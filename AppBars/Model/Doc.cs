using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AppBars.Model
{
    public class Docs
    {
        public List<Doc> docs;
    }

    public class Doc
    {
        public Doc(DateTime DateCreate, int Id, DateTime DateUpdate)
        {
            this.DateCreate = DateCreate;
            this.Id = Id;
            this.DateUpdate = DateUpdate;
            this.isActive = TimeSpan.FromTicks(DateTime.Now.Ticks - this.DateUpdate.Ticks) < TimeSpan.FromDays(60);
        }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public int Id { get; set; }
        public bool isActive { get; set; }
    }
}
