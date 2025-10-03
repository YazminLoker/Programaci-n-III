using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            console.writeline("Enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            console.writeline("Enter second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            console.writeline("seleccionar opción:");
            console.writeline("ta-suma");
            console.writeline("tb-resta");
            console.writeline("tc-multiplicación");
            console.writeline("td-división");
            switch (Console.ReadLine())
            {
                case "a":
                    console.writeline($ "El resultado
           
