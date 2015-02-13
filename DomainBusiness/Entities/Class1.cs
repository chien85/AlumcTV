using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainBusiness.Entities
{
    public class Video
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string ChannelId { get; set; }
        public int Weight { get; set; }
        public DateTime AdditiionDate { get; set; }
        public string UserId { get; set; }
        public string Description { get; set; }
  
    }
    public class User
    {

    }
    public class Role
    {

    }
    public class Playlist
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public byte[] Icon{get;set;}
        public int UserId{get;set;}
        public string Description{get;set;}
        public bool Lock{get;set;}
        public string slug{get;set;}

    }
    
}
