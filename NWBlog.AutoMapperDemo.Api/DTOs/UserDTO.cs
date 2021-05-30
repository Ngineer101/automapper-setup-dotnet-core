using AutoMapper;
using AutoMapper.Configuration.Annotations;
using NWBlog.AutoMapperDemo.Api.Models;
using System.Collections.Generic;

namespace NWBlog.AutoMapperDemo.Api.DTOs
{
    [AutoMap(typeof(User), ReverseMap = true)]
    public class UserDTO
    {
        public long Id { get; set; }

        [SourceMember(nameof(User.FirstName))]
        public string Name { get; set; }

        [IgnoreMap]
        public List<long> PetIds { get; set; }
    }
}
