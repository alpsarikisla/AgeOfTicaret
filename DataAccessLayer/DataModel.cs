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
    }
}
