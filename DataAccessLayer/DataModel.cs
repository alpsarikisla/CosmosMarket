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

        public User UserLogin(string userName, string password)
        {
            try
            {
                cmd.CommandText = "SELECT * FROM Users WHERE UserName=@username AND Password=@password";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("username", userName);
                cmd.Parameters.AddWithValue("password", password);
                con.Open();
                User u = null;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    u= new User();
                    u.ID = reader.GetInt32(0);
                    u.Name = reader.GetString(1);
                    u.Surname = reader.GetString(2);
                    u.UserName = reader.GetString(3);
                    u.Password = reader.GetString(4);
                    u.Status = reader.GetBoolean(5);
                }
                return u;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Category> GetCategories()
        {
            List<Category> Categories = new List<Category>();
            try
            {
                cmd.CommandText = "SELECT * FROM Categories";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Category c = new Category();
                    c.ID = reader.GetInt32(0);
                    c.Name = reader.GetString(1);
                    c.Description = reader.GetString (2);
                    Categories.Add(c);
                }
                return Categories;
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

        public bool AddCategory(Category c)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Categories(Name,Description) VALUES(@name,@description)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", c.Name);
                cmd.Parameters.AddWithValue("@description", c.Description);
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

        public bool DeleteCategory(int id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM Categories WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
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

        public Category GetCategory(int id)
        {
            Category c = new Category();
            try
            {
                cmd.CommandText = "SELECT * FROM Categories WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    c.ID = reader.GetInt32(0);
                    c.Name = reader.GetString(1);
                    c.Description = reader.GetString(2);
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

        public bool UpdateCategory(Category c)
        {
            try
            {
                cmd.CommandText = "UPDATE Categories SET Name=@name, Description = @description WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", c.ID);
                cmd.Parameters.AddWithValue("@name", c.Name);
                cmd.Parameters.AddWithValue("@description", c.Description);
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

        public int AddBrand(Brand b)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Brands(Name, Status) VALUES(@name, @status) SELECT @@IDENTITY";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", b.Name);
                cmd.Parameters.AddWithValue("@status", b.Status);
                con.Open();
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                return id;
            }
            catch
            {
                return -1;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Brand> GetBrands()
        {
            List<Brand> brands = new List<Brand>();
            try
            {
                cmd.CommandText = "SELECT * FROM Brands";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    brands.Add(new Brand()
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Status = reader.GetBoolean(2)
                    });
                    //Brand b = new Brand();
                    //b.ID = reader.GetInt32(0);
                    //b.Name = reader.GetString(1);
                    //b.Status = reader.GetBoolean(2);
                    //brands.Add(b);
                }
                return brands;
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

        public bool DeleteBrand(int id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM Brands WHERE ID= @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
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

        public Brand GetBrand(int id)
        {
            Brand b = new Brand();
            try
            {
                cmd.CommandText = "SELECT * FROM Brands WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    b.ID = reader.GetInt32(0);
                    b.Name = reader.GetString(1);
                    b.Status = reader.GetBoolean(2);
                }
                return b;
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

        public bool UpdateBrand(Brand b)
        {
            try
            {
                cmd.CommandText = "UPDATE Brands SET Name=@name, Status = @status WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", b.ID);
                cmd.Parameters.AddWithValue("@name", b.Name);
                cmd.Parameters.AddWithValue("@status", b.Status);
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

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                cmd.CommandText = "SELECT P.ID, P.BarcodeNo, P.ProductName, P.Category_ID, C.Name, P.Brand_ID, B.Name, P.Stock, P.Price FROM Products AS P JOIN Categories AS C ON P.Category_ID = C.ID JOIN Brands AS B ON P.Brand_ID = B.ID";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Product()
                    {
                        ID = reader.GetInt32(0),
                        BarcodeNo = reader.GetString(1),
                        ProductName = reader.GetString(2),
                        Category_ID = reader.GetInt32(3),
                        Category = reader.GetString(4),
                        Brand_ID = reader.GetInt32(5),
                        Brand = reader.GetString(6),
                        Stock = reader.GetInt32(7),
                        Price = reader.GetDecimal(8)
                    });
                }
                return products;
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

        public int AddProduct(Product p)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Products(ProductName, BarcodeNo,Category_ID,Brand_ID,Stock,Price) VALUES(@productName, @barcodeNo,@category_ID,@brand_ID,@stock,@price) SELECT @@IDENTITY";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@productName", p.ProductName);
                cmd.Parameters.AddWithValue("@barcodeNo", p.BarcodeNo);
                cmd.Parameters.AddWithValue("@category_ID", p.Category_ID);
                cmd.Parameters.AddWithValue("@brand_ID", p.Brand_ID);
                cmd.Parameters.AddWithValue("@stock", p.Stock);
                cmd.Parameters.AddWithValue("@price", p.Price);
                con.Open();
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                return id;
            }
            catch
            {
                return -1;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
