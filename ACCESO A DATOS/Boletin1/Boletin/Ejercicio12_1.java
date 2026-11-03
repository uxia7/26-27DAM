import java.io.RandomAccessFile;
import java.util.Scanner;

public class Ejercicio12_1 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.print("Introduce el número de línea: ");
        int linea = sc.nextInt();

        try {
            RandomAccessFile fichero = new RandomAccessFile("dnis.txt", "r");

            // Tamaño de cada línea: 9 caracteres DNI + '\n'
            int tamLinea = 10;

            // Posicionarse en la línea deseada
            fichero.seek((linea - 1) * tamLinea);

            // Leer los 9 caracteres del DNI
            String dni = "";
            for (int i = 0; i < 9; i++) {
                dni += (char) fichero.read();
            }

            System.out.println("DNI encontrado: " + dni);

            fichero.close();

        } catch (Exception e) {
            System.out.println("Error: " + e.getMessage());
        }

        sc.close();
    }
}
