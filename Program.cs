using System;

namespace Estruturas_de_repeticao._2
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.

            //Atributos 
            string nomeUsuario;
            string senhaUsuario;

            Console.WriteLine("Insira um nome de usuário");
            nomeUsuario  = Console.ReadLine();

            Console.WriteLine("Insira a senha do usuário");
            senhaUsuario = Console.ReadLine();
            
            while (nomeUsuario == senhaUsuario)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("nome de usuário não pode ser igual a senha do usuário Digite novamete");
                Console.ResetColor();

                Console.WriteLine("Insira um nome de usuário");
                nomeUsuario  = Console.ReadLine();

                Console.WriteLine("Insira a senha do usuário");
                senhaUsuario = Console.ReadLine();
            }
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Login efetuado com sucesso");
            Console.ResetColor()

        }
    }
}
