using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyDBCRUDtask.Services.Interfaces
{
    public interface ICrud
    {
        public void InsertData();
        public void SelectData();
        public void UpdateData();
        public void DeleteData();
    }
}
