using System;
using System.Threading;

namespace timewatch
{
    class Program
    {
        static void Main(string[] args)
        {
           Menu();
        }

        static void start(int time){
            
            int currentTime = 0;

            while(currentTime != time){

                Console.Clear();
                currentTime ++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);

            }
            
            for(int i = 0; i < 3; i++){

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado, Retornando para o menu !");
            Thread.Sleep(1000);
            Console.Clear();            
            Console.WriteLine("Stopwatch finalizado, Retornando para o menu !!");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado, Retornando para o menu !!!");
            Thread.Sleep(1000);
            }

            Menu();
            
            
        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("S - Seconds");
            Console.WriteLine("M - Minutes");
            Console.WriteLine("E - Exit");
            Console.WriteLine("--------------------");

                        
            char v = char.Parse(Console.ReadLine().ToLower());

            switch (v){
                case 's': Segundos(); break;
                case 'm': Minutos(); break;
                case 'e': System.Environment.Exit(0); break;
                default: TratamentoErro(); break; 
            }
        }

        static void Segundos(){
            
            Console.WriteLine("Quantos segundos ?");
            int time = int.Parse(Console.ReadLine());            

        }

        static void Minutos(){
            
            Console.WriteLine("Quantos minutos ?");
            int time = int.Parse(Console.ReadLine());
            time = time * 60;            
            start(time);

        }

        static void TratamentoErro(){
            Console.WriteLine("Digite um opção valida !");
            Thread.Sleep(1000);
            Menu();

        }
    }
}
