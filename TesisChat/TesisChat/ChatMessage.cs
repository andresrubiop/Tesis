using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesisChat
{
    class ChatMessage
    {
        private readonly string values;

        public ChatMessage(string values)
        {
            this.values = values;
        }

        public string Values
        {
            get { return this.values; }
        }

        public override string ToString()
        {
            return this.values;
        }
    }
}
