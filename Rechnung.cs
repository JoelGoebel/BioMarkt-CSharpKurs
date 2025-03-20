using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProNaturBiomarkt
{
    public class Rechnung
    {
        //Aus Tabelle Rechnung
        public int Re_Invoice_ID { get; private set; }
        public int Re_CustomerID { get; private set; }
        public DateTime Re_Date { get; private set; }
        public DateTime Re_DueDate { get; private set; }
        
        //Aus Tabelle Products
        public List<string> Pro_Name { get; private set; }
        public List<string> Pro_Brand { get; private set; }

        //Aus Tabelle RechnungsPositionen
        public List<int> RePo_ProductID { get; private set; }
        public List<int> RePo_Amount { get; private set; }
        public List<Decimal> RePo_Price { get; private set; }
        public List<Decimal> RePo_TotalPrice { get; set; }

        //Aus Tabelle Kunden
        public string Ku_Name { get; private set; }
        public string Ku_LastName { get; private set; }
        public string Ku_Adress { get; private set; }


        public Rechnung
            (int re_Invoice_ID, int re_CustomerID, DateTime re_Date, DateTime re_DueDate, List<string> pro_Name, List<string> pro_Brand, List<int> repo_ProductID,
            List<int> repo_Amount, List<Decimal> repo_Price, List<Decimal>repo_TotalPrice, string ku_Name, string ku_LastName, string ku_Adress)
        {
            Re_Invoice_ID = re_Invoice_ID;
            Re_CustomerID = re_CustomerID;
            Re_Date = re_Date;
            Re_DueDate = re_DueDate;

            Pro_Name = pro_Name;
            Pro_Brand = pro_Brand;

            RePo_ProductID = repo_ProductID;
            RePo_Amount = repo_Amount;
            RePo_Price = repo_Price;
            RePo_TotalPrice = repo_TotalPrice;

            Ku_Name = ku_Name;
            Ku_LastName = ku_LastName;
            Ku_Adress = ku_Adress;

        }

    }

    

}
