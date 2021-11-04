using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using anim;

namespace anim
{
    public partial class MainPage : ContentPage
    {
        private int prav = 0;
        private int neprav = 0;
        private int FirstOper = 0;
        private int SecondOper = 0;
        private int Result = 0;
        private int btnlbl1 = 0;
        private int btnlbl2 = 0;
        private int btnlbl3 = 0;
        private int btnlbl4 = 0;
        private int KonSum = 0;
        private int Operaciya = 0;
        private int isprg = 0;
        Random x = new Random();
        
        public MainPage()
        {
            InitializeComponent();
            DependencyService.Get<IAudio>().PlayAudioFile("Sound_2.mp3");
            
            Rass();
        }
        private void Rass()
        {
            isprg = int.Parse(prg.Text);
            KonSum = isprg;
            lblprav.Text = "Правильные: " + prav.ToString();
            lblneprav.Text = "Неправильные: " + neprav.ToString();

            Operaciya = x.Next(0,6);

            if (Operaciya == 0)
            {
                FirstOper = x.Next(0, isprg);
                SecondOper = x.Next(0, isprg);
                text.Text = FirstOper.ToString() + " + " + SecondOper.ToString() + " =";
                Result = FirstOper + SecondOper;
            }
            else if (Operaciya == 1)
            {
                FirstOper = x.Next(0, isprg);
                SecondOper = x.Next(0, isprg);
                while (SecondOper > FirstOper)
                {
                    SecondOper = x.Next(0, isprg);
                }
                text.Text = FirstOper.ToString() + " - " + SecondOper.ToString() + " =";
                Result = FirstOper - SecondOper;

            }
            else if (Operaciya==2)
            {
                FirstOper = x.Next(0, isprg);
                SecondOper = x.Next(0, isprg);
                while (SecondOper > FirstOper)
                {
                    SecondOper = x.Next(0, isprg);
                }
                text.Text = SecondOper.ToString() + " +  ...  = " + FirstOper.ToString();
                Result = FirstOper - SecondOper;
            }
            else if (Operaciya == 3)
            {
                FirstOper = x.Next(0, isprg);
                SecondOper = x.Next(0, isprg);
                while (SecondOper > FirstOper)
                {
                    SecondOper = x.Next(0, isprg);
                }
                text.Text = FirstOper.ToString() + " -  ...  = " + SecondOper.ToString();
                Result = FirstOper - SecondOper;
            }
            else if (Operaciya == 4)
            {
                FirstOper = x.Next(0, isprg);
                SecondOper = x.Next(0, isprg);
                while (SecondOper > FirstOper)
                {
                    SecondOper = x.Next(0, isprg);
                }
                text.Text = "... - " + SecondOper.ToString() + " = " + FirstOper.ToString();
                Result = FirstOper + SecondOper;
            }
            else if (Operaciya == 5)
            {
                FirstOper = x.Next(0, isprg);
                SecondOper = x.Next(0, isprg);
                
                text.Text = FirstOper.ToString() + " x " + SecondOper.ToString() + " =";
                Result = FirstOper * SecondOper;
                KonSum = isprg*3;
            }




            int Whatbutton = 0;

            Whatbutton = x.Next(1, 5);

            if (Whatbutton == 1)
            {
                btnlbl1 = Result;
                while (true)
                {
                    int a = x.Next(0, KonSum);
                    if (a != btnlbl1)
                    {
                        btnlbl2 = a;
                        break;
                    }
                }
                while (true)
                {
                    int a = x.Next(0, KonSum);
                    if (a != btnlbl1 && a != btnlbl2)
                    {
                        btnlbl3 = a;
                        break;
                    }
                }
                while (true)
                {
                    int a = x.Next(0, KonSum);
                    if (a != btnlbl1 && a != btnlbl2 && a != btnlbl3)
                    {
                        btnlbl4 = a;
                        break;
                    }
                }
            }
            else if (Whatbutton == 2)
            {
                btnlbl2 = Result;
                while (true)
                {
                    int a = x.Next(0, KonSum);
                    if (a != btnlbl2)
                    {
                        btnlbl1 = a;
                        break;
                    }
                }
                while (true)
                {
                    int a = x.Next(0, KonSum);
                    if (a != btnlbl1 && a != btnlbl2)
                    {
                        btnlbl3 = a;
                        break;
                    }
                }
                while (true)
                {
                    int a = x.Next(0, KonSum);
                    if (a != btnlbl1 && a != btnlbl2 && a != btnlbl3)
                    {
                        btnlbl4 = a;
                        break;
                    }
                }
            }
            else if (Whatbutton == 3)
            {
                btnlbl3 = Result;
                while (true)
                {
                    int a = x.Next(0, KonSum);
                    if (a != btnlbl3)
                    {
                        btnlbl1 = a;
                        break;
                    }
                }
                while (true)
                {
                    int a = x.Next(0, KonSum);
                    if (a != btnlbl1 && a != btnlbl3)
                    {
                        btnlbl2 = a;
                        break;
                    }
                }
                while (true)
                {
                    int a = x.Next(0, KonSum);
                    if (a != btnlbl1 && a != btnlbl2 && a != btnlbl3)
                    {
                        btnlbl4 = a;
                        break;
                    }
                }
            }
            else if (Whatbutton == 4)
            {
                btnlbl4 = Result;
                while (true)
                {
                    int a = x.Next(0, KonSum);
                    if (a != btnlbl4)
                    {
                        btnlbl1 = a;
                        break;
                    }
                }
                while (true)
                {
                    int a = x.Next(0, KonSum);
                    if (a != btnlbl1 && a != btnlbl4)
                    {
                        btnlbl2 = a;
                        break;
                    }
                }
                while (true)
                {
                    int a = x.Next(0, KonSum);
                    if (a != btnlbl1 && a != btnlbl2 && a != btnlbl4)
                    {
                        btnlbl3 = a;
                        break;
                    }
                }
            }

            btn1.Text = btnlbl1.ToString();
            btn2.Text = btnlbl2.ToString();
            btn3.Text = btnlbl3.ToString();
            btn4.Text = btnlbl4.ToString();

        }
        private void Srav(int a)
        {
            animationView.IsVisible = false;
            animationViewneprav.IsVisible = false;
            if (a == Result)
            {
                animationView.IsVisible = true;
                DependencyService.Get<IAudio>().PlayAudioFile("Sound_prav.mp3");
                prav++;
            }
            else
            {
                animationViewneprav.IsVisible = true;

                DependencyService.Get<IAudio>().PlayAudioFile("Sound_neprav.mp3");
                neprav++;
            }
        }
        private void Btn1_Clicked(object sender, EventArgs e)
        {
            Srav(btnlbl1);
            Rass();
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            Srav(btnlbl2);
            Rass();
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            Srav(btnlbl3);
            Rass();
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {           
            Srav(btnlbl4);
            Rass();
        }
    }
    [ContentProperty("Source")]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }
            var imageSource = ImageSource.FromResource(Source);

            return imageSource;
        }
    }
}
