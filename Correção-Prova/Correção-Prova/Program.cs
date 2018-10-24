using System;

namespace Correção_exercicio_2_da_prova
{

    class impar
    {
        static bool Par(int A)
        {
            if (A % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class IMC
    {
        private double peso;
        private double altura;

        public IMC()
        {
            this.peso = 0.0;
            this.altura = 0.0;
        }

        public IMC(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }

        public double calcular(double peso, double altura)
        {
            double imc = ((peso) / (altura * altura));
            return imc;
        }

        public string classificar(double IMC)
        {
            if (IMC > 0 && IMC < 16)
            {
                return "Com Anorexia.";
            }
            else if (IMC >= 16 && IMC < 17)
            {
                return "Com Magreza moderada.";
            }
            else if (IMC >= 17 && IMC < 18.5)
            {
                return "levemente abaixo do peso.";
            }
            else if (IMC >= 18.5 && IMC < 25)
            {
                return "Saudável.";
            }
            else if (IMC >= 25 && IMC < 30)
            {
                return "Com Sobrepeso.";
            }
            else if (IMC >= 30 && IMC < 35)
            {
                return "Com Obesidade primeiro grau.";
            }
            else if (IMC >= 35 && IMC < 40)
            {
                return "Com Obesidade de segundo grau.";
            }
            else if (IMC > 40)
            {
                return "Com Obesidade Morbida.";
            }
            return "ERRO";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            impar par = new impar();
            Console.WriteLine(par(11));
            Console.ReadKey();


            IMC imc = new IMC();
            Console.WriteLine("Qual a sua altura? ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("\nQual seu peso? ");
            double peso = double.Parse(Console.ReadLine());

            Double seuIMC = imc.calcular(peso, altura);

            Console.WriteLine("\nSeu IMC é: " + seuIMC);
            Console.Write("\nVoce está: " + imc.classificar(imc.calcular(peso, altura)));
            Console.ReadKey();
        }
    }
}
