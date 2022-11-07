using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string URL { get; set; }
        public List<Post> Posts { get; set; }
    }
}
