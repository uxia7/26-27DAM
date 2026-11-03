import java.io.File;

public class Ejercicio1 {

    public static void main(String[] args) {
        
        File f1 = new File("C:\\Users\\uxiap\\OneDrive\\Escritorio\\ACCESO A DATOS\\Boletin1");

        //mostrar de forma separada los directorios y ficheros que posee
        File[] contenido = f1.listFiles();

        //primero me encargo de mostrar los subdirectorios
        for(int i = 0; i < contenido.length; i++) {
            if(contenido[i].isDirectory()) {
                System.out.println("Subdirectorio: " + contenido[i].getName());
            } else if(contenido[i].isFile()) {
                System.out.println("Archivo: " + contenido[i].getName());
            }
        }

    }
}
