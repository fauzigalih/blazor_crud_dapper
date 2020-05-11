using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDapperCRUD.Data
{
    public class Video
    {
        public int videoId{ get; set; }
        public string title { get; set; }
        public DateTime datePublished { get; set; }
        public bool isActive { get; set; }
    }
}