using System.Globalization;

namespace Base.Formularios
{
    public partial class FrmDashboard : Form
    {
        private readonly FrmTelaCadastros formTelaCadastros;

        public FrmDashboard(FrmTelaCadastros formTelaCadastros)
        {
            this.formTelaCadastros = formTelaCadastros;
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            CultureInfo pt = new CultureInfo("pt-PT", false);
            string dateFormatString = pt.DateTimeFormat.LongDatePattern;

            string data = DateTime.Now.ToString(dateFormatString, new CultureInfo("pt-PT"));
            lblData.Text = data;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            formTelaCadastros.TopLevel = false;
            pnlPrincipal.Controls.Add(formTelaCadastros);
            formTelaCadastros.Show();
        }
        private void btnRelatorios_Click(object sender, EventArgs e)
        {

        }

        private void btnMovimentacao_Click(object sender, EventArgs e)
        {
            FrmMovimentacao frm = new FrmMovimentacao();
            frm.TopLevel = false;
            pnlPrincipal.Controls.Add(frm);
            frm.Show();
        }
    }
}