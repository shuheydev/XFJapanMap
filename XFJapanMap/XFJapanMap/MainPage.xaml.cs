using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFJapanMap
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

        private VisualElement polygonSelected;
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (polygonSelected != null)
                VisualStateManager.GoToState(polygonSelected, "Normal");

            VisualStateManager.GoToState((VisualElement)sender, "Selected");

            polygonSelected = (VisualElement)sender;
        }
    }
}
