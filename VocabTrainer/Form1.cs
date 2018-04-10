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

namespace VocabTrainer
{
    public partial class Form1 : Form
    {
        //Deklaration
        StreamReader rdr;
        Random rand;
        List<string> VocEng = new List<string>();
        List<string> VocGer = new List<string>();
        OpenFileDialog ofd = new OpenFileDialog();                  
        int countRIGHT = 0;
        int countWRONG = 0;
        int countTRY = 0;
        string pfad = "";
        string LWortGer;
        string LWortEng;
        int zufall;
        bool mode;
        int aktuellCountTry;
        int aktutellRight;
        int aktutellWrong;


        public Form1()
        {
            //Einstellen & Ausstellen der Elemente beim starten des Programms
            InitializeComponent();
            MessageBox.Show("Wir bitten sie die Vokabeln ihrer Textdatei in folgendem Format zu schreiben: ENGLISCH:DEUTSCH");
            lbl_Right.Hide();
            lbl_Try.Hide();
            lbl_Wrong.Hide();
            lb_ger.Enabled = true;
            lb_eng.Enabled = true;
            tb_Eng1.Enabled = true;
            tb_Ger1.Enabled = true;
            lb_amountWords.Enabled = true;
            tb_Check.Enabled = true;                              
            tb_amountWords.Enabled = true;
            lb_learn.Enabled = true;
            btn_startFromFile.Enabled = true;
            btn_cancel_top.Enabled = true;
            lb_add.Enabled = false;
            lb_ger2.Enabled = false;
            lb_eng2.Enabled = false;
            tb_Eng2.Enabled = false;
            tb_Ger2.Enabled = false;
            btn_save.Enabled = false;
            btn_saveInFile.Enabled = false;
            btn_switch.Text = "Lernen";
            circularProgressBar1.Hide();
            circularProgressBar1.ProgressColor1 = Color.FromArgb(255, 0, 204, 204);
            circularProgressBar1.ProgressColor2 = Color.FromArgb(255, 0, 204, 204);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Abbrechen Knopf, setzt alles wieder zurück
            tb_amountWords.Text = "";
            tb_Ger1.Text = "";
            tb_Eng1.Text = "";                   
            tb_Check.Text = "";
            aktuellCountTry = 0;
            aktutellRight = 0;
            aktutellWrong = 0;
        }
        private void saveFile_Click(object sender, EventArgs e)
        {
            //Speichern knopf
            StreamWriter save = File.AppendText(pfad);
            save.WriteLine(tb_Eng2.Text + ":" + tb_Ger2.Text);              
            save.Close();
        }

        bool bswitch = true;
        private void btn_switch_Click(object sender, EventArgs e)
        {
            if (bswitch == false)
            {
                //Boolean, die false und true umkehrt
                lb_ger.Enabled = true;
                lb_eng.Enabled = true;
                tb_Eng1.Enabled = true;
                tb_Ger1.Enabled = true;
                lb_amountWords.Enabled = true;
                tb_Check.Enabled = true;
                tb_amountWords.Enabled = true;
                lb_learn.Enabled = true;                     
                lb_check.Enabled = true;
                btn_cancel_top.Enabled = true;
                btn_startFromFile.Enabled = true;
                lb_add.Enabled = false;
                lb_ger2.Enabled = false;
                lb_eng2.Enabled = false;
                tb_Eng2.Enabled = false;
                tb_Ger2.Enabled = false;
                btn_save.Enabled = false;
                btn_saveInFile.Enabled = false;
                btn_switch.Text = "Lernen";
                bswitch = true;
            }
            else if (bswitch == true)
            {
                lb_ger.Enabled = false;
                lb_eng.Enabled = false;
                tb_Eng1.Enabled = false;
                tb_Ger1.Enabled = false;
                lb_amountWords.Enabled = false;
                tb_Check.Enabled = false;
                tb_amountWords.Enabled = false;
                lb_learn.Enabled = false;
                lb_check.Enabled = false;
                btn_cancel_top.Enabled = false;
                btn_startFromFile.Enabled = false;
                lb_add.Enabled = true;
                lb_ger2.Enabled = true;
                lb_eng2.Enabled = true;
                tb_Eng2.Enabled = true;
                tb_Ger2.Enabled = true;
                btn_save.Enabled = true;
                btn_saveInFile.Enabled = true;
                btn_switch.Text = "Erfassen";
                bswitch = false;
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            //Speichern in die Liste
            VocEng.Add(tb_Eng2.Text);
            VocGer.Add(tb_Ger2.Text);
        }
        private void btn_startFromFile_Click_1(object sender, EventArgs e)
        {
            tb_Eng1.Enabled = true;
            try
            {
                //Datei Öffnen
                ofd.Filter = "Textdokument|*.txt";
                ofd.Title = "Öffne Vokabeldatei";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pfad = ofd.FileName;
                    StreamReader sr = new StreamReader(pfad);
                    string vocabs = sr.ReadToEnd();
                    sr.Close();
                    MessageBox.Show(vocabs);
                }
            }
            catch
            {
                MessageBox.Show("Bitte gib eine valide .txt Datei an! ");
            }


            //Wörter auslesen, splitten und in die Listen eintragen
            rdr = new StreamReader(pfad);

            while (!rdr.EndOfStream)
            {
                try
                {
                    string[] wörter = rdr.ReadLine().Split(':');
                    VocEng.Add(wörter[0]);
                    VocGer.Add(wörter[1]);
                }
                catch (System.IndexOutOfRangeException)
                {

                    
                }

            }
            rdr.Close();
            startTEST();
        }
        void startTEST()
        {
            //Methode, zur zufälligen Abfrage der Vokabeln
            rand = new Random();
            zufall = rand.Next(0, VocEng.Count);
            LWortEng = VocEng[zufall];
            LWortGer = VocGer[zufall];

            tb_Ger1.Text = LWortGer;
        }
        //Benutzt Enter statt extraknopf & kontrolle ob die Angabe richtig ist.
        private void tb_Eng1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (LWortEng == tb_Eng1.Text)
                {
                    countRIGHT++;
                    aktuellCountTry++;
                    tb_Eng1.Text = "";
                    startTEST();
                    tb_Check.Text = "Richtig!";
                    countTRY++;
                    aktutellRight++;
                }
                else
                {
                    aktuellCountTry++;
                    tb_Eng1.Text = "";
                    tb_Check.Text = "Falsch!";
                    startTEST();
                    countWRONG++;
                    countTRY++;
                }
                if (aktuellCountTry == int.Parse(tb_amountWords.Text))
                {
                    tb_Check.Text = "Sie haben " + aktutellRight + " von " + aktuellCountTry + " richtig beantwortet!";
                    tb_Eng1.Text = "";
                    tb_Eng1.Enabled = false;
                    aktuellCountTry = 0;
                    aktutellRight = 0;
                    aktutellWrong = 0;
                }
            }
        }
        private void btn_stats_Click(object sender, EventArgs e)
        {
            //Anzeige der Statistik
            if (mode == true)
            {
                lb_ger.Show();
                lb_eng.Show();
                tb_Eng1.Show();
                tb_Ger1.Show();
                lb_amountWords.Show();
                tb_Check.Show();
                tb_amountWords.Show();
                lb_learn.Show();
                lb_check.Show();
                btn_cancel_top.Show();
                btn_startFromFile.Show();
                lbl_bewertung.Hide();
                lbl_bewertung.BorderStyle = BorderStyle.None;
                lb_add.Show();
                lb_ger2.Show();
                lb_eng2.Show();
                lbl_Wrong.Hide();
                lbl_Right.Hide();
                lbl_Try.Hide();
                tb_Eng2.Show();
                tb_Ger2.Show();
                btn_save.Show();
                btn_saveInFile.Show();
                btn_switch.Show();
                circularProgressBar1.Hide();
                mode = false;
                btn_stats.Text = "Statisik";
            }
            else
            {
                if (countTRY >= 1)
                {
                    //Algorithmus zur ausgabe der Statistik
                    lbl_bewertung.BorderStyle = BorderStyle.FixedSingle;
                    if (countTRY * 0.25 > countRIGHT)
                    {
                        lbl_bewertung.Text = "Anhand von deinen Statistiken ist Klar, dass du fast keine deiner Vokabeln kannst!";
                    }
                    else if (countTRY * 0.5 > countRIGHT && countRIGHT > countTRY * 0.25 || countRIGHT == countTRY * 0.25)
                    {
                        lbl_bewertung.Text = "Ein paar Vokabeln kannst du, allerdings hast du noch viel zu tun bis du sie komplett beherrschst! ";
                    }
                    else if (countTRY * 0.75 > countRIGHT && countRIGHT > countTRY * 0.5 || countRIGHT == countTRY*0.5)
                    {
                        lbl_bewertung.Text = "Du kannst einige deiner Vokabeln. Noch ein wenig üben und du kannst sie alle";
                    }
                    else if (countTRY > countRIGHT && countRIGHT > countTRY * 0.75 || countRIGHT == countTRY*0.75)
                    {
                        lbl_bewertung.Text = "Setz dich noch paar Minuten ran und du kannst alles";
                    }
                    else if (countTRY == countRIGHT)
                    {
                        lbl_bewertung.Text = "Du hast alles richtig beantwortet, Glückwunsch!";
                    }
                }
                //Anzeige der Statistik
                mode = true;
                lb_ger.Hide();
                lb_eng.Hide();
                tb_Eng1.Hide();
                tb_Ger1.Hide();
                lb_amountWords.Hide();
                tb_Check.Hide();
                tb_amountWords.Hide();
                lb_learn.Hide();
                lb_check.Hide();
                btn_cancel_top.Hide();
                btn_startFromFile.Hide();
                lb_add.Hide();
                lb_ger2.Hide();
                lb_eng2.Hide();
                tb_Eng2.Hide();
                tb_Ger2.Hide();
                btn_save.Hide();
                btn_saveInFile.Hide();
                lbl_Wrong.Show();
                lbl_Right.Show();
                lbl_Try.Show();
                lbl_Wrong.Text = "Falsch: "+countWRONG;
                lbl_Try.Text = "Versuche: "+countTRY;
                lbl_Right.Text = "Richtig: "+countRIGHT;
                btn_switch.Hide();
                btn_stats.Text = "Übungsmodus";
                circularProgressBar1.Maximum = countTRY;
                circularProgressBar1.Value = countRIGHT;
                circularProgressBar1.Update();
                circularProgressBar1.Show();
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Neustart des Programms
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //schließen
            Application.Exit();
        }

        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hilfe
            MessageBox.Show("So nutzt man das Programm richtig:"+Environment.NewLine+"1.Sie geben an wie viele Wörter sie abgefragt werden sollen (Anzahl Wörter)."+Environment.NewLine+"2. Sie klicken auf den Start aus Datei Knopf und wählen das Textdokument aus in dem sie ihre Vokabeln gespeichert haben."+Environment.NewLine+"3. Der Test kann beginnen, sie geben immer die Passende Englische Vokabel zur Deutschen ein und bestätigen mit der Enter-Taste nachdem die Vokabeln abgefragt wurden bekommen sie eine Auswertung, der Abbruch Knopf bricht den ganzen Test ab."+Environment.NewLine+"4. Wenn sie auf den Knopf Lernen klicken wechseln sie in den Erfassen Modus mit welchem sie im unteren Bereich des Programms Vokabeln hinzufügen können."+Environment.NewLine+"5. Der Speichern Knopf sorgt dafür das die Vokabeln nur für die jetzige Session gespeichert werden und nach Neustart wieder verschwinden."+Environment.NewLine+"6. Der Speichern in Datei Knopf sorgt dafür das die Vokabeln permanent in ihr Dokument geschrieben werden."+Environment.NewLine+"7. Der Statistiken Button wechselt in den Statistiken Modus wo ihr gesamter Fortschritt der jetzigen Session angezeigt das heißt von jedem Test den sie gemacht haben.");
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void dateiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
