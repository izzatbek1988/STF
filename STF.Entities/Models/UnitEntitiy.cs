namespace STF.Entities.Models
{
    public class UnitEntitiy:BaseEntity
    {
        public string UnitName { get; set; }

        //relation

        public virtual List<ProductEntity> Products { get; set; }
    }
}