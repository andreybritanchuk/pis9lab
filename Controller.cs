using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pis
{
    class Controller
    {
        public static User LogIn(string login, string password)
        {
            return null;
        }

        public static Card[] openRegistry(string filter="", string sorter="")
        {
            return null;
        }

        public static Card openCard(int idCard)
        {
            return null;
        }

        public static bool OpenNewActCard()
        {
            return true;
        }

        public static bool SelctActCardToUpdate(int idCard)
        {
            return true;
        }

        public static bool SelctActCardToDelete(int idCard)
        {
            return true;
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

        public static void ExportExcel(int[] idCard, string path)
        {

        }

        public static void ExportWord(int idCard, string path)
        {

        }
    }
}
