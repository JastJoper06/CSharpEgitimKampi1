using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("------------------------------------");
            #region Kategori Ekleme İşlemi
            //Console.WriteLine("Eklemek İstediğiniz Kategori Adı:");

            //string CategoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source= JASTJOPER\\JEYJEYJAVO; initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);

            //command.Parameters.AddWithValue("@p1", CategoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori Başarıyla Eklendi");
            #endregion

            #region Ürün Ekleme İşlemi
            //string ProductName;
            //decimal ProductPrice;

            //Console.Write("Ürün adı: ");
            //ProductName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //ProductPrice = Decimal.Parse(Console.ReadLine());

            //// SqlConnection dizesinde boşluk ve biçim hatası yok.
            //SqlConnection connection = new SqlConnection("Data Source=JASTJOPER\\JEYJEYJAVO; initial catalog=EgitimKampiDb; integrated security=true");

            //connection.Open();

            //// Fazladan noktalı virgül (;) kaldırıldı.
            //SqlCommand command = new SqlCommand("INSERT INTO TblProduct (ProductName, ProductPrice, ProductStatus) VALUES (@productName, @productPrice, @productStatus)", connection);

            //// Parametreler doğru şekilde eklendi.
            //command.Parameters.AddWithValue("@productName", ProductName);
            //command.Parameters.AddWithValue("@productPrice", ProductPrice);
            //command.Parameters.AddWithValue("@productStatus", true);

            //command.ExecuteNonQuery(); // Sorgu çalıştırılıyor.
            //connection.Close(); // Bağlantı kapatılıyor.

            //Console.Write("Ürün Eklemesi Başarılı");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=JASTJOPER\\JEYJEYJAVO; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();

            //}

            //connection.Close();


            #endregion

            #region Ürün Silme İşlemi
            //Console.Write("Silinecek Ürün Id girin: ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=JASTJOPER\\JEYJEYJAVO; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductID=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //Console.Write("Silme İşlemi yapıldı.");


            //connection.Close();

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün ID: ");

            //int productId=int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());




            //SqlConnection connection = new SqlConnection("Data Source=JASTJOPER\\JEYJEYJAVO; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductID = @productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);

            //command.ExecuteNonQuery();
            //command.Clone();

            //Console.Write("Ürün Güncelleme İşlemi Başarılı");   

            //connection.Close();

            #endregion




            Console.Read();
        }
    }
}
