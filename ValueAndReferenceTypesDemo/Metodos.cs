using System;
using System.Collections.Generic;
using System.Text;

namespace ValueAndReferenceTypesDemo
{
    static class Metodos
    {
        public static void Mudar(int z)
        {
            z = 500;
        }
        public static void Mudar(Estudante e)
        {
            e.id = 3;
            e.nome = "Robert";
        }

        public static void MudarNumero(int numero)
        {
            numero = 100;
            Console.WriteLine($" {numero}");
        }
        public static void MudarMensagem(string mensagem)
        {
            mensagem = "Olá Pessoal!";            
        }
    }
}
