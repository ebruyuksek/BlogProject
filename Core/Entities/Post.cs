using Core.Abstract;
using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Post : Entity
    {
        public string Title { get; set; } = null!;
        public string Text { get; set; } = null!;
        public string? ImageUrl { get; set; }
    }
}
