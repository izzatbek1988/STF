namespace STF.Entities.Models
{
    public class AppUserProfile : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LastEmail { get; set; }
        
        //relation

        public virtual AppUser AppUser { get; set; }
    }
}
