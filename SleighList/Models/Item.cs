using System.ComponentModel.DataAnnotations;

namespace SleighList.Models
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }
        public string ? Nome { get; set; }
        public int PrecoUnidade { get; set; }
        public int Quantidade { get; set; }

    }
}