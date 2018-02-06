using AutoMapper;
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
                return Resources.DeleteProjectError;

            }



        }

        public string AssignTechnologyToTask(int technologyId, int taskId)
        {


            DataLayerManager context = new DataLayerManager();

            if (context.GetNumberOfTechnologyToTask(taskId) < Convert.ToInt32(Resources.TechnologyAssignmentValue))
            {
                return Resources.MoreTechnologyThanRequired;
            }

            if (context.CheckTechnologyInProject(taskId, technologyId))
            {
                return context.AssignTechnologyToTask(technologyId, taskId);
            }
            else
            {
                return Resources.TechnologyNotInProject;
            }




        }

        public string AddProject(BusinessLayerEntities.BOProject project)
        {
            DataLayerManager context = new DataLayerManager();

            if (context.GetNumberOfProject(project.ProjectManagerId) > Convert.ToInt32(Resources.ProjectAssignmentValue))
            {

                return context.AddProject(Mapper.Map<BusinessLayerEntities.BOProject, CompanyEntities.Project>(project));
            }
            else
            {
                return Resources.ExcessProjectForManager;
            }

        }

        public string AssignEmployeeToProject(int employeeId, int projectId)
        {
            DataLayerManager context = new DataLayerManager();

            if (context.GetAssignedProjectForEmployee(employeeId) <= Convert.ToInt32(Resources.EmployeeAssignmentValue))
            {
                return context.AssignEmployeeToProject(employeeId, projectId);
            }
            else
            {
                return Resources.EmployeeAssignmentError;
            }


        }

        public string DeleteTask(int taskId)
        {
            DataLayerManager context = new DataLayerManager();

            if (context.GetTaskStatus(taskId) != (int)Status.Active)
            {
                return context.DeleteTask(taskId);
            }
            else
            {
                return Resources.CannotDeleteRunningTask;
            }


        }
        public string DeleteProject(int projectId)
        {
            DataLayerManager context = new DataLayerManager();


            if (context.GetProjectStatus(projectId) != (int)Status.Active)
            {
                return context.DeleteProject(projectId);
            }
            else
            {
                return Resources.CannotDeleteRunningProject;
            }


        }

        public string CreateTaskInProject(BusinessLayerEntities.BOTask task, int projectId)
        {
            DataLayerManager context = new DataLayerManager();

            if (context.GetProjectStatus(projectId) != (int)Status.Completed)
            {

                return context.CreateTaskInProject(Mapper.Map<BusinessLayerEntities.BOTask, CompanyEntities.Task>(task), projectId);
            }
            else
            {
                return Resources.TaskCannotAssignCompletedProject;
            }



        }




    }
}
