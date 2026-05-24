using System.Data;

namespace LocalDBExample
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            UserDataGridView.DataSource = LoadUsers();
        }

        private DataTable LoadUsers()
        {
            var usersTable = new DataTable();

            using var conn = Database.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Users";

            using var reader = cmd.ExecuteReader();

            usersTable.Load(reader);

            return usersTable;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO Users (Name, Age, Salary, Password) VALUES (@name, @age, @salary, @password)";
            cmd.Parameters.AddWithValue("@name", UserNameBox.Text);
            cmd.Parameters.AddWithValue("@age", int.Parse(AgeBox.Text));
            cmd.Parameters.AddWithValue("@salary", double.Parse(SalaryBox.Text));
            cmd.Parameters.AddWithValue("@password", PasswordBox.Text);

            cmd.ExecuteNonQuery();

            UserDataGridView.DataSource = LoadUsers();

            MessageBox.Show("User added successfully!");
        }
    }
}
