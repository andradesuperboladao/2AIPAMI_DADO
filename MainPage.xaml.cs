using System.Threading.Tasks;

namespace prova
{
    public partial class MainPage : ContentPage
    {
        int sorteado, itemIndex = -1;
        string face = "um.png";

        Game jogo = new Game();
        Dado dado = new Dado();
        public MainPage()
        {
            InitializeComponent();
        }

        private async void FlipButton_Clicked(object sender, EventArgs e)
        {
            itemIndex = FacePicker.SelectedIndex + 1;
           
            face = dado.Girar();
            if (dado.Soma >= 25)
            {
                await DisplayAlert("Teste", $"Limite alcançado!!  {dado.Soma}", "Ok");

            }
            else
            {

                if (itemIndex == -1)
                {
                    await DisplayAlert("Moeda", "Escolha a Face da Moeda!", "OK");
                }
                else
                {
                    //Fazer o sorteio do lado da moeda.
                    //Classe ... Variável... Uso do Construtor;



                    if (dado.LadoGirado == "um")
                    {
                        sorteado = 1;
                    }
                    else
                    {
                        if (dado.LadoGirado == "dois")
                        {
                            sorteado = 2;
                        }
                        else
                        {
                            if (dado.LadoGirado == "tres")
                            {
                                sorteado = 3;
                            }
                            else
                            {
                                if (dado.LadoGirado == "quatro")
                                {
                                    sorteado = 4;
                                }
                                else
                                {
                                    if (dado.LadoGirado == "cinco")
                                    {
                                        sorteado = 5;
                                    }
                                    else
                                    {
                                        if (dado.LadoGirado == "seis")
                                        {
                                            sorteado = 6;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (jogo.CheckWinner(sorteado, itemIndex))
                    {
                        FaceImage.Source = $"{face}.png";
                        await DisplayAlert("Sorteio", $"PARABÉNS!!! \nDeu {face}! " +
                            $"\nVocê GANHOU!" +
                            $"\nVoce ganhou {jogo.PlayerPoint} vezes!" +
                            $"\nSua sequencia é de {jogo.Streak}" +
                            $"\nSeu limite esta em: {dado.Soma}", "OK");
                    }
                    else
                    {
                        FaceImage.Source = $"{face}.png";
                        await DisplayAlert("Sorteio", $"Que PENA!!!\nDeu {face}! \nVocê PERDEU!", "OK");
                    }
                }
            }
        }
    }
}