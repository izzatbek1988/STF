namespace STF.Entities.Models
{
    public class ProductEntity : BaseEntity
    {
        public string ProductName { get; set; }
        public Guid ProductCategoryID { get; set; }
        public Guid ProductUnitID { get; set; }

        //Reliation

        public virtual CategoryEntitiy Category { get; set; }
        public virtual UnitEntitiy Units { get; set; }



    }
}
