using System;

namespace Aula26Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
           Produto prod = new Produto();
           Produto prod1 = new Produto(1 , "Livro", 24.99f);
           Produto prod2 = new Produto(2 , "Jaqueta" , 150f);
           Produto prod3 = new Produto(3 , "Mouse RGB" ,300f);
           Produto prod4 = new Produto(1 , "PC Gamer" , 50000f);

            Carrinho cart = new Carrinho();
            cart.Cadastrar(prod1);
            cart.Cadastrar(prod2);
            cart.Cadastrar(prod3);
            cart.Cadastrar(prod4);

            cart.Deletar(prod1);

            cart.Listar();

        }
    }
}
