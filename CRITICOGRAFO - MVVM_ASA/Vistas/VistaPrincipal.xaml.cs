using CRITICOGRAFO_MVVM_ASA.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CRITICOGRAFO_MVVM_ASA.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaPrincipal : ContentPage
    {
        public VistaPrincipal()
        {
            InitializeComponent();
            BindingContext = new VMpatron();
        }
    }
}