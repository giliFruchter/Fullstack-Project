using Dal.Api;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Service
{
    public class InvitationService : IInvitation
    {
        DatabaseManager db;
        public InvitationService(DatabaseManager db)
        {
            this.db = db;
        }
        public void Create(Invitation item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Invitation item)
        {
            throw new NotImplementedException();
        }

        public Task<List<Invitation>> Read()
        {
            return  db.Invitations.ToListAsync();
        }

        public void UpDate(Invitation item)
        {
            throw new NotImplementedException();
        }
       
    }
}
