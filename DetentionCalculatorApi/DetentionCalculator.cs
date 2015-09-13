using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DetentionCalculatorApi
{
    /// <summary>
    /// This class provides the functionality for detention calculator.
    /// </summary>
    public sealed class DetentionCalculator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetentionCalculator"/> class.
        /// </summary>
        /// <param name="detention">The detention.</param>
        /// <exception cref="System.ArgumentNullException">detention</exception>
        public DetentionCalculator(IDetention detention)
        {
            if (detention == null)
                throw new ArgumentNullException("detention");

            m_detention = detention;

        }

        /// <summary>
        /// Calculates the detention period.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.ApplicationException">Detention period has exceed the limit and please call the parent</exception>
        public double Calculate()
        {
            double detentionTime = 0;

            detentionTime = m_detention.Calculate();

            if (detentionTime > 8)
                throw new ApplicationException("Detention period has exceed the limit and please call the parent");
            return detentionTime;
        }

        private readonly IDetention m_detention;
    }
}