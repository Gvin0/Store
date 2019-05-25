using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain {
    public class Feature {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string FeatureName { get; set; }

        [Required, MaxLength(200)]
        public string FeatureDescription { get; set; }

        public virtual FeatureValue FeatureValues { get; set; }
    }
}
