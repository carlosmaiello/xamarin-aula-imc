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
        private ObservableCollection<String> Itens = new ObservableCollection<String>();

        public IMCPage()
        {
            InitializeComponent();
            HistoricoList.ItemsSource = Itens;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            /*
            double peso = Convert.ToDouble(PesoEntry.Text);
            double altura = Convert.ToDouble(AlturaEntry.Text);
            double imc = peso / (altura * altura);
            DisplayAlert("IMC", "Seu IMC é " + imc.Valor, "Fechar");
            */

            Imc imc = new Imc();
            imc.Altura = Convert.ToDouble(AlturaEntry.Text);
            imc.Peso = Convert.ToDouble(PesoEntry.Text);

            Itens.Add(imc.Mensagem);

            PesoEntry.Text = "";
            AlturaEntry.Text = "";
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Itens.Clear();
        }
    }
}