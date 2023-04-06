using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Code_Login
{
    public partial class FormProgramming : Form
    {
        List<Student> students = new List<Student>(); // List Data 

        List<ListViewItem> list = new List<ListViewItem>(); // List Row Item 
        public FormProgramming()
        {
            InitializeComponent();
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            // this.WindowState = FormWindowState.Maximized;
            Lv_Student.FullRowSelect = true;
            // Display grid lines.
            Lv_Student.GridLines = true;
            Lv_Student.Columns.Add("StudentCode", -2, HorizontalAlignment.Left);
            Lv_Student.Columns.Add("StudentName", -2, HorizontalAlignment.Left);
            Lv_Student.Columns.Add("Address", -2, HorizontalAlignment.Left);
            Lv_Student.Columns.Add("BirthDay", -2, HorizontalAlignment.Center);
            Lv_Student.Columns.Add("Gender", -2, HorizontalAlignment.Center);
            Lv_Student.Columns.Add("MathScore", -2, HorizontalAlignment.Center);
            /* this.panel2.Controls.Add(Lv_Student);
             this.Controls.Add(this.panel2);*/
            Lv_Student.View = View.Details; // Phai co lenh nay thi View moi Hien Thi len Giao dien




            /*  for(int i = 0; i<10;i++)
              {
                  ListViewItem studentItem = new ListViewItem("Code"+i);

                  Student student = new Student();
                  student.StudentCode = (i+1).ToString();
                  student.Name = "Nguyen Van A"+ i.ToString();
                  student.Gender = true;
                  student.MathScore = i + 10;

                  var dtStr = "2001-03-21";
                  DateTime myDate = DateTime.ParseExact(dtStr, "yyyy-MM-dd",
                                                         System.Globalization.CultureInfo.InvariantCulture);
                  student.BrithDay = myDate;
                  student.Address = "Hanoi";

                  students.Add(student);

                  studentItem.SubItems.Add(student.Name);
                  studentItem.SubItems.Add(student.Address + "");
                  studentItem.SubItems.Add(student.BrithDay +"");
                  studentItem.SubItems.Add(student.Gender.ToString());
                  studentItem.SubItems.Add(student.MathScore +"");
                  list.Add(studentItem);


              }*/

            rdtMale.Checked = true;
        }

        void RefreshListView(List<Student> students)
        {

            list = new List<ListViewItem>();

            for (int i = 0; i < students.Count; i++)
            {

                Student student = students[i];
                ListViewItem studentItem = new ListViewItem(student.StudentCode, i);

                studentItem.SubItems.Add(student.Name);
                studentItem.SubItems.Add(student.Address + "");
                studentItem.SubItems.Add(student.BrithDay + "");
                studentItem.SubItems.Add(student.Gender.ToString());
                studentItem.SubItems.Add(student.MathScore + "");
                list.Add(studentItem);


            }

            Lv_Student.Items.Clear();
            Lv_Student.Items.AddRange(list.ToArray());

        }

        private void txt_Thoat_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void Dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Loginform f = new Loginform();
            f.Show();
        }
        

        

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (keyword == "")
            {
                listSearch.Clear();
                listSearch = new List<Student>();

                RefreshListView(students);

            }
            else
            {
                foreach (Student student in students)
                {
                    if (keyword.Equals(student.Name))
                    {
                        listSearch.Add(student);
                    }
                }

                RefreshListView(listSearch);

            }

        }

        private void Lv_Student_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* var firstSelectedItem = Lv_Student.SelectedItems[0].Index;


            Student student = students[firstSelectedItem];


             txtStudentName.Text = student.Name;
             txtAddress.Text = student.Address;
             txtMathScore.Text = student.MathScore + "";
             txtStudentCode.Text = student.StudentCode;
             dtpBirthDay.Text = student.BrithDay;
            bool Gender = student.Gender;

            if (Gender)
            {
                rdtFemale.Checked = false;
                rdtMale.Checked = true;

            }

            if (!Gender)
            {
                rdtFemale.Checked = true;
                rdtMale.Checked = false;
            }*/
            if (Lv_Student.SelectedItems.Count > 0)
            {
                txtStudentName.Text = Lv_Student.SelectedItems[0].SubItems[0].Text;
                txtStudentCode.Text = Lv_Student.SelectedItems[0].SubItems[1].Text;
                txtMathScore.Text = Lv_Student.SelectedItems[0].SubItems[2].Text;
                txtAddress.Text = Lv_Student.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void Up_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String name = txtStudentName.Text;
            String address = txtAddress.Text;
            String math = txtMathScore.Text;
            String code = txtStudentCode.Text;
            String birthdayString = dtpBirthDay.Text;
            bool Gender = true;

            if (rdtMale.Checked)
            {
                rdtFemale.Checked = false;

                Gender = true;
            }

            if (rdtFemale.Checked)
            {
                rdtMale.Checked = false;
                Gender = false;
            }

            Student student = new Student();
            student.Name = name;
            student.Address = address;
            student.Gender = Gender;
            student.MathScore = Convert.ToDouble(math);
            student.BrithDay = birthdayString;

            students.Add(student);

            RefreshListView(students);



        }

        List<Student> listSearch = new List<Student>();

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
                if (Lv_Student.SelectedItems.Count > 0)
                {
                    // Lưu index của mục được chọn đầu tiên vào một biến
                    int firstSelectedItemIndex = Lv_Student.SelectedItems[0].Index;

                    // Xóa mục được chọn đầu tiên
                    Lv_Student.Items.Remove(Lv_Student.SelectedItems[0]);

                    // Nếu sau khi xóa mục thì vẫn còn mục trong ListView
                    if (Lv_Student.Items.Count > 0)
                    {
                        // Kiểm tra nếu index của mục được chọn đầu tiên lớn hơn số lượng mục hiện tại
                        if (firstSelectedItemIndex >= Lv_Student.Items.Count)
                        {
                            // Chọn mục cuối cùng trong ListView
                            Lv_Student.Items[Lv_Student.Items.Count - 1].Selected = true;
                            Lv_Student.Items[Lv_Student.Items.Count - 1].Focused = true;
                        }
                        else
                        {
                            // Chọn mục tiếp theo trong ListView
                            Lv_Student.Items[firstSelectedItemIndex].Selected = true;
                            Lv_Student.Items[firstSelectedItemIndex].Focused = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        

        }
    }

