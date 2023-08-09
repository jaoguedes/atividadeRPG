using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeRPG
{
    internal class Personagem
    {
        public Personagem(string Nome, string Classe, int Nivel, int Vida, int Forca, int Agilidade) 
        { 
            this.Nome = Nome;
            this.Classe = Classe;
            this.Nivel = Nivel;
            this.Vida = Vida;
            this.Forca = Forca;
            this.Agilidade = Agilidade;
        }
        public string Nome { get; set; }
        public string Classe { get; set; }
        public int Nivel { get; set; }
        public int Vida { get; set; }
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        
        
        public void descricao()
        {
            Console.WriteLine($"Olá eu sou {Nome} possuo a classe {Classe} e meus atuais atributos são:\nNivel: {Nivel}\nVida: {Vida}\nForça: {Forca}\nAgilidade: {Agilidade}\n");
        }

        public  void evolucao(int exp, int health, int power, int speed)
        {
            this.Nivel = Nivel + exp;
            this.Vida = Vida + health;
            this.Forca = Forca + power;
            this.Agilidade = Agilidade + speed;
        }
            
        public void apreEvo()
        {
            Console.WriteLine($"{Nome} evoluio os atuais atributos são:\nNivel: {Nivel}\nVida: {Vida}\nForça: {Forca}\nAgilidade: {Agilidade}\n");
        }

    }
}
