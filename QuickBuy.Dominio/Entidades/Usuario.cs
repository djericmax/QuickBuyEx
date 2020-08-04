using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        /// <summary>
        /// Usuário pode ter nenhum ou muitos pedidos.
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validade()
        {
            LimparMensagemValidacao();
            if (string.IsNullOrEmpty(Email))
            {
                AdicionarCritica("Crítica: E-mail não informado.");
            }
            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarCritica("Crítica: Senha não informada.")
            }
        }
    }
}
