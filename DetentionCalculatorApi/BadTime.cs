using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DetentionCalculatorApi
{
    /// <summary>
    /// Bad time.
    /// </summary>
    public class BadTime : IStudentTime
    {
        /// <summary>
        /// Gets the student time.
        /// </summary>
        /// <param name="detentionPeriodTime">The detention period time.</param>
        /// <returns></returns>
        public double GetStudentTime(double detentionPeriodTime)
        {
            return detentionPeriodTime + (0.1 * detentionPeriodTime);
        }
    }
}