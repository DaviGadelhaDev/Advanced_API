using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModel.Accounts
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Campo nome é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo E-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }
    }
}