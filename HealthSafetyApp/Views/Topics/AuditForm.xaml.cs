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
    public partial class AuditForm : ContentPage
    {
        private string fileText;
        //int a_up, b_up, c_up, a_low, b_low, c_low, a_new, b_new, c_new, a_new1, b_new1, c_new1, a_new2, b_new2, c_new2 = 0;
        //string c_up_color;
        //string c_low_color;
        //string c_new_color;
        //string c_new1_color;
        //int count = 0;
       
       // Picker pck;
        int img_count;
        private string filname;
        public AuditForm(string filenam)
        {
            InitializeComponent();
            filname = filenam;
            this.Title = "Audit form";
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
            if (a.Equals(CB151) || a.Equals(CB152) || a.Equals(CB153)) { CbRed = (Controls.CheckText)CB151; CbOrg = (Controls.CheckText)CB152; CbGrn = (Controls.CheckText)CB153; }
            if (a.Equals(CB161) || a.Equals(CB162) || a.Equals(CB163)) { CbRed = (Controls.CheckText)CB161; CbOrg = (Controls.CheckText)CB162; CbGrn = (Controls.CheckText)CB163; }

            if (a.Equals(CB171) || a.Equals(CB172) || a.Equals(CB173)) { CbRed = (Controls.CheckText)CB171; CbOrg = (Controls.CheckText)CB172; CbGrn = (Controls.CheckText)CB173; }
            if (a.Equals(CB181) || a.Equals(CB182) || a.Equals(CB183)) { CbRed = (Controls.CheckText)CB181; CbOrg = (Controls.CheckText)CB182; CbGrn = (Controls.CheckText)CB183; }
            if (a.Equals(CB191) || a.Equals(CB192) || a.Equals(CB193)) { CbRed = (Controls.CheckText)CB191; CbOrg = (Controls.CheckText)CB192; CbGrn = (Controls.CheckText)CB193; }

            if (a.Equals(CB201) || a.Equals(CB202) || a.Equals(CB203)) { CbRed = (Controls.CheckText)CB201; CbOrg = (Controls.CheckText)CB202; CbGrn = (Controls.CheckText)CB203; }
            if (a.Equals(CB211) || a.Equals(CB212) || a.Equals(CB213)) { CbRed = (Controls.CheckText)CB211; CbOrg = (Controls.CheckText)CB212; CbGrn = (Controls.CheckText)CB213; }
            if (a.Equals(CB221) || a.Equals(CB222) || a.Equals(CB223)) { CbRed = (Controls.CheckText)CB221; CbOrg = (Controls.CheckText)CB222; CbGrn = (Controls.CheckText)CB223; }

            if (a.Equals(CB231) || a.Equals(CB232) || a.Equals(CB233)) { CbRed = (Controls.CheckText)CB231; CbOrg = (Controls.CheckText)CB232; CbGrn = (Controls.CheckText)CB233; }
            if (a.Equals(CB241) || a.Equals(CB242) || a.Equals(CB243)) { CbRed = (Controls.CheckText)CB241; CbOrg = (Controls.CheckText)CB242; CbGrn = (Controls.CheckText)CB243; }
            if (a.Equals(CB251) || a.Equals(CB252) || a.Equals(CB253)) { CbRed = (Controls.CheckText)CB251; CbOrg = (Controls.CheckText)CB252; CbGrn = (Controls.CheckText)CB253; }

            if (a.Equals(CB261) || a.Equals(CB262) || a.Equals(CB263)) { CbRed = (Controls.CheckText)CB261; CbOrg = (Controls.CheckText)CB262; CbGrn = (Controls.CheckText)CB263; }
            if (a.Equals(CB271) || a.Equals(CB272) || a.Equals(CB273)) { CbRed = (Controls.CheckText)CB271; CbOrg = (Controls.CheckText)CB272; CbGrn = (Controls.CheckText)CB273; }
            if (a.Equals(CB281) || a.Equals(CB282) || a.Equals(CB283)) { CbRed = (Controls.CheckText)CB281; CbOrg = (Controls.CheckText)CB282; CbGrn = (Controls.CheckText)CB283; }

            if (a.Equals(CB291) || a.Equals(CB292) || a.Equals(CB293)) { CbRed = (Controls.CheckText)CB291; CbOrg = (Controls.CheckText)CB292; CbGrn = (Controls.CheckText)CB293; }
            if (a.Equals(CB301) || a.Equals(CB302) || a.Equals(CB303)) { CbRed = (Controls.CheckText)CB301; CbOrg = (Controls.CheckText)CB302; CbGrn = (Controls.CheckText)CB303; }
            if (a.Equals(CB311) || a.Equals(CB312) || a.Equals(CB313)) { CbRed = (Controls.CheckText)CB311; CbOrg = (Controls.CheckText)CB312; CbGrn = (Controls.CheckText)CB313; }

            if (a.Equals(CB321) || a.Equals(CB322) || a.Equals(CB323)) { CbRed = (Controls.CheckText)CB321; CbOrg = (Controls.CheckText)CB322; CbGrn = (Controls.CheckText)CB323; }
            if (a.Equals(CB331) || a.Equals(CB332) || a.Equals(CB333)) { CbRed = (Controls.CheckText)CB331; CbOrg = (Controls.CheckText)CB332; CbGrn = (Controls.CheckText)CB333; }
            if (a.Equals(CB341) || a.Equals(CB342) || a.Equals(CB343)) { CbRed = (Controls.CheckText)CB341; CbOrg = (Controls.CheckText)CB342; CbGrn = (Controls.CheckText)CB343; }

            if (a.Equals(CB351) || a.Equals(CB352) || a.Equals(CB353)) { CbRed = (Controls.CheckText)CB351; CbOrg = (Controls.CheckText)CB352; CbGrn = (Controls.CheckText)CB353; }
            if (a.Equals(CB361) || a.Equals(CB362) || a.Equals(CB363)) { CbRed = (Controls.CheckText)CB361; CbOrg = (Controls.CheckText)CB362; CbGrn = (Controls.CheckText)CB363; }
            if (a.Equals(CB371) || a.Equals(CB372) || a.Equals(CB373)) { CbRed = (Controls.CheckText)CB371; CbOrg = (Controls.CheckText)CB372; CbGrn = (Controls.CheckText)CB373; }

            if (a.Equals(CB381) || a.Equals(CB382) || a.Equals(CB383)) { CbRed = (Controls.CheckText)CB381; CbOrg = (Controls.CheckText)CB382; CbGrn = (Controls.CheckText)CB383; }
            if (a.Equals(CB391) || a.Equals(CB392) || a.Equals(CB393)) { CbRed = (Controls.CheckText)CB391; CbOrg = (Controls.CheckText)CB392; CbGrn = (Controls.CheckText)CB393; }
            if (a.Equals(CB401) || a.Equals(CB402) || a.Equals(CB403)) { CbRed = (Controls.CheckText)CB401; CbOrg = (Controls.CheckText)CB402; CbGrn = (Controls.CheckText)CB403; }

            if (a.Equals(CB411) || a.Equals(CB412) || a.Equals(CB413)) { CbRed = (Controls.CheckText)CB411; CbOrg = (Controls.CheckText)CB412; CbGrn = (Controls.CheckText)CB413; }
            if (a.Equals(CB421) || a.Equals(CB422) || a.Equals(CB423)) { CbRed = (Controls.CheckText)CB421; CbOrg = (Controls.CheckText)CB422; CbGrn = (Controls.CheckText)CB423; }
            if (a.Equals(CB431) || a.Equals(CB432) || a.Equals(CB433)) { CbRed = (Controls.CheckText)CB431; CbOrg = (Controls.CheckText)CB432; CbGrn = (Controls.CheckText)CB433; }
                                                                                                                              
            if (a.Checked == true)
            {

                if (a.Equals(CbRed))
                {
                    if (CbOrg.Checked == true) { CbOrg.IsEnabled = true; CbOrg.Checked = false; OrangeCount.Text = (int.Parse(OrangeCount.Text) - 1).ToString(); }
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

            update_prct();

        }
        //percentage
        private void update_prct()
        {
            ResultLblPoor.Text = "Poor =" + Math.Round((double.Parse(RedCount.Text)*100 / 42),2).ToString() + "%";
            ResultLblModerate.Text = "Moderate =" + Math.Round ((double.Parse(OrangeCount.Text) * 100 / 42),2).ToString() + "%";
            ResultLblGood.Text = "Good =" + Math.Round((double.Parse(GreenCount.Text) * 100 / 42),2).ToString() + "%";
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
                //sb.Append("<header>");
                //sb.Append("</header>");
                sb.Append("<main>");

                sb.Append(@"<table border='0' width='100%'><tbody>
                                <tr>
                                    <td colspan='10' bgcolor='gray' align='center'>
                                    <font color='white'><h3><b>Audit form</b></h3></font></center>
                                    </td>
                                </tr>

                                <tr>
                                    <td colspan='10' bgcolor='silver' align='right'>
                                    <p style='color:#ffffff;font-size:5px;'><i>Created using Audit form tool© @The Health And Safety App </i></p>
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
                                    <td colspan='6' rowspan='1'><font color='#3399ff'> Location: </font></td>
                                    <td colspan='14' rowspan='1' align='left' >" + txt_projname.Text + @" </td>
                                </tr>

                                <tr>
                                    <td colspan='6' rowspan='1'><font color='#3399ff'> Area: </font></td>
                                    <td colspan='14' rowspan='1' align='left' >" + txt_sitename.Text + @" </td>
                                </tr>

                                <tr>
                                    <td colspan='6' rowspan='1'><font color='#3399ff'> Date: </font></td>
                                    <td colspan='14' rowspan='1' align='left'>" + dat.ToString() + @" </td>
                                </tr>

                                <tr>
                                    <td colspan='6' rowspan='1'><font color='#3399ff'> Persons present: </font></td>
                                    <td colspan='14' rowspan='1' align='left'>" + txt_persons.Text  + @" </td>
                                </tr>

                                <tr>
                                    <td colspan='6' rowspan='1'><font color='#3399ff'>Description: </font></td>
                                    <td colspan='14' rowspan='1' align='left'>" + txt_Description.Text + @" </td>
                                </tr>
                             </tbody></table>
                            
                            <br/>

                <table border='0' width='100%'><tbody>
                    <tr>
                        <td colspan='3' bgcolor='#3399ff' align='center'>
                            <font color='white'><h3><b>1. </b></h3></font>
                        </td>
                        <td colspan='17' bgcolor='gray' align='left'>
                            <font color='white'><h3><b>Housekeeping</b></h3></font>
                        </td>
                    </tr>
                </tbody></table>

                <table border='0' width='100%'><tbody>
                   <tr bgcolor='Silver' border='1'>
                       <font color='white'> 
                        <td colspan='5' rowspan='1' valign='middle' align='center'> Observations </td>            
                        <td colspan='5' rowspan='1' valign='middle' align='left'> Grading</td>
                        <td colspan='10' rowspan='1' valign='middle' align='left'> Comments / Recommendations </td>
                       </font>
                  </tr>
                  <tr bgcolor='whitesmoke'>
                        <td colspan='5' rowspan='1' align='left'> 1.1 Waste bins cleared </td>                         
                        <td colspan='5' rowspan='1' align='left'>
                            <table width='100%'> ");

                                if (CB11.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                                if (CB12.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                                if (CB13.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                            sb.Append(@"</table>
                       </td>
                       <td colspan='10' rowspan='1' align='left'>" + TB1.Text + @"</td>
                 </tr>

                 <tr bgcolor='lightgray'>
                        <td colspan='5' rowspan='1' align='left'>1.2 Combustible waste clear inside and out</td>
                        <td colspan='5' rowspan='1' align='left'> 
                            <table width='100%' >");
                                if (CB21.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                                if (CB22.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                                if (CB23.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }
                            sb.Append(@" </table>
                        </td>
                        <td colspan='10' rowspan='1' align='left'>" + TB2.Text + @" </td>
                </tr>

                <tr bgcolor='whitesmoke'>
                    <td colspan='5' rowspan='1' align='left'> 1.3 Floor areas clear </td>                         
                    <td colspan='5' rowspan='1' align='left'>
                        <table width='100%'> ");

                            if (CB31.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                            if (CB32.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                            if (CB33.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                         sb.Append(@"</table>
                    </td>
                    
                    <td colspan='10' rowspan='1' align='left'>" + TB3.Text + @"</td>
                </tr>


             


             </tbody></table><br>");

                sb.Append(@"<table border='0' width='100%'><tbody>
                <tr>
                <td colspan='3' bgcolor='#3399ff' align='center'>
                <font color='white'><h3><b>2. </b></h3></font>
                </td>
                <td colspan='17' bgcolor='gray' align='left'>
                <font color='white'><h3><b>Fire risks</b></h3></font>
                </td></tr>
                </tbody></table>

                <table border='0' width='100%'><tbody>
   

                   <tr bgcolor='Silver' border='1'>
    

                    <font color='white'>
     
                <td colspan='5' rowspan='1' align='center'> Observations </td>            
                <td colspan='5' rowspan='1' align='left'> Grading</td>
                <td colspan='10' rowspan='1' align='left'> Comments / Recommendations </td>
                          
                                           </font>
                          

                                          </tr>

                <tr bgcolor='whitesmoke'>


                <td colspan='5' rowspan='1' align='left'>2.1 Extinguishers in correct location and in test</td>
                <td colspan='5' rowspan='1' align='left'> 
                <table width='100%' >");
                if (CB41.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB42.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB43.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                </table>
                </td>
                <td colspan='10' rowspan='1' align='left'>" + TB4.Text + @" </td>

                </tr>

                <tr bgcolor='lightgray'>


                <td colspan='5' rowspan='1' align='left'>2.2 Alarm call points identified</td>
                <td colspan='5' rowspan='1' align='left'> 
                <table width='100%' >");
                if (CB51.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB52.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB53.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                </table>
                </td>
                <td colspan='10' rowspan='1' align='left'>" + TB5.Text + @" </td>

                </tr>
                
                <tr bgcolor='whitesmoke'>


                <td colspan='5' rowspan='1' align='left'>2.3 Emergency routes and doors clear</td>
                <td colspan='5' rowspan='1' align='left'> 
                <table width='100%' >");
                if (CB61.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB62.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB63.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                </table>
                        </td>
                        <td colspan='10' rowspan='1' align='left'>" + TB6.Text + @" </td>
                    </tr>
                
                    <tr bgcolor='lightgray'>
                        <td colspan='5' rowspan='1' align='left'>2.4 Emergency exit doors clear</td>
                        <td colspan='5' rowspan='1' align='left'> 
                            <table width='100%' >");
                                if (CB71.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                                if (CB72.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                                if (CB73.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }
                            sb.Append(@" </table>
                        </td>
                        <td colspan='10' rowspan='1' align='left'>" + TB7.Text + @" </td>

                    </tr>
                    <tr bgcolor='whitesmoke'>
                        <td colspan='5' rowspan='1' align='left'>2.5 Emergency lights charging</td>
                        <td colspan='5' rowspan='1' align='left'> 
                            <table width='100%' >");
                                if (CB81.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                                if (CB82.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                                if (CB83.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }
                            sb.Append(@"</table>
                        </td>
                        <td colspan='10' rowspan='1' align='left'>" + TB8.Text + @" </td>
                    </tr>
                     <tr bgcolor='lightgray'>
                        <td colspan='5' rowspan='1' align='left'>2.6 Fire alarm tests completed</td>
                        <td colspan='5' rowspan='1' align='left'> 
                            <table width='100%' >");
                                if (CB91.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                                if (CB92.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                                if (CB93.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }
                            sb.Append(@"</table>
                        </td>
                        <td colspan='10' rowspan='1' align='left'>" + TB9.Text + @" </td>

                    </tr></tbody></table><br>");

                sb.Append(@"<table border='0' width='100%'><tbody>
                <tr>
                <td colspan='3' bgcolor='#3399ff' align='center'>
                <font color='white'><h3><b>3. </b></h3></font>
                </td>
                <td colspan='17' bgcolor='gray' align='left'>
                <font color='white'><h3><b>Lighting</b></h3></font>
                </td></tr>
                </tbody></table>

                                <table border='0' width='100%'><tbody>


                                   <tr bgcolor='Silver' border='1'>


                                    <font color='white'>

                                <td colspan='5' rowspan='1' align='center'> Observations </td>            
                                <td colspan='5' rowspan='1' align='left'> Grading</td>
                                <td colspan='10' rowspan='1' align='left'> Comments / Recommendations </td>

                                                           </font>


                                                          </tr>

                                <tr bgcolor='whitesmoke'>


                                <td colspan='5' rowspan='1' align='left'>3.1 Natural–blinds operative</td>
                                <td colspan='5' rowspan='1' align='left'> 
                                <table width='100%' >");
                if (CB101.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB102.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB103.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                                </table>
                                </td>
                                <td colspan='10' rowspan='1' align='left'>" + TB10.Text + @" </td>

                                </tr>

                                <tr bgcolor='lightgray'>


                                <td colspan='5' rowspan='1' align='left'>3.2 Artificial–Lights all working</td>
                                <td colspan='5' rowspan='1' align='left'> 
                                <table width='100%' >");
                if (CB111.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB112.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB113.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                                </table>
                                </td>
                                <td colspan='10' rowspan='1' align='left'>" + TB11.Text + @" </td>

                                </tr>


                 </tbody></table><br>");




                sb.Append(@"<table border='0' width='100%'><tbody>
                <tr>
                <td colspan='3' bgcolor='#3399ff' align='center'>
                <font color='white'><h3><b>4. </b></h3></font>
                </td>
                <td colspan='17' bgcolor='gray' align='left'>
                <font color='white'><h3><b>Heating</b></h3></font>
                </td></tr>
                </tbody></table>

                                <table border='0' width='100%'><tbody>


                                   <tr bgcolor='Silver' border='1'>


                                    <font color='white'>

                                <td colspan='5' rowspan='1' align='center'> Observations </td>            
                                <td colspan='5' rowspan='1' align='left'> Grading</td>
                                <td colspan='10' rowspan='1' align='left'> Comments / Recommendations </td>

                                                           </font>


                                                          </tr>

                                <tr bgcolor='whitesmoke'>


                                <td colspan='5' rowspan='1' align='left'>4.1 Temperature within limits(16ºC)or(13ºC)</td>
                                <td colspan='5' rowspan='1' align='left'> 
                                <table width='100%' >");
                if (CB121.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB122.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB123.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                                </table>
                                </td>
                                <td colspan='10' rowspan='1' align='left'>" + TB12.Text + @" </td>

                                </tr>

                                <tr bgcolor='lightgray'>


                                <td colspan='5' rowspan='1' align='left'>4.2 Thermometer available</td>
                                <td colspan='5' rowspan='1' align='left'> 
                                <table width='100%' >");
                if (CB131.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB132.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB133.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                                </table>
                                </td>
                                <td colspan='10' rowspan='1' align='left'>" + TB13.Text + @" </td>

                                </tr>
                                 </tbody></table ><br> ");









                sb.Append(@"<table border='0' width='100%'><tbody>
                <tr>
                <td colspan='3' bgcolor='#3399ff' align='center'>
                <font color='white'><h3><b>5. </b></h3></font>
                </td>
                <td colspan='17' bgcolor='gray' align='left'>
                <font color='white'><h3><b>Ventilation</b></h3></font>
                </td></tr>
                </tbody></table>

                                <table border='0' width='100%'><tbody>


                                   <tr bgcolor='Silver' border='1'>


                                    <font color='white'>

                                <td colspan='5' rowspan='1' align='center'> Observations </td>            
                                <td colspan='5' rowspan='1' align='left'> Grading</td>
                                <td colspan='10' rowspan='1' align='left'> Comments / Recommendations </td>

                                                           </font>


                                                          </tr>

                                <tr bgcolor='whitesmoke'>


                                <td colspan='5' rowspan='1' align='left'>5.1 Natural – windows open</td>
                                <td colspan='5' rowspan='1' align='left'> 
                                <table width='100%' >");
                if (CB141.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB142.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB143.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                                </table>
                                </td>
                                <td colspan='10' rowspan='1' align='left'>" + TB14.Text + @" </td>

                                </tr>

                                <tr bgcolor='lightgray'>


                                <td colspan='5' rowspan='1' align='left'>5.2 Artificial – air changes</td>
                                <td colspan='5' rowspan='1' align='left'> 
                                <table width='100%' >");
                if (CB151.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB152.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB153.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                                </table>
                                </td>
                                <td colspan='10' rowspan='1' align='left'>" + TB15.Text + @" </td>

                                </tr>


                                 </tbody></table ><br> ");

                sb.Append(@"<table border='0' width='100%'><tbody>
                <tr>
                <td colspan='3' bgcolor='#3399ff' align='center'>
                <font color='white'><h3><b>6. </b></h3></font>
                </td>
                <td colspan='17' bgcolor='gray' align='left'>
                <font color='white'><h3><b>Electrical</b></h3></font>
                </td></tr>
                </tbody></table>

                                <table border='0' width='100%'><tbody>


                                   <tr bgcolor='Silver' border='1'>


                                    <font color='white'>

                                <td colspan='5' rowspan='1' align='center'> Observations </td>            
                                <td colspan='5' rowspan='1' align='left'> Grading</td>
                                <td colspan='10' rowspan='1' align='left'> Comments / Recommendations </td>

                                                           </font>


                                                          </tr>

                                <tr bgcolor='whitesmoke'>


                                <td colspan='5' rowspan='1' align='left'>6.1 Leads not trailing across floor</td>
                                <td colspan='5' rowspan='1' align='left'> 
                                <table width='100%' >");
                if (CB161.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB162.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB163.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                                </table>
                                </td>
                                <td colspan='10' rowspan='1' align='left'>" + TB16.Text + @" </td>

                                </tr>

                                <tr bgcolor='lightgray'>


                                <td colspan='5' rowspan='1' align='left'>6.2 P.A.T. for all equipment or inspection</td>
                                <td colspan='5' rowspan='1' align='left'> 
                                <table width='100%' >");
                if (CB171.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB172.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB173.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                                </table>
                                </td>
                                <td colspan='10' rowspan='1' align='left'>" + TB17.Text + @" </td>

                                </tr>


                                 </tbody></table ><br> ");

                sb.Append(@"<table border='0' width='100%'><tbody>
                 <tr>
                 <td colspan='3' bgcolor='#3399ff' align='center'>
                 <font color='white'><h3><b>7. </b></h3></font>
                 </td>
                 <td colspan='17' bgcolor='gray' align='left'>
                 <font color='white'><h3><b>Lift trucks</b></h3></font>
                 </td></tr>
                 </tbody></table>

                 <table border='0' width='100%'><tbody>


                    <tr bgcolor='Silver' border='1'>


                     <font color='white'>

                 <td colspan='5' rowspan='1' align='center'> Observations </td>            
                 <td colspan='5' rowspan='1' align='left'> Grading</td>
                 <td colspan='10' rowspan='1' align='left'> Comments / Recommendations </td>

                                            </font>


                                           </tr>

                 <tr bgcolor='whitesmoke'>


                 <td colspan='5' rowspan='1' align='left'>7.1 Operator wearing belts</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB181.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB182.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB183.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB18.Text + @" </td>

                 </tr>

                 <tr bgcolor='lightgray'>


                 <td colspan='5' rowspan='1' align='left'>7.2 Pre-use inspection completed</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB191.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB192.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB193.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB19.Text + @" </td>

                 </tr>

                <tr bgcolor='whitesmoke'>


                 <td colspan='5' rowspan='1' align='left'>7.3 Horn used when entering building</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB201.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB202.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB203.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB20.Text + @" </td>

                 </tr>

                 <tr bgcolor='lightgray'>


                 <td colspan='5' rowspan='1' align='left'>7.4 Forklift correctly parked when not in use</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB211.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB212.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB213.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB21.Text + @" </td>

                 </tr>
                  </tbody></table ><br> ");



                sb.Append(@"<table border='0' width='100%'><tbody>
                 <tr>
                 <td colspan='3' bgcolor='#3399ff' align='center'>
                 <font color='white'><h3><b>8. </b></h3></font>
                 </td>
                 <td colspan='17' bgcolor='gray' align='left'>
                 <font color='white'><h3><b>Signs</b></h3></font>
                 </td></tr>
                 </tbody></table>

                 <table border='0' width='100%'><tbody>


                    <tr bgcolor='Silver' border='1'>


                     <font color='white'>

                 <td colspan='5' rowspan='1' align='center'> Observations </td>            
                 <td colspan='5' rowspan='1' align='left'> Grading</td>
                 <td colspan='10' rowspan='1' align='left'> Comments / Recommendations </td>

                                            </font>


                                           </tr>

                 <tr bgcolor='whitesmoke'>


                 <td colspan='5' rowspan='1' align='left'>8.1 Are correct signs in place</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB221.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB222.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB223.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB22.Text + @" </td>

                 </tr>

                 <tr bgcolor='lightgray'>


                 <td colspan='5' rowspan='1' align='left'>8.2 Are Signs in good condition</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB231.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB232.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB233.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB23.Text + @" </td>

                 </tr>

                <tr bgcolor='whitesmoke'>


                 <td colspan='5' rowspan='1' align='left'>8.3 Any extra signs required</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB241.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB242.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB243.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB24.Text + @" </td>

                 </tr>


                  </tbody></table ><br> ");

                sb.Append(@"<table border='0' width='100%'><tbody>
                 <tr>
                 <td colspan='3' bgcolor='#3399ff' align='center'>
                 <font color='white'><h3><b>9. </b></h3></font>
                 </td>
                 <td colspan='17' bgcolor='gray' align='left'>
                 <font color='white'><h3><b>P.P.E.</b></h3></font>
                 </td></tr>
                 </tbody></table>

                 <table border='0' width='100%'><tbody>


                    <tr bgcolor='Silver' border='1'>


                     <font color='white'>

                 <td colspan='5' rowspan='1' align='center'> Observations </td>            
                 <td colspan='5' rowspan='1' align='left'> Grading</td>
                 <td colspan='10' rowspan='1' align='left'> Comments / Recommendations </td>

                                            </font>


                                           </tr>

                 <tr bgcolor='whitesmoke'>


                 <td colspan='5' rowspan='1' align='left'>9.1 Mandatory P.P.E. being worn</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB251.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB252.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB253.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB25.Text + @" </td>

                 </tr>

                 <tr bgcolor='lightgray'>


                 <td colspan='5' rowspan='1' align='left'>9.2 P.P.E. correctly Stored</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB261.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB262.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB263.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB26.Text + @" </td>

                 </tr>

                <tr bgcolor='whitesmoke'>


                 <td colspan='5' rowspan='1' align='left'>9.3 P.P.E. condition</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB271.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB272.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB273.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB27.Text + @" </td>

                 </tr>


                  </tbody></table ><br> ");
                sb.Append(@"<table border='0' width='100%'><tbody>
                 <tr>
                 <td colspan='3' bgcolor='#3399ff' align='center'>
                 <font color='white'><h3><b>10. </b></h3></font>
                 </td>
                 <td colspan='17' bgcolor='gray' align='left'>
                 <font color='white'><h3><b>First aid</b></h3></font>
                 </td></tr>
                 </tbody></table>

                 <table border='0' width='100%'><tbody>


                    <tr bgcolor='Silver' border='1'>


                     <font color='white'>

                 <td colspan='5' rowspan='1' align='center'> Observations </td>            
                 <td colspan='5' rowspan='1' align='left'> Grading</td>
                 <td colspan='10' rowspan='1' align='left'> Comments / Recommendations </td>

                                            </font>


                                           </tr>

                 <tr bgcolor='whitesmoke'>


                 <td colspan='5' rowspan='1' align='left'>10.1 First aid box accessible and equipped</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB281.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB282.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB283.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB28.Text + @" </td>

                 </tr>

                 <tr bgcolor='lightgray'>


                 <td colspan='5' rowspan='1' align='left'>10.2 First aid materials in date</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB291.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB292.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB293.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB29.Text + @" </td>

                 </tr>

                <tr bgcolor='whitesmoke'>


                 <td colspan='5' rowspan='1' align='left'>10.3 Eye wash station condition</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB301.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB302.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB303.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB30.Text + @" </td>

                 </tr>


                  </tbody></table ><br> ");

                sb.Append(@"<table border='0' width='100%'><tbody>
                 <tr>
                 <td colspan='3' bgcolor='#3399ff' align='center'>
                 <font color='white'><h3><b>11. </b></h3></font>
                 </td>
                 <td colspan='17' bgcolor='gray' align='left'>
                 <font color='white'><h3><b>Risk assessments</b></h3></font>
                 </td></tr>
                 </tbody></table>

                 <table border='0' width='100%'><tbody>


                    <tr bgcolor='Silver' border='1'>


                     <font color='white'>

                 <td colspan='5' rowspan='1' align='center'> Observations </td>            
                 <td colspan='5' rowspan='1' align='left'> Grading</td>
                 <td colspan='10' rowspan='1' align='left'> Comments / Recommendations </td>

                                            </font>


                                           </tr>

                 <tr bgcolor='whitesmoke'>


                 <td colspan='5' rowspan='1' align='left'>11.1 Risk assessments available for task</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB311.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB312.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB313.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB31.Text + @" </td>

                 </tr>

                 <tr bgcolor='lightgray'>


                 <td colspan='5' rowspan='1' align='left'>11.2 Risk assessment being followed</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB321.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB322.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB323.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB32.Text + @" </td>

                 </tr>

                <tr bgcolor='whitesmoke'>


                 <td colspan='5' rowspan='1' align='left'>11.3 Risk assessment signed off</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB331.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB332.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB333.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB33.Text + @" </td>

                 </tr>


                  </tbody></table ><br> ");

                sb.Append(@"<table border='0' width='100%'><tbody>
                 <tr>
                 <td colspan='3' bgcolor='#3399ff' align='center'>
                 <font color='white'><h3><b>12. </b></h3></font>
                 </td>
                 <td colspan='17' bgcolor='gray' align='left'>
                 <font color='white'><h3><b>Safe system of work</b></h3></font>
                 </td></tr>
                 </tbody></table>

                 <table border='0' width='100%'><tbody>


                    <tr bgcolor='Silver' border='1'>


                     <font color='white'>

                 <td colspan='5' rowspan='1' align='center'> Observations </td>            
                 <td colspan='5' rowspan='1' align='left'> Grading</td>
                 <td colspan='10' rowspan='1' align='left'> Comments / Recommendations </td>

                                            </font>


                                           </tr>

                 <tr bgcolor='whitesmoke'>


                 <td colspan='5' rowspan='1' align='left'>12.1 SSOW available for task</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB341.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB342.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB343.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB34.Text + @" </td>

                 </tr>

                 <tr bgcolor='lightgray'>


                 <td colspan='5' rowspan='1' align='left'>12.2 SSOW being followed</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB351.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB352.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB353.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB35.Text + @" </td>

                 </tr>

                <tr bgcolor='whitesmoke'>


                 <td colspan='5' rowspan='1' align='left'>12.3 SSOW signed off</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB361.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB362.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB363.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB36.Text + @" </td>

                 </tr>


                  </tbody></table ><br> ");


                sb.Append(@"<table border='0' width='100%'><tbody>
                 <tr>
                 <td colspan='3' bgcolor='#3399ff' align='center'>
                 <font color='white'><h3><b>13. </b></h3></font>
                 </td>
                 <td colspan='17' bgcolor='gray' align='left'>
                 <font color='white'><h3><b>Racking inspection</b></h3></font>
                 </td></tr>
                 </tbody></table>

                 <table border='0' width='100%'><tbody>


                    <tr bgcolor='Silver' border='1'>


                     <font color='white'>

                 <td colspan='5' rowspan='1' align='center'> Observations </td>            
                 <td colspan='5' rowspan='1' align='left'> Grading</td>
                 <td colspan='10' rowspan='1' align='left'> Comments / Recommendations </td>

                                            </font>


                                           </tr>

                 <tr bgcolor='whitesmoke'>


                 <td colspan='5' rowspan='1' align='left'>13.1 Racking Condition</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB371.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB372.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB373.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB37.Text + @" </td>

                 </tr>



                  </tbody></table ><br> ");

                sb.Append(@"<table border='0' width='100%'><tbody>
                 <tr>
                 <td colspan='3' bgcolor='#3399ff' align='center'>
                 <font color='white'><h3><b>14. </b></h3></font>
                 </td>
                 <td colspan='17' bgcolor='gray' align='left'>
                 <font color='white'><h3><b>COSHH</b></h3></font>
                 </td></tr>
                 </tbody></table>

                 <table border='0' width='100%'><tbody>


                    <tr bgcolor='Silver' border='1'>


                     <font color='white'>

                 <td colspan='5' rowspan='1' align='center'> Observations </td>            
                 <td colspan='5' rowspan='1' align='left'> Grading</td>
                 <td colspan='10' rowspan='1' align='left'> Comments / Recommendations </td>

                                            </font>


                                           </tr>

                 <tr bgcolor='whitesmoke'>


                 <td colspan='5' rowspan='1' align='left'>14.1 Are chemicals safely stored</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB381.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB382.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB383.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB38.Text + @" </td>

                 </tr>

                 <tr bgcolor='lightgray'>


                 <td colspan='5' rowspan='1' align='left'>14.2 Do all chemicals have a COSHH risk assessment</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB391.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB392.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB393.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB39.Text + @" </td>

                 </tr>

                  </tbody></table ><br> ");

                sb.Append(@"<table border='0' width='100%'><tbody>
                 <tr>
                 <td colspan='3' bgcolor='#3399ff' align='center'>
                 <font color='white'><h3><b>15. </b></h3></font>
                 </td>
                 <td colspan='17' bgcolor='gray' align='left'>
                 <font color='white'><h3><b>Welfare</b></h3></font>
                 </td></tr>
                 </tbody></table>

                 <table border='0' width='100%'><tbody>


                    <tr bgcolor='Silver' border='1'>


                     <font color='white'>

                 <td colspan='5' rowspan='1' align='center'> Observations </td>            
                 <td colspan='5' rowspan='1' align='left'> Grading</td>
                 <td colspan='10' rowspan='1' align='left'> Comments / Recommendations </td>

                                            </font>


                                           </tr>

                 <tr bgcolor='whitesmoke'>


                 <td colspan='5' rowspan='1' align='left'>15.1 Toilet cleanliness</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB401.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB402.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB403.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB40.Text + @" </td>

                 </tr>

                 <tr bgcolor='lightgray'>


                 <td colspan='5' rowspan='1' align='left'>15.2 Hand washing facilities and condition</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB411.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB412.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB413.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB41.Text + @" </td>

                 </tr>
                 <tr bgcolor='whitesmoke'>


                 <td colspan='5' rowspan='1' align='left'>15.3 Hand drying facilities</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB421.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB422.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB423.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB42.Text + @" </td>

                 </tr>

                 <tr bgcolor='lightgray'>


                 <td colspan='5' rowspan='1' align='left'>15.4 Kitchen area cleanliness</td>
                 <td colspan='5' rowspan='1' align='left'> 
                 <table width='100%' >");
                if (CB431.Checked) { sb.Append(@"<tr><td><font color='red'><b>[</b></font><b>X</b><font color='red'><b>]  Poor </b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='red'>[ ] Poor </font></td></tr>"); }
                if (CB432.Checked) { sb.Append(@"<tr><td><font color='orange'><b>[</b></font><b>X</b><font color='orange'><b>] Moderate</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='orange'>[ ] Moderate</font></td></tr>"); }
                if (CB433.Checked) { sb.Append(@"<tr><td><font color='green'><b>[</b></font><b>X</b><font color='green'><b>] Good</b></font></td></tr>"); } else { sb.Append(@"<tr><td><font color='green'>[ ] Good</font></td></tr>"); }


                sb.Append(@"

                 </table>
                 </td>
                 <td colspan='10' rowspan='1' align='left'>" + TB43.Text + @" </td>

                 </tr>

                  </tbody></table ><br> ");

                sb.Append(@"
                 <table width='100%'>
                 <tr><font color='white'>
                 <td colspan='8' bgcolor='gray'> Totals (Counts)</td>
                 <td colspan='4' bgcolor='red' align='center'>Poor=" + RedCount.Text +" ("+ Math.Round((double.Parse(RedCount.Text) * 100 / 42),2).ToString() + @"%)</td>
                 <td colspan='4' bgcolor='orange' align='center'>Moderate=" + OrangeCount.Text + " (" + Math.Round((double.Parse(OrangeCount.Text) * 100 / 42),2).ToString() + @"%)</td>
                 <td colspan='4' bgcolor='green' align='center'>Good=" + GreenCount.Text + " (" + Math.Round((double.Parse(GreenCount.Text) * 100 / 42),2).ToString() + @"%)</td>
                 </font>
                 </tr>
                 </table>
                 <br>
                 <table width='100%'>");
                 //<tr>
                 //<td colspan='20' bgcolor='whitesmoke' align='center' ><font color='red' size='8 px'><i>
                 
                 //! If you have 1 or more red counts and/or more than 5 amber counts, Dynamic risk assessment will be required.   
                 //</i></font></td>
                 //</tr>
                 sb.Append(@"<tr bg='lightgray'>
                 <td colspan='20' align='center'> Remarks</td></tr>

                 <tr border='1'>
                 <td colspan='20' align='center'>" + TB44.Text + @"</td></tr>

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

                StringReader sr = new StringReader(sb.ToString());

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
                    SiteName = txt_sitename.Text,
                    date = dat,


                };
                txt_name.Text = txt_projname.Text = txt_sitename.Text = "";

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
                    PerPres=txt_persons.Text,  
                    Desc = txt_Description.Text,
                    CB11 = CB11.Checked ? "1" : "0",
                    CB12 = CB12.Checked ? "1" : "0",
                    CB13 = CB13.Checked ? "1" : "0",
                    CB21 = CB21.Checked ? "1" : "0",
                    CB22 = CB22.Checked ? "1" : "0",
                    CB23 = CB23.Checked ? "1" : "0",
                    CB31 = CB31.Checked ? "1" : "0",
                    CB32 = CB32.Checked ? "1" : "0",
                    CB33 = CB33.Checked ? "1" : "0",
                    CB41 = CB41.Checked ? "1" : "0",
                    CB42 = CB42.Checked ? "1" : "0",
                    CB43 = CB43.Checked ? "1" : "0",
                    CB51 = CB51.Checked ? "1" : "0",
                    CB52 = CB52.Checked ? "1" : "0",
                    CB53 = CB53.Checked ? "1" : "0",
                    CB61 = CB61.Checked ? "1" : "0",
                    CB62 = CB62.Checked ? "1" : "0",
                    CB63 = CB63.Checked ? "1" : "0",
                    CB71 = CB71.Checked ? "1" : "0",
                    CB72 = CB72.Checked ? "1" : "0",
                    CB73 = CB73.Checked ? "1" : "0",
                    CB81 = CB81.Checked ? "1" : "0",
                    CB82 = CB82.Checked ? "1" : "0",
                    CB83 = CB83.Checked ? "1" : "0",
                    CB91 = CB91.Checked ? "1" : "0",
                    CB92 = CB92.Checked ? "1" : "0",
                    CB93 = CB93.Checked ? "1" : "0",
                    CB101 = CB101.Checked ? "1" : "0",
                    CB102 = CB102.Checked ? "1" : "0",
                    CB103 = CB103.Checked ? "1" : "0",
                    CB111 = CB111.Checked ? "1" : "0",
                    CB112 = CB112.Checked ? "1" : "0",
                    CB113 = CB113.Checked ? "1" : "0",
                    CB121 = CB121.Checked ? "1" : "0",
                    CB122 = CB122.Checked ? "1" : "0",
                    CB123 = CB123.Checked ? "1" : "0",
                    CB131 = CB131.Checked ? "1" : "0",
                    CB132 = CB132.Checked ? "1" : "0",
                    CB133 = CB133.Checked ? "1" : "0",
                    CB141 = CB141.Checked ? "1" : "0",
                    CB142 = CB142.Checked ? "1" : "0",
                    CB143 = CB143.Checked ? "1" : "0",
                    CB151 = CB151.Checked ? "1" : "0",
                    CB161 = CB161.Checked ? "1" : "0",
                    CB162 = CB162.Checked ? "1" : "0",
                    CB163 = CB163.Checked ? "1" : "0",
                    CB171 = CB171.Checked ? "1" : "0",
                    CB172 = CB172.Checked ? "1" : "0",
                    CB173 = CB173.Checked ? "1" : "0",
                    CB181 = CB181.Checked ? "1" : "0",
                    CB182 = CB182.Checked ? "1" : "0",
                    CB183 = CB183.Checked ? "1" : "0",
                    CB191 = CB191.Checked ? "1" : "0",
                    CB192 = CB192.Checked ? "1" : "0",
                    CB193 = CB193.Checked ? "1" : "0",

                    CB201 = CB201.Checked ? "1" : "0",
                    CB202 = CB202.Checked ? "1" : "0",
                    CB203 = CB203.Checked ? "1" : "0",
                    CB211 = CB211.Checked ? "1" : "0",
                    CB212 = CB212.Checked ? "1" : "0",
                    CB213 = CB213.Checked ? "1" : "0",
                    CB221 = CB221.Checked ? "1" : "0",
                    CB222 = CB222.Checked ? "1" : "0",
                    CB223 = CB223.Checked ? "1" : "0",
                    CB231 = CB231.Checked ? "1" : "0",
                    CB232 = CB232.Checked ? "1" : "0",
                    CB233 = CB233.Checked ? "1" : "0",
                    CB241 = CB241.Checked ? "1" : "0",
                    CB242 = CB242.Checked ? "1" : "0",
                    CB243 = CB243.Checked ? "1" : "0",
                    CB251 = CB251.Checked ? "1" : "0",
                    CB252 = CB252.Checked ? "1" : "0",
                    CB253 = CB253.Checked ? "1" : "0",
                    CB261 = CB261.Checked ? "1" : "0",
                    CB262 = CB262.Checked ? "1" : "0",
                    CB263 = CB263.Checked ? "1" : "0",
                    CB271 = CB271.Checked ? "1" : "0",
                    CB272 = CB272.Checked ? "1" : "0",
                    CB273 = CB273.Checked ? "1" : "0",
                    CB281 = CB281.Checked ? "1" : "0",
                    CB282 = CB282.Checked ? "1" : "0",
                    CB283 = CB283.Checked ? "1" : "0",
                    CB291 = CB291.Checked ? "1" : "0",
                    CB292 = CB292.Checked ? "1" : "0",
                    CB293 = CB293.Checked ? "1" : "0",
                    CB301 = CB301.Checked ? "1" : "0",
                    CB302 = CB302.Checked ? "1" : "0",
                    CB303 = CB303.Checked ? "1" : "0",
                    CB311 = CB311.Checked ? "1" : "0",
                    CB312 = CB312.Checked ? "1" : "0",
                    CB313 = CB313.Checked ? "1" : "0",

                    CB321 = CB321.Checked ? "1" : "0",
                    CB322 = CB322.Checked ? "1" : "0",
                    CB323 = CB323.Checked ? "1" : "0",
                    CB331 = CB331.Checked ? "1" : "0",
                    CB332 = CB332.Checked ? "1" : "0",
                    CB333 = CB333.Checked ? "1" : "0",

                    CB341 = CB341.Checked ? "1" : "0",
                    CB342 = CB342.Checked ? "1" : "0",
                    CB343 = CB343.Checked ? "1" : "0",
                    CB351 = CB351.Checked ? "1" : "0",
                    CB352 = CB352.Checked ? "1" : "0",
                    CB353 = CB353.Checked ? "1" : "0",
                    CB361 = CB361.Checked ? "1" : "0",
                    CB362 = CB362.Checked ? "1" : "0",
                    CB363 = CB363.Checked ? "1" : "0",
                    CB371 = CB371.Checked ? "1" : "0",
                    CB372 = CB372.Checked ? "1" : "0",
                    CB373 = CB373.Checked ? "1" : "0",
                    CB381 = CB381.Checked ? "1" : "0",
                    CB382 = CB382.Checked ? "1" : "0",
                    CB383 = CB383.Checked ? "1" : "0",
                    CB391 = CB391.Checked ? "1" : "0",
                    CB392 = CB392.Checked ? "1" : "0",
                    CB393 = CB393.Checked ? "1" : "0",
                    CB401 = CB401.Checked ? "1" : "0",
                    CB402 = CB402.Checked ? "1" : "0",
                    CB403 = CB403.Checked ? "1" : "0",
                    CB411 = CB411.Checked ? "1" : "0",
                    CB412 = CB412.Checked ? "1" : "0",
                    CB413 = CB413.Checked ? "1" : "0",
                    CB421 = CB421.Checked ? "1" : "0",
                    CB422 = CB422.Checked ? "1" : "0",
                    CB423 = CB423.Checked ? "1" : "0",
                    CB431 = CB431.Checked ? "1" : "0",
                    CB432 = CB432.Checked ? "1" : "0",
                    CB433 = CB433.Checked ? "1" : "0",
                    TB1 = TB1.Text,
                    TB2 = TB2.Text,
                    TB3 = TB3.Text,
                    TB4 = TB4.Text,
                    TB5 = TB5.Text,
                    TB6 = TB6.Text,
                    TB7 = TB7.Text,
                    TB8 = TB8.Text,
                    TB9 = TB9.Text,
                    TB10 = TB10.Text,
                    TB11 = TB11.Text,
                    TB12 = TB12.Text,
                    TB13 = TB13.Text,
                    TB14 = TB14.Text,
                    TB15 = TB15.Text,
                    TB16 = TB16.Text,
                    TB17 = TB17.Text,
                    TB18 = TB18.Text,
                    TB19 = TB19.Text,
                    TB20 = TB20.Text,
                    TB21 = TB21.Text,
                    TB22 = TB22.Text,
                    TB23 = TB23.Text,
                    TB24 = TB24.Text,
                    TB25 = TB25.Text,
                    TB26 = TB26.Text,
                    TB27 = TB27.Text,
                    TB28 = TB28.Text,
                    TB29 = TB29.Text,
                    TB30 = TB30.Text,
                    TB31 = TB31.Text,
                    TB32 = TB32.Text,
                    TB33 = TB33.Text,
                    TB34 = TB34.Text,
                    TB35 = TB35.Text,
                    TB36 = TB36.Text,
                    TB37 = TB37.Text,
                    TB38 = TB38.Text,
                    TB39 = TB39.Text,
                    TB40 = TB40.Text,
                    TB41 = TB41.Text,
                    TB42 = TB42.Text,
                    TB43 = TB43.Text,
                    TB44 = TB44.Text,

                    RLRed=ResultLblPoor.Text,
                    RLOrange=ResultLblModerate.Text,
                    RLGreen=ResultLblGood.Text,   

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
            txt_projname.Text = account.ProjectName;
            txt_sitename.Text = account.SiteName;
            datepicker.Date = Convert.ToDateTime(account.date);
            txt_Description.Text = account.Desc;
            txt_persons.Text = account.PerPres;  
            if (account.CB11 == "1") { CB11.Checked = true; } else { CB11.Checked = false; }
            if (account.CB12 == "1") { CB12.Checked = true; } else { CB12.Checked = false; }
            if (account.CB13 == "1") { CB13.Checked = true; } else { CB13.Checked = false; }
            if (account.CB21 == "1") { CB21.Checked = true; } else { CB21.Checked = false; }
            if (account.CB22 == "1") { CB22.Checked = true; } else { CB22.Checked = false; }
            if (account.CB23 == "1") { CB23.Checked = true; } else { CB23.Checked = false; }
            if (account.CB31 == "1") { CB31.Checked = true; } else { CB31.Checked = false; }
            if (account.CB32 == "1") { CB32.Checked = true; } else { CB32.Checked = false; }
            if (account.CB33 == "1") { CB33.Checked = true; } else { CB33.Checked = false; }
            if (account.CB41 == "1") { CB41.Checked = true; } else { CB41.Checked = false; }
            if (account.CB42 == "1") { CB42.Checked = true; } else { CB42.Checked = false; }
            if (account.CB43 == "1") { CB43.Checked = true; } else { CB43.Checked = false; }
            if (account.CB51 == "1") { CB51.Checked = true; } else { CB51.Checked = false; }
            if (account.CB52 == "1") { CB52.Checked = true; } else { CB52.Checked = false; }
            if (account.CB53 == "1") { CB53.Checked = true; } else { CB53.Checked = false; }
            if (account.CB61 == "1") { CB61.Checked = true; } else { CB61.Checked = false; }
            if (account.CB62 == "1") { CB62.Checked = true; } else { CB62.Checked = false; }
            if (account.CB63 == "1") { CB63.Checked = true; } else { CB63.Checked = false; }
            if (account.CB71 == "1") { CB71.Checked = true; } else { CB71.Checked = false; }
            if (account.CB72 == "1") { CB72.Checked = true; } else { CB72.Checked = false; }
            if (account.CB73 == "1") { CB73.Checked = true; } else { CB73.Checked = false; }
            if (account.CB81 == "1") { CB81.Checked = true; } else { CB81.Checked = false; }
            if (account.CB82 == "1") { CB82.Checked = true; } else { CB82.Checked = false; }
            if (account.CB83 == "1") { CB83.Checked = true; } else { CB83.Checked = false; }
            if (account.CB91 == "1") { CB91.Checked = true; } else { CB91.Checked = false; }
            if (account.CB92 == "1") { CB92.Checked = true; } else { CB92.Checked = false; }
            if (account.CB93 == "1") { CB93.Checked = true; } else { CB93.Checked = false; }
            if (account.CB101 == "1") { CB101.Checked = true; } else { CB101.Checked = false; }
            if (account.CB102 == "1") { CB102.Checked = true; } else { CB102.Checked = false; }
            if (account.CB103 == "1") { CB103.Checked = true; } else { CB103.Checked = false; }
            if (account.CB111 == "1") { CB111.Checked = true; } else { CB111.Checked = false; }
            if (account.CB112 == "1") { CB112.Checked = true; } else { CB112.Checked = false; }
            if (account.CB113 == "1") { CB113.Checked = true; } else { CB113.Checked = false; }
            if (account.CB121 == "1") { CB121.Checked = true; } else { CB121.Checked = false; }
            if (account.CB122 == "1") { CB122.Checked = true; } else { CB122.Checked = false; }
            if (account.CB123 == "1") { CB123.Checked = true; } else { CB123.Checked = false; }
            if (account.CB131 == "1") { CB131.Checked = true; } else { CB131.Checked = false; }
            if (account.CB132 == "1") { CB132.Checked = true; } else { CB132.Checked = false; }
            if (account.CB133 == "1") { CB133.Checked = true; } else { CB133.Checked = false; }
            if (account.CB141 == "1") { CB141.Checked = true; } else { CB141.Checked = false; }
            if (account.CB142 == "1") { CB142.Checked = true; } else { CB142.Checked = false; }
            if (account.CB143 == "1") { CB143.Checked = true; } else { CB143.Checked = false; }
            if (account.CB151 == "1") { CB151.Checked = true; } else { CB151.Checked = false; }
            if (account.CB161 == "1") { CB161.Checked = true; } else { CB161.Checked = false; }
            if (account.CB162 == "1") { CB162.Checked = true; } else { CB162.Checked = false; }
            if (account.CB163 == "1") { CB163.Checked = true; } else { CB163.Checked = false; }
            if (account.CB171 == "1") { CB171.Checked = true; } else { CB171.Checked = false; }
            if (account.CB172 == "1") { CB172.Checked = true; } else { CB172.Checked = false; }
            if (account.CB173 == "1") { CB173.Checked = true; } else { CB173.Checked = false; }
            if (account.CB181 == "1") { CB181.Checked = true; } else { CB181.Checked = false; }
            if (account.CB182 == "1") { CB182.Checked = true; } else { CB182.Checked = false; }
            if (account.CB183 == "1") { CB183.Checked = true; } else { CB183.Checked = false; }
            if (account.CB191 == "1") { CB191.Checked = true; } else { CB191.Checked = false; }
            if (account.CB192 == "1") { CB192.Checked = true; } else { CB192.Checked = false; }
            if (account.CB193 == "1") { CB193.Checked = true; } else { CB193.Checked = false; }

            if (account.CB211 == "1") { CB211.Checked = true; } else { CB211.Checked = false; }
            if (account.CB212 == "1") { CB212.Checked = true; } else { CB212.Checked = false; }
            if (account.CB213 == "1") { CB213.Checked = true; } else { CB213.Checked = false; }
            if (account.CB221 == "1") { CB221.Checked = true; } else { CB221.Checked = false; }
            if (account.CB222 == "1") { CB222.Checked = true; } else { CB222.Checked = false; }
            if (account.CB223 == "1") { CB223.Checked = true; } else { CB223.Checked = false; }
            if (account.CB231 == "1") { CB231.Checked = true; } else { CB231.Checked = false; }
            if (account.CB232 == "1") { CB232.Checked = true; } else { CB232.Checked = false; }
            if (account.CB233 == "1") { CB233.Checked = true; } else { CB233.Checked = false; }
            if (account.CB241 == "1") { CB241.Checked = true; } else { CB241.Checked = false; }
            if (account.CB242 == "1") { CB242.Checked = true; } else { CB242.Checked = false; }
            if (account.CB243 == "1") { CB243.Checked = true; } else { CB243.Checked = false; }
            if (account.CB251 == "1") { CB251.Checked = true; } else { CB251.Checked = false; }
            if (account.CB261 == "1") { CB261.Checked = true; } else { CB261.Checked = false; }
            if (account.CB262 == "1") { CB262.Checked = true; } else { CB262.Checked = false; }
            if (account.CB263 == "1") { CB263.Checked = true; } else { CB263.Checked = false; }
            if (account.CB271 == "1") { CB271.Checked = true; } else { CB271.Checked = false; }
            if (account.CB272 == "1") { CB272.Checked = true; } else { CB272.Checked = false; }
            if (account.CB273 == "1") { CB273.Checked = true; } else { CB273.Checked = false; }
            if (account.CB281 == "1") { CB281.Checked = true; } else { CB281.Checked = false; }
            if (account.CB282 == "1") { CB282.Checked = true; } else { CB282.Checked = false; }
            if (account.CB283 == "1") { CB283.Checked = true; } else { CB283.Checked = false; }
            if (account.CB291 == "1") { CB291.Checked = true; } else { CB291.Checked = false; }
            if (account.CB292 == "1") { CB292.Checked = true; } else { CB292.Checked = false; }
            if (account.CB293 == "1") { CB293.Checked = true; } else { CB293.Checked = false; }
            if (account.CB301 == "1") { CB301.Checked = true; } else { CB301.Checked = false; }
            if (account.CB302 == "1") { CB302.Checked = true; } else { CB302.Checked = false; }
            if (account.CB303 == "1") { CB303.Checked = true; } else { CB303.Checked = false; }


            if (account.CB311 == "1") { CB311.Checked = true; } else { CB311.Checked = false; }
            if (account.CB312 == "1") { CB312.Checked = true; } else { CB312.Checked = false; }
            if (account.CB313 == "1") { CB313.Checked = true; } else { CB313.Checked = false; }
            if (account.CB321 == "1") { CB321.Checked = true; } else { CB321.Checked = false; }
            if (account.CB322 == "1") { CB322.Checked = true; } else { CB322.Checked = false; }
            if (account.CB323 == "1") { CB323.Checked = true; } else { CB323.Checked = false; }
            if (account.CB331 == "1") { CB331.Checked = true; } else { CB331.Checked = false; }
            if (account.CB332 == "1") { CB332.Checked = true; } else { CB332.Checked = false; }
            if (account.CB333 == "1") { CB333.Checked = true; } else { CB333.Checked = false; }
            if (account.CB341 == "1") { CB341.Checked = true; } else { CB341.Checked = false; }
            if (account.CB342 == "1") { CB342.Checked = true; } else { CB342.Checked = false; }
            if (account.CB343 == "1") { CB343.Checked = true; } else { CB343.Checked = false; }
            if (account.CB351 == "1") { CB351.Checked = true; } else { CB351.Checked = false; }
            if (account.CB361 == "1") { CB361.Checked = true; } else { CB361.Checked = false; }
            if (account.CB362 == "1") { CB362.Checked = true; } else { CB362.Checked = false; }
            if (account.CB363 == "1") { CB363.Checked = true; } else { CB363.Checked = false; }
            if (account.CB371 == "1") { CB371.Checked = true; } else { CB371.Checked = false; }
            if (account.CB372 == "1") { CB372.Checked = true; } else { CB372.Checked = false; }
            if (account.CB373 == "1") { CB373.Checked = true; } else { CB373.Checked = false; }
            if (account.CB381 == "1") { CB381.Checked = true; } else { CB381.Checked = false; }
            if (account.CB382 == "1") { CB382.Checked = true; } else { CB382.Checked = false; }
            if (account.CB383 == "1") { CB383.Checked = true; } else { CB383.Checked = false; }
            if (account.CB391 == "1") { CB391.Checked = true; } else { CB391.Checked = false; }
            if (account.CB392 == "1") { CB392.Checked = true; } else { CB392.Checked = false; }
            if (account.CB393 == "1") { CB393.Checked = true; } else { CB393.Checked = false; }
            if (account.CB401 == "1") { CB401.Checked = true; } else { CB401.Checked = false; }
            if (account.CB402 == "1") { CB402.Checked = true; } else { CB402.Checked = false; }
            if (account.CB403 == "1") { CB403.Checked = true; } else { CB403.Checked = false; }

            if (account.CB411 == "1") { CB411.Checked = true; } else { CB411.Checked = false; }
            if (account.CB412 == "1") { CB412.Checked = true; } else { CB412.Checked = false; }
            if (account.CB413 == "1") { CB413.Checked = true; } else { CB413.Checked = false; }
            if (account.CB421 == "1") { CB421.Checked = true; } else { CB421.Checked = false; }
            if (account.CB422 == "1") { CB422.Checked = true; } else { CB422.Checked = false; }
            if (account.CB423 == "1") { CB423.Checked = true; } else { CB423.Checked = false; }
            if (account.CB431 == "1") { CB431.Checked = true; } else { CB431.Checked = false; }
            if (account.CB432 == "1") { CB432.Checked = true; } else { CB432.Checked = false; }
            if (account.CB433 == "1") { CB433.Checked = true; } else { CB433.Checked = false; }

            TB1.Text = account.TB1;
            TB2.Text = account.TB2;
            TB3.Text = account.TB3;
            TB4.Text = account.TB4;
            TB5.Text = account.TB5;
            TB6.Text = account.TB6;
            TB7.Text = account.TB7;
            TB8.Text = account.TB8;
            TB9.Text = account.TB9;
            TB10.Text = account.TB10;
            TB11.Text = account.TB11;
            TB12.Text = account.TB12;
            TB13.Text = account.TB13;
            TB14.Text = account.TB14;
            TB15.Text = account.TB15;
            TB16.Text = account.TB16;
            TB17.Text = account.TB17;
            TB18.Text = account.TB18;
            TB19.Text = account.TB19;
            TB20.Text = account.TB20;

            TB20.Text = account.TB20;
            TB21.Text = account.TB21;
            TB22.Text = account.TB22;
            TB23.Text = account.TB23;
            TB24.Text = account.TB24;
            TB25.Text = account.TB25;
            TB26.Text = account.TB26;
            TB27.Text = account.TB27;
            TB28.Text = account.TB28;
            TB29.Text = account.TB29;
            TB30.Text = account.TB30;

            TB30.Text = account.TB30;
            TB31.Text = account.TB31;
            TB32.Text = account.TB32;
            TB33.Text = account.TB33;
            TB34.Text = account.TB34;
            TB35.Text = account.TB35;
            TB36.Text = account.TB36;
            TB37.Text = account.TB37;
            TB38.Text = account.TB38;
            TB39.Text = account.TB39;
            TB40.Text = account.TB40;
            TB41.Text = account.TB41;
            TB42.Text = account.TB42;
            TB43.Text = account.TB43;
            TB44.Text = account.TB44;
            
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

            ResultLblPoor.Text = account.RLRed;
            ResultLblModerate.Text  = account.RLOrange;
            ResultLblGood.Text   = account.RLGreen;

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
            public string Desc { get; set; }
            public string PerPres { get; set; }
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
            public string CB201 { get; set; }
            public string CB202 { get; set; }
            public string CB203 { get; set; }
            public string CB211 { get; set; }
            public string CB212 { get; set; }
            public string CB213 { get; set; }
            public string CB221 { get; set; }
            public string CB222 { get; set; }
            public string CB223 { get; set; }
            public string CB231 { get; set; }
            public string CB232 { get; set; }
            public string CB233 { get; set; }
            public string CB241 { get; set; }
            public string CB242 { get; set; }
            public string CB243 { get; set; }
            public string CB251 { get; set; }
            public string CB252 { get; set; }
            public string CB253 { get; set; }
            public string CB261 { get; set; }
            public string CB262 { get; set; }
            public string CB263 { get; set; }
            public string CB271 { get; set; }
            public string CB272 { get; set; }
            public string CB273 { get; set; }
            public string CB281 { get; set; }
            public string CB282 { get; set; }
            public string CB283 { get; set; }
            public string CB291 { get; set; }
            public string CB292 { get; set; }
            public string CB293 { get; set; }
            public string CB301 { get; set; }
            public string CB302 { get; set; }
            public string CB303 { get; set; }
            public string CB311 { get; set; }
            public string CB312 { get; set; }
            public string CB313 { get; set; }
            public string CB321 { get; set; }
            public string CB322 { get; set; }
            public string CB323 { get; set; }
            public string CB331 { get; set; }
            public string CB332 { get; set; }
            public string CB333 { get; set; }
            public string CB341 { get; set; }
            public string CB342 { get; set; }
            public string CB343 { get; set; }
            public string CB351 { get; set; }
            public string CB352 { get; set; }
            public string CB353 { get; set; }
            public string CB361 { get; set; }
            public string CB362 { get; set; }
            public string CB363 { get; set; }

            public string CB371 { get; set; }
            public string CB372 { get; set; }
            public string CB373 { get; set; }
            public string CB381 { get; set; }
            public string CB382 { get; set; }
            public string CB383 { get; set; }
            public string CB391 { get; set; }
            public string CB392 { get; set; }
            public string CB393 { get; set; }
            public string CB401 { get; set; }
            public string CB402 { get; set; }
            public string CB403 { get; set; }
            public string CB411 { get; set; }
            public string CB412 { get; set; }
            public string CB413 { get; set; }
            public string CB421 { get; set; }
            public string CB422 { get; set; }
            public string CB423 { get; set; }
            public string CB431 { get; set; }
            public string CB432 { get; set; }
            public string CB433 { get; set; }

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
            public string TB21 { get; set; }
            public string TB22 { get; set; }
            public string TB23 { get; set; }
            public string TB24 { get; set; }
            public string TB25 { get; set; }
            public string TB26 { get; set; }
            public string TB27 { get; set; }
            public string TB28 { get; set; }
            public string TB29 { get; set; }
            public string TB30 { get; set; }
            public string TB31 { get; set; }
            public string TB32 { get; set; }
            public string TB33 { get; set; }
            public string TB34 { get; set; }
            public string TB35 { get; set; }
            public string TB36 { get; set; }
            public string TB37 { get; set; }
            public string TB38 { get; set; }
            public string TB39 { get; set; }
            public string TB40 { get; set; }
            public string TB41 { get; set; }
            public string TB42 { get; set; }
            public string TB43 { get; set; }
            public string TB44 { get; set; }

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

            public string RLRed { get; set; }
            public string RLOrange { get; set; }
            public string RLGreen { get; set; }

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

     
    }
}
