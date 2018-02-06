using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementDataLayer
{
    public class Validator
    {


        public String CheckProjectForNull(CompanyEntities.Project project)

        {

            if (string.IsNullOrEmpty(project.name))
            {
                return Resource.ProjectNameMissing;
            }
            else if (project.departmentMasterId == 0)
            {
                return Resource.DepartmentIdMissing;
            }
            else if (project.statusMasterId == 0)
            {
                return Resource.StatusIdMissing;
            }
            else if (project.clientId == 0)
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
            if (string.IsNullOrEmpty(employee.fname) || string.IsNullOrEmpty(employee.lname))
            {
                return Resource.EmployeeNameMissing;
            }
            else if (string.IsNullOrEmpty(employee.email))
            {
                return Resource.EmployeeEmailMissing;
            }
            else if (employee.phoneNumber == 0)
            {
                return Resource.EmployeePhoneNumberMissing;
            }
            else if (employee.hireDate == null)
            {
                return Resource.EmployeeHirDateMissing;
            }
            else if (employee.departmentMasterId == 0)
            {
                return Resource.EmployeeDepartmentIdMissing;
            }
            else if (employee.salary == 0)
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
            if (string.IsNullOrEmpty(technology.name))
            {
                return Resource.TechnologyNameMissing;
            }
            else if (float.IsNaN(technology.version))
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
            if (string.IsNullOrEmpty(task.name))
            {
                return Resource.TaskNameMissing;
            }
            else if (task.statusId == 0)
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
                    }else
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
