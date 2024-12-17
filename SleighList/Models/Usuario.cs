using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SleighList.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }
        public string ? Nome { get; set; }
        public string ? Email { get; set; }
        public string ? Senha { get; set; }


        [ForeignKey("Item")]
        public int ? ItemID { get; set; }
        public Item ? Item{ get; set; }
        
    }

}