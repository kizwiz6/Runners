using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runners
{
    public class Run : IComparable<Run>
    {
        public string PersonName { get; }
        public string PersonFamilyName { get; }
        public double Time { get; }

        public Run(string personName, string personFamilyName, double time)
        {
            PersonName = personName;
            PersonFamilyName = personFamilyName;
            Time = time;
        }

        public int CompareTo(Run other)
        {
            return Time.CompareTo(other.Time);
        }
    }
}
