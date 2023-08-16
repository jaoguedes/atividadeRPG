using atividadeRPG;

internal class Program
{
    private static void Main(string[] args)
    {
        Personagem p1 = new Personagem("Luis", "Mago", 1, 100, 30, 70);
        Personagem p2 = new Personagem("Kauã", "Arqueiro", 1, 70, 30, 50);
        Personagem p3 = new Personagem("Gustavo", "Tanque", 4, 250, 100, 10);
        Personagem p4 = new Personagem("Guedes", "Assasino", 6, 260, 150, 100);
        Personagem p5 = new Personagem("Checco", "Guerreiro", 1, 100, 80, 80);

        p5.descricao();

        Console.WriteLine("Andando...");
        Console.WriteLine("Encontrei um inimigo\n");
        p1.descricao();
        Console.WriteLine("Começando a Luta\n");

        Console.WriteLine($"Checco da {p5.Forca} de dano e deixa {p1.Nome} com {p1.Vida - p5.Forca} de vida");
        Console.WriteLine($"Luis com {p1.Vida - p5.Forca} de vida resolve usar seu ataque e deixa Checco com {p5.Vida - p1.Forca} de vida.");
        Console.WriteLine($"Checco recebe dano de luis e fica com {p5.Vida - p1.Forca} de vida  e resolve usar seu ultimo ataque deixando luiz com {p1.Vida - (p5.Forca + 20)} de vida e o executando\n");
        Console.WriteLine($"Checco sobe de nivel");

        p5.evolucao(1, 30, 30, 80);
        p5.apreEvo();
      

        Console.WriteLine("Andando...");
        Console.WriteLine("Encontrei um inimigo\n");
        p2.descricao();
        Console.WriteLine($"Checco da {p5.Forca} de dano e deixa {p2.Nome} com {p2.Vida - p5.Forca} de vida e o mata pois ele é frango de academia.\n");
        
        Console.WriteLine($"Checco sobe de nivel!!!");
        p5.evolucao(1, 30, 30, 80);
        p5.apreEvo();

        Console.WriteLine("Andando...");
        Console.WriteLine("Encontrei um inimigo\n");
        p3.descricao();

        Console.WriteLine($"Checco da {p5.Forca} de dano e deixa {p3.Nome} com {p3.Vida - p5.Forca} de vida e o danifica mas gustavo contra ataca.\n");
        p3.evolucao(1, 20, 30, 30);
        p3.apreEvo();
        Console.WriteLine("De tanto esforço gustavo evolui e continua a batalha.");
        Console.WriteLine($"Checco recebe dano de {p3.Nome} e fica com {p5.Vida - p3.Forca} de vida  e resolve usar seu ultimo ataque deixando {p3.Nome} com {p3.Vida - (p5.Forca + 100)} de vida e {p3.Nome} com medo resolve fugir da luta\n");

        Console.WriteLine($"Checco sobe de nivel!!!");
        p5.evolucao(1, 30, 30, 80);
        p5.apreEvo();

        Console.WriteLine("Andando...");
        Console.WriteLine("Encontrei um inimigo\n");
        p4.descricao();

        Console.WriteLine($"Checco da {p5.Forca} de dano e deixa {p4.Nome} com {p4.Vida - p5.Forca} de vida e o danifica mas gustavo contra ataca.\n");
        Console.WriteLine($"Checco recebe dano de {p4.Nome} e fica com {p5.Vida - p4.Forca} de vida  e resolve usar seu ultimo ataque deixando {p4.Nome} com {p4.Vida - (p5.Forca + 100)} de vida e levando {p4.Nome} a obito.\n");



        Console.WriteLine("Andando...");
        Console.WriteLine("Uma exploção acontece e no meio de um monte de poeira aparece\n");
        Personagem boss = new Personagem("O mais rapido", "flash", 10, 1050, 1050, 2000);
        boss.descricao();

        Console.WriteLine($"{p5.Nome} ao ver {boss.Nome} tenta correr só que ele não consegue e {boss.Nome} usa o seu ataque que deixa {p5.Nome} com {p5.Vida - boss.Forca} de vida");
        Console.WriteLine($"{p5.Nome} no chão diz:\n Ó meu deus não consegui\ne vai de obito");
        boss.evolucao(6, 100, 310, 802);
        boss.apreEvo();

    }
}