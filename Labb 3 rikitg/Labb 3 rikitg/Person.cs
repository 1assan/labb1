using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3_rikitg
{
    public class Person
    {public Gender Gender { get; set; }
        public Hair Hair { get; set; }

        public DateTime Birthday { get; set; }

        public string EyeColor { get; set; }

        public override string ToString()
        {
            return $"Kön: {Gender}, Hårlängd: {Hair.HairLength} cm, Hårfärg: {Hair.HairColor}, Födelsedag: {Birthday.ToShortDateString()}, Ögonfärg: {EyeColor}";
        }
    }
}
