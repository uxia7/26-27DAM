import java.time.LocalDate;

public record LiderDto(
    String nombre, 
    @JsonFormat(pattern="yyyy-mm-dd") LocalDate tomaPosesion, 
    //actualizar el pom para meterle al final del todo la dependencia correspondiente
    ContactoDto
) {
    
}
