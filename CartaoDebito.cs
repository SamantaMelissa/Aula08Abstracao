using System;
namespace Aula8Abstracao
{
    public class CartaoDebito : Cartao
    {
        public float saldo { get; set; }

        public float transf { get; set; }

        public string Transferir(){
            return "Tranferência efetuada";
        }
        

        public string Pagartitulo(){
            return "Título pago";
        }

         public float trans { get; set; }

        public void Tranfer(float ad){

           
            trans = trans + ad;
           
        }
    }
}