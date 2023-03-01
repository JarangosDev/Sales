﻿using System.ComponentModel.DataAnnotations;

namespace Sales.Shared.Entities
{
    public class Product
    {

        public int Id { get; set; }

        [Display(Name = "Producto")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caractéres.")]
        public string Name { get; set; } = null!;

        public int ProdCategoryId { get; set; }
        public ProdCategory? ProdCategory { get; set; }
    }
}