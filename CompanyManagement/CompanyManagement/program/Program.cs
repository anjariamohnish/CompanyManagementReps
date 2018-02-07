
using System;
namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyManagementBusinessLayer.BusinessLayer obj = new CompanyManagementBusinessLayer.BusinessLayer();
            obj.AssignTechnologyToTask(4, 1);

            Console.ReadLine();

        }


    }
}
