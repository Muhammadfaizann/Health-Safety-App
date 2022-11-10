
using System;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;

using Newtonsoft.Json;

using Acr.UserDialogs;
using System.Globalization;
using Plugin.Media;
using Microsoft.AppCenter.Crashes;
using PCLStorage;
using static System.Net.WebRequestMethods;
using iText.Html2pdf.Attach.Impl.Tags;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Html2pdf;

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

                StringBuilder sb = new StringBuilder();
               
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
");
                sb.Append(@"<table border='0' width='100%'>
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
                sb.Append("</main>");
                sb.Append("<header class='headerdiv'>");



                sb.Append("</div>");
                sb.Append("</header>");
                sb.Append("<main>");
                sb.Append(@"<table border='0' width='100%'>
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
                if (option3_yes.Checked) { sb.Append(@" < td colspan = '1' rowspan = '1' >< b > Yes </ b ></ td > "); }
                else { sb.Append(@"<td colspan = '1' rowspan = '1'><b> No </b></td>"); }

                sb.Append(@"</tr>
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
                if (opt_Gas.Checked) { sb.Append(@"<td align='center' colspan='2'> <b>[X]</b> </td>"); } else { sb.Append(@"<td align='center' colspan='2'> [ ]</td>"); }
                if (opt_Vapour.Checked) { sb.Append(@"<td align='center' colspan='2'> <b>[X]</b> </td>"); } else { sb.Append(@"<td align='center' colspan='2'> [ ]</td>"); }
                if (opt_Mist.Checked) { sb.Append(@"<td align='center' colspan='2'> <b>[X]</b> </td>"); } else { sb.Append(@"<td align='center' colspan='2'> [ ]</td>"); }

                if (opt_Fume.Checked) { sb.Append(@" <td align='center' colspan='2'> <b>[X]</b> </td>"); } else { sb.Append(@"<td align='center' colspan='2'> [ ]</td>"); }
                if (opt_Dust.Checked) { sb.Append(@" <td align='center' colspan='2'> <b>[X]</b> </td>"); } else { sb.Append(@"<td align='center' colspan='2'> [ ]</td>"); }
                if (opt_Liquid.Checked) { sb.Append(@" <td align='center' colspan='2'> <b>[X]</b> </td>"); } else { sb.Append(@"<td align='center' colspan='2'> [ ]</td>"); }
                if (opt_Solid.Checked) { sb.Append(@" <td align='center' colspan='2'> <b>[X]</b> </td>"); } else { sb.Append(@"<td align='center' colspan='2'> [ ]</td>"); }

                sb.Append(@"<td align='center' colspan='6'>" + opt_other.Text + @"
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

                if (opt_Inhalation.Checked) { sb.Append(@"<td align='center' colspan='3'> <b>[X] </b> </td> "); } else { sb.Append(@"<td align='center' colspan='3'> [ ] </td>"); }
                if (opt_Skin.Checked) { sb.Append(@"<td align='center' colspan='3'> <b>[X]</b> </td>"); } else { sb.Append(@"<td align='center' colspan='3'> [ ]</td>"); }
                if (opt_eyes.Checked) { sb.Append(@"<td align='center' colspan='3'> <b>[X]</b> </td>"); } else { sb.Append(@"<td align='center' colspan='3'> [ ]</td>"); }
                if (opt_ingestion.Checked) { sb.Append(@" <td align='center' colspan='3'> <b>[X]</b> </td>"); } else { sb.Append(@"<td align='center' colspan='3'> [ ]</td>"); }


                sb.Append(@"<td colspan='8' align='center'>
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
                if (opt_expolmt_long.Checked) { sb.Append(@"<td align='left' colspan='2'><b>[X] </b> </td>"); } else { sb.Append(@"<td align='left' colspan='2'> [ ] </td>"); }

                sb.Append(@"
                <td colspan='8'>
                <p align='right'> Short - term exposure level(15 mins) </p>
                </td>");

                if (opt_expolmt_short.Checked) { sb.Append(@"<td align='left' colspan='2'> <b>[X] </b> </td>"); } else { sb.Append(@"<td align='left' colspan='2'> [ ] </td>"); }

                sb.Append(@"</tr>
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
                if (option4_yes.Checked) { sb.Append(@" < td colspan = '2' rowspan = '1' >< b > Yes </ b ></ td > "); }
                else { sb.Append(@"<td colspan = '2' rowspan = '1'><b> No </b></td>"); }


                sb.Append(@"</tr>
                </tbody>
                </table>
                <i> remember health surveillance may
                be required for vulnerable persons eg pregnant / young workers those with
                asthma, dermatitis etc </i> ");
                sb.Append(@"<table border='0' width='100%'>
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
                
                sb.Append(@"</tbody>
                </table>
                </main>");

                sb.Append(@"<main><table border='0' width='100%'>
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

                if (opt_fireext_dry.Checked) { sb.Append(@"<td colspan='1' rowspan='1' align='left'><b> [X] </b></td>"); }
                else { sb.Append(@"<td colspan = '1' rowspan = '1' align='left'><b> [ ] </b></td>"); }

                sb.Append(@"<td colspan='3'>
                <p align='right'> CO2 </p>
                </td>");

                if (opt_fireext_co2.Checked) { sb.Append(@"<td colspan='1' rowspan='1' align='left'><b> [X] </b></td>"); }
                else { sb.Append(@"<td colspan='1' rowspan='1' align='left'><b> [ ] </b></td>"); }

                sb.Append(@"<td colspan='3'>
                <p align='right'> Water </p>
                </td>");

                if (opt_fireext_water.Checked) { sb.Append(@"<td colspan='1' rowspan='1' align='left' ><b> [X] </b></td> "); }
                else { sb.Append(@"<td colspan='1' rowspan='1' align='left'><b> [ ] </b></td>"); }

                sb.Append(@"
                <td colspan='3'>
                <p align='right'> Foam </p>
                </td>");

                if (opt_fireext_foam.Checked) { sb.Append(@" <td colspan='1' rowspan='1' align='left'><b> [X] </b></td>"); }
                else { sb.Append(@"<td colspan = '1' rowspan = '1' align='left'><b> [ ] </b></td>"); }

                sb.Append(@"
                <td colspan='3'>
                <p align='right'> Fire Blanket </p>
                </td>");

                if (opt_fireext_fireblanket.Checked) { sb.Append(@"<td colspan='1' rowspan='1' align='left'><b> [X] </b></td>"); }
                else { sb.Append(@"<td colspan = '1' rowspan = '1' align='left'><b> [ ] </b></td>"); }

                sb.Append(@"
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

                if (opt_dispose_hazardous.Checked) { sb.Append(@"<td colspan = '2' rowspan = '1' align='left' bgcolor='lightgrey'><b> [X] </b></td> "); }
                else { sb.Append(@"<td colspan='1' rowspan='1' align='left' bgcolor='lightgrey'><b>[ ] </b></td>"); }

                sb.Append(@"
                <td colspan='3'>
                <p align='right'> General waste </p>
                </td>");

                if (opt_dispose_general.Checked) { sb.Append(@"<td colspan = '2' rowspan = '1' align='left' ><b> [X] </b></td> "); }
                else { sb.Append(@"<td colspan='1' rowspan='1' align='left' ><b>[ ] </b></td>"); }

                sb.Append(@"

                <td colspan='3' bgcolor='lightgrey'>
                <p align='right'> Biological waste </p>
                </td>
                ");

                if (opt_dispose_biological.Checked) { sb.Append(@"<td colspan = '2' rowspan = '1' align='left' bgcolor='lightgrey'><b> [X] </b></td> "); }
                else { sb.Append(@"<td colspan='1' rowspan='1' align='left' bgcolor='lightgrey'><b>[ ] </b></td>"); }

                sb.Append(@"
                <td colspan='3'>
                <p align='right'> Return to Supplier</p>
                </td>
                ");

                if (opt_dispose_returntosupplier.Checked) { sb.Append(@"<td colspan = '2' rowspan = '1' align='left'><b> [X] </b></td> "); }
                else { sb.Append(@"<td colspan='1' rowspan='1' align='left' ><b>[ ] </b></td>"); }

                sb.Append(@"
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
                if (opt_exposure_yes.Checked) { sb.Append(@"<td colspan = '2' rowspan = '1' ><b> Yes </b></td>"); }
                else { sb.Append(@"<td colspan = '2' rowspan = '1'><b> No </b></td>"); }


                sb.Append(@"
                </tr>
                </tbody>
                </table>
                
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

                
                IFolder rootFolder = await FileSystem.Current.GetFolderFromPathAsync(path);
                IFolder folder = await rootFolder.CreateFolderAsync("HandSAppPdf", CreationCollisionOption.OpenIfExists);
                string fnam = await InputBox(this.Navigation);

                if (fnam is null) { return; }
                else
                { if (fnam == "") { fnam = "Coshh assessment.pdf"; } else { fnam = fnam + ".pdf"; } }

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

                txt_name.Text = txt_projname.Text = txt_sitename.Text = "";
            }
            catch (Exception ex)
            {

            }
        }



        #endregion


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
                    if (fnam == "") { fnam = "Draft_CA.json"; } else { fnam = fnam + "_CA.json"; }
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

        #endregion


        #region OpenDraft
        private async void OnClick_OpenDraft(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DraftsList("_CA", 1));
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
            txt_sitename.Text = account.SiteName;
            datepicker.Date = Convert.ToDateTime(account.date);
            txt_Check1_text.Text = account.CheckBox1data;
            txt_Check2_text.Date = Convert.ToDateTime(account.CheckBox2data);
            if (account.CheckBox1data != null)
            { chkbx1.Checked = true; }
            txt_Check2_text.Date = Convert.ToDateTime(account.CheckBox2data);
            if (account.CheckBox2data != null)
            { chkbx2.Checked = true; }



            txt_GroundMaintenance.Text = account.GM;
            if (account.Op1Yes == "1") { option1_yes.Checked = true; } else { option1_yes.Checked = false; }
            if (account.Op1No == "1") { option1_No.Checked = true; } else { option1_No.Checked = false; }
            if (account.AT == "1") { option1_No.Checked = true; } else { option1_No.Checked = false; }

            Activity_txt.Text = account.AT;
            HowLong_txt.Text = account.HLT;
            Howoften_txt.Text = account.HOT;
            HowMuch_txt.Text = account.HMT;
            txt_sitename.Text = account.SiteName;
            if (account.CB11 == "1") { chkbx1.Checked = true; } else { chkbx1.Checked = false; }
            if (account.CB12 == "1") { chkbx2.Checked = true; } else { chkbx2.Checked = false; }
            if (account.CB13 == "1") { Others_CB.Checked = true; } else { Others_CB.Checked = false; }
            if (account.CB14 == "1") { Valnerable_CB.Checked = true; } else { Valnerable_CB.Checked = false; }
            txt_substance.Text = account.txt_sub;
            txt_substance_app.Text = account.txt_sub_app;
            txt_safety_DS.Text = account.txt_saf_DS;
            txt_Emergency_contact.Text = account.txt_Emergency_no;

            if (account.cb211 == "1") { cb211.Checked = true; } else { cb211.Checked = false; }
            if (account.cb212 == "1") { cb212.Checked = true; } else { cb212.Checked = false; }
            if (account.cb213 == "1") { cb213.Checked = true; } else { cb213.Checked = false; }

            if (account.cb221 == "1") { cb221.Checked = true; } else { cb221.Checked = false; }
            if (account.cb222 == "1") { cb222.Checked = true; } else { cb222.Checked = false; }
            if (account.cb223 == "1") { cb223.Checked = true; } else { cb223.Checked = false; }

            if (account.cb231 == "1") { cb231.Checked = true; } else { cb231.Checked = false; }
            if (account.cb232 == "1") { cb232.Checked = true; } else { cb232.Checked = false; }
            if (account.cb233 == "1") { cb233.Checked = true; } else { cb233.Checked = false; }

            if (account.cb241 == "1") { cb241.Checked = true; } else { cb241.Checked = false; }
            if (account.cb242 == "1") { cb242.Checked = true; } else { cb242.Checked = false; }
            if (account.cb243 == "1") { cb243.Checked = true; } else { cb243.Checked = false; }

            if (account.cb251 == "1") { cb251.Checked = true; } else { cb251.Checked = false; }
            if (account.cb252 == "1") { cb252.Checked = true; } else { cb252.Checked = false; }

            if (account.opt3yes == "1") { option3_yes.Checked = true; } else { option3_yes.Checked = false; }
            if (account.opt3no == "1") { option3_No.Checked = true; } else { option3_No.Checked = false; }

            if (account.optGas == "1") { opt_Gas.Checked = true; } else { opt_Gas.Checked = false; }
            if (account.optVap == "1") { opt_Vapour.Checked = true; } else { opt_Vapour.Checked = false; }
            if (account.optmist == "1") { opt_Mist.Checked = true; } else { opt_Mist.Checked = false; }
            if (account.optfume == "1") { opt_Fume.Checked = true; } else { opt_Fume.Checked = false; }
            if (account.optDust == "1") { opt_Dust.Checked = true; } else { opt_Dust.Checked = false; }
            if (account.optLiq == "1") { opt_Liquid.Checked = true; } else { opt_Liquid.Checked = false; }
            if (account.optSolid == "1") { opt_Solid.Checked = true; } else { opt_Solid.Checked = false; }
            opt_other.Text = account.optOther;

            if (account.optinh == "1") { opt_Inhalation.Checked = true; } else { opt_Inhalation.Checked = false; }
            if (account.optskin == "1") { opt_Skin.Checked = true; } else { opt_Skin.Checked = false; }
            if (account.opteye == "1") { opt_eyes.Checked = true; } else { opt_eyes.Checked = false; }
            if (account.opting == "1") { opt_ingestion.Checked = true; } else { opt_ingestion.Checked = false; }
            opt2_other.Text = account.optother2;

            if (account.optExpolimitlong == "1") { opt_expolmt_long.Checked = true; } else { opt_expolmt_long.Checked = false; }
            if (account.optExpolimitshort == "1") { opt_expolmt_short.Checked = true; } else { opt_expolmt_short.Checked = false; }

            txt_list1.Text = account.risklist;
            txt_list2.Text = account.controlmeasures;
            txt_list3.Text = account.warninglist;

            if (account.opt4yes == "1") { option4_yes.Checked = true; } else { option4_yes.Checked = false; }
            if (account.opt4no == "1") { option4_No.Checked = true; } else { option4_No.Checked = false; }

            if (account.cb311 == "1") { chk311.Checked = true; } else { chk311.Checked = false; }
            if (account.cb312 == "1") { chk312.Checked = true; } else { chk312.Checked = false; }
            if (account.cb313 == "1") { chk313.Checked = true; } else { chk313.Checked = false; }
            if (account.cb321 == "1") { chk321.Checked = true; } else { chk321.Checked = false; }
            if (account.cb322 == "1") { chk322.Checked = true; } else { chk322.Checked = false; }
            if (account.cb323 == "1") { chk323.Checked = true; } else { chk323.Checked = false; }
            if (account.cb331 == "1") { chk331.Checked = true; } else { chk331.Checked = false; }
            if (account.cb332 == "1") { chk332.Checked = true; } else { chk332.Checked = false; }

            txt_list4.Text = account.firstaid;

            if (account.optFEdry == "1") { opt_fireext_dry.Checked = true; } else { opt_fireext_dry.Checked = false; }
            if (account.optFEco == "1") { opt_fireext_co2.Checked = true; } else { opt_fireext_co2.Checked = false; }
            if (account.optFEWater == "1") { opt_fireext_water.Checked = true; } else { opt_fireext_water.Checked = false; }
            if (account.optFEfoam == "1") { opt_fireext_foam.Checked = true; } else { opt_fireext_foam.Checked = false; }
            if (account.optFEfireblanket == "1") { opt_fireext_fireblanket.Checked = true; } else { opt_fireext_fireblanket.Checked = false; }

            txt_list5.Text = account.harmfulVapGas;
            txt_storage_text.Text = account.txtStorage;

            if (account.optDisHaz == "1") { opt_dispose_hazardous.Checked = true; } else { opt_dispose_hazardous.Checked = false; }
            if (account.optDisGen == "1") { opt_dispose_general.Checked = true; } else { opt_dispose_general.Checked = false; }

            if (account.optDisBio == "1") { opt_dispose_biological.Checked = true; } else { opt_dispose_biological.Checked = false; }
            if (account.optDisRet == "1") { opt_dispose_returntosupplier.Checked = true; } else { opt_dispose_returntosupplier.Checked = false; }

            if (account.optDisOther == "1") { opt_dispose_other.Checked = true; } else { opt_dispose_other.Checked = false; }

            if (account.optExpoYes == "1") { opt_exposure_yes.Checked = true; } else { opt_exposure_yes.Checked = false; }
            if (account.optExpoNo == "1") { opt_exposure_No.Checked = true; } else { opt_exposure_No.Checked = false; }

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
                lbl_from.Text = "1";
                lbl_to.Text = img_count.ToString();

            }

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
