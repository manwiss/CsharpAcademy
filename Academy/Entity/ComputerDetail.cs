using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ComputerDetail
    {
        public string Name { get; set; }
        public string User { get; set; }
        public string Cpu { get; set; }
        public int Ram { get; set; }
        public string VideoCard { get; set; }
        public string Ip { get; set; }
        public int ComputerDetailId  { get; set; }
        public ICollection<UsageData> UsageDataCollection { get; set; }

        public ComputerDetail()
        {
            UsageDataCollection = new List<UsageData>();
        }

    
    }
}
