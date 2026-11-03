import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class Ejercicio7 {

    /**
     * Procesar un archivo según una operación:
     * n -> contar líneas y palabras
     * A -> ordenar ascendente, sensible a mayúsculas/minúsculas
     * D -> ordenar descendente, sensible a mayúsculas/minúsculas
     * a -> ordenar ascendente, NO sensible a mayúsculas/minúsculas
     * d -> ordenar descendente, NO sensible a mayúsculas/minúsculas
     *
     * Todo escrito dentro del main, sin métodos aparte.
     */

    public static void main(String[] args) throws FileNotFoundException {

        // Datos de prueba: nombre del archivo y operación a realizar
        String nombreArchivo = "fichero1.txt";
        char operacion = 'A';

        // Leemos todas las líneas del archivo y las guardamos en una lista
        ArrayList<String> lineas = new ArrayList<String>();
        Scanner lector = new Scanner(new File(nombreArchivo));

        while (lector.hasNextLine()) {
            String linea = lector.nextLine();
            lineas.add(linea);
        }
        lector.close();

        // Según la operación, hacemos una cosa u otra
        if (operacion == 'n') {

            // Contamos líneas y palabras
            int numeroLineas = lineas.size();
            int numeroPalabras = 0;

            for (int i = 0; i < lineas.size(); i++) {
                String linea = lineas.get(i);
                String[] palabras = linea.split("\\s+");

                if (!linea.trim().isEmpty()) {
                    numeroPalabras = numeroPalabras + palabras.length;
                }
            }

            System.out.println("Archivo: " + nombreArchivo);
            System.out.println("Número de líneas: " + numeroLineas);
            System.out.println("Número de palabras: " + numeroPalabras);

        } else if (operacion == 'A') {

            // Orden ascendente, sensible a mayúsculas/minúsculas
            Collections.sort(lineas);

            String nombreNuevo = nombreArchivo.replace(".txt", "") + "_ascendente_A.txt";
            PrintWriter escritor = new PrintWriter(new File(nombreNuevo));

            for (int i = 0; i < lineas.size(); i++) {
                escritor.println(lineas.get(i));
            }
            escritor.close();

            System.out.println("Archivo creado: " + nombreNuevo);

        } else if (operacion == 'D') {

            // Orden descendente, sensible a mayúsculas/minúsculas
            Collections.sort(lineas);
            Collections.reverse(lineas);

            String nombreNuevo = nombreArchivo.replace(".txt", "") + "_descendente_D.txt";
            PrintWriter escritor = new PrintWriter(new File(nombreNuevo));

            for (int i = 0; i < lineas.size(); i++) {
                escritor.println(lineas.get(i));
            }
            escritor.close();

            System.out.println("Archivo creado: " + nombreNuevo);

        } else if (operacion == 'a') {

            // Orden ascendente, NO sensible a mayúsculas/minúsculas
            Collections.sort(lineas, String.CASE_INSENSITIVE_ORDER);

            String nombreNuevo = nombreArchivo.replace(".txt", "") + "_ascendente_a.txt";
            PrintWriter escritor = new PrintWriter(new File(nombreNuevo));

            for (int i = 0; i < lineas.size(); i++) {
                escritor.println(lineas.get(i));
            }
            escritor.close();

            System.out.println("Archivo creado: " + nombreNuevo);

        } else if (operacion == 'd') {

            // Orden descendente, NO sensible a mayúsculas/minúsculas
            Collections.sort(lineas, String.CASE_INSENSITIVE_ORDER);
            Collections.reverse(lineas);

            String nombreNuevo = nombreArchivo.replace(".txt", "") + "_descendente_d.txt";
            PrintWriter escritor = new PrintWriter(new File(nombreNuevo));

            for (int i = 0; i < lineas.size(); i++) {
                escritor.println(lineas.get(i));
            }
            escritor.close();

            System.out.println("Archivo creado: " + nombreNuevo);

        } else {
            System.out.println("Operación no reconocida: " + operacion);
        }
    }
}
