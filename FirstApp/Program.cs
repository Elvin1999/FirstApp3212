using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public static class Program
    {

        //static DialogResult GetDialogResult()
        //{
        //    DialogResult result;
        //    string message = "Window displaying a text message";
        //    string caption = "C# Language";
        //    //result = MessageBox.Show(message);

        //    //result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel);


        //    result=MessageBox.Show(message, caption, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

        //    return result;
        //}

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



            //var result = GetDialogResult();

            //if (result == DialogResult.OK)
            //{
            //    MessageBox.Show("You clicked to OK");
            //}
            //else if(result == DialogResult.Cancel)
            //{
            //    MessageBox.Show("Canceled");
            //}

            //if(result == DialogResult.Abort)
            //{
            //    MessageBox.Show("You aborted");
            //}
            //else if(result == DialogResult.Ignore)
            //{
            //    MessageBox.Show("Ignored");
            //}
            //else if (result == DialogResult.Retry)
            //{
            //    MessageBox.Show("Retry");
            //}



            //  Application.Run(new Form1());

        }
    }
}
