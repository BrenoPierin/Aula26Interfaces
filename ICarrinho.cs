namespace Aula26Interfaces
{
    public interface ICarrinho
    {
         void Listar();
         void Cadastrar(Produto _produto);
         void Deletar(Produto _produto);
         void Alterar(int _codigo, Produto _produto);
    }
}