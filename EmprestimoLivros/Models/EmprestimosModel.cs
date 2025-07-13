namespace EmprestimoLivros.Models
{
    public class EmprestimosModel
    {
        public int Id { get; set; }
        public string Recebedor { get; set; }
        public String Fornecedor { get; set; }
        public String LivroEmprestado { get; set; }
        public DateTime DataEmprestimo { get; set; } = DateTime.Now;


    }
}
