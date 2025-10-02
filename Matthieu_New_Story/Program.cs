using System;

namespace Matthieu_New_Story
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo();
            jogo.Iniciar();
        }
    }

    class Jogo
    {
        private Personagem personagem;

        public Jogo()
        {
            personagem = new Personagem("Matthieu");
        }

        public void Iniciar()
        {
            Console.WriteLine($"Bem-vindo, {personagem.Nome}!");
            Console.WriteLine("Matthieu está viajando com os seus companheiros; Kamape e O lindo poderoso Alan junior 3°\n");
            Console.WriteLine("De repente, o grupo de viajantes se depara com um inimigo terrivel, Gabriell O Mago Perverso, ele sequestra Kamape ");
            Console.WriteLine("1 - Caminho Luminoso");
            Console.WriteLine("2 - Caminho Sombrio");
            Console.Write("Escolha o caminho (1 ou 2): ");

            string escolha = Console.ReadLine();

            if (escolha == "1")
            {
                CaminhoLuminoso();
            }
            else if (escolha == "2")
            {
                CaminhoSombrio();
            }
            else
            {
                Console.WriteLine("Escolha inválida. Tente novamente.");
                Iniciar();
            }
        }

        private void CaminhoLuminoso()
        {
            Console.WriteLine("\nVocê escolheu o Caminho Luminoso.");
            Console.WriteLine("O caminho é bonito e cheio de flores. Você encontra um grupo de viajantes amigáveis.");
            Console.WriteLine("Eles oferecem ajuda para continuar sua aventura.");
            Console.WriteLine("FIM: Você faz novos amigos e segue uma jornada segura e feliz.");
        }

        private void CaminhoSombrio()
        {
            Console.WriteLine("\nVocê escolheu o Caminho Sombrio.");
            Console.WriteLine("O caminho é escuro e assustador, mas você sente que algo valioso está no final.");
            Console.WriteLine("Você enfrenta desafios e encontra um tesouro antigo.");
            Console.WriteLine("FIM: Você retorna para casa como um herói com seu tesouro.");
        }
    }

    class Personagem
    {
        public string Nome { get; private set; }

        public Personagem(string nome)
        {
            Nome = nome;
        }
    }
}
