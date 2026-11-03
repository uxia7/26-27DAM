import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;

public class Ejercicio5 {

    public static void main(String[] args) {

        File f1 = new File("archivo5.txt");

        String cadenaEncontrar = "hola";
        try (Scanner sc = new Scanner(f1)) {
            ArrayList<String> listaPal = new ArrayList<>();
            while (sc.hasNext()) {
                listaPal.add(sc.nextLine());
            }

            for (int i = 0; i < listaPal.size(); i++) {
                if (cadenaEncontrar.equals(listaPal.get(i))) {
                    System.out.println("Linea: " + (i + 1) + " contiene la palabra: " + cadenaEncontrar);
                }

            }
        } catch (IOException e) {
            System.out.println("Error, al leer el archivo");
        }
    }
}
