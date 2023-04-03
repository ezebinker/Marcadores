class Marcador {
    public string Codigo {get; private set;}
    public int NivelTinta {get; private set;}
    public string Color {get; private set;}

    public Marcador(string codigo, string color){
        Codigo = codigo;
        NivelTinta = 100;
        Color = color;
    }

    private void DecidirColor(){
        if(Color == "Verde"){
            Console.ForegroundColor = ConsoleColor.Green;
        } else if(Color == "Rojo"){
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else{
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public void Escribir(string frase){
        DecidirColor();
        Console.WriteLine(frase);
        Console.ForegroundColor = ConsoleColor.White;
        NivelTinta -= frase.Length;
    }

    public void Recargar(){
        NivelTinta = 100;
    }

}