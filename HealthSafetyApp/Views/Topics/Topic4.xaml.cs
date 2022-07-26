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
    public partial class Topic4: ContentPage
    {
        private string fileText;
        //int a_up, b_up, c_up, a_low, b_low, c_low, a_new, b_new, c_new, a_new1, b_new1, c_new1, a_new2, b_new2, c_new2 = 0;
        //string c_up_color;
        //string c_low_color;
        //string c_new_color;
        //string c_new1_color;
        //int count = 0;
        
        Picker pck;
        int img_count;
        private string filname;
        public Topic4(string filenam)
        {
            InitializeComponent();
            filname = filenam;
            this.Title = "Manual handling risk assessment tool";
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
        private void CC_Checked(object sender, EventArgs e)
        {
            Controls.CheckText a = (Controls.CheckText)sender;

            Controls.CheckText CbRed;
            Controls.CheckText CbOrg;
            Controls.CheckText CbGrn;

            CbRed = (Controls.CheckText)CB11;
            CbOrg = (Controls.CheckText)CB12;
            CbGrn = (Controls.CheckText)CB13;

           if (a.Equals(CB11) || a.Equals(CB12) || a.Equals(CB13)) { CbRed = (Controls.CheckText)CB11; CbOrg = (Controls.CheckText)CB12; CbGrn = (Controls.CheckText)CB13; }
           if (a.Equals(CB21) || a.Equals(CB22) || a.Equals(CB23)) { CbRed = (Controls.CheckText)CB21; CbOrg = (Controls.CheckText)CB22; CbGrn = (Controls.CheckText)CB23; }
           if (a.Equals(CB31) || a.Equals(CB32) || a.Equals(CB33)) { CbRed = (Controls.CheckText)CB31; CbOrg = (Controls.CheckText)CB32; CbGrn = (Controls.CheckText)CB33; }

           if (a.Equals(CB41) || a.Equals(CB42) || a.Equals(CB43)) { CbRed = (Controls.CheckText)CB41; CbOrg = (Controls.CheckText)CB42; CbGrn = (Controls.CheckText)CB43; }
           if (a.Equals(CB51) || a.Equals(CB52) || a.Equals(CB53)) { CbRed = (Controls.CheckText)CB51; CbOrg = (Controls.CheckText)CB52; CbGrn = (Controls.CheckText)CB53; }
           if (a.Equals(CB61) || a.Equals(CB62) || a.Equals(CB63)) { CbRed = (Controls.CheckText)CB61; CbOrg = (Controls.CheckText)CB62; CbGrn = (Controls.CheckText)CB63; }

           if (a.Equals(CB71) || a.Equals(CB72) || a.Equals(CB73)) { CbRed = (Controls.CheckText)CB71; CbOrg = (Controls.CheckText)CB72; CbGrn = (Controls.CheckText)CB73; }
           if (a.Equals(CB81) || a.Equals(CB82) || a.Equals(CB83)) { CbRed = (Controls.CheckText)CB81; CbOrg = (Controls.CheckText)CB82; CbGrn = (Controls.CheckText)CB83; }
           if (a.Equals(CB91) || a.Equals(CB92) || a.Equals(CB93)) { CbRed = (Controls.CheckText)CB91; CbOrg = (Controls.CheckText)CB92; CbGrn = (Controls.CheckText)CB93; }

           if (a.Equals(CB101) || a.Equals(CB102) || a.Equals(CB103)) { CbRed = (Controls.CheckText)CB101; CbOrg = (Controls.CheckText)CB102; CbGrn = (Controls.CheckText)CB103; }
           if (a.Equals(CB111) || a.Equals(CB112) || a.Equals(CB113)) { CbRed = (Controls.CheckText)CB111; CbOrg = (Controls.CheckText)CB112; CbGrn = (Controls.CheckText)CB113; }
           if (a.Equals(CB121) || a.Equals(CB122) || a.Equals(CB123)) { CbRed = (Controls.CheckText)CB121; CbOrg = (Controls.CheckText)CB122; CbGrn = (Controls.CheckText)CB123; }

           if (a.Equals(CB131) || a.Equals(CB132) || a.Equals(CB133)) { CbRed = (Controls.CheckText)CB131; CbOrg = (Controls.CheckText)CB132; CbGrn = (Controls.CheckText)CB133; }
           if (a.Equals(CB141) || a.Equals(CB142) || a.Equals(CB143)) { CbRed = (Controls.CheckText)CB141; CbOrg = (Controls.CheckText)CB142; CbGrn = (Controls.CheckText)CB143; }
           if (a.Equals(CB161) || a.Equals(CB162) || a.Equals(CB163)) { CbRed = (Controls.CheckText)CB161; CbOrg = (Controls.CheckText)CB162; CbGrn = (Controls.CheckText)CB163; }

           if (a.Equals(CB171) || a.Equals(CB172) || a.Equals(CB173)) { CbRed = (Controls.CheckText)CB171; CbOrg = (Controls.CheckText)CB172; CbGrn = (Controls.CheckText)CB173; }
           if (a.Equals(CB181) || a.Equals(CB182) || a.Equals(CB183)) { CbRed = (Controls.CheckText)CB181; CbOrg = (Controls.CheckText)CB182; CbGrn = (Controls.CheckText)CB183; }
           if (a.Equals(CB191) || a.Equals(CB192) || a.Equals(CB193)) { CbRed = (Controls.CheckText)CB191; CbOrg = (Controls.CheckText)CB192; CbGrn = (Controls.CheckText)CB193; }

            if (a.Checked == true)
            { 

                 if (a.Equals(CbRed))
                {
                    if (CbOrg.Checked == true) { CbOrg.IsEnabled = true; CbOrg.Checked = false; OrangeCount.Text = (int.Parse(OrangeCount.Text) - 1).ToString();  }
                    if (CbGrn.Checked == true) { CbGrn.IsEnabled = true; CbGrn.Checked = false; GreenCount.Text = (int.Parse(GreenCount.Text) - 1).ToString(); }
                    //if (CbRed.Checked == true) { CbRed.Checked = false; RedCount.Text = (int.Parse(RedCount.Text) - 1).ToString(); }

                    //OrangeCount.Text = (int.Parse(OrangeCount.Text) + 1).ToString();
                    //GreenCount.Text = (int.Parse(GreenCount.Text) + 1).ToString();
                    CbRed.IsEnabled = false;
                    RedCount.Text = (int.Parse(RedCount.Text) + 1).ToString();
                }
            
                if (a.Equals(CbOrg))
                {
                    //if (CbOrg.Checked == true) { CbOrg.Checked = false; OrangeCount.Text = (int.Parse(OrangeCount.Text) - 1).ToString(); }
                    if (CbGrn.Checked == true) { CbGrn.IsEnabled = true; CbGrn.Checked = false; GreenCount.Text = (int.Parse(GreenCount.Text) - 1).ToString(); }
                    if (CbRed.Checked == true) { CbRed.IsEnabled = true; CbRed.Checked = false; RedCount.Text = (int.Parse(RedCount.Text) - 1).ToString(); }

                    OrangeCount.Text = (int.Parse(OrangeCount.Text) + 1).ToString();
                    CbOrg.IsEnabled = false;
                    //GreenCount.Text = (int.Parse(GreenCount.Text) + 1).ToString();
                    //RedCount.Text = (int.Parse(RedCount.Text) + 1).ToString();
                }

                if (a.Equals(CbGrn))
                {
                    if (CbOrg.Checked == true) { CbOrg.IsEnabled = true; CbOrg.Checked = false; OrangeCount.Text = (int.Parse(OrangeCount.Text) - 1).ToString(); }
                    //if (CbGrn.Checked == true) { CbGrn.Checked = false; GreenCount.Text = (int.Parse(GreenCount.Text) - 1).ToString(); }
                    if (CbRed.Checked == true) { CbRed.IsEnabled = true; CbRed.Checked = false; RedCount.Text = (int.Parse(RedCount.Text) - 1).ToString(); }

                    //OrangeCount.Text = (int.Parse(OrangeCount.Text) + 1).ToString();
                    CbGrn.IsEnabled = false;
                    GreenCount.Text = (int.Parse(GreenCount.Text) + 1).ToString();
                    //RedCount.Text = (int.Parse(RedCount.Text) + 1).ToString();
                }
            }

          

        }
        private void CC_Checked_15(object sender, EventArgs e)
        {
            Controls.CheckBox a = (Controls.CheckBox)sender;
            if (a.Checked == true) {
                GreenCount.Text = (int.Parse(GreenCount.Text) + 1).ToString();
            }
            else
            {
                GreenCount.Text = (int.Parse(GreenCount.Text) - 1).ToString();
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
            //    sb.Append("<u><p style='font-size:14px;'>" + txt_sitename.Text + "</p></u>");
            //    sb.Append("<b><p style='color:#0086b7;font-size:16px;'>Date</p></b>");
            //    sb.Append("<u><p style='font-size:14px;'>" + dat + "</p></u>");
            //    sb.Append("<br/>");
            //    if (chkbx1.IsChecked == true)
            //    { sb.Append("<p style='font-size:16px;'>(o) " + txt_Check1_text.Text + "</p>"); }
            //    else
            //    { sb.Append("<p style='font-size:16px;'>( )  " + txt_Check1_text.Text + "</p>"); }
            //    if (chkbx2.IsChecked == true)
            //    { sb.Append("<p style='font-size:16px;'>(o)  " + txt_Check2_text.Text + "</p>"); }
            //    else
            //    { sb.Append("<p style='font-size:16px;'>( ) " + txt_Check2_text.Text + "</p>"); }

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
            //    IFolder folder = await rootFolder.CreateFolderAsync("HandSAppPdf", CreationCollisionOption.OpenIfExists);
            //    IFile file = await folder.CreateFileAsync("Topic3_pdf.html", CreationCollisionOption.GenerateUniqueName);
            //    await file.WriteAllTextAsync(sb.ToString());
            //    await DisplayAlert("File Path", file.Path.ToString(), "OK");
            //}
#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS0612 // Type or member is obsolete
            if (Device.OS == TargetPlatform.Android)
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0618 // Type or member is obsolete
            {
                StringBuilder sb=new StringBuilder();
                //sb.Append("<header>");
                //sb.Append("</header>");
                sb.Append("<main>");

                sb.Append(@"<table border='0' width='100%'><tbody>
<tr>
<td colspan='10' bgcolor='gray' align='center'>
<font color='white'><h3><b>Manual handling risk assessment</b></h3></font></center>
</td></tr>

<tr>
<td colspan='10' bgcolor='silver' align='right'>
<p style='color:#ffffff;font-size:5px;'><i>Created using Manual handling risk assessment tool © @The Health And Safety App </i></p>
</td>

</tr>

</tbody></table>
<br/>
<table border='0' width='100%' border='1' ><tbody>

<tr>
<td colspan='6' rowspan='1'><font color='#3399ff'> Name of assessor: </font></td>
<td colspan='14' rowspan='1' align='left'>" + txt_name.Text + @" </td>
</tr>

<tr>
<td colspan='6' rowspan='1'><font color='#3399ff'> Department: </font></td>
<td colspan='14' rowspan='1' align='left' >" + txt_projname.Text + @" </td>
</tr>

<tr>
<td colspan='6' rowspan='1'><font color='#3399ff'> Location: </font></td>
<td colspan='14' rowspan='1' align='left' >" + txt_sitename.Text + @" </td>
</tr>

<tr>
<td colspan='6' rowspan='1'><font color='#3399ff'> Date: </font></td>
<td colspan='14' rowspan='1' align='left'>" + dat.ToString() + @" </td>
</tr>

<tr>
<td colspan='6' rowspan='1'><font color='#3399ff'>Description: </font></td>
<td colspan='14' rowspan='1' align='left'>" + txt_Description.Text+ @" </td>
</tr>
 </tbody></table>
<br>

<table border='0' width='100%'><tbody>
<tr>
<td colspan='3' bgcolor='#3399ff' align='center'>
<font color='white'><h3><b>1. </b></h3></font>
</td>
<td colspan='17' bgcolor='gray' align='left'>
<font color='white'><h3><b>Task</b></h3></font>
</td></tr>
</tbody></table>

                <table border='0' width='100%'><tbody>
   

                   <tr bgcolor='#3399ff'>
    

                    <font color='white'>
     
                     <td colspan='5' rowspan='1' align='center'> Risk factor </td>
              
                              <td colspan='5' rowspan='1' align='left'> Guidelines to degree of risk</td>
                     
                                     <td colspan='10' rowspan='1' align='left'> Comments / Assumptions </td>
                          
                                           </font>
                          

                                          </tr>
                          

                                          <tr bgcolor='whitesmoke'>
                                         <td colspan='5' rowspan='1' align='left'> Frequency </td>
                          
                                                <td colspan='5' rowspan='1' align='left'>
                          
                                                     <table width='100%'> ");
                if (CB11.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  &gt; 8 per minute</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] &gt; 8 per minute</font></td></tr>"); }
                if (CB12.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] 2-8 per minute</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] 2-8 per minute</font></td></tr>"); }
                if (CB13.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] &lt; 2 per minute</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] &lt; 2 per minute</font></td></tr>"); }


                sb.Append(@"
                </table>
                </td>
                <td colspan='10' rowspan='1' align='left'>" + TB1.Text + @"</td>

                </tr>

                <tr bgcolor='lightgray'>


                <td colspan='5' rowspan='1' align='left'>Stooping</td>
                <td colspan='5' rowspan='1' align='left'> 
                <table width='100%' >");
                if (CB21.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>] &gt; 30 degrees</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] &gt; 30 degrees</font></td></tr>"); }
                if (CB22.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] 0-30 degrees</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] 0-30 degrees</font></td></tr>"); }
                if (CB23.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] No stooping</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] No stooping </font></td></tr>"); }


                sb.Append(@"

                </table>
                </td>
                <td colspan='10' rowspan='1' align='left'>" + TB2.Text + @" </td>

                </tr>

                <tr bgcolor='whitesmoke'>


                <td colspan='5' rowspan='1' align='left'>Twisting</td>
                <td colspan='5' rowspan='1' align='left'> 
                <table width='100%' >");
                if (CB31.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>] 45-90 degrees</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] 45-90 degrees</font></td></tr>"); }
                if (CB32.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] 0-90 degrees</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] 0-90 degrees</font></td></tr>"); }
                if (CB33.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Very little or no twisting</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Very little or no twisting</font></td></tr>"); }


                sb.Append(@"
                </table>
                </td>
                <td colspan='10' rowspan='1' align='left'>" + TB3.Text + @"</td>

                </tr>

                <tr bgcolor='lightgray'>


                <td colspan='5' rowspan='1' align='left'>Reaching</td>
                <td colspan='5' rowspan='1' align='left' > 
                <table width='100%'>");
                if (CB41.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>] Arms length</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Arms length</font></td></tr>"); }
                if (CB42.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Between arm length and body </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Between arm length and bodys</font></td></tr>"); }
                if (CB43.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Close to body </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Close to body</font></td></tr>"); }


                sb.Append(@"

                </table>
                </td>
                <td colspan='10' rowspan='1' align='left'>" + TB4.Text + @" </td>

                </tr>

                <tr bgcolor='whitesmoke'>


                <td colspan='5' rowspan='1' align='left'>Weight<br><h6>(Consider above factors and identify area subject to load from body map)</h6></td>
                <td colspan='5' rowspan='1' align='left' > 
                <table width='100%'>");
                if (CB51.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>] &gt; 25kg</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] &gt; 25kg</font></td></tr>"); }
                if (CB52.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] 12-25kg</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] 12-25kg </font></td></tr>"); }
                if (CB53.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] &lt; 12kg </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] &lt; 12kg </font></td></tr>"); }


                sb.Append(@"
                </table>
                </td>
                <td colspan='10' rowspan='1' align='left'>" + TB5.Text + @"</td>

                </tr>

                <tr bgcolor='lightgray'>


                <td colspan='5' rowspan='1' align='left'>Pushing/Pulling Force</td>
                <td colspan='5' rowspan='1' align='left' > 
                <table width='100%'>");
                if (CB61.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>] &gt; 25kg </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] &gt; 25kg</font></td></tr>"); }
                if (CB62.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] 10-25kg </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] 10-25kg</font></td></tr>"); }
                if (CB63.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] &lt; 10kg </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] &lt; 10kg </font></td></tr>"); }


                sb.Append(@"

                </table>
                </td>
                <td colspan='10' rowspan='1' align='left'>" + TB6.Text + @" </td>

                </tr>



                <tr bgcolor='whitesmoke'>


                <td colspan='5' rowspan='1' align='left'>Distance carried</td>
                <td colspan='5' rowspan='1' align='left'> 
                <table width='100%'>");
                if (CB71.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>] &gt; 10m forwards/ > 1m backwards </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] &gt; 10m forwards/ 1m backwards </font></td></tr>"); }
                if (CB72.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] 1-10m forward/ < 1m backwards </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] 1-10m forward / 1m backwards</font></td></tr>"); }
                if (CB73.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] &lt; 1m forwards/Nil backwards </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] &lt; 1m forwards/Nil backwards</font></td></tr>"); }


                sb.Append(@"
                </table>
                </td>
                <td colspan='10' rowspan='1' align='left'>" + TB7.Text + @"</td>

                </tr>

                <tr bgcolor='lightgray'>


                 <td colspan='5' rowspan='1' align='left'>Duration of each work element / assignment</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%'>");
                if (CB81.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>] &gt; 10 minutes/ &lt;30 minutes </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] &gt;10 minutes/ &lt;30 minutes </font></td></tr>"); }
                if (CB82.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] 1-10 minutes </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] 1-10 minutes</font></td></tr>"); }
                if (CB83.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] 30 secs - 1 minute </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] 30 secs - 1 minute</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB8.Text + @" </td>

                 </tr>

                </tbody></table><br>");

                sb.Append(@"<table border='0' width='100%'><tbody>
                <tr>
                <td colspan='3' bgcolor='#3399ff' align='Center'>
                <font color='white'><h3><b>2. </b></h3></font>
                </td>
                <td colspan='17' bgcolor='gray' align='Center'>
                <font color='white'><h3><b>Load</b></h3></font>
                </td></tr>
                </tbody></table>



                <table border='0' width='100%'><tbody>

                <tr bgcolor='#3399ff'>

                <font color='white'>
                <td colspan='5' rowspan='1' align='center'>Risk factor</td>
                <td colspan='5' rowspan='1' align='left' > Guidelines to degree of risk </td>
                <td colspan='10' rowspan='1' align='left'>Comments / Assumptions </td>
                 </font>

                </tr>

                <tr bgcolor='whitesmoke'>


                <td colspan='5' rowspan='1' align='left'>Part handling</td>
                <td colspan='5' rowspan='1' align='left'> 
                <table width='100%'>");
                if (CB91.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>] No grasp points</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] No grasp points</font></td></tr>"); }
                if (CB92.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Grasp points okay but awkward</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Grasp points okay but awkward</font></td></tr>"); }
                if (CB93.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good grasp points </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good grasp points </font></td></tr>"); }


                sb.Append(@"
                </table>
                </td>
                <td colspan='10' rowspan='1' align='left'>" + TB9.Text + @"</td>

                </tr>");

                sb.Append(@"<tr bgcolor='lightgray'>


                <td colspan='5' rowspan='1' align='left'> Conditions (COSHH)</td>
                <td colspan='5' rowspan='1' align='left' > 
                <table width='100%'>");
                if (CB101.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>] Unmarked potential harmful </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Unmarked potential harmful</font></td></tr>"); }
                if (CB102.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Marked potential harmful</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Marked potential harmful</font></td></tr>"); }
                if (CB103.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Marked harmless</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Marked harmless </font></td></tr>"); }


                sb.Append(@"

                </table>
                </td>
                <td colspan='10' rowspan='1' align='left'>" + TB10.Text + @" </td>

                </tr>

                 </tbody></table><br>

                <table border='0' width='100%'><tbody>
                 <tr>
                 <td colspan='3' bgcolor='#3399ff'align='Center'>
                 <font color='white'><h3><b>3. </b></h3></font></center>
                 </td>
                 <td colspan='17' bgcolor='gray' align='Center'>
                 <font color='white'><h3><b>Environment</b></h3></font></center>
                 </td></tr>
                 </tbody></table>



                 <table border='0' width='100%'><tbody>

                 <tr bgcolor='#3399ff'>

                 <font color='white'>
                 <td colspan='5' rowspan='1' align='center'>Risk factor</td>
                 <td colspan='5' rowspan='1' align='left' > Guidelines to degree of risk </td>
                 <td colspan='10' rowspan='1' align='left'>Comments / Assumptions </td>
                  </font>

                 </tr>

                 <tr bgcolor='whitesmoke'>


                 <td colspan='5' rowspan='1' align='left'>Space <br><h6>Access sufficient for size of part</h6></td>
                 <td colspan='5' rowspan='1' align='left' > 
                 <table  width='100%'>");
                 if (CB111.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>] Congested</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Congested</font></td></tr>"); }
                 if (CB112.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Restricted</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Restricted</font></td></tr>"); }
                 if (CB113.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Clear </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Clear </font></td></tr>"); }


                 sb.Append(@"
                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB11.Text + @"</td>

                 </tr>

                 <tr bgcolor='lightgray'>


                 <td colspan='5' rowspan='1' align='left'> Floor condition </td>
                 <td colspan='5' rowspan='1' align='left' > 
                 <table  width='100%'>");
                 if (CB121.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>] Slippery </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Slippery</font></td></tr>"); }
                 if (CB122.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Reasonable</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Reasonable</font></td></tr>"); }
                 if (CB123.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good </font></td></tr>"); }


                 sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB12.Text + @" </td>

                 </tr>

                 <tr bgcolor='whitesmoke'>


                 <td colspan='5' rowspan='1' align='left'>Changes in floor level</td>
                 <td colspan='5' rowspan='1' align='left' > 
                 <table  width='100%'>");
                 if (CB131.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>] Steps</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Steps</font></td></tr>"); }
                 if (CB132.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Slopes</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Slopes</font></td></tr>"); }
                 if (CB133.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] None </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] None </font></td></tr>"); }


                 sb.Append(@"
                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB13.Text + @"</td>

                 </tr>

                 <tr bgcolor='lightgray'>


                 <td colspan='5' rowspan='1' align='left'> Lighting </td>
                 <td colspan='5' rowspan='1' align='left' > 
                 <table  width='100%'>");
                 if (CB141.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>] Poor, deep shadow or glare </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor, deep shadow or glare</font></td></tr>"); }
                 if (CB142.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Reasonable, some shadow or glare</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Reasonable, some shadow or glare</font></td></tr>"); }
                 if (CB143.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good or natural light, no shadow or glare</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good or natural light, no shadow or glare </font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB14.Text + @" </td>

                 </tr>

                  </tbody></table>
                 <br>

                 <table border='0' width='100%'><tbody>
                 <tr>
                 <td colspan='3' bgcolor='#3399ff'align='Center'>
                 <font color='white'><h3><b>4. </b></h3></font></center>
                 </td>
                 <td colspan='17' bgcolor='gray' align='Center'>
                 <font color='white'><h3><b>Individual</b></h3></font></center>
                 </td></tr>
                 </tbody></table>



                 <table border='0' width='100%'><tbody>

                 <tr bgcolor='#3399ff'>

                 <font color='white'>
                 <td colspan='5' rowspan='1' align='center'>Risk factor</td>
                 <td colspan='5' rowspan='1' align='left' > Guidelines to degree of risk </td>
                 <td colspan='10' rowspan='1' align='left'>Comments / Assumptions </td>
                  </font>

                 </tr>");

                 //<tr bgcolor='whitesmoke'>


                 //<td colspan='5' rowspan='1' align='left'>AGE</h6></td>
                 //<td colspan='5' rowspan='1' align='left' > 
                 //<table  width='100%'>");
                 //if (CB111.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>] Congested</b></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Congested</td></tr>"); }
                 //if (CB112.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Restricted</b></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Restricted</td></tr>"); }
                 //if (CB151.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Assume fit and able bodied </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Assume fit and able bodied </font></td></tr>"); }


                 //sb.Append(@"
                 //</table>
                 //</td>
                 //<td colspan='10' rowspan='1' align='left'>" + TB15.Text + @"</td>

                 //</tr>

sb.Append(@" <tr bgcolor='lightgray'>


                 <td colspan='5' rowspan='1' align='left'>Physical status </td>
                 <td colspan='5' rowspan='1' align='left' > 
                 <table  width='100%'>");
                 if (CB161.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>] Unfit and with medical condition </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Unfit and with medical condition</font></td></tr>"); }
                 if (CB162.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Unfit but no medical condition</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Unfit but no medical condition</font></td></tr>"); }
                 if (CB163.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Fit and no medical condition</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Fit and no medical condition </font></td></tr>"); }


                 sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB16.Text + @" </td>

                 </tr>

                 <tr bgcolor='whitesmoke'>


                 <td colspan='5' rowspan='1' align='left'>Personal protective equipment (PPE)</h6></td>
                 <td colspan='5' rowspan='1' align='left' > 
                 <table  width='100%'>");
                 if (CB171.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>] PPE required and not provided</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] PPE required and not provided</font></td></tr>"); }
                 if (CB172.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] N/A</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] N/A </font></td></tr>"); }
                 if (CB173.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Appropriate PPE available </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Appropriate PPE available </font></td></tr>"); }


                 sb.Append(@"
                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB17.Text + @"</td>

                 </tr>

                 <tr bgcolor='lightgray'>


                 <td colspan='5' rowspan='1' align='left'> Training </td>
                 <td colspan='5' rowspan='1' align='left' > 
                 <table width='100%'>");
                 if (CB181.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>] No training given </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] No training given </font></td></tr>"); }
                 if (CB182.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] General training given</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] General training given </font></td></tr>"); }
                 if (CB183.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Specific training given </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Specific training given </font></td></tr>"); }


                 sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB18.Text + @" </td>

                 </tr>

                 <tr bgcolor='whitesmoke'>


                 <td colspan='5' rowspan='1' align='left'>Teamwork</h6></td>
                 <td colspan='5' rowspan='1' align='left' > 
                 <table width='100%'>");
                 if (CB191.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>] Manning less than process or not available </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Manning less than process or not available</font></td></tr>"); }
                 if (CB192.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] N/A</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] N/A</font></td></tr>"); }
                 if (CB193.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Manning available in line with the process </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Manning available in line with the process </font></td></tr>"); }


                 sb.Append(@"
                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB19.Text + @"</td>

                 </tr>");
                 sb.Append(@"</tbody></table>
                <br>
                 <table width='100%'>
                 <tr><font color='white'>
                 <td colspan='8' bgcolor='gray'> Totals (Counts)</td>
                 <td colspan='4' bgcolor='red' align='center'>" + RedCount.Text + @"</td>
                 <td colspan='4' bgcolor='orange' align='center'>" + OrangeCount.Text + @"</td>
                 <td colspan='4' bgcolor='green' align='center'>" + GreenCount.Text + @"</td>
                 </font>
                 </tr>
                 </table>
                 <br>
                 <table width='100%'>
                 <tr>
                 <td colspan='20' bgcolor='whitesmoke' align='center' ><font color='red' size='8 px'><i>
                 
                 ! If you have 1 or more red counts and/or more than 5 amber counts, Dynamic risk assessment will be required.   
                 </i></font></td>
                 </tr>
                 <tr bg='lightgray'>
                 <td colspan='20' align='center'> Remarks</td></tr>

                 <tr border='1'>
                 <td colspan='20' align='center'>" + TB20.Text + @"</td></tr>

                </table >

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
</table>
");

                sb.Append("</main>");

                StringReader sr=new StringReader(sb.ToString());

            }

            txt_name.Text=txt_projname.Text=txt_sitename.Text="";


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
            string dat="";
            var dt=datepicker.Date;
            dat=dt.Year + "/" + dt.Month + "/" + dt.Day;
#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS0612 // Type or member is obsolete
            if (Device.OS == TargetPlatform.Windows)
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0618 // Type or member is obsolete
            {
                string filepath="";
                DraftFields s=new DraftFields
                {
                    Name1=txt_name.Text,
                    ProjectName=txt_projname.Text,
                    SiteName=txt_sitename.Text,
                    date=dat,
                   

                };
               
            }
#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS0612 // Type or member is obsolete
            if (Device.OS == TargetPlatform.Android)
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0618 // Type or member is obsolete
            {
                
                DraftFields s=new DraftFields
                {
                    Name1=txt_name.Text,
                    ProjectName=txt_projname.Text,
                    SiteName=txt_sitename.Text,
                    date=dat,
                    Desc=txt_Description.Text,
                    CB11=CB11.Checked ? "1" : "0",
                    CB12=CB12.Checked ? "1" : "0",
                    CB13=CB13.Checked ? "1" : "0",
                    CB21=CB21.Checked ? "1" : "0",
                    CB22=CB22.Checked ? "1" : "0",
                    CB23=CB23.Checked ? "1" : "0",
                    CB31=CB31.Checked ? "1" : "0",
                    CB32=CB32.Checked ? "1" : "0",
                    CB33=CB33.Checked ? "1" : "0",
                    CB41=CB41.Checked ? "1" : "0",
                    CB42=CB42.Checked ? "1" : "0",
                    CB43=CB43.Checked ? "1" : "0",
                    CB51=CB51.Checked ? "1" : "0",
                    CB52=CB52.Checked ? "1" : "0",
                    CB53=CB53.Checked ? "1" : "0",
                    CB61=CB61.Checked ? "1" : "0",
                    CB62=CB62.Checked ? "1" : "0",
                    CB63=CB63.Checked ? "1" : "0",
                    CB71=CB71.Checked ? "1" : "0",
                    CB72=CB72.Checked ? "1" : "0",
                    CB73=CB73.Checked ? "1" : "0",
                    CB81=CB81.Checked ? "1" : "0",
                    CB82=CB82.Checked ? "1" : "0",
                    CB83=CB83.Checked ? "1" : "0",
                    CB91=CB91.Checked ? "1" : "0",
                    CB92=CB92.Checked ? "1" : "0",
                    CB93=CB93.Checked ? "1" : "0",
                    CB101=CB101.Checked ? "1" : "0",
                    CB102=CB102.Checked ? "1" : "0",
                    CB103=CB103.Checked ? "1" : "0",
                    CB111=CB111.Checked ? "1" : "0",
                    CB112=CB112.Checked ? "1" : "0",
                    CB113=CB113.Checked ? "1" : "0",
                    CB121=CB121.Checked ? "1" : "0",
                    CB122=CB122.Checked ? "1" : "0",
                    CB123=CB123.Checked ? "1" : "0",
                    CB131=CB131.Checked ? "1" : "0",
                    CB132=CB132.Checked ? "1" : "0",
                    CB133=CB133.Checked ? "1" : "0",
                    CB141=CB141.Checked ? "1" : "0",
                    CB142=CB142.Checked ? "1" : "0",
                    CB143=CB143.Checked ? "1" : "0",
                    CB151=CB151.Checked ? "1" : "0",
                    CB161=CB161.Checked ? "1" : "0",
                    CB162=CB162.Checked ? "1" : "0",
                    CB163=CB163.Checked ? "1" : "0",
                    CB171=CB171.Checked ? "1" : "0",
                    CB172=CB172.Checked ? "1" : "0",
                    CB173=CB173.Checked ? "1" : "0",
                    CB181=CB181.Checked ? "1" : "0",
                    CB182=CB182.Checked ? "1" : "0",
                    CB183=CB183.Checked ? "1" : "0",
                    CB191=CB191.Checked ? "1" : "0",
                    CB192=CB192.Checked ? "1" : "0",
                    CB193=CB193.Checked ? "1" : "0",
                    TB1=TB1.Text,
                    TB2=TB2.Text,
                    TB3=TB3.Text,
                    TB4=TB4.Text,
                    TB5=TB5.Text,
                    TB6=TB6.Text,
                    TB7=TB7.Text,
                    TB8=TB8.Text,
                    TB9=TB9.Text,
                    TB10=TB10.Text,
                    TB11=TB11.Text,
                    TB12=TB12.Text,
                    TB13=TB13.Text,
                    TB14=TB14.Text,
                    TB15=TB15.Text,
                    TB16=TB16.Text,
                    TB17=TB17.Text,
                    TB18=TB18.Text,
                    TB19=TB19.Text,
                    TB20=TB20.Text,
                    img1=img1.Text,
                    img2=img2.Text,
                    img3=img3.Text,
                    img4=img4.Text,
                    img5=img5.Text,
                    img6=img6.Text,
                    img7=img7.Text,
                    img8=img8.Text,
                    img9=img9.Text,
                    img10=img10.Text,


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
                string filepath="";
                
            }
#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS0612 // Type or member is obsolete
            if (Device.OS == TargetPlatform.Android)
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0618 // Type or member is obsolete
            {
                
            }

            DraftFields account=JsonConvert.DeserializeObject<DraftFields>(FileText);
            txt_name.Text=account.Name1;
            txt_projname.Text=account.ProjectName;
            txt_sitename.Text=account.SiteName;
            datepicker.Date=Convert.ToDateTime(account.date);
            txt_Description.Text=account.Desc;
            if (account.CB11 == "1") { CB11.Checked=true; } else { CB11.Checked=false; }
            if (account.CB12 == "1") { CB12.Checked=true; } else { CB12.Checked=false; }
            if (account.CB13 == "1") { CB13.Checked=true; } else { CB13.Checked=false; }
            if (account.CB21 == "1") { CB21.Checked=true; } else { CB21.Checked=false; }
            if (account.CB22 == "1") { CB22.Checked=true; } else { CB22.Checked=false; }
            if (account.CB23 == "1") { CB23.Checked=true; } else { CB23.Checked=false; }
            if (account.CB31 == "1") { CB31.Checked=true; } else { CB31.Checked=false; }
            if (account.CB32 == "1") { CB32.Checked=true; } else { CB32.Checked=false; }
            if (account.CB33 == "1") { CB33.Checked=true; } else { CB33.Checked=false; }
            if (account.CB41 == "1") { CB41.Checked=true; } else { CB41.Checked=false; }
            if (account.CB42 == "1") { CB42.Checked=true; } else { CB42.Checked=false; }
            if (account.CB43 == "1") { CB43.Checked=true; } else { CB43.Checked=false; }
            if (account.CB51 == "1") { CB51.Checked=true; } else { CB51.Checked=false; }
            if (account.CB52 == "1") { CB52.Checked=true; } else { CB52.Checked=false; }
            if (account.CB53 == "1") { CB53.Checked=true; } else { CB53.Checked=false; }
            if (account.CB61 == "1") { CB61.Checked=true; } else { CB61.Checked=false; }
            if (account.CB62 == "1") { CB62.Checked=true; } else { CB62.Checked=false; }
            if (account.CB63 == "1") { CB63.Checked=true; } else { CB63.Checked=false; }
            if (account.CB71 == "1") { CB71.Checked=true; } else { CB71.Checked=false; }
            if (account.CB72 == "1") { CB72.Checked=true; } else { CB72.Checked=false; }
            if (account.CB73 == "1") { CB73.Checked=true; } else { CB73.Checked=false; }
            if (account.CB81 == "1") { CB81.Checked=true; } else { CB81.Checked=false; }
            if (account.CB82 == "1") { CB82.Checked=true; } else { CB82.Checked=false; }
            if (account.CB83 == "1") { CB83.Checked=true; } else { CB83.Checked=false; }
            if (account.CB91 == "1") { CB91.Checked=true; } else { CB91.Checked=false; }
            if (account.CB92 == "1") { CB92.Checked=true; } else { CB92.Checked=false; }
            if (account.CB93 == "1") { CB93.Checked=true; } else { CB93.Checked=false; }
            if (account.CB101 == "1") { CB101.Checked=true; } else { CB101.Checked=false; }
            if (account.CB102 == "1") { CB102.Checked=true; } else { CB102.Checked=false; }
            if (account.CB103 == "1") { CB103.Checked=true; } else { CB103.Checked=false; }
            if (account.CB111 == "1") { CB111.Checked=true; } else { CB111.Checked=false; }
            if (account.CB112 == "1") { CB112.Checked=true; } else { CB112.Checked=false; }
            if (account.CB113 == "1") { CB113.Checked=true; } else { CB113.Checked=false; }
            if (account.CB121 == "1") { CB121.Checked=true; } else { CB121.Checked=false; }
            if (account.CB122 == "1") { CB122.Checked=true; } else { CB122.Checked=false; }
            if (account.CB123 == "1") { CB123.Checked=true; } else { CB123.Checked=false; }
            if (account.CB131 == "1") { CB131.Checked=true; } else { CB131.Checked=false; }
            if (account.CB132 == "1") { CB132.Checked=true; } else { CB132.Checked=false; }
            if (account.CB133 == "1") { CB133.Checked=true; } else { CB133.Checked=false; }
            if (account.CB141 == "1") { CB141.Checked=true; } else { CB141.Checked=false; }
            if (account.CB142 == "1") { CB142.Checked=true; } else { CB142.Checked=false; }
            if (account.CB143 == "1") { CB143.Checked=true; } else { CB143.Checked=false; }
            if (account.CB151 == "1") { CB151.Checked=true; } else { CB151.Checked=false; }
            if (account.CB161 == "1") { CB161.Checked=true; } else { CB161.Checked=false; }
            if (account.CB162 == "1") { CB162.Checked=true; } else { CB162.Checked=false; }
            if (account.CB163 == "1") { CB163.Checked=true; } else { CB163.Checked=false; }
            if (account.CB171 == "1") { CB171.Checked=true; } else { CB171.Checked=false; }
            if (account.CB172 == "1") { CB172.Checked=true; } else { CB172.Checked=false; }
            if (account.CB173 == "1") { CB173.Checked=true; } else { CB173.Checked=false; }
            if (account.CB181 == "1") { CB181.Checked=true; } else { CB181.Checked=false; }
            if (account.CB182 == "1") { CB182.Checked=true; } else { CB182.Checked=false; }
            if (account.CB183 == "1") { CB183.Checked=true; } else { CB183.Checked=false; }
            if (account.CB191 == "1") { CB191.Checked=true; } else { CB191.Checked=false; }
            if (account.CB192 == "1") { CB192.Checked=true; } else { CB192.Checked=false; }
            if (account.CB193 == "1") { CB193.Checked=true; } else { CB193.Checked=false; }
            TB1.Text=account.TB1;
            TB2.Text=account.TB2;
            TB3.Text=account.TB3;
            TB4.Text=account.TB4;
            TB5.Text=account.TB5;
            TB6.Text=account.TB6;
            TB7.Text=account.TB7;
            TB8.Text=account.TB8;
            TB9.Text=account.TB9;
            TB10.Text=account.TB10;
            TB11.Text=account.TB11;
            TB12.Text=account.TB12;
            TB13.Text=account.TB13;
            TB14.Text=account.TB14;
            TB15.Text=account.TB15;
            TB16.Text=account.TB16;
            TB17.Text=account.TB17;
            TB18.Text=account.TB18;
            TB19.Text=account.TB19;
            TB20.Text=account.TB20;
            img1.Text=account.img1;
            img2.Text=account.img2;
            img3.Text=account.img3;
            img4.Text=account.img4;
            img5.Text=account.img5;
            img6.Text=account.img6;
            img7.Text=account.img7;
            img8.Text=account.img8;
            img9.Text=account.img9;
            img10.Text=account.img10;

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
                ActImg.Text="1";
                Image1.Source=img1.Text;
            }

        }
        #endregion


        public class DraftFields
        {
            public string Name1 { get; set; }
            public string ProjectName { get; set; }
            public string SiteName { get; set; }
            public string date { get; set; }
            public string Desc { get; set; }
            public string CB11 { get; set; }
            public string CB12 { get; set; }
            public string CB13 { get; set; }
            public string CB21 { get; set; }
            public string CB22 { get; set; }
            public string CB23 { get; set; }
            public string CB31 { get; set; }
            public string CB32 { get; set; }
            public string CB33 { get; set; }
            public string CB41 { get; set; }
            public string CB42 { get; set; }
            public string CB43 { get; set; }
            public string CB51 { get; set; }
            public string CB52 { get; set; }
            public string CB53 { get; set; }
            public string CB61 { get; set; }
            public string CB62 { get; set; }
            public string CB63 { get; set; }
            public string CB71 { get; set; }
            public string CB72 { get; set; }
            public string CB73 { get; set; }
            public string CB81 { get; set; }
            public string CB82 { get; set; }
            public string CB83 { get; set; }
            public string CB91 { get; set; }
            public string CB92 { get; set; }
            public string CB93 { get; set; }
            public string CB101 { get; set; }
            public string CB102 { get; set; }
            public string CB103 { get; set; }
            public string CB111 { get; set; }
            public string CB112 { get; set; }
            public string CB113 { get; set; }
            public string CB121 { get; set; }
            public string CB122 { get; set; }
            public string CB123 { get; set; }
            public string CB131 { get; set; }
            public string CB132 { get; set; }
            public string CB133 { get; set; }
            public string CB141 { get; set; }
            public string CB142 { get; set; }
            public string CB143 { get; set; }
            public string CB151 { get; set; }
            public string CB161 { get; set; }
            public string CB162 { get; set; }
            public string CB163 { get; set; }
            public string CB171 { get; set; }
            public string CB172 { get; set; }
            public string CB173 { get; set; }
            public string CB181 { get; set; }
            public string CB182 { get; set; }
            public string CB183 { get; set; }
            public string CB191 { get; set; }
            public string CB192 { get; set; }
            public string CB193 { get; set; }
            public string TB1 { get; set; }
            public string TB2 { get; set; }
            public string TB3 { get; set; }
            public string TB4 { get; set; }
            public string TB5 { get; set; }
            public string TB6 { get; set; }
            public string TB7 { get; set; }
            public string TB8 { get; set; }
            public string TB9 { get; set; }
            public string TB10 { get; set; }
            public string TB11 { get; set; }
            public string TB12 { get; set; }
            public string TB13 { get; set; }
            public string TB14 { get; set; }
            public string TB15 { get; set; }
            public string TB16 { get; set; }
            public string TB17 { get; set; }
            public string TB18 { get; set; }
            public string TB19 { get; set; }
            public string TB20 { get; set; }
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
                fileText=value;
                OnPropertyChanged();
            }
        }


        //        protected void chkbx1_CheckedChanged(object sender, EventArgs e)
        //        {
        //            if (chkbx1.IsChecked == true)
        //            {
        //                chkbx2.IsChecked=false;
        //            }
        //            if (chkbx2.IsChecked == true)
        //            {
        //                chkbx1.IsChecked=false;
        //            }

        //        }

        //        protected void chkbx2_CheckedChanged(object sender, EventArgs e)
        //        {
        //            if (chkbx2.IsChecked == true)
        //            {
        //                chkbx1.IsChecked=false;
        //            }
        //            if (chkbx1.IsChecked == true)
        //            {
        //                chkbx2.IsChecked=false;
        //            }

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

        private void CB11_CheckedChanged(object sender, EventArgs e)
        {
            Controls.CheckText a = (Controls.CheckText)sender;
        }

        private void CB11_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
    