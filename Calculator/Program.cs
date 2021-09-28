using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();



        }

        static void soma()
        {
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor Valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            imprimir(resultado);           

        }

        static void subtracao()
        {

            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor Valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            imprimir(resultado);      

        }

        static void multiplicacao()
        {
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor Valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            imprimir(resultado);      

        }

        static void divisao()
        {
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor Valor:");
            float v2 = float.Parse(Console.ReadLine());

            if(v2 == 0){
                Console.WriteLine("Não é possivel dividir por zero !!");
                Menu();  
            }else{

                float resultado = v1 / v2;
                imprimir(resultado);
                 
                
            }

                

        }

        static void imprimir(float res){
            Console.WriteLine(res);
            Menu();  
        }

        static void Menu()
        {

            
            Console.WriteLine("### Escolha uma operação matematica ###");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair da Aplicação");


            Console.WriteLine("-------------------------");
            short n = short.Parse(Console.ReadLine());

            switch(n){
                case 1: soma(); break;
                case 2: subtracao(); break;
                case 3: multiplicacao(); break;
                case 4: divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }


        }


    }
}
