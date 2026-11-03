import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.IOException;

public class Ejercicio11 {

    public static void main(String[] args) {

        // copia con bufferinput y output
        try (BufferedInputStream bis = new BufferedInputStream(new FileInputStream("archivo100MB.data"));
                BufferedOutputStream bos = new BufferedOutputStream(new FileOutputStream("copiaBuffered.data"))) {

            int dato1;
            while ((dato1 = bis.read()) != -1) {
                bos.write(dato1);
            }

        } catch (IOException e) {
            System.out.println("Error: " + e.getMessage());
        }

        // copia con fileinput y output con diferentes tamaños de buffer
        int[] tamanos = { 10, 100, 1000, 5000, 10000, 50000, 100000 };
        try (FileInputStream fis2 = new FileInputStream("archivo100MB.data");
            FileOutputStream fos2 = new FileOutputStream("copiaBuffer.data");) {

            for (int tam : tamanos) {

                byte[] buffer = new byte[tam];
                int leidos;

                while ((leidos = fis2.read(buffer)) != -1) {
                    fos2.write(buffer, 0, leidos);
                }
            }

        } catch (IOException e) {
            System.out.println("Error: " + e.getMessage());
        }

        /*
         * -------------------------------------------------------------------------
         * Cual es mejor y por qué?
         *
         * BufferedInputStream y BufferedOutputStream son más eficientes.
         * Esto se debe a que los buffered ya tienen un buffer interno optimizado y con bastante tamaño en si
         * lo que reduce las llamadas al SO En cambio, cuando usamos FileInputStream FileOutputStream 
         * con buffers pequeños la copia es mucho mas lenta porque se realizan muchas mas llamadas a las operaciones 
         * lectura / escritura. Pero cuando esos buffers de los Files aumentan a tamaños más grandes
         * la eficiendcia mejora, pero aun así BufferedInputStream suele ser más rápido 
         * debido a la implementacion de ese buffer optimizado internamente en su clase. 
         * 
         * En resumen, BufferedInputStream/BufferedOutputStream es lo más eficiente y
         * FileInputStream/FileOutputStream con buffer grande también es rápido, pero este
         * siempre va a depender del tamaño que se elija, con lo cual, siempre va a variar y no va a ser 
         * algo optimo y fijo como el Buffered
         * -------------------------------------------------------------------------
         */
    }
}
