using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Homework_5_1
{
    public partial class AddEditStudent : Form
    {
        public delegate void MySimpleDelegate();
        public event MySimpleDelegate StudentAdded;

        private FileHelper<List<Student>> _fileHelper = new FileHelper<List<Student>>(Program.FilePath);

        private List<Group> _groups = new List<Group>
            {
                new Group() { Id = 0, Name = "Brak"},
                new Group() { Id = 1, Name = "1a"},
                new Group() { Id = 2, Name = "2a"},
            };

        private int _studentId;
        public AddEditStudent(int id = 0)
        {
            InitializeComponent();

            InitGroupsCombobox();

            tbFirstName.Select();
            _studentId = id;

            if (id != 0)
            {
                Text = "Edytowanie danych ucznia";
                var students = _fileHelper.DeserializeFromFile();
                var student = students.FirstOrDefault(x => x.Id == id);
                if (student == null)
                {
                    throw new Exception("Brak użytkownika o podanym Id");
                }

                tbId.Text = student.Id.ToString();
                tbFirstName.Text = student.FirstName;
                tbLastName.Text = student.LastName;
                rtbComments.Text = student.Comments;
                tbMath.Text = student.Math;
                tbTechnology.Text = student.Technology;
                tbPhysics.Text = student.Physics;
                tbPolishLanguage.Text = student.PolishLang;
                tbForeignLanguage.Text = student.ForeignLang;
                cbAreExtraActivities.Checked = student.AreExtraActivities;
                cbGroup.SelectedItem = _groups.FirstOrDefault(x => x.Id == student.GroupId);
            }

        }

        private void InitGroupsCombobox()
        {
            cbGroup.DataSource = _groups;
            cbGroup.DisplayMember = "Name";
            cbGroup.ValueMember = "Id";
        }
        private void OnStudentAdded()
        {
            StudentAdded?.Invoke();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var students = _fileHelper.DeserializeFromFile();

            if (_studentId != 0)
            {
                students.RemoveAll(x => x.Id == _studentId);
            }
            else
            {
                var studentWithHighestId = students
                    .OrderByDescending(x => x.Id).FirstOrDefault();

               _studentId = studentWithHighestId == null ? 1 : 
                    studentWithHighestId.Id + 1;
            }



            var student = new Student
            {
                Id = _studentId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Comments = rtbComments.Text,
                Math = tbMath.Text,
                Technology = tbTechnology.Text,
                Physics = tbPhysics.Text,
                PolishLang = tbPolishLanguage.Text,
                ForeignLang = tbForeignLanguage.Text,
                AreExtraActivities = cbAreExtraActivities.Checked,
                GroupId = (cbGroup.SelectedItem as Group).Id,
            };

            students.Add(student);

            _fileHelper.SerializeToFile(students);

            OnStudentAdded();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
