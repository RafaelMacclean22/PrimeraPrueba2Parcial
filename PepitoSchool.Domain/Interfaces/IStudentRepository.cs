using DepreciationDBApp.Domain.Interfaces;
using PepitoSchool.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepitoSchool.Domain.Interfaces
{
   public  interface IStudentRepository : IRepository<Estudiante>
    {
        Estudiante FindByEmail(string Correo);
        IEnumerable<Estudiante> FindByApellidos (string Apellidos);
    }
}
