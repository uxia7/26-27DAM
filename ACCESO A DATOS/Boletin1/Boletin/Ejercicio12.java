import java.io.File;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.util.Scanner;

public class Ejercicio12 {
    /*
     * Dado un fichero de caracteres, se guarda en cada línea el DNI de una
     * persona (8 dígitos + 1
     * letra). Usando exclusivamente RandomAccessFile, elabora un programa que
     * indicando el
     * número de línea devuelva el DNI situado en esa posición. Debes acceder a la
     * línea sin
     * necesidad de haber leído en memoria todo el fichero
     */

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        try {
            File fich = new File("ejercicio12.txt");

            /*
             * la clase RandomAccess es todo lo contrario a lo visto hasta ahora
             * no funciona de forma secuencial si no que accede a un punto enn concreto del
             * fichero que nosotros le indiquemos
             * funciona con bytes
             */
            RandomAccessFile raf = new RandomAccessFile(fich, "r");

            System.out.println("En que linea vas a querer empezar a leer?");
            int numUser = sc.nextInt();
            /*
             * cada linea tiene un DNI que son 8 caracteres + 1 que es la letra
             * basicamente cada linea son 9 caracteres a leer
             * cada caracter representa un byte
             * hay que tener en cuenta que el retorno de carro, tambien es un caracter con
             * lo cual tambien es un byte entonces en cad fila va a haber un total de 10
             * caracteres
             * un total de 10 bytes, asi que hay que teniendo eso en cuenta,
             */
            int linea = (numUser - 1) * 11;

            raf.seek(linea);

            String dni = raf.readLine();

            System.out.println(dni);

            // se puede hacer asi o leyendo byte a byte con el for, pero como solo quiero
            // leer la linea, ya lo hago directamente asi como hice arriba 


            // for (int i = caracter; i < raf.length(); i++) {
            // // como cada linea son 10, seria siempre el numero que me da el usuario
            // // numUser lo multiplico por 10 para obtener el final de la linea
            // // como quiero leer el comienzo es solo restarle 9 a esa cantidad

            // System.out.print(raf.readLine());
            // System.out.println("");
            // }

            // raf.seek(posicion);

            // while (raf.getFilePointer() < raf.length()) {
            // System.out.println(raf.readLine());
            // }

        } catch (IOException e) {
            System.out.println("Hubo un error con el archivo");
        }

    }
}
