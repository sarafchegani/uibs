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

namespace WindowsFormsApplication5
{
   
    public partial class Form1 : Form
    {
        public int fna = 0;
        public int fn = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create a new telnet connection to hostname "gobelijn" on port "23"
            TelnetConnection tc = new TelnetConnection("10.49.38.158", 23);
            // FileInfo out_file = new FileInfo(@"C:\nokia_out\new.txt");
            //login with user "root",password "rootpassword", using a timeout of 100ms, 
            //and show server output
            string s = tc.Login("TAHERE", "TAHERE123", 10);
            // Console.Write(s);

            // server output should end with "{1}quot; or ">", otherwise the connection failed
            string prompt = s.TrimEnd();
            //  prompt = s.Substring(prompt.Length - 1, 1);
            // if (prompt != ":")
            //     throw new Exception("Connection failed");

            // prompt = "";

            // while connected
            // execute MML command
            string sdate = DateTime.Now.TimeOfDay.ToString().Substring(0, 8).Replace(":", "-");
            tc.WriteLine("EOH:," + sdate + ";");
            fna = fna + 1;
            if (fna == 10)
                fna = 1;
            // write to text file
            FileStream fs = new FileStream(@"C:\nokia_out\ZEOH000" + fna.ToString() + ".txt", FileMode.Create, FileAccess.Write, FileShare.None);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(tc.Read());
            sw.Close();
            //Console.WriteLine("***COMMITED");
           textBox1.Text = DateTime.Now.ToString().Substring(0, 10);
           textBox2.Text = DateTime.Now.TimeOfDay.ToString().Substring(0, 8).Replace(":","-"); 

            //     while (tc.IsConnected && prompt.Trim() != "exit")
            //     {
            //         // display server output
            //        Console.Write(tc.Read());

            //         // send client input to server
            //        prompt = Console.ReadLine();
            //        tc.WriteLine(prompt);

            //        // display server output
            //         Console.Write(tc.Read());
            //     }

            //    Console.WriteLine("***DISCONNECTED");
            // Console.ReadLine();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //create a new telnet connection to hostname "gobelijn" on port "23"
            TelnetConnection tc1 = new TelnetConnection("10.49.38.158", 23);
            // FileInfo out_file = new FileInfo(@"C:\nokia_out\new.txt");
            //login with user "root",password "rootpassword", using a timeout of 100ms, 
            //and show server output
            string s = tc1.Login("TAHERE", "TAHERE123", 10);
            // Console.Write(s);

            // server output should end with "{1}quot; or ">", otherwise the connection failed
            string prompt = s.TrimEnd();
            //  prompt = s.Substring(prompt.Length - 1, 1);
            // if (prompt != ":")
            //     throw new Exception("Connection failed");

            // prompt = "";

            // while connected
            // execute MML command

            tc1.WriteLine("ZEEI;");
            fn = fn + 1;
            if (fn == 10)
                fn = 1;
            // write to text file
            FileStream fs1 = new FileStream(@"C:\nokia_out\ZEEI000"+fn.ToString()+".txt", FileMode.Create, FileAccess.Write, FileShare.None);
            StreamWriter sw1 = new StreamWriter(fs1);
            sw1.Write(tc1.Read());
            sw1.Close();
            //Console.WriteLine("***COMMITED");
            textBox1.Text = DateTime.Now.ToString().Substring(0, 10);
            textBox2.Text = DateTime.Now.TimeOfDay.ToString().Substring(0, 8);
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //create a new telnet connection to hostname "gobelijn" on port "23"
            TelnetConnection tc = new TelnetConnection("10.49.38.158", 23);
            // FileInfo out_file = new FileInfo(@"C:\nokia_out\new.txt");
            //login with user "root",password "rootpassword", using a timeout of 100ms, 
            //and show server output
            string s = tc.Login("TAHERE", "TAHERE123", 10);
            // Console.Write(s);

            // server output should end with "{1}quot; or ">", otherwise the connection failed
            string prompt = s.TrimEnd();
            //  prompt = s.Substring(prompt.Length - 1, 1);
            // if (prompt != ":")
            //     throw new Exception("Connection failed");

            // prompt = "";

            // while connected
            // execute MML command
            string sdate = DateTime.Now.TimeOfDay.ToString().Substring(0, 8).Replace(":", "-");
            tc.WriteLine("EOH:," + sdate + ";");
            fna = fna + 1;
            if (fna == 10)
                fna = 1;
            // write to text file
            FileStream fs = new FileStream(@"C:\nokia_out\ZEOH000" + fna.ToString() + ".txt", FileMode.Create, FileAccess.Write, FileShare.None);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(tc.Read());
            sw.Close();
            //Console.WriteLine("***COMMITED");
            textBox1.Text = DateTime.Now.ToString().Substring(0, 10);
            textBox2.Text = DateTime.Now.TimeOfDay.ToString().Substring(0, 8).Replace(":", "-");

            //     while (tc.IsConnected && prompt.Trim() != "exit")
            //     {
            //         // display server output
            //        Console.Write(tc.Read());

            //         // send client input to server
            //        prompt = Console.ReadLine();
            //        tc.WriteLine(prompt);

            //        // display server output
            //         Console.Write(tc.Read());
            //     }

            //    Console.WriteLine("***DISCONNECTED");
            // Console.ReadLine()
        }
    }
}
