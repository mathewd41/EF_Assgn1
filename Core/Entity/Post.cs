using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Post : BaseEntity
    {
      
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public int PostTypeId { get; set; }
        public PostType postType { get; set; }

        public int UserId { get; set; }
        public UserEntity User { get; set; }
    }
}
