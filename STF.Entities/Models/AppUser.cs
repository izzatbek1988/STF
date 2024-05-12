using Microsoft.AspNetCore.Identity;
using STF.Entities.Interfaces;

namespace STF.Entities.Models
{
    public class AppUser : IdentityUser<Guid>, IEntitiy
    {
        public Guid ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid CreatedUser { get; set; }
        public Guid? ModifiedUser { get; set; }
        public string? Description { get; set; }

        //Relation
        public virtual AppUserProfile AppUserProfile { get; set; }
        public virtual List<STFEntitiy> STFs { get; set; }
    }
}
