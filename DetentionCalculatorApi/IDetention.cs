using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DetentionCalculatorApi
{
    /// <summary>
    /// We can add different detentionmodes by using this interface.
    /// </summary>
    public interface IDetention
    {
        /// <summary>
        /// Calculates the detention period.
        /// </summary>
        /// <returns></returns>
        double Calculate();
    }
}
