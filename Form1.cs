using System.Windows.Forms;

namespace NotepadSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //--------------------------------------------------------------------------   
            
            Application.Exit();

         //-------------------------------------------------------------------------- 
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         //-------------------------------------------------------------------------- 

            MessageBox.Show("Created by Miguel Andrade © 2023");

         //-------------------------------------------------------------------------- 
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //-------------------------------------------------------------------------- 

            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);

            }


         //-------------------------------------------------------------------------- 
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //-------------------------------------------------------------------------- 

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);

            }

        //---------------------------------------------------------------------------
        }
    }
}