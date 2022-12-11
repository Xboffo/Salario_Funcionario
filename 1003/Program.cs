using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numeroFuncionario, horasTrabalhadas;
            double valorDaHora,salary;

            numeroFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorDaHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            salary = horasTrabalhadas * valorDaHora;
            

            Console.WriteLine("NUMBER = " + numeroFuncionario);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture)); 
        }
    }
}