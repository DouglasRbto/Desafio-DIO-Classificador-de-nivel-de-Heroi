internal class Program
{
    enum Nivel
    {
        Ferro, Bronze, Prata, Ouro, Platina, Ascendente, Imortal, Radiante
    }
    private static void Main(string[] args)
    {
        Heroi heroi;
        string nome;
        string nivel = Nivel.Ferro.ToString();
        int xp;
        bool isNumber;

        Console.WriteLine("Digite o nome do Herói:");
        do
        {
            nome = Console.ReadLine();
            if (string.IsNullOrEmpty(nome))
                Console.WriteLine("O Nome do Heróo não pode ficar em branco. Tente novamente.");
        } while (string.IsNullOrEmpty(nome));

        Console.WriteLine("Digite a Experiência(XP) do Herói:");
        do
        {
            isNumber = int.TryParse(Console.ReadLine(), out xp);
            if (isNumber == false)
                Console.WriteLine("Digite um valor numérico para a Experiência(XP) do Herói:");
        } while (isNumber == false);

        if (xp <= 1000) nivel = Nivel.Ferro.ToString();
        if (xp >= 1001 && xp <= 2000) nivel = Nivel.Bronze.ToString();
        if (xp >= 2001 && xp <= 5000) nivel = Nivel.Prata.ToString();
        if (xp >= 5001 && xp <= 7000) nivel = Nivel.Ouro.ToString();
        if (xp >= 7001 && xp <= 8000) nivel = Nivel.Platina.ToString();
        if (xp >= 8001 && xp <= 9000) nivel = Nivel.Ascendente.ToString();
        if (xp >= 9001 && xp <= 10000) nivel = Nivel.Imortal.ToString();
        if (xp >= 10001) nivel = Nivel.Radiante.ToString();

        heroi = new(nome, xp, nivel);

        Console.WriteLine($"O Herói de nome {heroi.Nome} está no nível de {heroi.Nivel}.");
    }
}
public class Heroi(string nome, int xp, string nivel)
{
    public string Nome { get; set; } = nome;
    public string Nivel { get; set; } = nivel;
    public int XP { get; set; } = xp;

}