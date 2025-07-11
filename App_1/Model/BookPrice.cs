namespace App_1
{
    public class BookPrice
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CurrencyId { get; set; }
        public int Amount { get; set; }


        public Book books { get; set; }
        public Currency currency { get; set; }
    }
}
