using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatraSports.BL
{
    public class Producto
    {
        public Producto()
        {
            Activo = true;
        }

        public int Id { get; set; }
        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Ingrese la Descripcion")]
        [MinLength(3, ErrorMessage = ("Ingrese minimo 3 caracteres"))]
        [MaxLength(20, ErrorMessage = ("Ingrese maximo de 20 caracteres"))]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = ("Ingrese el Precio"))]
        [Range(0, 1000, ErrorMessage =("Ingrese un Precio entre 0 y 1000"))]
        public double Precio { get; set; }
       
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }

        public bool Activo { get; set; }
    }
}
