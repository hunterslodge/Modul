using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dnn.HuntersLodge.HuntersLodge.Dnn.HelloWorld.Models
{
    [TableName("Kódok")]
    [PrimaryKey(nameof(ID), AutoIncrement = true)]
    public class Kódok
    {
        public int ID { get; set; }
        public string Kód { get; set; }

        public int KapcsolódóVadászat { get; set; }

        public bool Lejárt_e { get; set; }

        public DateTime Létrehozás { get; set; }

        public bool Beváltás { get; set; }
        public int Típus { get; set; }
        public int Létszám { get; set; }
    }
}
