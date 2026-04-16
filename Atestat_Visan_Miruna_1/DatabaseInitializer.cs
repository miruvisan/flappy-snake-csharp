using System;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Atestat_Visan_Miruna_1
{
    public static class DatabaseInitializer
    {
        public static string GetConnectionString()
        {
            string dbPath = Path.Combine(Application.StartupPath, "bdatestat.mdb");
            return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath;
        }

        public static void InitializeDatabase()
        {
            try
            {
                string dbPath = Path.Combine(Application.StartupPath, "bdatestat.mdb");

                // Verifica daca fisierul bazei de date exista
                if (!File.Exists(dbPath))
                {
                    // Incearca sa copieze din directorul original (daca exista)
                    string originalDbPath = "bdatestat.mdb";
                    if (File.Exists(originalDbPath))
                    {
                        File.Copy(originalDbPath, dbPath);
                    }
                    else
                    {
                        // Daca nici copia originala nu exista, afiseaza un mesaj
                        MessageBox.Show("Baza de date bdatestat.mdb nu a fost gasita. Va rugam asigurati-va ca fisierul exista.", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Verifica daca tabela utilizatori exista
                if (!TableExists("utilizatori"))
                {
                    CreateTabelaUtilizatori();
                }
                
                // Adauga coloane noi daca lipsesc
                AddMissingColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la initializarea bazei de date: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool TableExists(string tableName)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(GetConnectionString()))
                {
                    con.Open();
                    var schema = con.GetSchema("Tables");
                    foreach (System.Data.DataRow row in schema.Rows)
                    {
                        if (row[2].ToString() == tableName)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Daca nu putem verifica, incercam sa cream tabela oricum
                return false;
            }
        }

        private static void CreateTabelaUtilizatori()
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(GetConnectionString()))
                {
                    con.Open();
                    string createTableQuery = @"
                        CREATE TABLE utilizatori (
                            ID AUTOINCREMENT PRIMARY KEY,
                            username TEXT(50) UNIQUE NOT NULL,
                            Nume TEXT(100) NOT NULL,
                            Prenume TEXT(100) NOT NULL,
                            Parola TEXT(255) NOT NULL,
                            DataCrearii DATETIME DEFAULT NOW(),
                            FlappyScore INT DEFAULT 0,
                            SnakeScore INT DEFAULT 0,
                            GamesPlayedFlappy INT DEFAULT 0,
                            GamesPlayedSnake INT DEFAULT 0,
                            TotalPoints INT DEFAULT 0,
                            LastDifficultySnake TEXT DEFAULT 'Medium'
                        )";

                    using (OleDbCommand cmd = new OleDbCommand(createTableQuery, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Tabela probabil deja exista, ignora eroarea
                System.Diagnostics.Debug.WriteLine("Tabel creation info: " + ex.Message);
            }
        }

        private static void AddMissingColumns()
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(GetConnectionString()))
                {
                    con.Open();
                    
                    // Verifica coloanele și le adauga dacă lipsesc
                    string[] newColumns = { "GamesPlayedFlappy", "GamesPlayedSnake", "TotalPoints", "LastDifficultySnake" };
                    var schema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, null, "utilizatori", null });
                    
                    foreach (string columnName in newColumns)
                    {
                        bool columnExists = false;
                        foreach (System.Data.DataRow row in schema.Rows)
                        {
                            if (row["COLUMN_NAME"].ToString() == columnName)
                            {
                                columnExists = true;
                                break;
                            }
                        }

                        if (!columnExists)
                        {
                            string dataType = columnName == "LastDifficultySnake" ? "TEXT" : "INT";
                            string defaultValue = columnName == "LastDifficultySnake" ? "'Medium'" : "0";
                            string alterQuery = $"ALTER TABLE utilizatori ADD COLUMN {columnName} {dataType} DEFAULT {defaultValue}";
                            
                            using (OleDbCommand cmd = new OleDbCommand(alterQuery, con))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Column check info: " + ex.Message);
            }
        }

        public static int GetBestFlappyScore(string username)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(GetConnectionString()))
                {
                    con.Open();
                    string query = "SELECT FlappyScore FROM utilizatori WHERE username = @username";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Eroare la citire FlappyScore: " + ex.Message);
                return 0;
            }
        }

        public static int GetBestSnakeScore(string username)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(GetConnectionString()))
                {
                    con.Open();
                    string query = "SELECT SnakeScore FROM utilizatori WHERE username = @username";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Eroare la citire SnakeScore: " + ex.Message);
                return 0;
            }
        }

        public static void UpdateBestFlappyScore(string username, int score)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(GetConnectionString()))
                {
                    con.Open();
                    // Update doar daca scorul nou este mai mare decat cel existent
                    string query = "UPDATE utilizatori SET FlappyScore = @score WHERE username = @username AND (@score > ISNULL(FlappyScore, 0) OR FlappyScore IS NULL)";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@score", score);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Eroare la update FlappyScore: " + ex.Message);
            }
        }

        public static void UpdateBestSnakeScore(string username, int score)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(GetConnectionString()))
                {
                    con.Open();
                    // Update doar daca scorul nou este mai mare decat cel existent
                    string query = "UPDATE utilizatori SET SnakeScore = @score WHERE username = @username AND (@score > ISNULL(SnakeScore, 0) OR SnakeScore IS NULL)";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@score", score);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Eroare la update SnakeScore: " + ex.Message);
            }
        }

        public static void IncrementGamesPlayedFlappy(string username)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(GetConnectionString()))
                {
                    con.Open();
                    string query = "UPDATE utilizatori SET GamesPlayedFlappy = GamesPlayedFlappy + 1 WHERE username = @username";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Eroare la increment GamesPlayedFlappy: " + ex.Message);
            }
        }

        public static void IncrementGamesPlayedSnake(string username)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(GetConnectionString()))
                {
                    con.Open();
                    string query = "UPDATE utilizatori SET GamesPlayedSnake = GamesPlayedSnake + 1 WHERE username = @username";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Eroare la increment GamesPlayedSnake: " + ex.Message);
            }
        }

        public static void UpdateTotalPoints(string username, int pointsToAdd)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(GetConnectionString()))
                {
                    con.Open();
                    string query = "UPDATE utilizatori SET TotalPoints = TotalPoints + @points WHERE username = @username";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@points", pointsToAdd);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Eroare la update TotalPoints: " + ex.Message);
            }
        }

        public static void UpdateDifficultySnake(string username, string difficulty)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(GetConnectionString()))
                {
                    con.Open();
                    string query = "UPDATE utilizatori SET LastDifficultySnake = @difficulty WHERE username = @username";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@difficulty", difficulty);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Eroare la update Difficulty: " + ex.Message);
            }
        }

        public class UserStats
        {
            public int GamesPlayedFlappy { get; set; }
            public int GamesPlayedSnake { get; set; }
            public int TotalPoints { get; set; }
            public int BestFlappyScore { get; set; }
            public int BestSnakeScore { get; set; }
            public string LastDifficultySnake { get; set; }
        }

        public static UserStats GetUserStats(string username)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(GetConnectionString()))
                {
                    con.Open();
                    string query = "SELECT GamesPlayedFlappy, GamesPlayedSnake, TotalPoints, FlappyScore, SnakeScore, LastDifficultySnake FROM utilizatori WHERE username = @username";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        using (OleDbDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                return new UserStats
                                {
                                    GamesPlayedFlappy = Convert.ToInt32(dr["GamesPlayedFlappy"] ?? 0),
                                    GamesPlayedSnake = Convert.ToInt32(dr["GamesPlayedSnake"] ?? 0),
                                    TotalPoints = Convert.ToInt32(dr["TotalPoints"] ?? 0),
                                    BestFlappyScore = Convert.ToInt32(dr["FlappyScore"] ?? 0),
                                    BestSnakeScore = Convert.ToInt32(dr["SnakeScore"] ?? 0),
                                    LastDifficultySnake = dr["LastDifficultySnake"]?.ToString() ?? "Medium"
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Eroare la citire UserStats: " + ex.Message);
            }
            return new UserStats();
        }

        public static DataTable GetLeaderboard(int topCount = 10)
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(GetConnectionString()))
                {
                    con.Open();
                    string query = $"SELECT TOP {topCount} username, BestFlappyScore, BestSnakeScore, TotalPoints, GamesPlayedFlappy, GamesPlayedSnake FROM utilizatori ORDER BY TotalPoints DESC";
                    using (OleDbDataAdapter da = new OleDbDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Eroare la citire Leaderboard: " + ex.Message);
                return new DataTable();
            }
        }
    }
}
