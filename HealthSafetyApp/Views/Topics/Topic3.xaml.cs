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
    public partial class Topic3 : ContentPage
    {
        private string fileText;
        int a_up, b_up, c_up, a_low, b_low, c_low, a_new, b_new, c_new, a_new1, b_new1, c_new1, a_new2, b_new2, c_new2 = 0;
        string c_up_color;
        string c_low_color;
        string c_new_color;
        string c_new1_color;
        int count = 0;
        
        Picker pck;
        private string filname;
        int img_count;


        public Topic3(string filenam)
        {
            InitializeComponent();
            filname = filenam;           
            this.Title = "Workstation assessment Tool";
#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS0612 // Type or member is obsolete
            if (Device.OS == TargetPlatform.Windows)
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0618 // Type or member is obsolete
            {
                this.BackgroundColor = Xamarin.Forms.Color.White;
            }
            chkbx2.IsChecked = false;
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
#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS0612 // Type or member is obsolete
            if (Device.OS == TargetPlatform.Android)
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0618 // Type or member is obsolete
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("<header class='headerdiv'>");



                sb.Append("</div>");
                sb.Append("</header>");
                sb.Append("<main>");

                sb.Append(@"<table border = '0' width = '100%'><tbody>
<tr>
<td colspan='10' bgcolor='gray' align='Center'>
<font color='white'><h3><b>Work Station Assessment</b></h3></font></center>
</td></tr>

<tr>
<td colspan='10' bgcolor='silver' align='right'>
<p style='color:#ffffff;font-size:5px;'><i>Created using Work station assessment tool © @The Health And Safety App </i></p>
</td>

</tr>

<tr>
<td colspan='10' bgcolor='White' align='Center'>
<font color='gray'><h6>This questionnaire will enable you to carry out an assessment of your workstation.The information provide will help us to ensure your comfort and safety at work.Answer that best describes your opinion of each of the questions listed</h6></font></center>
</td>

</tr>

<tr>
<td colspan='10' rowspan='1'><font color='#3399ff'> Name of assessor: </font></td>
</tr>

<tr>
<td colspan='10' rowspan='1'>" + txt_name.Text + @"</td>
</tr>
<tr>
<td colspan='10' rowspan='1'><font color='#3399ff'> Department: </font></td>
</tr>
<tr>
<td colspan='10' rowspan='1'>" + txt_projname.Text + @" </td>
</tr>
<tr>
<td colspan='10' rowspan='1'> <font color='#3399ff'>Workstation location/ identification: </font></td>
</tr>
<tr>
<td colspan='10' rowspan='1'> " + txt_sitename.Text + @" </td>
</tr>
<tr>
<td colspan='10' rowspan='1'><font color='#3399ff'> Date: </font></td>
</tr>
<tr>
<td colspan='10' rowspan='1'> " + dat + @" </td>
</tr>

<br/><br/>
<hr>


<tr>
<td colspan='2' rowspan='1' bgcolor='#3399ff'><font color='white' >1.1 Space</font> </td>
<td colspan='8' rowspan='1' ><font color='#3399ff'>Describe the space around your workstation(i.e.not the size of the desk)?</font> </td>
</tr>

<tr>
<td colspan='2' rowspan='1' >
<td colspan='8' rowspan='1'> " + Cmb_Space.SelectedItem  + @" </td>
</tr>

<tr>
<td colspan='2' rowspan='1' bgcolor='#3399ff'><font color='white' >1.2 Lighting </font> </td>
<td colspan='8' rowspan='1' ><font color='#3399ff'>How bright is the lighting at your workstation?</font> </td>
</tr>

<tr>
<td colspan='2' rowspan='1' >
<td colspan='8' rowspan='1'> " + Cmb_light.SelectedItem + @" </td>
</tr>

<tr>
<td colspan='2' rowspan='1' bgcolor='#3399ff'><font color='white' >1.3 Control </font> </td>
<td colspan='8' rowspan='1' ><font color='#3399ff'>What control do you have over local lighting (switching lights on or off, opening/closing blinds or curtains)?</font> </td>
</tr>

<tr>
<td colspan='2' rowspan='1' >
<td colspan='8' rowspan='1'> " + Cmb_ControlLight.SelectedItem + @" </td>
</tr>

<tr>
<td colspan='2' rowspan='1' bgcolor='#3399ff'><font color='white' >1.4 Refelection & Glare </font> </td>
<td colspan='8' rowspan='1' ><font color='#3399ff'>Do you get distracting reflections on your screen?</font> </td>
</tr>

<tr>
<td colspan='2' rowspan='1' >
<td colspan='8' rowspan='1'> " + Cmb_Reflection.SelectedItem + @" </td>
</tr>

<tr>
<td colspan='2' rowspan='1' bgcolor='#3399ff'><font color='white' >1.5 Noise </font> </td>
<td colspan='8' rowspan='1' ><font color='#3399ff'>Are you distracted by noise from work equipment?</font> </td>
</tr>

<tr>
<td colspan='2' rowspan='1' >
<td colspan='8' rowspan='1'> " + Cmb_Noise.SelectedItem + @" </td>
</tr>

<tr>
<td colspan='2' rowspan='1' bgcolor='#3399ff'><font color='white' >1.6 Temperature </font> </td>
<td colspan='8' rowspan='1' ><font color='#3399ff'>At your workstation, is it usually ? </font> </td>
</tr>

<tr>
<td colspan='2' rowspan='1' >
<td colspan='8' rowspan='1'> " + Cmb_temp.SelectedItem + @" </td>
</tr>

<tr>
<td colspan='2' rowspan='1' bgcolor='#3399ff'><font color='white' >1.7 Humidity </font> </td>
<td colspan='8' rowspan='1' ><font color='#3399ff'>Is the air around your workstation? </font> </td>
</tr>

<tr>
<td colspan='2' rowspan='1' >
<td colspan='8' rowspan='1'> " + Cmb_Air.SelectedItem + @" </td>
</tr>

                </table>

<br><br>

<table width='100%' bordercolor='gray'>
<tr border='1'>
<td colspan='2' rowspan='1' bgcolor='#3399ff'><font color='white'>2.1</font></td>
<td colspan='18' rowspan='1'><font color='#3399ff'>Display Screen</font></td>
</tr></table>
<hr style='border-top: 1px solid #3399ff; background: transparent;'>
<table width='100%'>
<tr bgcolor='LightGray'>
<td colspan='18' rowspan='1'><b>2.1.1</b>Can you easily adjust the brightness and contrast between the characters on screen?</td>
");
                if (Y11.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>

<tr bgcolor='WhiteSmoke'>
<td colspan='18' rowspan='1'><b>2.1.2</b>Can the screen be tilted and swivelled?</td>
");
                if (Y21.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>

<tr bgcolor='LightGray'>
<td colspan='18' rowspan='1'><b>2.1.3</b>Is the screen image stable and free of flicker and other persistent instabilities?</td>
");
                if (Y31.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>

<tr bgcolor='WhiteSmoke'>
<td colspan='18' rowspan='1'><b>2.1.4</b>Is the screen at a height that is comfortable for you?</td>
");
                if (Y41.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>


</table>

<br>

<table width='100%'>
<tr border='1'>
<td colspan='2' rowspan='1' bgcolor='#3399ff'><font color='white'>2.2</font></td>
<td colspan='18' rowspan='1'><font color='#3399ff'>Keyboard</font></td>
</tr></table>

<table width='100%'>
<tr bgcolor='LightGray'>
<td colspan='18' rowspan='1'><b>2.2.1</b>Can you easily adjust the brightness and contrast between the characters on screen?</td>
");
                if (Y12.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>

<tr bgcolor='WhiteSmoke'>
<td colspan='18' rowspan='1'><b>2.2.2</b>Can you easily see the symbols on the keys?</td>
");
                if (Y22.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>

<tr bgcolor='LightGray'>
<td colspan='18' rowspan='1'><b>2.2.3</b>Is there enough space to rest your hands in front of the keyboard?</td>
");
                if (Y32.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>
</table>

<br>

<table width='100%'>
<tr border='1'>
<td colspan='2' rowspan='1' bgcolor='#3399ff'><font color='white'>2.3</font></td>
<td colspan='18' rowspan='1'><font color='#3399ff'>Chair</font></td>
</tr></table>

<table width='100%'>
<tr bgcolor='LightGray'>
<td colspan='18' rowspan='1'><b>2.3.1</b>Can you adjust the height of the seat?</td>
");
                if (Y13.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>

<tr bgcolor='WhiteSmoke'>
<td colspan='18' rowspan='1'><b>2.3.2</b>Can you adjust the height and angle of the backrest?</td>
");
                if (Y23.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>

<tr bgcolor='LightGray'>
<td colspan='18' rowspan='1'><b>2.3.3</b>Is the chair comfortable?</td>
");
                if (Y33.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>

<tr bgcolor='WhiteSmoke'>
<td colspan='18' rowspan='1'><b>2.3.4</b>Is the chair in a good state of repair?</td>
");
                if (Y43.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>


</table>

<br>
<table width='100%'>
<tr border='1'>
<td colspan='2' rowspan='1' bgcolor='#3399ff'><font color='white'>2.4</font></td>
<td colspan='18' rowspan='1'><font color='#3399ff'>Desk</font></td>
</tr></table>

<table width='100%'>
<tr bgcolor='LightGray'>
<td colspan='18' rowspan='1'><b>2.4.1</b>Is the desk surface large enough to allow you to place all your equipment where you want it?</td>
");
                if (Y14.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>

<tr bgcolor='WhiteSmoke'>
<td colspan='18' rowspan='1'><b>2.4.2</b>Is the height of the desk suitable?</td>
");
                if (Y24.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>

</table>

<br>
<table width='100%'>
<tr border='1'>
<td colspan='2' rowspan='1' bgcolor='#3399ff'><font color='white'>2.5</font></td>
<td colspan='18' rowspan='1'><font color='#3399ff'>Footrest</font></td>
</tr></table>

<table width='100%'>
<tr bgcolor='LightGray'>
<td colspan='18' rowspan='1'><b>2.5.1</b>If you cannot place your feet flat on the floor whilst keying, has a footrest been supplied?</td>
");
                if (Y15.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>


</table>
<br>
<table width='100%'>
<tr border='1'>
<td colspan='2' rowspan='1' bgcolor='#3399ff'><font color='white'>2.6</font></td>
<td colspan='18' rowspan='1'><font color='#3399ff'>Document Holder</font></td>
</tr></table>

<table width='100%'>
<tr bgcolor='LightGray'>
<td colspan='18' rowspan='1'><b>2.6.1</b>If it would be of benefit to use a document holder, has one been supplied?</td>
");
                if (Y16.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>

<tr bgcolor='WhiteSmoke'>
<td colspan='18' rowspan='1'><b>2.6.2</b>If you have document holder, is it adjustable to suit your needs?</td>
");
                if (Y26.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>

</table>

<br>
<table width='100%'>
<tr border='1'>
<td colspan='2' rowspan='1' bgcolor='#3399ff'><font color='white'>2.7</font></td>
<td colspan='18' rowspan='1'><font color='#3399ff'>Training / Information</font></td>
</tr></table>

<table width='100%'>
<tr bgcolor='LightGray'>
<td colspan='18' rowspan='1'><b>2.7.1</b>Have you been informed about the risks associated with workstation equipment and how to reduce the risks?</td>
");
                if (Y17.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>

<tr bgcolor='WhiteSmoke'>
<td colspan='18' rowspan='1'><b>2.7.2</b>Have you been informed about the arrangements to provide breaks and activity changes?</td>
");
                if (Y27.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>

<tr bgcolor='LightGray'>
<td colspan='18' rowspan='1'><b>2.7.3</b>Have you been informed about the arrangements for the provision of eye and eyesight tests?</td>
");
                if (Y37.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>

<tr bgcolor='WhiteSmoke'>
<td colspan='18' rowspan='1'><b>2.7.4</b>Do you know the procedures to follow if you have a problem relating to workstation equipment?</td>
");
                if (Y47.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>

<tr bgcolor='LightGray'>
<td colspan='18' rowspan='1'><b>2.7.5</b>Have you been informed in the correct adjustment and positioning of workstation equipment?</td>
");
                if (Y57.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>

<tr bgcolor='WhiteSmoke'>
<td colspan='18' rowspan='1'><b>2.7.6</b>Have you been informed about the importance of good posture?</td>
");
                if (Y67.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>

<tr bgcolor='LightGray'>
<td colspan='18' rowspan='1'><b>2.7.7</b>Do you know how to adjust screen brightness and contrast?</td>
");
                if (Y77.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>

<tr bgcolor='WhiteSmoke'>
<td colspan='18' rowspan='1'><b>2.7.8</b>Do you know how to recognise visual or postural fatigue and the action to take?</td>
");
                if (Y87.IsChecked) { sb.Append(@"<td colspan='2' rowspan='1'><b>Yes</b></td>"); }
                else { sb.Append(@"<td colspan='2' rowspan='1'><b>No</b></td>"); }


                sb.Append(@"
</tr>

</table>
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
                
                sb.Append("</main> ");

                StringReader sr = new StringReader(sb.ToString());

                
            }
           
            txt_name.Text = txt_projname.Text = txt_sitename.Text = "";


        }

        private void CC_Checked(object sender, EventArgs e)
        {
            var a = (CheckBox)sender;

            
          var  b= (CheckBox)Y11;
            if (a.Equals(N11)) {b =(CheckBox) Y11;}
            if (a.Equals(Y11)) { b = (CheckBox)N11; }

         if (a.Equals(N21)) { b = (CheckBox)Y21; }
         if (a.Equals(Y21)) { b = (CheckBox)N21; }

         if (a.Equals(N31)) { b = (CheckBox)Y31; }
         if (a.Equals(Y31)) { b = (CheckBox)N31; }

         if (a.Equals(N41)) { b = (CheckBox)Y41; }
         if (a.Equals(Y41)) { b = (CheckBox)N41; }
                                  
         if (a.Equals(N12)) { b = (CheckBox)Y12; }
         if (a.Equals(Y12)) { b = (CheckBox)N12; }
                                  
         if (a.Equals(N22)) { b = (CheckBox)Y22; }
         if (a.Equals(Y22)) { b = (CheckBox)N22; }
                                   
         if (a.Equals(N32)) { b = (CheckBox)Y32; }
         if (a.Equals(Y32)) { b = (CheckBox)N32; }
                                   
         if (a.Equals(N13)) { b = (CheckBox)Y13; }
         if (a.Equals(Y13)) { b = (CheckBox)N13; }
                                   
         if (a.Equals(N23)) { b = (CheckBox)Y23; }
         if (a.Equals(Y23)) { b = (CheckBox)N23; }
                                   
         if (a.Equals(N33)) { b = (CheckBox)Y33; }
         if (a.Equals(Y33)) { b = (CheckBox)N33; }
                                   
         if (a.Equals(N43)) { b = (CheckBox)Y43; }
         if (a.Equals(Y43)) { b = (CheckBox)N43; }
                                   
         if (a.Equals(N14)) { b = (CheckBox)Y14; }
         if (a.Equals(Y14)) { b = (CheckBox)N14; }
                                   
         if (a.Equals(N24)) { b = (CheckBox)Y24; }
         if (a.Equals(Y24)) { b = (CheckBox)N24; }
                                   
         if (a.Equals(N15)) { b = (CheckBox)Y15; }
         if (a.Equals(Y15)) { b = (CheckBox)N15; }
                                   
         if (a.Equals(N16)) { b = (CheckBox)Y16; }
         if (a.Equals(Y16)) { b = (CheckBox)N16; }
                                   
         if (a.Equals(N26)) { b = (CheckBox)Y26; }
         if (a.Equals(Y26)) { b = (CheckBox)N26; }
                                   
         if (a.Equals(N17)) { b = (CheckBox)Y17; }
         if (a.Equals(Y17)) { b = (CheckBox)N17; }
                                   
         if (a.Equals(N27)) { b = (CheckBox)Y27; }
         if (a.Equals(Y27)) { b = (CheckBox)N27; }
                                   
         if (a.Equals(N37)) { b = (CheckBox)Y37; }
         if (a.Equals(Y37)) { b = (CheckBox)N37; }
                                   
         if (a.Equals(N47)) { b = (CheckBox)Y47; }
         if (a.Equals(Y47)) { b = (CheckBox)N47; }
                                   
         if (a.Equals(N57)) { b = (CheckBox)Y57; }
         if (a.Equals(Y57)) { b = (CheckBox)N57; }
                                   
         if (a.Equals(N67)) { b = (CheckBox)Y67; }
         if (a.Equals(Y67)) { b = (CheckBox)N67; }
                                   
         if (a.Equals(N77)) { b = (CheckBox)Y77; }
         if (a.Equals(Y77)) { b = (CheckBox)N77; }
                                   
         if (a.Equals(N87)) { b = (CheckBox)Y87; }
         if (a.Equals(Y87)) { b = (CheckBox)N87; }

          if (a.IsChecked == true)
            {
                b.IsChecked = false;
            }
            if (b.IsChecked == true)
            {
                a.IsChecked = false;
            }

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
                    SiteName = txt_sitename.Text,
                    date = dat,
                    CheckBox1data = txt_Check1_text.Text,
                    //CheckBox2data = txt_Check2_text.Text,


                };
                string jsonContents = JsonConvert.SerializeObject(s);
             
                
                txt_name.Text = txt_projname.Text = txt_sitename.Text = txt_Check1_text.Text = txt_Check2_text.Text = "";
                chkbx1.IsChecked = chkbx2.IsChecked = false;
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
                    SiteName = txt_sitename.Text,
                    date = dat,
                    CheckBox1data = txt_Check1_text.Text,
                    CheckBox2data = txt_Check2_text.Text,
                    cmb_space = Cmb_Space.Items[Cmb_Space.SelectedIndex],
                    cmb_light = Cmb_light.Items[Cmb_light.SelectedIndex],
                    cmb_ControlLight = Cmb_ControlLight.Items[Cmb_ControlLight.SelectedIndex],
                    cmb_reflection = Cmb_Reflection.Items[Cmb_Reflection.SelectedIndex],
                    cmb_noise = Cmb_Noise.Items[Cmb_Noise.SelectedIndex],
                    cmb_temp = Cmb_temp.Items[Cmb_temp.SelectedIndex],
                    cmb_air = Cmb_Air.Items[Cmb_Air.SelectedIndex],
                    y11 = Y11.IsChecked? "1": "0",
                    N11 = N11.IsChecked ? "1" : "0",
                    y21 = Y21.IsChecked ? "1" : "0",
                    N21 = N21.IsChecked ? "1" : "0",
                    y31 = Y31.IsChecked ? "1" : "0",
                    N31 = N31.IsChecked ? "1" : "0",
                    y41 = Y41.IsChecked ? "1" : "0",
                    N41 = N41.IsChecked ? "1" : "0",

                    y12 = Y12.IsChecked ? "1" : "0",
                    N12 = N12.IsChecked ? "1" : "0",
                    y22 = Y22.IsChecked ? "1" : "0",
                    N22 = N22.IsChecked ? "1" : "0",
                    y32 = Y32.IsChecked ? "1" : "0",
                    N32 = N32.IsChecked ? "1" : "0",

                    y13 = Y13.IsChecked ? "1" : "0",
                    N13 = N13.IsChecked ? "1" : "0",
                    y23 = Y23.IsChecked ? "1" : "0",
                    N23 = N23.IsChecked ? "1" : "0",
                    y33 = Y33.IsChecked ? "1" : "0",
                    N33 = N33.IsChecked ? "1" : "0",
                    y43 = Y43.IsChecked ? "1" : "0",
                    N43 = N43.IsChecked ? "1" : "0",

                    y14 = Y14.IsChecked ? "1" : "0",
                    N14 = N14.IsChecked ? "1" : "0",
                    y24 = Y24.IsChecked ? "1" : "0",
                    N24 = N24.IsChecked ? "1" : "0",

                    y15 = Y15.IsChecked ? "1" : "0",
                    N15 = N15.IsChecked ? "1" : "0",

                    y16 = Y16.IsChecked ? "1" : "0",
                    N16 = N16.IsChecked ? "1" : "0",
                    y26 = Y26.IsChecked ? "1" : "0",
                    N26 = N26.IsChecked ? "1" : "0",

                    y17 = Y17.IsChecked ? "1" : "0",
                    N17 = N17.IsChecked ? "1" : "0",
                    y27 = Y27.IsChecked ? "1" : "0",
                    N27 = N27.IsChecked ? "1" : "0",
                    y37 = Y37.IsChecked ? "1" : "0",
                    N37 = N37.IsChecked ? "1" : "0",
                    y47 = Y47.IsChecked ? "1" : "0",
                    N47 = N47.IsChecked ? "1" : "0",
                    y57 = Y57.IsChecked ? "1" : "0",
                    N57 = N57.IsChecked ? "1" : "0",
                    y67 = Y67.IsChecked ? "1" : "0",
                    N67 = N67.IsChecked ? "1" : "0",
                    y77 = Y77.IsChecked ? "1" : "0",
                    N77 = N77.IsChecked ? "1" : "0",
                    y87 = Y87.IsChecked ? "1" : "0",
                    N87 = N87.IsChecked ? "1" : "0",
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


            DraftFields account = JsonConvert.DeserializeObject<DraftFields>(FileText);
            txt_name.Text = account.Name1;
            txt_projname.Text = account.ProjectName;
            txt_sitename.Text = account.SiteName;
            datepicker.Date = Convert.ToDateTime(account.date);
            txt_Check1_text.Text = account.CheckBox1data;
            txt_Check2_text.Text = account.CheckBox2data;
            if (account.CheckBox1data != null)
            { chkbx1.IsChecked = true; }
            txt_Check2_text.Text = account.CheckBox2data;
            if (account.CheckBox2data != null)
            { chkbx2.IsChecked = true; }

                    
            Cmb_Space.SelectedItem = account.cmb_space;
            Cmb_light.SelectedItem = account.cmb_light;
            Cmb_ControlLight.SelectedItem = account.cmb_ControlLight;
            Cmb_Reflection.SelectedItem = account.cmb_reflection;
            Cmb_Noise.SelectedItem = account.cmb_noise;
            Cmb_temp.SelectedItem = account.cmb_temp;
            Cmb_Air.SelectedItem = account.cmb_air;


            if (account.y11 == "1") { Y11.IsChecked  = true; } else { Y11.IsChecked = false; }
            if (account.N11 == "1") { N11.IsChecked = true; } else { N11.IsChecked = false; }
            if (account.y21 == "1") { Y21.IsChecked = true; } else { Y21.IsChecked = false; }
            if (account.N21 == "1") { N21.IsChecked = true; } else { N21.IsChecked = false; }
            if (account.y31 == "1") { Y31.IsChecked = true; } else { Y31.IsChecked = false; }
            if (account.N31 == "1") { N31.IsChecked = true; } else { N31.IsChecked = false; }
            if (account.y41 == "1") { Y41.IsChecked = true; } else { Y41.IsChecked = false; }
            if (account.N41 == "1") { N41.IsChecked = true; } else { N41.IsChecked = false; }

            if (account.y12 == "1") { Y12.IsChecked = true; } else { Y12.IsChecked = false; }
            if (account.N12 == "1") { N12.IsChecked = true; } else { N12.IsChecked = false; }
            if (account.y22 == "1") { Y22.IsChecked = true; } else { Y22.IsChecked = false; }
            if (account.N22 == "1") { N22.IsChecked = true; } else { N22.IsChecked = false; }
            if (account.y32 == "1") { Y32.IsChecked = true; } else { Y32.IsChecked = false; }
            if (account.N32 == "1") { N32.IsChecked = true; } else { N32.IsChecked = false; }

            if (account.y13 == "1") { Y13.IsChecked = true; } else { Y13.IsChecked = false; }
            if (account.N13 == "1") { N13.IsChecked = true; } else { N13.IsChecked = false; }
            if (account.y23 == "1") { Y23.IsChecked = true; } else { Y23.IsChecked = false; }
            if (account.N23 == "1") { N23.IsChecked = true; } else { N23.IsChecked = false; }
            if (account.y33 == "1") { Y33.IsChecked = true; } else { Y33.IsChecked = false; }
            if (account.N33 == "1") { N33.IsChecked = true; } else { N33.IsChecked = false; }
            if (account.y43 == "1") { Y43.IsChecked = true; } else { Y43.IsChecked = false; }
            if (account.N43 == "1") { N43.IsChecked = true; } else { N43.IsChecked = false; }

            if (account.y14 == "1") { Y14.IsChecked = true; } else { Y14.IsChecked = false; }
            if (account.N14 == "1") { N14.IsChecked = true; } else { N14.IsChecked = false; }
            if (account.y24 == "1") { Y24.IsChecked = true; } else { Y24.IsChecked = false; }
            if (account.N24 == "1") { N24.IsChecked = true; } else { N24.IsChecked = false; }

            if (account.y15 == "1") { Y15.IsChecked = true; } else { Y15.IsChecked = false; }
            if (account.N15 == "1") { N15.IsChecked = true; } else { N15.IsChecked = false; }

            if (account.y16 == "1") { Y16.IsChecked = true; } else { Y16.IsChecked = false; }
            if (account.N16 == "1") { N16.IsChecked = true; } else { N16.IsChecked = false; }
            if (account.y26 == "1") { Y26.IsChecked = true; } else { Y26.IsChecked = false; }
            if (account.N26 == "1") { N26.IsChecked = true; } else { N26.IsChecked = false; }

            if (account.y17 == "1") { Y17.IsChecked = true; } else { Y17.IsChecked = false; }
            if (account.N17 == "1") { N17.IsChecked = true; } else { N17.IsChecked = false; }
            if (account.y27 == "1") { Y27.IsChecked = true; } else { Y27.IsChecked = false; }
            if (account.N27 == "1") { N27.IsChecked = true; } else { N27.IsChecked = false; }
            if (account.y37 == "1") { Y37.IsChecked = true; } else { Y37.IsChecked = false; }
            if (account.N37 == "1") { N37.IsChecked = true; } else { N37.IsChecked = false; }
            if (account.y47 == "1") { Y47.IsChecked = true; } else { Y47.IsChecked = false; }
            if (account.N47 == "1") { N47.IsChecked = true; } else { N47.IsChecked = false; }
            if (account.y57 == "1") { Y57.IsChecked = true; } else { Y57.IsChecked = false; }
            if (account.N57 == "1") { N57.IsChecked = true; } else { N57.IsChecked = false; }
            if (account.y67 == "1") { Y67.IsChecked = true; } else { Y67.IsChecked = false; }
            if (account.N67 == "1") { N67.IsChecked = true; } else { N67.IsChecked = false; }
            if (account.y77 == "1") { Y77.IsChecked = true; } else { Y77.IsChecked = false; }
            if (account.N77 == "1") { N77.IsChecked = true; } else { N77.IsChecked = false; }
            if (account.y87 == "1") { Y87.IsChecked = true; } else { Y87.IsChecked = false; }
            if (account.N87 == "1") { N87.IsChecked = true; } else { N87.IsChecked = false; }


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
            public string CheckBox1data { get; set; }
            public string CheckBox2data { get; set; }
            public string cmb_space { get; set; }
            public string cmb_light { get; set; }
            public string cmb_ControlLight { get; set; }
            public string cmb_reflection { get; set; }
            public string cmb_noise { get; set; }
            public string cmb_temp { get; set; }
            public string cmb_air { get; set; }
            public string y11 { get; set; }
                    public string N11 { get; set; }
                    public string y21 { get; set; }
                    public string N21 { get; set; }
                    public string y31 { get; set; }
                    public string N31 { get; set; }
                    public string y41 { get; set; }
                    public string N41 { get; set; }

            public string y12 { get; set; }
            public string N12 { get; set; }
                    public string y22 { get; set; }
                    public string N22 { get; set; }
                    public string y32 { get; set; }
                    public string N32 { get; set; }

                    public string y13 { get; set; }
                    public string N13 { get; set; }
                    public string y23 { get; set; }
                    public string N23 { get; set; }
                    public string y33 { get; set; }
                    public string N33 { get; set; }
                    public string y43 { get; set; }
                    public string N43 { get; set; }

                    public string y14 { get; set; }
                    public string N14 { get; set; }
                    public string y24 { get; set; }
                    public string N24 { get; set; }

                    public string y15 { get; set; }
                    public string N15 { get; set; }

                    public string y16 { get; set; }
                    public string N16 { get; set; }
                    public string y26 { get; set; }
                    public string N26 { get; set; }

                    public string y17 { get; set; }
                    public string N17 { get; set; }
                    public string y27 { get; set; }
                    public string N27 { get; set; }
                    public string y37 { get; set; }
                    public string N37 { get; set; }
                    public string y47 { get; set; }
                    public string N47 { get; set; }
                    public string y57 { get; set; }
                    public string N57 { get; set; }
                    public string y67 { get; set; }
                    public string N67 { get; set; }
                    public string y77 { get; set; }
                    public string N77 { get; set; }
                    public string y87 { get; set; }
                    public string N87 { get; set; }
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
       

        protected void chkbx1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx1.IsChecked == true)
            {
                chkbx2.IsChecked = false;
            }
            if (chkbx2.IsChecked == true)
            {
                chkbx1.IsChecked = false;
            }

        }

        protected void chkbx2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx2.IsChecked == true)
            {
                chkbx1.IsChecked = false;
            }
            if (chkbx1.IsChecked == true)
            {
                chkbx2.IsChecked = false;
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

