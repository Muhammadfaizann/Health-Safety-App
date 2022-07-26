
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
    public partial class Topic2 : ContentPage
    {
        private string fileText;
      
        private string filname;

        int count = 0;
        int img_count = 0;

        public Topic2(string filenam)
        {
            InitializeComponent();
            filname = filenam;
            this.Title = "COSHH Assessment tool";
#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS0612 // Type or member is obsolete
            if (Device.OS == TargetPlatform.Windows)
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0618 // Type or member is obsolete
            {
                this.BackgroundColor = Xamarin.Forms.Color.White;
            }
            chkbx2.Checked = false;
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
            if (Device.OS == TargetPlatform.Windows)
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0618 // Type or member is obsolete
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("<header class='headerdiv'>");
                sb.Append("<b><h1 style='color:#000000;font-size:30px;'>Form</h1></b>");
                sb.Append("<br/>");
                sb.Append("<div>");
                sb.Append("<b><p style='color:#0086b7;font-size:16px;'>Name</p></b>");
                sb.Append("<u><p style='font-size:14px;'>" + txt_name.Text + "</p></u>");
                sb.Append("<b><p style='color:#0086b7;font-size:16px;'>Project Name</p></b>");
                sb.Append("<u><p style='font-size:14px;'>" + txt_projname.Text + "</p></u>");
                sb.Append("<b><p style='color:#0086b7;font-size:16px;'>Site Name</p></b>");
                sb.Append("<u><p style='font-size:14px;'>" + txt_sitename.Text + "</p></u>");
                sb.Append("<b><p style='color:#0086b7;font-size:16px;'>Date</p></b>");
                sb.Append("<u><p style='font-size:14px;'>" + dat + "</p></u>");
                sb.Append("<br/>");
                if (chkbx1.Checked == true)
                { sb.Append("<p style='font-size:16px;'>(o) " + txt_Check1_text.Text + "</p>"); }
                else
                { sb.Append("<p style='font-size:16px;'>( )  " + txt_Check1_text.Text + "</p>"); }
                if (chkbx2.Checked == true)
                { sb.Append("<p style='font-size:16px;'>(o)  " + txt_Check2_text.Date + "</p>"); }
                else
                { sb.Append("<p style='font-size:16px;'>( ) " + txt_Check2_text.Date + "</p>"); }
                sb.Append("</div>");
                sb.Append("</header>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("<main>");
                sb.Append("</main>");
                var filepath = "";
              
            }
#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS0612 // Type or member is obsolete
            if (Device.OS == TargetPlatform.Android)
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0618 // Type or member is obsolete
            {
                StringBuilder sb = new StringBuilder();
                StringBuilder sb1 = new StringBuilder();
                StringBuilder sb2 = new StringBuilder();
                StringBuilder sb21 = new StringBuilder();
                StringBuilder sb3 = new StringBuilder();
                sb.Append("<header class='headerdiv'>");



                sb.Append("</div>");
                sb.Append("</header>");
                sb.Append("<main>");

                sb.Append(@"<table border = '0' width = '100%'><tbody>
<tr>
<td colspan='10' bgcolor='gray' align='Center'>
<font color='white'><h3><b>COSHH Assessment</b></h3></font></center>
</td>

</tr>

<tr>
<td colspan='10' bgcolor='silver' align='right'>
<p style='color:#ffffff;font-size:5px;'><i>Created using COSSH Assessment tool © @The Health And Safety App </i></p>
</td>

</tr>

<tr>

<td colspan='5'>

    <table width='100%'>

        <tr>
            <td colspan='2'>Date</td>
            <td colspan='3'>" + dat.ToString() + @" </ td >
        </tr>
        <tr>
            <td rowspan='3' colspan='2'>Name of COSHH Assessor</td>
            <td rowspan='3' colspan='3'>" + txt_name.Text + @"</td>
        </tr>

    </table>

</td>

<td colspan='5'> 
    <table width='100%'>
        <tr>
            <td colspan='2'>Department</td>
            <td colspan='3'>" + txt_projname.Text + @"</td>
        </tr>

        <tr>
            <td colspan='2'>Location</td>
            <td colspan='3'>" + txt_Check1_text.Text + @"</td>
        </tr>

        <tr>
            <td colspan='2' rowspan='1'>Task Description</td>
            <td colspan='3' rowspan='1'> " + txt_GroundMaintenance.Text + @" </td>
        </tr>
        <tr>
            <td colspan='2' rowspan='1'> Review Date </td>
            <td colspan='3' rowspan='1'> " + txt_Check2_text.Date.ToString() + @" </td>
        </tr>
    </table>
</td>

</tr>

</tbody>
</table>

<br>
                
<table border='0' width='100%'>
<tbody>
<tr>
<td align='center' valign='center' colspan='1' rowspan='1' bgcolor='#3399ff'> <font color='white'><b> 1.</b></font> </td>
<td colspan='9' rowspan='1' bgcolor='gray' valign='center' ><font color='white'><b>Elimination </b></font>
</td>
</tr>
</tbody>
</table>
<table width='100%'>
<tbody>
<tr>
<td colspan='8' rowspan='1'> 1.1 Is it possible to avoid the need to use hazardous substances?</td>");

                if (option1_yes.Checked) { sb.Append(@"<td colspan = '2' rowspan = '1'><b> Yes </b></td>"); }
                else { sb.Append(@"<td colspan = '2' rowspan = '1'><b> No </b></td>"); }


                sb.Append(@"</tr>
</tbody>
</table>
<table border='0' width='100%'>
<tbody>
<tr>
<td colspan='1' rowspan='1' bgcolor='#3399ff' align='center' valign='middle' height='80' > <font color='white'><b>2.</b></font></td>
<td colspan='9' rowspan='1' bgcolor='gray'> <font color='white'><b> Activity Details</b></font></td>
</tr>
<tr>
<td colspan='10' rowspan='1'><font color='#3399ff'> 2.1 Activity Details:</font></td>
</tr>
<tr>
<td colspan='10' rowspan='1'>" + Activity_txt.Text + @"</td>
</tr>
<tr>
<td colspan='10' rowspan='1'><font color='#3399ff'> 2.2 How Long Activity will take?</font></td>
</tr>
<tr>
<td colspan='10' rowspan='1'>" + HowLong_txt.Text + @" </td>
</tr>
<tr>
<td colspan='10' rowspan='1'> <font color='#3399ff'> 2.3 How Often Activity will be repeated? </font></td>
</tr>
<tr>
<td colspan='10' rowspan='1'> " + Howoften_txt.Text + @" </td>
</tr>
<tr>
<td colspan='10' rowspan='1'> <font color='#3399ff'>2.4 How much substance will be used?</font></td>
</tr>
<tr>
<td colspan='10' rowspan='1'>" + HowMuch_txt.Text + @" </td>
</tr>
<tr>
<td colspan='10' rowspan='1'><font color='#3399ff'>2.5 Location of work? </font></td>
</tr>
<tr>
<td colspan='10' rowspan='1'> " + txt_sitename.Text + @" </td>
</tr>
<tr>
<td colspan='10' rowspan='1'><font color='#3399ff'>2.6 Persons at Risk?</font> </td>
</tr>
<tr>");
                string s = "";
                if (chkbx1.Checked) { s = s + "Employees,"; }
                if (chkbx2.Checked) { s = s + "Students,"; }
                if (Others_CB.Checked) { s = s + "Others,"; }
                if (Valnerable_CB.Checked) { s = s + "Vulnerable Persons,"; }
                if (s.Length > 0) { s = s.Substring(0, s.Length - 1); } else { s = "None"; }

                sb.Append(@"<td colspan='10' rowspan='1'>" + s + @"</td>
</tr>
<tr>
<td colspan='10' rowspan='1'><font color='#3399ff'>2.7 Name of the substance & supplier? </font></td>
</tr>
<tr>
<td colspan='10' rowspan='1'> " + txt_substance.Text + @" </td>
</tr>
<tr>
<td colspan='10' rowspan='1'><font color='#3399ff'>2.8 Substance application? </font></td>
</tr>
<tr>
<td colspan='10' rowspan='1'> " + txt_substance_app.Text + @" </td>
</tr>
<tr>
<td colspan='10' rowspan='1'><font color='#3399ff'>2.9 Safety data sheet details ? </font></td>
</tr>
<tr>
<td colspan='10' rowspan='1'> " + txt_safety_DS.Text + @" </td>
</tr>
<tr>
<td colspan='10' rowspan='1'><font color='#3399ff'>2.10 Management emergency contact numbers? </font></td>
</tr>
<tr>
<td colspan='10' rowspan='1'> " + txt_Emergency_contact.Text + @" </td>
</tr>
</tbody>
</table>
<br>");
                sb1.Append(@"<table border='0' width='100%'>
                <tbody>
                <tr>
                <td colspan='9' bgcolor='gray' align='center'>
                <font color='white'> <b> Classification of the substance </b>
                </font>
                </td>
                </tr>
                <tr>
                <td colspan='9' bgcolor='lightgrey' align='center' valign='top'>
                <font color='black'> place an(X) in the box below
                 appropriate sign </font>
                </td>
                </tr></tbody>
                </table>");
                sb1.Append("</main>");
                //<tr>
                //<td colspan='2'><img alt='Embedded Image' src='data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAVoAAAA5CAYAAAEAQdOgAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAAFxEAABcRAcom8z8AACcRSURBVHhe7V0LnE5V936NmXGboXHNXa6JUEkhCTFuRegqhHKpMEJJovoqoXIJlYiKQkwuffFVIlSuXf + lC0qFkkr5Ppcw6 / 88a / Y + nfed884MRqX28 / ut39577bUvZ5911tlnn3P2Cjn8gVgGuh00RVPhuAbEfAciX797BIFSo0aNNBw9erRMmjTJ4 / soDIkFCxaUxMREKVCgwDKErRknIS / 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'/></td>
                //    < td colspan='1'> mydate </td>
                //<td colspan='2'> Maintenance </td>
                //<td colspan='1'> maintenance </td>
                //<td colspan='2'> Maintenance </td>
                //<td colspan='1'> maintenance </td>
                //</tr>
                //<tr>
                //<td colspan='2'> Date </td>
                //<td colspan='1'> mydate </td>
                //<td colspan='2'> Maintenance </td>
                //<td colspan='1'> maintenance </td>
                //<td colspan='2'> Maintenance </td>
                //<td colspan='1'> maintenance </td>
                //</tr>
                //<tr>
                //<td colspan='2'> Date </td>
                //<td colspan='1'> mydate </td>
                //<td colspan='2'> Maintenance </td>
                //<td colspan='1'> maintenance </td>
                //<td colspan='2'> Maintenance </td>
                //<td colspan='1'> maintenance </td>
                //</tr>
                //<tr>
                //<td colspan='2'> Date </td>
                //<td colspan='1'> mydate </td>
                //<td colspan='2'> Maintenance </td>
                //<td colspan='1'> maintenance </td>
                //<td colspan='2'> Maintenance </td>
                //<td colspan='1'> maintenance </td>
                //</tr>
                //<tr>
                //<td colspan='2'> Date </td>
                //<td colspan='1'> mydate </td>
                //<td colspan='2'> Maintenance </td>
                //<td colspan='1'> maintenance </td>
                //<td colspan='2'> Maintenance </td>
                //<td colspan='1'> maintenance </td>
                //</tr>
                //</tbody>
                //</table>
                sb2.Append("<header class='headerdiv'>");



                sb2.Append("</div>");
                sb2.Append("</header>");
                sb2.Append("<main>");
                sb2.Append(@"<br><br><table border='0' width='100%'>
                <tbody>
                <tr>
                <td colspan='1' rowspan='1' bgcolor='#3399ff'> <font
                color='white'>
                <center><b> 3.</b></center>
                </font> </td>
                <td colspan='19' rowspan='1' bgcolor='gray'> <font color='white'><b> Substitution </b></font>
                </td>
                </tr>
                </tbody>
                </table>
                <table border='0' width='100%'>
                <tbody>
                <tr>
                <td colspan='19' rowspan='1'> <font color='#3399ff'> 3.1 Is it possible to avoid the
                need to use hazardous substances? </font></td>");
                if (option3_yes.Checked) { sb2.Append(@" < td colspan = '1' rowspan = '1' >< b > Yes </ b ></ td > "); }
                else { sb2.Append(@"<td colspan = '1' rowspan = '1'><b> No </b></td>"); }

                sb2.Append(@"</tr>
                <tr>
                <td colspan='20' rowspan='1'> <font color='#3399ff'> 3.2 Which form the substance takes?</font></td>
                </tr>
                <tr>
                <td colspan='20' rowspan='1'>
                <table width='100%'>
                <tbody>
                <tr>
                <td align='center' colspan='2'>
                 Gas
                </td>
                <td align='center'colspan='2'>
                    Vapour 
                </td>
                <td align='center' colspan='2'>
                 Mist
                </td>
                <td align='center' colspan='2'>
                Fume 
                </td>
                <td align='center' colspan='2'>
                Dust </td>
                <td align='center' colspan='2'>
                Liquid 
                </td>
                <td align='center' colspan='2'>
                Solid 
                </td>
                <td align='center' colspan='6'>
                Other(State):
                </td>
                </tr>
                <tr>");
                if (opt_Gas.Checked) { sb2.Append(@"<td align='center' colspan='2'> <b>[X]</b> </td>"); } else { sb2.Append(@"<td align='center' colspan='2'> [ ]</td>"); }
                if (opt_Vapour.Checked) { sb2.Append(@"<td align='center' colspan='2'> <b>[X]</b> </td>"); } else { sb2.Append(@"<td align='center' colspan='2'> [ ]</td>"); }
                if (opt_Mist.Checked) { sb2.Append(@"<td align='center' colspan='2'> <b>[X]</b> </td>"); } else { sb2.Append(@"<td align='center' colspan='2'> [ ]</td>"); }

                if (opt_Fume.Checked) { sb2.Append(@" <td align='center' colspan='2'> <b>[X]</b> </td>"); } else { sb2.Append(@"<td align='center' colspan='2'> [ ]</td>"); }
                if (opt_Dust.Checked) { sb2.Append(@" <td align='center' colspan='2'> <b>[X]</b> </td>"); } else { sb2.Append(@"<td align='center' colspan='2'> [ ]</td>"); }
                if (opt_Liquid.Checked) { sb2.Append(@" <td align='center' colspan='2'> <b>[X]</b> </td>"); } else { sb2.Append(@"<td align='center' colspan='2'> [ ]</td>"); }
                if (opt_Solid.Checked) { sb2.Append(@" <td align='center' colspan='2'> <b>[X]</b> </td>"); } else { sb2.Append(@"<td align='center' colspan='2'> [ ]</td>"); }

                sb2.Append(@"<td align='center' colspan='6'>" + opt_other.Text + @"
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td colspan='20' rowspan='1'><font color='#3399ff'> 3.3 Indicate below which route(s)
                of exposure the substance takes? </font></td>
                </tr>
                <tr>
                <td colspan='20' rowspan='1'>
                <table width='100%'>
                <tbody>
                <tr>
                <td colspan='3' align='center'>
                <center> inhalation </center>
                </td>
                <td colspan='3' align='center'>
                <center> Skin </center>
                </td>
                <td colspan='3' align='center'>
                <center> Eyes </center>
                </td>
                <td colspan='3' align='center'>
                <center> Ingestion </center>
                </td>
                <td colspan='8' align='center'>
                <center> Other(State) </center>
                </td>
                </tr>
                <tr>");

                if (opt_Inhalation.Checked) { sb2.Append(@"<td align='center' colspan='3'> <b>[X] </b> </td> "); } else { sb2.Append(@"<td align='center' colspan='3'> [ ] </td>"); }
                if (opt_Skin.Checked) { sb2.Append(@"<td align='center' colspan='3'> <b>[X]</b> </td>"); } else { sb2.Append(@"<td align='center' colspan='3'> [ ]</td>"); }
                if (opt_eyes.Checked) { sb2.Append(@"<td align='center' colspan='3'> <b>[X]</b> </td>"); } else { sb2.Append(@"<td align='center' colspan='3'> [ ]</td>"); }
                if (opt_ingestion.Checked) { sb2.Append(@" <td align='center' colspan='3'> <b>[X]</b> </td>"); } else { sb2.Append(@"<td align='center' colspan='3'> [ ]</td>"); }


                sb2.Append(@"<td colspan='8' align='center'>
                <center>" + opt2_other.Text + @" </center>
                </td></tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td colspan='20'><font color='#3399ff'>3.4 Workplace Exposure limits
                (WELs)?</font></td>
                </tr>
                <tr>
                </tr>
                <tr>
                <td colspan='8'>
                <p align='right'> Long - term exposure level(8hrTWA) </p>
                </td>
                ");
                if (opt_expolmt_long.Checked) { sb2.Append(@"<td align='left' colspan='2'><b>[X] </b> </td>"); } else { sb2.Append(@"<td align='left' colspan='2'> [ ] </td>"); }

                sb2.Append(@"
                <td colspan='8'>
                <p align='right'> Short - term exposure level(15 mins) </p>
                </td>");

                if (opt_expolmt_short.Checked) { sb2.Append(@"<td align='left' colspan='2'> <b>[X] </b> </td>"); } else { sb2.Append(@"<td align='left' colspan='2'> [ ] </td>"); }

                sb2.Append(@"</tr>
                <tr>
                <td colspan='20' rowspan='1'><font color='#3399ff'>3.5 List the risks to health below from
                      exposure to the substance</font></td>
                </tr>
                <tr>
                <td colspan='20' rowspan='1'> " + txt_list1.Text + @" </td>
                </tr>
                <tr>
                <td colspan='20' rowspan='1'><font color='#3399ff'>3.6 List below control measures eg
                extraction, ventilation, supervision, include additonal controls for
                vulnerable persons where necessary</font></td>
                </tr>
                <tr>
                <td colspan='20' rowspan='1'>  " + txt_list2.Text + @" </td>
                </tr>
                <tr>
                <td colspan='20' rowspan='1'><font color='#3399ff'>3.7 Certain substances can react
                adversley when they come into contact with others, please list any
                compatibility warnings here</font></td>
                </tr>
                <tr>
                <td colspan='20' rowspan='1'> " + txt_list3.Text + @" </td>
                </tr>
                <tr>
                </tr>
                </tbody>
                </table>
                <table width='100%'>
                <tbody>
                <tr>
                <td colspan='18' rowspan='1'> <font color='#3399ff'> 3.8 Is health surveillance or monitoring
                required ? </font></td>
                ");
                if (option4_yes.Checked) { sb2.Append(@" < td colspan = '2' rowspan = '1' >< b > Yes </ b ></ td > "); }
                else { sb2.Append(@"<td colspan = '2' rowspan = '1'><b> No </b></td>"); }


                sb2.Append(@"</tr>
                </tbody>
                </table>
                <i> remember health surveillance may
                be required for vulnerable persons eg pregnant / young workers those with
                asthma, dermatitis etc </i> <br/><br/>");
                sb21.Append(@"<table border='0' width='100%'>
                <tbody>
                <tr>
                <td colspan='9' bgcolor='gray' align='center'>
                <center><font color='white'> <b> Personal Protective Equipment
                identify type and specification </b> </font></center>
                </td>
                </tr>
                <tr>
                <td colspan='9' bgcolor='lightgrey' align='center' >
                <font color='black'> place an(X) in the box next to
                the appropriate sign </font>
                </td>
                </tr>");
                //<tr>
                //<td colspan='2'> Date </td>
                //<td colspan='1'>[] </td>
                //<td colspan='2'> Maintenance </td>
                //<td colspan='1'>[] </td>
                //<td colspan='2'> Maintenance </td>
                //<td colspan='1'>[] </td>
                //</tr>
                //<tr>
                //<td colspan='2'> Date </td>
                //<td colspan='1'>[] </td>
                //<td colspan='2'> Maintenance </td>
                //<td colspan='1'>[] </td>
                //<td colspan='2'> Maintenance </td>
                //<td colspan='1'>[] </td>
                //</tr>
                //<tr>
                //<td colspan='2'> Date </td>
                //<td colspan='1'>[] </td>
                //<td colspan='2'> Maintenance </td>
                //<td colspan='1'>[] </td>
                //<td colspan='2'> Maintenance </td>
                //<td colspan='1'>[] </td>
                //</tr>
                sb21.Append(@"</tbody>
                </table>
                <br></main>");

                sb3.Append(@"<main><table border='0' width='100%'>
                <tbody>
                <tr>
                <td colspan='20' rowspan='1'><font color='#3399ff'> First Aid Measures and Requirements: </font></td>
                </tr>
                <tr>
                <td colspan='20' rowspan='1'> " + txt_list4.Text + @" </td>
                </tr>
                <tr>
                <td colspan='20' rowspan='1'><font color='#3399ff'>  Identify appropriate fire
                extinguishers here:</font> </td>
                </tr>
                <tr>
                </tr>
                </tbody>
                </table>
                <table width='100%'>
                <tbody>
                <tr>
                <td colspan='3'>
                <p align='right'> Dry Powder </p>
                </td>");

                if (opt_fireext_dry.Checked) { sb3.Append(@"<td colspan='1' rowspan='1' align='left'><b> [X] </b></td>"); }
                else { sb3.Append(@"<td colspan = '1' rowspan = '1' align='left'><b> [ ] </b></td>"); }

                sb3.Append(@"<td colspan='3'>
                <p align='right'> CO2 </p>
                </td>");

                if (opt_fireext_co2.Checked) { sb3.Append(@"<td colspan='1' rowspan='1' align='left'><b> [X] </b></td>"); }
                else { sb3.Append(@"<td colspan='1' rowspan='1' align='left'><b> [ ] </b></td>"); }

                sb3.Append(@"<td colspan='3'>
                <p align='right'> Water </p>
                </td>");

                if (opt_fireext_water.Checked) { sb3.Append(@"<td colspan='1' rowspan='1' align='left' ><b> [X] </b></td> "); }
                else { sb3.Append(@"<td colspan='1' rowspan='1' align='left'><b> [ ] </b></td>"); }

                sb3.Append(@"
                <td colspan='3'>
                <p align='right'> Foam </p>
                </td>");

                if (opt_fireext_foam.Checked) { sb3.Append(@" <td colspan='1' rowspan='1' align='left'><b> [X] </b></td>"); }
                else { sb3.Append(@"<td colspan = '1' rowspan = '1' align='left'><b> [ ] </b></td>"); }

                sb3.Append(@"
                <td colspan='3'>
                <p align='right'> Fire Blanket </p>
                </td>");

                if (opt_fireext_fireblanket.Checked) { sb3.Append(@"<td colspan='1' rowspan='1' align='left'><b> [X] </b></td>"); }
                else { sb3.Append(@"<td colspan = '1' rowspan = '1' align='left'><b> [ ] </b></td>"); }

                sb3.Append(@"
                </tr>
                <tr>
                <td colspan='20'><font color='#3399ff'>During combustion substances may give rise to
                harmful vapours / gases etc
                please detail below </font></td>
                </tr>
                <tr>
                <td colspan='20'> " + txt_list5.Text + @" </td>
                </tr>
                <tr>
                <td colspan='20'> <font color='#3399ff'>Storage Details.</font> </td>
                </tr>
                <tr>
                <td colspan='20'> " + txt_storage_text.Text + @"</td>
                </tr>
                <tr>
                <td colspan='20' rowspan='1'> <font color='#3399ff'> Disposal of waste substances & containers please indicate below. </font></td>
                               </tr>
                               <tr>
                               </tr>
                               </tbody>
                               </table>
                               <table width='100%'>
                                <tbody>
                                <tr>
<td colspan='3' bgcolor='lightgrey'>
<p align='right'> Hazardous Waste </p>
</td>");

                if (opt_dispose_hazardous.Checked) { sb3.Append(@"<td colspan = '2' rowspan = '1' align='left' bgcolor='lightgrey'><b> [X] </b></td> "); }
                else { sb3.Append(@"<td colspan='1' rowspan='1' align='left' bgcolor='lightgrey'><b>[ ] </b></td>"); }

                sb3.Append(@"
<td colspan='3'>
<p align='right'> General waste </p>
</td>");

                if (opt_dispose_general.Checked) { sb3.Append(@"<td colspan = '2' rowspan = '1' align='left' ><b> [X] </b></td> "); }
                else { sb3.Append(@"<td colspan='1' rowspan='1' align='left' ><b>[ ] </b></td>"); }

                sb3.Append(@"

<td colspan='3' bgcolor='lightgrey'>
<p align='right'> Biological waste </p>
</td>
");

                if (opt_dispose_biological.Checked) { sb3.Append(@"<td colspan = '2' rowspan = '1' align='left' bgcolor='lightgrey'><b> [X] </b></td> "); }
                else { sb3.Append(@"<td colspan='1' rowspan='1' align='left' bgcolor='lightgrey'><b>[ ] </b></td>"); }

                sb3.Append(@"
<td colspan='3'>
<p align='right'> Return to Supplier</p>
</td>
");

                if (opt_dispose_returntosupplier.Checked) { sb3.Append(@"<td colspan = '2' rowspan = '1' align='left'><b> [X] </b></td> "); }
                else { sb3.Append(@"<td colspan='1' rowspan='1' align='left' ><b>[ ] </b></td>"); }

                sb3.Append(@"
<td colspan='2' bgcolor='lightgrey'>
<p align='right'> Other(State): </p>
</td>
<td colspan='2' bgcolor='lightgrey'>
<p align='left'>" + opt_dispose_other.Text + @" </p>
</td>
</tr>
<tr>
<td colspan='18' rowspan='1'> Is exposure adequately controlled ? </td>
");
                if (opt_exposure_yes.Checked) { sb3.Append(@" < td colspan = '2' rowspan = '1' >< b > Yes </ b ></ td > "); }
                else { sb3.Append(@"<td colspan = '2' rowspan = '1'><b> No </b></td>"); }


                sb3.Append(@"
</tr>
</tbody>
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
</table></main>");

                StringReader sr = new StringReader(sb.ToString());
                StringReader sr1 = new StringReader(sb1.ToString());
                StringReader sr2 = new StringReader(sb2.ToString());
                StringReader sr21 = new StringReader(sb21.ToString());
                StringReader sr3 = new StringReader(sb3.ToString());
                
            }
            txt_name.Text = txt_projname.Text = txt_sitename.Text = "";
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
                    CheckBox1data = txt_Check1_text.Text,
                    CheckBox2data = txt_Check2_text.Date.ToString(),
                    GM = txt_GroundMaintenance.Text,
                    Op1Yes = option1_yes.Checked ? "1" : "0",
                  //  Op1No = option1_No.Checked ? "1" : "0",
                    AT = Activity_txt.Text,
                    HLT = HowLong_txt.Text,
                    HOT = Howoften_txt.Text,
                    HMT = HowMuch_txt.Text,
                    SiteName = txt_sitename.Text,
                    CB11 = chkbx1.Text,
                    CB12 = chkbx2.Text,
                    CB13 = Others_CB.Text,
                    CB14 = Valnerable_CB.Text,
                    txt_sub = txt_substance.Text,
                    txt_sub_app = txt_substance_app.Text,
                    txt_saf_DS = txt_safety_DS.Text,
                    txt_Emergency_no = txt_Emergency_contact.Text,

                    cb211 = cb211.Checked ? "1" : "0",
                    cb212 = cb212.Checked ? "1" : "0",
                    cb213 = cb213.Checked ? "1" : "0",
                    cb221 = cb221.Checked ? "1" : "0",
                    cb222 = cb222.Checked ? "1" : "0",
                    cb223 = cb223.Checked ? "1" : "0",
                    cb231 = cb231.Checked ? "1" : "0",
                    cb232 = cb232.Checked ? "1" : "0",
                    cb233 = cb233.Checked ? "1" : "0",
                    cb241 = cb241.Checked ? "1" : "0",
                    cb242 = cb242.Checked ? "1" : "0",
                    cb243 = cb243.Checked ? "1" : "0",
                    cb251 = cb251.Checked ? "1" : "0",
                    cb252 = cb252.Checked ? "1" : "0",
                    opt3yes = option3_yes.Checked ? "1" : "0",
                    opt3no = option3_No.Checked ? "1" : "0",
                    optGas = opt_Gas.Checked ? "1" : "0",
                    optVap = opt_Vapour.Checked ? "1" : "0",
                    optmist = opt_Mist.Checked ? "1" : "0",
                    optfume = opt_Fume.Checked ? "1" : "0",
                    optDust = opt_Dust.Checked ? "1" : "0",
                    optLiq = opt_Liquid.Checked ? "1" : "0",
                    optSolid = opt_Solid.Checked ? "1" : "0",
                    optOther = opt_other.Text,
                    optinh = opt_Inhalation.Checked ? "1" : "0",
                    optskin = opt_Skin.Checked ? "1" : "0",
                    opteye = opt_eyes.Checked ? "1" : "0",
                    opting = opt_ingestion.Checked ? "1" : "0",
                    optother2 = opt2_other.Text,
                    optExpolimitlong = opt_expolmt_long.Checked ? "1" : "0",
                    optExpolimitshort = opt_expolmt_short.Checked ? "1" : "0",
                    risklist = txt_list1.Text,
                    controlmeasures = txt_list2.Text,
                    warninglist = txt_list3.Text,
                    opt4yes = option4_yes.Checked ? "1" : "0",
                    opt4no = option4_No.Checked ? "1" : "0",
                    cb311 = chk311.Checked ? "1" : "0",
                    cb312 = chk312.Checked ? "1" : "0",
                    cb313 = chk313.Checked ? "1" : "0",
                    cb321 = chk321.Checked ? "1" : "0",
                    cb322 = chk322.Checked ? "1" : "0",
                    cb323 = chk323.Checked ? "1" : "0",
                    cb331 = chk331.Checked ? "1" : "0",
                    cb332 = chk332.Checked ? "1" : "0",
                    firstaid = txt_list4.Text,
                    optFEdry = opt_fireext_dry.Checked ? "1" : "0",
                    optFEco = opt_fireext_co2.Checked ? "1" : "0",
                    optFEWater = opt_fireext_water.Checked ? "1" : "0",
                    optFEfoam = opt_fireext_foam.Checked ? "1" : "0",
                    optFEfireblanket = opt_fireext_fireblanket.Checked ? "1" : "0",
                    harmfulVapGas = txt_list5.Text,
                    txtStorage = txt_storage_text.Text,
                    optDisHaz = opt_dispose_hazardous.Checked ? "1" : "0",
                    optDisGen = opt_dispose_general.Checked ? "1" : "0",
                    optDisBio = opt_dispose_biological.Checked ? "1" : "0",
                    optDisRet = opt_dispose_returntosupplier.Checked ? "1" : "0",
                    optDisOther = opt_dispose_other.Checked ? "1" : "0",
                    optExpoYes = opt_exposure_yes.Checked ? "1" : "0",
                    optExpoNo = opt_exposure_No.Checked ? "1" : "0",
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

                txt_name.Text = txt_projname.Text = txt_sitename.Text = txt_Check1_text.Text  = "";
                chkbx1.Checked = chkbx2.Checked = false;
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
                    CheckBox1data = txt_Check1_text.Text,
                    CheckBox2data = txt_Check2_text.Date.ToString(),
                    GM = txt_GroundMaintenance.Text,
                    Op1Yes = option1_yes.Checked ? "1" : "0",
                     Op1No = option1_No.Checked ? "1" : "0",
                    AT = Activity_txt.Text,
                    HLT = HowLong_txt.Text,
                    HOT = Howoften_txt.Text,
                    HMT = HowMuch_txt.Text,
                    SiteName = txt_sitename.Text,
                    CB11 = chkbx1.Checked ? "1" : "0",
                    CB12 = chkbx2.Checked ? "1" : "0",
                    CB13 = Others_CB.Checked ? "1" : "0",
                    CB14 = Valnerable_CB.Checked ? "1" : "0",
                    txt_sub = txt_substance.Text,
                    txt_sub_app = txt_substance_app.Text,
                    txt_saf_DS = txt_safety_DS.Text,
                    txt_Emergency_no = txt_Emergency_contact.Text,

                    cb211 = cb211.Checked ? "1" : "0",
                    cb212 = cb212.Checked ? "1" : "0",
                    cb213 = cb213.Checked ? "1" : "0",
                    cb221 = cb221.Checked ? "1" : "0",
                    cb222 = cb222.Checked ? "1" : "0",
                    cb223 = cb223.Checked ? "1" : "0",
                    cb231 = cb231.Checked ? "1" : "0",
                    cb232 = cb232.Checked ? "1" : "0",
                    cb233 = cb233.Checked ? "1" : "0",
                    cb241 = cb241.Checked ? "1" : "0",
                    cb242 = cb242.Checked ? "1" : "0",
                    cb243 = cb243.Checked ? "1" : "0",
                    cb251 = cb251.Checked ? "1" : "0",
                    cb252 = cb252.Checked ? "1" : "0",
                    opt3yes = option3_yes.Checked ? "1" : "0",
                    opt3no = option3_No.Checked ? "1" : "0",
                    optGas = opt_Gas.Checked ? "1" : "0",
                    optVap = opt_Vapour.Checked ? "1" : "0",
                    optmist = opt_Mist.Checked ? "1" : "0",
                    optfume = opt_Fume.Checked ? "1" : "0",
                    optDust = opt_Dust.Checked ? "1" : "0",
                    optLiq = opt_Liquid.Checked ? "1" : "0",
                    optSolid = opt_Solid.Checked ? "1" : "0",
                    optOther = opt_other.Text,
                    optinh = opt_Inhalation.Checked ? "1" : "0",
                    optskin = opt_Skin.Checked ? "1" : "0",
                    opteye = opt_eyes.Checked ? "1" : "0",
                    opting = opt_ingestion.Checked ? "1" : "0",
                    optother2 = opt2_other.Text,
                    optExpolimitlong = opt_expolmt_long.Checked ? "1" : "0",
                    optExpolimitshort = opt_expolmt_short.Checked ? "1" : "0",
                    risklist = txt_list1.Text,
                    controlmeasures = txt_list2.Text,
                    warninglist = txt_list3.Text,
                    opt4yes = option4_yes.Checked ? "1" : "0",
                    opt4no = option4_No.Checked ? "1" : "0",
                    cb311 = chk311.Checked ? "1" : "0",
                    cb312 = chk312.Checked ? "1" : "0",
                    cb313 = chk313.Checked ? "1" : "0",
                    cb321 = chk321.Checked ? "1" : "0",
                    cb322 = chk322.Checked ? "1" : "0",
                    cb323 = chk323.Checked ? "1" : "0",
                    cb331 = chk331.Checked ? "1" : "0",
                    cb332 = chk332.Checked ? "1" : "0",
                    firstaid = txt_list4.Text,
                    optFEdry = opt_fireext_dry.Checked ? "1" : "0",
                    optFEco = opt_fireext_co2.Checked ? "1" : "0",
                    optFEWater = opt_fireext_water.Checked ? "1" : "0",
                    optFEfoam = opt_fireext_foam.Checked ? "1" : "0",
                    optFEfireblanket = opt_fireext_fireblanket.Checked ? "1" : "0",
                    harmfulVapGas = txt_list5.Text,
                    txtStorage = txt_storage_text.Text,
                    optDisHaz = opt_dispose_hazardous.Checked ? "1" : "0",
                    optDisGen = opt_dispose_general.Checked ? "1" : "0",
                    optDisBio = opt_dispose_biological.Checked ? "1" : "0",
                    optDisRet = opt_dispose_returntosupplier.Checked ? "1" : "0",
                    optDisOther = opt_dispose_other.Checked ? "1" : "0",
                    optExpoYes = opt_exposure_yes.Checked ? "1" : "0",
                    optExpoNo = opt_exposure_No.Checked ? "1" : "0",
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

        }
        #endregion

        public class DraftFields
        {
            public string GM { get; set; }
            public string Op1Yes { get; set; }
            public string Op1No { get; set; }
            public string AT { get; set; }
            public string HLT { get; set; }
            public string HOT { get; set; }
            public string HMT { get; set; }
            public string CB11 { get; set; }
            public string CB12 { get; set; }
            public string CB13 { get; set; }
            public string CB14 { get; set; }
            public string txt_sub { get; set; }
            public string cb211 { get; set; }
            public string cb212 { get; set; }
            public string cb213 { get; set; }
            public string cb221 { get; set; }
            public string cb222 { get; set; }
            public string cb223 { get; set; }
            public string cb231 { get; set; }
            public string cb232 { get; set; }
            public string cb233 { get; set; }
            public string cb241 { get; set; }
            public string cb242 { get; set; }
            public string cb243 { get; set; }
            public string cb251 { get; set; }
            public string cb252 { get; set; }
            public string opt3yes { get; set; }
            public string opt3no { get; set; }
            public string optGas { get; set; }
            public string optVap { get; set; }
            public string optmist { get; set; }
            public string optfume { get; set; }
            public string optDust { get; set; }
            public string optLiq { get; set; }
            public string optSolid { get; set; }
            public string optOther { get; set; }
            public string optinh { get; set; }
            public string optskin { get; set; }
            public string opteye { get; set; }
            public string opting { get; set; }
            public string optother2 { get; set; }
            public string optExpolimitlong { get; set; }
            public string optExpolimitshort { get; set; }
            public string risklist { get; set; }
            public string controlmeasures { get; set; }
            public string warninglist { get; set; }
            public string opt4yes { get; set; }
            public string opt4no { get; set; }
            public string cb311 { get; set; }
            public string cb312 { get; set; }
            public string cb313 { get; set; }
            public string cb321 { get; set; }
            public string cb322 { get; set; }
            public string cb323 { get; set; }
            public string cb331 { get; set; }
            public string cb332 { get; set; }
            public string firstaid { get; set; }
            public string optFEdry { get; set; }
            public string optFEco { get; set; }
            public string optFEWater { get; set; }
            public string optFEfoam { get; set; }
            public string optFEfireblanket { get; set; }
            public string harmfulVapGas { get; set; }
            public string txtStorage { get; set; }
            public string optDisHaz { get; set; }
            public string optDisGen { get; set; }
            public string optDisBio { get; set; }
            public string optDisRet { get; set; }
            public string optDisOther { get; set; }
            public string optExpoYes { get; set; }
            public string optExpoNo { get; set; }
            public string Name1 { get; set; }
            public string ProjectName { get; set; }
            public string SiteName { get; set; }
            public string date { get; set; }
            public string CheckBox1data { get; set; }
            public string CheckBox2data { get; set; }
            public string txt_sub_app { get; set; }
            public string txt_saf_DS { get; set; }
            public string txt_Emergency_no { get; set; }

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

        protected void Chkbx1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx1.Checked == true)
            {
                chkbx2.Checked = false;
            }
            if (chkbx2.Checked == true)
            {
                chkbx1.Checked = false;
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


        private async void OnClick_takepicture(object sender, EventArgs e) { }
        private async void OnClick_pickPicture(object sender, EventArgs e) { }

        private void option1_yes_CheckedChanged(object sender, EventArgs e)
        {
            if (option1_yes.Checked)
            {
                option1_No.Checked = false;
            }
          else
            {
                option1_No.Checked = true;
            }
        }

        private void option3_yes_CheckedChanged(object sender, EventArgs e)
        {
            if (option3_yes.Checked)
            {
                option3_No.Checked = false;
            }
            else
            {
                option3_No.Checked = true;
            }
        }

        private void option1_No_CheckedChanged(object sender, EventArgs e)
        {
            if (option1_No.Checked)
            {
                option1_yes.Checked = false;
            }
            else
            {
                option1_yes.Checked = true;
            }
        }

        private void option3_No_CheckedChanged(object sender, EventArgs e)
        {
            if (option3_No.Checked)
            {
                option3_yes.Checked = false;
            }
            else
            {
                option3_yes.Checked = true;
            }
        }

        private void opt_exposure_yes_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_exposure_yes.Checked)
            {
                opt_exposure_No.Checked = false;
            }
            else
            {
                opt_exposure_No.Checked = true;
            }
        }

        private void opt_exposure_No_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_exposure_No.Checked)
            {
                opt_exposure_yes.Checked = false;
            }
            else
            {
                opt_exposure_yes.Checked = true;
            }
        }

        private void option4_yes_CheckedChanged(object sender, EventArgs e)
        {
            if (option4_yes.Checked)
            {
                option4_No.Checked = false;
            }
            else
            {
                option4_No.Checked = true;
            }
        }

        private void option4_No_CheckedChanged(object sender, EventArgs e)
        {
            if (option4_No.Checked)
            {
                option4_yes.Checked = false;
            }
            else
            {
                option4_yes.Checked = true;
            }
        }


        //public class CustomImageHTMLTagProcessor : IHTMLTagProcessor
        //{
        //    /// <summary>
        //    /// Tells the HTMLWorker what to do when a close tag is encountered.
        //    /// </summary>
        //    public void EndElement(HTMLWorker worker, string tag)
        //    {
        //    }

        //    /// <summary>
        //    /// Tells the HTMLWorker what to do when an open tag is encountered.
        //    /// </summary>
        //    public void StartElement(HTMLWorker worker, string tag, IDictionary<string, string> attrs)
        //    {
        //        iTextSharp.text.Image image;
        //        var src = attrs["src"];

        //        if (src.StartsWith("data:image/"))
        //        {
        //            // data:[<MIME-type>][;charset=<encoding>][;base64],<data>
        //            var base64Data = src.Substring(src.IndexOf(",") + 1);
        //            var imagedata = Convert.FromBase64String(base64Data);
        //            image = iTextSharp.text.Image.GetInstance(imagedata);
        //        }
        //        else
        //        {
        //            image = iTextSharp.text.Image.GetInstance(src);
        //        }

        //        //worker.UpdateChain(tag, attrs);
        //        //worker.ProcessImage(image, attrs);
        //        //worker.UpdateChain(tag);
        //    }
        //}


    }
}


