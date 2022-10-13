using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class frm_MouseCursor : Form
    {
        public frm_MouseCursor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var marco = false;

            this.Cursor = Cursors.WaitCursor;

            if(marco)
            {
                return;
            }

            try
            {
                marco = false;

                if(marco)
                {
                    //throw new Exception("Não foi encontrada nenhuma nota com os dados informados.");
                    //return;
                }

                try
                {
                    if(marco)
                    {
                        //throw new Exception("Não foi encontrada nenhuma nota com os dados informados.");
                        return;
                    }

                    for(int i = 0; i < 3; i++)
                    {
                        System.Threading.Thread.Sleep(1000);
                    }

                    throw new Exception();
                }
                catch(Exception)
                {
                    MessageBox.Show("Erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                //throw new Exception();
            }
            catch(Exception)
            {
                
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
