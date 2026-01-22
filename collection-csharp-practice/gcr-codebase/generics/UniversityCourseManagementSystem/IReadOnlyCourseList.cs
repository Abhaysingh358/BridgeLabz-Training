using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.UniversityCourseManagementSystem
{
    // Covariant interface (Read-only)
    internal interface IReadOnlyCourseList<out T> where T : CourseType
    {
        IEnumerable<T> GetAllCourses();
    }

}

