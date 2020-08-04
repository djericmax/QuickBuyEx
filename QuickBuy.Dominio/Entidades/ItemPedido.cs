using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validade()
        {
            LimparMensagemValidacao();
            if (ProdutoId == 0)
            {
                AdicionarCritica("Crítica: Não foi identificado a referência do produto.");
            }
            if (Quantidade == 0)
            {
                AdicionarCritica("Crítica: Quantidade não informada.");
            }
        }
    }
}
