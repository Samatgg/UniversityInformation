using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace UnivetsityInformation
{
    public partial class UniversityInfoForm : Form
    {
        public UniversityInfoForm(string universityName, string cityName, string universityInfo, string imagePath)
        {

            InitializeComponent();
            textBoxUniversityName.Text = universityName;
            textBoxCity.Text = cityName;
            textBoxUniversityInfo.Text = universityInfo;

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                pictureBoxUniversity.Image = Image.FromFile(imagePath);
            }
        }
    }
}
