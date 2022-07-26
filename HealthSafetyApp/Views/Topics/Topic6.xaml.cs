using System;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
using Newtonsoft.Json;
using Acr.UserDialogs;
using System.Globalization;

namespace HealthSafetyApp.Views.Topics
{
    public partial class Topic6 : ContentPage
    {
        private string fileText;
        
        private string filname;
        
        
        int img_count;

        public Topic6(string filenam)
        {
            InitializeComponent();
            filname = filenam;
            this.Title = "Safe systems of work tool";
#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS0612 // Type or member is obsolete
            if (Device.OS == TargetPlatform.Windows)
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0618 // Type or member is obsolete
            {
                this.BackgroundColor = Xamarin.Forms.Color.White;
            }
           
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();          
            if (filname != "1")
            {
                await PCLReadJson();
            }
        }


        #region SavePDF
        private async void OnClick_SavePDF(object sender, EventArgs e)
        {
            try
            {
                await PCLReportGenaratePdf("/storage/emulated/0/");
            }
            catch (FormatException) { }

        }
        public async Task PCLReportGenaratePdf(string path)
        {
            string dat = "";
            var dt = datepicker.Date;
                       dat = dt.ToString(CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern);
            string HeadText= headlines.Text;
            if (!(HeadText is null))
            {
                HeadText = HeadText.Replace("\r\n", "<br>").Replace("\n", "<br>").Replace("\r", "<br>");

            }

            //for(Int16 i=1; i <= HeadText.Length; i++)
            //{
            //    await DisplayAlert("File Path", HeadText.Substring(i,1) , "OK");
            //}
            //if (Device.OS == TargetPlatform.Windows)
            //{
            //    StringBuilder sb = new StringBuilder();
            //    sb.Append("<header class='headerdiv'>");
            //    sb.Append("<b><h1 style='color:#000000;font-size:30px;'>Form</h1></b>");
            //    sb.Append("<br/>");
            //    sb.Append("<div>");
            //    sb.Append("<b><p style='color:#0086b7;font-size:16px;'>Name</p></b>");
            //    sb.Append("<u><p style='font-size:14px;'>" + txt_name.Text + "</p></u>");
            //    sb.Append("<b><p style='color:#0086b7;font-size:16px;'>Project Name</p></b>");
            //    sb.Append("<u><p style='font-size:14px;'>" + txt_projname.Text + "</p></u>");
            //    sb.Append("<b><p style='color:#0086b7;font-size:16px;'>Site Name</p></b>");

            //    sb.Append("<b><p style='color:#0086b7;font-size:16px;'>Date</p></b>");
            //    sb.Append("<u><p style='font-size:14px;'>" + dat + "</p></u>");
            //    sb.Append("<br/>");


            //    sb.Append("</div>");
            //    sb.Append("</header>");
            //    sb.Append("<br/>");
            //    sb.Append("<br/>");


            //    sb.Append("<main>");

            //    sb.Append("</main>");
            //    var filepath = "";
            //    var winwrite = DependencyService.Get<IWPExternalStorageWriter>();
            //    filepath = await winwrite.CreateFile("hello.html");
            //    IFolder rootFolder = await FileSystem.Current.GetFolderFromPathAsync(filepath);
            //    IFolder folder = await rootFolder.CreateFolderAsync("KashAppPdf", CreationCollisionOption.OpenIfExists);
            //    IFile file = await folder.CreateFileAsync("Topic6_pdf.html", CreationCollisionOption.GenerateUniqueName);
            //    await file.WriteAllTextAsync(sb.ToString());
            //    await DisplayAlert("File Path", file.Path.ToString(), "OK");
            //}
#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS0612 // Type or member is obsolete
            if (Device.OS == TargetPlatform.Android)
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0618 // Type or member is obsolete
            {
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
<br/>
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
<br/>


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

            }


            txt_name.Text = txt_projname.Text = "";


        }
        #endregion

        #region SaveDraft
        private async void OnClick_SaveDraft(object sender, EventArgs e)
        {
            try
            {
                await PCLGenarateJson("/storage/emulated/0/");
            }
            catch (FormatException) { }
        }
        public async Task PCLGenarateJson(string path)
        {

            string dat = "";
            var dt = datepicker.Date;
                       dat = dt.ToString(CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern);

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS0612 // Type or member is obsolete
            if (Device.OS == TargetPlatform.Windows)
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0618 // Type or member is obsolete
            {
                string filepath = "";
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

            }
#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS0612 // Type or member is obsolete
            if (Device.OS == TargetPlatform.Android)
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0618 // Type or member is obsolete
            {
                
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

            }



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
        #endregion


        #region OpenDraft
        private async void OnClick_OpenDraft(object sender, EventArgs e)
        {           
           
        }


        public async Task PCLReadJson()
        {

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS0612 // Type or member is obsolete
            if (Device.OS == TargetPlatform.Windows)
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0618 // Type or member is obsolete
            {
                
            }
#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS0612 // Type or member is obsolete
            if (Device.OS == TargetPlatform.Android)
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0618 // Type or member is obsolete
            {
               
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
        #endregion







        public class DraftFields
        {
            public string Name1 { get; set; }
            public string ProjectName { get; set; }
            public string SiteName { get; set; }
            public string date { get; set; }
            public string detail { get; set; }
            public string img1 { get; set; }
            public string img2 { get; set; }
            public string img3 { get; set; }
            public string img4 { get; set; }
            public string img5 { get; set; }
            public string img6 { get; set; }
            public string img7 { get; set; }
            public string img8 { get; set; }
            public string img9 { get; set; }
            public string img10 { get; set; }
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

        }
        private async void OnClick_pickPicture(object sender, EventArgs e)
        {
            filname = "1";
            if (img_count >= 10)
            {
                UserDialogs.Instance.Alert("You can't attach more than 10 images.Please delete one to attach one more", "Image count Exceeding limit");
                return;
            }

           


            //await DisplayAlert("File Path", Image1.Source.ToString(), "OK");
        }



    }
}


