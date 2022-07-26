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
    public partial class Topic5 : ContentPage
    {
        private string fileText;
        int a_up, b_up, c_up, a_low, b_low, c_low, a_new, b_new, c_new, a_new1, b_new1, c_new1, a_new2, b_new2, c_new2 = 0;
        string c_up_color;
        string c_low_color;
        string c_new_color;
        string c_new1_color;
        int count = 0;
        
        Picker pck;
        int img_count;
        private string filname;
        public Topic5(string filenam)
        {
            InitializeComponent();
            filname = filenam;
            this.Title = "Accident record form";
#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS0612 // Type or member is obsolete
            if (Device.OS == TargetPlatform.Windows)
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0618 // Type or member is obsolete
            {
                this.BackgroundColor = Xamarin.Forms.Color.White;
            }
            //chkbx2.IsChecked = false;
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
            //            if (Device.OS == TargetPlatform.Windows)
            //            {
            //                StringBuilder sb = new StringBuilder();
            //                sb.Append("<header class='headerdiv'>");
            //                sb.Append("<b><h1 style='color:#000000;font-size:30px;'>Form</h1></b>");
            //                sb.Append("<br/>");
            //                sb.Append("<div>");
            //                sb.Append("<b><p style='color:#0086b7;font-size:16px;'>Name</p></b>");
            //                sb.Append("<u><p style='font-size:14px;'>" + txt_name.Text + "</p></u>");
            //                sb.Append("<b><p style='color:#0086b7;font-size:16px;'>Project Name</p></b>");
            //                sb.Append("<u><p style='font-size:14px;'>" + txt_projname.Text + "</p></u>");
            //                sb.Append("<b><p style='color:#0086b7;font-size:16px;'>Site Name</p></b>");
            //                sb.Append("<u><p style='font-size:14px;'>" + txt_sitename.Text + "</p></u>");
            //                sb.Append("<b><p style='color:#0086b7;font-size:16px;'>Date</p></b>");
            //                sb.Append("<u><p style='font-size:14px;'>" + dat + "</p></u>");
            //                sb.Append("<br/>");
            //                if (chkbx1.IsChecked == true)
            //                { sb.Append("<p style='font-size:16px;'>(o) " + txt_Check1_text.Text + "</p>"); }
            //                else
            //                { sb.Append("<p style='font-size:16px;'>( )  " + txt_Check1_text.Text + "</p>"); }
            //                if (chkbx2.IsChecked == true)
            //                { sb.Append("<p style='font-size:16px;'>(o)  " + txt_Check2_text.Text + "</p>"); }
            //                else
            //                { sb.Append("<p style='font-size:16px;'>( ) " + txt_Check2_text.Text + "</p>"); }

            //                sb.Append("</div>");
            //                sb.Append("</header>");
            //                sb.Append("<br/>");
            //                sb.Append("<br/>");


            //                sb.Append("<main>");

            //                sb.Append("</main>");
            //                var filepath = "";
            //                var winwrite = DependencyService.Get<IWPExternalStorageWriter>();
            //                filepath = await winwrite.CreateFile("hello.html");
            //                IFolder rootFolder = await FileSystem.Current.GetFolderFromPathAsync(filepath);
            //                IFolder folder = await rootFolder.CreateFolderAsync("HandSAppPdf", CreationCollisionOption.OpenIfExists);
            //                IFile file = await folder.CreateFileAsync("Topic3_pdf.html", CreationCollisionOption.GenerateUniqueName);
            //                await file.WriteAllTextAsync(sb.ToString());
            //                await DisplayAlert("File Path", file.Path.ToString(), "OK");
            //            }
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
<font color='white'><h3><b>Accident/Incident Record Form </b></h3></font></center>
</td></tr>
<tr>
<td colspan='10' bgcolor='silver' align='right'>
<p style='color:#ffffff;font-size:5px;'><i>Created using Accident Record tool © @The Health And Safety App </i></p>
</td>

</tr>
</tbody></table>
<br>
<table border='0' width='100%'><tbody>
<tr>
<td colspan='2' bgcolor='#3399ff' align='center'>
<font color='white'><h3><b>1. </b></h3></font>
</td>
<td colspan='18' bgcolor='gray' align='left'>
<font color='white'><h3><b>About the person involved with accident / incident </b></h3></font>
</td></tr>
</tbody></table>
<br>
<table border='0' width='100%' border='0' ><tbody>

<tr bgcolor='whitesmoke'>
<td colspan='4' rowspan='1'><font color='#3399ff'> Name: </font></td>
<td colspan='16' rowspan='1' align='left' border='0'>" + txt_name.Text + @" </td>
</tr>

<tr bgcolor='lightgray'>
<td colspan='4' rowspan='1'><font color='#3399ff'> Address: </font></td>
<td colspan='16' rowspan='1' align='left' border='0'>" + txt_Address.Text + @" </td>
</tr>

<tr bgcolor='whitesmoke'>
<td colspan='4' rowspan='1'><font color='#3399ff'> City/Town: </font></td>
<td colspan='16' rowspan='1' align='left' border='0'>" + txt_city.Text + @" </td>
</tr>

<tr bgcolor='lightgray'>
<td colspan='4' rowspan='1'><font color='#3399ff'> Postcode: </font></td>
<td colspan='16' rowspan='1' align='left' border='0'>" + txt_postcode.Text + @" </td>
</tr>

<tr bgcolor='whitesmoke'>
<td colspan='4' rowspan='1'><font color='#3399ff'>Telephone: </font></td>
<td colspan='16' rowspan='1' align='left' border='0'>" + txt_telephone.Text + @" </td>
</tr>

<tr bgcolor='lightgray'>
<td colspan='4' rowspan='1'><font color='#3399ff'>Occupation: </font></td>
<td colspan='16' rowspan='1' align='left' border='0'>" + txt_occupation.Text + @" </td>
</tr>

 </tbody> </table>
<br>

<table border='0' width='100%'><tbody>
<tr>
<td colspan='2' bgcolor='#3399ff' align='center'>
<font color='white'><h3><b>2. </b></h3></font>
</td>
<td colspan='18' bgcolor='gray' align='left'>
<font color='white'><h3><b>Details of person reporting this accident / incident</b></h3></font>
</td></tr>
</tbody></table><br>
<table border='0' width='100%' border='0' ><tbody>

<tr bgcolor='whitesmoke'>
<td colspan='4' rowspan='1'><font color='#3399ff'> Name: </font></td>
<td colspan='16' rowspan='1' align='left' border='0'>" + txt_name2.Text + @" </td>
</tr>

<tr bgcolor='lightgray'>
<td colspan='4' rowspan='1'><font color='#3399ff'> Address: </font></td>
<td colspan='16' rowspan='1' align='left' border='0'>" + txt_Address2.Text + @" </td>
</tr>

<tr bgcolor='whitesmoke'>
<td colspan='4' rowspan='1'><font color='#3399ff'> City/Town: </font></td>
<td colspan='16' rowspan='1' align='left' border='0'>" + txt_city2.Text + @" </td>
</tr>

<tr bgcolor='lightgray'>
<td colspan='4' rowspan='1'><font color='#3399ff'> Postcode: </font></td>
<td colspan='16' rowspan='1' align='left' border='0'>" + txt_postcode2.Text + @" </td>
</tr>

<tr bgcolor='whitesmoke'>
<td colspan='4' rowspan='1'><font color='#3399ff'>Telephone: </font></td>
<td colspan='16' rowspan='1' align='left' border='0'>" + txt_telephone2.Text + @" </td>
</tr>

<tr bgcolor='lightgray'>
<td colspan='4' rowspan='1'><font color='#3399ff'>Occupation: </font></td>
<td colspan='16' rowspan='1' align='left' border='0'>" + txt_occupation2.Text + @" </td>
</tr>

 </tbody> </table>
<br>
<table border='0' width='100%'><tbody>
<tr>
<td colspan='2' bgcolor='#3399ff' align='center'>
<font color='white'><h3><b>3. </b></h3></font>
</td>
<td colspan='18' bgcolor='gray' align='left'>
<font color='white'><h3><b>Details of accident / incident and injury</b></h3></font>
</td></tr>
</tbody></table>
<br>
<table border='0' width='100%'><tbody>
<tr bgcolor='whitesmoke'>

<td colspan='3' rowspan='1'><font color='#3399ff'>Date: </font></td>
<td colspan='7' rowspan='1' align='left' border='0'>" + dat + @" </td>

<td colspan='3' rowspan='1' align='right' ><font color='#3399ff'>Time: </font></td>
<td colspan='7' rowspan='1' align='left' border='0'>" + timepicker.Time.ToString() + @" </td>

</tr>
</tbody></table>
<table border='0' width='100%' border='0' ><tbody>

<tr bgcolor='lightgray'>
<td colspan='20' rowspan='1' align='left'><font color='#3399ff'> Where did the accident/injury take place? </font></td>
</tr>

<tr bgcolor='lightgray'>
<td colspan='20' rowspan='1' align='left' border='0'>" + entry_Where.Text + @" </td>
</tr>

<tr bgcolor='whitesmoke'>
<td colspan='20' rowspan='1' align='left'><font color='#3399ff'> How the accident happened, Give the cause if you can? </font></td>
</tr>

<tr bgcolor='whitesmoke'>
<td colspan='20' rowspan='1' align='left' border='0'>" + entry_How.Text + @" </td>
</tr>

<tr bgcolor='lightgray'>
<td colspan='20' rowspan='1' align='left'><font color='#3399ff'> Details of accident/injury? </font></td>
</tr>

<tr bgcolor='lightgray'>
<td colspan='20' rowspan='1' align='left' border='0'>" + entry_Details.Text + @" </td>
</tr>


</table><br/>
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

                sb.Append("</main>");

                StringReader sr = new StringReader(sb.ToString());

               
            }

            //txt_name.Text = txt_projname.Text = txt_sitename.Text = "";


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
                    Add = txt_Address.Text,
                    City =txt_city.Text,
                    date = dat,
                    time=timepicker.Time.ToString(),   
                    PostCode=txt_postcode.Text,
                    tele=txt_telephone.Text,
                    ocu=txt_occupation.Text,
                    name2=txt_name2.Text,
                    Add2 = txt_Address2.Text,
                    City2 = txt_city2.Text,
                    PostCode2 = txt_postcode2.Text,
                    tele2 = txt_telephone2.Text,
                    ocu2 = txt_occupation2.Text,
                    Where=entry_Where.Text,
                    How=entry_How.Text,
                    detail=entry_Details.Text,
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
                    Add = txt_Address.Text,
                    City = txt_city.Text,
                    date = dat,
                    time=timepicker.Time.ToString(),
                    PostCode = txt_postcode.Text,
                    tele = txt_telephone.Text,
                    ocu = txt_occupation.Text,
                    name2 = txt_name2.Text,
                    Add2 = txt_Address2.Text,
                    City2 = txt_city2.Text,
                    PostCode2 = txt_postcode2.Text,
                    tele2 = txt_telephone2.Text,
                    ocu2 = txt_occupation2.Text,
                    Where = entry_Where.Text,
                    How = entry_How.Text,
                    detail = entry_Details.Text,
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
                string filepath = "";
                
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
           
            datepicker.Date = Convert.ToDateTime(account.date);
            timepicker.Time = TimeSpan.Parse(account.time);

            txt_Address.Text = account.Add;
            txt_city.Text= account.City ;

             txt_postcode.Text=account.PostCode;
              txt_telephone.Text=account.tele;
            txt_occupation.Text = account.ocu;
                     txt_name2.Text = account.name2;
              txt_Address2.Text=account.Add2;
              txt_city2.Text=account.City2;
            txt_postcode2.Text = account.PostCode2;
             txt_telephone2.Text=account.tele2;
                     txt_occupation2.Text = account.ocu2;
             entry_Where.Text=account.Where;
              entry_How.Text=account.How;
              entry_Details.Text=account.detail;
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
            public string time { get; set; }
            public string CheckBox1data { get; set; }
            public string CheckBox2data { get; set; }
            public string Add { get; set; }
            public string City { get; set; }
            public string PostCode{ get; set; }
            public string tele{ get; set; }
            public string ocu{ get; set; }
            public string name2 { get; set; }
            public string Add2 { get; set; }
            public string City2 { get; set; }
            public string PostCode2 { get; set; }
            public string tele2 { get; set; }
            public string ocu2 { get; set; }
            public string Where { get; set; }
            public string How { get; set; }
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
