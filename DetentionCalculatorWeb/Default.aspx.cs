using DetentionCalculatorApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DetentionCalculatorWeb
{
    /// <summary>
    /// Default aspx page.
    /// </summary>
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lstOffenses.DataSource = offenses;
                lstOffenses.DataValueField = "DetentionPeriod";
                lstOffenses.DataTextField = "OffenseType";
                lstOffenses.DataBind();
            }
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the label values.
                lblSuccess.Text = string.Empty;
                lblFailure.Text = string.Empty;
                // Initialize the variables.
                Student student = new Student(txtStudentName.Text);
                IStudentTime studentTime = null;
                IDetention detention = null;
                IList<Offense> selectedOffenses = new List<Offense>();

                //Getting the selected offenses list.
                foreach (int index in lstOffenses.GetSelectedIndices())
                {
                    selectedOffenses.Add(offenses[index]);
                }

                //Get good or bad time.
                if (rdbGoodTime.Checked)
                    studentTime = new GoodTime();
                else
                    studentTime = new BadTime();

                // Get the calculation mode.
                if (rdbConcurrentMode.Checked)
                    detention = new ConcurrentDetention(selectedOffenses, studentTime);
                else
                    detention = new ConsecutiveDetention(selectedOffenses, studentTime);
                //Calculate the detention period.
                DetentionCalculator detentionCalculator = new DetentionCalculator(detention);
                double detentionPeriod = detentionCalculator.Calculate();

                lblSuccess.Text = string.Format("Detention period for {0} is {1}", student.StudentName, detentionPeriod.ToString());
            }
            catch (Exception ex)
            {
                lblFailure.Text = string.Format("{0}", ex.Message);
            }
        }

        private readonly IList<Offense> offenses = new List<Offense>()
                                            {
                                                new Offense() { OffenseType = "Not done home work", DetentionPeriod = 1.5 },
                                                new Offense() { OffenseType = "stealing", DetentionPeriod = 2 },
                                                new Offense() { OffenseType = "offense1", DetentionPeriod =  3},
                                                new Offense() { OffenseType = "offense2", DetentionPeriod =  4},
                                                new Offense() { OffenseType = "offense3", DetentionPeriod =  5},
                                            };
    }
}