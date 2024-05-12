namespace STF.Entities.Models
{
    public class STFDetails:BaseEntity
    {
        public Guid ProductID { get; set; }
        public Guid STFID { get; set; }

        //relation

        public virtual ProductEntity Product { get; set; }
        public virtual STFEntitiy STF { get; set; }
    }
}
