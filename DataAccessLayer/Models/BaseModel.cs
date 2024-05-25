using System;

namespace DataAccessLayer.Models
{
    public abstract class BaseModel
    {
        public long Id { get; set; }
        public ApplicationUser CreatorUser { get; set; }
        public long CreatorId { get; set; }
        public long ModifierId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public int HVersion { get; set; }
        public bool IsDeleted { get; set; }
    }
}