using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DetentionCalculatorApi
{
    /// <summary>
    /// Offense
    /// </summary>
    public class Offense
    {
        /// <summary>
        /// Gets or sets the type of the offense.
        /// </summary>
        public string OffenseType { get; set; }

        /// <summary>
        /// Gets or sets the detention period.
        /// </summary>
        public double DetentionPeriod { get; set; }
    }
}