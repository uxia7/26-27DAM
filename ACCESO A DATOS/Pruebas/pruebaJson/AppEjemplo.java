public class AppEjemplo {
    
    public static void main(String[] args) {
        ObjectMapper mapper = new ObjectMapper();

        mapper.disable(DeseralizationFeature)
        mapper.registerModule(new JavaTimeModule);

        File fuente = new File("src/resources/empresa.json");

        RootDto rto = mapper.redValue(fuente, RootDto.class);

        String emailCarlosRuiz = root.empresa()
                                .departamentos()[0]
                                .equipos()[0]
                                .lider()
                                .contacto()
                                .email();
        System.out.println(emailCarlosRuiz);
    }

}
