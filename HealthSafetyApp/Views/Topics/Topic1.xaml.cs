﻿
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;

using Newtonsoft.Json;
using Acr.UserDialogs;
using System.Globalization;
using Plugin.Media;

using HealthSafetyApp.Helpers;
using Microsoft.AppCenter.Crashes;

using Xamarin.Essentials;
using PCLStorage;
using SkiaSharp;
using HealthSafetyApp.Models;
using FileSystem = PCLStorage.FileSystem;
using FileAccess = PCLStorage.FileAccess;
using iText.Html2pdf;
using iText.Kernel.Pdf;
using iText.Kernel.Geom;
using iText.Layout;
using iText.Layout.Element;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using static System.Net.WebRequestMethods;
using HealthSafetyApp.ViewModels;
using Org.BouncyCastle.Crypto;
using Microsoft.Extensions.Primitives;
using iText.Commons.Utils;
using static iText.Layout.Borders.Border;
using static System.Net.Mime.MediaTypeNames;

namespace HealthSafetyApp.Views.Topics
{
    public partial class Topic1 : ContentPage
    {
        private List<Team> Teams = new List<Team>();

private string fileText;
        int a_up, b_up, c_up, a_low, b_low, c_low, a_new, b_new, c_new, a_new1, b_new1, c_new1, a_new2, b_new2, c_new2 = 0;
        int a_up1, b_up1, c_up1, a_low1, b_low1, c_low1 = 0;

        int a_up2, b_up2, c_up2, a_low2, b_low2, c_low2 = 0;
        string c_up2_color, c_low2_color;

        int a_up3, b_up3, c_up3, a_low3, b_low3, c_low3 = 0;
        string c_up3_color, c_low3_color;

        int a_up4, b_up4, c_up4, a_low4, b_low4, c_low4 = 0;
        string c_up4_color, c_low4_color;

        int a_up5, b_up5, c_up5, a_low5, b_low5, c_low5 = 0;
        string c_up5_color, c_low5_color;

        int a_up6, b_up6, c_up6, a_low6, b_low6, c_low6 = 0;
        string c_up6_color, c_low6_color;

        int a_up7, b_up7, c_up7, a_low7, b_low7, c_low7 = 0;
        string c_up7_color, c_low7_color;

        int a_up8, b_up8, c_up8, a_low8, b_low8, c_low8 = 0;
        string c_up8_color, c_low8_color;

        int a_up9, b_up9, c_up9, a_low9, b_low9, c_low9 = 0;
        string c_up9_color, c_low9_color;

        int a_up10, b_up10, c_up10, a_low10, b_low10, c_low10 = 0;
        string c_up10_color, c_low10_color;


        string c_up_color, c_up1_color;
        string c_low_color, c_low1_color;

        string c_new_color;
        string c_new1_color;
        int count = 0;
        int img_count;

        // Picker pck;
        private string filname;
        
        private void OnClicked_DelLine2(object sender, EventArgs e)
        {

            count--;
            fill_text_11.IsVisible = false;
            fill_text_12.IsVisible = false;
            Add_btn1.IsVisible = true;
            Add_btn2.IsVisible = false;

        }

        private void OnClicked_DelLine3(object sender, EventArgs e)
        {

            count--;
            fill_text_21.IsVisible = false;
            fill_text_22.IsVisible = false;
            Add_btn2.IsVisible = true;
            Add_btn3.IsVisible = false;

        }

        private void OnClicked_DelLine4(object sender, EventArgs e)
        {

            count--;
            fill_text_31.IsVisible = false;
            fill_text_32.IsVisible = false;
            Add_btn3.IsVisible = true;
            Add_btn4.IsVisible = false;

        }
        private void OnClicked_DelLine5(object sender, EventArgs e)
        {

            count--;
            fill_text_41.IsVisible = false;
            fill_text_42.IsVisible = false;
            Add_btn4.IsVisible = true;
            Add_btn5.IsVisible = false;

        }
        private void OnClicked_DelLine6(object sender, EventArgs e)
        {

            count--;
            fill_text_51.IsVisible = false;
            fill_text_52.IsVisible = false;
            Add_btn5.IsVisible = true;
            Add_btn6.IsVisible = false;

        }

        private void OnClicked_DelLine7(object sender, EventArgs e)
        {

            count--;
            fill_text_61.IsVisible = false;
            fill_text_62.IsVisible = false;
            Add_btn6.IsVisible = true;
            Add_btn7.IsVisible = false;

        }
        private void OnClicked_DelLine8(object sender, EventArgs e)
        {

            count--;
            fill_text_71.IsVisible = false;
            fill_text_72.IsVisible = false;
            Add_btn7.IsVisible = true;
            Add_btn8.IsVisible = false;

        }
        private void OnClicked_DelLine9(object sender, EventArgs e)
        {

            count--;
            fill_text_81.IsVisible = false;
            fill_text_82.IsVisible = false;
            Add_btn8.IsVisible = true;
            Add_btn9.IsVisible = false;

        }
        private void OnClicked_DelLine10(object sender, EventArgs e)
        {

            count--;
            fill_text_91.IsVisible = false;
            fill_text_92.IsVisible = false;
            Add_btn9.IsVisible = true;
            Add_btn10.IsVisible = false;

        }

        private void OnClicked_DelLine11(object sender, EventArgs e)
        {
            {

                count--;
                fill_text_101.IsVisible = false;
                fill_text_102.IsVisible = false;
                Add_btn10.IsVisible = true;
                Add_btn11.IsVisible = false;

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
                if (s > 1)
                {
                    s--;
                }
                else { s = img_count; }

                if (s == 0)
                {
                    Image1.Source = "";
                    ActImg.Text = s.ToString();
                    return;
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
        
        

        public Topic1(string filenam)
        {
            
            try
            {
                InitializeComponent();
                filname = filenam;
                this.Title = "Dynamic risk assessment tool";

                img_count = 0;
                Teams.Add(new Team
                {
                    SNo = 5,
                    Name = 0,
                    Win = 5,
                    Loose = 10,
                    Percentage = 20,
                    Conf = "43 - 9",
                    Div = "25",
                    Home = 15,
                    Road = "34 - 7",
                    Last10 = "8 - 2",
                    Streak = 25,
                    Logo = "Fatality, Disabling injury, etc"
                });
                Teams.Add(new Team
                {
                    SNo = 4,
                    Name = 0,
                    Win = 4,
                    Loose = 8,
                    Percentage = 16,
                    Conf = "43 - 9",
                    Div = "14 - 2",
                    Home = 12,
                    Road = "27 - 14",
                    Last10 = "6 - 4",
                    Streak = 20,
                    Logo = "Major injury or illness"
                });
                Teams.Add(new Team
                {
                    SNo = 3,
                    Name = 0,
                    Win = 3,
                    Loose = 6,
                    Percentage = 12,
                    Conf = "37 - 15",
                    Div = "13 - 3",
                    Home = 9,
                    Road = "23 - 18",
                    Last10 = "5 - 5",
                    Streak = 15,
                    Logo = "7 day Injury or illness"

                });
                Teams.Add(new Team
                {
                    SNo = 2,
                    Name = 0,
                    Win = 2,
                    Loose = 4,
                    Percentage = 8,
                    Conf = "31 - 21",
                    Div = "9 - 7",
                    Home = 6,
                    Road = "24 - 17",
                    Last10 = "8 - 2",
                    Streak = 10,
                    Logo = "Minor injury or illness"
                });
                Teams.Add(new Team
                {
                    SNo = 1,
                    Name = 0,
                    Win = 1,
                    Loose = 2,
                    Percentage = 4,
                    Conf = "29 - 23",
                    Div = "11 - 5",
                    Home = 3,
                    Road = "16 - 25",
                    Last10 = "7 - 3",
                    Streak = 5,
                    Logo = "First aid injury or illness"
                });
                Teams.Add(new Team
                {
                    SNo = 0,
                    Name = 0,
                    Win = 0,
                    Loose = 0,
                    Percentage = 0,
                    Conf = "27 - 25",
                    Div = "7 - 9",
                    Home = 0,
                    Road = "19 - 22",
                    Last10 = "7 - 3",
                    Streak = 0,
                    Logo = "No injury or illness"
                });


            }
            catch (Exception exception)
            {
                Crashes.TrackError(exception);
            }
        }

        private void Datechanged(object sender, DateChangedEventArgs e)
        {
            //var picker = sender as Xamarin.Forms.DatePicker;
            //if (picker.Date != null) { 
            //picker.Date = picker.Date.ToLocalTime();
            //}
        }

        protected async override void OnAppearing()
        {
            try
            {
                
                    base.OnAppearing();
                    //Xamarin.Forms.DataGrid.DataGridComponent.Init();
                    
                    if (pick_a_up.SelectedItem is null) { pick_a_up.SelectedIndex = 0; }
                    if (pick_b_up.SelectedItem is null) { pick_b_up.SelectedIndex = 0; }
                    if (pick_a_low.SelectedItem is null) { pick_a_low.SelectedIndex = 0; }
                    if (pick_b_low.SelectedItem is null) { pick_b_low.SelectedIndex = 0; }
                    
                    if (filname != "1")
                    {
                        await PCLReadJson();
                    }

                    //grdfill_text.IsVisible = false;
                    //grdfill_textnew1.IsVisible = false;
                    //grdfill_textnew2.IsVisible = false;
                
            }
            catch (Exception exception)
            {
                Crashes.TrackError(exception);
            }
        }

        private async Task PCLReadJson()
        {
            try
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
                using (var stream = await file.OpenAsync(FileAccess.Read))
                using (var reader = new StreamReader(stream))
                {
                    FileText = await reader.ReadToEndAsync();
                }


                DraftFields account = JsonConvert.DeserializeObject<DraftFields>(FileText);
                    txt_name.Text = account.Name1;
                    txt_projname.Text = account.ProjectName;
                    txt_sitename.Text = account.SiteName;
                    txt_Check2_text.Text = account.CheckBox1data;
                    if (account.CheckBox1data != null)
                    { chkbx1.IsChecked = true; }
                    txt_Check2_text.Text = account.CheckBox2data;
                    if (account.CheckBox2data != null)
                    { chkbx2.IsChecked = true; }
                    datepicker.Date = Convert.ToDateTime(account.Date);

                    pick_1.SelectedItem = account.pick1;
                    pick_2.SelectedItem = account.pick2;


                    pick_3.SelectedItem = account.pick3;
                    pick_4.SelectedItem = account.pick4;

                    pick2_1.SelectedItem = account.pick2_1;
                    pick2_2.SelectedItem = account.pick2_2;
                    pick2_3.SelectedItem = account.pick2_3;
                    pick2_4.SelectedItem = account.pick2_4;
                    pick2_5.SelectedItem = account.pick2_5;
                    pick2_6.SelectedItem = account.pick2_6;
                    pick2_7.SelectedItem = account.pick2_7;
                    pick2_8.SelectedItem = account.pick2_8;

                    pick2_9.SelectedItem = account.pick2_9;
                    pick2_10.SelectedItem = account.pick2_10;
                    pick2_11.SelectedItem = account.pick2_11;
                    pick2_12.SelectedItem = account.pick2_12;
                    pick2_13.SelectedItem = account.pick2_13;
                    pick2_14.SelectedItem = account.pick2_14;
                    pick2_15.SelectedItem = account.pick2_15;
                    pick2_16.SelectedItem = account.pick2_16;

                    pick2_17.SelectedItem = account.pick2_17;
                    pick2_18.SelectedItem = account.pick2_18;
                    pick2_19.SelectedItem = account.pick2_19;
                    pick2_20.SelectedItem = account.pick2_20;
                    pick2_21.SelectedItem = account.pick2_21;
                    pick2_22.SelectedItem = account.pick2_22;
                    pick2_23.SelectedItem = account.pick2_23;
                    pick2_24.SelectedItem = account.pick2_24;



                    step2_other.Text = account.step2_other;
                    pick3_1.SelectedItem = account.pick3_1;

                    txt_fill1.Text = account.fillable_txt1;
                    txt_fill2.Text = account.fillable_txt2;


                    txt_Check_text11.Text = account.fillable_txt3;
                    txt_Check_text12.Text = account.fillable_txt4;
                    txt_Check_text21.Text = account.fillable_txt5;
                    txt_Check_text22.Text = account.fillable_txt6;
                    txt_Check_text31.Text = account.fillable_txt7;
                    txt_Check_text32.Text = account.fillable_txt8;
                    txt_Check_text41.Text = account.fillable_txt9;
                    txt_Check_text42.Text = account.fillable_txt10;

                    txt_Check_text51.Text = account.fillable_txt11;
                    txt_Check_text52.Text = account.fillable_txt12;
                    txt_Check_text61.Text = account.fillable_txt13;
                    txt_Check_text62.Text = account.fillable_txt14;
                    txt_Check_text71.Text = account.fillable_txt15;
                    txt_Check_text72.Text = account.fillable_txt16;
                    txt_Check_text81.Text = account.fillable_txt17;
                    txt_Check_text82.Text = account.fillable_txt18;
                    txt_Check_text91.Text = account.fillable_txt19;
                    txt_Check_text92.Text = account.fillable_txt20;
                    txt_Check_text101.Text = account.fillable_txt21;
                    txt_Check_text102.Text = account.fillable_txt22;

                    pick_a_up.SelectedItem = account.a_up;
                    pick_b_up.SelectedItem = account.b_up;
                    //txt_resultup   = account.c_up.ToString();

                    pick_a_low.SelectedItem = account.a_low;
                    pick_b_low.SelectedItem = account.b_low;
                    //txt_resultlow  = account.c_low.ToString();

                    //pick_a_ne = account.a_new;
                    //b_new = account.b_new;
                    //c_new = account.c_new;
                    //a_new1 = account.a_new1;
                    //b_new1 = account.b_new1;
                    //c_new1 = account.c_new1;
                    //a_new2 = account.a_new2;
                    //b_new2 = account.b_new2;
                    //c_new2 = account.c_new2;
                    pick_a_up1.SelectedItem = account.a_up1;
                    pick_b_up1.SelectedItem = account.b_up1;
                    //txt_resultup1 = account.c_up1;
                    pick_a_low1.SelectedItem = account.a_low1;
                    pick_b_low1.SelectedItem = account.b_low1;
                    //txt_resultlow1  = account.c_low1;

                    pick_a_up2.SelectedItem = account.a_up2;
                    pick_b_up2.SelectedItem = account.b_up2;
                    //txt_resultup2  = account.c_up2;
                    pick_a_low2.SelectedItem = account.a_low2;
                    pick_b_low2.SelectedItem = account.b_low2;
                    //txt_resultlow2 = account.c_low2;

                    pick_a_up3.SelectedItem = account.a_up3;
                    pick_b_up3.SelectedItem = account.b_up3;
                    // txt_resultup3 = account.c_up3;
                    pick_a_low3.SelectedItem = account.a_low3;
                    pick_b_low3.SelectedItem = account.b_low3;
                    //txt_resultlow3 = account.c_low3;

                    pick_a_up4.SelectedItem = account.a_up4;
                    pick_b_up4.SelectedItem = account.b_up4;
                    //c_up4 = account.c_up4;
                    pick_a_low4.SelectedItem = account.a_low4;
                    pick_b_low4.SelectedItem = account.b_low4;
                    //c_low4 = account.c_low4;

                    pick_a_up5.SelectedItem = account.a_up5;
                    pick_b_up5.SelectedItem = account.b_up5;
                    //c_up5 = account.c_up5;
                    pick_a_low5.SelectedItem = account.a_low5;
                    pick_b_low5.SelectedItem = account.b_low5;
                    //c_low5 = account.c_low5;

                    pick_a_up6.SelectedItem = account.a_up6;
                    pick_b_up6.SelectedItem = account.b_up6;
                    //c_up6 = account.c_up6;
                    pick_a_low6.SelectedItem = account.a_low6;
                    pick_b_low6.SelectedItem = account.b_low6;
                    //c_low6 = account.c_low6;

                    pick_a_up7.SelectedItem = account.a_up7;
                    pick_b_up7.SelectedItem = account.b_up7;
                    //c_up7 = account.c_up7;
                    pick_a_low7.SelectedItem = account.a_low7;
                    pick_b_low7.SelectedItem = account.b_low7;
                    //c_low7 = account.c_low7;

                    pick_a_up8.SelectedItem = account.a_up8;
                    pick_b_up8.SelectedItem = account.b_up8;
                    //c_up8 = account.c_up8;
                    pick_a_low8.SelectedItem = account.a_low8;
                    pick_b_low8.SelectedItem = account.b_low8;
                    //c_low8 = account.c_low8;

                    pick_a_up9.SelectedItem = account.a_up9;
                    pick_b_up9.SelectedItem = account.b_up9;
                    //c_up9 = account.c_up9;
                    pick_a_low9.SelectedItem = account.a_low9;
                    pick_b_low9.SelectedItem = account.b_low9;
                    //c_low9 = account.c_low9;

                    pick_a_up10.SelectedItem = account.a_up10;
                    pick_b_up10.SelectedItem = account.b_up10;
                    //c_up10 = account.c_up10;
                    pick_a_low10.SelectedItem = account.a_low10;
                    pick_b_low10.SelectedItem = account.b_low10;
                    //c_low10 = account.c_low10;
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
                    if (account.add_btn1 == true) { Add_btn1.IsVisible = true; } else { Add_btn1.IsVisible = false; }

                    if (account.add_btn2 == true)
                    {
                        fill_text_11.IsVisible = true;
                        fill_text_12.IsVisible = true;
                        Add_btn1.IsVisible = false;
                        Add_btn2.IsVisible = true;
                    }
                    else
                    {
                        fill_text_11.IsVisible = false;
                        fill_text_12.IsVisible = false;
                        Add_btn1.IsVisible = true;
                        Add_btn2.IsVisible = false;
                    }

                    if (account.add_btn3 == true)
                    {
                        fill_text_21.IsVisible = true;
                        fill_text_22.IsVisible = true;
                        Add_btn3.IsVisible = true;
                        Add_btn2.IsVisible = false;
                    }
                    else
                    {
                        fill_text_21.IsVisible = false;
                        fill_text_22.IsVisible = false;
                        Add_btn3.IsVisible = false;

                    }

                    if (account.add_btn4 == true)
                    {
                        fill_text_31.IsVisible = true;
                        fill_text_32.IsVisible = true;
                        Add_btn4.IsVisible = true;
                        Add_btn3.IsVisible = false;
                    }
                    else
                    {
                        fill_text_31.IsVisible = false;
                        fill_text_32.IsVisible = false;
                        Add_btn4.IsVisible = false;
                    }

                    if (account.add_btn5 == true)
                    {
                        fill_text_41.IsVisible = true;
                        fill_text_42.IsVisible = true;
                        Add_btn5.IsVisible = true;
                        Add_btn4.IsVisible = false;
                    }
                    else
                    {
                        fill_text_41.IsVisible = false;
                        fill_text_42.IsVisible = false;
                        Add_btn5.IsVisible = false;
                    }
                    if (account.add_btn6 == true)
                    {
                        fill_text_51.IsVisible = true;
                        fill_text_52.IsVisible = true;
                        Add_btn6.IsVisible = true;
                        Add_btn5.IsVisible = false;
                    }
                    else
                    {
                        fill_text_51.IsVisible = false;
                        fill_text_52.IsVisible = false;
                        Add_btn6.IsVisible = false;
                    }
                    if (account.add_btn7 == true)
                    {
                        fill_text_61.IsVisible = true;
                        fill_text_62.IsVisible = true;
                        Add_btn7.IsVisible = true;
                        Add_btn6.IsVisible = false;
                    }
                    else
                    {
                        fill_text_61.IsVisible = false;
                        fill_text_62.IsVisible = false;
                        Add_btn7.IsVisible = false;
                    }

                    if (account.add_btn8 == true)
                    {
                        fill_text_71.IsVisible = true;
                        fill_text_72.IsVisible = true;
                        Add_btn8.IsVisible = true;
                        Add_btn7.IsVisible = false;
                    }
                    else
                    {
                        fill_text_71.IsVisible = false;
                        fill_text_72.IsVisible = false;
                        Add_btn8.IsVisible = false;
                    }

                    if (account.add_btn9 == true)
                    {
                        fill_text_81.IsVisible = true;
                        fill_text_82.IsVisible = true;
                        Add_btn9.IsVisible = true;
                        Add_btn8.IsVisible = false;
                    }
                    else
                    {
                        fill_text_81.IsVisible = false;
                        fill_text_82.IsVisible = false;
                        Add_btn9.IsVisible = false;
                    }

                    if (account.add_btn10 == true)
                    {
                        fill_text_91.IsVisible = true;
                        fill_text_92.IsVisible = true;
                        Add_btn10.IsVisible = true;
                        Add_btn9.IsVisible = false;
                    }
                    else
                    {
                        fill_text_91.IsVisible = false;
                        fill_text_92.IsVisible = false;
                        Add_btn10.IsVisible = false;
                    }

                    if (account.add_btn11 == true)
                    {
                        fill_text_101.IsVisible = true;
                        fill_text_102.IsVisible = true;
                        Add_btn11.IsVisible = true;
                        Add_btn10.IsVisible = true;
                    }
                    else
                    {
                        fill_text_101.IsVisible = false;
                        fill_text_102.IsVisible = false;
                        Add_btn11.IsVisible = false;
                        Add_btn10.IsVisible = false;
                    }

                
            }
            catch (Exception ex)
            {

            }
        }

        //Click New Line Method
        private void OnClicked_NewLine(object sender, EventArgs e)
        {
            count++;
            //if (count == 1)
            //{
            pick_a_up1.SelectedIndex = 0;
            pick_a_low1.SelectedIndex = 0;
            pick_b_up1.SelectedIndex = 0;
            pick_b_low1.SelectedIndex = 0;

            fill_text_11.IsVisible = true;
            fill_text_12.IsVisible = true;
            Add_btn1.IsVisible = false;
            Add_btn2.IsVisible = true;
            //grdfill_text.IsVisible = true;
            //    grdfill_textnew1.IsVisible = true;
            //}
            //if (count == 10)
            //    btn_newline.IsVisible = false;
        }

        private void OnClicked_NewLine2(object sender, EventArgs e)
        {
            count++;

            pick_a_up2.SelectedIndex = 0;
            pick_a_low2.SelectedIndex = 0;
            pick_b_up2.SelectedIndex = 0;
            pick_b_low2.SelectedIndex = 0;

            fill_text_21.IsVisible = true;
            fill_text_22.IsVisible = true;
            Add_btn2.IsVisible = false;
            Add_btn3.IsVisible = true;
            //}
            //if (count == 10)
            //    btn_newline.IsVisible = false;
        }
        private void OnClicked_NewLine3(object sender, EventArgs e)
        {
            count++;
            pick_a_up3.SelectedIndex = 0;
            pick_a_low3.SelectedIndex = 0;
            pick_b_up3.SelectedIndex = 0;
            pick_b_low3.SelectedIndex = 0;

            fill_text_31.IsVisible = true;
            fill_text_32.IsVisible = true;
            Add_btn3.IsVisible = false;
            Add_btn4.IsVisible = true;
            //}
            //if (count == 10)
            //    btn_newline.IsVisible = false;
        }
        private void OnClicked_NewLine4(object sender, EventArgs e)
        {
            count++;
            pick_a_up4.SelectedIndex = 0;
            pick_a_low4.SelectedIndex = 0;
            pick_b_up4.SelectedIndex = 0;
            pick_b_low4.SelectedIndex = 0;
            fill_text_41.IsVisible = true;
            fill_text_42.IsVisible = true;
            Add_btn4.IsVisible = false;
            Add_btn5.IsVisible = true;
            //}
            //if (count == 10)
            //    btn_newline.IsVisible = false;
        }
        private void OnClicked_NewLine5(object sender, EventArgs e)
        {
            count++;
            pick_a_up5.SelectedIndex = 0;
            pick_a_low5.SelectedIndex = 0;
            pick_b_up5.SelectedIndex = 0;
            pick_b_low5.SelectedIndex = 0;

            fill_text_51.IsVisible = true;
            fill_text_52.IsVisible = true;
            Add_btn5.IsVisible = false;
            Add_btn6.IsVisible = true;

        }
        private void OnClicked_NewLine6(object sender, EventArgs e)
        {
            count++;
            pick_a_up6.SelectedIndex = 0;
            pick_a_low6.SelectedIndex = 0;
            pick_b_up6.SelectedIndex = 0;
            pick_b_low6.SelectedIndex = 0;

            fill_text_61.IsVisible = true;
            fill_text_62.IsVisible = true;
            Add_btn6.IsVisible = false;
            Add_btn7.IsVisible = true;

        }
        private void OnClicked_NewLine7(object sender, EventArgs e)
        {
            count++;
            pick_a_up7.SelectedIndex = 0;
            pick_a_low7.SelectedIndex = 0;
            pick_b_up7.SelectedIndex = 0;
            pick_b_low7.SelectedIndex = 0;

            fill_text_71.IsVisible = true;
            fill_text_72.IsVisible = true;
            Add_btn7.IsVisible = false;
            Add_btn8.IsVisible = true;

        }
        private void OnClicked_NewLine8(object sender, EventArgs e)
        {
            count++;
            pick_a_up8.SelectedIndex = 0;
            pick_a_low8.SelectedIndex = 0;
            pick_b_up8.SelectedIndex = 0;
            pick_b_low8.SelectedIndex = 0;

            fill_text_81.IsVisible = true;
            fill_text_82.IsVisible = true;
            Add_btn8.IsVisible = false;
            Add_btn9.IsVisible = true;

        }
        private void OnClicked_NewLine9(object sender, EventArgs e)
        {
            count++;
            pick_a_up9.SelectedIndex = 0;
            pick_a_low9.SelectedIndex = 0;
            pick_b_up9.SelectedIndex = 0;
            pick_b_low9.SelectedIndex = 0;
            fill_text_91.IsVisible = true;
            fill_text_92.IsVisible = true;
            Add_btn9.IsVisible = false;
            Add_btn10.IsVisible = true;

        }
        private void OnClicked_NewLine10(object sender, EventArgs e)
        {
            count++;
            pick_a_up10.SelectedIndex = 0;
            pick_a_low10.SelectedIndex = 0;
            pick_b_up10.SelectedIndex = 0;
            pick_b_low10.SelectedIndex = 0;

            fill_text_101.IsVisible = true;
            fill_text_102.IsVisible = true;
            Add_btn10.IsVisible = false;
            Add_btn11.IsVisible = true;


        }

        #region number pickers      
        private void Chg_Pick(object sender, EventArgs e)
        {
            Picker p = (Picker)sender;

            Picker a = pick_a_up;
            Picker b = pick_b_up;
            Label r = txt_resultup;

            int aa;
            int bb;
            int rr;
            int i;

            aa = 0;
            bb = 0;
            rr = 0;
            i = 1;


            if (p.Equals(pick_a_up) || p.Equals(pick_b_up)) { a = (Picker)pick_a_up; b = (Picker)pick_b_up; r = (Label)txt_resultup; i = 1; }
            if (p.Equals(pick_a_low) || p.Equals(pick_b_low)) { a = (Picker)pick_a_low; b = (Picker)pick_b_low; r = (Label)txt_resultlow; i = 2; }

            if (p.Equals(pick_a_up1) || p.Equals(pick_b_up1)) { a = (Picker)pick_a_up1; b = (Picker)pick_b_up1; r = (Label)txt_resultup1; i = 11; }
            if (p.Equals(pick_a_low1) || p.Equals(pick_b_low1)) { a = (Picker)pick_a_low1; b = (Picker)pick_b_low1; r = (Label)txt_resultlow1; i = 12; }

            if (p.Equals(pick_a_up2) || p.Equals(pick_b_up2)) { a = (Picker)pick_a_up2; b = (Picker)pick_b_up2; r = (Label)txt_resultup2; i = 21; }
            if (p.Equals(pick_a_low2) || p.Equals(pick_b_low2)) { a = (Picker)pick_a_low2; b = (Picker)pick_b_low2; r = (Label)txt_resultlow2; i = 22; }

            if (p.Equals(pick_a_up3) || p.Equals(pick_b_up3)) { a = (Picker)pick_a_up3; b = (Picker)pick_b_up3; r = (Label)txt_resultup3; i = 31; }
            if (p.Equals(pick_a_low3) || p.Equals(pick_b_low3)) { a = (Picker)pick_a_low3; b = (Picker)pick_b_low3; r = (Label)txt_resultlow3; i = 32; }

            if (p.Equals(pick_a_up4) || p.Equals(pick_b_up4)) { a = (Picker)pick_a_up4; b = (Picker)pick_b_up4; r = (Label)txt_resultup4; i = 41; }
            if (p.Equals(pick_a_low4) || p.Equals(pick_b_low4)) { a = (Picker)pick_a_low4; b = (Picker)pick_b_low4; r = (Label)txt_resultlow4; i = 42; }

            if (p.Equals(pick_a_up5) || p.Equals(pick_b_up5)) { a = (Picker)pick_a_up5; b = (Picker)pick_b_up5; r = (Label)txt_resultup5; i = 51; }
            if (p.Equals(pick_a_low5) || p.Equals(pick_b_low5)) { a = (Picker)pick_a_low5; b = (Picker)pick_b_low5; r = (Label)txt_resultlow5; i = 52; }

            if (p.Equals(pick_a_up6) || p.Equals(pick_b_up6)) { a = (Picker)pick_a_up6; b = (Picker)pick_b_up6; r = (Label)txt_resultup6; i = 61; }
            if (p.Equals(pick_a_low6) || p.Equals(pick_b_low6)) { a = (Picker)pick_a_low6; b = (Picker)pick_b_low6; r = (Label)txt_resultlow6; i = 62; }

            if (p.Equals(pick_a_up7) || p.Equals(pick_b_up7)) { a = (Picker)pick_a_up7; b = (Picker)pick_b_up7; r = (Label)txt_resultup7; i = 71; }
            if (p.Equals(pick_a_low7) || p.Equals(pick_b_low7)) { a = (Picker)pick_a_low7; b = (Picker)pick_b_low7; r = (Label)txt_resultlow7; i = 72; }

            if (p.Equals(pick_a_up8) || p.Equals(pick_b_up8)) { a = (Picker)pick_a_up8; b = (Picker)pick_b_up8; r = (Label)txt_resultup8; i = 81; }
            if (p.Equals(pick_a_low8) || p.Equals(pick_b_low8)) { a = (Picker)pick_a_low8; b = (Picker)pick_b_low8; r = (Label)txt_resultlow8; i = 82; }

            if (p.Equals(pick_a_up9) || p.Equals(pick_b_up9)) { a = (Picker)pick_a_up9; b = (Picker)pick_b_up9; r = (Label)txt_resultup9; i = 91; }
            if (p.Equals(pick_a_low9) || p.Equals(pick_b_low9)) { a = (Picker)pick_a_low9; b = (Picker)pick_b_low9; r = (Label)txt_resultlow9; i = 92; }

            if (p.Equals(pick_a_up10) || p.Equals(pick_b_up10)) { a = (Picker)pick_a_up10; b = (Picker)pick_b_up10; r = (Label)txt_resultup10; i = 101; }
            if (p.Equals(pick_a_low10) || p.Equals(pick_b_low10)) { a = (Picker)pick_a_low10; b = (Picker)pick_b_low10; r = (Label)txt_resultlow10; i = 102; }

            if (a.SelectedIndex < 0) { a.SelectedIndex = 0; }
            if (b.SelectedIndex < 0) { b.SelectedIndex = 0; }

            aa = int.Parse(a.Items[a.SelectedIndex].ToString());
            bb = int.Parse(b.Items[b.SelectedIndex].ToString());


            rr = aa * bb;
            //c_up = int.Parse(a.SelectedItem.ToString()) * int.Parse(b.SelectedItem.ToString());

            c_up = rr;
            r.Text = rr.ToString();
            //populate the variables
            if (i == 1) { a_up = aa; b_up = bb; }
            if (i == 2) { a_low = aa; b_low = bb; }

            if (i == 11) { a_up1 = aa; b_up1 = bb; }
            if (i == 12) { a_low1 = aa; b_low1 = bb; }

            if (i == 21) { a_up2 = aa; b_up2 = bb; }
            if (i == 22) { a_low2 = aa; b_low2 = bb; }

            if (i == 31) { a_up3 = aa; b_up3 = bb; }
            if (i == 32) { a_low3 = aa; b_low3 = bb; }

            if (i == 41) { a_up4 = aa; b_up4 = bb; }
            if (i == 42) { a_low4 = aa; b_low4 = bb; }

            if (i == 51) { a_up5 = aa; b_up5 = bb; }
            if (i == 52) { a_low5 = aa; b_low5 = bb; }

            if (i == 61) { a_up6 = aa; b_up6 = bb; }
            if (i == 62) { a_low6 = aa; b_low6 = bb; }

            if (i == 71) { a_up7 = aa; b_up7 = bb; }
            if (i == 72) { a_low7 = aa; b_low7 = bb; }

            if (i == 81) { a_up8 = aa; b_up8 = bb; }
            if (i == 82) { a_low8 = aa; b_low8 = bb; }

            if (i == 91) { a_up9 = aa; b_up9 = bb; }
            if (i == 92) { a_low9 = aa; b_low9 = bb; }

            if (i == 101) { a_up10 = aa; b_up10 = bb; }
            if (i == 102) { a_low10 = aa; b_low10 = bb; }

            if (c_up <= 3)
            {
                r.TextColor = Xamarin.Forms.Color.FromHex("#01DF01");

                if (i == 1) { c_up_color = "#01DF01"; }
                if (i == 2) { c_low_color = "#01DF01"; }

                if (i == 11) { c_up1_color = "#01DF01"; }
                if (i == 12) { c_low1_color = "#01DF01"; }

                if (i == 21) { c_up2_color = "#01DF01"; }
                if (i == 22) { c_low2_color = "#01DF01"; }

                if (i == 31) { c_up3_color = "#01DF01"; }
                if (i == 32) { c_low3_color = "#01DF01"; }

                if (i == 41) { c_up4_color = "#01DF01"; }
                if (i == 42) { c_low4_color = "#01DF01"; }

                if (i == 51) { c_up5_color = "#01DF01"; }
                if (i == 52) { c_low5_color = "#01DF01"; }

                if (i == 61) { c_up6_color = "#01DF01"; }
                if (i == 62) { c_low6_color = "#01DF01"; }

                if (i == 71) { c_up7_color = "#01DF01"; }
                if (i == 72) { c_low7_color = "#01DF01"; }

                if (i == 81) { c_up8_color = "#01DF01"; }
                if (i == 82) { c_low8_color = "#01DF01"; }

                if (i == 91) { c_up9_color = "#01DF01"; }
                if (i == 92) { c_low9_color = "#01DF01"; }

                if (i == 101) { c_up10_color = "#01DF01"; }
                if (i == 102) { c_low10_color = "#01DF01"; }
            }
            if (c_up > 3 && c_up <= 6)
            {
                r.TextColor = Xamarin.Forms.Color.FromHex("#ffb240");

                if (i == 1) { c_up_color = "#ffb240"; }
                if (i == 2) { c_low_color = "#ffb240"; }

                if (i == 11) { c_up1_color = "#ffb240"; }
                if (i == 12) { c_low1_color = "#ffb240"; }

                if (i == 21) { c_up2_color = "#ffb240"; }
                if (i == 22) { c_low2_color = "#ffb240"; }

                if (i == 31) { c_up3_color = "#ffb240"; }
                if (i == 32) { c_low3_color = "#ffb240"; }

                if (i == 41) { c_up4_color = "#ffb240"; }
                if (i == 42) { c_low4_color = "#ffb240"; }

                if (i == 51) { c_up5_color = "#ffb240"; }
                if (i == 52) { c_low5_color = "#ffb240"; }

                if (i == 61) { c_up6_color = "#ffb240"; }
                if (i == 62) { c_low6_color = "#ffb240"; }

                if (i == 71) { c_up7_color = "#ffb240"; }
                if (i == 72) { c_low7_color = "#ffb240"; }

                if (i == 81) { c_up8_color = "#ffb240"; }
                if (i == 82) { c_low8_color = "#ffb240"; }

                if (i == 91) { c_up9_color = "#ffb240"; }
                if (i == 92) { c_low9_color = "#ffb240"; }

                if (i == 101) { c_up10_color = "#ffb240"; }
                if (i == 102) { c_low10_color = "#ffb240"; }

            }
            if (c_up > 6)
            {
                r.TextColor = Xamarin.Forms.Color.FromHex("#f22626");


                if (i == 1) { c_up_color = "#f22626"; }
                if (i == 2) { c_low_color = "#f22626"; }

                if (i == 11) { c_up1_color = "#f22626"; }
                if (i == 12) { c_low1_color = "#f22626"; }

                if (i == 21) { c_up2_color = "#f22626"; }
                if (i == 22) { c_low2_color = "#f22626"; }

                if (i == 31) { c_up3_color = "#f22626"; }
                if (i == 32) { c_low3_color = "#f22626"; }

                if (i == 41) { c_up4_color = "#f22626"; }
                if (i == 42) { c_low4_color = "#f22626"; }

                if (i == 51) { c_up5_color = "#f22626"; }
                if (i == 52) { c_low5_color = "#f22626"; }

                if (i == 61) { c_up6_color = "#f22626"; }
                if (i == 62) { c_low6_color = "#f22626"; }

                if (i == 71) { c_up7_color = "#f22626"; }
                if (i == 72) { c_low7_color = "#f22626"; }

                if (i == 81) { c_up8_color = "#f22626"; }
                if (i == 82) { c_low8_color = "#f22626"; }

                if (i == 91) { c_up9_color = "#f22626"; }
                if (i == 92) { c_low9_color = "#f22626"; }

                if (i == 101) { c_up10_color = "#f22626"; }
                if (i == 102) { c_low10_color = "#f22626"; }

            }




        }
        private void OnSelectedIndexChanged_pick_a_up(object sender, EventArgs e)
        {
            if (pick_a_up.SelectedIndex == 0)
                a_up = 0;
            if (pick_a_up.SelectedIndex == 1)
                a_up = 1;
            if (pick_a_up.SelectedIndex == 2)
                a_up = 2;
            if (pick_a_up.SelectedIndex == 3)
                a_up = 3;
            if (pick_a_up.SelectedIndex == 4)
                a_up = 4;
            if (pick_a_up.SelectedIndex == 0)
                a_up = 4;
            // a_up = Int32.Parse(pick_a_up.SelectedItem.ToString());

            c_up = a_up * b_up;
            if (c_up <= 3)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up_color = "#01DF01"; }
            if (c_up > 3 && c_up <= 6)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("#ffb240"); c_up_color = "#ffb240"; }
            if (c_up > 6)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("f22626"); c_up_color = "#f22626"; }
            txt_resultup.Text = c_up.ToString();
            // pick_a_up.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_up(object sender, EventArgs e)
        {
            if (pick_b_up.SelectedIndex == 0)
                b_up = 1;
            if (pick_b_up.SelectedIndex == 1)
                b_up = 2;
            if (pick_b_up.SelectedIndex == 2)
                b_up = 3;
            if (pick_b_up.SelectedIndex == 3)
                b_up = 4;
            if (pick_b_up.SelectedIndex == 4)
                b_up = 5;
            c_up = a_up * b_up;

            if (c_up <= 3)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up_color = "#01DF01"; }
            if (c_up > 3 && c_up <= 6)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("#ffb240"); c_up_color = "#ffb240"; }
            if (c_up > 6)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("f22626"); c_up_color = "#f22626"; }
            txt_resultup.Text = c_up.ToString();
            //pick_b_up.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_a_low(object sender, EventArgs e)
        {
            if (pick_a_low.SelectedIndex == 0)
                a_low = 1;
            if (pick_a_low.SelectedIndex == 1)
                a_low = 2;
            if (pick_a_low.SelectedIndex == 2)
                a_low = 3;
            if (pick_a_low.SelectedIndex == 3)
                a_low = 4;
            if (pick_a_low.SelectedIndex == 4)
                a_low = 5;
            c_low = a_low * b_low;
            if (c_low <= 3)
            { txt_resultlow.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low_color = "#01DF01"; }
            if (c_low > 3 && c_low <= 6)
            { txt_resultlow.TextColor = Xamarin.Forms.Color.FromHex("#ffb240"); c_low_color = "#ffb240"; }
            if (c_low > 6)
            { txt_resultlow.TextColor = Xamarin.Forms.Color.FromHex("f22626"); c_low_color = "#f22626"; }
            txt_resultlow.Text = c_low.ToString();
            //pick_a_low.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_low(object sender, EventArgs e)
        {
            if (pick_b_low.SelectedIndex == 0)
                b_low = 1;
            if (pick_b_low.SelectedIndex == 1)
                b_low = 2;
            if (pick_b_low.SelectedIndex == 2)
                b_low = 3;
            if (pick_b_low.SelectedIndex == 3)
                b_low = 4;
            if (pick_b_low.SelectedIndex == 4)
                b_low = 5;
            c_low = a_low * b_low;
            if (c_low <= 3)
            { txt_resultlow.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low_color = "#01DF01"; }
            if (c_low > 3 && c_low <= 6)
            { txt_resultlow.TextColor = Xamarin.Forms.Color.FromHex("#ffb240"); c_low_color = "#ffb240"; }
            if (c_low > 6)
            { txt_resultlow.TextColor = Xamarin.Forms.Color.FromHex("f22626"); c_low_color = "#f22626"; }
            txt_resultlow.Text = c_low.ToString();
            //pick_b_low.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_a_new(object sender, EventArgs e)
        {
            if (pick_a_low.SelectedIndex == 0)
                a_new = 1;
            if (pick_a_low.SelectedIndex == 1)
                a_new = 2;
            if (pick_a_low.SelectedIndex == 2)
                a_new = 3;
            if (pick_a_low.SelectedIndex == 3)
                a_new = 4;
            if (pick_a_low.SelectedIndex == 4)
                a_new = 5;
            c_new = a_new * b_new;
            if (c_new <= 3)
            { txt_resultup1.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_new_color = "#01DF01"; }
            if (c_new > 3 && c_new <= 6)
            { txt_resultlow1.TextColor = Xamarin.Forms.Color.FromHex("#ffb240"); c_new_color = "#ffb240"; }
            if (c_new > 6)
            { txt_resultup1.TextColor = Xamarin.Forms.Color.FromHex("f22626"); c_new_color = "#f22626"; }
            txt_resultup1.Text = c_new.ToString();
            //pick_a_low1.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_new(object sender, EventArgs e)
        {
            if (pick_b_low1.SelectedIndex == 0)
                b_new = 1;
            if (pick_b_low1.SelectedIndex == 1)
                b_new = 2;
            if (pick_b_low1.SelectedIndex == 2)
                b_new = 3;
            if (pick_b_low1.SelectedIndex == 3)
                b_new = 4;
            if (pick_b_low1.SelectedIndex == 4)
                b_new = 5;
            c_new = a_new * b_new;
            if (c_new <= 3)
            { txt_resultup2.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_new_color = "#01DF01"; }
            if (c_new > 3 && c_new <= 6)
            { txt_resultup2.TextColor = Xamarin.Forms.Color.FromHex("#ffb240"); c_new_color = "#ffb240"; }
            if (c_new > 6)
            { txt_resultup2.TextColor = Xamarin.Forms.Color.FromHex("f22626"); c_new_color = "#f22626"; }
            txt_resultup2.Text = c_new.ToString();
            //pick_b_low2.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_a_new1(object sender, EventArgs e)
        {
            if (pick_a_up1.SelectedIndex == 0)
                a_new1 = 1;
            if (pick_a_up1.SelectedIndex == 1)
                a_new1 = 2;
            if (pick_a_up1.SelectedIndex == 2)
                a_new1 = 3;
            if (pick_a_up1.SelectedIndex == 3)
                a_new1 = 4;
            if (pick_a_up1.SelectedIndex == 4)
                a_new1 = 5;
            c_new1 = a_new1 * b_new1;
            if (c_new1 <= 3)
            { txt_resultup1.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_new1_color = "#01DF01"; }
            if (c_new1 > 3 && c_new1 <= 6)
            { txt_resultup1.TextColor = Xamarin.Forms.Color.FromHex("#ffb240"); c_new1_color = "#ffb240"; }
            if (c_new1 > 6)
            { txt_resultup1.TextColor = Xamarin.Forms.Color.FromHex("f22626"); c_new1_color = "#f22626"; }
            txt_resultup1.Text = c_new1.ToString();
            //pick_a_up1.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_new1(object sender, EventArgs e)
        {
            if (pick_b_low1.SelectedIndex == 0)
                b_new1 = 1;
            if (pick_b_low1.SelectedIndex == 1)
                b_new1 = 2;
            if (pick_b_low1.SelectedIndex == 2)
                b_new1 = 3;
            if (pick_b_low1.SelectedIndex == 3)
                b_new1 = 4;
            if (pick_b_low1.SelectedIndex == 4)
                b_new1 = 5;
            c_new1 = a_new1 * b_new1;
            if (c_new1 <= 3)
            { txt_resultlow1.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_new1_color = "#01DF01"; }
            if (c_new1 > 3 && c_new1 <= 6)
            { txt_resultlow1.TextColor = Xamarin.Forms.Color.FromHex("#ffb240"); c_new1_color = "#ffb240"; }
            if (c_new1 > 6)
            { txt_resultlow1.TextColor = Xamarin.Forms.Color.FromHex("f22626"); c_new1_color = "#f22626"; }
            txt_resultlow1.Text = c_new1.ToString();
            //pick_b_low1.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }

        #region number pickers       
        private void OnSelectedIndexChanged_pick_a_up1(object sender, EventArgs e)
        {
            if (pick_a_up1.SelectedIndex == 0)
                a_up1 = 1;
            if (pick_a_up1.SelectedIndex == 1)
                a_up1 = 2;
            if (pick_a_up1.SelectedIndex == 2)
                a_up1 = 3;
            if (pick_a_up1.SelectedIndex == 3)
                a_up1 = 4;
            if (pick_a_up1.SelectedIndex == 4)
                a_up1 = 5;
            c_up1 = a_up1 * b_up1;
            if (c_up1 <= 3)
            { txt_resultup1.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up1_color = "#01DF01"; }
            if (c_up1 > 3 && c_up1 <= 6)
            { txt_resultup1.TextColor = Xamarin.Forms.Color.FromHex("#ffb240"); c_up1_color = "#ffb240"; }
            if (c_up1 > 6)
            { txt_resultup1.TextColor = Xamarin.Forms.Color.FromHex("f22626"); c_up1_color = "#f22626"; }
            txt_resultup1.Text = c_up1.ToString();
            //pick_a_up1.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_up1(object sender, EventArgs e)
        {
            if (pick_b_up1.SelectedIndex == 0)
                b_up1 = 1;
            if (pick_b_up1.SelectedIndex == 1)
                b_up1 = 2;
            if (pick_b_up1.SelectedIndex == 2)
                b_up1 = 3;
            if (pick_b_up1.SelectedIndex == 3)
                b_up1 = 4;
            if (pick_b_up1.SelectedIndex == 4)
                b_up1 = 5;
            c_up1 = a_up1 * b_up1;
            if (c_up1 <= 3)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up1_color = "#01DF01"; }
            if (c_up1 > 3 && c_up1 <= 6)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("#ffb240"); c_up1_color = "#ffb240"; }
            if (c_up1 > 6)
            { txt_resultup1.TextColor = Xamarin.Forms.Color.FromHex("f22626"); c_up1_color = "#f22626"; }
            txt_resultup1.Text = c_up1.ToString();
            //pick_b_up1.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_a_low1(object sender, EventArgs e)
        {
            if (pick_a_low1.SelectedIndex == 0)
                a_low1 = 1;
            if (pick_a_low1.SelectedIndex == 1)
                a_low1 = 2;
            if (pick_a_low1.SelectedIndex == 2)
                a_low1 = 3;
            if (pick_a_low1.SelectedIndex == 3)
                a_low1 = 4;
            if (pick_a_low1.SelectedIndex == 4)
                a_low1 = 5;
            c_low1 = a_low1 * b_low1;
            if (c_low1 <= 3)
            { txt_resultlow1.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low1_color = "#01DF01"; }
            if (c_low1 > 3 && c_low1 <= 6)
            { txt_resultlow1.TextColor = Xamarin.Forms.Color.FromHex("#ffb240"); c_low1_color = "#ffb240"; }
            if (c_low1 > 6)
            { txt_resultlow1.TextColor = Xamarin.Forms.Color.FromHex("f22626"); c_low1_color = "#f22626"; }
            txt_resultlow1.Text = c_low1.ToString();
            //pick_a_low1.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_low1(object sender, EventArgs e)
        {
            if (pick_b_low1.SelectedIndex == 0)
                b_low1 = 1;
            if (pick_b_low1.SelectedIndex == 1)
                b_low1 = 2;
            if (pick_b_low1.SelectedIndex == 2)
                b_low1 = 3;
            if (pick_b_low1.SelectedIndex == 3)
                b_low1 = 4;
            if (pick_b_low1.SelectedIndex == 4)
                b_low1 = 5;
            c_low1 = a_low1 * b_low1;
            if (c_low1 <= 3)
            { txt_resultlow1.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low1_color = "#01DF01"; }
            if (c_low1 > 3 && c_low1 <= 6)
            { txt_resultlow1.TextColor = Xamarin.Forms.Color.FromHex("#ffb240"); c_low1_color = "#ffb240"; }
            if (c_low1 > 6)
            { txt_resultlow1.TextColor = Xamarin.Forms.Color.FromHex("f22626"); c_low1_color = "#f22626"; }
            txt_resultlow1.Text = c_low1.ToString();
            //pick_b_low1.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        #endregion
        #region number pickers       
        private void OnSelectedIndexChanged_pick_a_up2(object sender, EventArgs e)
        {
            if (pick_a_up2.SelectedIndex == 0)
                a_up2 = 1;
            if (pick_a_up2.SelectedIndex == 1)
                a_up2 = 2;
            if (pick_a_up2.SelectedIndex == 2)
                a_up2 = 3;
            if (pick_a_up2.SelectedIndex == 3)
                a_up2 = 4;
            if (pick_a_up2.SelectedIndex == 4)
                a_up2 = 5;
            c_up2 = a_up2 * b_up2;
            if (c_up2 <= 3)
            { txt_resultup2.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up2_color = "#01DF01"; }
            if (c_up2 > 3 && c_up2 <= 6)
            { txt_resultup2.TextColor = Xamarin.Forms.Color.FromHex("#ffb240"); c_up2_color = "#ffb240"; }
            if (c_up2 > 6)
            { txt_resultup2.TextColor = Xamarin.Forms.Color.FromHex("f22626"); c_up2_color = "#f22626"; }
            txt_resultup2.Text = c_up2.ToString();
            // pick_a_up2.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_up2(object sender, EventArgs e)
        {
            if (pick_b_up2.SelectedIndex == 0)
                b_up2 = 1;
            if (pick_b_up2.SelectedIndex == 1)
                b_up2 = 2;
            if (pick_b_up2.SelectedIndex == 2)
                b_up2 = 3;
            if (pick_b_up2.SelectedIndex == 3)
                b_up2 = 4;
            if (pick_b_up2.SelectedIndex == 4)
                b_up2 = 5;
            c_up2 = a_up2 * b_up2;
            if (c_up2 <= 3)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up2_color = "#01DF01"; }
            if (c_up2 > 3 && c_up2 <= 6)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("#ffb240"); c_up2_color = "#ffb240"; }
            if (c_up2 > 6)
            { txt_resultup2.TextColor = Xamarin.Forms.Color.FromHex("f22626"); c_up2_color = "#f22626"; }
            txt_resultup2.Text = c_up2.ToString();
            // pick_b_up2.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_a_low2(object sender, EventArgs e)
        {
            if (pick_a_low2.SelectedIndex == 0)
                a_low2 = 1;
            if (pick_a_low2.SelectedIndex == 1)
                a_low2 = 2;
            if (pick_a_low2.SelectedIndex == 2)
                a_low2 = 3;
            if (pick_a_low2.SelectedIndex == 3)
                a_low2 = 4;
            if (pick_a_low2.SelectedIndex == 4)
                a_low2 = 5;
            c_low2 = a_low2 * b_low2;
            if (c_low2 <= 3)
            { txt_resultlow2.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low2_color = "#01DF01"; }
            if (c_low2 > 3 && c_low2 <= 6)
            { txt_resultlow2.TextColor = Xamarin.Forms.Color.FromHex("#ffb240"); c_low2_color = "#ffb240"; }
            if (c_low2 > 6)
            { txt_resultlow2.TextColor = Xamarin.Forms.Color.FromHex("f22626"); c_low2_color = "#f22626"; }
            txt_resultlow2.Text = c_low2.ToString();
            // pick_a_low2.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_low2(object sender, EventArgs e)
        {
            if (pick_b_low2.SelectedIndex == 0)
                b_low2 = 1;
            if (pick_b_low2.SelectedIndex == 1)
                b_low2 = 2;
            if (pick_b_low2.SelectedIndex == 2)
                b_low2 = 3;
            if (pick_b_low2.SelectedIndex == 3)
                b_low2 = 4;
            if (pick_b_low2.SelectedIndex == 4)
                b_low2 = 5;
            c_low2 = a_low2 * b_low2;
            if (c_low2 <= 3)
            { txt_resultlow2.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low2_color = "#01DF01"; }
            if (c_low2 > 3 && c_low2 <= 6)
            { txt_resultlow2.TextColor = Xamarin.Forms.Color.FromHex("#ffb240"); c_low2_color = "#ffb240"; }
            if (c_low2 > 6)
            { txt_resultlow2.TextColor = Xamarin.Forms.Color.FromHex("f22626"); c_low2_color = "#f22626"; }
            txt_resultlow2.Text = c_low2.ToString();
            //  pick_b_low2.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        #endregion
        #region number pickers       
        private void OnSelectedIndexChanged_pick_a_up3(object sender, EventArgs e)
        {
            if (pick_a_up3.SelectedIndex == 0)
                a_up3 = 1;
            if (pick_a_up3.SelectedIndex == 1)
                a_up3 = 2;
            if (pick_a_up3.SelectedIndex == 2)
                a_up3 = 3;
            if (pick_a_up3.SelectedIndex == 3)
                a_up3 = 4;
            if (pick_a_up3.SelectedIndex == 4)
                a_up3 = 5;
            c_up3 = a_up3 * b_up3;
            if (c_up3 <= 3)
            { txt_resultup3.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up3_color = "#01DF01"; }
            if (c_up3 > 3 && c_up3 <= 6)
            { txt_resultup3.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_up3_color = "#ffb340"; }
            if (c_up3 > 6)
            { txt_resultup3.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_up3_color = "#f33636"; }
            txt_resultup3.Text = c_up3.ToString();
            //pick_a_up3.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_up3(object sender, EventArgs e)
        {
            if (pick_b_up3.SelectedIndex == 0)
                b_up3 = 1;
            if (pick_b_up3.SelectedIndex == 1)
                b_up3 = 2;
            if (pick_b_up3.SelectedIndex == 2)
                b_up3 = 3;
            if (pick_b_up3.SelectedIndex == 3)
                b_up3 = 4;
            if (pick_b_up3.SelectedIndex == 4)
                b_up3 = 5;
            c_up3 = a_up3 * b_up3;
            if (c_up3 <= 3)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up3_color = "#01DF01"; }
            if (c_up3 > 3 && c_up3 <= 6)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_up3_color = "#ffb340"; }
            if (c_up3 > 6)
            { txt_resultup3.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_up3_color = "#f33636"; }
            txt_resultup3.Text = c_up3.ToString();
            //pick_b_up3.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_a_low3(object sender, EventArgs e)
        {
            if (pick_a_low3.SelectedIndex == 0)
                a_low3 = 1;
            if (pick_a_low3.SelectedIndex == 1)
                a_low3 = 2;
            if (pick_a_low3.SelectedIndex == 2)
                a_low3 = 3;
            if (pick_a_low3.SelectedIndex == 3)
                a_low3 = 4;
            if (pick_a_low3.SelectedIndex == 4)
                a_low3 = 5;
            c_low3 = a_low3 * b_low3;
            if (c_low3 <= 3)
            { txt_resultlow3.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low3_color = "#01DF01"; }
            if (c_low3 > 3 && c_low3 <= 6)
            { txt_resultlow3.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_low3_color = "#ffb340"; }
            if (c_low3 > 6)
            { txt_resultlow3.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_low3_color = "#f33636"; }
            txt_resultlow3.Text = c_low3.ToString();
            //pick_a_low3.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_low3(object sender, EventArgs e)
        {
            if (pick_b_low3.SelectedIndex == 0)
                b_low3 = 1;
            if (pick_b_low3.SelectedIndex == 1)
                b_low3 = 2;
            if (pick_b_low3.SelectedIndex == 2)
                b_low3 = 3;
            if (pick_b_low3.SelectedIndex == 3)
                b_low3 = 4;
            if (pick_b_low3.SelectedIndex == 4)
                b_low3 = 5;
            c_low3 = a_low3 * b_low3;
            if (c_low3 <= 3)
            { txt_resultlow3.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low3_color = "#01DF01"; }
            if (c_low3 > 3 && c_low3 <= 6)
            { txt_resultlow3.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_low3_color = "#ffb340"; }
            if (c_low3 > 6)
            { txt_resultlow3.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_low3_color = "#f33636"; }
            txt_resultlow3.Text = c_low3.ToString();
            //pick_b_low3.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        #endregion
        #region number pickers       
        private void OnSelectedIndexChanged_pick_a_up4(object sender, EventArgs e)
        {
            if (pick_a_up4.SelectedIndex == 0)
                a_up4 = 1;
            if (pick_a_up4.SelectedIndex == 1)
                a_up4 = 2;
            if (pick_a_up4.SelectedIndex == 2)
                a_up4 = 3;
            if (pick_a_up4.SelectedIndex == 3)
                a_up4 = 4;
            if (pick_a_up4.SelectedIndex == 4)
                a_up4 = 5;
            c_up4 = a_up4 * b_up4;
            if (c_up4 <= 3)
            { txt_resultup4.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up4_color = "#01DF01"; }
            if (c_up4 > 3 && c_up4 <= 6)
            { txt_resultup4.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_up4_color = "#ffb340"; }
            if (c_up4 > 6)
            { txt_resultup4.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_up4_color = "#f33636"; }
            txt_resultup4.Text = c_up4.ToString();
            //pick_a_up4.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_up4(object sender, EventArgs e)
        {
            if (pick_b_up4.SelectedIndex == 0)
                b_up4 = 1;
            if (pick_b_up4.SelectedIndex == 1)
                b_up4 = 2;
            if (pick_b_up4.SelectedIndex == 2)
                b_up4 = 3;
            if (pick_b_up4.SelectedIndex == 3)
                b_up4 = 4;
            if (pick_b_up4.SelectedIndex == 4)
                b_up4 = 5;
            c_up4 = a_up4 * b_up4;
            if (c_up4 <= 3)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up4_color = "#01DF01"; }
            if (c_up4 > 3 && c_up4 <= 6)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_up4_color = "#ffb340"; }
            if (c_up4 > 6)
            { txt_resultup4.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_up4_color = "#f33636"; }
            txt_resultup4.Text = c_up4.ToString();
            //pick_b_up4.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_a_low4(object sender, EventArgs e)
        {
            if (pick_a_low4.SelectedIndex == 0)
                a_low4 = 1;
            if (pick_a_low4.SelectedIndex == 1)
                a_low4 = 2;
            if (pick_a_low4.SelectedIndex == 2)
                a_low4 = 3;
            if (pick_a_low4.SelectedIndex == 3)
                a_low4 = 4;
            if (pick_a_low4.SelectedIndex == 4)
                a_low4 = 5;
            c_low4 = a_low4 * b_low4;
            if (c_low4 <= 3)
            { txt_resultlow4.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low4_color = "#01DF01"; }
            if (c_low4 > 3 && c_low4 <= 6)
            { txt_resultlow4.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_low4_color = "#ffb340"; }
            if (c_low4 > 6)
            { txt_resultlow4.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_low4_color = "#f33636"; }
            txt_resultlow4.Text = c_low4.ToString();
            //pick_a_low4.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_low4(object sender, EventArgs e)
        {
            if (pick_b_low4.SelectedIndex == 0)
                b_low4 = 1;
            if (pick_b_low4.SelectedIndex == 1)
                b_low4 = 2;
            if (pick_b_low4.SelectedIndex == 2)
                b_low4 = 3;
            if (pick_b_low4.SelectedIndex == 3)
                b_low4 = 4;
            if (pick_b_low4.SelectedIndex == 4)
                b_low4 = 5;
            c_low4 = a_low4 * b_low4;
            if (c_low4 <= 3)
            { txt_resultlow4.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low4_color = "#01DF01"; }
            if (c_low4 > 3 && c_low4 <= 6)
            { txt_resultlow4.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_low4_color = "#ffb340"; }
            if (c_low4 > 6)
            { txt_resultlow4.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_low4_color = "#f33636"; }
            txt_resultlow4.Text = c_low4.ToString();
            //pick_b_low4.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        #endregion
        #region number pickers       
        private void OnSelectedIndexChanged_pick_a_up5(object sender, EventArgs e)
        {
            if (pick_a_up5.SelectedIndex == 0)
                a_up5 = 1;
            if (pick_a_up5.SelectedIndex == 1)
                a_up5 = 2;
            if (pick_a_up5.SelectedIndex == 2)
                a_up5 = 3;
            if (pick_a_up5.SelectedIndex == 3)
                a_up5 = 4;
            if (pick_a_up5.SelectedIndex == 4)
                a_up5 = 5;
            c_up5 = a_up5 * b_up5;
            if (c_up5 <= 3)
            { txt_resultup5.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up5_color = "#01DF01"; }
            if (c_up5 > 3 && c_up5 <= 6)
            { txt_resultup5.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_up5_color = "#ffb340"; }
            if (c_up5 > 6)
            { txt_resultup5.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_up5_color = "#f33636"; }
            txt_resultup5.Text = c_up5.ToString();
            //pick_a_up5.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_up5(object sender, EventArgs e)
        {
            if (pick_b_up5.SelectedIndex == 0)
                b_up5 = 1;
            if (pick_b_up5.SelectedIndex == 1)
                b_up5 = 2;
            if (pick_b_up5.SelectedIndex == 2)
                b_up5 = 3;
            if (pick_b_up5.SelectedIndex == 3)
                b_up5 = 4;
            if (pick_b_up5.SelectedIndex == 4)
                b_up5 = 5;
            c_up5 = a_up5 * b_up5;
            if (c_up5 <= 3)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up5_color = "#01DF01"; }
            if (c_up5 > 3 && c_up5 <= 6)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_up5_color = "#ffb340"; }
            if (c_up5 > 6)
            { txt_resultup5.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_up5_color = "#f33636"; }
            txt_resultup5.Text = c_up5.ToString();
            //pick_b_up5.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_a_low5(object sender, EventArgs e)
        {
            if (pick_a_low5.SelectedIndex == 0)
                a_low5 = 1;
            if (pick_a_low5.SelectedIndex == 1)
                a_low5 = 2;
            if (pick_a_low5.SelectedIndex == 2)
                a_low5 = 3;
            if (pick_a_low5.SelectedIndex == 3)
                a_low5 = 4;
            if (pick_a_low5.SelectedIndex == 4)
                a_low5 = 5;
            c_low5 = a_low5 * b_low5;
            if (c_low5 <= 3)
            { txt_resultlow5.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low5_color = "#01DF01"; }
            if (c_low5 > 3 && c_low5 <= 6)
            { txt_resultlow5.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_low5_color = "#ffb340"; }
            if (c_low5 > 6)
            { txt_resultlow5.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_low5_color = "#f33636"; }
            txt_resultlow5.Text = c_low5.ToString();
            //pick_a_low5.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_low5(object sender, EventArgs e)
        {
            if (pick_b_low5.SelectedIndex == 0)
                b_low5 = 1;
            if (pick_b_low5.SelectedIndex == 1)
                b_low5 = 2;
            if (pick_b_low5.SelectedIndex == 2)
                b_low5 = 3;
            if (pick_b_low5.SelectedIndex == 3)
                b_low5 = 4;
            if (pick_b_low5.SelectedIndex == 4)
                b_low5 = 5;
            c_low5 = a_low5 * b_low5;
            if (c_low5 <= 3)
            { txt_resultlow5.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low5_color = "#01DF01"; }
            if (c_low5 > 3 && c_low5 <= 6)
            { txt_resultlow5.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_low5_color = "#ffb340"; }
            if (c_low5 > 6)
            { txt_resultlow5.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_low5_color = "#f33636"; }
            txt_resultlow5.Text = c_low5.ToString();
            //pick_b_low5.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        #endregion
        #region number pickers       
        private void OnSelectedIndexChanged_pick_a_up6(object sender, EventArgs e)
        {
            if (pick_a_up6.SelectedIndex == 0)
                a_up6 = 1;
            if (pick_a_up6.SelectedIndex == 1)
                a_up6 = 2;
            if (pick_a_up6.SelectedIndex == 2)
                a_up6 = 3;
            if (pick_a_up6.SelectedIndex == 3)
                a_up6 = 4;
            if (pick_a_up6.SelectedIndex == 4)
                a_up6 = 5;
            c_up6 = a_up6 * b_up6;
            if (c_up6 <= 3)
            { txt_resultup6.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up6_color = "#01DF01"; }
            if (c_up6 > 3 && c_up6 <= 6)
            { txt_resultup6.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_up6_color = "#ffb340"; }
            if (c_up6 > 6)
            { txt_resultup6.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_up6_color = "#f33636"; }
            txt_resultup6.Text = c_up6.ToString();
            //pick_a_up6.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_up6(object sender, EventArgs e)
        {
            if (pick_b_up6.SelectedIndex == 0)
                b_up6 = 1;
            if (pick_b_up6.SelectedIndex == 1)
                b_up6 = 2;
            if (pick_b_up6.SelectedIndex == 2)
                b_up6 = 3;
            if (pick_b_up6.SelectedIndex == 3)
                b_up6 = 4;
            if (pick_b_up6.SelectedIndex == 4)
                b_up6 = 5;
            c_up6 = a_up6 * b_up6;
            if (c_up6 <= 3)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up6_color = "#01DF01"; }
            if (c_up6 > 3 && c_up6 <= 6)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_up6_color = "#ffb340"; }
            if (c_up6 > 6)
            { txt_resultup6.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_up6_color = "#f33636"; }
            txt_resultup6.Text = c_up6.ToString();
            //pick_b_up6.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_a_low6(object sender, EventArgs e)
        {
            if (pick_a_low6.SelectedIndex == 0)
                a_low6 = 1;
            if (pick_a_low6.SelectedIndex == 1)
                a_low6 = 2;
            if (pick_a_low6.SelectedIndex == 2)
                a_low6 = 3;
            if (pick_a_low6.SelectedIndex == 3)
                a_low6 = 4;
            if (pick_a_low6.SelectedIndex == 4)
                a_low6 = 5;
            c_low6 = a_low6 * b_low6;
            if (c_low6 <= 3)
            { txt_resultlow6.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low6_color = "#01DF01"; }
            if (c_low6 > 3 && c_low6 <= 6)
            { txt_resultlow6.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_low6_color = "#ffb340"; }
            if (c_low6 > 6)
            { txt_resultlow6.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_low6_color = "#f33636"; }
            txt_resultlow6.Text = c_low6.ToString();
            //pick_a_low6.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_low6(object sender, EventArgs e)
        {
            if (pick_b_low6.SelectedIndex == 0)
                b_low6 = 1;
            if (pick_b_low6.SelectedIndex == 1)
                b_low6 = 2;
            if (pick_b_low6.SelectedIndex == 2)
                b_low6 = 3;
            if (pick_b_low6.SelectedIndex == 3)
                b_low6 = 4;
            if (pick_b_low6.SelectedIndex == 4)
                b_low6 = 5;
            c_low6 = a_low6 * b_low6;
            if (c_low6 <= 3)
            { txt_resultlow6.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low6_color = "#01DF01"; }
            if (c_low6 > 3 && c_low6 <= 6)
            { txt_resultlow6.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_low6_color = "#ffb340"; }
            if (c_low6 > 6)
            { txt_resultlow6.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_low6_color = "#f33636"; }
            txt_resultlow6.Text = c_low6.ToString();
            //pick_b_low6.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        #endregion
        #region number pickers       
        private void OnSelectedIndexChanged_pick_a_up7(object sender, EventArgs e)
        {
            if (pick_a_up7.SelectedIndex == 0)
                a_up7 = 1;
            if (pick_a_up7.SelectedIndex == 1)
                a_up7 = 2;
            if (pick_a_up7.SelectedIndex == 2)
                a_up7 = 3;
            if (pick_a_up7.SelectedIndex == 3)
                a_up7 = 4;
            if (pick_a_up7.SelectedIndex == 4)
                a_up7 = 5;
            c_up7 = a_up7 * b_up7;
            if (c_up7 <= 3)
            { txt_resultup7.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up7_color = "#01DF01"; }
            if (c_up7 > 3 && c_up7 <= 6)
            { txt_resultup7.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_up7_color = "#ffb340"; }
            if (c_up7 > 6)
            { txt_resultup7.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_up7_color = "#f33636"; }
            txt_resultup7.Text = c_up7.ToString();
            //pick_a_up7.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_up7(object sender, EventArgs e)
        {
            if (pick_b_up7.SelectedIndex == 0)
                b_up7 = 1;
            if (pick_b_up7.SelectedIndex == 1)
                b_up7 = 2;
            if (pick_b_up7.SelectedIndex == 2)
                b_up7 = 3;
            if (pick_b_up7.SelectedIndex == 3)
                b_up7 = 4;
            if (pick_b_up7.SelectedIndex == 4)
                b_up7 = 5;
            c_up7 = a_up7 * b_up7;
            if (c_up7 <= 3)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up7_color = "#01DF01"; }
            if (c_up7 > 3 && c_up7 <= 6)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_up7_color = "#ffb340"; }
            if (c_up7 > 6)
            { txt_resultup7.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_up7_color = "#f33636"; }
            txt_resultup7.Text = c_up7.ToString();
            //pick_b_up7.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_a_low7(object sender, EventArgs e)
        {
            if (pick_a_low7.SelectedIndex == 0)
                a_low7 = 1;
            if (pick_a_low7.SelectedIndex == 1)
                a_low7 = 2;
            if (pick_a_low7.SelectedIndex == 2)
                a_low7 = 3;
            if (pick_a_low7.SelectedIndex == 3)
                a_low7 = 4;
            if (pick_a_low7.SelectedIndex == 4)
                a_low7 = 5;
            c_low7 = a_low7 * b_low7;
            if (c_low7 <= 3)
            { txt_resultlow7.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low7_color = "#01DF01"; }
            if (c_low7 > 3 && c_low7 <= 6)
            { txt_resultlow7.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_low7_color = "#ffb340"; }
            if (c_low7 > 6)
            { txt_resultlow7.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_low7_color = "#f33636"; }
            txt_resultlow7.Text = c_low7.ToString();
            //pick_a_low7.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_low7(object sender, EventArgs e)
        {
            if (pick_b_low7.SelectedIndex == 0)
                b_low7 = 1;
            if (pick_b_low7.SelectedIndex == 1)
                b_low7 = 2;
            if (pick_b_low7.SelectedIndex == 2)
                b_low7 = 3;
            if (pick_b_low7.SelectedIndex == 3)
                b_low7 = 4;
            if (pick_b_low7.SelectedIndex == 4)
                b_low7 = 5;
            c_low7 = a_low7 * b_low7;
            if (c_low7 <= 3)
            { txt_resultlow7.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low7_color = "#01DF01"; }
            if (c_low7 > 3 && c_low7 <= 6)
            { txt_resultlow7.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_low7_color = "#ffb340"; }
            if (c_low7 > 6)
            { txt_resultlow7.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_low7_color = "#f33636"; }
            txt_resultlow7.Text = c_low7.ToString();
            //pick_b_low7.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        #endregion
        #region number pickers       
        private void OnSelectedIndexChanged_pick_a_up8(object sender, EventArgs e)
        {
            if (pick_a_up8.SelectedIndex == 0)
                a_up8 = 1;
            if (pick_a_up8.SelectedIndex == 1)
                a_up8 = 2;
            if (pick_a_up8.SelectedIndex == 2)
                a_up8 = 3;
            if (pick_a_up8.SelectedIndex == 3)
                a_up8 = 4;
            if (pick_a_up8.SelectedIndex == 4)
                a_up8 = 5;
            c_up8 = a_up8 * b_up8;
            if (c_up8 <= 3)
            { txt_resultup8.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up8_color = "#01DF01"; }
            if (c_up8 > 3 && c_up8 <= 6)
            { txt_resultup8.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_up8_color = "#ffb340"; }
            if (c_up8 > 6)
            { txt_resultup8.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_up8_color = "#f33636"; }
            txt_resultup8.Text = c_up8.ToString();
            //pick_a_up8.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_up8(object sender, EventArgs e)
        {
            if (pick_b_up8.SelectedIndex == 0)
                b_up8 = 1;
            if (pick_b_up8.SelectedIndex == 1)
                b_up8 = 2;
            if (pick_b_up8.SelectedIndex == 2)
                b_up8 = 3;
            if (pick_b_up8.SelectedIndex == 3)
                b_up8 = 4;
            if (pick_b_up8.SelectedIndex == 4)
                b_up8 = 5;
            c_up8 = a_up8 * b_up8;
            if (c_up8 <= 3)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up8_color = "#01DF01"; }
            if (c_up8 > 3 && c_up8 <= 6)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_up8_color = "#ffb340"; }
            if (c_up8 > 6)
            { txt_resultup8.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_up8_color = "#f33636"; }
            txt_resultup8.Text = c_up8.ToString();
            //pick_b_up8.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_a_low8(object sender, EventArgs e)
        {
            if (pick_a_low8.SelectedIndex == 0)
                a_low8 = 1;
            if (pick_a_low8.SelectedIndex == 1)
                a_low8 = 2;
            if (pick_a_low8.SelectedIndex == 2)
                a_low8 = 3;
            if (pick_a_low8.SelectedIndex == 3)
                a_low8 = 4;
            if (pick_a_low8.SelectedIndex == 4)
                a_low8 = 5;
            c_low8 = a_low8 * b_low8;
            if (c_low8 <= 3)
            { txt_resultlow8.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low8_color = "#01DF01"; }
            if (c_low8 > 3 && c_low8 <= 6)
            { txt_resultlow8.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_low8_color = "#ffb340"; }
            if (c_low8 > 6)
            { txt_resultlow8.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_low8_color = "#f33636"; }
            txt_resultlow8.Text = c_low8.ToString();
            //pick_a_low8.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_low8(object sender, EventArgs e)
        {
            if (pick_b_low8.SelectedIndex == 0)
                b_low8 = 1;
            if (pick_b_low8.SelectedIndex == 1)
                b_low8 = 2;
            if (pick_b_low8.SelectedIndex == 2)
                b_low8 = 3;
            if (pick_b_low8.SelectedIndex == 3)
                b_low8 = 4;
            if (pick_b_low8.SelectedIndex == 4)
                b_low8 = 5;
            c_low8 = a_low8 * b_low8;
            if (c_low8 <= 3)
            { txt_resultlow8.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low8_color = "#01DF01"; }
            if (c_low8 > 3 && c_low8 <= 6)
            { txt_resultlow8.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_low8_color = "#ffb340"; }
            if (c_low8 > 6)
            { txt_resultlow8.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_low8_color = "#f33636"; }
            txt_resultlow8.Text = c_low8.ToString();
            //pick_b_low8.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        #endregion
        #region number pickers       
        private void OnSelectedIndexChanged_pick_a_up9(object sender, EventArgs e)
        {
            if (pick_a_up9.SelectedIndex == 0)
                a_up9 = 1;
            if (pick_a_up9.SelectedIndex == 1)
                a_up9 = 2;
            if (pick_a_up9.SelectedIndex == 2)
                a_up9 = 3;
            if (pick_a_up9.SelectedIndex == 3)
                a_up9 = 4;
            if (pick_a_up9.SelectedIndex == 4)
                a_up9 = 5;
            c_up9 = a_up9 * b_up9;
            if (c_up9 <= 3)
            { txt_resultup9.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up9_color = "#01DF01"; }
            if (c_up9 > 3 && c_up9 <= 6)
            { txt_resultup9.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_up9_color = "#ffb340"; }
            if (c_up9 > 6)
            { txt_resultup9.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_up9_color = "#f33636"; }
            txt_resultup9.Text = c_up9.ToString();
            //pick_a_up9.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_up9(object sender, EventArgs e)
        {
            if (pick_b_up9.SelectedIndex == 0)
                b_up9 = 1;
            if (pick_b_up9.SelectedIndex == 1)
                b_up9 = 2;
            if (pick_b_up9.SelectedIndex == 2)
                b_up9 = 3;
            if (pick_b_up9.SelectedIndex == 3)
                b_up9 = 4;
            if (pick_b_up9.SelectedIndex == 4)
                b_up9 = 5;
            c_up9 = a_up9 * b_up9;
            if (c_up9 <= 3)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up9_color = "#01DF01"; }
            if (c_up9 > 3 && c_up9 <= 6)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_up9_color = "#ffb340"; }
            if (c_up9 > 6)
            { txt_resultup9.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_up9_color = "#f33636"; }
            txt_resultup9.Text = c_up9.ToString();
            //pick_b_up9.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_a_low9(object sender, EventArgs e)
        {
            if (pick_a_low9.SelectedIndex == 0)
                a_low9 = 1;
            if (pick_a_low9.SelectedIndex == 1)
                a_low9 = 2;
            if (pick_a_low9.SelectedIndex == 2)
                a_low9 = 3;
            if (pick_a_low9.SelectedIndex == 3)
                a_low9 = 4;
            if (pick_a_low9.SelectedIndex == 4)
                a_low9 = 5;
            c_low9 = a_low9 * b_low9;
            if (c_low9 <= 3)
            { txt_resultlow9.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low9_color = "#01DF01"; }
            if (c_low9 > 3 && c_low9 <= 6)
            { txt_resultlow9.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_low9_color = "#ffb340"; }
            if (c_low9 > 6)
            { txt_resultlow9.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_low9_color = "#f33636"; }
            txt_resultlow9.Text = c_low9.ToString();
            //pick_a_low9.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_low9(object sender, EventArgs e)
        {
            if (pick_b_low9.SelectedIndex == 0)
                b_low9 = 1;
            if (pick_b_low9.SelectedIndex == 1)
                b_low9 = 2;
            if (pick_b_low9.SelectedIndex == 2)
                b_low9 = 3;
            if (pick_b_low9.SelectedIndex == 3)
                b_low9 = 4;
            if (pick_b_low9.SelectedIndex == 4)
                b_low9 = 5;
            c_low9 = a_low9 * b_low9;
            if (c_low9 <= 3)
            { txt_resultlow9.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low9_color = "#01DF01"; }
            if (c_low9 > 3 && c_low9 <= 6)
            { txt_resultlow9.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_low9_color = "#ffb340"; }
            if (c_low9 > 6)
            { txt_resultlow9.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_low9_color = "#f33636"; }
            txt_resultlow9.Text = c_low9.ToString();
            //pick_b_low9.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        #endregion
        #region number pickers       
        private void OnSelectedIndexChanged_pick_a_up10(object sender, EventArgs e)
        {
            if (pick_a_up10.SelectedIndex == 0)
                a_up10 = 1;
            if (pick_a_up10.SelectedIndex == 1)
                a_up10 = 2;
            if (pick_a_up10.SelectedIndex == 2)
                a_up10 = 3;
            if (pick_a_up10.SelectedIndex == 3)
                a_up10 = 4;
            if (pick_a_up10.SelectedIndex == 4)
                a_up10 = 5;
            c_up10 = a_up10 * b_up10;
            if (c_up10 <= 3)
            { txt_resultup10.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up10_color = "#01DF01"; }
            if (c_up10 > 3 && c_up10 <= 6)
            { txt_resultup10.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_up10_color = "#ffb340"; }
            if (c_up10 > 6)
            { txt_resultup10.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_up10_color = "#f33636"; }
            txt_resultup10.Text = c_up10.ToString();
            //pick_a_up10.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_up10(object sender, EventArgs e)
        {
            if (pick_b_up10.SelectedIndex == 0)
                b_up10 = 1;
            if (pick_b_up10.SelectedIndex == 1)
                b_up10 = 2;
            if (pick_b_up10.SelectedIndex == 2)
                b_up10 = 3;
            if (pick_b_up10.SelectedIndex == 3)
                b_up10 = 4;
            if (pick_b_up10.SelectedIndex == 4)
                b_up10 = 5;
            c_up10 = a_up10 * b_up10;
            if (c_up10 <= 3)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_up10_color = "#01DF01"; }
            if (c_up10 > 3 && c_up10 <= 6)
            { txt_resultup.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_up10_color = "#ffb340"; }
            if (c_up10 > 6)
            { txt_resultup10.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_up10_color = "#f33636"; }
            txt_resultup10.Text = c_up10.ToString();
            //pick_b_up10.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_a_low10(object sender, EventArgs e)
        {
            if (pick_a_low10.SelectedIndex == 0)
                a_low10 = 1;
            if (pick_a_low10.SelectedIndex == 1)
                a_low10 = 2;
            if (pick_a_low10.SelectedIndex == 2)
                a_low10 = 3;
            if (pick_a_low10.SelectedIndex == 3)
                a_low10 = 4;
            if (pick_a_low10.SelectedIndex == 4)
                a_low10 = 5;
            c_low10 = a_low10 * b_low10;
            if (c_low10 <= 3)
            { txt_resultlow10.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low10_color = "#01DF01"; }
            if (c_low10 > 3 && c_low10 <= 6)
            { txt_resultlow10.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_low10_color = "#ffb340"; }
            if (c_low10 > 6)
            { txt_resultlow10.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_low10_color = "#f33636"; }
            txt_resultlow10.Text = c_low10.ToString();
            //pick_a_low10.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        private void OnSelectedIndexChanged_pick_b_low10(object sender, EventArgs e)
        {
            if (pick_b_low10.SelectedIndex == 0)
                b_low10 = 1;
            if (pick_b_low10.SelectedIndex == 1)
                b_low10 = 2;
            if (pick_b_low10.SelectedIndex == 2)
                b_low10 = 3;
            if (pick_b_low10.SelectedIndex == 3)
                b_low10 = 4;
            if (pick_b_low10.SelectedIndex == 4)
                b_low10 = 5;
            c_low10 = a_low10 * b_low10;
            if (c_low10 <= 3)
            { txt_resultlow10.TextColor = Xamarin.Forms.Color.FromHex("01DF01"); c_low10_color = "#01DF01"; }
            if (c_low10 > 3 && c_low10 <= 6)
            { txt_resultlow10.TextColor = Xamarin.Forms.Color.FromHex("#ffb340"); c_low10_color = "#ffb340"; }
            if (c_low10 > 6)
            { txt_resultlow10.TextColor = Xamarin.Forms.Color.FromHex("f33636"); c_low10_color = "#f33636"; }
            txt_resultlow10.Text = c_low10.ToString();
            //pick_b_low10.TextColor = Xamarin.Forms.Color.FromHex("191919");
        }
        #endregion
        private void OnSelectedIndexChanged_pick_a_new2(object sender, EventArgs e)
        {
            if (pick_a_low2.SelectedIndex == 0)
                a_new2 = 1;
            if (pick_a_low2.SelectedIndex == 1)
                a_new2 = 2;
            if (pick_a_low2.SelectedIndex == 2)
                a_new2 = 3;
            if (pick_a_low2.SelectedIndex == 3)
                a_new2 = 4;
            if (pick_a_low2.SelectedIndex == 4)
                a_new2 = 5;
            c_new2 = a_new2 * b_new2;
            txt_resultlow2.Text = c_new2.ToString();
        }
        private void OnSelectedIndexChanged_pick_b_new2(object sender, EventArgs e)
        {
            if (pick_b_low2.SelectedIndex == 0)
                b_new2 = 1;
            if (pick_b_low2.SelectedIndex == 1)
                b_new2 = 2;
            if (pick_b_low2.SelectedIndex == 2)
                b_new2 = 3;
            if (pick_b_low2.SelectedIndex == 3)
                b_new2 = 4;
            if (pick_b_low2.SelectedIndex == 4)
                b_new2 = 5;
            c_new2 = a_new2 * b_new2;
            txt_resultlow2.Text = c_new2.ToString();
        }
        #endregion



        
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
                sb.Append(@"<table width = '100%' height='100px' >
                    <tbody>
                        <tr bgcolor=grey>
                            <td align='Center '><font color='#000000 '><b> Maintenance Dynamic / Point of Work Risk Assessment</b> </font>
                            </td>
                        </tr>  
                        <tr> 
                            <td  bgcolor='silver' align='right'> <p style='color:#ffffff;font-size:5px;'><i>Created using Dynamic Risk Assessment tool © @The Health And Safety App </i></p> 
                            </td> 
                        </tr> 
                    </tbody>
                    </table>

                        <table style='border-collapse: collapse;'  Width='98%'><tbody>
                        <tr>          
                        <td colspan='2' align='left'><b> Name:</b></td>                     
                        <td colspan='3' align='left' border-bottom ='1'>" + txt_name.Text + @"</td>                                 
                        <td colspan='2' align='left'><b>Location Name:</b></td>
                        <td colspan='3' style='border-bottom: 0pt solid black;' align='left' >" + txt_projname.Text + @" </td>                                                       
                        </tr>                          
                            <tr>
                        <td colspan='2' align='left'><b> Task Description: </b></td>
                        <td colspan='3' align='left'>" + txt_sitename.Text + @"</td>
                        <td colspan='2' align='left'> <b> Date:</b></td>                                                                                       
                        <td colspan='3' align='left'>" + dat + @" </td>                                                                                             
                            </tr>    
                        <tr>
                        <td colspan='10' align='left'><b>  </b></td>                                                                                
                        </tr>             
                        </tbody>      
                        </table>");
                sb.Append(@"<table border='0' style='border-collapse:collapse;' width='100%'>
                        <tr> 
                            <th colspan='4' bgcolor='#3399ff'  align='center'><b><font color='white'> Step 1. Stop</font></b></th>
                            <th colspan='16' bgcolor='gray' style='text-align:center;'  ><b> Before starting work think through the task</b></th>                          
                        </tr>  
                        </table> 

                        
                        <table style ='border:solid 0px; width:100%' bgcolor='silver'>      
                            <tr>       
                            <th colspan='17' align='left'><b>Questions </b></th>
                            <th colspan='3' style='text-align:right;'><b>Yes/No/NA</b></th>
                        </tr>     
                    </table>"
                );
                sb.Append(@"<table style=' border:solid 0px; width:100% ' >
                    <tbody>
                         <caption style=""caption-side:bottom; text-align:left"" ><i> ! If you have answered no to any of the above , please inform your team leader. </i></caption>
                        
                         <tr>
                             <td   align='left' ><b> 1. </b></td>
                             <td colspan='16'  ><b> Are you fit and suitably competent to carry out the task(s) ?</b></td>
                             <td colspan='3'  align='right    '><b>" + pick_1.SelectedItem + @"</b></td>
                         </tr>
                 
                         <tr bgcolor='whitesmoke' style=' border-bottom: 0px solid #000;'>
                             <td colspan='1' align='left'><b> 2. </b></td >
                             <td colspan='16' align='left'><b > Do you have the relevant permit and documentation ?</b></td>
                             <td colspan='3' align='right'><b>"+ pick_2.SelectedItem + @"</b></td>
                         </tr>
                         <tr style='display: table-row; border-bottom: 0px '>
                             <td colspan='1' align='left'><b> 3. </b></td >
                             <td colspan='16' align='left'><b > Do you have the correct PPE and tools for the task(s) ? </b></td>
                             <td colspan='3' align='right'><b>" + pick_3.SelectedItem + @"</b></td>
                         </tr>
                         <tr bgcolor='whitesmoke' style=' border-bottom: 0px solid #000;'>
                             <td colspan='1' align='left'><b> 4. </b></td >
                             <td colspan='16' align='left'><b > Do you have suitable access into the work area ?</b></td>
                             <td colspan='3' align='right'><b>" + pick_4.SelectedItem + @"</b></td>
                         </tr>
                         
                        </tbody>
              </table>");
                            sb.Append(@"<table border='0' style='border-collapse:collapse;' border=0 width='100%'>
                                            <tr> 
                                                <th colspan='4' bgcolor='#3399ff'  align='center'><b><font color='white'> Step 2. Think </font></b></th>
                                                <th colspan='16' bgcolor='gray' style='text-align:center;'><b> Spot the Hazards </b></th>                          
                                            </tr>  
                                            </table> 
                                             <table style ='border:solid 0px; width:100%' bgcolor='silver'>      
                            <tr>       
                            <th colspan='17' align='left'><b>Hazard </b></th>
                            <th colspan='3' style='text-align:right;'><b>Yes/No</b></th>
                        </tr>     
                        </table>");
                sb.Append(@"<table style='border:solid 0px;' width='100%'>
                            <caption style=""caption-side:bottom; text-align:left"" ><i> ! Where hazard is identified it should be covered by a generic or specific Risk Assessment </i></caption>
                            
                        
                        <tr>
                            <td colspan='' align='left'><b> 1. </b></td >
                            <td colspan='16' align='left'><b> Slip, Trip and Fall</b></td>
                            <td colspan='3' align='right'><b>" + pick2_1.SelectedItem + @"</b></td>
                        </tr>


                        <tr bgcolor='whitesmoke' style=' border-bottom: 0px solid #000;'>
                            <td colspan='' align='left'><b> 2. </b></td >
                            <td colspan='16' align='left'><b> Work at height </b></td>
                            <td colspan='3' align='right'><b>" + pick2_2.SelectedItem + @"</b></td>
                        </tr>
                        
                        <tr>
                            <td colspan='' align='left'><b> 3. </b></td >
                            <td colspan='16' align='left'><b> Risk of fall from height</b></td>
                            <td colspan='3' align='right'><b>" + pick2_3.SelectedItem + @" </b></td>
                        </tr>

                         <tr bgcolor='whitesmoke' style=' border-bottom: 0px solid #000;'>
                            <td colspan='' align='left'><b> 4. </b></td >
                            <td colspan='16' align='left'><b> Lifting operation / Cranes</b></td>
                            <td colspan='3' align='right'><b>" + pick2_4.SelectedItem + @"</b></td>
                        </tr>

                        <tr>
                            <td colspan='' align='left'><b> 5. </b></td >
                            <td colspan='16' align='left'><b> Falling / Ejected Objects</b></td>
                            <td colspan='3' align='right'><b>" + pick2_5.SelectedItem + @"</b></td>
                        </tr>

                         <tr bgcolor='whitesmoke' style=' border-bottom: 0px solid #000;'>
                            <td colspan='' align='left'><b> 6. </b></td >
                            <td colspan='16' align='left'><b> Moving Vehicles</b></td>
                            <td colspan='3' align='right'><b>" + pick2_6.SelectedItem + @"</b></td>
                        </tr>

                        <tr>
                            <td colspan='' align='left'><b> 7. </b></td >
                            <td colspan='16' align='left'><b>Overturning / Collapse</b></td>
                            <td colspan='3' align='right'><b>" + pick2_7.SelectedItem + @"</b></td>
                        </tr>

                         <tr bgcolor='whitesmoke' style=' border-bottom: 0px solid #000;'>
                            <td colspan='' align='left'><b> 8. </b></td >
                            <td colspan='16' align='left'><b>Electricity (HV/LV)</b></td>
                            <td colspan='3' align='right'><b>" + pick2_8.SelectedItem + @"</b></td>
                        </tr>

                        <tr>
                            <td colspan='' align='left'><b> 9. </b></td >
                            <td colspan='16' align='left'><b>Pressurised equipment</b></td>
                            <td colspan='3' align='right'><b>" + pick2_9.SelectedItem + @"</b></td>
                        </tr>


                        <tr bgcolor='whitesmoke' style=' border-bottom: 0px solid #000;'>
                            <td colspan='' align='left'><b> 10. </b></td >
                            <td colspan='16' align='left'><b> Sharp Objects </b></td>
                            <td colspan='3' align='right'><b>" + pick2_10.SelectedItem + @"</b></td>
                        </tr>
                        
                        <tr>
                            <td colspan='' align='left'><b> 11. </b></td >
                            <td colspan='16' align='left'><b>Manual Handling / Ergonomics</b></td>
                            <td colspan='3' align='right'><b>" + pick2_11.SelectedItem + @"</b></td>
                        </tr>

                         <tr bgcolor='whitesmoke' style=' border-bottom: 0px solid #000;'>
                            <td colspan='' align='left'><b> 12. </b></td >
                            <td colspan='16' align='left'><b>Confined / Restricted space</b></td>
                            <td colspan='3' align='right'><b>" + pick2_12.SelectedItem + @"</b></td>
                        </tr>

                        <tr>
                            <td colspan='' align='left'><b> 13. </b></td >
                            <td colspan='16' align='left'><b> Poor lighting</b></td>
                            <td colspan='3' align='right'><b>" + pick2_13.SelectedItem + @"</b></td>
                        </tr>

                         <tr bgcolor='whitesmoke' style=' border-bottom: 0px solid #000;'>
                            <td colspan='' align='left'><b> 14. </b></td >
                            <td colspan='16' align='left'><b> Fire / Explosion Risk</b></td>
                            <td colspan='3' align='right'><b>" + pick2_14.SelectedItem + @"</b></td>
                        </tr>

                        <tr>
                            <td colspan='' align='left'><b> 15. </b></td >
                            <td colspan='16' align='left'><b>Dust, Fumes, Gases, Vapours</b></td>
                            <td colspan='3' align='right'><b>" + pick2_15.SelectedItem + @"</b></td>
                        </tr>

                         <tr bgcolor='whitesmoke' style=' border-bottom: 0px solid #000;'>
                            <td colspan='' align='left'><b> 16. </b></td >
                            <td colspan='16' align='left'><b>Hazardous material</b></td>
                            <td colspan='3' align='right'><b>" + pick2_16.SelectedItem + @"</b></td>
                        </tr>

                         <tr>
                            <td colspan='' align='left'><b> 17. </b></td >
                            <td colspan='16' align='left'><b>Noise</b></td>
                            <td colspan='3' align='right'><b>" + pick2_17.SelectedItem + @"</b></td>
                        </tr>


                        <tr bgcolor='whitesmoke' style=' border-bottom: 0px solid #000;'>
                            <td colspan='' align='left'><b> 18. </b></td >
                            <td colspan='16' align='left'><b> Vibration </b></td>
                            <td colspan='3' align='right'><b>" + pick2_18.SelectedItem + @"</b></td>
                        </tr>
                        
                        <tr>
                            <td colspan='' align='left'><b> 19. </b></td >
                            <td colspan='16' align='left'><b>High/Low humidity </b></td>
                            <td colspan='3' align='right'><b>" + pick2_19.SelectedItem + @"</b></td>
                        </tr>

                         <tr bgcolor='whitesmoke' style=' border-bottom: 0px solid #000;'>
                            <td colspan='' align='left'><b> 20. </b></td >
                            <td colspan='16' align='left'><b>Hot/Cold temperatures</b></td>
                            <td colspan='3' align='right'><b>" + pick2_20.SelectedItem + @"</b></td>
                        </tr>

                        <tr>
                            <td colspan='' align='left'><b> 21. </b></td >
                            <td colspan='16' align='left'><b>Lone working</b></td>
                            <td colspan='3' align='right'><b>" + pick2_21.SelectedItem + @"</b></td>
                        </tr>

                         <tr bgcolor='whitesmoke' style='border-bottom: 0px solid #000;'>
                            <td colspan='' align='left'><b> 22. </b></td >
                            <td colspan='16' align='left'><b>Specialist equipment required </b></td>
                            <td colspan='3' align='right'><b>" + pick2_22.SelectedItem + @"</b></td>
                        </tr>

                       

                        <tr  style=' border-bottom: 0px solid #000;'>
                            <td colspan='' align='left'><b> 24. </b></td >
                            <td colspan='16' align='left'><b>Risk to you from others </b></td>
                            <td colspan='3' align='right'><b>" + pick2_24.SelectedItem + @"</b></td>
                        </tr>
                        <tr>
                            <td colspan='' align='left'><b> 25. </b></td >
                            <td colspan='3' align='left'><b>Others:</b></td>
                        </tr>
                   
                         

                        </table>
                <table style='border:solid 0px;' width='100%'>
                    <tbody>
                         <tr style=' border-bottom: 0px solid #000;'>
                             
                            <td colspan='16' align='left'>Are you and your colleagues safe?</td>
                            <td colspan='3' align='right'><b>" + pick3_1.SelectedItem + @"</b></td>
                        </tr>    
                    </tbody>
                
                </table>");

                sb.Append(@"<table border='1' style='border-collapse:collapse;' width='100%'>
    <tr>
        <th colspan='9' bgcolor='#3399ff' align='center'><b><font color='white'> Step 3. Action </font></b></th>
        <th colspan='10' bgcolor='gray' align='center'><b> Assess the risk of any significant hazards identified
            earlier </b></th>
    </tr>

    <tr bgcolork='silver'>
        <th colspan='13' align='left'><b>Hazard identified/ Control Measures </b></th>
        <th colspan='2' align='center'><b> Likelihood </b></th>
        <th colspan='2' align='center'><b> Severity </b></th>
        <th colspan='2' align='center'><b> Residual Risk </b></th>
    </tr>
    <tr>
        <th rowspan='2'> <b>1.</b></th>
        <th colspan='12' align='left' style='border:none;'><b> " + txt_fill1.Text + @"</b></th>
        <th colspan='2' align='center' style='border:none;'>" + pick_a_up.SelectedItem + @"</th>
        <th colspan='2' align='center' style='border:none;'>" + pick_b_up.SelectedItem + @"</th>
        <th colspan='2' align='center' style='border:none;'>" + txt_resultup.Text + @"</th>
        <tr>
            <th colspan='12' align='left' style='border:none;'><b> " + txt_fill2.Text + @" </b></th>
            <th colspan='2' align='center' style='border:none;'>" + pick_a_low.SelectedItem + @"</th>
            <th colspan='2' align='center' style='border:none;'>" + pick_b_low.SelectedItem + @"</th>
            <th colspan='2' align='center' style='border:none;'>" + txt_resultlow.Text + @"</th>
        </tr>
    </tr>");
                if (fill_text_11.IsVisible == true)
                {
                    sb.Append(@"
                            <tr>
                <th rowspan='2'> <b>2.</b></th>
                <th colspan='12' align='left' style='border:none;'><b> " + txt_Check_text11.Text + @"</b></th>
                <th colspan='2' align='center' style='border:none;'>" + pick_a_up1.SelectedItem + @"</th>
                <th colspan='2' align='center' style='border:none;'>" + pick_b_up1.SelectedItem + @"</th>
                <th colspan='2' align='center' style='border:none;color:" + c_up1_color + ";'>" + txt_resultup1.Text + @"</ th >
                <tr>
                    <th colspan='12' align='left' style='border:none;'><b> "  + txt_Check_text12.Text + @" </b></th>
                    <th colspan='2' align='center' style='border:none;'>" + pick_a_low1.SelectedItem + @"</th>
                    <th colspan='2' align='center' style='border:none;'>" + pick_b_low1.SelectedItem+ @"</th>
                    <th colspan='2' align='center' style='border:none;color:" + c_low1_color + ";'>" + txt_resultlow.Text + @"</th>
                </tr>
                </tr>
                ");
                }
                if (fill_text_21.IsVisible == true)
                {
                    sb.Append(@"<tr>
                    <th rowspan='2'> <b>3.</b></th>
                    <th colspan='12' align='left' style='border:none;'><b> " + txt_Check_text21.Text + @"</b></th>
                    <th colspan='2' align='center' style='border:none;'>" + pick_a_up2.SelectedItem + @"</th>
                    <th colspan='2' align='center' style='border:none;'>" + pick_b_up2.SelectedItem + @"</th>
                    <th colspan='2' align='center' style='border:none;color:" + c_up2_color + ";'>" + txt_resultup2.Text + @"</th>
                    <tr>
                        <th colspan='12' align='left' style='border:none;'><b> " + txt_Check_text22.Text + @" </b></th>
                        <th colspan='2' align='center' style='border:none;'>" + pick_a_low2.SelectedItem + @"</th>
                        <th colspan='2' align='center' style='border:none;'>" + pick_b_low2.SelectedItem + @"</th>
                        <th colspan='2' align='center' style='border:none;color:" + c_low2_color + ";'>" + txt_resultlow2.Text + @"</th>
                    </tr>
                </tr>");

                }
                if (fill_text_31.IsVisible == true)
                {
                    sb.Append(@"<tr>
                        <th rowspan='2'> <b>4.</b></th>
                        <th colspan='12' align='left' style='border:none;'><b> " + txt_Check_text31.Text + @"</b></th>
                        <th colspan='2' align='center' style='border:none;'>" + pick_a_up3.SelectedItem + @"</th>
                        <th colspan='2' align='center' style='border:none;'>" + pick_b_up3.SelectedItem + @"</th>
                        <th colspan='2' align='center' style='border:none;color:" + c_up3_color + ";'>" + txt_resultup3.Text + @"</th>
                        <tr>
                            <th colspan='12' align='left' style='border:none;'><b> " + txt_Check_text32.Text + @" </b></th>
                            <th colspan='2' align='center' style='border:none;'>" + pick_a_low3.SelectedItem + @"</th>
                            <th colspan='2' align='center' style='border:none;'>" + pick_b_low3.SelectedItem + @"</th>
                            <th colspan='2' align='center' style='border:none;color:" + c_low3_color + ";'>" + txt_resultlow3.Text + @"</th>
                        </tr>
                    </tr>");

                }
                if (fill_text_41.IsVisible == true)
                {
                    sb.Append(@" <tr>
        <th rowspan='2'> <b>5.</b></th>
        <th colspan='12' align='left' style='border:none;'><b> " + txt_Check_text41.Text + @"</b></th>
        <th colspan='2' align='center' style='border:none;'>" + pick_a_up4.SelectedItem + @"</th>
        <th colspan='2' align='center' style='border:none;'>" + pick_b_up4.SelectedItem + @"</th>
        <th colspan='2' align='center' style='border:none;color:" + c_up4_color + ";'>" + txt_resultup4.Text + @"</th>
        <tr>
            <th colspan='12' align='left' style='border:none;'><b> " + txt_Check_text42.Text + @" </b></th>
            <th colspan='2' align='center' style='border:none;'>" + pick_a_low4.SelectedItem + @"</th>
            <th colspan='2' align='center' style='border:none;'>" + pick_b_low4.SelectedItem + @"</th>
            <th colspan='2' align='center' style='border:none;color:" + c_low4_color + ";'>" + txt_resultlow4.Text + @"</th>
        </tr>
    </tr>");

                }
                if (fill_text_51.IsVisible == true)
                {
                    sb.Append(@"<tr>
                        <th rowspan='2'> <b>6.</b></th>
                        <th colspan='12' align='left' style='border:none;'><b> " + txt_Check_text51.Text + @"</b></th>
                        <th colspan='2' align='center' style='border:none;'>" + pick_a_up5.SelectedItem + @"</th>
                        <th colspan='2' align='center' style='border:none;'>" + pick_b_up5.SelectedItem + @"</th>
                        <th colspan='2' align='center' style='border:none;color:" + c_up5_color + ";'>" + txt_resultup5.Text + @"</th>
                        <tr>
                            <th colspan='12' align='left' style='border:none;'><b> " + txt_Check_text52.Text + @" </b></th>
                            <th colspan='2' align='center' style='border:none;'>" + pick_a_low5.SelectedItem + @"</th>
                            <th colspan='2' align='center' style='border:none;'>" + pick_b_low5.SelectedItem + @"</th>
                            <th colspan='2' align='center' style='border:none;color:" + c_low5_color + ";'>" + txt_resultlow5.Text + @"</th>
                        </tr>
                    </tr>");

                }
                if (fill_text_61.IsVisible == true)
                {
                    sb.Append(@"<tr>
                        <th rowspan='2'> <b>7.</b></th>
                        <th colspan='12' align='left' style='border:none;'><b> " + txt_Check_text61.Text + @"</b></th>
                        <th colspan='2' align='center' style='border:none;'>" + pick_a_up6.SelectedItem + @"</th>
                        <th colspan='2' align='center' style='border:none;'>" + pick_b_up6.SelectedItem + @"</th>
                        <th colspan='2' align='center' style='border:none;color:" + c_up6_color + ";'>" + txt_resultup6.Text + @"</th>
                        <tr>
                            <th colspan='12' align='left' style='border:none;'><b> " + txt_Check_text62.Text + @" </b></th>
                            <th colspan='2' align='center' style='border:none;'>" + pick_a_low6.SelectedItem + @"</th>
                            <th colspan='2' align='center' style='border:none;'>" + pick_b_low6.SelectedItem + @"</th>
                            <th colspan='2' align='center' style='border:none;color:" + c_low6_color + ";'>" + txt_resultlow6.Text + @"</th>
                        </tr>
                    </tr>");

                }
                if (fill_text_71.IsVisible == true)
                {
                    sb.Append(@"<tr>
                        <th rowspan='2'> <b>8.</b></th>
                        <th colspan='12' align='left' style='border:none;'><b> " + txt_Check_text71.Text + @"</b></th>
                        <th colspan='2' align='center' style='border:none;'>" + pick_a_up7.SelectedItem + @"</th>
                        <th colspan='2' align='center' style='border:none;'>" + pick_b_up7.SelectedItem + @"</th>
                        <th colspan='2' align='center' style='border:none;color:" + c_up7_color + ";'>" + txt_resultup7.Text + @"</th>
                        <tr>
                            <th colspan='12' align='left' style='border:none;'><b> " + txt_Check_text72.Text + @" </b></th>
                            <th colspan='2' align='center' style='border:none;'>" + pick_a_low7.SelectedItem + @"</th>
                            <th colspan='2' align='center' style='border:none;'>" + pick_b_low7.SelectedItem + @"</th>
                            <th colspan='2' align='center' style='border:none;color:" + c_low7_color + ";'>" + txt_resultlow7.Text + @"</th>
                        </tr>
                    </tr>");

                }
                if (fill_text_81.IsVisible == true)
                {
                    sb.Append(@"<tr>
                        <th rowspan='2'> <b>9.</b></th>
                        <th colspan='12' align='left' style='border:none;'><b> " + txt_Check_text81.Text + @"</b></th>
                        <th colspan='2' align='center' style='border:none;'>" + pick_a_up8.SelectedItem + @"</th>
                        <th colspan='2' align='center' style='border:none;'>" + pick_b_up8.SelectedItem + @"</th>
                        <th colspan='2' align='center' style='border:none;color:" + c_up8_color + ";'>" + txt_resultup8.Text + @"</th>
                        <tr>
                            <th colspan='12' align='left' style='border:none;'><b> " + txt_Check_text82.Text + @" </b></th>
                            <th colspan='2' align='center' style='border:none;'>" + pick_a_low8.SelectedItem + @"</th>
                            <th colspan='2' align='center' style='border:none;'>" + pick_b_low8.SelectedItem + @"</th>
                            <th colspan='2' align='center' style='border:none;color:" + c_low8_color + ";'>" + txt_resultlow8.Text + @"</th>
                        </tr>
                    </tr>");

                }
                if (fill_text_91.IsVisible == true)
                {
                    sb.Append(@"<tr>
                    <th rowspan='2'> <b>10.</b></th>
                    <th colspan='12' align='left' style='border:none;'><b> " + txt_Check_text91.Text + @"</b></th>
                    <th colspan='2' align='center' style='border:none;'>" + pick_a_up9.SelectedItem + @"</th>
                    <th colspan='2' align='center' style='border:none;'>" + pick_b_up9.SelectedItem + @"</th>
                    <th colspan='2' align='center' style='border:none;color:" + c_up9_color + ";'>" + txt_resultup9.Text + @"</th>
                    <tr>
                        <th colspan='12' align='left' style='border:none;'><b> " + txt_Check_text92.Text + @" </b></th>
                        <th colspan='2' align='center' style='border:none;'>" + pick_a_low9.SelectedItem + @"</th>
                        <th colspan='2' align='center' style='border:none;'>" + pick_b_low9.SelectedItem + @"</th>
                        <th colspan='2' align='center' style='border:none;color:" + c_low9_color + ";'>" + txt_resultlow9.Text + @"</th>
                    </tr>
                </tr>");

                }
                if (fill_text_101.IsVisible == true)
                {
                    sb.Append(@"<tr>
                        <th rowspan='2'> <b>11.</b></th>
                        <th colspan='12' align='left' style='border:none;'><b> " + txt_Check_text101.Text + @"</b></th>
                        <th colspan='2' align='center' style='border:none;'>" + pick_a_up10.SelectedItem + @"</th>
                        <th colspan='2' align='center' style='border:none;'>" + pick_b_up10.SelectedItem + @"</th>
                        <th colspan='2' align='center' style='border:none;color:" + c_up10_color + ";'>" + txt_resultup10.Text + @"</th>
                        <tr>
                            <th colspan='12' align='left' style='border:none;'><b> " + txt_Check_text102.Text + @" </b></th>
                            <th colspan='2' align='center' style='border:none;'>" + pick_a_low10.SelectedItem + @"</th>
                            <th colspan='2' align='center' style='border:none;'>" + pick_b_low10.SelectedItem + @"</th>
                            <th colspan='2' align='center' style='border:none;color:" + c_low10_color + ";'>" + txt_resultlow10.Text + @"</th>
                        </tr>
                    </tr>");

                }
                sb.Append("</table>");
                sb.Append(@"
                    <table border='1' style='border-collapse:collapse;margin-left: auto;margin-right: auto;' width='80%' align='Center'>
                    <thead>
                      <tr>
                        <th colspan=""17"" bgcolor=""grey"">Likehood</th>
                      </tr>
                    </thead>
                    <tbody>
                      <tr bgcolor='silver' >
                        <td colspan=""5""></td>
                        <td colspan=""2"">Zero to very low</td>
                        <td colspan=""2"">VeryUnlikely</td>
                        <td colspan=""2"">Unlikely</td>
                        <td colspan=""2"">Likely</td>
                        <td colspan=""2"">Very Likely</td>
                        <td colspan=""2"">AlmostCertain</td>
                      </tr>
                      <tr>
                        <td colspan=""5"" >SEVERITY</td>
                        <td colspan=""2"">0</td>
                        <td colspan=""2"">1</td>
                        <td colspan=""2"">2</td>
                        <td colspan=""2"">3</td>
                        <td colspan=""2"" >4</td>
                        <td colspan=""2"">5</td>
                      </tr>
                      <tr>
                        <td colspan=""3"">Fatality,Disabling injury,etc</td>
                        <td colspan=""2"" >5</td>
                        <td colspan=""2""bgcolor=""#34ff34"">0</td>
                        <td colspan=""2"" bgcolor=""#ffc702"">5</td>
                        <td colspan=""2"" bgcolor=""red"">10</td>
                        <td colspan=""2"" bgcolor=""red"">15</td>
                        <td colspan=""2"" bgcolor=""red"">20</td>
                        <td colspan=""2"" bgcolor=""red"">25</td>
                      </tr>
                      <tr>
                        <td colspan=""3"">Major injury or illness</td>
                        <td colspan=""2"" >4</td>
                        <td colspan=""2"" bgcolor=""#34ff34"">0</td>
                        <td colspan=""2"" bgcolor=""#ffc702"">4</td>
                        <td colspan=""2"" bgcolor=""red"">8</td>
                        <td colspan=""2"" bgcolor=""red"">12</td>
                        <td colspan=""2"" bgcolor=""red"">16</td>
                        <td colspan=""2"" bgcolor=""red"">20</td>
                      </tr>
                      <tr>
                        <td colspan=""3"">7 day injury or illness</td>
                        <td colspan=""2"">3</td>
                        <td colspan=""2"" bgcolor=""#34ff34"">0</td>
                        <td colspan=""2"" bgcolor=""#ffc702"">3</td>
                        <td colspan=""2"" bgcolor=""#ffc702"">6</td>
                        <td colspan=""2"" bgcolor=""red"">9</td>
                        <td colspan=""2"" bgcolor=""red"">12</td>
                        <td colspan=""2"" bgcolor=""red"">15</td>
                      </tr>
                      <tr>
                        <td colspan=""3"">Minor injury or illness</td>
                        <td colspan=""2"">2</td>
                        <td colspan=""2""bgcolor=""#34ff34"">0</td>
                        <td colspan=""2""bgcolor=""#34ff34"">2</td>
                        <td colspan=""2"" bgcolor=""#ffc702"">4</td>
                        <td colspan=""2"" bgcolor=""#ffc702"">6</td>
                        <td colspan=""2"" bgcolor=""red"">8</td>
                        <td colspan=""2"" bgcolor=""red"">10</td>
                      </tr>
                      <tr>
                        <td colspan=""3"">First aid injury or illness</td>
                        <td colspan=""2"" >1</td>
                        <td colspan=""2"" bgcolor=""#34ff34"">0</td>
                        <td colspan=""2"" bgcolor=""#34ff34"">1</td>
                        <td colspan=""2"" bgcolor=""#34ff34"">2</td>
                        <td colspan=""2"" bgcolor=""#ffc702"">3</td>
                        <td colspan=""2"" bgcolor=""#ffc702"">4</td>
                        <td colspan=""2"" bgcolor=""#ffc702"">5</td>
                      </tr>
                      <tr>
                        <td colspan=""3"">No injury or illness</td>
                        <td colspan=""2"" >0</td>
                        <td colspan=""2"" bgcolor=""#34ff34"">0</td>
                        <td colspan=""2"" bgcolor=""#34ff34"">0</td>
                        <td colspan=""2"" bgcolor=""#34ff34"">0</td>
                        <td colspan=""2"" bgcolor=""#34ff34"">0</td>
                        <td colspan=""2"" bgcolor=""#34ff34"">0</td>
                        <td colspan=""2"" bgcolor=""#34ff34"">0</td>
                      </tr>
                    </tbody>
                    </table>");
                sb.Append(@"
                    <table  border='1' style='border-collapse:collapse;' width='100%'>
                    <thead>
                      <tr>
                        <th rowspan=""2"" colspan=""1""  align='left'><b>Signature(s) </b></th>
                        <th colspan=""8"" rowspan=""2""></th>
                        <th rowspan=""2"" colspan=""3""><b>Date: </b></th>
                        <th colspan=""4"" rowspan=""2""></th>
                          <th rowspan=""2""><b>ReviewDate:</b></th>
                        <th colspan=""2"" rowspan=""2""></th>
                      </tr>
                    </thead>
                    </table>");
                sb.Append(" </main");
                IFolder rootFolder = await PCLStorage.FileSystem.Current.GetFolderFromPathAsync(path);
                IFolder folder = await rootFolder.CreateFolderAsync("HandSAppPdf", CreationCollisionOption.OpenIfExists);

                string fnam = await InputBox(this.Navigation);

                if (fnam is null) { return; }
                else
                { if (fnam == "") { fnam = "Dynamic Risk Assessment.pdf"; } else { fnam = fnam + ".pdf"; } }

                IFile file = await folder.CreateFileAsync(fnam, CreationCollisionOption.GenerateUniqueName);


                using (var fs = await file.OpenAsync(FileAccess.ReadAndWrite))
                {
                    ConverterProperties properties = new ConverterProperties();
                    PdfWriter writer = new PdfWriter(fs);
                    PdfDocument pdfDocument = new PdfDocument(writer);
                    pdfDocument.SetDefaultPageSize(PageSize.A4);
                    var doc = HtmlConverter.ConvertToDocument(sb.ToString(), pdfDocument, properties);
                    doc.Close();
                    await DisplayAlert("File Path", file.Path.ToString(), "OK");
                }
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
            }

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
            catch (Exception ex) {
                Crashes.TrackError(ex);
            }
        }
        public async Task PCLGenarateJson(string path)
        {
            try
            {
                string dat = "";
                var dt = datepicker.Date;
                dat = dt.ToString(CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern);
                IFile file;
                DraftFields s = new DraftFields
                {
                    Name1 = txt_name.Text,
                    ProjectName = txt_projname.Text,
                    SiteName = txt_sitename.Text,
                    Date = dat,

                    pick1 = pick_1.Items[pick_1.SelectedIndex],
                    pick2 = pick_2.Items[pick_2.SelectedIndex],
                    pick3 = pick_3.Items[pick_3.SelectedIndex],
                    pick4 = pick_4.Items[pick_4.SelectedIndex],

                    pick2_1 = pick2_1.Items[pick2_1.SelectedIndex],
                    pick2_2 = pick2_2.Items[pick2_2.SelectedIndex],
                    pick2_3 = pick2_3.Items[pick2_3.SelectedIndex],
                    pick2_4 = pick2_4.Items[pick2_4.SelectedIndex],
                    pick2_5 = pick2_5.Items[pick2_5.SelectedIndex],
                    pick2_6 = pick2_6.Items[pick2_6.SelectedIndex],
                    pick2_7 = pick2_7.Items[pick2_7.SelectedIndex],
                    pick2_8 = pick2_8.Items[pick2_8.SelectedIndex],

                    pick2_9 = pick2_9.Items[pick2_9.SelectedIndex],
                    pick2_10 = pick2_10.Items[pick2_10.SelectedIndex],
                    pick2_11 = pick2_11.Items[pick2_11.SelectedIndex],
                    pick2_12 = pick2_12.Items[pick2_12.SelectedIndex],
                    pick2_13 = pick2_13.Items[pick2_13.SelectedIndex],
                    pick2_14 = pick2_14.Items[pick2_14.SelectedIndex],
                    pick2_15 = pick2_15.Items[pick2_15.SelectedIndex],
                    pick2_16 = pick2_16.Items[pick2_16.SelectedIndex],


                    pick2_17 = pick2_17.Items[pick2_17.SelectedIndex],
                    pick2_18 = pick2_18.Items[pick2_18.SelectedIndex],
                    pick2_19 = pick2_19.Items[pick2_19.SelectedIndex],
                    pick2_20 = pick2_20.Items[pick2_20.SelectedIndex],
                    pick2_21 = pick2_21.Items[pick2_21.SelectedIndex],
                    pick2_22 = pick2_22.Items[pick2_22.SelectedIndex],
                    pick2_23 = pick2_23.Items[pick2_23.SelectedIndex],
                    pick2_24 = pick2_24.Items[pick2_24.SelectedIndex],

                    step2_other = step2_other.Text,
                    pick3_1 = pick3_1.Items[pick3_1.SelectedIndex],

                    fillable_txt1 = txt_fill1.Text,
                    fillable_txt2 = txt_fill2.Text,
                    fillable_txt3 = txt_Check_text11.Text,
                    fillable_txt4 = txt_Check_text12.Text,
                    fillable_txt5 = txt_Check_text21.Text,
                    fillable_txt6 = txt_Check_text22.Text,
                    fillable_txt7 = txt_Check_text31.Text,
                    fillable_txt8 = txt_Check_text32.Text,
                    fillable_txt9 = txt_Check_text41.Text,
                    fillable_txt10 = txt_Check_text42.Text,
                    fillable_txt11 = txt_Check_text51.Text,
                    fillable_txt12 = txt_Check_text52.Text,
                    fillable_txt13 = txt_Check_text61.Text,
                    fillable_txt14 = txt_Check_text62.Text,
                    fillable_txt15 = txt_Check_text71.Text,
                    fillable_txt16 = txt_Check_text72.Text,
                    fillable_txt17 = txt_Check_text81.Text,
                    fillable_txt18 = txt_Check_text82.Text,
                    fillable_txt19 = txt_Check_text91.Text,
                    fillable_txt20 = txt_Check_text92.Text,
                    fillable_txt21 = txt_Check_text101.Text,
                    fillable_txt22 = txt_Check_text102.Text,
                    a_up = a_up.ToString(),
                    b_up = b_up.ToString(),
                    c_up = c_up.ToString(),
                    a_low = a_low.ToString(),
                    b_low = b_low.ToString(),
                    c_low = c_low.ToString(),
                    a_new = a_new.ToString(),
                    b_new = b_new.ToString(),
                    c_new = c_new.ToString(),
                    a_new1 = a_new1.ToString(),
                    b_new1 = b_new1.ToString(),
                    c_new1 = c_new1.ToString(),
                    a_new2 = a_new2.ToString(),
                    b_new2 = b_new2.ToString(),
                    c_new2 = c_new2.ToString(),
                    a_up1 = a_up1.ToString(),
                    b_up1 = b_up1.ToString(),
                    c_up1 = c_up1.ToString(),
                    a_low1 = a_low1.ToString(),
                    b_low1 = b_low1.ToString(),
                    c_low1 = c_low1.ToString(),

                    a_up2 = a_up2.ToString(),
                    b_up2 = b_up2.ToString(),
                    c_up2 = c_up2.ToString(),
                    a_low2 = a_low2.ToString(),
                    b_low2 = b_low2.ToString(),
                    c_low2 = c_low2.ToString(),

                    a_up3 = a_up3.ToString(),
                    b_up3 = b_up3.ToString(),
                    c_up3 = c_up3.ToString(),
                    a_low3 = a_low3.ToString(),
                    b_low3 = b_low3.ToString(),
                    c_low3 = c_low3.ToString(),

                    a_up4 = a_up4.ToString(),
                    b_up4 = b_up4.ToString(),
                    c_up4 = c_up4.ToString(),
                    a_low4 = a_low4.ToString(),
                    b_low4 = b_low4.ToString(),
                    c_low4 = c_low4.ToString(),

                    a_up5 = a_up5.ToString(),
                    b_up5 = b_up5.ToString(),
                    c_up5 = c_up5.ToString(),
                    a_low5 = a_low5.ToString(),
                    b_low5 = b_low5.ToString(),
                    c_low5 = c_low5.ToString(),

                    a_up6 = a_up6.ToString(),
                    b_up6 = b_up6.ToString(),
                    c_up6 = c_up6.ToString(),
                    a_low6 = a_low6.ToString(),
                    b_low6 = b_low6.ToString(),
                    c_low6 = c_low6.ToString(),

                    a_up7 = a_up7.ToString(),
                    b_up7 = b_up7.ToString(),
                    c_up7 = c_up7.ToString(),
                    a_low7 = a_low7.ToString(),
                    b_low7 = b_low7.ToString(),
                    c_low7 = c_low7.ToString(),

                    a_up8 = a_up8.ToString(),
                    b_up8 = b_up8.ToString(),
                    c_up8 = c_up8.ToString(),
                    a_low8 = a_low8.ToString(),
                    b_low8 = b_low8.ToString(),
                    c_low8 = c_low8.ToString(),

                    a_up9 = a_up9.ToString(),
                    b_up9 = b_up9.ToString(),
                    c_up9 = c_up9.ToString(),
                    a_low9 = a_low9.ToString(),
                    b_low9 = b_low9.ToString(),
                    c_low9 = c_low9.ToString(),

                    a_up10 = a_up10.ToString(),
                    b_up10 = b_up10.ToString(),
                    c_up10 = c_up10.ToString(),
                    a_low10 = a_low10.ToString(),
                    b_low10 = b_low10.ToString(),
                    c_low10 = c_low10.ToString(),
                    add_btn1 = txt_fill1.IsVisible,
                    add_btn2 = fill_text_11.IsVisible,
                    add_btn3 = fill_text_21.IsVisible,
                    add_btn4 = fill_text_31.IsVisible,
                    add_btn5 = fill_text_41.IsVisible,
                    add_btn6 = fill_text_51.IsVisible,
                    add_btn7 = fill_text_61.IsVisible,
                    add_btn8 = fill_text_71.IsVisible,
                    add_btn9 = fill_text_81.IsVisible,
                    add_btn10 = fill_text_91.IsVisible,
                    add_btn11 = fill_text_101.IsVisible,
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

                    CheckBox1data = txt_Check2_text.Text,
                    CheckBox2data = txt_Check2_text.Text,
                    Teams = this.Teams
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
                        if (fnam == "") { fnam = "Draft_DRA.json"; } else { fnam = fnam + "_DRA.json"; }
                    }
                    file = await folder.CreateFileAsync(fnam, CreationCollisionOption.GenerateUniqueName);
                }
                using (var fs = await file.OpenAsync(FileAccess.ReadAndWrite))
                {
                    using (StreamWriter textWriter = new StreamWriter(fs))
                    {
                        textWriter.Write(jsonContents);

                    }

                }
                await DisplayAlert("File Path", file.Path.ToString(), "OK");
                //UserDialogs.Instance.ShowSuccess("Draft saved at:" + file.Path.ToString(), 2000);
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
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

            
                var page = new ContentPage();
                page.Content = layout;
                navigation.PushModalAsync(page);
          
                txtInput.Focus();

                return tcs.Task;
            }

        




        #endregion


        #region OpenDraft
        private async void OnClick_OpenDraft(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DraftsList("_DRA", 1));
        }
       
        #endregion


        public class DraftFields
        {
            public string pick1 { get; set; }
            public string pick2 { get; set; }
            public string pick3 { get; set; }
            public string pick4 { get; set; }

            public string pick2_1 { get; set; }
            public string pick2_2 { get; set; }
            public string pick2_3 { get; set; }
            public string pick2_4 { get; set; }

            public string pick2_5 { get; set; }
            public string pick2_6 { get; set; }
            public string pick2_7 { get; set; }
            public string pick2_8 { get; set; }

            public string pick2_9 { get; set; }
            public string pick2_10 { get; set; }
            public string pick2_11 { get; set; }
            public string pick2_12 { get; set; }

            public string pick2_13 { get; set; }
            public string pick2_14 { get; set; }
            public string pick2_15 { get; set; }
            public string pick2_16 { get; set; }

            public string pick2_17 { get; set; }
            public string pick2_18 { get; set; }
            public string pick2_19 { get; set; }
            public string pick2_20 { get; set; }

            public string pick2_21 { get; set; }
            public string pick2_22 { get; set; }
            public string pick2_23 { get; set; }
            public string pick2_24 { get; set; }

            public string step2_other { get; set; }
            public string pick3_1 { get; set; }

            public string Name1 { get; set; }
            public string ProjectName { get; set; }
            public string SiteName { get; set; }
            public string Date { get; set; }
            public string fillable_txt1 { get; set; }
            public string fillable_txt2 { get; set; }
            public string fillable_txt3 { get; set; }
            public string fillable_txt4 { get; set; }
            public string fillable_txt5 { get; set; }
            public string fillable_txt6 { get; set; }
            public string fillable_txt7 { get; set; }
            public string fillable_txt8 { get; set; }
            public string fillable_txt9 { get; set; }
            public string fillable_txt10 { get; set; }
            public string fillable_txt11 { get; set; }
            public string fillable_txt12 { get; set; }
            public string fillable_txt13 { get; set; }
            public string fillable_txt14 { get; set; }
            public string fillable_txt15 { get; set; }
            public string fillable_txt16 { get; set; }
            public string fillable_txt17 { get; set; }
            public string fillable_txt18 { get; set; }
            public string fillable_txt19 { get; set; }
            public string fillable_txt20 { get; set; }
            public string fillable_txt21 { get; set; }
            public string fillable_txt22 { get; set; }

            public string a_up { get; set; }
            public string b_up { get; set; }
            public string c_up { get; set; }
            public string a_low { get; set; }
            public string b_low { get; set; }
            public string c_low { get; set; }

            public string a_up1 { get; set; }
            public string b_up1 { get; set; }
            public string c_up1 { get; set; }
            public string a_low1 { get; set; }
            public string b_low1 { get; set; }
            public string c_low1 { get; set; }

            public string a_up2 { get; set; }
            public string b_up2 { get; set; }
            public string c_up2 { get; set; }
            public string a_low2 { get; set; }
            public string b_low2 { get; set; }
            public string c_low2 { get; set; }

            public string a_up3 { get; set; }
            public string b_up3 { get; set; }
            public string c_up3 { get; set; }
            public string a_low3 { get; set; }
            public string b_low3 { get; set; }
            public string c_low3 { get; set; }

            public string a_up4 { get; set; }
            public string b_up4 { get; set; }
            public string c_up4 { get; set; }
            public string a_low4 { get; set; }
            public string b_low4 { get; set; }
            public string c_low4 { get; set; }
            public string a_up5 { get; set; }
            public string b_up5 { get; set; }
            public string c_up5 { get; set; }
            public string a_low5 { get; set; }
            public string b_low5 { get; set; }
            public string c_low5 { get; set; }
            public string a_up6 { get; set; }
            public string b_up6 { get; set; }
            public string c_up6 { get; set; }
            public string a_low6 { get; set; }
            public string b_low6 { get; set; }
            public string c_low6 { get; set; }
            public string a_up7 { get; set; }
            public string b_up7 { get; set; }
            public string c_up7 { get; set; }
            public string a_low7 { get; set; }
            public string b_low7 { get; set; }
            public string c_low7 { get; set; }
            public string a_up8 { get; set; }
            public string b_up8 { get; set; }
            public string c_up8 { get; set; }
            public string a_low8 { get; set; }
            public string b_low8 { get; set; }
            public string c_low8 { get; set; }
            public string a_up9 { get; set; }
            public string b_up9 { get; set; }
            public string c_up9 { get; set; }
            public string a_low9 { get; set; }
            public string b_low9 { get; set; }
            public string c_low9 { get; set; }
            public string a_up10 { get; set; }
            public string b_up10 { get; set; }
            public string c_up10 { get; set; }
            public string a_low10 { get; set; }
            public string b_low10 { get; set; }
            public string c_low10 { get; set; }
            public string a_new { get; set; }
            public string b_new { get; set; }
            public string c_new { get; set; }
            public string a_new1 { get; set; }
            public string b_new1 { get; set; }
            public string c_new1 { get; set; }
            public string a_new2 { get; set; }
            public string b_new2 { get; set; }
            public string c_new2 { get; set; }
            public bool add_btn1 { get; set; }
            public bool add_btn2 { get; set; }
            public bool add_btn3 { get; set; }
            public bool add_btn4 { get; set; }
            public bool add_btn5 { get; set; }
            public bool add_btn6 { get; set; }
            public bool add_btn7 { get; set; }
            public bool add_btn8 { get; set; }
            public bool add_btn9 { get; set; }
            public bool add_btn10 { get; set; }
            public bool add_btn11 { get; set; }
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
            public int Name { get; set; }
            public int Win { get; set; }
            public int Loose { get; set; }
            public int Home { get; set; }
            public int Streak { get; set; }
            public string CheckBox1data { get; set; }
            public string CheckBox2data { get; set; }
            public List<Team> Teams { get; set; }

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


        }

        protected void chkbx2_CheckedChanged(object sender, EventArgs e)
        {


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
            try
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
            catch (Exception ex)
            {

            }
        }

        void pick2_1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_fill1.Text = "Slip, Trip and Falls";
                OnClicked_NewLine(null, null);
            }
        }
        /*
        void pick2_2_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_Check_text11.Text = "Work at height";
                OnClicked_NewLine2(null, null);
            }
        }

        void pick2_3_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_Check_text21.Text = "Risk of fall from height";
                OnClicked_NewLine3(null, null);
            }
        }

        void pick2_4_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_Check_text21.Text = "Lifting operations / cranes";
                OnClicked_NewLine4(null, null);
            }
        }

        void pick2_5_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_Check_text31.Text = "Falling / Ejected Objects";
                OnClicked_NewLine5(null, null);
            }
        }

        void pick2_6_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_Check_text41.Text = "Moving vehicles";
                OnClicked_NewLine6(null, null);
            }
        }

        void pick2_7_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_Check_text51.Text = "Overturning / Collapse";
                OnClicked_NewLine7(null, null);
            }
        }

        void pick2_8_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_Check_text61.Text = "Electricity (HV/LV)";
                OnClicked_NewLine8(null, null);
            }
        }

        void pick2_9_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_Check_text71.Text = "Pressurised equipment";
                OnClicked_NewLine9(null, null);
            }
        }

        void pick2_10_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_Check_text81.Text = "Sharp objects";
                OnClicked_NewLine10(null, null);
            }
        }

        void pick2_11_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_Check_text91.Text = "Manual handling / Ergonomics";
                OnClicked_NewLine(null, null);
            }
        }

        void pick2_12_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_Check_text101.Text = "Confined / Restricted space";
                OnClicked_NewLine(null, null);
            }
        }

        void pick2_13_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_Check_text11.Text = "Poor lighting";
                OnClicked_NewLine(null, null);
            }
        }

        void pick2_14_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_Check_text12.Text = "Fire / Explosion risk";
                OnClicked_NewLine(null, null);
            }
        }

        void pick2_15_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_fill1.Text = "Dust, Fumes, Gases , Vapours";
                OnClicked_NewLine(null, null);
            }
        }

        void pick2_16_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_fill1.Text = "Hazardous materials / Waste";
                OnClicked_NewLine(null, null);
            }
        }

        void pick2_17_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_fill1.Text = "Noise";
                OnClicked_NewLine(null, null);
            }
        }

        void pick2_18_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_fill1.Text = "Vibration";
                OnClicked_NewLine(null, null);
            }
        }

        void pick2_19_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_fill1.Text = "High / Low humidity";
                OnClicked_NewLine(null, null);
            }
        }

        void pick2_20_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_fill1.Text = "Hot / Cold temperatures";
                OnClicked_NewLine(null, null);
            }
        }

        void pick2_21_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_fill1.Text = "Lone working";
                OnClicked_NewLine(null, null);
            }
        }

        void pick2_22_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_fill1.Text = "Specialist equipment required";
                OnClicked_NewLine(null, null);
            }
        }

        void pick2_23_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_fill1.Text = "Moving vehicles";
                OnClicked_NewLine(null, null);
            }
        }

        void pick2_24_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            if (picker.SelectedIndex == 1)
            {
                txt_fill1.Text = "Risk to you from others";
                OnClicked_NewLine(null, null);
            }
        }*/
    }

   


}


