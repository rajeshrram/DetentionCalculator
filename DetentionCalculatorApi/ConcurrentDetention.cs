using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DetentionCalculatorApi
{
    /// <summary>
    /// This class provide the functionality for concurrent detention.
    /// </summary>
    public class ConcurrentDetention : IDetention
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrentDetention"/> class.
        /// </summary>
        /// <param name="offenses">The offenses.</param>
        /// <param name="studentTime">The student time.</param>
        /// <exception cref="System.ArgumentNullException">
        /// offenses
        /// or
        /// studentTime
        /// </exception>
        /// <exception cref="System.ArgumentException">Offenses should be selected</exception>
        public ConcurrentDetention(IList<Offense> offenses, IStudentTime studentTime)
        {
            if (offenses == null)
                throw new ArgumentNullException("offenses");
            if (offenses.Count == 0)
                throw new ArgumentException("Offenses should be selected");
            if (studentTime == null)
                throw new ArgumentNullException("studentTime");

            m_offenses = offenses;
            m_studentTime = studentTime;
        }

        /// <summary>
        /// Calculates the detention period.
        /// </summary>
        /// <returns></returns>
        public double Calculate()
        {
            double detentionTime = 0;

            detentionTime = GetConcurrentDetentionTimeBasedOnOffenses();
            detentionTime = m_studentTime.GetStudentTime(detentionTime);
            return detentionTime;
        }

        /// <summary>
        /// Gets the concurrent detention time based on offenses.
        /// </summary>
        /// <returns></returns>
        private double GetConcurrentDetentionTimeBasedOnOffenses()
        {
            double detentionTime = 0;
            foreach (Offense offense in m_offenses)
            {
                if (offense.DetentionPeriod > detentionTime)
                {
                    detentionTime = offense.DetentionPeriod;
                }
            }
            return detentionTime;
        }

        private readonly IList<Offense> m_offenses;
        private readonly IStudentTime m_studentTime;
    }
}
