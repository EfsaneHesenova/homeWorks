using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace AcademyDBCRUDtask.Helpers
{
    public class InvalidTableNameException : Exception
    {
        
        public InvalidTableNameException(string message) : base(message)
        {
        }

        
        public InvalidTableNameException() : base("Invalid Table Name")
        {
        }
    }
}
