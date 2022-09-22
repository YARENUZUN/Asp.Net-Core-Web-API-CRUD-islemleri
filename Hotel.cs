using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;

namespace HotelFinder.Entities
{
    public class Hotel
    {
        
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string City { get; set; }
    }
}