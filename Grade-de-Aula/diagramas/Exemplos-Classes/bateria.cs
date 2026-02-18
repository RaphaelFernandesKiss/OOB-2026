// A Classe é o "molde" ou a "síntese" da Bateria
public class Bateria 
{
    // ATRIBUTOS (O que a bateria TEM)
    public string marca;
    public string material;
    public int quantidadePratos;
    public bool possuiBumboDuplo;

    // MÉTODO (O que a bateria FAZ)
    public void TocarRitmo(string estilo) 
    {
        // A ação depende dos atributos para ser específica
        Console.WriteLine($"Tocando um {estilo} na bateria {marca} de {quantidadePratos} pratos!");
    }
}
