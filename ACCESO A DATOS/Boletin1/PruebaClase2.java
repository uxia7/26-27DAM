import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

public class PruebaClase2 {
    
    public static void main(String[] args) {
        
        File fLectura = new File("archivoLectura.txt");
        File fEscritura = new File("archivoEscritura.txt");

        try(Scanner sc = new Scanner(fLectura); FileWriter fw = new FileWriter(fEscritura)) {
            
            String leido = "";
            while(sc.hasNext()) {
                leido = sc.nextLine();
                fw.write(leido);
            }

        } catch(IOException e) {
            System.out.println("Error a la hora de gestionar el archivo");
        }

    }
}
