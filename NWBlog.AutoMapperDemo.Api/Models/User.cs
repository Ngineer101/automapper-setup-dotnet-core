using System.Collections.Generic;

namespace NWBlog.AutoMapperDemo.Api.Models
{
    public class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public List<Pet> Pets { get; set; }
    }
}
