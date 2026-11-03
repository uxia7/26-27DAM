import java.io.Serializable;

public class Persona implements Serializable {

    private int codigo;
    private String nombre;
    private int edad;
    private int codDepart; 

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }
    public int getCodigo() {
        return codigo;
    }
    
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
    public String getNombre() {
        return nombre;
    }
    
    public void setEdad(int edad) {
        this.edad = edad;
    }
    public int getEdad() {
        return edad;
    }
    
    public void setCodDepart(int codDepart) {
        this.codDepart = codDepart;
    }
    public int getCodDepart() {
        return codDepart;
    }
    
    public Persona(int codigo, String nombre, int edad, int codDepart) {
        setCodigo(codigo);
        setNombre(nombre);
        setEdad(edad);
        setCodDepart(codDepart);
    }

    @Override 
    public String toString() {
        return "Persona " + codigo + " : " + nombre + " : " + edad + " anios : depart. " + codDepart;
    }
}