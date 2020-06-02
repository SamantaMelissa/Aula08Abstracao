namespace Aula8Abstracao
{
    public class Cartao : Pagamento
    {
       protected string token = "hdfjk5765765+++hsd";

        public string titular { get; set; }
        public int numero { get; set; }
        public string cvv { get; set; }
        public string bandeira { get; set; }
        public string tranferir { get; set; }

        private bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }

    }
}