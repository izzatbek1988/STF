namespace STF.Entities.Models
{
    public class CategoryEntitiy:BaseEntity
    {
        public string CategoryName { get; set; }

        //Relation

        public virtual List<ProductEntity> Products { get; set; }

    }
}
