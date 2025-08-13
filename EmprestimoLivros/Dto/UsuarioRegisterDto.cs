using System.ComponentModel.DataAnnotations;

namespace EmprestimoLivros.Dto
{
    public class UsuarioRegisterDto
    {
        [Required(ErrorMessage = "Digite o Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o Sobrenome!")]
        public int Sobrenome { get; set; }

        [Required(ErrorMessage = "Digite o E-mail!")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Digite a Senha!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Digite a Confirmação de Senha!")]
        public string ConfirmarSenha { get; set; }
    }
}
