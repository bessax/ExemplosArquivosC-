using System;
using System.IO;

namespace ExemploTXT01
{
    class Program
    {
        static void Main(string[] args)
        {
            // String com opção a ser digitada.
            char op;
            do
            {
                // Montando menu de exibição no console
                Console.WriteLine(">>>>>>>>>> Escrever e Ler em TXT <<<<<<<<<<");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Escrever");
                Console.WriteLine("2 - Ler");
                Console.WriteLine("3 - Sair");
                Console.Write("Opção desejada: ");
                op = Console.ReadLine()[0];
                switch (op)
                {
                    case '1':
                        Escrever();
                        break;

                    case '2':
                        Ler();

                        break;
                    default:
                        Console.WriteLine("Opção de menu inválida");
                        break;
                }

            }
            while (op != '3');


        }

        // Método criado para criar e escrever em um arquivo texto.
        static void Escrever()
        {
            string nome = "";
            Console.WriteLine("Digite seu Nome:");
            nome = Console.ReadLine();

            // A utilização do Try é necessário ao se trabalhar com arquivos, pois estas são operações
            //sujeitas a falhas como não encontrar o arquivo, ou ele existe mas sem permissões de edição, etc...
            try
            {
                //Cria um StreamWriter para a criação de um arquivo do tipo ".txt".
                StreamWriter sw = new StreamWriter("C:\\Temp\\Nomes.txt", true);
                sw.WriteLine(nome);
                sw.Close();

            }
            catch (Exception ex)
            {

                Console.WriteLine("Exceção a ser tratada .:{0}", ex.Message);
            }

            Console.ReadKey();
            Console.Clear();
        }

        // Método criado para ler e exibir o conteúdo de um arquivo .txt
        static void Ler()
        {
            // Verificando se o arquivo existe
            if (File.Exists(@"C:\Temp\Nomes.txt"))
            {
                // A utilização do Try é necessário ao se trabalhar com arquivos, pois estas são operações
                //sujeitas a falhas como não encontrar o arquivo, ou ele existe mas sem permissões de edição, etc...
                try
                {
                    // Cria um objeto do tipo StreamReader
                    StreamReader sr = new StreamReader("C:\\Temp\\Nomes.txt");

                    // Percorre o arquivo exibindo seu conteúdo na tela
                    Console.WriteLine(">>> Lista de Nomes Cadastrados <<<");
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }

                    sr.Close();
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Exceção a ser tratada .:{0}", ex.Message);
                }
            }
            else // Se o arquivo não existir exibe a mensagem para o usuário.
            {
                Console.WriteLine("Arquivo Nomes.txt não encontrado");
            }


            Console.ReadKey();
            Console.Clear();
        }
    }
}
