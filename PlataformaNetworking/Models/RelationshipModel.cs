using System;
using PlataformaNetworking.Models.Enums;

namespace PlataformaNetworking.Models
{
    public class RelationshipModel
    {
        public Guid Id { get; set; }

        public Guid? UserId1 { get; set; }

        public Guid? UserId2 { get; set; }

        public RelationshipStatus? Status { get; set; }
    }
}
