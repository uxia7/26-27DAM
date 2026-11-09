import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NodeList;

public class ejer3 {
    public Document creaArbol(String ruta) {
        Document doc = null;
        try {
            DocumentBuilderFactory factoria = DocumentBuilderFactory.newInstance();
            factoria.setIgnoringComments(true);
            DocumentBuilder builder = factoria.newDocumentBuilder();
            doc = builder.parse(ruta);
        } catch (Exception e) {
            System.out.println("Error generando el árbol DOM: " + e.getMessage());
        }
        return doc;
    }

    public void pelisDire(Document doc) {
        NodeList peliculas = doc.getElementsByTagName("pelicula");
        // tenemos que coger la lista de todas las peliculas que hay en el xml

        // como es una lista, tenemos que recorrerlo como corresponde que es con el for
        for (int i = 0; i < peliculas.getLength(); i++) {

            Element pelicula = (Element) peliculas.item(i);

            String titulo = pelicula.getElementsByTagName("titulo").item(0).getTextContent();
            String genero = pelicula.getAttribute("genero");

            System.out.println("Titulo: " + titulo);
            System.out.println("Genero: " + genero);

            // ahora el tema de los directores es que en los directores hay dos hijos dentro
            // que son nombre y apellidos y a veces hay dos directores en dentro de uno
            // solo, con lo cual ya no tenemos un elemento en si, tenemos una lista de
            // directores con sus elementos entonces tenemos que recorrerlo dentro de este
            // array porque es el padre y para poder acceder y crear una lista donde ir
            // guardando todos los elementos a medida que se vayan guardando
            NodeList directores = pelicula.getElementsByTagName("director");
            for (int j = 0; j < directores.getLength(); j++) {
                Element director = (Element) directores.item(j);

                String nombre = director.getElementsByTagName("nombre").item(0).getTextContent();
                String apellido = director.getElementsByTagName("apellido").item(0).getTextContent();
                
                System.out.println("Director: " + nombre + " - " + apellido);
            }
        }
    }

    public static void main(String[] args) {
        ejer3 e3 = new ejer3();
        Document doc1 = e3.creaArbol(".\\peliculas.xml");
        Document doc2 = e3.creaArbol("https://www.w3schools.com/xml/cd_catalog.xml");

        e3.pelisDire(doc1);
    }
}
