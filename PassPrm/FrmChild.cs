using System;
using System.Drawing;
using System.Windows.Forms;
using static PassPrm.CommonClass;

namespace PassPrm
{
    public partial class FrmChild : Form
    {
        //  Property publica static pode ser vista por outro form
        public static string ParmChild { get; set; }

        //  Variaveis locais - Salva valores originais dos parm recebidos
        private ParmClass ParmRecebido;
        private readonly ParmClass SaveParmRecebido;
        private readonly string SaveParmParent;
        private readonly string SaveParmChild; 

        public FrmChild( ref ParmClass ParmArg)
        {
            InitializeComponent();

            //  Salva o parametro recebido em variavel de trabalho, caso contrario ele sera perdido.
            //  Só da pra ler aqui pq é local. Observe que foi passado por referencia ( classes )
            ParmRecebido = ParmArg;

            //  Salva os valores originais dos parametros   
            SaveParmRecebido = new ParmClass( ParmArg.P1, ParmArg.P2);
            SaveParmParent   = FrmParent.ParmParent;
            SaveParmChild    = ParmChild;

            //  Display textos
            this.Text = "FORM AUXILIAR CHILD";
                        
            lblTexto.Text = "Este formulario(child) mostra os parametros recebidos do formulario(parent)";
            //  Preenche com os valores recebidos
            txtParm1.Text = FrmParent.ParmParent;
            txtParm2.Text = ParmChild;
            txtParm3.Text = ParmRecebido.P1;
            txtParm4.Text = ParmRecebido.P2;
        }
        
        private void BtnCallForm_Click(object sender, EventArgs e)
        {
            //  Modifica o valor do parametro no Parent form
            FrmParent.ParmParent = txtParm1.Text;
            ParmChild            = txtParm2.Text;
            ParmRecebido.P1      = txtParm3.Text;
            ParmRecebido.P2      = txtParm4.Text;

            //  Set o flag de resultado. Sera usado no form que chamou
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //  Restaura os valores originais
            ParmRecebido.P1      = SaveParmRecebido.P1;
            ParmRecebido.P2      = SaveParmRecebido.P2;
            FrmParent.ParmParent = SaveParmParent;
            ParmChild            = SaveParmChild;

            //  Set o flag de resultado. Sera usado no form que chamou
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
