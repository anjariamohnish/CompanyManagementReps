using BusinessLayerEntities;
using System.ServiceModel;
namespace CompanyManagementWCF
{
    [ServiceContract]
    interface ICompanyMangementService
    {

        [OperationContract]
        string DeleteTechnology(int technologyId);

        [OperationContract]
        string AssignTechnologyToTask(int technologyId, int taskId);

        [OperationContract]
        string AddProject(BOProject project);

        [OperationContract]
        string AssignEmployeeToProject(int employeeId, int projectId);

        [OperationContract]
        string DeleteTask(int taskId);

        [OperationContract]
        string DeleteProject(int projectId);

        [OperationContract]
        string CreateTaskInProject(BOTask task, int projectId);


    }



}
