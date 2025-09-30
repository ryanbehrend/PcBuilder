using System.Collections.Generic;

namespace PcBuilder.Models
{
    public class Build
    {
        public int Id { get; set; }
        public List<int> PartIds { get; set; } = new List<int>();
    }
}
