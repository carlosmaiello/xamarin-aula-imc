using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IMC
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (App.UsuarioLogado.Email == EmailEntry.Text &&
                App.UsuarioLogado.Senha == SenhaEntry.Text)
            {
                App.Current.MainPage = new NavigationPage(new Pages.IMCPage());
            }
            else
            {
                DisplayAlert("Login", "Email ou senha inválidos", "Fechar");
            }

        }
    }
}
