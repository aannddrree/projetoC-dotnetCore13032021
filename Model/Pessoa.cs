namespace projetoC_dotnetCore.Model
{
    public class Pessoa
    {
        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Telefone { get; set; }

        #endregion

        #region Métodos

        public override string ToString()
        {
            return "Id: " + this.Id + "\nNome: " + this.Nome;
        }

        #endregion
    }
}