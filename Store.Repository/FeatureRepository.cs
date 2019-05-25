using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Domain;

namespace Store.Repository {
    public class FeatureRepository : BaseRepository<Feature> {
        internal FeatureRepository(StoreDbContext context) : base(context) {

        }
    }
}
