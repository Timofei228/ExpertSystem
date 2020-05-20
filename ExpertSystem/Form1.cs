using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystem
{
    public partial class Form1 : Form
    {
        private OleDbConnection myConn;
        public string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=carsExpertSystem.mdb";
        public int question_counter = 1;
        public OleDbCommand cmd;
        public OleDbDataReader reader;
        public int NFact;
        public int NRz;
        public int Fact_Count = 0;
        public int NPrav = 0;
        public int count_mark = 0;

        public Form1()
        { 
            InitializeComponent();
            connection();
            string count = "SELECT COUNT(IDFact) FROM Facts WHERE type = 0 ";
            cmd = new OleDbCommand(count, myConn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Fact_Count = Convert.ToInt32(reader[0]);
            }
            myConn.Close();
        }
        void consultation()
        {
            lb_Rz.Items.Clear();
            connection();
            string zap = "SELECT DISTINCT Facts.IDFact, Facts.question, Rz.NameRz " +
                "FROM Rz INNER JOIN Facts ON Rz.NumFact = Facts.IDFact " +
                "WHERE Facts.IDFact = @qc";
            cmd = new OleDbCommand(zap, myConn);
            cmd.Parameters.AddWithValue("@qc", question_counter);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbl_Quest.Text = reader.GetValue(1).ToString();
                lb_Rz.Items.Add(reader[2].ToString());
                NFact = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            myConn.Close();
            count_mark = 0;
            NPrav = 0;
        }

        void Clear()
        {
            lb_Rz.Items.Clear();
            lb_Story.Items.Clear();
            lbl_Quest.Text = "Вопрос";
        }
        void connection()
        {
            myConn = new OleDbConnection(connectString);
            myConn.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_Rz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Clear();
            consultation();
            connection();
            string upd = "UPDATE Posilki SET Posilki.Mark = 0 WHERE Posilki.Mark = 1 OR Posilki.Mark = -1";
            cmd = new OleDbCommand(upd, myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            int Nq = 0;
            connection();
            string TxtRz = lb_Rz.SelectedItem.ToString();
            string story_question = lbl_Quest.Text;
            string zap = "SELECT IDRz FROM Rz WHERE NameRz = @name ";
            cmd =  new OleDbCommand(zap, myConn);
            cmd.Parameters.AddWithValue("@name", TxtRz);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                NRz = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            lb_Story.Items.Add(story_question + " - " + TxtRz);
            string upd = "UPDATE Posilki SET Posilki.Mark = 1 WHERE Posilki.NumFact = " + NFact + " AND Posilki.NumRz = " + NRz + ";";
            cmd = new OleDbCommand(upd, myConn);
            cmd.ExecuteNonQuery();
            string upd2 = "UPDATE Posilki SET Posilki.Mark = -1 WHERE Posilki.NumFact = " + NFact + " AND Posilki.Mark = 0;";
            cmd = new OleDbCommand(upd2, myConn);
            cmd.ExecuteNonQuery();
            string prav = "SELECT NumRule, SUM(Mark) FROM Posilki GROUP BY NumRule HAVING SUM(Mark) > 0;";
            cmd = new OleDbCommand(prav, myConn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                NPrav = Convert.ToInt32(reader[0]);
            }
            reader.Close();

            string concl = "SELECT AVG(Mark) FROM Posilki WHERE NumRule = " + NPrav + "";
            cmd = new OleDbCommand(concl, myConn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    count_mark = Convert.ToInt32(reader[0]);
                }
                catch (Exception ex )
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
                finally
                {
                    this.Refresh();
                }

            }
            textBox1.Text = count_mark.ToString();

            if (count_mark == 1)
            {
                string conclusion = "SELECT Facts_1.nameFact, Rz_1.NameRz, Posilki.Mark " +
                    "FROM((((Posilki INNER JOIN Zakl ON Posilki.NumRule = Zakl.IDZakl) " +
                    "INNER JOIN Facts AS Facts_1 ON Zakl.NumFact = Facts_1.IDFact) " +
                    "INNER JOIN Rz AS Rz_1 ON Zakl.NumRz = Rz_1.IDRz) " +
                    "INNER JOIN Facts ON Posilki.NumFact = Facts.IDFact) " +
                    "INNER JOIN Rz ON(Posilki.NumRz = Rz.IDRz) " +
                    "AND(Rz.NumFact = Facts.IDFact) WHERE IDZakl = " + NPrav + "; ";
                cmd = new OleDbCommand(conclusion, myConn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader[0].ToString() + "-" + reader[1].ToString();
                }

                MessageBox.Show("Ответ найден");
                question_counter = 1;
            }
            else
            {

                string qstn = "SELECT NumFact FROM Posilki WHERE Posilki.NumRule = " + NPrav + " AND Mark = 0;";
                cmd = new OleDbCommand(qstn, myConn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Nq = Convert.ToInt32(reader[0]);
                }
                reader.Close();
                question_counter = Nq;
                consultation();
            }
           
        }
    }
}
