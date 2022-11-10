using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Acr.UserDialogs;
using iText.Html2pdf;
using iText.Html2pdf.Attach.Impl.Tags;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using Microsoft.AppCenter.Crashes;
using Newtonsoft.Json;
using PCLStorage;
using Plugin.Media;

using Xamarin.Forms;

namespace HealthSafetyApp.Views.Topics
{
    public partial class SafeSystemForm : ContentPage
    {
        private string fileText;

        int img_count;
        private string filname;
        public SafeSystemForm(string filenam)
        {
            InitializeComponent();
            filname = filenam;
            this.Title = "Safe systems of work tool";
            {
                this.BackgroundColor = Xamarin.Forms.Color.White;
            }
        }
        protected async override void OnAppearing()
        {

            try
            {
                base.OnAppearing();
                if (filname != "1")
                {
                    await PCLReadJson();
                }
            }
            catch (Exception exception)
            {
                Crashes.TrackError(exception);
            }
        }
        public async Task PCLReadJson()
        {


            IFile file = null;
            if (Device.RuntimePlatform == Device.iOS)
            {
                file = await FileSystem.Current.LocalStorage.GetFileAsync(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/HandSAppDrafts/" + filname);
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                file = await FileSystem.Current.LocalStorage.GetFileAsync("/storage/emulated/0/HandSAppDrafts/" + filname);
            }

            using (var stream = await file.OpenAsync(PCLStorage.FileAccess.Read))
            using (var reader = new StreamReader(stream))
            {
                FileText = await reader.ReadToEndAsync();
            }


            DraftFields account = JsonConvert.DeserializeObject<DraftFields>(FileText);
            txt_name.Text = account.Name1;
            txt_projname.Text = account.ProjectName;

            datepicker.Date = Convert.ToDateTime(account.date);
            headlines.Text = account.detail;
            img1.Text = account.img1;
            img2.Text = account.img2;
            img3.Text = account.img3;
            img4.Text = account.img4;
            img5.Text = account.img5;
            img6.Text = account.img6;
            img7.Text = account.img7;
            img8.Text = account.img8;
            img9.Text = account.img9;
            img10.Text = account.img10;
            img_count = 0;
            for (int i = 1; i <= 10; i++)
            {
                Label lbl = this.FindByName<Label>("img" + i);
                if (!(lbl.Text is null))
                {
                    img_count++;
                }
            }

            if (img1 != null)
            {
                ActImg.Text = "1";
                Image1.Source = img1.Text;
            }


        }
        void Prev_Clicked(System.Object sender, System.EventArgs e)
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

        void DeletePhoto_Clicked(System.Object sender, System.EventArgs e)
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

        void Next_Clicked(System.Object sender, System.EventArgs e)
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

        async void takePhoto_Clicked(System.Object sender, System.EventArgs e)
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

        async void pickPhoto_Clicked(System.Object sender, System.EventArgs e)
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
            await Navigation.PushAsync(new DraftsList("_SSW", 1));
        }

        #region SaveDraft
        private async void OnClick_SaveDraft(object sender, EventArgs e)
        {
            try
            {
                if (Device.RuntimePlatform == Device.iOS)
                {
                    await PCLGenarateJson(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    await PCLGenarateJson("/storage/emulated/0/");
                }

            }
            catch (FormatException) { }
        }
        public async Task PCLGenarateJson(string path)
        {

            string dat = "";
            var dt = datepicker.Date;
            dat = dt.ToString(CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern);

            IFile file;
            DraftFields s = new DraftFields
            {
                Name1 = txt_name.Text,
                ProjectName = txt_projname.Text,

                date = dat,
                detail = headlines.Text,
                img1 = img1.Text,
                img2 = img2.Text,
                img3 = img3.Text,
                img4 = img4.Text,
                img5 = img5.Text,
                img6 = img6.Text,
                img7 = img7.Text,
                img8 = img8.Text,
                img9 = img9.Text,
                img10 = img10.Text,
            };

            string jsonContents = JsonConvert.SerializeObject(s);

            IFolder rootFolder = await FileSystem.Current.GetFolderFromPathAsync(path);
            IFolder folder = await rootFolder.CreateFolderAsync("HandSAppDrafts", CreationCollisionOption.OpenIfExists);
            if (filname != "1")
            { file = await folder.CreateFileAsync(filname, CreationCollisionOption.ReplaceExisting); }
            else
            {
                string fnam = await InputBox(this.Navigation);
                if (fnam is null) { return; }
                else
                {
                    if (fnam == "") { fnam = "Draft_SSW.json"; } else { fnam = fnam + "_SSW.json"; }
                }
                file = await folder.CreateFileAsync(fnam, CreationCollisionOption.GenerateUniqueName);
            }
            using (var fs = await file.OpenAsync(PCLStorage.FileAccess.ReadAndWrite))
            {
                using (StreamWriter textWriter = new StreamWriter(fs))
                {
                    textWriter.Write(jsonContents);

                }

            }
            await DisplayAlert("File Path", file.Path.ToString(), "OK");
            //UserDialogs.Instance.ShowSuccess("Draft saved at:" + file.Path.ToString(), 2000);
        }

        public Task<string> InputBox(INavigation navigation)
        {
            // wait in this proc, until user did his input 
            var tcs = new TaskCompletionSource<string>();

            var lblTitle = new Label { Text = "Health & Safety App", HorizontalOptions = LayoutOptions.Center, FontAttributes = FontAttributes.Bold };
            var lblMessage = new Label { Text = "Enter file name:" };
            var txtInput = new Entry { Text = "" };

            var btnOk = new Xamarin.Forms.Button
            {
                Text = "Ok",
                WidthRequest = 100,
                BackgroundColor = Xamarin.Forms.Color.FromRgb(0.8, 0.8, 0.8),
            };
            btnOk.Clicked += async (s, e) =>
            {
                // close page
                var result = txtInput.Text;
                await navigation.PopModalAsync();
                // pass result
                tcs.SetResult(result);
            };

            var btnCancel = new Xamarin.Forms.Button
            {
                Text = "Cancel",
                WidthRequest = 100,
                BackgroundColor = Xamarin.Forms.Color.FromRgb(0.8, 0.8, 0.8)
            };
            btnCancel.Clicked += async (s, e) =>
            {
                // close page
                await navigation.PopModalAsync();
                // pass empty result
                tcs.SetResult(null);
            };

            var slButtons = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { btnOk, btnCancel },
            };

            var layout = new StackLayout
            {
                Padding = new Thickness(0, 40, 0, 0),
                VerticalOptions = LayoutOptions.StartAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Orientation = StackOrientation.Vertical,
                Children = { lblTitle, lblMessage, txtInput, slButtons },
            };

            // create and show page
            var page = new ContentPage();
            page.Content = layout;
            navigation.PushModalAsync(page);
            // open keyboard
            txtInput.Focus();

            // code is waiting her, until result is passed with tcs.SetResult() in btn-Clicked
            // then proc returns the result
            return tcs.Task;
        }
        public string FileText
        {
            get { return fileText; }
            set
            {
                if (FileText == value) return;
                fileText = value;
                OnPropertyChanged();
            }
        }

        private async void OnClick_SavePDF(object sender, EventArgs e)
        {
            try
            {
                if (Device.RuntimePlatform == Device.iOS)
                {
                    await PCLReportGenaratePdf(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    await PCLReportGenaratePdf("/storage/emulated/0/");
                }
            }
            catch (Exception exception)
            {
                Crashes.TrackError(exception);
            }
        }
        public async Task PCLReportGenaratePdf(string path)
        {
            try
            {
                string dat = "";
                var dt = datepicker.Date;
                dat = dt.ToString(CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern);
                string HeadText = headlines.Text;
                if (!(HeadText is null))
                {
                    HeadText = HeadText.Replace("\r\n", "").Replace("\n", "").Replace("\r", "");

                }
                StringBuilder sb = new StringBuilder();
                sb.Append("<main>");
                sb.Append(@"<table border='0' width='100%'><tbody>
                <tr>
                <td colspan='10' bgcolor='gray' align='center'>
                <font color='white'><h3><b>Safe systems of work</b></h3></font></center>
                </td></tr>
                <tr>
                <td colspan='10' bgcolor='silver' align='right'>
                <p style='color:#ffffff;font-size:5px;'><i>Created using safe systems of work tool © @The Health And Safety App </i></p>
                </td>

                </tr>
                </tbody></table>
                
                <table border='0' width='100%'><tbody>

                <tr>
                <td colspan='20' align='left'>
                <font color='#3399ff'><h3><b>Assessor name:</b></h3></font>
                </td>
                </tr>

                <tr>
                <td colspan='20' align='left'>
                <font><h3>" + txt_name.Text + @"</h3></font>
                </td>
                </tr>

                <tr>
                <td colspan='20' align='left'>
                <font color='#3399ff'><h3><b>Risk assessment topic name:</b></h3></font>
                </td>
                </tr>

                <tr>
                <td colspan='20' align='left'>
                <font><h3>" + txt_projname.Text + @"</h3></font>
                </td>
                </tr>

                <tr>
                <td colspan='20' align='left'>
                <font color='#3399ff'><h3><b>Date:</b></h3></font>
                </td>
                </tr>

                <tr>
                <td colspan='20' align='left'>
                <font><h3>" + dat + @"</h3></font>
                </td>
                </tr>

                <tr bgcolor='#3399ff'>
                <td colspan='20' align='Center'>
                <font color='white'><h3><b>Safe systems/Method statment</b></h3></font>
                </td>
                </tr>

                <tr>
                <td colspan='20' align='left'>
                <p>");
                sb.Append(HeadText);

                sb.Append(@"</p>
                </td>

                </tr>

                </tbody></table>
                


                <table style='width: 100%;' border='1'>
                <tbody>
                <tr>
                <td colspan='3' rowspan='1'> Signature(s) </td>
                <td colspan='7' rowspan='2'>  </td>
                <td colspan='2' rowspan='1'> Date: </td>
                <td colspan='3' rowspan='2'> </td>
                <td colspan='2' rowspan='1'> Review Date: </td>
                <td colspan='3' rowspan='2'> </td>
                </tr>
                </tbody>
                </table>");
                sb.Replace(System.Environment.NewLine, "\n");
                StringReader sr = new StringReader(sb.ToString());

                IFolder rootFolder = await FileSystem.Current.GetFolderFromPathAsync(path);
                IFolder folder = await rootFolder.CreateFolderAsync("HandSAppPdf", CreationCollisionOption.OpenIfExists);
                string fnam = await InputBox(this.Navigation);

                if (fnam is null) { return; }
                else
                { if (fnam == "") { fnam = "Safe systems of work.pdf"; } else { fnam = fnam + ".pdf"; } }

                IFile file = await folder.CreateFileAsync(fnam, CreationCollisionOption.GenerateUniqueName);

                using (var fs = await file.OpenAsync(PCLStorage.FileAccess.ReadAndWrite))
                {

                    ConverterProperties properties = new ConverterProperties();
                    PdfWriter writer = new PdfWriter(fs);
                    PdfDocument pdfDocument = new PdfDocument(writer);
                    pdfDocument.SetDefaultPageSize(PageSize.A4);
                    var doc = HtmlConverter.ConvertToDocument(sb.ToString(), pdfDocument, properties);
                    doc.Close();
                    await DisplayAlert("File Path", file.Path.ToString(), "OK");

                }
                //txt_name.Text = txt_projname.Text = "";
            }
            catch (Exception ex)
            {

            }
        
        }


    }
    #endregion

}

