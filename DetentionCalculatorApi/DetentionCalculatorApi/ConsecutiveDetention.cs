using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DetentionCalculatorApi
{
    /// <summary>
    /// This class provide the functionality for consecutive detention.
    /// </summary>
    public class ConsecutiveDetention : IDetention
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsecutiveDetention"/> class.
        /// </summary>
        /// <param name="offenses">The offenses.</param>
        /// <param name="studentTime">The student time.</param>
        /// <exception cref="System.ArgumentNullException">
        /// offenses
        /// or
        /// studentTime
        /// </exception>
        /// <exception cref="System.ArgumentException">Offenses should be selected</exception>
        public ConsecutiveDetention(IList<Offense> offenses, IStudentTime studentTime)
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

            detentionTime = GetConsecutiveDetentionTimeBasedOnOffenses();
            detentionTime = m_studentTime.GetStudentTime(detentionTime);
            return detentionTime;
        }

        /// <summary>
        /// Gets the consecutive detention time based on offenses.
        /// </summary>
        /// <returns></returns>
        private double GetConsecutiveDetentionTimeBasedOnOffenses()
        {
            double detentionTime = 0;
            foreach (Offense offense in m_offenses)
            {
                detentionTime += offense.DetentionPeriod;
            }
            return detentionTime;
        }

        private readonly IList<Offense> m_offenses;
        private readonly IStudentTime m_studentTime;
    }
}
