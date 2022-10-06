using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shift_Calculator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class Day
        {
            public TimeStamp ShiftA1 = new TimeStamp(), ShiftA2 = new TimeStamp(), ShiftB1 = new TimeStamp(), ShiftB2 = new TimeStamp();
            public bool WorkedA = false, WorkedB = false;
            public int DurA, DurB;
        }

        public class TimeStamp
        {
            public int Hr, Mt, Secs;
            public string Input;
            public bool Convert()
            {
                string[] temp;
                temp = this.Input.Split(':');
                try
                {
                    this.Hr = Int32.Parse(temp[0]);
                    this.Mt = Int32.Parse(temp[1]);
                    this.Hr *= 3600;
                    this.Mt *= 60;
                    this.Secs = this.Mt + this.Hr;
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            public int hrsecs()
            {
                return Hr * 3600;
            }
            public int mtsecs()
            {
                return Mt * 60;
            }
        }

        public string TimeConvert(int secs)
        {
            string sthr, stmt, time;
            int hr, mt;

            mt = secs % 3600;
            hr = secs - mt;
            hr /= 3600;
            mt /= 60;

            sthr = hr.ToString();
            stmt = mt.ToString();

            if (sthr.Length == 1)
            {
                sthr = "0" + sthr;
            }
            if (stmt.Length == 1)
            {
                stmt = "0" + stmt;
            }

            time = sthr + ":" + stmt;
            return time;
        }

        private void GetTime()
        {
            Dictionary<string, Day> Days = new Dictionary<string, Day>();
            int Sum = 0;


            Days.Add("Mon", new Day());
            Days.Add("Tue", new Day());
            Days.Add("Wed", new Day());
            Days.Add("Thu", new Day());
            Days.Add("Fri", new Day());

            Days["Mon"].WorkedA = MonA.Checked;
            Days["Mon"].WorkedB = MonB.Checked;
            Days["Tue"].WorkedA = TueA.Checked;
            Days["Tue"].WorkedB = TueB.Checked;
            Days["Wed"].WorkedA = WedA.Checked;
            Days["Wed"].WorkedB = WedB.Checked;
            Days["Thu"].WorkedA = ThuA.Checked;
            Days["Thu"].WorkedB = ThuB.Checked;
            Days["Fri"].WorkedA = FriA.Checked;
            Days["Fri"].WorkedB = FriB.Checked;

            if (Days["Mon"].WorkedA)
            {
                if (MonA1.SelectedItem == null || MonA2.SelectedItem == null)
                {
                    Result.Text = "Mon Shift A: Check Inputs";
                    return;
                }
                else
                {
                    Days["Mon"].ShiftA1.Input = MonA1.SelectedItem.ToString();
                    Days["Mon"].ShiftA2.Input = MonA2.SelectedItem.ToString();
                }
            }
            if (Days["Tue"].WorkedA)
            {
                if (TueA1.SelectedItem == null || TueA2.SelectedItem == null)
                {
                    Result.Text = "Tue Shift A: Check Inputs";
                    return;
                }
                else
                {
                    Days["Tue"].ShiftA1.Input = TueA1.SelectedItem.ToString();
                    Days["Tue"].ShiftA2.Input = TueA2.SelectedItem.ToString();
                }
            }
            if (Days["Wed"].WorkedA)
            {
                if (WedA1.SelectedItem == null || WedA2.SelectedItem == null)
                {
                    Result.Text = "Wed Shift A: Check Inputs";
                    return;
                }
                else
                {
                    Days["Wed"].ShiftA1.Input = WedA1.SelectedItem.ToString();
                    Days["Wed"].ShiftA2.Input = WedA2.SelectedItem.ToString();
                }
            }
            if (Days["Thu"].WorkedA)
            {
                if (ThuA1.SelectedItem == null || ThuA2.SelectedItem == null)
                {
                    Result.Text = "Thu Shift A: Check Inputs";
                    return;
                }
                else
                {
                    Days["Thu"].ShiftA1.Input = ThuA1.SelectedItem.ToString();
                    Days["Thu"].ShiftA2.Input = ThuA2.SelectedItem.ToString();
                }
            }
            if (Days["Fri"].WorkedA)
            {
                if (FriA1.SelectedItem == null || FriA2.SelectedItem == null)
                {
                    Result.Text = "Fri Shift A: Check Inputs";
                    return;
                }
                else
                {
                    Days["Fri"].ShiftA1.Input = FriA1.SelectedItem.ToString();
                    Days["Fri"].ShiftA2.Input = FriA2.SelectedItem.ToString();
                }
            }
            if (Days["Mon"].WorkedB)
            {
                if (MonA1.SelectedItem == null || MonA2.SelectedItem == null)
                {
                    Result.Text = "Mon Shift B: Check Inputs";
                    return;
                }
                else
                {
                    Days["Mon"].ShiftA1.Input = MonA1.SelectedItem.ToString();
                    Days["Mon"].ShiftA2.Input = MonA2.SelectedItem.ToString();
                }
            }
            if (Days["Tue"].WorkedB)
            {
                if (TueA1.SelectedItem == null || TueA2.SelectedItem == null)
                {
                    Result.Text = "Tue Shift B: Check Inputs";
                    return;
                }
                else
                {
                    Days["Tue"].ShiftA1.Input = TueA1.SelectedItem.ToString();
                    Days["Tue"].ShiftA2.Input = TueA2.SelectedItem.ToString();
                }
            }
            if (Days["Wed"].WorkedB)
            {
                if (WedA1.SelectedItem == null || WedA2.SelectedItem == null)
                {
                    Result.Text = "Wed Shift B: Check Inputs";
                    return;
                }
                else
                {
                    Days["Wed"].ShiftA1.Input = WedA1.SelectedItem.ToString();
                    Days["Wed"].ShiftA2.Input = WedA2.SelectedItem.ToString();
                }
            }
            if (Days["Thu"].WorkedB)
            {
                if (ThuA1.SelectedItem == null || ThuA2.SelectedItem == null)
                {
                    Result.Text = "Thu Shift B: Check Inputs";
                    return;
                }
                else
                {
                    Days["Thu"].ShiftA1.Input = ThuA1.SelectedItem.ToString();
                    Days["Thu"].ShiftA2.Input = ThuA2.SelectedItem.ToString();
                }
            }
            if (Days["Fri"].WorkedB)
            {
                if (FriA1.SelectedItem == null || FriA2.SelectedItem == null)
                {
                    Result.Text = "Fri Shift B: Check Inputs";
                    return;
                }
                else
                {
                    Days["Fri"].ShiftA1.Input = FriA1.SelectedItem.ToString();
                    Days["Fri"].ShiftA2.Input = FriA2.SelectedItem.ToString();
                }
            }



            foreach (KeyValuePair<string, Day> entry in Days)
            {
                if (Days[entry.Key].WorkedA)
                {
                    if (!(Days[entry.Key].ShiftA1.Convert()) || !(Days[entry.Key].ShiftA2.Convert()))
                    {
                        Result.Text = entry.Key + " Shift A: Unexpected Error";
                        return;
                    } else
                    {
                        Days[entry.Key].ShiftA1.Convert();
                        Days[entry.Key].ShiftA2.Convert();
                        Days[entry.Key].DurA = Days[entry.Key].ShiftA2.Secs - Days[entry.Key].ShiftA1.Secs;
                    }
                }
                if (Days[entry.Key].WorkedB)
                {
                    if (!(Days[entry.Key].ShiftB1.Convert()) || !(Days[entry.Key].ShiftB2.Convert()))
                    {
                        Result.Text = entry.Key + " Shift B: Unexpected Error";
                        return;
                    }
                    else
                    {
                        Days[entry.Key].ShiftB1.Convert();
                        Days[entry.Key].ShiftB2.Convert();
                        Days[entry.Key].DurB = Days[entry.Key].ShiftB2.Secs - Days[entry.Key].ShiftB1.Secs;
                    }
                }
            }
            foreach (KeyValuePair<string, Day> entry in Days)
            {
                if (Days[entry.Key].WorkedA) 
                {
                    if (Days[entry.Key].DurA >= 0)
                    {
                        Sum += Days[entry.Key].DurA;
                    } else
                    {
                        Result.Text = entry.Key + " Shift A: Please make sure clock in is before clock out.";
                        return;
                    }
                }
                if (Days[entry.Key].WorkedB)
                {
                    if (Days[entry.Key].DurB >= 0)
                    {
                        Sum += Days[entry.Key].DurB;
                    }
                    else
                    {
                        Result.Text = entry.Key + " Shift B: Please make sure clock in is before clock out.";
                        return;
                    }
                }
            }

            if (Lab.Checked)
            {
                if (!(LabType.SelectedItem.ToString() == null))
                {
                    if (LabType.SelectedItem.ToString() == "Weekday")
                    {
                        Sum += (3600 * 3);
                    }
                    else
                    {
                        Sum += (3600 * 4);
                    }
                } else
                {
                    Result.Text = "Please select a lab type";
                    return;
                }
            }


            Result.Text = "You shift would be " + TimeConvert(Sum) + " hours";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            GetTime();
        }
    }
}
