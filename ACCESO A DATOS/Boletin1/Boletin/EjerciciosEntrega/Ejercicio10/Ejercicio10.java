import java.io.EOFException;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;
import java.util.Scanner;

public class Ejercicio10 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        File fiP = new File("personas.dat");
        File fiDe = new File("departamentos.dat");

        ArrayList<Persona> listaPersonas = new ArrayList<Persona>();
        ArrayList<Depart> listaDeparts = new ArrayList<Depart>();

        if (fiDe.exists()) {
            try (ObjectInputStream ois = new ObjectInputStream(new FileInputStream(fiDe))) {
                while (true) {
                    listaDeparts.add((Depart) ois.readObject());
                }
            } catch (EOFException e) {
                // fin del fichero: es normal
            } catch (IOException | ClassNotFoundException e2) {
                System.out.println("No se pudo leer el archivo \"departamentos.dat\": " + e2.getMessage());
            }
        } else {
            System.err.println("Problema con el archivo \"departamentos.dat\"");
        }

        if (fiP.exists()) {
            try (ObjectInputStream in = new ObjectInputStream(new FileInputStream(fiP))) {
                while (true) {
                    listaPersonas.add((Persona) in.readObject());
                }
            } catch (EOFException e) {
                // fin del fichero: es normal
            } catch (IOException | ClassNotFoundException e) {
                System.out.println("ERROR al leer personas.dat: " + e.getMessage());
            }
        } else {
            System.err.println("Problema al leer el archivo \"personas.dat\"");
        }

        int opcion = 0;
        do {
            try {

                System.out.println(
                        "Elige una opcion:\n1)Añadir persona\n2)Añadir departamento\n3)Consultar personas\n4)Consultar departamentos\n5)Borar personas\n6)Borrar departamentos\n7)Salir");
                opcion = sc.nextInt();

                switch (opcion) {
                    case 1:
                        System.out.println("Vamos a añadir una persona");

                        System.out.print("Dime el codigo");
                        int codigo = sc.nextInt();
                        // tengo que limipar el buffer por el retorno de carro de los int
                        sc.nextLine();

                        System.out.print("Dime el nombre de la persona");
                        String nombre = sc.nextLine();

                        System.out.print("Dime su edad");
                        int edad = sc.nextInt();
                        // limpiar el buffer
                        sc.nextLine();

                        System.out.print("Dime el codigo del departamento al que pertenece");
                        int codDepart = sc.nextInt();
                        // limpiar el buffer
                        sc.nextLine();

                        Persona p1 = new Persona(codigo, nombre, edad, codDepart);

                        listaPersonas.add(p1);

                        break;

                    case 2:
                        System.out.println("Vamos a añadir un departamento");

                        System.out.print("Dime el codigo del departamento");
                        int codigoDe = sc.nextInt();
                        // otra vez limpio el buffer para que no me de errores
                        sc.nextLine();

                        System.out.print("Dime el nombre del departamento");
                        String nombreDe = sc.nextLine();

                        Depart d1 = new Depart(codigoDe, nombreDe);

                        listaDeparts.add(d1);
                        break;

                    case 3:
                        System.out.println("Vamos a mostrar todos las personas guardadas");

                        for (int i = 0; i < listaPersonas.size(); i++) {
                            System.out.println(listaPersonas.get(i).toString());
                        }

                        break;

                    case 4:
                        System.out.println("Vamos a mostrar todos los departamentos guardados");

                        for (int i = 0; i < listaDeparts.size(); i++) {
                            System.out.println(listaDeparts.get(i).toString());
                        }
                        break;

                    case 5:
                        System.out.println("Dime el codigo de la persona que quieras eliminar");
                        int codigoPe = sc.nextInt();
                        for (int i = listaPersonas.size() - 1; i >= 0; i--) {
                            if (listaPersonas.get(i).getCodigo() == codigoPe) {
                                listaPersonas.remove(listaPersonas.get(i));
                            }
                        }
                        break;

                    case 6:
                        System.out.println("Dime el codigo de la persona que quieras eliminar");
                        int codigoDeB = sc.nextInt();
                        for (int i = listaDeparts.size() - 1; i >= 0; i--) {
                            if (listaDeparts.get(i).getCodigo() == codigoDeB) {
                                listaDeparts.remove(listaDeparts.get(i));
                            }
                        }
                        break;

                    case 7:
                        System.out.println("Saliendo del menu");
                        break;

                    default:
                        System.out.println("Opcion del menu no valida");
                        break;
                }
            } catch (IllegalArgumentException e) {
                System.out.println("Dato invalido");
            }
        } while (opcion != 7);

        try (ObjectOutputStream oos = new ObjectOutputStream(new FileOutputStream("personasEscritura.dat"));
                ObjectOutputStream oos2 = new ObjectOutputStream(new FileOutputStream("departsEscritura.dat"))) {

            for (int i = 0; i < listaPersonas.size(); i++) {
                oos.writeObject(listaPersonas.get(i));
            }

            for (int i = 0; i < listaDeparts.size(); i++) {
                oos2.writeObject(listaDeparts.get(i));
            }

        } catch (EOFException e) {
            System.out.println("Archivo ");
        } catch (IOException ee) {
            System.out.println("");
        }

    }

}
