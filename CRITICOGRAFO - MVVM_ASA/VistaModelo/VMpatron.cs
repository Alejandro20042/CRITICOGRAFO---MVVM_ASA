using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CRITICOGRAFO_MVVM_ASA.VistaModelo
{
    class VMpatron : BaseViewModel
    {
        private string nombre;
        private string resultadosFinal;
        private bool generoHombre;
        private bool generoMujer;
        private bool alto;
        private bool feo;
        private bool hermoso;
        private bool extravagante;
        private bool guapo;
        private bool listo;

        public string ResultadosFinal
        {
            get { return resultadosFinal; }
            set { SetValue(ref resultadosFinal, value); }
        }

        public string Nombre
        {
            get { return nombre; }
            set { SetValue(ref nombre, value); }
        }

        public bool Generohombre
        {
            get { return generoHombre; }
            set { SetValue(ref generoHombre, value); }
        }
        public bool Generomujer
        {
            get { return generoMujer; }
            set { SetValue(ref generoMujer, value); }
        }

        public bool Alto
        {
            get { return alto; }
            set { SetValue(ref alto, value); }
        }

        public bool Feo
        {
            get { return feo; }
            set { SetValue(ref feo, value); }
        }

        public bool Hermoso
        {
            get { return hermoso; }
            set { SetValue(ref hermoso, value); }
        }

        public bool Extravagante
        {
            get { return extravagante; }
            set { SetValue(ref extravagante, value); }
        }

        public bool Guapo
        {
            get { return guapo; }
            set { SetValue(ref guapo, value); }
        }

        public bool Listo
        {
            get { return listo; }
            set { SetValue(ref listo, value); }
        }

        public ICommand CalcularResultadosCommand => new Command(CalcularResultados);

        public void CalcularResultados()
        {
            string caracteristicas = "";

            if (generoHombre)
            {
                if (Alto)
                    caracteristicas += " Alto,";

                if (Feo)
                    caracteristicas += " Feo,";

                if (Hermoso)
                    caracteristicas += " Hermoso,";

                if (Extravagante)
                    caracteristicas += " Extravagante,";

                if (Guapo)
                    caracteristicas += " Guapo,";

                if (Listo)
                    caracteristicas += " Listo,";
            }
            else if(generoMujer)
            {
                if (Alto)
                    caracteristicas += " Alta,";

                if (Feo)
                    caracteristicas += " Fea,";

                if (Hermoso)
                    caracteristicas += " Hermosa,";

                if (Guapo)
                    caracteristicas += " Guapa,";

                if (Listo)
                    caracteristicas += " Lista,";

                if (Extravagante)
                    caracteristicas += " Extravagante,";
            }


            string genero = Generohombre ? "Hombre" : Generomujer ? "Mujer" : "";

            string resultado = $"{Nombre} es {genero}, ";

            if (!string.IsNullOrWhiteSpace(caracteristicas))
            {
                int ultimaComa = caracteristicas.TrimEnd(',').LastIndexOf(",");

                if (ultimaComa > 0)
                {
                    resultado += $"Es {caracteristicas.Substring(0, ultimaComa)} y {caracteristicas.Substring(ultimaComa + 1)}.";

                }
                else
                {
                    resultado += $"{caracteristicas.TrimEnd(',')}";

                }

                ResultadosFinal = resultado;
            }
        }
    }
}
