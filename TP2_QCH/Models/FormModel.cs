using System.ComponentModel.DataAnnotations;

namespace TP2_QCH.Models
{
    public class FormModel
    {
        [Required(ErrorMessage = "*")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*")]
        public string FName { get; set; }

        [Required]
        [RegularExpression("^(?!.*Sélectionner un Sexe).*", ErrorMessage = "*")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "*")]
        public string Address { get; set; }

        [Required(ErrorMessage = "*")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Format incorrect.")]
        public string ZCode { get; set; }

        [Required(ErrorMessage = "*")]
        public string Town { get; set; }

        [Required(ErrorMessage = "*")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Format Incorrect.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*")]
        public string SDate { get; set; }

        [Required]
        [RegularExpression("^(?!.*Sélectionner une Formation).*", ErrorMessage = "*")]
        public string TType { get; set; }
    }
}
