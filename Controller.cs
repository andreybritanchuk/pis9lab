using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pis
{
    class Controller
    {
        static public SqlConnection connect;

        public static User LogIn(string login, string password)
        {
            return User.LogIn(login, password);
        }

        public static Card[] openRegistry(string filter="", string sorter="")
        {
            return Card.openRegistry(filter, sorter);
        }

        public static Card openCard(int idCard)
        {
            return Card.openCard(idCard);
        }

        public static bool OpenNewActCard()
        {
            return true;
        }

        public static bool SelectActCardToUpdate(int idCard)
        {
            return true;
        }

        public static bool SelectActCardToDelete(int idCard)
        {
            return true;
        }

        public static Card AddActCard(string[] actCardData)
        {
            return Card.AddActCard(actCardData);
        }

        public static Card UpdateActCard(int idCard, string[] actCardData)
        {
            return Card.UpdateActCard(idCard, actCardData);
        }

        public static void DeleteActCard(int idCard)
        {
            Card.DeleteActCard(idCard);
        }

        public static Card AddFile(int idCard, byte[] fileData)
        {
            return Card.AddFile(idCard, fileData);
        }

        public static Card DeleteFile(int idCard, int fileID)
        {
            return Card.DeleteFile(idCard, fileID);
        }

        public static void ExportExcel(int[] idCard, string path)
        {
            Export.ExportExcel(idCard, path);
        }

        public static void ExportWord(int idCard, string path)
        {
            Export.ExportWord(idCard, path);
        }
    }
}
