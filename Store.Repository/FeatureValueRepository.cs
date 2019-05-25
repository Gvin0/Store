using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain.Domains;
using Store.Domain.Interfaces;

namespace Store.Repository {
    public class FeatureValueRepository : BaseRepository<FeatureValue>, IFeatureValueRepository
    {
        internal FeatureValueRepository(IStoreDbContext context) : base(context) {

        }
    }
}
