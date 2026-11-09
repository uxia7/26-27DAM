import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.transform.OutputKeys;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NodeList;
import org.w3c.dom.bootstrap.DOMImplementationRegistry;
import org.w3c.dom.ls.DOMImplementationLS;
import org.w3c.dom.ls.LSOutput;
import org.w3c.dom.ls.LSSerializer;

public class ejer10 {

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

    public Document anadirDirector(Document doc) {

        NodeList listaPeliculas = doc.getElementsByTagName("pelicula");

        for (int i = 0; i < listaPeliculas.getLength(); i++) {

            Element pelicula = (Element) listaPeliculas.item(i);

            String titulo = pelicula.getElementsByTagName("titulo")
                    .item(0)
                    .getTextContent();

            if (titulo.equalsIgnoreCase("Dune")) {

                Element nuevoDirector = doc.createElement("director");

                Element nombre = doc.createElement("nombre");
                nombre.setTextContent("Alfredo");

                Element apellido = doc.createElement("apellido");
                apellido.setTextContent("Landa");

                nuevoDirector.appendChild(nombre);
                nuevoDirector.appendChild(apellido);

                pelicula.appendChild(nuevoDirector);

                System.out.println("Director añadido");
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
        ejer10 e10 = new ejer10();

        Document doc1 = e10.creaArbol("peliculas.xml");

        Document nuevo = e10.anadirDirector(doc1);

        e10.grabarDOM(nuevo, "peliculas_mod.xml");

    }
}
