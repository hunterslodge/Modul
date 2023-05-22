using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dnn.HuntersLodge.HuntersLodge.Dnn.HelloWorld.Models
{
    [TableName("Vadászattípusok")]
    [PrimaryKey(nameof(ID), AutoIncrement = true)]
    public class Vadászattípusok
    {
        public int ID { get; set; }
        public string Név { get; set; }

        public string Leírás { get; set; }

        public int Hossz { get; set; }

        public string Nehézség { get; set; }

        public int Ár { get; set; }
    }
}
