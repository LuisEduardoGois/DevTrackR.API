using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTrackR.API.Entities
{
    public class PackageUpdate
    {
        public PackageUpdate(string status, int packageId)
        {
            Status = status;
            PackageId = packageId;
            UpdateDate = DateTime.Now;
        }

        public int Id { get; private set; }
        public int PackageId { get; private set; }
        public string Status { get; private set; }
        public DateTime UpdateDate { get; private set; }
    }
}