using OOP.ADONET.DAL.Abtract;
using OOP.ADONET.Entities;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ADONET.DAL.Concrete.ADONET
{
    public class EmployeeDal : IEmployeeDal
    {
        public void Add(Employee entity)
        {
            var cmd = new SqlCommand("INSERT INTO Employees(FirstName, LastName) VALUES(@FirstName,@LastName)");
            cmd.Parameters.AddWithValue("FirstName", entity.FirstName);
            cmd.Parameters.AddWithValue("LastName", entity.LastName);
            RDMS.SqlNonQuery(cmd);
        }

        public void Delete(Employee entity)
        {
            var cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeID=@EmployeeId");
            cmd.Parameters.AddWithValue("EmployeeID", entity.EmployeeId);
            RDMS.SqlNonQuery(cmd);
        }

        public List<Employee> GetAll()
        {
            var _list = new List<Employee>();
            var cmd = new SqlCommand("SELECT EmployeeID, FirstName, LastName FROM Employees");
            var ds = RDMS.SqlReader(cmd);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                _list.Add(
                    new Employee
                    {
                        EmployeeId = int.Parse(item[0].ToString()),
                        FirstName = item[1].ToString(),
                        LastName = item[2].ToString()
                    }
                    );
            }

            return _list;
        }

        public void Update(Employee entity)
        {
            var cmd = new SqlCommand("UPDATE Employees SET FirstName=@FirstName, LastName=@LastName WHERE EmployeeID=@EmployeeId");
            cmd.Parameters.AddWithValue("EmployeeID", entity.EmployeeId);
            cmd.Parameters.AddWithValue("FirstName", entity.FirstName);
            cmd.Parameters.AddWithValue("LastName", entity.LastName);
            RDMS.SqlNonQuery(cmd);
        }
    }
}
