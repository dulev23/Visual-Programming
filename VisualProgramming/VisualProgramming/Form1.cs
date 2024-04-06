namespace VisualProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbAllCourses.Items.Add("SP");
            lbAllCourses.Items.AddRange(new string[] { "OOP", "NP", "VP" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbCourseName.Text.Length > 0)
            {
                foreach (var item in lbAllCourses.Items)
                {
                    if (item.ToString().Equals(tbCourseName.Text))
                    {
                        return;
                    }
                } 
                lbAllCourses.Items.Add(tbCourseName.Text);
                tbCourseName.Clear();
            }
        }

        private void btnMoveToEnrolled_Click(object sender, EventArgs e)
        {
            foreach (var item in lbAllCourses.SelectedItems)
            {
               clbEnrolledCourses.Items.Add(item);
            }

            while (lbAllCourses.SelectedItems.Count > 0)
            {
                lbAllCourses.Items.Remove(lbAllCourses.SelectedItems[0]);
            }
        }

        private void btnMoveBackToAllCourses_Click(object sender, EventArgs e)
        {
            foreach (var item in clbEnrolledCourses.SelectedItems)
            {
                lbAllCourses.Items.Add(item);
            }

            while (clbEnrolledCourses.SelectedItems.Count > 0)
            {
                clbEnrolledCourses.Items.Remove(clbEnrolledCourses.SelectedItems[0]);
            }
        }
    }
}
