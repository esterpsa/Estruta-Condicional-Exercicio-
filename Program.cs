using System;

namespace exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aumento de Sálario");
            Console.WriteLine("----------------");
        

        //ENTRADA
            Console.WriteLine("Digite o seu salário: ");
            double salario = double.Parse(Console.ReadLine());

    
        
        //PROCESSAMENTO E EXIBIÇÃO
            if(salario <=500)
            {
                double reajustado = salario * 0.3;
                double aumento = salario + reajustado; 
                Console.WriteLine("Parabéns! Você recebeu um aumento de 30%, o seu salário será: "+aumento);

            }
            else
            {
                Console.WriteLine("Poxa! O aumento ainda não está disponível, mas qualquer novidade você será informado");
            }
        }
    }
}
