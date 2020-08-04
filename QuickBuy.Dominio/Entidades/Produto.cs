namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validade()
        {
            LimparMensagemValidacao();
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Crítica: Nome precisa ser preenchido.");
            }
            if (Preco == 0)
            {
                AdicionarCritica("Crítica: O preço precisa ser maior que zero.")
            }
        }
    }
}
