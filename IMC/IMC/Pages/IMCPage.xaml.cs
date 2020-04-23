using IMC.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IMC.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IMCPage : ContentPage
    {
        private ObservableCollection<Imc> Itens = new ObservableCollection<Imc>();

        public IMCPage()
        {
            InitializeComponent();
            HistoricoList.ItemsSource = Itens;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Imc imc = App.UsuarioLogado.NovaAlturaPeso(Convert.ToDouble(AlturaEntry.Text), 
                Convert.ToDouble(PesoEntry.Text));

            DisplayAlert("IMC", "Seu IMC é " + imc.Valor, "Fechar");

            Itens.Add(imc);

            PesoEntry.Text = "";
            AlturaEntry.Text = "";
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            App.UsuarioLogado.Imcs.Clear();
            Itens.Clear();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PerfilPage());
        }

        private void HistoricoList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Imc sel = e.SelectedItem as Imc;

            if (sel != null) DisplayAlert("IMC", sel.ToString(), "Fechar");

            HistoricoList.SelectedItem = null;
        }
    }
}