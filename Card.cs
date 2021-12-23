using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pis
{
    class Card
    {
        public int idCard;
        public int idMC;
        public DateTime datemc;
        public string municipality;
        public string localGovernmentBody;
        public string executor;
        public int numberdog;
        public int numbercat;
        public int numberanimal;
        public string locality;
        public DateTime date_trapping;
        public string purpose;
        public static Dictionary<int, Card> cards;
        public Card(List<string> data)
        {
            idMC = int.Parse(data[0]);
            datemc = Convert.ToDateTime(data[1]);
            municipality = data[2];
            localGovernmentBody = data[3];
            executor = data[4];
            idCard = int.Parse(data[5]);
            numberdog = int.Parse(data[6]);
            numbercat = int.Parse(data[7]);
            numberanimal = int.Parse(data[8]);
            locality = data[9];
            date_trapping = Convert.ToDateTime(data[10]).Date;
            purpose = data[11];
        }

        public static Card[] openRegistry(string filter = "", string sorter = "")
        {
            Controller.connect.Open();
            string sql1 = @"select* from registry";
            SqlCommand command = Controller.connect.CreateCommand();
            command.CommandText = sql1;
            SqlDataReader result = command.ExecuteReader();
            cards = new Dictionary<int, Card>();
            while (result.Read())
            {
                var data = new List<string>();
                data.Add(result.GetValue(0).ToString());
                data.Add(result.GetValue(1).ToString());
                data.Add(result.GetValue(2).ToString());
                data.Add(result.GetValue(3).ToString());
                data.Add(result.GetValue(4).ToString());
                data.Add(result.GetValue(5).ToString());
                data.Add(result.GetValue(6).ToString());
                data.Add(result.GetValue(7).ToString());
                data.Add(result.GetValue(8).ToString());
                data.Add(result.GetValue(9).ToString());
                data.Add(result.GetValue(10).ToString());
                data.Add(result.GetValue(11).ToString());
                cards.Add(int.Parse(data[5]), new Card(data));
            }
            Controller.connect.Close();
            return cards.Values.ToArray();
        }

        public static Card openCard(int idCard)
        {
            return cards[idCard];
        }
        public static Card AddActCard(string[] actCardData)
        {
            return null;
        }

        public static Card UpdateActCard(int idCard, string[] actCardData)
        {
            return null;
        }

        public static void DeleteActCard(long idCard)
        {

        }

        public static Card AddFile(int idCard, byte[] fileData)
        {
            return null;
        }

        public static Card DeleteFile(int idCard, int fileID)
        {
            return null;
        }
    }
}
