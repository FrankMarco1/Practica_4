using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Practica_4.Models
{
     [Table ("Visitante")]
    public class Visitante
    {
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id {get; set;}
        
        
         [Column("Nombre")]
        public String Nombre {get; set;}
        
        
        [Column("Comentario")] 
        public String Comentario { get; set; }   
    }
}
