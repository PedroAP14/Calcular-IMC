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

            if (NomeEntry.Text == null || IdadeEntry.Text == null || GeneroPicker.SelectedIndex == -1)
            {
                AvisoLabel.Text = "Insira todas as informações!!!";
                return;
            }
                
            else
            {
               altura = Convert.ToDouble(AlturaLabel.Text);
               peso = Convert.ToDouble(PesoLabel.Text);

                AvisoLabel.Text = null;

                imc = Math.Round(peso / (altura * altura), 1);

                if (imc < 18.5)
                {
                    ClassificacaoPesoLabel.Text = "Abaixo do Peso";
                    ClassificacaoPesoLabel.TextColor = Microsoft.Maui.Graphics.Colors.Red;
                }
                else if (imc < 25)
                {
                    ClassificacaoPesoLabel.Text = "Peso Adequado";
                    ClassificacaoPesoLabel.TextColor = Microsoft.Maui.Graphics.Colors.LightGreen;
                }
                else if (imc < 30)
                {
                    ClassificacaoPesoLabel.Text = "SobrePeso";
                    ClassificacaoPesoLabel.TextColor = Microsoft.Maui.Graphics.Colors.DarkGreen;
                }
                else if (imc < 35)
                {
                    ClassificacaoPesoLabel.Text = "Obesidade Grau 1";
                    ClassificacaoPesoLabel.TextColor = Microsoft.Maui.Graphics.Colors.Orange;
                }
                else if (imc < 40)
                {
                    ClassificacaoPesoLabel.Text = "Obesidade Grau 2";
                    ClassificacaoPesoLabel.TextColor = Microsoft.Maui.Graphics.Colors.OrangeRed;
                }
                else
                {
                    ClassificacaoPesoLabel.Text = "Obesidade Grau 3";
                    ClassificacaoPesoLabel.TextColor = Microsoft.Maui.Graphics.Colors.DarkRed;
                }


                ImcLabel.Text = $" IMC: {imc.ToString()}";
            }
       
        }

        private void AlturaSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double alturaArredondado = Math.Round(AlturaSlider.Value, 2);
            string alturaTexto = alturaArredondado.ToString();
            AlturaLabel.Text = $"{alturaTexto}";
        }

        private void PesoSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double pesoArredondado = Math.Round(PesoSlider.Value, 2);
            string pesoTexto = pesoArredondado.ToString();
            PesoLabel.Text = $"{pesoTexto}";
        }
    }
}
