import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.Scanner;

public class Ejercicio7_1 {
    /*
     * Escribir un método que reciba dos parámetros: el primero será el nombre de un
     * archivo y el segundo una operación al realizar (para ordenar se puede usar la
     * clase Collections) siendo estas:
     */

    public static void menuFicheros(File nomFich, String opcion) {
        /*
         * ➢ Opción n: contar el número de líneas y palabras del archivo.
         * ➢ Opción D: crear un nuevo archivo con las líneas del archivo inicial
         * ordenadas
         * forma descendente siendo esta ordenación sensible al caso.
         * ➢ Opción a: crear un nuevo archivo con las líneas del archivo inicial
         * ordenadas
         * forma ascendente siendo la ordenación no sensible al caso.
         * ➢ Opción d: crear un nuevo archivo con las líneas del archivo inicial
         * ordenadas
         * forma descendente siendo la ordenación no sensible al caso.
         */

        // no podemos poner un do-while en este menu
        // porque al no volver a hacer peticion de datos
        switch (opcion) {
            case "n":
                System.out.println("Vamos a contar las lineas y palabras del archivo");
                /*
                 * si que se puede usar try-withresources pero es mas comodo sin el porque
                 * tengo que contar lineas y palabras a la vez
                 * con lo cual se puede leer dos veces un mismo archivo pero
                 * tengo que cerrarlo para poder volver abrirlo
                 */
                if (nomFich.length() == 0) {
                    System.out.println("El fichero está vacio, vuelve a intentarlo");
                } else {
                    try {
                        Scanner lector = new Scanner(nomFich);

                        System.out.println("Primero vamos a ver cuantas palabras tiene ese fichero");
                        int cont = 0;
                        String palabras = lector.next();
                        while (lector.hasNext()) {
                            cont++;
                            palabras = lector.next();
                        }
                        System.out.println("Este fichero tiene un total de: " + cont + " palabras");

                        lector.close();

                        lector = new Scanner(nomFich);
                        System.out.println("Ahora vamos a contar lineas del fichero");
                        int contLineas = 0;
                        String linea = lector.nextLine();
                        while (lector.hasNextLine()) {
                            contLineas++;
                            linea = lector.nextLine();
                        }
                        System.out.println("Este fichero tiene un total: " + contLineas + " lineas");

                        lector.close();

                    } catch (FileNotFoundException e) {
                        System.out.println("No se encontro el archivo señalado: " + e.getMessage());
                    }
                }
                break;
            /*
             * ➢ Opción A: crear un nuevo archivo con las líneas del archivo inicial
             * ordenadas
             * forma ascendente siendo esta ordenación sensible al caso.
             */
            case "A":
                System.out.println("Vamos a crear un nuevo archivo con las lineas del archivo original (ascedente y SC)");

                try {
                    PrintWriter pw = new PrintWriter("ejercicio1_caseA.txt");

                }

                break;

            case "D":

                break;
            case "a":

                break;
            case "d":

                break;
            case "S":
                System.out.println("Saliendo...");
                break;

            default:
                System.out.println("Opcion invalida, no está dentro del menu");
                break;
        }
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Dime el nombre del fichero");
        File nomFich = new File(sc.nextLine());
        while (!nomFich.exists() || !nomFich.isFile()) {
            System.out.println("El nombre del fichero, no existe, pasa la ruta o el nombre del fichero otra vez");
            nomFich = new File(sc.nextLine());
        }

        String[] opciones = { "n", "A", "D", "a", "d", "S" };
        // String opcionFinal;
        System.out.println(
                "Ahora dime la opcion que quieres:\nn)Contar palabras o lineas\nA)Nuevo archivo ascendente SC\nD)Nuevo archivo descendente SC\na)Nuevo archivo ascendente NSC\nd)Nuevo archivo descendente NSC\nS)Salir");
        String opcionTemp = sc.nextLine();

        int indice = opciones[0].indexOf(opcionTemp);
        while (indice == -1) {
            System.out.println("Opcion incorrecta, no existe en el menu, vuelve a decirme otra");
            opcionTemp = sc.nextLine();
            indice = opciones[0].indexOf(opcionTemp);
        }

        menuFicheros(nomFich, opcionTemp);

        // for(int i = 0; i < opciones.length; i++) {
        // while(!opciones[i].equals(opcionTemp)) {
        // System.out.println("Opcion incorrecta, no existe en el menu, vuelve a
        // intentarlo de nuevo");

        // }
        // }
    }
}
