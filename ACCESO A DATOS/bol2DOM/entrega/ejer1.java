import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

public class ejer1 {

    // esta funcion es aquella que tenemos que tener para poder crear el arbol DOM y
    // poder acceder a sus atributos
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

    // ahora de forma adicional creamos un metodo el cual nos mostrara por pantalla
    // el arbol Dom que se ha pedido en el ejercicio que se crease

    public void mostrarArbol(Document doc) {
        NodeList listaPeliculas = doc.getElementsByTagName("pelicula");

        for (int i = 0; i < listaPeliculas.getLength(); i++) {
            Node nodoPelicula = listaPeliculas.item(i);

            if (nodoPelicula.getNodeType() == Node.ELEMENT_NODE) {
                Element elementoPelicula = (Element) nodoPelicula;

                // Mostrar atributo "genero"
                if (elementoPelicula.hasAttribute("genero")) {
                    String genero = elementoPelicula.getAttribute("genero");
                    System.out.println("genero: " + genero);
                }

                // Mostrar hijos: Título, Director, Estreno
                NodeList hijos = elementoPelicula.getChildNodes();
                for (int j = 0; j < hijos.getLength(); j++) {
                    Node hijo = hijos.item(j);

                    if (hijo.getNodeType() == Node.ELEMENT_NODE) {
                        String nombreNodo = hijo.getNodeName();
                        String valor = hijo.getTextContent().trim();
                        System.out.println(nombreNodo + ": " + valor);
                    }
                }
            }
        }
    }

    public static void main(String[] args) {
        // tenemos que llamar a los metodos como siempre y para ello hay que crear el
        // objeto
        ejer1 e1 = new ejer1();
        Document doc1 = e1.creaArbol(".\\peliculas.xml");
        Document doc2 = e1.creaArbol("https://www.w3schools.com/xml/cd_catalog.xml");

        e1.mostrarArbol(doc1);
    }
}
