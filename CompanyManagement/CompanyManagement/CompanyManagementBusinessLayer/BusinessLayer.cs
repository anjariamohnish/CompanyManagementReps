﻿using AutoMapper;
using CompanyManagementDataLayer;
using System;


namespace CompanyManagementBusinessLayer
{
    public class BusinessLayer
    {
        const int maxUsageOfTechnology = 2;


        public string DeleteTechnology(int technologyId)
        {
            DataLayerManager dataLayer = new DataLayerManager();


            if (dataLayer.GetCountOfTechnologyInProjects(technologyId) < maxUsageOfTechnology)
            {
                return dataLayer.DeleteTechnology(technologyId);
            }
            else
            {
                return Resources.TechnologyUsedInMoreThanTwoProject;

            }



        }

        public string AssignTechnologyToTask(int technologyId, int taskId)
        {


            DataLayerManager dataLayer = new DataLayerManager();

            if (dataLayer.GetCountOfTechnologyInTask(taskId) > Convert.ToInt32(Resources.TechnologyMaxAssignValue))
            {
                return Resources.ExcessTechnologyThanRequired;
            }

            if (dataLayer.IsTechnologyAssignedToProject(taskId, technologyId))
            {
                return dataLayer.AssignTechnologyToTask(technologyId, taskId);
            }
            else
            {
                return Resources.TechnologyNotInProject;
            }




        }

        public string AddProject(BusinessLayerEntities.BOProject project)
        {

            DataLayerManager dataLayer = new DataLayerManager();

            if (dataLayer.GetCountOfProjectsAssignedToProjectManager(project.ProjectManagerId) < Convert.ToInt32(Resources.ProjectMaxAssignValue))
            {
                IMapper mapper = CompanyManagementMapper.GetMapper();

                return dataLayer.AddProject(mapper.Map<BusinessLayerEntities.BOProject, CompanyEntities.Project>(project));
            }
            else
            {
                return Resources.ExcessProjectForProjectManager;
            }

        }

        public string AssignEmployeeToProject(int employeeId, int projectId)
        {
            DataLayerManager dataLayer = new DataLayerManager();

            if (dataLayer.GetCountOfProjectsAssignedToEmployee(employeeId) < Convert.ToInt32(Resources.EmployeeMaxAssignValue))
            {
                return dataLayer.AssignEmployeeToProject(employeeId, projectId);
            }
            else
            {
                return Resources.EmployeeAssignmentError;
            }


        }

        public string DeleteTask(int taskId)
        {
            DataLayerManager dataLayer = new DataLayerManager();

            if (dataLayer.GetTaskStatus(taskId) != (int)Status.Active)
            {
                return dataLayer.DeleteTask(taskId);
            }
            else
            {
                return Resources.CannotDeleteRunningTask;
            }


        }

        public string DeleteProject(int projectId)
        {
            DataLayerManager dataLayer = new DataLayerManager();


            if (dataLayer.GetProjectStatus(projectId) != (int)Status.Active)
            {
                return dataLayer.DeleteProject(projectId);
            }
            else
            {
                return Resources.CannotDeleteRunningProject;
            }


        }

        public string CreateTaskInProject(BusinessLayerEntities.BOTask task, int projectId)
        {
            DataLayerManager dataLayer = new DataLayerManager();
            if (dataLayer.GetProjectStatus(projectId) != (int)Status.Completed)
            {

                IMapper mapper = CompanyManagementMapper.GetMapper();

                return dataLayer.CreateTaskInProject(mapper.Map<BusinessLayerEntities.BOTask, CompanyEntities.Task>(task), projectId);
            }
            else
            {
                return Resources.TaskCannotAssignCompletedProject;
            }



        }
        //--



    }
}
