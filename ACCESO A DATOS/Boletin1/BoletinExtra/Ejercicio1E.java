import java.io.File;

/**
 * Ejercicio1E
 */
public class Ejercicio1E {

    public void listarExtensiones(File carpeta) {
        // comprobamos si lo pasado como parametro
        // es o no es una carpeta y lo hacemos con el
        // isDirectory()
        if (!carpeta.isDirectory()) {
            System.out.println("Lo pasado no es una carpeta");
        } else {
            // hago un array de tipo File
            // le paso la lista de los archivos que tiene
            File[] archivos = carpeta.listFiles();
            // ahora hay que recorrerlo y vamos viendo las extensiones
            for (int i = 0; i < archivos.length; i++) {
                if (archivos[i].isFile()) {
                    // si cada elemento de dentro del array es un archivo enton

                    // String[] extension = archivos[i].getName().split(".");

                    // ahora que tenemos la extension pillada
                    // sabemos que la extension corresponderia al segundo elemento del array

                    // cogemos los nombres de cada carpeta y archivo
                    // pero como ya nos hemos asegurado de que son solo archivos con el if
                    // entonces podemos coger el nombre y apañar la extension
                    String nombre = archivos[i].getName();
                    // lastIndexOf()
                    // es una funcion de String
                    // devuelve la posicion en la que se encuentra el char o string que yo le paso
                    // como parametro
                    // 
                    int punto = nombre.lastIndexOf('.');

                    // String ext = (punto != -1) ? nombre.substring(punto + 1) : "";

                }
            }
        }
    }

    public static void main(String[] args) {

        Ejercicio1E ej1 = new Ejercicio1E();

        File rutaCarpeta = new File(
                "C:\\Users\\uxiap\\OneDrive\\Escritorio\\26-27DAM\\ACCESO A DATOS\\Boletin1\\Boletin\\Ejercicio6");
        ej1.listarExtensiones(rutaCarpeta);
    }
}