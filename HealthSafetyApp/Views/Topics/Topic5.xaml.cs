using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Acr.UserDialogs;
using Plugin.Media;

namespace HealthSafetyApp.Views.Topics
{
    public partial class Topic5 : ContentPage
    {
        private string fileText;
        
        int img_count;
        private string filname;
        public Topic5(string filenam)
        {
            InitializeComponent();
            filname = filenam;
            this.Title = "Accident record form";
            {
                this.BackgroundColor = Xamarin.Forms.Color.White;
            }
        }

       

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }


        

        private void OnClick_Prev(object sender, EventArgs e)
        {
            if (img_count == 0)
            {
                lbl_from.Text = "0";
                lbl_to.Text = "0";
                return;
            }

            int s = 0;

            if (ActImg.Text != null)
            {
                Int32.TryParse(ActImg.Text, out s);
                if (s != 1)
                {
                    s--;
                }
                else { s = img_count; }

                Label lbl = this.FindByName<Label>("img" + s);
                if (lbl.Text != null)
                {
                    Image1.Source = lbl.Text;
                    ActImg.Text = s.ToString();

                }




                lbl_from.Text = s.ToString();
                lbl_to.Text = img_count.ToString();


            }
        }
        private void OnClick_Nxt(object sender, EventArgs e)
        {
            if (img_count == 0)
            {
                lbl_from.Text = "0";
                lbl_to.Text = "0";
                return;
            }

            int s = 0;

            if (ActImg.Text != null)
            {
                Int32.TryParse(ActImg.Text, out s);
                if (s != 10 && s != img_count)
                {
                    s++;
                }
                else
                {
                    s = 1;
                }
                Label lbl = this.FindByName<Label>("img" + s);
                if (lbl.Text != null)
                {
                    Image1.Source = lbl.Text;
                    ActImg.Text = s.ToString();
                }
                lbl_from.Text = s.ToString();
                lbl_to.Text = img_count.ToString();




            }
        }

        private void OnClick_deletepicture(object sender, EventArgs e)
        {
            int s = 0;

            if (ActImg.Text != null)
            {
                img_count--;

                if (img_count <= 0)
                {
                    lbl_from.Text = "0";
                    lbl_to.Text = "0";

                    img1.Text = null;
                    Image1.Source = "";
                    ActImg.Text = "";

                    return;
                }

                Int32.TryParse(ActImg.Text, out s);
                Label lbl, lbl1, lbl2;
                if (s != 10 && s <= img_count)
                {
                    for (int i = s; i < 10; i++)
                    {
                        lbl1 = this.FindByName<Label>("img" + i);
                        int j = i + 1;
                        lbl2 = this.FindByName<Label>("img" + j);
                        lbl1.Text = lbl2.Text;
                    }

                    if (img_count != 0)
                    {
                        lbl = this.FindByName<Label>("img" + s);
                        Image1.Source = lbl.Text;
                        ActImg.Text = s.ToString();
                    }
                    else
                    {
                        lbl = this.FindByName<Label>("img" + s);
                        lbl.Text = null;
                        Image1.Source = "";
                        ActImg.Text = "";
                    }

                }

                else
                {
                    s = img_count;
                    img10.Text = "";
                    lbl = this.FindByName<Label>("img" + s);
                    Image1.Source = lbl.Text;
                    ActImg.Text = s.ToString();

                }

                lbl_from.Text = s.ToString();
                lbl_to.Text = img_count.ToString();


            }
        }


        private async void OnClick_takepicture(object sender, EventArgs e)
        {
            filname = "1";
            if (img_count >= 10)
            {
                UserDialogs.Instance.Alert("You can't attach more than 10 images.Please delete one to attach one more", "Image count Exceeding limit");
                return;
            }
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", "No camera avaialble.", "OK");
                return;
            }
            try
            {

                var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
                {
                    PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,
                    Directory = "HealthAndSafetyImages",
                    Name = "img" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg"
                });


                if (file == null)
                {
                    return;
                }
                else
                {
                    img_count++;
                    Label lbl = this.FindByName<Label>("img" + img_count);
                    lbl.Text = file.Path;

                    ActImg.Text = img_count.ToString();
                    lbl_to.Text = img_count.ToString();
                    lbl_from.Text = img_count.ToString();

                    Image1.Source = ImageSource.FromStream(() =>
                    {
                        var stream = file.GetStream();
                        file.Dispose();
                        return stream;
                    });
                }

            }
            catch (Exception error)
            {
                await DisplayAlert("Alert!", error.ToString(), "OK");
                throw error;
            }


        }
        private async void OnClick_pickPicture(object sender, EventArgs e)
        {
            filname = "1";
            if (img_count >= 10)
            {
                UserDialogs.Instance.Alert("You can't attach more than 10 images.Please delete one to attach one more", "Image count Exceeding limit");
                return;
            }

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Photos Not Supported", ":( Permission not granted to photos.", "OK");
                return;
            }
            var file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
            {
                PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium
            });
            if (file == null)
                return;

            img_count++;
            Label lbl = this.FindByName<Label>("img" + img_count);
            lbl.Text = file.Path;
            ActImg.Text = img_count.ToString();
            lbl_to.Text = img_count.ToString();
            lbl_from.Text = img_count.ToString();
            Image1.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
        }

        private async void OnClick_OpenDraft(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DraftsList("_ARF", 1));
        }

    }
}
