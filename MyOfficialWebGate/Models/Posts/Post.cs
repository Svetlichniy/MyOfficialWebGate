using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOfficialWebGate.Data.Posts
{
    public class Post
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Header { get; set; }
        public string PostContent { get; set; }
    }
}
