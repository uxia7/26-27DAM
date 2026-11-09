import java.util.Scanner;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

public class ejer5 {
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

    public void mostrarPeliculasConMaisDeNDirectores(Document doc) {
        if (doc == null) {
            System.out.println("El doc DOM es nulo");
            return;
        }

        Scanner sc = new Scanner(System.in);
        System.out.print("Dime el numero directores que quieres: ");
        int n = sc.nextInt();

        NodeList listaPeliculas = doc.getElementsByTagName("pelicula");
        boolean atopadas = false;

        for (int i = 0; i < listaPeliculas.getLength(); i++) {
            Node nodoPelicula = listaPeliculas.item(i);

            // if (nodoPelicula.getNodeType() == Node.ELEMENT_NODE) {
                Element pelicula = (Element) nodoPelicula;

                // Obtemos o título da película
                String titulo = pelicula.getElementsByTagName("titulo").item(0).getTextContent();

                // Obtemos o número de directores
                NodeList directores = pelicula.getElementsByTagName("director");
                int numDirectores = directores.getLength();

                // Se ten máis de n directores, amosámola
                if (numDirectores > n) {
                    atopadas = true;
                    System.out.println("Película: " + titulo);
                    System.out.println("Número de directores: " + numDirectores);
                    System.out.println("Directores:");

                    for (int j = 0; j < directores.getLength(); j++) {
                        Element director = (Element) directores.item(j);
                        String nombre = director.getElementsByTagName("nombre").item(0).getTextContent();
                        String apellido = director.getElementsByTagName("apellido").item(0).getTextContent();
                        System.out.println("   - " + nombre + " " + apellido);
                    }

                    // System.out.println("----------------------------------");
                }
            // }
        }

        if (!atopadas) {
            System.out.println("No hay peliculas con mas de " + n + " directores");
        }
    }

    public static void main(String[] args) {
        ejer5 e5 = new ejer5();
        Document doc1 = e5.creaArbol(".\\peliculas.xml");
        Document doc2 = e5.creaArbol("https://www.w3schools.com/xml/cd_catalog.xml");
    }

}
