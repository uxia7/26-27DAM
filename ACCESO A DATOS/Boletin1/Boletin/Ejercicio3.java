import java.io.File;
import java.io.FileReader;
import java.io.IOException;

public class Ejercicio3 {

    public static void main(String[] args) {

        File f1 = new File("archivo3.txt");

        char letra = 'a';
        char encontrado;
        int cont = 0;
        try (FileReader fr = new FileReader(f1)) {
            // while (fr.read() != -1) {
            //     encontrado = (char) fr.read();
            //     if (letra == encontrado) {
            //         cont++;
            //     }
            // }

            int caracter = fr.read();
            while(caracter != -1) {
                encontrado = (char)caracter;
                if(encontrado == letra) {
                    cont++;
                }
                caracter = fr.read();
            }
            System.out.println("Tu letra: " + letra + " aparecio un total de: " + cont);
        } catch (IOException e) {
            System.out.println("Fallo al leer el archivo indicado");
        }

    }
}
