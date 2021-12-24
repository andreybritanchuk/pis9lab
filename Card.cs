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
        public int idMC;
        public DateTime datemc;
        public string municipality;
        public string localGovernmentBody;
        public string executor;
        public int idCard;
        public int numberdog=0;
        public int numbercat=0;
        public int numberanimal=0;
        public string locality;
        public DateTime date_trapping;
        public string purpose;
        public static Dictionary<int, Card> cards;
        public Card(string[] data)
        {
            idMC = int.Parse(data[0]);
            datemc = Convert.ToDateTime(data[1]);
            municipality = data[2];
            localGovernmentBody = data[3];
            executor = data[4];
            idCard = int.Parse(data[5]);
            if (data[6] != "") numberdog = int.Parse(data[6]);
            if (data[7] != "") numbercat = int.Parse(data[7]);
            if (data[8] != "") numberanimal = int.Parse(data[8]);
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
                cards.Add(int.Parse(data[5]), new Card(data.ToArray()));
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
            try
            {
                Controller.connect.Open();

                string sql1 = @"insert into act_trapping values('" + actCardData[5] + "', '"
                    + actCardData[6] + "', '" + actCardData[7] + "', '" + actCardData[8] + "', '" + actCardData[9]
                    + "', '" + actCardData[10] + "', '" + actCardData[11] + "', '" + actCardData[0] + "')";
                SqlCommand command = Controller.connect.CreateCommand();
                command.CommandText = sql1;
                command.ExecuteNonQuery();

                Controller.connect.Close();

                var card = new Card(actCardData);
                return card;
            }
            catch
            {
                return null;
            }
        }

        public static Card UpdateActCard(int idCard, string[] actCardData)
        {
            try
            {
                Controller.connect.Open();

                string sql1 = @"update act_trapping set numberdog='" + actCardData[6]
                    + "', numbercat='" + actCardData[7] + "', numberanimal='" + actCardData[8]
                    + "', locality='" + actCardData[9] + "', date_trapping='" + actCardData[10]
                    + "', purpose='" + actCardData[11] + "', id_mc='" + actCardData[0]
                    + "' where id_act='" + actCardData[5] + "'";
                SqlCommand command = Controller.connect.CreateCommand();
                command.CommandText = sql1;
                command.ExecuteNonQuery();

                Controller.connect.Close();

                var card = new Card(actCardData);
                return card;
            }
            catch
            {
                return null;
            }
            
        }

        public static void DeleteActCard(int idCard)
        {
            Controller.connect.Open();

            string sql1 = @"delete from act_trapping where id_act='"+idCard+"'";
            SqlCommand command = Controller.connect.CreateCommand();
            command.CommandText = sql1;
            command.ExecuteNonQuery();

            Controller.connect.Close();
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
