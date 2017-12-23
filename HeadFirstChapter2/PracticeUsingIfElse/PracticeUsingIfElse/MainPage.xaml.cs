using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PracticeUsingIfElse
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void changeText_Click(object sender, RoutedEventArgs e)
        {
            setLabelToChangeText(enableCheckBox.IsChecked);
        }

        private void setLabelToChangeText(bool? check)
        {
            if (check == true)
            {
                
                if (isLeft(labelToChange.HorizontalAlignment))
                {
                    labelToChange.HorizontalAlignment = HorizontalAlignment.Right;
                    labelToChange.Text = "Right";
                }
                else
                {
                    labelToChange.HorizontalAlignment = HorizontalAlignment.Left;
                    labelToChange.Text = "Left";
                }
            }
            else
            {
                labelToChange.HorizontalAlignment = HorizontalAlignment.Center;
                labelToChange.Text = "Text changing is disabled";
            }
            
        }

        private bool isLeft(HorizontalAlignment alignment)
        {
            if (alignment == HorizontalAlignment.Left)
                return true;
            else
                return false;
        }
    }
}
