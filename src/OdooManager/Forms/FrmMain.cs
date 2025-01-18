using System.Drawing;
using System.Text;
using Npgsql;
using OdooManager.Model;

namespace OdooManager.Forms;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
        txtServer.Text = Properties.Settings.Default.Server;
        txtUser.Text = Properties.Settings.Default.UserName;
        txtDb.Text = Properties.Settings.Default.Database;
        txtPass.Text = Properties.Settings.Default.Password;
    }

    private async void btnConnect_Click(object sender, EventArgs e)
    {
        var con = new ConnectionVM()
        {
            UserName = txtUser.Text.Trim(),
            Database = txtDb.Text.Trim(),
            Password = txtPass.Text.Trim(),
            Server = txtServer.Text.Trim()
        };

        var validator = new ConnectionValidator().Validate(con);
        if (!validator.IsValid)
        {
            StringBuilder str = new();
            foreach (var err in validator.Errors)
            {
                str.AppendLine(err.ErrorMessage);
            }
            MessageBox.Show(this, str.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            Properties.Settings.Default.Server = con.Server;
            Properties.Settings.Default.UserName = con.UserName;
            Properties.Settings.Default.Database = con.Database;
            Properties.Settings.Default.Password = con.Password;

            Properties.Settings.Default.Save();

            var connectionString = $"Host={con.Server};Username={con.UserName};Password={con.Password};Database={con.Database}";
            await using var dataSource = NpgsqlDataSource.Create(connectionString);

            //// Insert some data
            //await using (var cmd = dataSource.CreateCommand("INSERT INTO data (some_field) VALUES ($1)"))
            //{
            //    cmd.Parameters.AddWithValue("Hello world");
            //    await cmd.ExecuteNonQueryAsync();
            //}

            // Retrieve all rows
            //await using (var cmd = dataSource.CreateCommand("SELECT some_field FROM data"))
            //await using (var reader = await cmd.ExecuteReaderAsync())
            //{
            //    while (await reader.ReadAsync())
            //    {
            //        Console.WriteLine(reader.GetString(0));
            //    }
            //}
            try
            {
                await dataSource.OpenConnectionAsync();
                MessageBox.Show(this, "Connected successfully.", Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}