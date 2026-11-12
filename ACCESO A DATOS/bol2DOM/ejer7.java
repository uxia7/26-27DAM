import java.util.Scanner;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NodeList;

public class ejer7 {
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

    public void anadirAtributo(Document doc) {

        Scanner sc = new Scanner(System.in);

        System.out.print("Dime el titulo de la peli: ");
        String tituloBuscar = sc.nextLine();

        System.out.print("Dime el nombre del atributo que le quieres poner: ");
        String nomeAtributo = sc.nextLine();

        System.out.print("Dime el valor del atributo: ");
        String valorAtributo = sc.nextLine();

        NodeList listaPeliculas = doc.getElementsByTagName("pelicula");
        

        for (int i = 0; i < listaPeliculas.getLength(); i++) {

            Element pelicula = (Element) listaPeliculas.item(i);

            String titulo = pelicula.getElementsByTagName("titulo").item(0).getTextContent();

            if (titulo.equals(tituloBuscar)) {
                
                if (!pelicula.hasAttribute(nomeAtributo)) {

                    pelicula.setAttribute(nomeAtributo, valorAtributo);

                    System.out.println("Atributo añadido correctamente");

                } else {
                    System.out.println("La pelicula ya tiene ese atributo");
                }
                break;
            } 

        }

    }

    public void eliminarAtributo(Document doc) {
        Scanner sc = new Scanner(System.in);

        System.out.print("Dime el titulo de la pelicula: ");
        String tituloBuscar = sc.nextLine();

        System.out.print("Dime el nombre del atributo que quieres eliminar: ");
        String nomeAtributo = sc.nextLine();

        NodeList listaPeliculas = doc.getElementsByTagName("pelicula");

        for (int i = 0; i < listaPeliculas.getLength(); i++) {

            Element pelicula = (Element) listaPeliculas.item(i);
            String titulo = pelicula.getElementsByTagName("titulo").item(0).getTextContent();

            if (titulo.equals(tituloBuscar)) {
                if (pelicula.hasAttribute(nomeAtributo)) {

                    pelicula.removeAttribute(nomeAtributo);

                    System.out.println("Atributo eliminado correctamente.");

                } else {
                    System.out.println("La pelicula no tiene ese atributo");
                }
                break;
            }

        }
    }


    public static void main(String[] args) {
        ejer7 e7 = new ejer7();
        Document doc1 = e7.creaArbol("peliculas.xml");
        
        
    }
}
