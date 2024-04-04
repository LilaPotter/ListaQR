using System.ComponentModel.DataAnnotations;

namespace ListaQR.Models
{
    public class usuarios_model
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public string correo_electronico {get; set;}
    }
}
