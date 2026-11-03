import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;

public class Ejercicio8 {

    public static void main(String[] args) {

        // Primero hago la copia sin el buffer
        try (FileInputStream entrada1 = new FileInputStream("original.data");
                FileOutputStream salida1 = new FileOutputStream("copiaSin.data")) {

            int byteLeido;
            while ((byteLeido = entrada1.read()) != -1) {
                salida1.write(byteLeido);
            }

        } catch (IOException e) {
            System.out.println("Error: " + e.getMessage());
        }

        //Ahora realizo la copia con el buffer
        //puse un buffer de un tamaño de por ejemplo 1024 bytes
        try {
            FileInputStream entrada2 = new FileInputStream("originalBuffer.data");
            FileOutputStream salida2 = new FileOutputStream("copiaCon.data");

            byte[] buffer = new byte[1024];
            int leidos;

            while ((leidos = entrada2.read(buffer)) != -1) {
                salida2.write(buffer, 0, leidos);
            }

            entrada2.close();
            salida2.close();

        } catch (IOException e) {
            System.out.println("Error: " + e.getMessage());
        }

        /*
         * --------------------------------------------------------------
         * Cual es mas eficiente y por qué?
         * 
         * La copia con el buffer es más eficiente y el motivo es muy sencillo.
         * Sin el buffer leo y escribo byte a byte lo que produce es muchas llamadas al SO,
         * lo cual lo vuelve un proceso lento y tedioso para el programa. 
         * 
         * Por otro lado con el buffer leo y escribo bloques grandes, como en el ejemplo que hice de 1024 bytes
         * en cada operacion que se realiza, lo cual, reduce las muchas llamadas al SO y se acelera la copia de este
         * 
         * En resumen, copiar con buffer es más rápido y eficaz porque es un proceso de bloques de bytes de golpe
         * todo lo contrario a sin el buffer
         * --------------------------------------------------------------
         */
    }
}
