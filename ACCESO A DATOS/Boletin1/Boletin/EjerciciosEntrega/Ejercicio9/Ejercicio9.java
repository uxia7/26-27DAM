import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.EOFException;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Scanner;

public class Ejercicio9 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        File fichero = new File("alumnos.dat");

        int opcion = 0;

        do {
            try {
                System.out.println("1)Añadir alumnos\n2)Mostrar alumnos\n3)Modificar alumno\n4)Borrar alumnos\n5)Salir");
                opcion = sc.nextInt();

                switch (opcion) {
                    case 1:
                        sc.nextLine();
                        System.out.println("Dime el nombre del alumno");
                        String nombre = sc.nextLine();

                        System.out.println("Dime el codigo del alumno");
                        int codigo = sc.nextInt();
                        
                        //limpieza de buffer

                        System.out.println("Dime la altura del alumno");
                        double altura = sc.nextDouble();

                        try (DataOutputStream dot = new DataOutputStream(new FileOutputStream(fichero))) {
                            dot.writeInt(codigo);
                            dot.writeUTF(nombre);
                            dot.writeDouble(altura);
                        } catch (IOException e) {
                            System.out.println("Problemas al encontrar el fichero");
                        }

                        System.out.println("Alumno añadido!");

                        break;

                    case 2:
                        if (fichero.exists()) {
                            try (DataInputStream dis = new DataInputStream(new FileInputStream(fichero))) {
                                while (true) {
                                    int codigoLec = dis.readInt();
                                    String nomLec = dis.readUTF();
                                    double alturaLec = dis.readDouble();

                                    System.out.println(codigoLec + nomLec + alturaLec);
                                }
                            } catch (EOFException e) {
                                System.out.println("Llegamos al final del archivo");
                            } catch (IOException ee) {
                                System.out.println("Problemas al encontrar el archivo de lectura");
                            }
                        } else {
                            System.out.println("Aun no existen alumnos");
                        }
                        break;

                    case 3:
                        System.out.println("Dime el codigo del alumno que quieres modificar");
                        int codAlum = sc.nextInt();

                        if (fichero.exists()) {
                            try (DataInputStream dis = new DataInputStream(new FileInputStream(fichero));
                                    DataOutputStream dos = new DataOutputStream(new FileOutputStream(fichero))) {
                                while (true) {
                                    int cod3 = dis.readInt();
                                    String nom3 = dis.readUTF();
                                    double alt3 = dis.readDouble();

                                    if (codAlum == cod3) {
                                        System.out.println("Datos actuales: " + nom3 + " | " + alt3);

                                        System.out.println("Dime el nuevo nombre: ");
                                        String nuevoNom = sc.nextLine();

                                        System.out.println("Dime la altura correcta");
                                        double nuevaAltura = sc.nextDouble();

                                        dos.writeInt(cod3);
                                        dos.writeUTF(nuevoNom);
                                        dos.writeDouble(nuevaAltura);

                                        System.out.println("Alumno actualizado!");
                                    } else {
                                        System.out.println("Alumno no encontrado");
                                    }
                                }
                            } catch (EOFException e) {
                                System.out.println("Fin de la lectura");
                            } catch (IOException ee) {
                                System.out.println("Problemas con el archivo");
                            }
                        } else {
                            System.out.println("Aun no hay alumnos guardados");
                        }
                        break;

                    case 4:
                        // File fiTemp = new File("temporal");
                        System.out.println("Dime el codigo del alumno que quieres borrar");
                        int codAlum4 = sc.nextInt();

                        boolean bandera = true;
                        if (fichero.exists()) {
                            try (DataInputStream dis = new DataInputStream(new FileInputStream(fichero));
                                    DataOutputStream dos = new DataOutputStream(new FileOutputStream(fichero))) {
                                while (true) {
                                    int cod4 = dis.readInt();
                                    String nom4 = dis.readUTF();
                                    double alt4 = dis.readDouble();

                                    if (cod4 == codAlum4) {
                                        bandera = true; 
                                        //no lo copio en esa vuelta y en si queda borrado del fichero
                                    } else {
                                        dos.writeInt(cod4);
                                        dos.writeUTF(nom4);
                                        dos.writeDouble(alt4);
                                    }
                                }
                            } catch (EOFException e) {
                                System.out.println("Fin del fichero");
                            } catch (IOException ee) {
                                System.out.println("Problemas al manejar el fichero");
                            }  
                            
                            if(bandera) {
                                System.out.println("Alumno eliminado correctamente");
                            } else {
                                System.out.println("Alumno NO eliminado correctamente");
                            }
                        } else {
                            System.out.println("Aun no existen alumnos guardados");
                        }

                        break;
                    case 5:
                        System.out.println("Saliendo del menu");
                        break;

                    default:
                        System.out.println("Opcion no valida del menu");
                        break;
                }
            } catch (IllegalArgumentException e) {
                System.out.println("Dato no valido, vuelve a ejecutar el menu");
            }

        } while (opcion != 5);
    }
}
