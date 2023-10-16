namespace Rms.Builder.Entity
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public string? CreatedByName { get; set; }
        public DateTime Created { get; set; }
        public int? LastChangedBy { get; set; }
        public string? LastChangedByName { get; set; }
        public DateTime? LastChanged { get; set; }
    }
}
