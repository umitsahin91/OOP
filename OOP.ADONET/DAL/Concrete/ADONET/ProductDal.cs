using OOP.ADONET.DAL.Abtract;
using OOP.ADONET.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OOP.ADONET.DAL.Concrete.ADONET
{
    public class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            var cmd = new SqlCommand("INSERT INTO Products(ProductName, UnitPrice, UnitsInStock) VALUES(@ProductName,@UnitPrice,@UnitsInStock)");
            cmd.Parameters.AddWithValue("ProductName", entity.ProductName);
            cmd.Parameters.AddWithValue("UnitPrice", entity.UnitPrice);
            cmd.Parameters.AddWithValue("UnitsInStock", entity.UnitsInStock);
            RDMS.SqlNonQuery(cmd);
        }

        public void Delete(Product entity)
        {
            var cmd = new SqlCommand("DELETE FROM Products WHERE ProductID=@ProductId");
            cmd.Parameters.AddWithValue("ProductId", entity.ProductId);
            RDMS.SqlNonQuery(cmd);
        }

        public List<Product> GetAll()
        {
            var _list = new List<Product>();
            var cmd = new SqlCommand("SELECT ProductID, ProductName, UnitPrice, UnitsInStock FROM Products");
            var ds = RDMS.SqlReader(cmd);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                _list.Add(
                    new Product
                    {
                        ProductId = int.Parse(item[0].ToString()),
                        ProductName = item[1].ToString(),
                        UnitPrice = decimal.Parse(item[2].ToString()),
                        UnitsInStok = int.Parse(item[3].ToString())
                    }
                    );
            }

            return _list;
        }

        public void Update(Product entity)
        {
            var cmd = new SqlCommand("UPDATE Products SET ProductName=@ProductName, UnitPrice=@UnitPrice, UnitsInStock=@UnitsInStock WHERE ProductID=@ProductId");
            cmd.Parameters.AddWithValue("ProductId", entity.ProductId);
            cmd.Parameters.AddWithValue("ProductName", entity.ProductName);
            cmd.Parameters.AddWithValue("UnitPrice", entity.UnitPrice);
            cmd.Parameters.AddWithValue("UnitsInStock", entity.UnitsInStock);

            RDMS.SqlNonQuery(cmd);
        }
    }
}
