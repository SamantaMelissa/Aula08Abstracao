using System;

namespace Aula8Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {

//cartão 2
            CartaoCredito visa = new CartaoCredito();
            visa.limite = 5000f;

            Console.WriteLine("Deseja aumentar seu limite no seu cartão Visa? Quanto de acréscimo?");
            float acresc = float.Parse( Console.ReadLine());

            visa.AumentarLimite(acresc);
            Console.WriteLine("Novo limite: \n R$"+visa.limite);

            Console.WriteLine("Digite a data do pagamento:");
            visa.data = DateTime.Parse( Console.ReadLine());
            Console.WriteLine("Data:"+ visa.data);

            

//cartão 2
            CartaoCredito MasterCard = new CartaoCredito();
            MasterCard.limite = 10000f;

            Console.WriteLine("Deseja aumentar seu limite no seu cartão Master Card? Quanto de acréscimo?");
            float soma = float.Parse( Console.ReadLine());

            MasterCard.AumentarLimite(soma);
            Console.WriteLine("Novo limite: \n R$"+MasterCard.limite);

            Console.WriteLine("Digite a data do pagamento:");
            MasterCard.data = DateTime.Parse( Console.ReadLine());
            Console.WriteLine("Data:"+MasterCard.data);
            //2020-06-02T15:01:20


            CartaoDebito elo = new CartaoDebito();
            elo.transf = 10000f;

            Console.WriteLine("Deseja fazer transferência de seu cartão de débito de quanto?");
            float ad = float.Parse( Console.ReadLine());

           // elo.Tranfer(ad);
            //Console.WriteLine("Novo limite: \n R$"+elo.transf);
            
        }
    }



}
