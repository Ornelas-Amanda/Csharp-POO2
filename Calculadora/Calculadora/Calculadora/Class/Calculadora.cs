using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Class
{
    public class Calculadora
    {
        public double Primeiro_numero { get; set; } 
        public double Segundo_numero { get; set; }
        public int Operador { get; set; }

        public Calculadora() { }

        public double Soma(double primeiro_numero, double segundo_numero)
        {
            return primeiro_numero + segundo_numero;

        }
        public double Subtracao(double primeiro_numero, double segundo_numero)
        {
            return primeiro_numero - segundo_numero;

        }
        public double Multiplicacao(double primeiro_numero, double segundo_numero)
        {
            return primeiro_numero * segundo_numero;

        }
        public double Divisao(double primeiro_numero, double segundo_numero)
        {
            return primeiro_numero / segundo_numero;

        }

        public void Operacao(double operador, double primeiro_numero, double segundo_numero)
        {

            double resposta = 0;
            switch (operador)
            {
                case 1:
                    resposta = Soma(primeiro_numero, segundo_numero);
                    Console.WriteLine("O resultada da sua soma é: \n" + resposta + "\n");
                    break;
                case 2:
                    resposta = Subtracao(primeiro_numero, segundo_numero);
                    Console.WriteLine("O resultada da sua subtração é: \n" + resposta);
                    break;
                case 3:
                    resposta = Multiplicacao(primeiro_numero, segundo_numero);
                    Console.WriteLine("O resultada da sua multiplicação é: \n" + resposta);
                    break;
                case 4:
                    if (segundo_numero == 0)
                    {
                        Console.WriteLine("Não é possivel realizar uma divisão por 0");
                    }
                    else
                    {
                        resposta = Divisao(primeiro_numero, segundo_numero);
                        Console.WriteLine("O resultada da sua divisão é: \n" + resposta);
                    }
                    break;
            }

            Continuar(operador, resposta);
        }

        public void Continuar(double operador, double resposta)
        {
            Console.WriteLine("Deseja continuar nessa operação ?\n1-Sim\n0-Nao\n");
            var continuar = Convert.ToInt32(Console.ReadLine());

            if (continuar == 1)
            {
                Console.WriteLine("Deseja Mudar a operação ?\n1-Sim\n0-Nao\n");
                var mudar_operacao = Convert.ToInt32(Console.ReadLine());

                if (mudar_operacao == 1)
                {
                    Console.WriteLine("Qual operação deseja fazer?\n");
                    Console.WriteLine("1-Soma\n2-Subtração\n3-Multiplicação\n4-Divisão\n");

                    operador = Convert.ToDouble(Console.ReadLine());

                }



                Console.WriteLine("Proximo numero?\n");
                double proxima_numero = Convert.ToDouble(Console.ReadLine());

                Operacao(operador, resposta, proxima_numero);
            }
            else
            {
                Console.WriteLine("Fim da Operação!");
            }

        }
    }
}
