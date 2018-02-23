using System;

public class Program
{
    public static void Main()
    {
        /*
		Caixa Eletrônico
		De acordo com o valor informado na variavel valor. 
		Sistema deve retornar notas somente quando o valor for divisível pelas notas disponíveis, retornando mensagem informativa caso o valor não seja divisível pelas notas.
		Sistema deve retornar o menor número de notas para o valor informado. Deve informar a quantidade de cada nota como resultado do saque.
		*/

        double valor = 0;

        do
        {
            Console.Write("Digite o valor do saque ou 0 para sair: ");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine(RetornarNotas(valor.ToString()));
            Console.ReadLine();

        } while (valor != 0);
    }


    public static string RetornarNotas(string valor)
    {
        int valorSaque = int.Parse(valor);
        var retornoNotas = String.Empty;
        int notas20 = 0;
        int notas50 = 0;
        int notas100 = 0;

        // verifica se o valor do saque é válido
        if (valorSaque % 10 == 0 && valorSaque >= 20 && valorSaque != 30)
        {
            notas100 = valorSaque / 100;
            valorSaque = valorSaque % 100;

            if (valorSaque == 10 || valorSaque == 30 && notas100 > 0)
            {
                valorSaque += 100;
                notas100 -= 1;
            }

            notas50 = valorSaque / 50;
            valorSaque = valorSaque % 50;

            if (valorSaque == 10 || valorSaque == 30 && notas50 > 0)
            {
                valorSaque += 50;
                notas50 -= 1;
            }

            notas20 = valorSaque / 20;
            valorSaque = valorSaque % 20;

            return notas100 + " notas de 100 | " + notas50 + " notas de 50 | " + notas20 + " notas de 20.";
        }
         
        return "Valor de saque inválido";
    }
}
