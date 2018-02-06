﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyManagementDataLayer
{







    public class DataLayerManager
    {




        /*  2-A    */
        public List<Project> GetAllProjects()
        {
            CompanyDbDataContext companyDb = new CompanyDbDataContext();

            return (from project in companyDb.Projects select project).ToList();

        }

        public List<TechnologyMaster> GetAllTechnologies()
        {
            CompanyDbDataContext companyDb = new CompanyDbDataContext();

            return (from tech in companyDb.TechnologyMasters select tech).ToList();
        }

        public int GetEmployeeCountForProject(int projectId)
        {


            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {
                Validator validate = new Validator();
                if (validate.CheckProjectExist(projectId) == Resource.AllFieldPresent)
                {
                    return (from mapper in companyDb.EmployeeProjectMappers where mapper.projectId == projectId select mapper.employeeId).Count();
                }
                else
                {
                    return 0;
                }


            }




        }


        public List<Employee> GetAllEmployeesForProject(int projectId)
        {
            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {
                Validator validate = new Validator();
                if (validate.CheckProjectExist(projectId) == Resource.AllFieldPresent)
                {
                    return (from mapper in companyDb.EmployeeProjectMappers where mapper.projectId == projectId select mapper.Employee).ToList();
                }
                else
                {
                    return null;
                }



            }

        }


        public List<Project> GetAllDelayedProjects()
        {
            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {
                return (from project in companyDb.Projects where project.statusMasterId == (int)Status.Delayed select project).ToList();
            }


        }


        public List<Project> GetAllProjectsForEmployee(int employeeId)
        {
            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {
                Validator validate = new Validator();
                if (validate.CheckEmployeeExist(employeeId) == Resource.AllFieldPresent)
                {
                    return (from mapper in companyDb.EmployeeProjectMappers where mapper.employeeId == employeeId select mapper.Project).ToList();
                }
                else
                {
                    return null;
                }



            }



        }


        public List<Task> GetAllTasksForEmployee(int employeeId)
        {
            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {
                Validator validate = new Validator();
                if (validate.CheckEmployeeExist(employeeId) == Resource.AllFieldPresent)
                {
                    return (from mapper in companyDb.EmployeeTaskMappers where mapper.employeeId == employeeId select mapper.Task).ToList();
                }
                else
                {
                    return null;
                }



            }


        }


        public List<Task> GetAllTechnologyTasksForEmployee(int technologyId, int employeeId)
        {

            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {
                Validator validate = new Validator();
                if (validate.CheckEmployeeExist(employeeId) == Resource.AllFieldPresent && validate.CheckTechnologyExist(technologyId) == Resource.AllFieldPresent)
                {
                    //  return (from mapper in companyDb.EmployeeTaskMappers where mapper.employeeId == employeeID && mapper.Task.technologyMasterId == technologyID select mapper.Task).ToList();
                    return null;
                }
                else
                {
                    return null;
                }



            }


        }


        public List<Project> GetAllTechnologyProjects(int technologyId)
        {
            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {
                Validator validate = new Validator();
                if (validate.CheckTechnologyExist(technologyId) == Resource.AllFieldPresent)
                {
                    return (from mapper in companyDb.TechnologyProjectMappers where mapper.technologyId == technologyId select mapper.Project).ToList();
                }
                else
                {
                    return null;
                }



            }

        }


        public List<Task> GetAllActiveTasksForProject(int projectId)
        {
            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {
                Validator validate = new Validator();
                if (validate.CheckProjectExist(projectId) == Resource.AllFieldPresent)
                {
                    return (from mapper in companyDb.ProjectTaskMappers where mapper.projectId == projectId && mapper.Task.statusId == (int)Status.Active select mapper.Task).ToList();
                }
                else
                {
                    return null;
                }



            }

        }


        public List<TechnologyMaster> GetAllTechnologiesForEmployee(int employeeId)
        {

            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {
                Validator validate = new Validator();
                if (validate.CheckEmployeeExist(employeeId) == Resource.AllFieldPresent)
                {
                    //  return (from mapper in companyDb.EmployeeTaskMappers where mapper.employeeId == employeeID && mapper.Task.taskId == mapper.taskId select mapper.Task.TechnologyMaster).ToList();
                    return null;
                }
                else
                {
                    return null;
                }



            }

        }


        public int GetProjectCountForEmployee(int employeeId)
        {
            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {
                Validator validate = new Validator();
                if (validate.CheckEmployeeExist(employeeId) == Resource.AllFieldPresent)
                {
                    return (from mapper in companyDb.EmployeeProjectMappers where mapper.employeeId == employeeId select mapper).Count();
                }
                else
                {
                    return 0;
                }



            }

        }


        public List<Project> GetAllActiveProjectsManagedByEmployee(int employeeId)
        {

            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {
                Validator validate = new Validator();
                if (validate.CheckEmployeeExist(employeeId) == Resource.AllFieldPresent)
                {
                    return (from mapper in companyDb.EmployeeProjectMappers where mapper.employeeId == employeeId && mapper.Project.statusMasterId == (int)Status.Active select mapper.Project).ToList();
                }
                else
                {
                    return null;
                }



            }

        }

        public List<Task> GetAllDelayedTasksForEmployee(int employeeId)
        {

            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {
                Validator validate = new Validator();
                if (validate.CheckEmployeeExist(employeeId) == Resource.AllFieldPresent)
                {
                    return (from mapper in companyDb.EmployeeTaskMappers where mapper.employeeId == employeeId && mapper.statusMasterId == (int)Status.Delayed select mapper.Task).ToList();
                }
                else
                {
                    return null;
                }



            }


        }




        /*  
         *  
         *  2-B
          */

        public String AddProject(CompanyEntities.Project data)
        {

            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {
                Validator validate = new Validator();

                String result = validate.CheckProjectForNull(data);
                if (result == Resource.AllFieldPresent)
                {


                    Project project = new Project();
                    project.name = data.name;
                    project.departmentMasterId = data.departmentMasterId;
                    project.statusMasterId = data.statusMasterId;
                    project.clientId = data.clientId;

                    companyDb.Projects.InsertOnSubmit(project);
                    companyDb.SubmitChanges();

                    return "Success";
                }
                else
                {
                    throw new Exception(result);
                }

            }

        }

        public String AddTechnology(CompanyEntities.Technology data)
        {
            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {
                Validator validate = new Validator();
                if (validate.CheckTechnologForNull(data) == Resource.AllFieldPresent)
                {



                    TechnologyMaster technology = new TechnologyMaster();
                    technology.name = data.name;
                    technology.version = data.version;

                    companyDb.TechnologyMasters.InsertOnSubmit(technology);
                    companyDb.SubmitChanges();

                    return "Success";
                }
                else
                {
                    throw new Exception("Invalid Data");
                }
            }

        }

        public String AssignTechnologyToTask(int technologyId, int taskId)
        {

            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {

                Validator validate = new Validator();

                if (validate.CheckTechnologyExist(technologyId) == Resource.AllFieldPresent && validate.CheckTaskExist(taskId) == Resource.AllFieldPresent)
                {
                    TaskTechnologyMapper tasktechmapper = (from mapper in companyDb.TaskTechnologyMappers where mapper.taskId == taskId select mapper).FirstOrDefault();
                    tasktechmapper.technologyMasterId = technologyId;
                    companyDb.SubmitChanges();

                    return "Success";
                }
                else
                {
                    throw new Exception("Invalid Data");
                }

            }

        }

        public String AddEmployee(CompanyEntities.Employee data)
        {

            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {
                Validator validate = new Validator();
                if (validate.CheckEmployeeForNull(data) == Resource.AllFieldPresent)
                {



                    Employee employee = new Employee();
                    employee.fname = data.fname;
                    employee.lname = data.lname;
                    employee.email = data.email;
                    employee.phoneNumber = data.phoneNumber;
                    employee.hireDate = data.hireDate;
                    employee.departmentMasterId = data.departmentMasterId;
                    employee.salary = data.salary;


                    companyDb.Employees.InsertOnSubmit(employee);
                    companyDb.SubmitChanges();

                    return "Success";
                }
                else
                {
                    throw new Exception("Invalid Data");
                }
            }


        }

        public String AssignEmployeeToProject(int employeeId, int projectId)
        {
            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {

                Validator validate = new Validator();


                if (validate.CheckEmployeeExist(employeeId) == Resource.AllFieldPresent && validate.CheckProjectExist(projectId) == Resource.AllFieldPresent)
                {
                    EmployeeProjectMapper employeeprojectmapper = new EmployeeProjectMapper();
                    employeeprojectmapper.employeeId = employeeId;
                    employeeprojectmapper.projectId = projectId;

                    companyDb.EmployeeProjectMappers.InsertOnSubmit(employeeprojectmapper);
                    companyDb.SubmitChanges();


                    return "Success";
                }
                else
                {
                    throw new Exception("Invalid Data");
                }

            }
        }

        public String DeleteEmployeeFromSystem(int employeeId)
        {


            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {

                Validator validate = new Validator();

                if (validate.CheckEmployeeExist(employeeId) == Resource.AllFieldPresent)
                {

                    Employee deleteEmployee = (from Employee in companyDb.Employees where Employee.employeeId == employeeId select Employee).FirstOrDefault();

                    companyDb.Employees.DeleteOnSubmit(deleteEmployee);

                    companyDb.SubmitChanges();
                    return "Success";
                }
                else
                {
                    throw new Exception("Invalid Data");
                }
            }

        }

        public string DeleteTechnology(int technologyId)
        {
            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {

                Validator validate = new Validator();


                if (validate.CheckTechnologyExist(technologyId) == Resource.AllFieldPresent)
                {

                    TechnologyMaster deleteTechnology = (from TechnologyMaster in companyDb.TechnologyMasters where TechnologyMaster.technologyMasterId == technologyId select TechnologyMaster).FirstOrDefault();

                    companyDb.TechnologyMasters.DeleteOnSubmit(deleteTechnology);

                    companyDb.SubmitChanges();
                    return "Success";


                }
                else
                {
                    throw new Exception("Invalid Data");
                }
            }
        }

        public String DeleteTask(int taskId)
        {
            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {

                Validator validate = new Validator();


                if (validate.CheckTaskExist(taskId) == Resource.AllFieldPresent)
                {

                    Task deleteTask = (from task in companyDb.Tasks where task.taskId == taskId select task).FirstOrDefault();

                    companyDb.Tasks.DeleteOnSubmit(deleteTask);

                    companyDb.SubmitChanges();
                    return "Success";
                }
                else
                {
                    throw new Exception("Invalid Data");
                }

            }
        }

        public String DeleteProject(int projectId)
        {
            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {

                Validator validate = new Validator();

                if (validate.CheckProjectExist(projectId) == Resource.AllFieldPresent)
                {

                    Project deleteProject = (from Project in companyDb.Projects where Project.projectId == projectId select Project).FirstOrDefault();

                    companyDb.Projects.DeleteOnSubmit(deleteProject);

                    companyDb.SubmitChanges();
                    return "Success";
                }
                else
                {
                    throw new Exception("Invalid Data");
                }

            }
        }

        public String CreateTaskInProject(CompanyEntities.Task task, int projectId)
        {
            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {

                Validator validate = new Validator();


                if (validate.CheckTaskForNull(task) == Resource.AllFieldPresent && validate.CheckProjectExist(projectId) == Resource.AllFieldPresent)
                {

                    Task t = new Task();

                    t.name = task.name;
                    t.statusId = task.statusId;
                    t.updateDate = task.updateDate;

                    companyDb.Tasks.InsertOnSubmit(t);

                    ProjectTaskMapper mapper = new ProjectTaskMapper();

                    mapper.taskId = t.taskId;
                    mapper.projectId = projectId;

                    companyDb.ProjectTaskMappers.InsertOnSubmit(mapper);

                    return "Success";
                }
                else
                {
                    throw new Exception("Invalid Data");
                }

            }

        }

        public String UpdateTechnologiesForTask(List<int> technologyIds, int taskId)
        {
            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {

                Validator validate = new Validator();

                if (validate.CheckTaskExist(taskId) == Resource.AllFieldPresent && validate.CheckTechnologyExist(technologyIds) == Resource.AllFieldPresent)
                {

                    TaskTechnologyMapper tasktechmapper = new TaskTechnologyMapper();

                    List<int> taskTechnology = (from mapper in companyDb.TaskTechnologyMappers where mapper.taskId == taskId select mapper.technologyMasterId).ToList();

                    List<int> removeTechnologyId = taskTechnology.Except(technologyIds).ToList(); // remove old techids



                    foreach (int technologyId in removeTechnologyId)
                    {
                        TaskTechnologyMapper deleteTechnology = (from mapper in companyDb.TaskTechnologyMappers where mapper.taskId == taskId && mapper.technologyMasterId == technologyId select mapper).FirstOrDefault();
                        companyDb.TaskTechnologyMappers.DeleteOnSubmit(deleteTechnology);
                        companyDb.SubmitChanges();
                    }


                    foreach (int technologyId in technologyIds)
                    {
                        if (!taskTechnology.Contains(technologyId))
                        {

                            TaskTechnologyMapper taskTechnologyMapper = new TaskTechnologyMapper();
                            taskTechnologyMapper.taskId = taskId;
                            taskTechnologyMapper.technologyMasterId = technologyId;
                            companyDb.TaskTechnologyMappers.InsertOnSubmit(taskTechnologyMapper);
                            companyDb.SubmitChanges();
                        }
                    }

                    return "Success";
                }
                else
                {
                    throw new Exception("Invalid Data");
                }

            }

        }





        /* Extra  */


        public List<Client> GetCustomersWithEmployee()
        {

            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {
                List<Client> clients = new List<Client>();

                List<int> clientIds = (from client in companyDb.Clients select client.clientId).ToList();

                foreach (int clientId in clientIds)
                {

                    int count = (from mapper in companyDb.EmployeeProjectMappers where mapper.Project.clientId == clientId group mapper by mapper.employeeId into emp select new { emp }).Count();

                    if (count > 5)
                    {
                        clients.Add((from client in companyDb.Clients where client.clientId == clientId select client).FirstOrDefault());
                    }

                }

                return clients;
            }


        }

        public List<Client> GetCustomerWithTechnology()
        {

            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {
                List<Client> clients = new List<Client>();

                List<int> clientIds = (from client in companyDb.Clients select client.clientId).ToList();

                foreach (int clientId in clientIds)
                {
                    int count = (from mapper in companyDb.TechnologyProjectMappers where mapper.Project.clientId == clientId group mapper by mapper.technologyId into technology select new { technology }).Count();

                    if (count > 3)
                    {
                        clients.Add((from client in companyDb.Clients where client.clientId == clientId select client).FirstOrDefault());
                    }
                }

                return clients;
            }
        }

        public List<Client> GetCustomerWithDelayedTask()
        {
            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {
                List<Client> clients = new List<Client>();

                List<int> clientIds = (from client in companyDb.Clients select client.clientId).ToList();

                foreach (int clientId in clientIds)
                {

                    int count = (from mapper in companyDb.ProjectTaskMappers where mapper.Project.clientId == clientId && mapper.Task.statusId == (int)Status.Delayed group mapper by mapper.taskId into task select new { task }).Count();


                    if (count > 3)
                    {
                        clients.Add((from client in companyDb.Clients where client.clientId == clientId select client).FirstOrDefault());
                    }

                }



                return clients;
            }


        }



        // Extra methods for BL
        public int GetTechnologyUsage(int technologyId)
        {
            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {

                return (from Mapper in companyDb.TechnologyProjectMappers where Mapper.technologyId == technologyId select Mapper).Count();

            }


        }


        public Boolean CheckTechnologyTaskInProject(int taskId, int technologyId)
        {
            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {

                List<int> projectIdList = (from Mapper in companyDb.ProjectTaskMappers where Mapper.taskId == taskId select Mapper.projectId).ToList();


                return (from Mapper in companyDb.TechnologyProjectMappers where projectIdList.Contains(Mapper.projectId) && Mapper.technologyId == technologyId select Mapper).Any();


            }



        }


        public int GetNumberOfTechnologyToTask(int taskId)
        {
            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {
                return (from Mapper in companyDb.TaskTechnologyMappers where Mapper.taskId == taskId select Mapper).Count();

            }

        }


    }
}
