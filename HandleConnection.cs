using Microsoft.Data.SqlClient;
namespace StudentManagementSysytem;
public static class HandleConnection
{
    public static readonly string ConnnectionString = $"Server=DESKTOP-IBQJ98S\\SQLEXPRESS;Database=dbUMS;Trusted_Connection=true;TrustServerCertificate=true;";
    public static SqlConnection GetConnection()
    {
        SqlConnection? conn = new SqlConnection(ConnnectionString);
        try
        {
            conn.Open();
            return conn;
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error connectoin! ", ex.Message);
            return null;
        }
    }
}
