using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pratica.Model
{
    public class Pessoa
    {
        // Construtor da classe
        public Pessoa()
        {

        }
        // Construtor com parâmetros
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        // Propriedades
        private string _nome;
        private int _idade;
        // Propriedades
        public string Nome 
        {
            get => _nome;

            set
            {
                if(value == "")
                {
                    Console.WriteLine("Nome não pode ser vazio");
                }
                _nome = value;

            }
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}";
        public int Idade 
        { 
            get => _idade; 
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Idade não pode ser negativa");
                }
                _idade = value;
            }
        }

        // Métodos
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.");
        }
    }
}