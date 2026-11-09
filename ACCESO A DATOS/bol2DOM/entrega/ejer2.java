import java.io.File;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

public class ejer2 {
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

    public void titulosPelis(Document doc) {
        // es void porque no vas a devolver nada simplemente vas a mostrar en pantalla
        // las cosas

        NodeList peliculas = doc.getElementsByTagName("pelicula");

        System.out.println("Titulos de las peliculas: ");

        for (int i = 0; i < peliculas.getLength(); i++) {
            // porque vamos a recorrer el NodeList que es una lista de los elementos Node
            // del xml
            // con lo cual en esta lista estaremos recorriendo todas las etiquetas peliculas
            // y nosotros tenemos que entrar y coger sus hijos titulo
            Node pelicula = peliculas.item(i);
            // cogemos una pelicula al completo
            if (pelicula.getNodeType() == Node.ELEMENT_NODE) {
                Element peliEnSi = (Element) pelicula;
                //getFirstChild() en lugar de item(0)
                String titulo = peliEnSi.getElementsByTagName("titulo").item(0).getTextContent();
                System.out.println("Titulo: " + titulo);
            }
        }

    }

    public static void main(String[] args) {
        ejer2 e2 = new ejer2();
        // File f = new File(".\\peliculas.xml");
        // System.out.println("Archivo existe: " + f.exists());

        Document doc1 = e2.creaArbol(".\\peliculas.xml");
        Document doc2 = e2.creaArbol("https://www.w3schools.com/xml/cd_catalog.xml");

        e2.titulosPelis(doc1);

    }
}