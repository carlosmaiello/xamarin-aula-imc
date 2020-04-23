using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IMC.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PerfilPage : ContentPage
    {
        public PerfilPage()
        {
            InitializeComponent();

            NomeLabel.Text = App.UsuarioLogado.Nome;
            PesoLabel.Text = Convert.ToString(App.UsuarioLogado.Peso);
            AlturaLabel.Text = Convert.ToString(App.UsuarioLogado.Altura);
        }
    }
}