using Formulario.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Formulario.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormularioPage : ContentPage
    {
        public FormularioPage()
        {
            InitializeComponent();
            BindingContext = new FormViewModel();
        }
    }
}