using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace appAula23_02_Pages
{
    public partial class MainPage : ContentPage
    {
        public static String nome, curso;

        public MainPage()
        {
            InitializeComponent();
        }

        async void btnCadastrar_Clicked(object sender, EventArgs e)
        {
            nome = edtNome.Text;
            curso = edtCurso.Text;
            await Navigation.PushAsync(new Page2());
        }

        private void btnLimpar_Clicked(object sender, EventArgs e)
        {
            edtNome.Text = "";
            edtCurso.Text = "";
        }

        private void btnFinalizar_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}
