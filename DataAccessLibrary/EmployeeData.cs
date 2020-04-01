using DataAccessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class EmployeeData : IEmployeeData
    {
        private readonly ISqlDataAccess db;

        public EmployeeData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public Task<List<EmployeeModel>> GetEmployeeAsync()
        {
            string sql = "select * from Employee";

            return this.db.LoadData<EmployeeModel, dynamic>(sql, new { });
        }

        public Task InsertEmployeeAsync(EmployeeModel employee)
        {
            string sql = @"insert into bdo.Employee(FirstName, LastName, Address, Email, Role)
                            values (@FirstName, @LastName, @Address, @Email, @Role);";

            return this.db.SaveData(sql, employee);
        }

        Task<List<EmployeeModel>> IEmployeeData.GetEmployee()
        {
            throw new NotImplementedException();
        }

        Task IEmployeeData.InsertEmployee(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }
    }
}
