using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUZEY
{
    public class Ortak
    {
        public class Baglanti
        {
            public string sunucuAdres { get; set; }
            public string VeritabaniAdi { get; set; }
            public string username { get; set; }
            public string parola { get; set; }
        }
        public static string conStr = "";
        static public Baglanti baglantiBilgileri;
        public static Kullanicilar kullanici;





        public static void ConfigDoldur()
        {
            if (baglantiBilgileri == null)
            {

                string a = baglantiBilgileriGetir();

                baglantiBilgileri = Newtonsoft.Json.JsonConvert.DeserializeObject<Baglanti>(a);
                a = Newtonsoft.Json.JsonConvert.SerializeObject(baglantiBilgileri, Newtonsoft.Json.Formatting.Indented);
            }
            //string format = "metadata=res://*/Model.csdl|res://*/Model.ssdl|res://*/Model.msl;provider=System.Data.SqlClient;provider connection string=\"{0}\"";
            //string connectionString = "server=" + Ortak.baglantiBilgileri.sunucuAdres + ";database=" + baglantiBilgileri.VeritabaniAdi + ";userid=" + baglantiBilgileri.username + ";Password=" + baglantiBilgileri.parola + ";";
            string baglantiBilgisi = ConStrBuilder("System.Data.SqlClient", Ortak.baglantiBilgileri.sunucuAdres, Ortak.baglantiBilgileri.VeritabaniAdi, Ortak.baglantiBilgileri.username, Ortak.baglantiBilgileri.parola, "Model");
            conStr = baglantiBilgisi;

        }

        public static string conStrGetir()
        {
            if (conStr == "")
            {
                ConfigDoldur();
            }
            return Ortak.conStr;
        }
        public static string baglantiBilgileriGetir()
        {
            string bilgiler = "";
            string dosyaYolu = AppDomain.CurrentDomain.BaseDirectory;
            var a = File.ReadLines(dosyaYolu + @"\config.config");
            foreach (var il in a)
            {
                bilgiler += il;
            }
            return bilgiler;
        }
        public static string ConStrBuilder(string providerName, string serverName, string databaseName, string userName, string pass, string metadata)
        {
            try
            {
                // Initialize the connection string builder for the 
                // underlying provider.
                SqlConnectionStringBuilder sqlBuilder =
                    new SqlConnectionStringBuilder();

                // Set the properties for the data source.
                sqlBuilder.DataSource = serverName;
                sqlBuilder.InitialCatalog = databaseName;
                sqlBuilder.IntegratedSecurity = false;
                sqlBuilder.Password = pass;
                sqlBuilder.UserID = userName;
                sqlBuilder.MaxPoolSize = 20000;
                sqlBuilder.ConnectTimeout = 240;
                // Build the SqlConnection connection string. 
                string providerString = sqlBuilder.ToString();

                //Initialize the EntityConnectionStringBuilder.
                EntityConnectionStringBuilder entityBuilder =
                    new EntityConnectionStringBuilder();

                //Set the provider name.
                entityBuilder.Provider = providerName;

                // Set the provider-specific connection string.
                entityBuilder.ProviderConnectionString = providerString;

                // Set the Metadata location.
                entityBuilder.Metadata = @"res://*/" + metadata + @".csdl|
                                            res://*/" + metadata + @".ssdl|
                                            res://*/" + metadata + ".msl";

                return entityBuilder.ToString(); 
            }
            catch (Exception)
            {

                return "";
            }
        }

        //public string baglantiOlustur()
        //{
        //    string format = "metadata=res://*/Model.csdl|res://*/Model.ssdl|res://*/Model.msl;provider=System.Data.SqlClient;provider connection string=\"{0}\"";
        //    string connectionString = "server=" + Ortak.baglantiBilgileri.sunucuAdres + ";database=" + baglantiBilgileri.VeritabaniAdi + ";UserID=" + baglantiBilgileri.username + ";Password=" + baglantiBilgileri.parola + ";";
        //    string baglantiBilgisi = string.Format(format, connectionString);
        //    //SqlConnection sql = new SqlConnection("Data Source=" + Ortak.baglantiBilgileri.sunucuAdres + "; Initial Catalog="+baglantiBilgileri.VeritabaniAdi+"; User Id="+baglantiBilgileri.username+"; password="+baglantiBilgileri.parola+";");
        //    return baglantiBilgisi;
        //}

    }
}
