namespace calcularimc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CalcularImcButton_Clicked(object sender, EventArgs e)
        {
            double imc;
            double altura = 0;
            double peso = 0;
            double pesoAdequado;

            if (NomeEntry.Text == null || NomeEntry.Text == "" || IdadeEntry.Text == null || IdadeEntry.Text == "" || GeneroPicker.SelectedIndex == -1)
            {
                ImcLabel.Text = ImcLabel.Text = $"IMC:"; ;
                SugestaoPesoLabel.Text = null;

                ClassificacaoPesoLabel.Text = "Insira todas as informações!!!";
                ClassificacaoPesoLabel.TextColor = Microsoft.Maui.Graphics.Colors.Red;
            }
                
            else
            {
                altura = Convert.ToDouble(AlturaLabel.Text);
                peso = Convert.ToDouble(PesoLabel.Text);

                imc = Math.Round(peso / (altura * altura), 1);
                pesoAdequado = Math.Round(21.7 * (altura * altura), 1);

                ImcLabel.Text = $"IMC: {imc.ToString()}";

                if (imc < 18.5)
                {
                    ClassificacaoPesoLabel.Text = "Abaixo do Peso";
                    ClassificacaoPesoLabel.TextColor = Microsoft.Maui.Graphics.Colors.DarkRed;
                    SugestaoPesoLabel.Text = $"Peso Adequado: {pesoAdequado.ToString()}Kg";
                }
                else if (imc < 25)
                {
                    ClassificacaoPesoLabel.Text = "Peso Adequado";
                    ClassificacaoPesoLabel.TextColor = Microsoft.Maui.Graphics.Colors.LightGreen;
                    SugestaoPesoLabel.Text = null;
                }
                else if (imc < 30)
                {
                    ClassificacaoPesoLabel.Text = "SobrePeso";
                    ClassificacaoPesoLabel.TextColor = Microsoft.Maui.Graphics.Colors.DarkGreen;
                    SugestaoPesoLabel.Text = $"Peso Adequado: {pesoAdequado.ToString()}Kg";
                }
                else if (imc < 35)
                {
                    ClassificacaoPesoLabel.Text = "Obesidade Grau 1";
                    ClassificacaoPesoLabel.TextColor = Microsoft.Maui.Graphics.Colors.Orange;
                    SugestaoPesoLabel.Text = $"Peso Adequado: {pesoAdequado.ToString()}Kg";
                }
                else if (imc < 40)
                {
                    ClassificacaoPesoLabel.Text = "Obesidade Grau 2";
                    ClassificacaoPesoLabel.TextColor = Microsoft.Maui.Graphics.Colors.OrangeRed;
                    SugestaoPesoLabel.Text = $"Peso Adequado: {pesoAdequado.ToString()}Kg";
                }
                else
                {
                    ClassificacaoPesoLabel.Text = "Obesidade Grau 3";
                    ClassificacaoPesoLabel.TextColor = Microsoft.Maui.Graphics.Colors.DarkRed;
                    SugestaoPesoLabel.Text = $"Peso Adequado: {pesoAdequado.ToString()}Kg";
                }

            }
       
        }

        private void AlturaSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double alturaSlider = Math.Round(AlturaSlider.Value, 2);
            AlturaLabel.Text = $"{alturaSlider}";
        }

        private void PesoSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double pesoSlider = Math.Round(PesoSlider.Value, 1);
            PesoLabel.Text = $"{pesoSlider}";
        }
    }
}
