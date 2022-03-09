using System;
using System.ComponentModel.DataAnnotations;

namespace Prueba.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Compania { get; set; }
        public string Tipo { get; set; }
        public bool Estado { get; set; }

    }
}
