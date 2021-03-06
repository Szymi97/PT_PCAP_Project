using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_MAPACKET.Models
{
    public class MyPacket
    {
        public int Id { get; set; }

        public string Time { get; set; }

        public string SourceMac { get; set; }

        public string DestMac { get; set; }

        public string SourceIP { get; set; }

        public string DestIP { get; set; }

        public string Checksum { get; set; }

        public int Length { get; set; }

        public override string ToString()
        {
            var values = new { Id, Time, SourceMac, SourceIP, DestMac, DestIP, Checksum, Length };
            return String.Join(",", values);
        }
    }
}
