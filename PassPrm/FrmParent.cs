using System;
using System.Drawing;
using System.Windows.Forms;
using static PassPrm.CommonClass;

namespace PassPrm
{
    public partial class FrmParent : Form
    {
        //  Property static publica ser vista por outro form
        public static string ParmParent { get; set; }

        //  Classe cuja instanciua sera passada por referencia a outro form
        ParmClass ParmForm = new ParmClass();

        public FrmParent() { 
            InitializeComponent();
            //  Inicializando controles que receberão os parametros a enviar e receber
            this.Text = "PASSING PARAMETERS";

            //  Preenche a mensagem ao usuario
            lblTexto.Text = "Este formulario (parent) chama e passa os parametros abaixo ao formulario (child)";
            txtParm1.Text = "Argumento original 1";
            txtParm2.Text = "Argumento original 2";
            txtParm3.Text = "Argumento original 3";
            txtParm4.Text = "Argumento original 4";
        }

        private void BtnCallForm_Click(object sender, EventArgs e)
        {
            //  Modificando a variavel publica (property)
            ParmParent = txtParm1.Text;    

            //  Modificando a variavel publica do from a ser CHAMADO
            FrmChild.ParmChild = txtParm2.Text;

            //  Instancia da classe que será passada ao construtor do child form            
            ParmForm.P1 = txtParm3.Text;
            ParmForm.P2 = txtParm4.Text;

            //  Criando instancia do form child
            using (FrmChild frmChild = new FrmChild( ref ParmForm))
            {
                //  Localizacao do from child para facilidade e visualizacao
                frmChild.StartPosition = FormStartPosition.Manual;
                frmChild.Location = new Point(this.Location.X + this.Size.Width / 2,
                                              this.Location.Y + this.Size.Height / 2); ;
                //  Show order pad
                frmChild.ShowDialog();
                if (frmChild.DialogResult == DialogResult.OK)
                {
                    //  O usuario clicou OK no for CHILD
                    txtParm1.Text = ParmParent;
                    //  ---------------------------------------------------------------
                    //  COMO VC PODE VE, FUNCIONA MAS NAO RECOMENDO.
                    //  TRATA-SE DE UMA VARIAVEL QUE PODE SER ACESSADA POR OUTROS FORMS
                    txtParm2.Text = FrmChild.ParmChild; 
                    //  ---------------------------------------------------------------
                    txtParm3.Text = ParmForm.P1;
                    txtParm4.Text = ParmForm.P2;
                };
                if (frmChild. DialogResult == DialogResult.Cancel)
                {
                    //  O usuario clicou o botao de CANCEL no form CHILD;
                    //  Ignorar as alteracoes
                };
            }
        }
    }
}
