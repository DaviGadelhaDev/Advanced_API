using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModel.Accounts
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Campo E-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        public string Password { get; set; }
    }
}