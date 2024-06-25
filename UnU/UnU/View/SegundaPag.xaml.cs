using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace generarcv.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SegundaPag : ContentPage
    {
        public SegundaPag(string nombre, string apellido, string direcc, string correo, string contacto, string expe1, string expe2, string expe3, string ingles, string educacion, string aptitud1, string aptitud2, string aptitud3, string descripcion)
        {
            InitializeComponent();
            LabelNombreComp.Text = nombre + " " + apellido;
            direc.Text ="Actualmente vivo en --> "+ direcc;
            corr.Text = "Puedes enviarme un correo --> " + correo;
            numero.Text = "Mi whatsApp es --> " + contacto + " suelo responder rapido";
            Experiencia1.Text = "♦ "+ expe1;
            Experiencia2.Text = "♦ " + expe2;
            Experiencia3.Text = "♦ " + expe3;
            Ingles.Text = "Mi nivel de ingles es --> " + ingles;
            edu.Text = educacion;
            Ap1.Text = "♦ " + aptitud1;
            Ap2.Text = "♦ " + aptitud2;
            Ap3.Text = "♦ " + aptitud3;
            Desc.Text =descripcion;

        }
    }

}
