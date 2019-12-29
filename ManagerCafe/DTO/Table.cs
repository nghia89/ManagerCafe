using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCafe.DTO
{
   public class Table
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public int Id { get; set; }

        public static Table From(DataRow dataRow)
        {
            if (dataRow == null) return null;
            return new Table()
            {
                Id = (int)dataRow["id"],
                Name=dataRow["name"].ToString(),
                Status=dataRow["status"].ToString()
            };
        }
    }
}
