import java.io.FileNotFoundException;
import java.io.FileOutputStream;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NodeList;
import org.w3c.dom.bootstrap.DOMImplementationRegistry;
import org.w3c.dom.ls.DOMImplementationLS;
import org.w3c.dom.ls.LSOutput;
import org.w3c.dom.ls.LSSerializer;

public class ejer11 {

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

    public Document borrarPelicula(Document doc, String tituloBuscado) {

        NodeList peliculas = doc.getElementsByTagName("pelicula");

        for (int i = 0; i < peliculas.getLength(); i++) {

            Element pelicula = (Element) peliculas.item(i);

            String titulo = pelicula.getElementsByTagName("titulo")
                    .item(0)
                    .getTextContent();

            if (titulo.equals(tituloBuscado)) {

                pelicula.getParentNode().removeChild(pelicula);

                System.out.println("Película borrada");
                break;
            }
        }
        return doc;
    }

    public void grabarDOM(Document document, String ficheroSalida)
            throws ClassNotFoundException, InstantiationException, IllegalAccessException, FileNotFoundException {
        DOMImplementationRegistry registry = DOMImplementationRegistry.newInstance();
        DOMImplementationLS ls = (DOMImplementationLS) registry.getDOMImplementation("XML 3.0 LS 3.0");
        // Se crea un destino vacio
        LSOutput output = ls.createLSOutput();
        output.setEncoding("UTF-8");
        // Se establece el flujo de salida
        output.setByteStream(new FileOutputStream(ficheroSalida));
        // output.setByteStream(System.out);
        // Permite escribir un documento DOM en XML
        LSSerializer serializer = ls.createLSSerializer();
        // Se establecen las propiedades del serializador
        serializer.setNewLine("\r\n");

        serializer.getDomConfig().setParameter("format-pretty-print", true);
        // Se escribe el documento ya sea en un fichero o en una cadena de texto
        serializer.write(document, output);
        // String xmlCad=serializer.writeToString(document);
    }

    public static void main(String[] args) throws ClassNotFoundException, InstantiationException, IllegalAccessException, FileNotFoundException {
        ejer11 e11 = new ejer11();

        Document doc = e11.creaArbol("peliculas.xml");

        Document nuevo = e11.borrarPelicula(doc, "Matrix");

        e11.grabarDOM(nuevo, "peliculas_mod.xml");
    }
}
