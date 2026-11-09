import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Document;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

public class ejer4 {
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

    public void mostrarNodos(Document doc) {
        if (doc == null) {
            System.out.println("El docoumento DOM es nulo");
            return;
        }

        // Empezamos desde o nodo raíz (filmoteca)
        Node raiz = doc.getDocumentElement();
        recorrerNodos(raiz, 0);
    }

    // Método auxiliar recursivo interno
    private void recorrerNodos(Node nodo, int nivel) {
        // Mostrar o tipo de nodo e o seu nome, con sangrado segundo o nivel
        System.out.println(" ".repeat(nivel * 3) + nodo.getNodeType() + " " + nodo.getNodeName());

        // Obtemos os fillos do nodo actual
        NodeList hijos = nodo.getChildNodes();

        // Recorremos os fillos, si los hai
        for (int i = 0; i < hijos.getLength(); i++) {
            Node hijo = hijos.item(i);
            recorrerNodos(hijo, nivel + 1);
        }
    }

    public static void main(String[] args) {
        ejer4 e4 = new ejer4();
        Document doc1 = e4.creaArbol(".\\peliculas.xml");
        Document doc2 = e4.creaArbol("https://www.w3schools.com/xml/cd_catalog.xml");

        e4.mostrarNodos(doc1);
        e4.recorrerNodos(doc1, 2);
    }
}
