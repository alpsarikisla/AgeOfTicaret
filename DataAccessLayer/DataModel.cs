using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            cmd = con.CreateCommand();
        }

        #region Category Functions

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            try
            {
                cmd.CommandText = "SELECT CategoryID,CategoryName,Description FROM Categories";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Category c = new Category() { CategoryID = reader.GetInt32(0), CategoryName = reader.GetString(1), Description = !reader.IsDBNull(2) ? reader.GetString(2) : "Açıklama Yok" };
                    categories.Add(c);
                }
                return categories;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public Category AddCategory(Category model)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Categories(CategoryName, Description) VALUES(@categoryName,@description) SELECT @@IDENTITY";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@categoryName", model.CategoryName);
                cmd.Parameters.AddWithValue("@description", model.Description);
                con.Open();
                model.CategoryID = Convert.ToInt32(cmd.ExecuteScalar());
                return model;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public Category GetCategory(int id)
        {
            try
            {
                cmd.CommandText = "SELECT CategoryID,CategoryName,Description FROM Categories WHERE CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Category c = new Category();
                while (reader.Read())
                {
                    c.CategoryID = reader.GetInt32(0);
                    c.CategoryName = reader.GetString(1);
                    c.Description = !reader.IsDBNull(2) ? reader.GetString(2) : "Açıklama Yok";
                }
                return c;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public bool UpdateCategory(Category model)
        {
            try
            {
                cmd.CommandText = "UPDATE Categories SET CategoryName = @categoryName, Description =@description WHERE CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", model.CategoryID);
                cmd.Parameters.AddWithValue("@categoryName", model.CategoryName);
                cmd.Parameters.AddWithValue("@description", model.Description);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public void RemoveCategory(int id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM Categories WHERE CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region Employee Functions


        public Employee GetEmployee(int id)
        {
            try
            {
                Employee model = new Employee();
                cmd.CommandText = "SELECT [EmployeeID],[UserName],[Password],[LastName],[FirstName],[Title],[TitleOfCourtesy],[BirthDate],[HireDate],[Address],[City],[Region],[PostalCode],[Country],[HomePhone],[Extension],[Notes],[ReportsTo],[PhotoPath],[TitleOfCourtesy] +' '+ [FirstName] + ' ' + [LastName] AS Fullname FROM Employees WHERE EmployeeID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    model.EmployeeID = reader.GetInt32(0);
                    model.UserName = reader.GetString(1);
                    model.Password = reader.GetString(2);
                    model.LastName = reader.GetString(3);
                    model.FirstName = reader.GetString(4);
                    model.Title = reader.GetString(5);
                    model.TitleOfCourtesy = reader.GetString(6);
                    model.BirthDate = reader.GetDateTime(7);
                    model.HireDate = reader.GetDateTime(8);
                    model.Address = reader.GetString(9);
                    model.City = reader.GetString(10);
                    model.Region = !reader.IsDBNull(11) ? reader.GetString(11): "";
                    model.PostalCode = reader.GetString(12);
                    model.Country = reader.GetString(13);
                    model.HomePhone = reader.GetString(14);
                    model.Extension = reader.GetString(15);
                    model.Notes = reader.GetString(16);
                    model.ReportsTo = !reader.IsDBNull(17) ? reader.GetInt32(17) : 0;
                    model.PhotoPath = reader.GetString(18);
                    model.FullName = reader.GetString(19);
                }
                return model;
            }
            catch(Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public Employee EmployeeLogin(string username, string password)
        {
            Employee model = new Employee();
            try
            {
                cmd.CommandText = "SELECT EmployeeID FROM Employees WHERE UserName=@userName AND Password = @password";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@userName", username);
                cmd.Parameters.AddWithValue("@password", password);
                con.Open();
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                if (id > 0)
                {
                    model = GetEmployee(id);
                }
                return model;
            }
            catch(Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion
    }
}
