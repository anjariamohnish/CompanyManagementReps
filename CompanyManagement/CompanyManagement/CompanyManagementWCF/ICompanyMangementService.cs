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
        string AddProject(BusinessLayerEntities.BOProject project);

        [OperationContract]
        string AssignEmployeeToProject(int employeeId, int projectId);

        [OperationContract]
        string DeleteTask(int taskId);

        [OperationContract]
        string DeleteProject(int projectId);

        [OperationContract]
        string CreateTaskInProject(BusinessLayerEntities.BOTask task, int projectId);


    }



}
