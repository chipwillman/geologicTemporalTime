using System;
using System.Collections.Generic;
using System.Text;

namespace OwlOntology.Models
{
    public class TemporalPosition
    {
        /// <summary>
        /// YBP is Years Before Present starting from 1950
        /// 11700 YBP = 9750 BC
        /// 6663 YBP = 0 JD = 4713 BC
        /// 1110 YBP = 1110 Cal YBP = 1310 Uncal YBP
        /// </summary>
        public virtual decimal? YBP { get; set; }
        public object IndeterminatePosition { get; set; }
    }
}
