using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pis
{
    class Card
    {
        public int idCard;
        public int idMC;
        public DateTime datemc;
        public string name;
        public string localGovernmentBody;
        public string executor;
        public int numberdog;
        public int numbercat;
        public int numberanimal;
        public string locality;
        public DateTime date_trapping;
        public string purpose;
        public static Card[] openRegistry(string filter = "", string sorter = "")
        {
            return null;
        }

        public static Card openCard(int idCard)
        {
            return null;
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
