using System.ComponentModel.DataAnnotations;

namespace AlexaSkillsAnasinf.Fichajes.Model
{
    public class TbdAccesos
    {   [Required (ErrorMessage = "CBA es requerido",AllowEmptyStrings = false)]
        public string CBA { get; set; }
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Anyo { get; set; }
        public int Hora { get; set; }
        public int Minuto { get; set; }
        public int CDAH { get; set; }
        public int CDAL { get; set; }
        public int SUMA { get; set; }
        public int Valor { get; set; }
        public string NumReloj { get; set; }
    }
}