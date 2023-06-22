using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingManagementApplication
{
    internal class LobbyData
    {
        public string idLobby;
        public string idLobbyType;
        public string LobbyName;
        public int MaxTable;
        public string Note;

        public LobbyData() { }

        // full constructor
        public LobbyData(string idLobby, string idLobbyType, string LobbyName, int MaxTable, string Note)
        {
            this.idLobby = idLobby;
            this.idLobbyType = idLobbyType;
            this.LobbyName = LobbyName;
            this.MaxTable = MaxTable;
            this.Note = Note;
        }
    }
}
