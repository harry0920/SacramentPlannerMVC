using SacramentPlannerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlannerMVC.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SacramentContext context)
        {
            context.Database.EnsureCreated();

            if (context.Bishoprics.Any())
            {
                return;
            }

            var bishoprics = new Bishopric[]
            {
                new Bishopric{Name="Brother Thayne",IsActive=true},
                new Bishopric{Name="Zach Wilson",IsActive=true},
                new Bishopric{Name="Tad Cooper",IsActive=true}
            };
            foreach (Bishopric b in bishoprics)
            {
                context.Bishoprics.Add(b);
            }
            context.SaveChanges();
        }
    }
}
