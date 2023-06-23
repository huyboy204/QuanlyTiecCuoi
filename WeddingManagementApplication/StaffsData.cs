using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingManagementApplication
{
    internal class StaffsData
    {
        public int idStaff;
        public string Username;
        public string Pw;
        public int Priority;
        public string Name;
        public string Identification;

        public StaffsData() { } 
        public StaffsData(int idStaff, string username, string pw, int priority, string name, string identification)
        {
            this.idStaff = idStaff;
            Username = username;
            Pw = pw;
            Priority = priority;
            Name = name;
            Identification = identification;
        }
    }
}
