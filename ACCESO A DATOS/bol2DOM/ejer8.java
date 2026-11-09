import java.io.FileNotFoundException;
import java.io.FileOutputStream;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.bootstrap.DOMImplementationRegistry;
import org.w3c.dom.ls.DOMImplementationLS;
import org.w3c.dom.ls.LSOutput;
import org.w3c.dom.ls.LSSerializer;

public class ejer8 {
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

    public Document anadirDepredador(Document doc) {
        Element raiz = doc.getDocumentElement();

        // asi es como se crea un elemento pelicula
        Element novaPelicula = doc.createElement("pelicula");
        novaPelicula.setAttribute("año", "1987");
        novaPelicula.setAttribute("genero", "accion");
        novaPelicula.setAttribute("idioma", "en");

        // titulo
        Element titulo = doc.createElement("titulo");
        titulo.setTextContent("Depredador");
        novaPelicula.appendChild(titulo);

        // director
        Element director = doc.createElement("director");
        Element nombre = doc.createElement("nombre");
        nombre.setTextContent("John");
        Element apellido = doc.createElement("apellido");
        apellido.setTextContent("Tiernan");

        director.appendChild(nombre);
        director.appendChild(apellido);
        novaPelicula.appendChild(director);

        // ahora añadimos la pelicula al raiz, en este caso no hay ninguna otra manera,
        // para añadir o borrar en xml siempre hay que hacerlo con elementos de
        // appendChild o getParent o asi porque no queda de otra porque vamos a movernos
        // con cosas que aun no existen y con Element solo, no basta
        raiz.appendChild(novaPelicula);

        return doc;
        // //guardar en un nuevo xml
        // try {
        // TransformerFactory factory = TransformerFactory.newInstance();
        // Transformer transformer = factory.newTransformer();
        // transformer.setOutputProperty(OutputKeys.INDENT, "yes");
        // transformer.transform(new DOMSource(doc), new StreamResult(new
        // File("filmoteca_modificada.xml")));
        // System.out.println("Nova película engadida e gardada en
        // filmoteca_modificada.xml");
        // } catch (Exception e) {
        // System.out.println("Erro gardando o arquivo: " + e.getMessage());
        // }
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
        ;
        serializer.getDomConfig().setParameter("format-pretty-print", true);
        // Se escribe el documento ya sea en un fichero o en una cadena de texto
        serializer.write(document, output);
        // String xmlCad=serializer.writeToString(document);
    }

    public static void main(String[] args) throws ClassNotFoundException, InstantiationException, IllegalAccessException, FileNotFoundException {
        ejer8 e8 = new ejer8();
        Document doc1 = e8.creaArbol("peliculas.xml");

        Document nuevo = e8.anadirDepredador(doc1);

        e8.grabarDOM(nuevo, "peliculas_mod.xml");
    }
}
