using Management2.Models;
using System.Collections.Generic;

namespace Management2.Repository
{
    public interface Iprocessor
    {
        bool AddDoctor(Doctor req);
        List<Doctor> GetDoctorList();
    }
}
