// A Classe é o "molde" da Guitarra
public class Guitarra 
{
    // ATRIBUTOS (O que a guitarra TEM)
    public string modelo;
    public int numeroDeCordas;
    public bool estaAfinada; // Este atributo controla o comportamento do método

    // MÉTODOS (O que a guitarra FAZ)
    public void Afinar() 
    {
        estaAfinada = true;
        Console.WriteLine("A guitarra foi afinada com sucesso.");
    }

    public void TocarSolo() 
    {
        // Aqui vemos a lógica: o método checa o estado do atributo antes de agir
        if (estaAfinada) 
        {
            Console.WriteLine($"Executando um solo incrível na {modelo}!");
        } 
        else 
        {
            Console.WriteLine("O solo soou horrível... a guitarra está desafinada!");
        }
    }
}
