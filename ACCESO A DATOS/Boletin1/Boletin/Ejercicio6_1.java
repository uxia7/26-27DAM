import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Scanner;

public class Ejercicio6_1 {
    /*
     * Crea un programa que realice las siguientes acciones:
     * ➢ Dividir un fichero en función de:
     * • De un número n de caracteres (en cada fichero generado debe poseer n
     * caracteres).
     * • De un número l de líneas (en cada fichero generado debe poseer l l íneas).
     * ➢ Unir ficheros: dada una lista de ficheros generará un nuevo fichero que
     * resultara de la unión de los anteriores.
     *
     */

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int opcion = 0;

        System.out.println("Menu");
        System.out.println("1)Dividir fichero\n2)Unir ficheros\n3)Salir");
        opcion = sc.nextInt();

        switch (opcion) {
            case 1:
                System.out.println("Vamos a dividir ficheros");
                System.out.println("1)Dividir segun numero de caracteres\n2)Dividir segun numero de lineas");
                int opcion2 = sc.nextInt();
                File fichero = new File("ejercicio6_1.txt");
                switch (opcion2) {
                    case 1:
                        System.out.println("Vamos a dividir por caracteres");

                        /*
                         * para poder dividir por caracteres hay que leerlo con el FileReader
                         * ya que es la clase que nos permite leer caracter x cararcter
                         * o como en este caso podemos leer un conjunto de caracteres
                         * y guardarlos en un array de ese tamaño y luego simplemente ir leyendo
                         * hasta que lleguemos al limite, limpiarlo y volver a empezar
                         * hacemos la manera que mas nos guste
                         * IMPORTANTE
                         * tambien hay que tener en cuenta que los retorno de carro cuentan como
                         * caracteres tambien
                         */

                        // primero manejamos los flujos a mano y luego vemos si es buena idea hacer
                        // try-with-resources

                        try {
                            // aunque no usemos el try-resources, el FileReader lanza la excepcion de
                            // FileNotFound
                            // que la podemos manejar con la excepcion global de ficheros que es IOException
                            FileReader fr = new FileReader(fichero);

                            // los caracteres se representan por numeros, por ejemplo el fin de una lectua
                            // por caracteres es -1

                            // FileWriter al igual que el Print si el archivo no existe lo crea
                            // CUIDADO: los que no crean los archivos son los Reader, ya que ellos tienen
                            // que leer algo que existe

                            FileWriter fw = new FileWriter("archivo.txt");
                            int caracter = fr.read();
                            int cont = 0;

                            int numArchivos = 1;

                            // le pedimos al usuario el numero maximo de caracteres que ira en cada fichero
                            System.out.println("Por cuantos caracteres quieres dividir el fichero?");
                            int maximo = sc.nextInt();

                            // int[] cantCaracteres = new int[maximo];

                            while (caracter != -1) {
                                fw.write((char) caracter);
                                cont++;
                                if (cont == maximo) {
                                    fw.close();
                                    cont = 0;
                                    fw = new FileWriter("archivo" + numArchivos + ".txt");
                                    numArchivos++;
                                }
                                caracter = fr.read();
                            }

                            /*
                             * cuanto ya estamos al final del todo, habra veces en las que los caracteres
                             * restantes que queden, no cumplan con el if, entonces
                             */
                            fw.close();
                            fr.close();

                        } catch (IOException e) {
                            System.out.println("Error" + e.getMessage());
                        }

                        break;

                    case 2:
                        System.out.println("Vamos a dividir por lineas");
                        try {
                            Scanner lector = new Scanner(fichero);


                            PrintWriter pw = new PrintWriter("archivo.txt");
                            String linea = lector.nextLine();
                            int cont = 0;

                            int numArchivos = 1;

                            // le pedimos al usuario el numero maximo de caracteres que ira en cada fichero
                            System.out.println("Por cuantos caracteres quieres dividir el fichero?");
                            int maximo = sc.nextInt();

                            // int[] cantCaracteres = new int[maximo];

                            while (lector.hasNextLine()) {
                                pw.write(linea);
                                cont++;
                                if (cont == maximo) {
                                    pw.close();
                                    cont = 0;
                                    pw = new PrintWriter("archivo" + numArchivos + ".txt");
                                    numArchivos++;
                                }
                                linea = lector.nextLine();
                            }
                            pw.close();
                            lector.close();

                        } catch (IOException e) {
                            System.out.println("Error" + e.getMessage());
                        }
                        break;

                    default:
                        System.out.println("Opcion no valida en el menu");
                        break;
                }
                break;

            case 2:
                System.out.println("Vamos a unir ficheros");

                int cantFicheros = 0;
                System.out.println("Cuantos ficheros vas a querer unir?");
                cantFicheros = sc.nextInt();

                break;

            case 3:
                System.out.println("Saliendo");
                break;

            default:
                System.out.println("Opcion no valida del menu");
                break;
        }
    }
}
