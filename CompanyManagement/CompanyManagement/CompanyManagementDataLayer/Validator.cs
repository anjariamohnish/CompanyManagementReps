using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyManagementDataLayer
{
    public class Validator
    {


        public String CheckProjectForNull(CompanyEntities.Project project)

        {

            if (string.IsNullOrEmpty(project.Name))
            {
                return Resource.ProjectNameMissing;
            }
            else if (project.DepartmentMasterId == 0)
            {
                return Resource.DepartmentIdMissing;
            }
            else if (project.StatusMasterId == 0)
            {
                return Resource.StatusIdMissing;
            }
            else if (project.ClientId == 0)
            {
                return Resource.ClientIdMissing;
            }
            else
            {
                return Resource.AllFieldPresent;
            }

        }

        public String CheckEmployeeForNull(CompanyEntities.Employee employee)
        {
            if (string.IsNullOrEmpty(employee.FirstName) || string.IsNullOrEmpty(employee.LastName))
            {
                return Resource.EmployeeNameMissing;
            }
            else if (string.IsNullOrEmpty(employee.Email))
            {
                return Resource.EmployeeEmailMissing;
            }
            else if (employee.PhoneNumber == 0)
            {
                return Resource.EmployeePhoneNumberMissing;
            }
            else if (employee.HireDate == null)
            {
                return Resource.EmployeeHirDateMissing;
            }
            else if (employee.DepartmentMasterId == 0)
            {
                return Resource.EmployeeDepartmentIdMissing;
            }
            else if (employee.Salary == 0)
            {
                return Resource.EmployeeSalaryMissing;
            }
            else
            {
                return Resource.AllFieldPresent;
            }
        }

        public String CheckTechnologForNull(CompanyEntities.Technology technology)
        {
            if (string.IsNullOrEmpty(technology.Name))
            {
                return Resource.TechnologyNameMissing;
            }
            else if (float.IsNaN(technology.Version))
            {
                return Resource.TechnologyVersionMissing;
            }
            else
            {
                return Resource.AllFieldPresent;
            }

        }

        public String CheckTaskForNull(CompanyEntities.Task task)
        {
            if (string.IsNullOrEmpty(task.Name))
            {
                return Resource.TaskNameMissing;
            }
            else if (task.StatusId == 0)
            {
                return Resource.StatusIdMissing;
            }
            else
            {
                return Resource.AllFieldPresent;
            }
        }

        public String CheckProjectExist(int projectId)
        {
            if (projectId == 0)
            {
                return null;
            }
            else
            {

                using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
                {


                    if ((from project in companyDb.Projects where project.projectId == projectId select project).Any())
                    {
                        return Resource.AllFieldPresent;
                    }
                    else
                    {
                        return Resource.ProjectIdNotFound;

                    }


                }

            }
        }

        public String CheckEmployeeExist(int employeeId)
        {
            if (employeeId == 0)
            {
                return Resource.EmployeeIdMissing;
            }
            else
            {
                using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
                {

                    if ((from employee in companyDb.Employees where employee.employeeId == employeeId select employee).Any())
                    {
                        return Resource.AllFieldPresent;
                    }
                    else
                    {
                        return Resource.EmployeeIdMissingDb;
                    }


                }
            }
        }

        public String CheckTechnologyExist(int technologyId)
        {
            if (technologyId == 0)
            {
                return Resource.TechnologyIdMissing;
            }
            else
            {

                using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
                {



                    if ((from technology in companyDb.TechnologyMasters where technology.technologyMasterId == technologyId select technology).Any())
                    {
                        return Resource.AllFieldPresent;
                    }
                    else
                    {
                        return Resource.TechnologyIdMissingDb;
                    }


                }
            }
        }

        public String CheckTaskExist(int taskId)
        {
            if (taskId == 0)
            {
                return Resource.TaskIdMissing;
            }
            else
            {

                using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
                {

                    if ((from task in companyDb.Tasks where task.taskId == taskId select task).Any())
                    {
                        return Resource.AllFieldPresent;
                    }
                    else
                    {
                        return Resource.TaskIdMissingDb;
                    }

                }
            }
        }

        public String CheckTechnologyExist(List<int> technologyId)
        {
            int count = 0;
            using (CompanyDbDataContext companyDb = new CompanyDbDataContext())
            {
                foreach (int technologyid in technologyId)
                {
                    if (!(technologyid == 0))
                    {

                        if (!(from technology in companyDb.TechnologyMasters where technology.technologyMasterId == technologyid select technology).Any())
                        {
                            count++;
                        }
                    }
                    else
                    {
                        count++;
                    }
                }
            }

            if (count > 1)
            {
                return Resource.TechnologyIdMissing;
            }
            else
            {
                return Resource.AllFieldPresent;
            }
        }






    }
}
