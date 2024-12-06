using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSystemDemo
{
    public class FormattedName
    {
        string name;

        public FormattedName(string arg)
        {
            this.name = $"Mr.{arg}";
        }

        public static FormattedName operator +(FormattedName one, FormattedName two) {
            return new FormattedName($"{one.name} {two.name}");
        }

        public override string? ToString()
        {
            return this.name;
        }
    }
}
