using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {

            string altura, peso;

            Console.WriteLine(" ");
            Console.WriteLine(@"Bem vindo usuário!
Esse programa irá calcular o índicie de massa corporal, de acordo com os dados que você fornecerá.");
            Console.WriteLine(" ");

            Console.Write("Altura (m)..: ");
            altura = Console.ReadLine();
            
            Console.Write("Peso (kg)...: ");
            peso = Console.ReadLine();
            Console.WriteLine(" ");

            double h = Convert.ToDouble(altura);
            double kg = Convert.ToDouble(peso);

            double IMC = kg / Math.Pow(h,2);

            Console.WriteLine($"IMC: {IMC:N1} Kg/m²");
            Console.WriteLine(" ");

            /* Na tentativa de criar condicionais em Switch e Case converti
            double em boolean mas não obtive resultado satisfatório.

            bool imcbool = Convert.ToBoolean(IMC);

            Console.WriteLine($"IMC: {imcbool} Kg/m²");*/

           
           
               if(IMC < 16){
                   Console.ForegroundColor = ConsoleColor.Cyan;
               Console.WriteLine("Peso deficitário.");
               Console.ResetColor();
               }

               if(IMC <= 18.5 && IMC > 16){
                   Console.ForegroundColor = ConsoleColor.Blue;
               Console.WriteLine("Abaixo do peso.");
               Console.ResetColor();
               }

               if(IMC <= 24 && IMC > 18.5){ 
                   Console.ForegroundColor = ConsoleColor.DarkGreen;
               Console.WriteLine("Peso ideal (normal).");
               Console.ResetColor();
               }

               if(IMC <= 30 && IMC > 24){ 
                   Console.ForegroundColor = ConsoleColor.DarkYellow;
               Console.WriteLine("Acima do peso.");
               Console.ResetColor();
               }

               if(IMC <= 35 && IMC > 30){
                   Console.ForegroundColor = ConsoleColor.Yellow;
               Console.WriteLine("Obesidade nível 1.");
               Console.ResetColor();
               }

               if(IMC <= 40 && IMC > 35){
                   Console.ForegroundColor = ConsoleColor.Magenta;
               Console.WriteLine("Obesidade nível 2.");
               Console.ResetColor();
               }

               if(IMC > 40){
                   Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("Obesidade nível 3.");
               Console.ResetColor();
               }
                       
            
        }
    }
}
