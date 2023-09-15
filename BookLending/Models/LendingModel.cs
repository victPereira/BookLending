using System.ComponentModel.DataAnnotations;

namespace BookLending.Models
{
    public class LendingModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter the name of the Receiver!!!")]
        public string Receiver { get; set; }

        [Required(ErrorMessage = "Enter the name of the Supplier!!!")]
        public string Supplier { get; set; }

        [Required(ErrorMessage = "Enter the name of the Book!!!")]
        public string BookLend { get; set; }

        //Propiedade do banco de dados sempre ira pegar a data atual
        public DateTime DataEndAtt { get; set; } = DateTime.Now;
    }
}
