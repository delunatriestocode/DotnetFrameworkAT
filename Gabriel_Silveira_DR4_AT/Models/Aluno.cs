using System.ComponentModel.DataAnnotations;

namespace Gabriel_Silveira_DR4_AT.Models {
    public class Aluno {
        // Id
        public int Id { get; set; }

        // Nome
        [StringLength(50, MinimumLength = 4, ErrorMessage = "O nome deve ter, no mínimo, 4 caracteres.")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        // Endereço
        [Required(ErrorMessage = "O endereço é obrigatório")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        // Telefone
        [Required(ErrorMessage = "O telefone é obrigatório")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        // E-mail
        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        // Data de Nascimento
        [Required(ErrorMessage = "A data de nascimento é obrigatório")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public string DataDeNascimento { get; set; }
    }
}
