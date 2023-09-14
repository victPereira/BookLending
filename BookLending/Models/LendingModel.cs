namespace BookLending.Models
{
    public class LendingModel
    {
        public int Id { get; set; }
        public string Receiver { get; set; }
        public string Supplier { get; set; }
        public string BookLend { get; set; }

        //Propiedade do banco de dados sempre ira pegar a data atual
        public DateTime DataEndAtt { get; set; } = DateTime.Now;
    }
}
