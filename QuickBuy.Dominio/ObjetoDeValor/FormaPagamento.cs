using QuickBuy.Dominio.Enumerados;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto
        {
            get { return Id == (int)TipoFormaPagtoEnum.Boleto; }
        }
        public bool EhCartaoCredido
        {
            get { return Id == (int)TipoFormaPagtoEnum.CartaoCredito; }
        }
        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagtoEnum.Deposito ; }
        }
        public bool NaoFoiDefinido
        {
            get { return Id == (int)TipoFormaPagtoEnum.NaoDefinido; }
        }
    }
}
