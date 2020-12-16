using System;
using System.ComponentModel.DataAnnotations;


namespace PC3_PrograTeoria.Models
{
    public class Producto
    {
        public int Id { get; set;}

        [Required]
        [Display(Name="Nombre del Producto")]
        public string nameProduct { get; set;}

        [Required]
        public string urlProduct { get; set;}

        [Required]  
        [Display(Name="Descripción del Producto")]      
        public string describeProduct { get; set;}

        [Required]
        [Display(Name="Precio del Producto")]
        public double priceProduct { get; set;}
        
        [Required]
        [Display(Name="Celular de Contacto")]
        public string phoneProduct { get; set;}

        [Required]
        [Display(Name="Lugar de Pedido")]
        public string placeProduct { get; set;}

        [Required]
        [Display(Name="Nombre del Usuario")]
        public string userProduct { get; set;}

        public DateTime Date { get { return DateTime.Now; } }
    }
}