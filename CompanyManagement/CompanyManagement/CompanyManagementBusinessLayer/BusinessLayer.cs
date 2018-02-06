using CompanyManagementDataLayer;
using System;

namespace CompanyManagementBusinessLayer
{
    public class BusinessLayer
    {


        public string DeleteTechnology(int technologyId)
        {
            DataLayerManager context = new DataLayerManager();


            if (context.GetTechnologyUsage(technologyId) < 2)
            {
                return context.DeleteTechnology(technologyId);
            }
            else
            {
                return "Cannot delete technology as it used in more than 2 projects";

            }



        }

        public string AssignTechnologyToTask(int technologyId, int taskId)
        {


            DataLayerManager context = new DataLayerManager();

            if (context.GetNumberOfTechnologyToTask(taskId) < Convert.ToInt32(Resources.TechnologyAssignmentValue))
            {
                return Resources.MoreTechnologyThanRequired;
            }



            if (context.CheckTechnologyTaskInProject(taskId, technologyId))
            {
                return context.AssignTechnologyToTask(technologyId, taskId);
            }
            else
            {
                return Resources.TechnologyNotInProject;
            }




        }




    }
}
