class Disco 
{
    public Dictionary<int, string> canciones {get; private set;}
    public string nombreProductor {get; private set;}
    public string nombreArtista {get; private set;}
    public string duracion {get; private set;}
    public string titulo {get; private set;}
    public string generoMusical {get; private set;}  
    public string foto {get; private set;}

    public Disco(string titulo, string nombreArtista, string duracion, string nombreProductor, string generoMusical, string foto)
    {
        canciones = new Dictionary<int, string>();
        this.titulo = titulo;
        this.nombreArtista = nombreArtista;
        this.duracion = duracion;
        this.nombreProductor = nombreProductor;
        this.generoMusical = generoMusical;
        this.foto = foto;
    }
}

