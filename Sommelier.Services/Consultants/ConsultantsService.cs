using Sommelier.Models;
using Sommelier.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sommelier.Services.Consultants
{
    public class ConsultantsService : IConsultantsService
    {
        private readonly IRepository<Consultant> ConsultantsRepo;

        public ConsultantsService(IRepository<Consultant> ConsultantsRepo)
        {
            this.ConsultantsRepo = ConsultantsRepo;
        }

        public Consultant CreateConsultant(Consultant c)
        {
            return this.ConsultantsRepo.Create(c);
        }

        public void DeleteConsultant(Consultant c)
        {
            this.ConsultantsRepo.Delete(c);
        }

        public IEnumerable<Consultant> GetAllConsultants()
        {
            return this.ConsultantsRepo.GetAll();
        }

        public Consultant GetConsultantById(Guid id)
        {
            return this.ConsultantsRepo.GetById(id);
        }

        public void UpdateConsultant(Consultant c)
        {
            throw new NotImplementedException();
        }
    }
}
