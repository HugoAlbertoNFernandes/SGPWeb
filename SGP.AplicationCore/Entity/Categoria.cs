using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SGP.AplicationCore.Entity
{
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoriaId { get; set; }
        [Display(Name = "Categoria")]
        public string Descricao { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }

        public Categoria()
        {
            Produtos = new List<Produto>();
        }
    }
}
