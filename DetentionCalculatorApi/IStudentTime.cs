using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DetentionCalculatorApi
{
    /// <summary>
    /// Student time.
    /// </summary>
    public interface IStudentTime
    {
        /// <summary>
        /// Gets the student time.
        /// </summary>
        /// <param name="detentionPeriodTime">The detention period time.</param>
        /// <returns></returns>
        double GetStudentTime(double detentionPeriodTime);
    }
}