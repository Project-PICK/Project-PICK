//Data Source=:memory:;Version=3;New=True;
//Data Source=c:\mydb.db;Version=3;



using System.DataSQLite; 
  
namespace Registration
{	
	public partial class LoginPage : Form
	{
		public LoginPage()
		{
			InitializeComponent();
		}
		
		private void LoginBTN_CLICK(object sender , EventArgs e)
		{
			if (user.Text.Trim() == "" && pass.Text.Trim() == "")
			{
				MessageBox.Show("Empty","Please enter Fields");
			}
			else
			{
				string query = "SELECT * FROM people WHERE username= @user and password = @pass";
				SQLiteConnection conn = new SQLiteConnection("Data Source=db.db;Version=3;");
				conn.Open();
				
				SQLiteConnection lite_conn = new SQLiteConnection(query, conn);
				//Paramaters
				cmd.Parameters.AddWithValue("user",user.Text);
				cmd.Parameters.AddWithValue("user",user.Text);
				SQLiteDataAdapter data_adapter = new SQLiteDataAdapter(cmd);
				DataTable data_table = new DataTable();
				data_adapter(data_table);
				
				if (data_table.Rows.Count > 0)
				{
					MessageBox.Show("Thank you, you may now proceed to training");
				}
				else
				{
					MessageBox.Show("An error has occurred, please try again!");
				}
			}
		}		
	}			
}				
				
				
				