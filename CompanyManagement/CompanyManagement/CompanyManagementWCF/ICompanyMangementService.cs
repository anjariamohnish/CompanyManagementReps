using System.ServiceModel;

namespace CompanyManagementWCF
{
    [ServiceContract]
    public interface ICompanyMangementService
    {
        /*  [OperationContract]
          public List<BOProject> GetAllProjects();

          [OperationContract]
          public List<TechnologyMaster> GetAllTechnologies();
          [OperationContract]
          public int GetEmployeeCountForProject(int projectId);

          [OperationContract]
          public List<Employee> GetAllEmployeesForProject(int projectId);


          [OperationContract]
          public List<Project> GetAllDelayedProjects();

          [OperationContract]
          public List<Project> GetAllProjectsForEmployee(int employeeId);


          [OperationContract]
          public List<Task> GetAllTasksForEmployee(int employeeId);

          [OperationContract]
          public List<Task> GetAllTechnologyTasksForEmployee(int technologyId, int employeeId);


          [OperationContract]
          public List<Project> GetAllTechnologyProjects(int technologyId);


          [OperationContract]
          public List<Task> GetAllActiveTasksForProject(int projectId);

          [OperationContract]
          public List<TechnologyMaster> GetAllTechnologiesForEmployee(int employeeId);


          [OperationContract]
          public int GetProjectCountForEmployee(int employeeId);

          [OperationContract]
          public List<Project> GetAllActiveProjectsManagedByEmployee(int employeeId);

          [OperationContract]
          public List<Task> GetAllDelayedTasksForEmployee(int employeeId);




          /*  
           *  
           *  2-B
            */
        /*   [OperationContract]
           public String AddProject(CompanyEntities.Project data);
           [OperationContract]
           public String AddTechnology(CompanyEntities.Technology data);

           [OperationContract]
           public String AssignTechnologyToTask(int technologyId, int taskId);

           [OperationContract]
           public String AddEmployee(CompanyEntities.Employee data);

           [OperationContract]
           public String AssignEmployeeToProject(int employeeId, int projectId);

           [OperationContract]
           public String DeleteEmployeeFromSystem(int employeeId);

           [OperationContract]
           public string DeleteTechnology(int technologyId);

           [OperationContract]
           public String DeleteTask(int taskId);

           [OperationContract]
           public String DeleteProject(int projectId);
           [OperationContract]
           public String CreateTaskInProject(CompanyEntities.Task task, int projectId);

           [OperationContract]
           public String UpdateTechnologiesForTask(List<int> technologyIds, int taskId);


           */



        /* Extra  */

        /*   [OperationContract]
           public List<Client> GetCustomersWithEmployee();

           [OperationContract]
           public List<Client> GetCustomerWithTechnology();

           [OperationContract]
           public List<Client> GetCustomerWithDelayedTask();



           // Extra methods for BL

           [OperationContract]
           public int GetCountOfTechnologyInProjects(int technologyId);


           [OperationContract]
           public Boolean IsTechnologyAssignedToProject(int taskId, int technologyId);

           [OperationContract]
           public int GetCountOfTechnologyInTask(int taskId);

           [OperationContract]
           public int GetCountOfProjectsAssignedToProjectManager(int employeeId);


           [OperationContract]
           public int GetCountOfProjectsAssignedToEmployee(int employeeId);


           [OperationContract]
           public int GetTaskStatus(int taskId);


           [OperationContract]
           public int GetProjectStatus(int projectId);

       */


    }



}
