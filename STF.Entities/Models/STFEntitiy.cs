namespace STF.Entities.Models
{
    public  class STFEntitiy:BaseEntity
    {
        public string STFNo { get; set; }
        public Guid AppUserID { get; set; }
        public Guid StatusID { get; set; }


        //relation
        public virtual AppUser AppUser { get; set; }
    }
}
