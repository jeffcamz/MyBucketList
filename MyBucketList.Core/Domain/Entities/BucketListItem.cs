using SQLite;
using System;

namespace MyBucketList.Core.Domain.Entities
{
    [Table("bucketListItem")]
    public class BucketlistItem
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public string Period
        {
            get
            {
                return String.Format("{0} - {1}",
                         DateFrom.ToString("MMM d, yyyy"),
                         DateFrom.ToString("MMM d, yyyy"));
            }
        }
    }
}
