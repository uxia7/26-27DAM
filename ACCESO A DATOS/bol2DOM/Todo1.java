import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

public class Todo1 {
    // EJERCICIO 1
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

    // EJERCICIO 2
    public void mostrarTituloPelis(Document doc) {
        NodeList titulos = doc.getElementsByTagName("titulo");
        // obtenemos la lista de todos los titulos de las peliculas y lo hacemos
        // cogiendo el nombre de la etiqueta que contiene ese #text que queremos mostrar

        // recorremos esa coleccion de Elements que nos devuelve la funcion
        for (int i = 0; i < titulos.getLength(); i++) {
            Element elemento = (Element) titulos.item(i);
            // cada nodo de la lista lo casteamos a un tipo Element para poder acceder a
            // funciones interesantes que son mas directas

            System.out.println(elemento.getTextContent());
            // a medida que se vayan guardando esos Element dentro de esa variable entonces
            // con la funcion getTextContent() vamos enseñando el contenido texto que hay
            // dentro de ese elemento de titulo
        }

        // otra manera de hacerlo seria accediendo al hijo del nodo titulo y luego a
        // getNodeValue() que seria la funcion encargada de mostra el contendio texto de
        // ese nodo

    }

    // EJERCICIO 3
    public void infoPelis(Document doc) {
        NodeList peliculas = doc.getElementsByTagName("pelicula");
        for (int i = 0; i < peliculas.getLength(); i++) {
            Element pelicula = (Element) peliculas.item(i); // .getParentNode()

            NodeList titulos = pelicula.getElementsByTagName("titulo");
            // for(int j = 0; j < titulos.getLength(); j++){
            // Element titulo = (Element)titulos.item(j);
            // }
            String titulo = titulos.item(0).getTextContent();
            System.out.println("Titulo: " + titulo);

            NodeList directores = pelicula.getElementsByTagName("director");
            for (int j = 0; j < directores.getLength(); j++) {
                Element director = (Element) directores.item(j);

                String nombre = director.getElementsByTagName("nombre").item(0).getTextContent();
                String apellido = director.getElementsByTagName("apellido").item(0).getTextContent();

                System.out.println("Director: " + nombre + " " + apellido);
            }

            // ahora falta obtener el genero de la pelicula
            String genero = pelicula.getAttribute("genero");
            System.out.println("Genero: " + genero);

        }
    }

    // EJERCICIO 4:
    //necesito recursividad si o si, con lo cual
    //recursividad es lo que se usa para llamar a la propia funcion dentro de si
    /*en este caso no es asi, pero se sigue conociendo como recursividad
    primero haces la funcion mostrar arbol que es una mini funcion
    la cual nos permitira 
     */
    public void recorrerArbol(Document doc) {
        // necesito recorrer el arbol y mostrar todos los nodos desde el raiz hasta abajo
        if(doc == null) {
            System.out.println("El documento DOM es nulo");
            return;
        }

        Node raiz = doc.getDocumentElement();
    }

    public static void main(String[] args) {
        Todo1 td = new Todo1();
        Document doc1 = td.creaArbol(".\\peliculas.xml");
        // td.mostrarTituloPelis(doc1);
        // td.infoPelis(doc1);
        Node raiz = doc1.getDocumentElement();
        Node raiz2 = null;
        td.recorrerArbol(doc1);

        td.infoPelis(doc1);

    }
}
