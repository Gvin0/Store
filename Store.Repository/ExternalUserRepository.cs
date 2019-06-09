using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Interfaces;
using Store.Domain.Domains;

namespace Store.Repository {
    public class ExternalUserRepository : BaseRepository<ExternalUser>, IExternalUserRepository {
        internal ExternalUserRepository(IStoreDbContext context) : base(context) {

        }
    }
}
