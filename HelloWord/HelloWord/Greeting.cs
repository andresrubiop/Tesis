using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    public class Greeting
    {
        private readonly string value;

        public Greeting(string value)
        {
            this.value = value;
        }

        public string Value
        {
            get { return this.value; }
        }

        public override string ToString()
        {
            return this.value;
        }
    }
}
