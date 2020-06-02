using System;

namespace Aula8Abstracao
{
    public class CartaoCredito : Cartao
    {
        public float limite { get; set; }

        public void AumentarLimite(float acrescimo){

            token = "kdjfgsfkghkidsfjgoisf";
            limite = limite + acrescimo;
            //uso do void pq é melhor para a melhor manutenção//

        }
    }
}