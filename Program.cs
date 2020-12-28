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
            
        }
    }
}
