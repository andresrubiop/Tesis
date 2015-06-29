using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesisChat

{
    public class User
    {
        private string userName;
        private string id;

         public User(string userName,string id)
        {
            this.userName = userName;
            this.id = id;


        }

         public string UserName
         {
             
             get 
             {
                 return this.userName;
             }
             set
             {
                 userName = value;
             }


         }
         public string Id
         {
             get
             { 
                 return this.id;
             }
             set 
             {
                 id = value;
             }
         }
         public override string ToString()
         {
             return this.userName;
         }
    }
}
