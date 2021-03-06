using Microsoft.EntityFrameworkCore;
using PepitoSchool.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PepitoSchool.Domain.Interfaces
{
   public  interface IStudentDBcontext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
        public int SaveChanges();
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
