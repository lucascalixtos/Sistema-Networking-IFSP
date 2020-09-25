using CadernoDigitalColaborativo.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadernoDigitalColaborativo.Models
{
    public class RelationshipModel
    {
        public Guid Id { get; set; }

        public Guid? UserId1 { get; set; }

        public Guid? UserId2 { get; set; }

        public RelationshipStatus? Status { get; set; }
    }
}
