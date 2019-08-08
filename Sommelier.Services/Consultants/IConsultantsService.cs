using Sommelier.Models;
using Sommelier.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sommelier.Services.Consultants
{
    public interface IConsultantsService
    {
        IEnumerable<Consultant> GetAllConsultants();
        Consultant GetConsultantById(Guid id);
        Consultant CreateConsultant(Consultant c);
        void DeleteConsultant(Consultant c);
        void UpdateConsultant(Consultant c);
    }
}
