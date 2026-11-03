import java.io.*;

public class Ejercicio1 {
    public static void main(String[] args) {

        File f1 = new File("C:\\Users\\uxiap\\OneDrive\\Escritorio\\ACCESO A DATOS");

        // leer caracter x caracter
        try (FileReader fr = new FileReader(f1)) {
            while (fr.read() != -1) {
                System.out.print(fr.read());
            }

        } catch (IOException e) {

        }

    }
}
