using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EpiDHL.Models
{
    public class Cliente
    {
        [Key]
        public int Cliente_ID { get; set; }

        [Required(ErrorMessage = "Campo Azienda obbligatorio")]
        [Display(Name = "Azienda")]
        public bool Azienda { get; set; }

        [Display(Name = "Codice Fiscale")]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "Il Codice Fiscale deve contenere 16 caratteri")]
        public string Cod_Fisc { get; set; }

        [Display(Name = "Partiva Iva")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Il Codice Fiscale deve contenere 11 cifre")]
        public string PI { get; set; }

        [Required(ErrorMessage = "Campo Email obbligatorio")]
        [StringLength(255, ErrorMessage = "Il codice fiscale deve avere massimo 255 caratteri")]
        [RegularExpression(@"^[\w-.]+@([\w-]+.)+[\w-]{2,4}$", ErrorMessage = "Inserisci un indirizzo email valido")]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [Display(Name = "Telefono")]
        [StringLength(20, MinimumLength = 7, ErrorMessage = "Il Telefono deve contenere almeno 7 cifre")]
        public string Tel { get; set; }

        [Required(ErrorMessage = "Campo Nome obbligatorio")]
        [StringLength(50, ErrorMessage = "Il nome deve avere un massimo di 50 caratteri")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Cognome")]
        [StringLength(50, ErrorMessage = "Il cognome deve avere un massimo di 50 caratteri")]
        public string Cognome { get; set; }

    }
}