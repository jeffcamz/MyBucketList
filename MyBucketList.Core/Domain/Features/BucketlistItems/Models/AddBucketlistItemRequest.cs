using MediatR;
using MyBucketList.Core.Domain.Entities;
using System;

namespace MyBucketList.Core.Domain.Features.BucketlistItems.Models
{
    public class AddEditBucketlistItemRequest : IRequest<BucketlistItem>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Period { get; set; }

        
    }
}
