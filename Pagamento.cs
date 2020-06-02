using System;

namespace Aula8Abstracao
{
    public class Pagamento
    {
        public DateTime data { get; set; } //DateTime usa para colocar data//

        public float valor { get; set; }

        public string Pagar(float valorPago){
            return "Valor pago: R$"+valorPago;
        }

        public string Cancelar(){
            return "Pagamento cancelado.";
        }



    }
}