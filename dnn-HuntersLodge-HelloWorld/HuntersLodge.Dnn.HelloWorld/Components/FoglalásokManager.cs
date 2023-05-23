using DotNetNuke.Data;
using DotNetNuke.Framework;
using System;
using System.Collections.Generic;
using Dnn.HuntersLodge.HuntersLodge.Dnn.HelloWorld.Models;
using System.Linq;

namespace Dnn.HuntersLodge.HuntersLodge.Dnn.HelloWorld.Components
{
    public class FoglalásokManager
    {
        public IEnumerable<Foglalások> GetFoglalások()
        {
            using (var context = DataContext.Instance())
            {
                var repository = context.GetRepository<Foglalások>();
                var query = repository.Get();
                return query.ToList();
            }
        }
    }
}