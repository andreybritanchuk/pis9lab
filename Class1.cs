﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pis
{
    class Controller
    {
        public void ExportExcel(int[] idCard, string path)
        {

        }

        public void ExportWord(int idCard, string path)
        {

        }

        public void openCard(int idCard)
        {

        }

        public void openRegistry()
        {

        }

        public object[] openRegistry(string filter, string sorter)
        {
            return null;
        }

        public void LogIn(string login, string password)
        { 
            
        }

        public void AddActCard(string[] actCardData)
        { 
            
        }

        public void DeleteActCard(long idCard)
        { 
            
        }
        
         public void UpdateActCard(int idCard, string[] actCardData)
        {

        }

        public void AddFile(int idCard, byte[] fileData)
        {

        }

        public void DeleteFile(int idCard, int fileID)
        {

        }
        
         public void SelctActCardToUpdate(int idCard)
        { 
            
        }
        
         public void OpenNewActCard()
        { 
            
        }
        
         public void SelctActCardToDelete(int idCard)
        { 
            
        }
    }
}
