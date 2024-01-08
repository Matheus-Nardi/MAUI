using AppJogoDaForca.Repositories;
using AppJogoDaForca.Models;
using AppJogoDaForca.Libraries.Text;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace AppJogoDaForca
{
    public partial class MainPage : ContentPage
    {

        private Word _word;
        private int _errors;
        private int _streak;
        

        public MainPage()
        {
            InitializeComponent();

            ResetScreen();
            streakButton.Text = $"STREAK : {_streak}";
        }

        private async void OnButtonClicked(object sender , EventArgs e)
        {
            Button button = (Button)sender;
            button.IsEnabled = false;
            String letter = button.Text;
            var positions = _word.Text.GetPosition(letter);

            if (positions.Count == 0)
            {
                ErrorHandler(button);
                await isGameOver();
                return;

            }

            ReplaceLetter(button, letter, positions);
            await isWin();

        }


        private void OnButtonClickedResetGamer(object sender, EventArgs e)
        {
            ResetScreen();
            streakButton.Text = $"STREAK : {_streak = 0}";
        }
        #region Handler Error
        private async Task isGameOver()
        {
            if (_errors == 6)
            {
                bool answer = await DisplayAlert("Voce foi enforcado", $"A palavra era {_word.Text} !", "Novo Jogo", "Sair");
                streakButton.Text = $"STREAK : {_streak = 0}";

                if (answer)
                {
                    ResetScreen();
                }
                else
                {
                    await Navigation.PopAsync();
                }

            }
        }

        private void ErrorHandler(Button button)
        {
            _errors++;
            imgForca.Source = ImageSource.FromFile($"forca{_errors + 1}.png");
            button.Style = App.Current.Resources.MergedDictionaries.ElementAt(1)["Fail"] as Style;
        }


        #endregion


        #region Handler Success
        private void ReplaceLetter(Button button, string letter, List<int> positions)
        {
            foreach (var position in positions)
            {
                lblText.Text = lblText.Text.Remove(position, 1).Insert(position, letter);
                button.Style = App.Current.Resources.MergedDictionaries.ElementAt(1)["Success"] as Style;
            }
        }


        private async Task isWin()
        {
            if (lblText.Text == _word.Text)
            {
                bool answer = await DisplayAlert("Parabens", $"Voce acertou a palavra {_word.Text} !", "Novo Jogo", "Sair");
                streakButton.Text = $"STREAK : {++_streak}";

                if (answer)
                {
                    ResetScreen();
                }
                else
                {
                    await Navigation.PopAsync();
                }
            }
        }
        #endregion


        #region ResetScreen
        public void  ResetScreen()
        {
            ResetKeyBoard();
            ReserErros();
            GenerateNewWord();
        }

        private void GenerateNewWord()
        {
            var repository = new WordRepositories();
            _word = repository.GetRandomWord();

            lblTips.Text = _word.Tips;
            lblText.Text = new string('_', _word.Text.Length);
        }

        private void ReserErros()
        {
            _errors = 0;
            imgForca.Source = ImageSource.FromFile("forca1.png");

        }

        private void ResetKeyBoard()
        {
            ResetLines((HorizontalStackLayout)KeyboardContainer.Children[0]);
            ResetLines((HorizontalStackLayout)KeyboardContainer.Children[1]);
            ResetLines((HorizontalStackLayout)KeyboardContainer.Children[2]);
           
        }

        private void ResetLines(HorizontalStackLayout horizontal)
        {
            foreach (Button button in horizontal.Children)
            {
                button.IsEnabled = true;
                button.Style= null;
            }
            
        }

        #endregion

        
    }
}