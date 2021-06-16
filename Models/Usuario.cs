using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Practica_4.Models
{
     [Table ("Usuario")]
    public class Usuario
    {
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id {get; set;}
        
        [Column("Titulo")]
        public String Titulo{get; set;}

         [Column("Nombre")]
        public String Nombre {get; set;}
        
        
        [Column("imagen")] 
        public String imagen { get; set; }   
    }
}
