using System;
using System.Runtime.InteropServices;

namespace ValueAndReferenceTypesDemo
{
    class Principal
    {
        static void Main(string[] args)
        {

            int defaultValueOfInteger = default;
            double defaultValueOfDouble = default;
            char defaultValueOfChar = default;
            
            Console.WriteLine(" " + defaultValueOfInteger);
            Console.WriteLine(" " + defaultValueOfDouble);
            Console.WriteLine(" " + defaultValueOfChar);
            Console.WriteLine(" " + "----------------------");
            //-------------------------------------------------------------------------------------------------------------------------

            int num1 = 1;
            Metodos.MudarNumero(num1);
            Console.WriteLine($" {num1}");
            //-------------------------------------------------------------------------------------------------------------------------

            int x = 1;
            int y = x;
            y++;
            Console.WriteLine(" " + x);
            Console.WriteLine(" " + y);
            Console.WriteLine(" " + "---------------------------");
            //--------------------------------------------------------------------------------------------------------------------------

            Fracao Fracao1 = new Fracao();
            Fracao1.numerador = 1;
            Fracao1.denominador = 1;

            Fracao Fracao2 = Fracao1;
            Fracao2.numerador = 1111;

            Console.WriteLine(" " + Fracao1.numerador); 
            Console.WriteLine(" " + "---------------------------");
            //---------------------------------------------------------------------------------------------------------------------------

            int z = 5;
            Metodos.Mudar(z);
            Console.WriteLine(" " + z); 
            Console.WriteLine(" " + "---------------------------");
            //---------------------------------------------------------------------------------------------------------------------------

            Estudante s = new Estudante();
            s.id = 2;
            s.nome = "Bobby";
            Metodos.Mudar(s);
            Console.WriteLine(" " + s.id); 
            Console.WriteLine(" " + s.nome);    
            
            //BONUS ---------------------------------------------------------------------------------------------------------------------------
            
            string mensagem = "Olá";
            Metodos.MudarMensagem(mensagem);
            Console.WriteLine(" " + mensagem);
            Console.WriteLine(" " + "---------------------------");
        }
      
    }
}
