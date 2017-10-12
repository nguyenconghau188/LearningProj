using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManagement
{
    static class ActionFind
    {
        public static ArrayList lstFind = new ArrayList();
        public static ArrayList FindEmployeesByName(ArrayList lst, string name)
        {
            lstFind.Clear();
            foreach(People employee in lst)
            {
                if (employee.name.Contains(name))
                {
                    lstFind.Add(employee);
                }
            }
            return lstFind;
        }
        public static ArrayList FindEmployeesByPosition(ArrayList lst, Position pos)
        {
            lstFind.Clear();
            foreach(People employee in lst)
            {
                if (employee.GetPosition() == pos)
                {
                    lstFind.Add(employee);
                }
            }
            return lstFind;
        }

        internal static ArrayList FindEmployeesByGender(ArrayList lst, Gender gen)
        {
            lstFind.Clear();
            foreach (People employee in lst)
            {
                if (employee.GetGender() == gen)
                {
                    lstFind.Add(employee);
                }
            }
            return lstFind;
        }
    }
}
