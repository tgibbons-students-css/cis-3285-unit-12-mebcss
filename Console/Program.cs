
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubtypeCovariance;

namespace ConsoleSample
{
    class Program
    {
        static void Main(string[] args)
        {

            EntityRepository entityRepository = new EntityRepository();
            User User1 = entityRepository.GetByID(Guid.NewGuid());

            myEntity.Name = "Martin";
            Console.WriteLine("New entity ID: " + myEntity.ID.ToString());
            Console.WriteLine("New entity Name: " + myEntity.Name);

        }
    }
}
