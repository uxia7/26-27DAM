import java.io.Serializable;

public class Depart implements Serializable {

    private int codigo;
    private String nombre;

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
    
    
    public Depart(int codigo, String nombre) {
        setCodigo(codigo);
        setNombre(nombre);
    }

    @Override
    public String toString() {
        return "Departamento " + getCodigo() + " | " + getNombre();
    }
}

