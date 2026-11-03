import java.io.*;

public class Prueba1 {
    public static void main(String[] args) {
        /*
         * Muestra, por separado, la lista de ficheros y directorios de un directorio
         * dado.
         */

        File f1 = new File("C:\\Users\\uxiap\\OneDrive\\Escritorio\\ACCESO A DATOS");

        File[] archivos_Subs = f1.listFiles();

        for (int i = 0; i < archivos_Subs.length; i++) {
            if (archivos_Subs[i].isDirectory()) {
                System.out.println(archivos_Subs[i].getName());
            } else if (archivos_Subs[i].isFile()) {
                System.out.println(archivos_Subs[i].getName());
            } else {
                System.out.println("Error en la lectura  ");
            }
        }
    }

    public static void inspeccionarDatos() {
        
    }
}