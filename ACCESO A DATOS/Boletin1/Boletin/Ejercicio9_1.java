import java.io.DataInputStream;
import java.io.IOException;

/**
 * Ejercicio9_1
 * 
 * 
 * Realiza un programa que permita almacenar, de forma binaria, los datos de
 * unos alumnos en el fichero alumnos.dat (guarda los datos de forma individual,
 * no
 * como un objeto). Los datos de cada alumno serán: código como entero, nombre
 * como cadena de texto, altura como un número con dos decimales. El programa
 * debe realizar las siguientes tareas:
 * ➢ Dar de alta nuevos alumnos.
 * ➢ Consultar alumnos.
 * ➢ Modificar alumnos.
 * ➢ Borrar alumnos.
 * El programa deberá avisar de posibles problemas encontrados como puede ser el
 * intentar borrar un alumno que no exista.
 */
public class Ejercicio9_1 {

    // de forma binario -> usar los que contengan la palabra input/output
    // fichero -> alumnos.dat
    // guardar datos de forma individual y no como objeto -> no podemos usar
    // ObjectInput, usamos el DataInput/Output
    /*
     * datos alumno:
     * codigo -> int
     * nombre -> string
     * altura -> double
     */

    // tareas -> menu
    //informar de problemas, por ejemplo si un alumno no existe

    public static void main(String[] args) {
        int opcion = 0;
        do {
            System.out.println("Menu:\n1)dar de alta nuevos alumnos\n2)consultar alumnos\n3)modificar alumnos\n4)borrar alumnos\n5)salir");
            switch (opcion) {
                case 1:
                    try(DataInputStream dis = new DataInputStream(fichero)) {
                        
                    } catch (IOException e) {
                        System.out.println("Error el fichero no se pudo");
                    }
                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:
                    System.out.println("Saliendo...");
                    break;

                default:
                    System.out.println("Opcion invalida en el menu, vuelve a intentarlo");
                    break;
            }
        } while (opcion != 5);

    }
}