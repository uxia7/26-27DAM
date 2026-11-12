import java.util.ArrayList;

public record DepartamentoDto(
    String nombre, 
    ArrayList<EquiposDto> equipos
) {

    
}
