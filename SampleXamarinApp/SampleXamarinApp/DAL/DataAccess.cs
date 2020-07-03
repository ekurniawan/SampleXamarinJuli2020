using SampleXamarinApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Essentials;

namespace SampleXamarinApp.DAL
{
    public class DataAccess
    {
        private SQLiteConnection db;
        public SQLiteConnection GetConnection()
        {
            SQLiteConnection sqlConn;
            var dbName = "MyDb.db3";
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, dbName);
            sqlConn = new SQLiteConnection(dbPath);
            return sqlConn;
        }

        public DataAccess()
        {
            db = GetConnection();
            db.CreateTable<Employee>();
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            //return db.Query<Employee>("select * from Employee order by EmpName asc");
            var result = from e in db.Table<Employee>()
                         orderby e.EmpId
                         select e;

            return result;
        }

        public int InsertEmployee(Employee emp)
        {
            return db.Insert(emp);
        }

        public int EditEmployee(Employee emp)
        {
            return db.Update(emp);
        }

        public int DeleteEmployee(Employee emp)
        {
            /*var del = from e in db.Table<Employee>()
                      where e.EmpName.ToLower().Contains("erick")
                      select e;*/

            return db.Delete(emp);
        }
    }
}
