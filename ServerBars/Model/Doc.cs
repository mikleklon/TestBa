using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerBars.Model
{
    [DataContract]
    [KnownType(typeof(List<Doc>))]
    [KnownType(typeof(Doc))]
    public class Docs
    {
        [DataMember]
        public List<Doc> docs;
    }

    [DataContract]
    public class Doc
    {
        public Doc(DateTime DateCreate, int Id, DateTime DateUpdate)
        {
            this.DateCreate = DateCreate;
            this.Id = Id;
            this.DateUpdate = DateUpdate;
        }
        [DataMember]
        public DateTime DateCreate { get; set; }
        [DataMember]
        public DateTime DateUpdate { get; set; }
        [DataMember]
        public int Id { get; set; }
    }
}
