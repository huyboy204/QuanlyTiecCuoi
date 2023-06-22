using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingManagementApplication
{
    public class Service
    {
        public string idService;
        public string ServiceName;
        public long ServicePrice;
        public string Note;

        public Service(string idService, string ServiceName, long ServicePrice, string Note)
        {
            this.idService = idService;
            this.ServiceName = ServiceName;
            this.ServicePrice = ServicePrice;
            this.Note = Note;
        }

        public Service()
        {
            // make all fiels non-null
            idService = "";
            ServiceName = "";
            ServicePrice = 0;
            Note = "";
        }

        public bool Equals(Service other)
        {
            // check if all fields are equal
            return this.idService.Equals(other.idService) &&
                this.ServiceName.Equals(other.ServiceName) &&
                this.ServicePrice.Equals(other.ServicePrice) &&
                this.Note.Equals(other.Note);
        }
    }
}
