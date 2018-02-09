using BusinessLayerEntities;
using CompanyManagementBusinessLayer;

namespace CompanyManagementWCF
{
    public class CompanyMangementService : ICompanyMangementService
    {
        public string AddProject(BOProject project)
        {
            BusinessLayer businessLayer = new BusinessLayer();
// testt git
            return businessLayer.AddProject(project);

        }

        public string AssignEmployeeToProject(int employeeId, int projectId)
        {
            BusinessLayer businessLayer = new BusinessLayer();

            return businessLayer.AssignEmployeeToProject(employeeId, projectId);

        }

        public string AssignTechnologyToTask(int technologyId, int taskId)
        {
            BusinessLayer businessLayer = new BusinessLayer();


            return businessLayer.AssignTechnologyToTask(technologyId, taskId);

        }

        public string CreateTaskInProject(BOTask task, int projectId)
        {
            BusinessLayer businessLayer = new BusinessLayer();


            return businessLayer.CreateTaskInProject(task, projectId);

        }

        public string DeleteProject(int projectId)
        {
            BusinessLayer businessLayer = new BusinessLayer();

            return businessLayer.DeleteProject(projectId);

        }

        public string DeleteTask(int taskId)
        {
            BusinessLayer businessLayer = new BusinessLayer();

            return businessLayer.DeleteTask(taskId);

        }

        public string DeleteTechnology(int technologyId)
        {
            BusinessLayer businessLayer = new BusinessLayer();

            return businessLayer.DeleteTechnology(technologyId);

        }
    }
}
