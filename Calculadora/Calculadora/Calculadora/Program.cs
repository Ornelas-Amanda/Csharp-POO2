using Calculadora.Class;

namespace Calculadora
{

    class Program
    {


        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Qual operação deseja fazer?\n");
            Console.WriteLine("1-Soma\n2-Subtração\n3-Multiplicação\n4-Divisão\n");

            //recebe o input da escolha do operador e o converte
            var operador = Convert.ToInt32(Console.ReadLine());

            //só realiza a operação se o operador estiver entre o valor de 1 a 4  
            if (operador >= 1 && operador <= 4)
            {
                Console.WriteLine("Primeiro numero:");
                double primeiro_numero = Convert.ToDouble(Console.ReadLine()!.Replace('.', ','));


                Console.WriteLine("Segundo numero:");
                double segundo_numero = Convert.ToDouble(Console.ReadLine()!.Replace('.', ','));

                var calc = new Class.Calculadora();
                calc.Operacao(operador, primeiro_numero, segundo_numero);
               // Operacao(operador, primeiro_numero, segundo_numero);
            }
            else
            {
                Console.WriteLine("Escolha um operador valido!!");
            }



        }


    }

}
