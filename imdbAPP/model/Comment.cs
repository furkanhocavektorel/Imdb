using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imdbAPP.model
{
    public class Comment
    {
        public int Id { get; set; }
        // mantıksal ilişki
        public int MovieId { get; set; }
        // standart ilişki
        public Customer Customer { get; set; }
        public string CommentDescription { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
