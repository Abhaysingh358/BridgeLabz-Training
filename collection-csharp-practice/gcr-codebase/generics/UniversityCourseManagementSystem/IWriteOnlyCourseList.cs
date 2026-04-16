using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.UniversityCourseManagementSystem
{
    // Contravariant interface (Write-only)
    internal interface IWriteOnlyCourseList<in T> where T : CourseType
    {
        void AddCourse(T course);
    }
}
