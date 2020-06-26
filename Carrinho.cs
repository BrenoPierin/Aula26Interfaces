using System.Collections.Generic;

namespace Aula26Interfaces
{
    public class Carrinho : ICarrinho
    {

        List<Produto> cart = new List<Produto>();
        public void Alterar(int _codigo, Produto _produto)
        {
            cart.Find( x => x.Codigo == _codigo).Nome = _produto.Nome;
            cart.Find( x => x.Codigo == _codigo).Preco = _produto.Preco;
        }

        public void Cadastrar(Produto _produto)
        {
            cart.Add(_produto);
        }

        public void Deletar(Produto _produto)
        {
            cart.Remove(_produto);
        }

        public void Listar()
        {
           foreach(Produto prod in cart )
           {
               System.Console.WriteLine($"{prod.Nome} - R${prod.Preco}");
           }
        }
    }
}