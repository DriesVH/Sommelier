using Sommelier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sommelier.Repositories.Consultants
{
    public class ConsultantsRepository: IRepository<Consultant>
    {
        private List<Consultant> Consultants;

        public ConsultantsRepository()
        {
            Consultants = new List<Consultant>()
            {
                new Consultant
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Dries",
                    LastName = "Van Hertbruggen",
                    BirthDay = new DateTime(1996, 11, 05),
                    Contract = new ElmosContract
                    {
                        Id = Guid.NewGuid(),
                        Name = "",
                        StartDate = new DateTime(2019, 06, 17),
                    },
                    Address = new Address
                    {
                        Id = Guid.NewGuid(),
                        StreetName = "Laathoflaan",
                        HouseNumber = "46",
                        Zip = new Zip
                        {
                            Id = Guid.NewGuid(),
                            Name = "Ekeren",
                            ZipCode = "2180"
                        }
                    }
                }
            };
        }
        public Consultant Create(Consultant entity)
        {
            Consultants.Add(entity);
            return entity;
        }

        public void Delete(Consultant entity)
        {
            this.Consultants.Remove(entity);
        }

        public IEnumerable<Consultant> GetAll()
        {
            return Consultants;
        }

        public Consultant GetById(Guid id)
        {
            return this.Consultants.Where(p => p.Id == id).SingleOrDefault();
        }

        public void Update(Consultant entity)
        {
            throw new NotImplementedException();
        }
    }
}

    
   