using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dnn.HuntersLodge.HuntersLodge.Dnn.HelloWorld.Models
{
    [TableName("Foglalások")]
    [PrimaryKey(nameof(ID), AutoIncrement = true)]
    public class Foglalások
    {
        public int ID { get; set; }
        public int Típus { get; set; }

        public DateTime Időpont { get; set; }

        public DateTime Létrehozás { get; set; }

        public bool Lemondták_e { get; set; }

        public int Minimális_létszám { get; set; }
        public int Maximális_létszám { get; set; }
        public int Aktuális_létszám { get; set; }
    }
}
