import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Document;

public class Ejercicio3 {
    /*
     * Crea un método que mostre todas as películas xunto co nome e apelido do
     * seu/os seus directores ademais do xénero ao que pertence.
     */

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

    public void infoPelis(Document dom) {
        
    }

}
