namespace SimplePaint
{
    public partial class Form1 : Form
    {
        private bool flagPinter = false;
        private Graphics graphicsPainelPintura;
        private float espessuradaCaneta;

        public Form1()
        {
            InitializeComponent();
            Borracha.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            Limpar.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            Salvar.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;

            for (int i = 2; i <= 80; i += 2)
            {
                EspessuraCaneta.Items.Add(i);
            }
            EspessuraCaneta.Text = "6";
            EspessuraCaneta.MaxDropDownItems = 6;
            EspessuraCaneta.IntegralHeight = false;

            graphicsPainelPintura = panel1.CreateGraphics();
            espessuradaCaneta = float.Parse(EspessuraCaneta.Text);
        }

        private void CorCaneta_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            var corEscolhida = colorDialog.ShowDialog();
            if (corEscolhida == DialogResult.OK)
            {
                CorCaneta.BackColor = colorDialog.Color;
            }
        }

        private void Borracha_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            flagPinter = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            flagPinter = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flagPinter)
            {
                graphicsPainelPintura.DrawEllipse(new Pen(CorCaneta.BackColor, espessuradaCaneta),
                                                  new RectangleF(e.X, e.Y, espessuradaCaneta, espessuradaCaneta));
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja apagar todo o DESENHO?", "Apagar Desenho", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                graphicsPainelPintura.Clear(Color.White);
            }

        }

        private void EspessuraCaneta_SelectedIndexChanged(object sender, EventArgs e)
        {
            espessuradaCaneta = float.Parse(EspessuraCaneta.SelectedItem.ToString());
        }
    }
}
