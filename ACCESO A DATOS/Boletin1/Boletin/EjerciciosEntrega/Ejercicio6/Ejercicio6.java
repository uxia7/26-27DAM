import java.io.*;
import java.util.Scanner;

public class Ejercicio6 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int opcion = 0;

        File fLectura = new File("og6.txt");

        do {
            System.out.println("huna opcion del menu: 1 dividir 2 unir 3 salir");
            opcion = sc.nextInt();

            switch (opcion) {
                case 1:
                    System.out.println("Dividir fichero");

                    int opcion1 = 0;
                    System.out.println("Quieres dividir por: 1-caracteres 2-cadenas 3-salir");
                    opcion1 = sc.nextInt();

                    int veces = 0;

                    try (FileReader fr = new FileReader(fLectura);
                            Scanner lectura = new Scanner(fLectura)) {

                        switch (opcion1) {
                            case 1:
                                FileWriter fw = new FileWriter("archivo" + veces + ".txt");
                                System.out.println("Dividiremos el archivo por caracteres!");

                                // le pedimos la cantidad de caracteres al usuario y esto es lo que usaremos
                                // para comparar
                                System.out
                                        .println("Dime el numero de caracteres por el que quieres separar el archivo");
                                int cantidad = sc.nextInt();

                                // variables
                                // para leer el archivo
                                int caracter = fr.read();
                                // para contar los caracteres
                                int contCaractLeidos = 0;

                                // leemos caracter x caracter el archivo
                                while (caracter != -1) {
                                    // ahora tengo que recorrer el archivo y cuando llegue a un numero determinado
                                    // de caracteres
                                    // parar y crear un archivo nuevo donde seguir escribiendo
                                    if (contCaractLeidos < cantidad) {
                                        fw.write((char) caracter);
                                    } else {
                                        // como hemos entrado aqui quiere decir que hemos acabado de rellenar el archivo
                                        // anterior
                                        // con lo cual hay que cerrar el flujo de dicho archivo antes de abrir otro o
                                        // seguir escribiendo
                                        fw.close();
                                        contCaractLeidos = 0;
                                        veces++;
                                        fw = new FileWriter(new File("archivo" + veces + ".txt"));
                                        // escribimos este primer caracter en el que se quedo antes de que se pierda
                                        fw.write((char) caracter);
                                        contCaractLeidos++;
                                    }
                                    // como hemos acabado de gestionar la letra anterior pues
                                    // sumamos al contador una vuelta de caracter
                                    contCaractLeidos++;
                                    // leemos el siguiente caracter
                                    caracter = fr.read();
                                }

                                fw.close();
                                break;

                            case 2:
                                System.out.println("Se dividira por cadenas!");

                                //pedimos las lineas para la division
                                System.out.println("Dime el numero de lineas por el que quieres separar el archivo");
                                int numLineas = sc.nextInt();

                                int contLineasLeidas = 0;

                                PrintWriter pw = new PrintWriter("archivo" + veces + ".txt");
                                // Leemos línea a línea con Scanner
                                while (lectura.hasNextLine()) {
                                    String linea = lectura.nextLine();

                                    // Si aún no hemos llegado al límite, escribimos
                                    if (contLineasLeidas < numLineas) {
                                        pw.println(linea);
                                        contLineasLeidas++;
                                    } else {
                                        pw.close();
                                        contLineasLeidas = 0;
                                        veces++;

                                        pw = new PrintWriter("archivo" + veces + ".txt");
                                        pw.println(linea);
                                        contLineasLeidas++;
                                    }
                                }

                                pw.close();

                                break;

                            case 3:
                                System.out.println("Saliendo...");
                                break;

                            default:
                                System.out.println("Opcion del menu no valida");
                                break;
                        }

                    } catch (IOException e) {
                        System.out.println("Error, problemas al interactuar con el archivo");
                    }

                case 2:
                    System.out.println("Vamos a unir ficheros!");
                    String[] ficherosEntrada = {
                            "fichero1.txt",
                            "fichero2.txt",
                            "fichero3.txt"
                    };

                    try {
                        // nombre del fichero que quedara como resultado
                        String ficheroSalida = "union.txt";
                        PrintWriter pw = new PrintWriter(new File(ficheroSalida));

                        //ahora recorremos cada fichero de la lista
                        for (int i = 0; i < ficherosEntrada.length; i++) {

                            String nombreFichero = ficherosEntrada[i];

                            try {
                                // Scanner para leer el fichero de entrada
                                Scanner lector = new Scanner(new File(nombreFichero));

                                // Leemos línea a línea mientras haya líneas
                                while (lector.hasNextLine()) {
                                    String linea = lector.nextLine();
                                    pw.println(linea);
                                }

                                lector.close();
                                System.out.println("Añadido: " + nombreFichero);

                            } catch (FileNotFoundException e) {
                                System.out.println("No se encontró el fichero: " + nombreFichero);
                            }
                        }

                        pw.close();
                        System.out.println("Fichero unión creado: " + ficheroSalida);

                    } catch (IOException e) {
                        System.out.println("Error al gestionar el fichero");
                    }

                    break;

                case 3:
                    System.out.println("Saliendo...");
                    break;

                default:
                    System.out.println("Opcion no valida en el menu");
                    break;
            }
        } while (opcion != 3);

    }

}
