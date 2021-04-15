using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression_Linq
{
    class Program
    {
        static void Main(string[] args)
        {            
            IDictionary<string, int> allPositions = GetAllPositions();

            var allEmployee = GetAllEmployee().OrderBy(e => e.FirstName).OrderBy(e => e.LastName);

            foreach (var employee in allEmployee.OrderByDescending(e => allPositions[e.Position]))
            {
                Console.WriteLine(employee);
            }
            
            // var entry = Console.ReadLine();

            // Console.WriteLine($"positions rating: {allPositions[entry]}");
            // GetAllEmployee(1);
        }

        static IDictionary<string, int> GetAllPositions()
        {
            Console.Write("Enter the number of positions: ");
            int num = Convert.ToInt16(Console.ReadLine());

            var positions = new Dictionary<string, int>(){};
            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter position in the format **Position-num**: ");
                string response = Console.ReadLine();
                                
                var post = response.Split('-', 2);
                positions.Add(post[0], Convert.ToInt16(post[1]));
            }
            return positions;
        }

        static IEnumerable<Worker> GetAllEmployee()
        {
            Console.Write("Enter the number of employees: ");
            int num = Convert.ToInt16(Console.ReadLine());
            
            var employees = new List<Worker>(){};
            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter employee data in the format **Firstname LastName-Position**: ");
                string response = Console.ReadLine();

                var detailsArr = response.Split('-', 2);
                var name = detailsArr[0].Split(' ');

                employees.Add(new Worker(name[0], name[1], detailsArr[1]));

                // Console.WriteLine($"Firstname {name[0]} lastname {name[1]} position {detailsArr[1]}");
            }
            return employees;
        }
    }
}
