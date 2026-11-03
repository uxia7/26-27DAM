import java.io.File;
import java.io.FileReader;
import java.io.IOException;

public class Ejercicio4 {
    public static void main(String[] args) {

        File f1 = new File("archivo4.txt");

        //digamos que es la tabla ASCII
        //y cada indice representa un caracter del codigo ASCII
        int caracteres[] = new int[256];
        //sirve pero no coge todo tipo de caracteres desde simbolos hasta los chinos
        //se recomienda el uso de HashMap para menos costo de memoria y datos

        //vamos a leer caracter x caracter con lo cual vamos a necesita
        try(FileReader fr = new FileReader(f1)) {
            int caracter = fr.read();
            int caracterComun = 0;

            //se me olvido
            int apariciones = 0;

            while(caracter != -1) {
                // for (int i = 0; i < caracteres.length; i++) {
                //     caracteres[caracter]++;
                // }
                // caracter = fr.read();

                caracteres[caracter]++;
                caracter = fr.read();
            }

            for (int i = 0; i < caracteres.length; i++) {
                if(caracteres[i] > caracterComun) {
                    apariciones = caracteres[i];
                    caracterComun = i;
                }
            }

            System.out.println("Caracter mas usado: " + (char)caracterComun + "\nTotal apariciones: " + apariciones);

        } catch (IOException e) {
            System.out.println("Error al leer el archivo");
        }
    }
}
