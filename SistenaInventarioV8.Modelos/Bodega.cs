﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioV8.Modelos
{
    public class Bodega


    {
        [Key]
        public int  Id { get; set; }

        [Required(ErrorMessage = "Nombre es requerido")]
        [MaxLength (60, ErrorMessage = "Nombre debe ser maximo de 60 caracteres")]
       public string Nombre { get; set; }

        [Required(ErrorMessage = "Descripcion es requerida")]
        [MaxLength(100, ErrorMessage = "Descripcion debe ser maximo de 100 caracteres")]
         public string Descripcion { get; set; }

        [Required(ErrorMessage = "Estado es requerido")]
        public bool Estado { get; set;}


    }
}
