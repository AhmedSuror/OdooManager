using System.Data;
using System.Drawing;
using System.Text;
using Npgsql;
using OdooManager.Model;

namespace OdooManager.Forms;

public partial class FrmMain : Form
{
    public static string conStr = "";
    public FrmMain()
    {
        InitializeComponent();
    }

    #region Functions
    public bool PrepareConnectionString()
    {
        if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.Server) &&
            !string.IsNullOrWhiteSpace(Properties.Settings.Default.UserName) &&
            !string.IsNullOrWhiteSpace(Properties.Settings.Default.Password) &&
            !string.IsNullOrWhiteSpace(Properties.Settings.Default.Database))
        {
            conStr = $"Host={Properties.Settings.Default.Server};Username={Properties.Settings.Default.UserName};Password={Properties.Settings.Default.Password};Database={Properties.Settings.Default.Database};Include Error Detail=true";
            return true;
        }

        return false;
    }
    public void ShowConnectionError()
    {
        tabPage1.Show();
        MessageBox.Show(this, "Test connection first.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    public void ToggleControlsState(bool enabled)
    {
        UseWaitCursor = !enabled;
        tabControl1.Enabled = enabled;
    }
    private async Task FindAllSessionsAsync()
    {
        using (var con = NpgsqlDataSource.Create(conStr))
        {
            var da = new NpgsqlDataAdapter("SELECT * FROM pos_session p;", await con.OpenConnectionAsync());
            DataSet ds = new();
            //da.FillSchema(ds, SchemaType.Source);
            da.Fill(ds, "pos_session");
            dgSessions.DataSource = ds;
            dgSessions.DataMember = ds.Tables[0].TableName;
            lblCount.Text = ds.Tables[0].Rows.Count.ToString();
            MessageBox.Show(this, "Data loaded!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    private async Task FindSessionAsync(int sessionId)
    {
        using (var con = NpgsqlDataSource.Create(conStr))
        {
            var da = new NpgsqlDataAdapter($"SELECT * FROM pos_session p where p.id = {sessionId};", await con.OpenConnectionAsync());
            DataSet ds = new();
            //da.FillSchema(ds, SchemaType.Source);
            da.Fill(ds, "pos_session");
            dgSessions.DataSource = ds;
            dgSessions.DataMember = ds.Tables[0].TableName;
            lblCount.Text = ds.Tables[0].Rows.Count.ToString();
            MessageBox.Show(this, "Data loaded!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    #endregion

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

            ToggleControlsState(false);

            conStr = $"Host={con.Server};Username={con.UserName};Password={con.Password};Database={con.Database}";
            await using var dataSource = NpgsqlDataSource.Create(conStr);

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
            ToggleControlsState(true);
        }
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private async void btnLoadAllSessions_Click(object sender, EventArgs e)
    {
        if (PrepareConnectionString())
        {
            ToggleControlsState(false);
            await FindAllSessionsAsync();
        }
        else
        {
            ShowConnectionError();
        }
        ToggleControlsState(true);

    }


    private async void toolStripButton1_Click(object sender, EventArgs e)
    {
        int sid;
        if (string.IsNullOrWhiteSpace(txtSessionId.Text))
        {
            MessageBox.Show(this, "Enter session Id first.", "Find a session", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else if (!int.TryParse(txtSessionId.Text, out sid))
        {
            MessageBox.Show(this, "Enter session Id correctly.", "Find a session", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            if (PrepareConnectionString())
            {
                ToggleControlsState(false);
                await FindSessionAsync(sid);
            }
            else
            {
                ShowConnectionError();
            }
            ToggleControlsState(true);
        }
    }

    private async void btnDelSession_Click(object sender, EventArgs e)
    {
        if (dgSessions.RowCount == 0)
        {
            MessageBox.Show(this, "Select a session first.", "Delete a session", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else if (dgSessions.RowCount > 1)
        {
            MessageBox.Show(this, "Find a single session first.", "Delete a session", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            //Delete
            if (PrepareConnectionString())
            {
                ToggleControlsState(false);

                var sid = dgSessions.SelectedRows[0].Cells[0].Value;

                var m = MessageBox.Show(this, $"Are you sure you want to delete session #{sid}", "Delete a session",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (m == DialogResult.Yes)
                {
                    await using var ds = NpgsqlDataSource.Create(conStr);

                    var dc = ds.CreateCommand($"DELETE FROM pos_session p WHERE p.id = {sid};");
                    try
                    {
                        await dc.ExecuteNonQueryAsync();
                        MessageBox.Show(this, $"Session #{sid} was deleted successfully.", "Delete a session", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "Delete a session", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                ShowConnectionError();
            }
            ToggleControlsState(true);
        }
    }

    private void dgSessions_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dgSessions.SelectedRows[0].Index > -1)
        {
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show(dgSessions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
        }
    }
}