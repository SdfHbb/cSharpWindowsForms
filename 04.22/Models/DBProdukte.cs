using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace cSharpWindowsForms._04._22.Models
{
  public class DBProdukte
  {
    public static string connectionString =
      "datasource=127.0.01;" +
      "port=3306;" +
      "username=root;" +
      "password=;" +
      "database=onlineshop;";


    public static MySqlConnection connection = null;
    public static MySqlCommand command = null;
    public static DataSet dataset;
    public static MySqlDataAdapter adapter;

    public static void Connect()
    {
      try
      {
        connection = new MySqlConnection(connectionString);
        connection.Open();
        // MessageBox.Show("Verbindung hergestellt!");
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
        throw;
      }
    }

    public static void Read(DataGridView dataGridView)
    {
      try
      {
        Connect();
        string sql = "SELECT * FROM produkte;";
        command = new MySqlCommand(sql, connection);
        adapter = new MySqlDataAdapter(command);
        dataset = new DataSet();
        adapter.Fill(dataset);

        dataGridView.DataSource = dataset.Tables[0];
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
      }
      finally
      {
        connection.Close();
      }
    }

    public static void Delete(string id)
    {
      Connect();
      string sql = "DELETE FROM produkte WHERE ID = " + id + ";";
      command = new MySqlCommand(sql, connection);
      int rowsAffected = command.ExecuteNonQuery();

      if (rowsAffected > 0)
      {
        MessageBox.Show($"ID: {id} gelöscht!");
      }
      else
      {
        MessageBox.Show("Fehler");
      }
    }

    public static void Update(Produkt produkt)
    {
      Connect();

      string sql = "UPDATE `produkte` " +
                   "SET artikelnummer=@artikelnummer,name=@name,preis=@preis,beschreibung=@beschreibung,anzahl=@anzahl " +
                   "WHERE id=@id;";

      // Befehlausführung
      MySqlCommand command = new MySqlCommand(sql, connection);

      command.Parameters.AddWithValue("id", produkt.Id);
      command.Parameters.AddWithValue("Artikelnummer", produkt.Artikelnummer);
      command.Parameters.AddWithValue("name", produkt.Name);
      command.Parameters.AddWithValue("preis", produkt.Preis);
      command.Parameters.AddWithValue("beschreibung", produkt.Beschreibung);
      command.Parameters.AddWithValue("anzahl", produkt.Anzahl);

      int rowsAffected = command.ExecuteNonQuery();

      if (rowsAffected > 0)
      {
        MessageBox.Show("Erfolg!");
      }
      else
      {
        MessageBox.Show("Fehler!");
      }
    }

    public static void Insert(Produkt produkt)
    {
      Connect();

      string sql = "INSERT INTO produkte(artikelnummer, name, preis, beschreibung, anzahl) " +
                   "VALUES (@artikelnummer, @name, @preis, @beschreibung, @anzahl);";

      // Befehlausführung
      MySqlCommand command = new MySqlCommand(sql, connection);

      command.Parameters.AddWithValue("Artikelnummer", produkt.Artikelnummer);
      command.Parameters.AddWithValue("name", produkt.Name);
      command.Parameters.AddWithValue("preis", produkt.Preis);
      command.Parameters.AddWithValue("beschreibung", produkt.Beschreibung);
      command.Parameters.AddWithValue("anzahl", produkt.Anzahl);

      int rowsAffected = command.ExecuteNonQuery();

      if (rowsAffected > 0)
      {
        MessageBox.Show("Erfolg!");
      }
      else
      {
        MessageBox.Show("Fehler!");
      }
    }
  }
}