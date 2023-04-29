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
                    model.Region = !reader.IsDBNull(11) ? reader.GetString(11) : "";
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
            catch (Exception ex)
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
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region Product Functions

        public List<Product> ProductList()
        {
            List<Product> products = new List<Product>();
            try
            {
                cmd.CommandText = "SELECT p.ProductID, p.ProductName,p.SupplierID, s.CompanyName,p.CategoryID, c.CategoryName, p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued, p.ImagePath, p.Barcode FROM Products AS p JOIN Categories AS c ON c.CategoryID = p.CategoryID JOIN Suppliers AS s ON s.SupplierID = p.SupplierID";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product model = new Product()
                    {
                        ProductID = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        SupplierID = reader.GetInt32(2),
                        Supplier = reader.GetString(3),
                        CategoryID = reader.GetInt32(4),
                        Category = reader.GetString(5),
                        QuantityPerUnit = !reader.IsDBNull(6) ? reader.GetString(6) : "",
                        UnitPrice = reader.GetDecimal(7),
                        UnitsInStock = reader.GetInt16(8),
                        UnitsOnOrder = reader.GetInt16(9),
                        ReorderLevel = reader.GetInt16(10),
                        Discontinued = reader.GetBoolean(11),
                        ImagePath = !reader.IsDBNull(12) ? reader.GetString(12) : "product.png",
                        Barcode = reader.IsDBNull(13) ? "" : reader.GetString(13)
                    };
                    products.Add(model);
                }
                return products;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public Product GetProduct(int id)
        {

            try
            {
                cmd.CommandText = "SELECT p.ProductID, p.ProductName,p.SupplierID, s.CompanyName,p.CategoryID, c.CategoryName, p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued, p.ImagePath, p.Barcode FROM Products AS p JOIN Categories AS c ON c.CategoryID = p.CategoryID JOIN Suppliers AS s ON s.SupplierID = p.SupplierID WHERE p.ProductID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Product model = new Product();
                while (reader.Read())
                {
                    model.ProductID = reader.GetInt32(0);
                    model.ProductName = reader.GetString(1);
                    model.SupplierID = reader.GetInt32(2);
                    model.Supplier = reader.GetString(3);
                    model.CategoryID = reader.GetInt32(4);
                    model.Category = reader.GetString(5);
                    model.QuantityPerUnit = !reader.IsDBNull(6) ? reader.GetString(6) : "";
                    model.UnitPrice = reader.GetDecimal(7);
                    model.UnitsInStock = reader.GetInt16(8);
                    model.UnitsOnOrder = reader.GetInt16(9);
                    model.ReorderLevel = reader.GetInt16(10);
                    model.Discontinued = reader.GetBoolean(11);
                    model.ImagePath = !reader.IsDBNull(12) ? reader.GetString(12) : "product.png";
                    model.Barcode = reader.IsDBNull(13) ? "" : reader.GetString(13);
                }
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

        public bool AddProduct(Product model)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued, Barcode, IsFastProduct, ImagePath ) VALUES (@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice, @UnitsInStock, @UnitsOnOrder, @ReorderLevel, @Discontinued, @Barcode, @IsFastProduct, @ImagePath)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ProductName", model.ProductName);
                cmd.Parameters.AddWithValue("@SupplierID", model.SupplierID);
                cmd.Parameters.AddWithValue("@CategoryID", model.CategoryID);
                cmd.Parameters.AddWithValue("@QuantityPerUnit", model.QuantityPerUnit);
                cmd.Parameters.AddWithValue("@UnitPrice", model.UnitPrice);
                cmd.Parameters.AddWithValue("@UnitsInStock", model.UnitsInStock);
                cmd.Parameters.AddWithValue("@UnitsOnOrder", model.UnitsOnOrder);
                cmd.Parameters.AddWithValue("@ReorderLevel", model.ReorderLevel);
                cmd.Parameters.AddWithValue("@Discontinued", model.Discontinued);
                cmd.Parameters.AddWithValue("@Barcode", model.Barcode);
                cmd.Parameters.AddWithValue("@IsFastProduct", model.IsFastProduct);
                cmd.Parameters.AddWithValue("@ImagePath", model.ImagePath);
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

        #endregion

        #region Supplier Functions

        public List<Supplier> SupplierList()
        {
            List<Supplier> suppliers = new List<Supplier>();
            try
            {
                cmd.CommandText = "SELECT [SupplierID],[CompanyName] ,[ContactName],[ContactTitle],[Address],[City],[Region],[PostalCode],[Country],[Phone],[Fax],[HomePage] FROM Suppliers";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Supplier model = new Supplier();
                    model.ID = reader.GetInt32(0);
                    model.companyName = reader.GetString(1);
                    model.contactName = !reader.IsDBNull(2) ? reader.GetString(2) : "";
                    model.contactTitle = !reader.IsDBNull(3) ? reader.GetString(3) : "";
                    model.address = !reader.IsDBNull(4) ? reader.GetString(4) : "";
                    model.city = !reader.IsDBNull(5) ? reader.GetString(5) : "";
                    model.region = !reader.IsDBNull(6) ? reader.GetString(6) : "";
                    model.postalCode = !reader.IsDBNull(7) ? reader.GetString(7) : "";
                    model.country = !reader.IsDBNull(8) ? reader.GetString(8) : "";
                    model.phone = !reader.IsDBNull(9) ? reader.GetString(9) : "";
                    model.fax = !reader.IsDBNull(10) ? reader.GetString(10) : "";
                    model.homePage = !reader.IsDBNull(11) ? reader.GetString(11) : "";
                    suppliers.Add(model);
                }
                return suppliers;
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

        #endregion
    }
}
