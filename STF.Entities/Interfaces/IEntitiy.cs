namespace STF.Entities.Interfaces
{
    public interface IEntitiy
    {
        public Guid ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid CreatedUser { get; set; }
        public Guid? ModifiedUser { get; set; }
        public string? Description { get; set; }
    }
}
