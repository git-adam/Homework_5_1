using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Threading;

namespace Homework_5_1
{
    public partial class Main : Form
    {
        private FileHelper<List<Student>> _fileHelper = new FileHelper<List<Student>>(Program.FilePath);
        private List<Group> _groups = new List<Group>
            {
                new Group() { Id = 0, Name = "Wszyscy"},
                new Group() { Id = 1, Name = "1a"},
                new Group() { Id = 2, Name = "2a"},
            };

        public Main()
        {

            InitializeComponent();
            InitGroupsCombobox();


            //var students = new List<Student>();
            //
            //students.Add(new Student { FirstName = "Adam" });
            //students.Add(new Student() { FirstName = "Robert"  });
            //students.Add(new Student { FirstName = "Janyusz"  });

            //SerializeToFile3(students);
            //var students = DeserializeFromFile3();
            // MessageBox.Show(students[1].FirstName);
            //var path = $"{Path.GetDirectoryName(Application.ExecutablePath)}\\..\\NowyPlik2.txt";

            //if (!File.Exists(path))
            //{
            //    File.Create(path);                
            //}
            ////File.Delete(path);
            //File.WriteAllText(path, "If you dont know me by now...\n");
            //File.AppendAllText(path, "...you will never, never, never know me");
            //var text = File.ReadAllText(path);
            //MessageBox.Show(text);
            //MessageBox.Show("Test", "tytul", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);

            RefreshDiary();

            SetColumnHeader();

        }

        private void SetColumnHeader()
        {
            dgvDiary.Columns[nameof(Student.Id)].HeaderText = "Identyfikator";
            dgvDiary.Columns[nameof(Student.FirstName)].HeaderText = "Imię";
            dgvDiary.Columns[nameof(Student.LastName)].HeaderText = "Nazwisko";
            dgvDiary.Columns[nameof(Student.Comments)].HeaderText = "Uwagi";
            dgvDiary.Columns[nameof(Student.Math)].HeaderText = "Matematyka";
            dgvDiary.Columns[nameof(Student.Technology)].HeaderText = "Technologia";
            dgvDiary.Columns[nameof(Student.Physics)].HeaderText = "Fizyka";
            dgvDiary.Columns[nameof(Student.PolishLang)].HeaderText = "Język polski";
            dgvDiary.Columns[nameof(Student.ForeignLang)].HeaderText = "Język angielski";
            dgvDiary.Columns[nameof(Student.AreExtraActivities)].HeaderText = "Zajęcia dodatkowe";
            dgvDiary.Columns[nameof(Student.GroupId)].HeaderText = "Klasa";
        }

        private async Task MethodAsync()
        {
            await Task.Run(() => Thread.Sleep(3000));
        }
        private void RefreshDiary()
        {
            var students = _fileHelper.DeserializeFromFile();

            var selectedGroupId = (cbGroupFilter.SelectedItem as Group).Id;

            if (selectedGroupId == 0)
                dgvDiary.DataSource = students;
            else
                students = students.Where(x => x.GroupId == selectedGroupId).ToList();

            dgvDiary.DataSource = students;
        }

        private void InitGroupsCombobox()
        {
            cbGroupFilter.DataSource = _groups;
            cbGroupFilter.DisplayMember = "Name";
            cbGroupFilter.ValueMember = "Id";
        }

        //public void SerializeToFile3(List<Student> students)
        //{
        //    var serializer = new JsonSerializer();
        //    using (StreamWriter streamWriter = new StreamWriter(_filePath))
        //    {
        //        serializer.Serialize(streamWriter, students);
        //        streamWriter.Close();
        //    }

        //}

        //public void SerializeToFile(List<Student> students)
        //{
        //    var serializer = new XmlSerializer(typeof(List<Student>));
        //    using (StreamWriter streamWriter = new StreamWriter(_filePath))
        //    {
        //        serializer.Serialize(streamWriter, students);
        //        streamWriter.Close();
        //    }
        //}

        //public void SerializeToFile2(List<Student> students)
        //{

        //    var serializer = new XmlSerializer(typeof(List<Student>));
        //    StreamWriter streamWriter = null;

        //    try
        //    {

        //        streamWriter = new StreamWriter(_filePath);
        //        serializer.Serialize(streamWriter, students);
        //        streamWriter.Close();
        //    }
        //    finally
        //    {
        //        streamWriter.Dispose();
        //    }

        //}

        //public List<Student> DeserializeFromFile()
        //{
        //    if (!File.Exists(_filePath))
        //    {
        //        return new List<Student>();
        //    }

        //    var serializer = new XmlSerializer(typeof(List<Student>));
        //    using (StreamReader streamReader = new StreamReader(_filePath))
        //    {
        //        var students = (List<Student>)serializer.Deserialize(streamReader);
        //        streamReader.Close();

        //        return students;
        //    }
        //}

        //public List<Student> DeserializeFromFile3()
        //{
        //    if (!File.Exists(_filePath))
        //    {
        //        return new List<Student>();
        //    }

        //    var serializer = new JsonSerializer();

        //    using (StreamReader streamReader = new StreamReader(_filePath))
        //    using (JsonTextReader jsonTextReader = new JsonTextReader(streamReader))
        //    {
        //        var students = serializer.Deserialize<List<Student>>(jsonTextReader);
        //        jsonTextReader.Close();
        //        streamReader.Close();
        //        return students;
        //    }
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEditStudent = new AddEditStudent();
            addEditStudent.StudentAdded += AddEditStudent_StudentAdded;            
            addEditStudent.ShowDialog();
            addEditStudent.StudentAdded -= AddEditStudent_StudentAdded;
        }

        private void AddEditStudent_StudentAdded()
        {
            RefreshDiary();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDiary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznaczyć ucznia, którego chcesz edytować!");
                return;
            }

            var addEditStudent = new AddEditStudent(
                Convert.ToInt32(dgvDiary.SelectedRows[0].Cells[0].Value));

            addEditStudent.StudentAdded += AddEditStudent_StudentAdded;
            addEditStudent.ShowDialog();
            addEditStudent.StudentAdded -= AddEditStudent_StudentAdded;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDiary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznaczyć ucznia, którego chcesz usunąć!");
                return;
            }

            var selectedStudent = dgvDiary.SelectedRows[0];

            var confirmDelete = MessageBox.Show($"Czy na pewno chcesz usunąć użytkownika " +
                $"{(selectedStudent.Cells[1].Value.ToString() + " " + selectedStudent.Cells[2].Value.ToString()).Trim()}",
                "Usuwanie ucznia", MessageBoxButtons.OKCancel);

            if (confirmDelete == DialogResult.OK)
            {
                var students = _fileHelper.DeserializeFromFile();
                students.RemoveAll(x => x.Id == Convert.ToInt32(selectedStudent.Cells[0].Value));
                _fileHelper.SerializeToFile(students);
                dgvDiary.DataSource = students;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDiary();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            RefreshDiary();
        }
    }
}
