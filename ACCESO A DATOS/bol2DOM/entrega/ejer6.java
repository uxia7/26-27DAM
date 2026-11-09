import java.util.HashSet;
import java.util.Set;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

public class ejer6 {

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

    public void mostrarXeneros(Document doc) {
        if (doc == null) {
            System.out.println("El doc DOM es nulo");
            return;
        }

        // Usamos un Set para gardar os xéneros sen repetir
        Set<String> xeneros = new HashSet<>();

        // Obtemos todas as películas
        NodeList listaPeliculas = doc.getElementsByTagName("pelicula");

        // Recorremos cada película e recollemos o seu atributo "genero"
        for (int i = 0; i < listaPeliculas.getLength(); i++) {
            Node nodoPelicula = listaPeliculas.item(i);

            if (nodoPelicula.getNodeType() == Node.ELEMENT_NODE) {
                Element pelicula = (Element) nodoPelicula;
                String genero = pelicula.getAttribute("genero");

                if (genero != null && !genero.isEmpty()) {
                    xeneros.add(genero);
                }
            }
        }

        // Amosamos o resultado
        System.out.println("El numero total de generos que hay es de: " + xeneros.size());
        System.out.println("Generos:");

        for (String g : xeneros) {
            System.out.println(" - " + g);
        }
    }

    public static void main(String[] args) {
        ejer6 e6 = new ejer6();
        Document doc1 = e6.creaArbol(".\\peliculas.xml");
        Document doc2 = e6.creaArbol("https://www.w3schools.com/xml/cd_catalog.xml");
    }

}
