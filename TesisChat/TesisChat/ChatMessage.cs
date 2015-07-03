using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesisChat
{
    class ChatMessage
    {
        private readonly string value;

        public ChatMessage(string value)
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
