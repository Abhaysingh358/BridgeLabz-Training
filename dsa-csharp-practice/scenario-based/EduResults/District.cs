using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.EduResults
{
    internal class District
    {
        private string _districtName;
        private StudentLinkedList _districtList;

        public District(string districtName)
        {
            _districtName = districtName;
            _districtList = new StudentLinkedList();
        }

        public string GetDistrictName()
        {
            return _districtName;
        }

        public void AddStudent(Student student)
        {
            _districtList.AddStudent(student);
        }

        public void RemoveStudent(int rollNumber)
        {
            _districtList.RemoveStudent(rollNumber);
        }

        public void SortDistrictList()
        {
            _districtList.SortList();
        }

        public StudentLinkedList GetDistrictList()
        {
            return _districtList;
        }
    }
}
