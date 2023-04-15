using System.ComponentModel.DataAnnotations;

namespace UniversityAppBackend.Models.DataModels
{
    public class Curso:BaseEntity
    {
        [Required, StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string DescripcionCorta { get; set; } = string.Empty;

        [Required, StringLength(250)]
        public string DescripcionLarga { get; set; } = string.Empty;

        [Required]
        public string PublicoObjetivo { get; set; } = string.Empty;

        [Required]
        public string Objectivos { get; set; } = string.Empty;

        [Required]
        public string Requisitos { get; set; } = string.Empty;

        [Required]
        public Nivel NivelCurso { get; set; }
    }

    public enum Nivel
    {
        Basico=1,
        Intermedio=2,
        Avanzado=3
    }
}
