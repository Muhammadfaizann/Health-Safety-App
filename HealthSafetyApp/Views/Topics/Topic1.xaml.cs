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
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Drawing;

namespace HealthSafetyApp.Views.Topics
{
    public partial class Topic1 : ContentPage
    {
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

        protected override void OnAppearing()
        {
            try
            {
                base.OnAppearing();
            }
            catch (Exception exception)
            {
                Crashes.TrackError(exception);
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



        
        private  void OnClick_SavePDF(object sender, EventArgs e)
        {
            try
            {
               
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
                StringBuilder sb2 = new StringBuilder();
                sb.Append("<header class='headerdiv'>");



                sb.Append("</div>");
                sb.Append("</header>");
                sb.Append("<main>");

                sb.Append(@"<br/><table width = '100%' ><tbody>
                             
                            <tr bgcolor='gray'>
                            <td align='Center'>
                            <font color='white'><b> Maintenance Dynamic / Point of Work Risk Assessment</b> </font>
                            </td>
                            </tr> 
                        <tr>
<td  bgcolor='silver' align='right'>
<p style='color:#ffffff;font-size:5px;'><i>Created using Dynamic Risk Assessment tool © @The Health And Safety App </i></p>
</td>

</tr>
                        </tbody></table>

                        <center>
                        
                        <table style='border-collapse: collapse;'  Width='98%'><tbody>
                        <tr>          
                        <td colspan='2' align='left'><b> Name:</b></td>                     
                        <td colspan='3' align='left' border-bottom ='1'>" + txt_name.Text + @"</td>                                 
                        <td colspan='2' align='left'><b>Location Name:</b></td>
                        <td colspan='3' style='border-bottom: 1pt solid black;' align='left' >" + txt_projname.Text + @" </td>                                                       
                        </tr>
                                                       
                        <tr>
                        <td colspan='2' align='left'><b> Task Description: </b></td>
                        <td colspan='3' align='left'>" + txt_sitename.Text + @"</td>
                        <td colspan='2' align='left'> <b> Date:</b></td>                                                                                       
                        <td colspan='3' align='left'>" + dat + @" </td>                                                                                             
                        </tr>    
                        
                        <tr>
                        <td colspan='10' align='left'><b> <br/> </b></td>                                                                                
                        </tr>             

                        </tbody>      

                        </table>                                                                                             
                        </center> ");


                sb.Append(@"<table border='0' style='border-collapse:collapse;' width='100%'>
                        <tr> 
                            <th colspan='4' bgcolor='#3399ff'  align = 'center'><b><font color='white'> Step 1. Stop</font></b></th>
                            <th colspan='16' bgcolor='gray' align = 'center'><b> Before starting work think through the task</b></th>                          
                        </tr>  
                        </table> 
                        
                        <table style ='border:solid 1px;' style='width:100%'>      
                        <tr bgcolor='silver'>       
                            <th colspan='17' align='left'><b>Questions </b></th>
                            <th colspan='3' align='right'><b>Yes/No/NA</b></th>                                   
                        </tr>         
                        </table>

                        <table style='border:solid 1px;' width='100%'>
                        
                        <tr>
                            <td colspan='1' align='left'><b> 1. </b></td >
                            <td colspan='16' align='left'><b> Are you fit and suitably competent to carry out the task(s) ?</b></td>
                            <td colspan='3' align='right'><b>" + pick_1.SelectedItem + @"</b></td>
                        </tr>


                        <tr bgcolor='whitesmoke' style='display: block; border-bottom: 1px solid #000;'>
                            <td colspan='1' align='left'><b> 2. </b></td >
                            <td colspan='16' align='left'><b> Do you have the relevant permit and documentation ?</b></td>
                            <td colspan='3' align='right'><b>" + pick_2.SelectedItem + @"</b></td>
                        </tr>
                        
                        <tr>
                            <td colspan='1' align='left'><b> 3. </b></td >
                            <td colspan='16' align='left'><b> Do you have the correct PPE and tools for the task(s) ? </b></td>
                            <td colspan='3' align='right'><b>" + pick_3.SelectedItem + @"</b></td>
                        </tr>

                         <tr bgcolor='whitesmoke' style='display: block; border-bottom: 1px solid #000;'>
                            <td colspan='1' align='left'><b> 4. </b></td >
                            <td colspan='16' align='left'><b> Do you have suitable access into the work area ?</b></td>
                            <td colspan='3' align='right'><b>" + pick_4.SelectedItem + @"</b></td>
                        </tr>

                        <tr style='display: block; border-bottom: 1px solid #000;'>
                           
                            <td colspan='20' align='left'><i> ! If you have answered no to any of the above , please inform your team leader. </i></td>
                            
                        </tr>
                        
                         <tr style='display: block; border-bottom: 1px solid #000;'>
                           
                            <td colspan='20' align='left'><br/></td>
                            
                        </tr>

                        </table >");

                sb.Append(@"<table border='0' style='border-collapse:collapse;' border=0 width='100%'>
                        <tr> 
                            <th colspan='4' bgcolor='#3399ff'  align='center'><b><font color='white'> Step 2. Think </font></b></th>
                            <th colspan='16' bgcolor='gray' align = 'center'><b> Spot the Hazards </b></th>                          
                        </tr>  
                        </table> 
                        
                        <table style ='border:solid 1px;' style='width:100%'>      
                        <tr bgcolor='silver'>       
                            <th colspan='17' align='left'><b>Hazard </b></th>
                            <th colspan='3' align='right'><b>Yes/No</b></th>                                   
                        </tr>         
                        </table>

                        <table style='border:solid 1px;' width='100%'>
                        
                        <tr>
                            <td colspan='1' align='left'><b> 1. </b></td >
                            <td colspan='16' align='left'><b> Slip, Trip and Fall</b></td>
                            <td colspan='3' align='right'><b>" + pick2_1.SelectedItem + @"</b></td>
                        </tr>


                        <tr bgcolor='whitesmoke' style='display: block; border-bottom: 1px solid #000;'>
                            <td colspan='1' align='left'><b> 2. </b></td >
                            <td colspan='16' align='left'><b> Work at height </b></td>
                            <td colspan='3' align='right'><b>" + pick2_2.SelectedItem + @"</b></td>
                        </tr>
                        
                        <tr>
                            <td colspan='1' align='left'><b> 3. </b></td >
                            <td colspan='16' align='left'><b> Risk of fall from height</b></td>
                            <td colspan='3' align='right'><b>" + pick2_3.SelectedItem + @" </b></td>
                        </tr>

                         <tr bgcolor='whitesmoke' style='display: block; border-bottom: 1px solid #000;'>
                            <td colspan='1' align='left'><b> 4. </b></td >
                            <td colspan='16' align='left'><b> Lifting operation / Cranes</b></td>
                            <td colspan='3' align='right'><b>" + pick2_4.SelectedItem + @"</b></td>
                        </tr>

                        <tr>
                            <td colspan='1' align='left'><b> 5. </b></td >
                            <td colspan='16' align='left'><b> Falling / Ejected Objects</b></td>
                            <td colspan='3' align='right'><b>" + pick2_5.SelectedItem + @"</b></td>
                        </tr>

                         <tr bgcolor='whitesmoke' style='display: block; border-bottom: 1px solid #000;'>
                            <td colspan='1' align='left'><b> 6. </b></td >
                            <td colspan='16' align='left'><b> Moving Vehicles</b></td>
                            <td colspan='3' align='right'><b>" + pick2_6.SelectedItem + @"</b></td>
                        </tr>

                        <tr>
                            <td colspan='1' align='left'><b> 7. </b></td >
                            <td colspan='16' align='left'><b>Overturning / Collapse</b></td>
                            <td colspan='3' align='right'><b>" + pick2_7.SelectedItem + @"</b></td>
                        </tr>

                         <tr bgcolor='whitesmoke' style='display: block; border-bottom: 1px solid #000;'>
                            <td colspan='1' align='left'><b> 8. </b></td >
                            <td colspan='16' align='left'><b>Electricity (HV/LV)</b></td>
                            <td colspan='3' align='right'><b>" + pick2_8.SelectedItem + @"</b></td>
                        </tr>

                        <tr>
                            <td colspan='1' align='left'><b> 9. </b></td >
                            <td colspan='16' align='left'><b>Pressurised equipment</b></td>
                            <td colspan='3' align='right'><b>" + pick2_9.SelectedItem + @"</b></td>
                        </tr>


                        <tr bgcolor='whitesmoke' style='display: block; border-bottom: 1px solid #000;'>
                            <td colspan='1' align='left'><b> 10. </b></td >
                            <td colspan='16' align='left'><b> Sharp Objects </b></td>
                            <td colspan='3' align='right'><b>" + pick2_10.SelectedItem + @"</b></td>
                        </tr>
                        
                        <tr>
                            <td colspan='1' align='left'><b> 11. </b></td >
                            <td colspan='16' align='left'><b>Manual Handling / Ergonomics</b></td>
                            <td colspan='3' align='right'><b>" + pick2_11.SelectedItem + @"</b></td>
                        </tr>

                         <tr bgcolor='whitesmoke' style='display: block; border-bottom: 1px solid #000;'>
                            <td colspan='1' align='left'><b> 12. </b></td >
                            <td colspan='16' align='left'><b>Confined / Restricted space</b></td>
                            <td colspan='3' align='right'><b>" + pick2_12.SelectedItem + @"</b></td>
                        </tr>

                        <tr>
                            <td colspan='1' align='left'><b> 13. </b></td >
                            <td colspan='16' align='left'><b> Poor lighting</b></td>
                            <td colspan='3' align='right'><b>" + pick2_13.SelectedItem + @"</b></td>
                        </tr>

                         <tr bgcolor='whitesmoke' style='display: block; border-bottom: 1px solid #000;'>
                            <td colspan='1' align='left'><b> 14. </b></td >
                            <td colspan='16' align='left'><b> Fire / Explosion Risk</b></td>
                            <td colspan='3' align='right'><b>" + pick2_14.SelectedItem + @"</b></td>
                        </tr>

                        <tr>
                            <td colspan='1' align='left'><b> 15. </b></td >
                            <td colspan='16' align='left'><b>Dust, Fumes, Gases, Vapours</b></td>
                            <td colspan='3' align='right'><b>" + pick2_15.SelectedItem + @"</b></td>
                        </tr>

                         <tr bgcolor='whitesmoke' style='display: block; border-bottom: 1px solid #000;'>
                            <td colspan='1' align='left'><b> 16. </b></td >
                            <td colspan='16' align='left'><b>Hazardous material</b></td>
                            <td colspan='3' align='right'><b>" + pick2_16.SelectedItem + @"</b></td>
                        </tr>

                         <tr>
                            <td colspan='1' align='left'><b> 17. </b></td >
                            <td colspan='16' align='left'><b>Noise</b></td>
                            <td colspan='3' align='right'><b>" + pick2_17.SelectedItem + @"</b></td>
                        </tr>


                        <tr bgcolor='whitesmoke' style='display: block; border-bottom: 1px solid #000;'>
                            <td colspan='1' align='left'><b> 18. </b></td >
                            <td colspan='16' align='left'><b> Vibration </b></td>
                            <td colspan='3' align='right'><b>" + pick2_18.SelectedItem + @"</b></td>
                        </tr>
                        
                        <tr>
                            <td colspan='1' align='left'><b> 19. </b></td >
                            <td colspan='16' align='left'><b>High/Low humidity </b></td>
                            <td colspan='3' align='right'><b>" + pick2_19.SelectedItem + @"</b></td>
                        </tr>

                         <tr bgcolor='whitesmoke' style='display: block; border-bottom: 1px solid #000;'>
                            <td colspan='1' align='left'><b> 20. </b></td >
                            <td colspan='16' align='left'><b>Hot/Cold temperatures</b></td>
                            <td colspan='3' align='right'><b>" + pick2_20.SelectedItem + @"</b></td>
                        </tr>

                        <tr>
                            <td colspan='1' align='left'><b> 21. </b></td >
                            <td colspan='16' align='left'><b>Lone working</b></td>
                            <td colspan='3' align='right'><b>" + pick2_21.SelectedItem + @"</b></td>
                        </tr>

                         <tr bgcolor='whitesmoke' style='display: block; border-bottom: 1px solid #000;'>
                            <td colspan='1' align='left'><b> 22. </b></td >
                            <td colspan='16' align='left'><b>Specialist equipment required </b></td>
                            <td colspan='3' align='right'><b>" + pick2_22.SelectedItem + @"</b></td>
                        </tr>

                       

                        <tr  style='display: block; border-bottom: 1px solid #000;'>
                            <td colspan='1' align='left'><b> 24. </b></td >
                            <td colspan='16' align='left'><b>Risk to you from others </b></td>
                            <td colspan='3' align='right'><b>" + pick2_24.SelectedItem + @"</b></td>
                        </tr>

                        <tr>
                            <td colspan='20'>
                            <table width='100%'>
                            <tr>
                            <td colspan='1' align='left'><b> 25. </b></td >
                            <td colspan='3' align='left'><b>Others:</b></td>
                            <td colspan='10' align='right'><b>" + step2_other.Text + @"</b></td>
                            </tr>
                            </table>
                            </td>
                        </tr>

                        <tr style='display: block; border-bottom: 1px solid #000;'>
                           
                            <td colspan='20' align='left'><i> ! Where hazard is identified it should be covered by a generic or specific Risk Assessment </i></td>
                            
                        </tr>
                        
                        <tr style='display: block; border-bottom: 1px solid #000;'>
                           
                            <td colspan='17' align='left'><h4>Are you and your colleagues safe?</h4></td>
                            <td colspan='3' align='right'><b>" + pick3_1.SelectedItem + @"</b></td>
                        </tr>

                         <tr style='display: block; border-bottom: 1px solid #000;'>
                           
                            <td colspan='20' align='left'><br/></td>
                            
                        </tr>

                        </table>");

                sb.Append(@"<table border='1' style='border-collapse:collapse;' border=1 width='100%'>
                        <tr> 
                            <th colspan='4' bgcolor='#3399ff'  align = 'center'><b><font color='white'> Step 3. Action </font></b></th>
                            <th colspan='16' bgcolor='gray' align = 'center'><b> Assess the risk of any significant hazards identified earlier  </b></th>                          
                        </tr>  
                      <font size='2'>
                        <tr bgcolork='silver'>       
                            <th colspan='14' align='left'><b>Hazard identified/ Control Measures </b></th>
                            <th colspan='2' align='center'><b><font size='12px'> Likelihood</font> </b></th>
                            <th colspan='2' align='center'><b><font size='12px'> Severity </font></b></th>   
                            <th colspan='2' align='center'><b> <font size='12px'>Residual Risk </font></b></th> 
                        </tr>         
                    </font>
                        <tr>
                        <td>
                            <table border='0'>
                            <tr>
                                <td valign='center' align='left'><b> 1. </b></td >
                             </tr>                          
                           </table>
                        </td>
                        <td colspan='19'>
                            <table border='0'>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_fill1.Text + @" </b></td>
                                    <td colspan='2' align='center'>" + pick_a_up.SelectedItem + @"</td>
                                    <td colspan='2' align='center'>" + pick_b_up.SelectedItem + @"</td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_up_color + ";'>" + txt_resultup.Text + @"</td>
                                </tr>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_fill2.Text + @" </b></td>
                                    <td colspan='2' align='center'>" + pick_a_low.SelectedItem + @" </td>
                                    <td colspan='2' align='center'>" + pick_b_low.SelectedItem + @" </td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_low_color + ";'> " + txt_resultlow.Text + @" </td>
                                </tr>
                            </table>
                        </td>
                        </tr>");

                if (fill_text_11.IsVisible == true)
                {
                    sb.Append(@"<tr bgcolor='whitesmoke'>
                        <td>
                            <table border='0'>
                            <tr>
                                <td valign='center' align='left'><b> 2. </b></td >
                             </tr>                          
                           </table>
                        </td>
                        <td colspan='19'>
                            <table border='0'>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_Check_text11.Text + @" </b></td>
                                    <td colspan='2' align='center'>" + pick_a_up1.SelectedItem + @"</td>
                                    <td colspan='2' align='center'>" + pick_b_up1.SelectedItem + @"</td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_up1_color + ";'>" + txt_resultup1.Text + @"</td>
                                </tr>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_Check_text12.Text + @"  </b></td>
                                    <td colspan='2' align='center'>" + pick_a_low1.SelectedItem + @" </td>
                                    <td colspan='2' align='center'>" + pick_b_low1.SelectedItem + @" </td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_low1_color + ";'>" + txt_resultlow1.Text + @"</td>
                                </tr>
                            </table>
                        </td>
                        </tr>");

                }
                if (fill_text_21.IsVisible == true)
                {
                    sb.Append(@"<tr>
                        <td>
                            <table border='0'>
                            <tr>
                                <td valign='center' align='left'><b> 3. </b></td >
                             </tr>                          
                           </table>
                        </td>
                        <td colspan='19'>
                            <table border='0'>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_Check_text21.Text + @" </b></td>
                                    <td colspan='2' align='center'>" + pick_a_up2.SelectedItem + @"</td>
                                    <td colspan='2' align='center'>" + pick_b_up2.SelectedItem + @"</td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_up2_color + ";'>" + txt_resultup2.Text + @"</td>
                                </tr>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_Check_text22.Text + @" </b></td>
                                    <td colspan='2' align='center'> " + pick_a_low2.SelectedItem + @" </td>
                                    <td colspan='2' align='center'> " + pick_b_low2.SelectedItem + @" </td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_low2_color + ";'>" + txt_resultlow2.Text + @"</td>
                                </tr>
                            </table>
                        </td>
                        </tr>");

                }
                if (fill_text_31.IsVisible == true)
                {
                    sb.Append(@"<tr bgcolor='whitesmoke'>
                        <td>
                            <table border='0'>
                            <tr>
                                <td valign='center' align='left'><b> 4. </b></td >
                             </tr>                          
                           </table>
                        </td>
                        <td colspan='19'>
                            <table border='0'>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_Check_text31.Text + @" </b></td>
                                    <td colspan='2' align='center'>" + pick_a_up3.SelectedItem + @"</td>
                                    <td colspan='2' align='center'>" + pick_b_up3.SelectedItem + @"</td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_up3_color + ";'>" + txt_resultup3.Text + @"</td>
                                </tr>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_Check_text32.Text + @" </b></td>
                                    <td colspan='2' align='center'> " + pick_a_low3.SelectedItem + @" </td>
                                    <td colspan='2' align='center'> " + pick_b_low3.SelectedItem + @" </td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_low3_color + ";'>" + txt_resultlow3.Text + @"</td>
                                </tr>
                            </table>
                        </td>
                        </tr>");

                }
                if (fill_text_41.IsVisible == true)
                {
                    sb.Append(@"<tr>
                        <td>
                            <table border='0'>
                            <tr>
                                <td valign='center' align='left'><b> 5. </b></td >
                             </tr>                          
                           </table>
                        </td>
                        <td colspan='19'>
                            <table border='0'>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_Check_text41.Text + @" </b></td>
                                    <td colspan='2' align='center'>" + pick_a_up4.SelectedItem + @"</td>
                                    <td colspan='2' align='center'>" + pick_b_up4.SelectedItem + @"</td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_up4_color + ";'>" + txt_resultup4.Text + @"</td>
                                </tr>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_Check_text42.Text + @" </b></td>
                                    <td colspan='2' align='center'> " + pick_a_low4.SelectedItem + @" </td>
                                    <td colspan='2' align='center'> " + pick_b_low4.SelectedItem + @" </td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_low4_color + ";'>" + txt_resultlow4.Text + @"</td>
                                </tr>
                            </table>
                        </td>
                        </tr>");

                }
                if (fill_text_51.IsVisible == true)
                {
                    sb.Append(@"<tr bgcolor='whitesmoke'>
                        <td>
                            <table border='0'>
                            <tr>
                                <td valign='center' align='left'><b> 6. </b></td >
                             </tr>                          
                           </table>
                        </td>
                        <td colspan='19'>
                            <table border='0'>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_Check_text51.Text + @" </b></td>
                                    <td colspan='2' align='center'>" + pick_a_up5.SelectedItem + @"</td>
                                    <td colspan='2' align='center'>" + pick_b_up5.SelectedItem + @"</td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_up5_color + ";'>" + txt_resultup5.Text + @"</td>
                                </tr>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_Check_text52.Text + @" </b></td>
                                    <td colspan='2' align='center'> " + pick_a_low5.SelectedItem + @" </td>
                                    <td colspan='2' align='center'> " + pick_b_low5.SelectedItem + @" </td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_low5_color + ";'>" + txt_resultlow5.Text + @"</td>
                                </tr>
                            </table>
                        </td>
                        </tr>");

                }
                if (fill_text_61.IsVisible == true)
                {
                    sb.Append(@"<tr>
                        <td>
                            <table border='0'>
                            <tr>
                                <td valign='center' align='left'><b> 7. </b></td >
                             </tr>                          
                           </table>
                        </td>
                        <td colspan='19'>
                            <table border='0'>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_Check_text61.Text + @" </b></td>
                                    <td colspan='2' align='center'>" + pick_a_up6.SelectedItem + @"</td>
                                    <td colspan='2' align='center'>" + pick_b_up6.SelectedItem + @"</td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_up6_color + ";'>" + txt_resultup6.Text + @"</td>
                                </tr>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_Check_text62.Text + @" </b></td>
                                    <td colspan='2' align='center'> " + pick_a_low6.SelectedItem + @" </td>
                                    <td colspan='2' align='center'> " + pick_b_low6.SelectedItem + @" </td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_low6_color + ";'>" + txt_resultlow6.Text + @"</td>
                                </tr>
                            </table>
                        </td>
                        </tr>");

                }
                if (fill_text_71.IsVisible == true)
                {
                    sb.Append(@"<tr bgcolor='whitesmoke'>
                        <td>
                            <table border='0'>
                            <tr>
                                <td valign='center' align='left'><b> 8. </b></td >
                             </tr>                          
                           </table>
                        </td>
                        <td colspan='19'>
                            <table border='0'>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_Check_text71.Text + @" </b></td>
                                    <td colspan='2' align='center'>" + pick_a_up7.SelectedItem + @"</td>
                                    <td colspan='2' align='center'>" + pick_b_up7.SelectedItem + @"</td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_up7_color + ";'>" + txt_resultup7.Text + @"</td>
                                </tr>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_Check_text72.Text + @" </b></td>
                                    <td colspan='2' align='center'> " + pick_a_low7.SelectedItem + @" </td>
                                    <td colspan='2' align='center'> " + pick_b_low7.SelectedItem + @" </td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_low7_color + ";'>" + txt_resultlow7.Text + @"</td>
                                </tr>
                            </table>
                        </td>
                        </tr>");

                }
                if (fill_text_81.IsVisible == true)
                {
                    sb.Append(@"<tr>
                        <td>
                            <table border='0'>
                            <tr>
                                <td valign='center' align='left'><b> 9. </b></td >
                             </tr>                          
                           </table>
                        </td>
                        <td colspan='19'>
                            <table border='0'>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_Check_text81.Text + @" </b></td>
                                    <td colspan='2' align='center'>" + pick_a_up8.SelectedItem + @"</td>
                                    <td colspan='2' align='center'>" + pick_b_up8.SelectedItem + @"</td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_up8_color + ";'>" + txt_resultup8.Text + @"</td>
                                </tr>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_Check_text82.Text + @" </b></td>
                                    <td colspan='2' align='center'> " + pick_a_low8.SelectedItem + @" </td>
                                    <td colspan='2' align='center'> " + pick_b_low8.SelectedItem + @" </td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_low8_color + ";'>" + txt_resultlow8.Text + @"</td>
                                </tr>
                            </table>
                        </td>
                        </tr>");

                }
                if (fill_text_91.IsVisible == true)
                {
                    sb.Append(@"<tr bgcolor='whitesmoke'>
                        <td>
                            <table border='0'>
                            <tr>
                                <td valign='center' align='left'><b> 10. </b></td >
                             </tr>                          
                           </table>
                        </td>
                        <td colspan='19'>
                            <table border='0'>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_Check_text91.Text + @" </b></td>
                                    <td colspan='2' align='center'>" + pick_a_up9.SelectedItem + @"</td>
                                    <td colspan='2' align='center'>" + pick_b_up9.SelectedItem + @"</td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_up9_color + ";'>" + txt_resultup9.Text + @"</td>
                                </tr>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_Check_text92.Text + @" </b></td>
                                    <td colspan='2' align='center'> " + pick_a_low9.SelectedItem + @" </td>
                                    <td colspan='2' align='center'> " + pick_b_low9.SelectedItem + @" </td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_low9_color + ";'>" + txt_resultlow9.Text + @"</td>
                                </tr>
                            </table>
                        </td>
                        </tr>");

                }
                if (fill_text_101.IsVisible == true)
                {
                    sb.Append(@"<tr>
                        <td>
                            <table border='0'>
                            <tr>
                                <td valign='center' align='left'><b> 11. </b></td >
                             </tr>                          
                           </table>
                        </td>
                        <td colspan='19'>
                            <table border='0'>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_Check_text101.Text + @" </b></td>
                                    <td colspan='2' align='center'>" + pick_a_up10.SelectedItem + @"</td>
                                    <td colspan='2' align='center'>" + pick_b_up10.SelectedItem + @"</td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_up10_color + ";'>" + txt_resultup10.Text + @"</td>
                                </tr>
                                <tr>
                                    <td colspan='13' align='left'><b> " + txt_Check_text102.Text + @" </b></td>
                                    <td colspan='2' align='center'> " + pick_a_low10.SelectedItem + @" </td>
                                    <td colspan='2' align='center'> " + pick_b_low10.SelectedItem + @" </td>
                                    <td colspan='2' align='center' style='font-size:14px;color:" + c_low10_color + ";'>" + txt_resultlow10.Text + @"</td>
                                </tr>
                            </table>
                        </td>
                        </tr>");

                }
                sb.Append("</table>");
                //sb.Append("<table width='100%' style='width:100%'>");
                //sb.Append("<tr>");
                //sb.Append("<td colspan='2' width='80%' style='width:80%'>");
                //sb.Append("<table width='100%'>");
                //sb.Append("<tr>");
                //sb.Append("<td style='color:#0086b7;font-size:16px;'><b>Fillable Text box</b></td>");
                //sb.Append("</tr>");
                //sb.Append("<tr>");
                //sb.Append("<td style='text-align:justify;font-size:14px;'><u>" + txt_Check_text11.Text + "</u></td>");
                //sb.Append("</tr>");
                //sb.Append("</table>");
                //sb.Append("</td>");
                ////sb.Append("<td></td>");
                //sb.Append("<td width='20%' style='width:20%' valign='top'>");
                //sb.Append("<table width='100%'>");
                //sb.Append("<tr>");
                //sb.Append("<td style='color:#0086b7;font-size:16px;'><b>A</b></td>");
                //sb.Append("<td style='color:#0086b7;font-size:16px;'><b>B</b></td>");
                //sb.Append("<td style='color:#0086b7;font-size:16px;'><b>C</b></td>");
                //sb.Append("</tr>");
                //sb.Append("<tr>");
                //sb.Append("<td style='font-size:14px;'>" + a_new + "</td>");
                //sb.Append("<td style='font-size:14px;'>" + b_new + "</td>");
                //sb.Append("<td style='font-size:14px;color:" + c_new_color + ";'>" + c_new + "</td>");
                //sb.Append("</tr>");
                //sb.Append("</table>");
                //sb.Append("</td>");
                //sb.Append("</tr>");
                //sb.Append("</table>");
                //sb.Append("<br/><br/>");

                //sb.Append("<table width='100%' style='width:100%'>");
                //sb.Append("<tr>");
                //sb.Append("<td colspan='2' width='80%' style='width:80%'>");
                //sb.Append("<table width='100%'>");
                //sb.Append("<tr>");
                //sb.Append("<td style='color:#0086b7;font-size:16px;'><b>Fillable Text box</b></td>");
                //sb.Append("</tr>");
                //sb.Append("<tr>");
                //sb.Append("<td style='text-align:justify;font-size:14px;'><u>" + txt_Check_text11.Text + "</u></td>");
                //sb.Append("</tr>");
                //sb.Append("</table>");
                //sb.Append("</td>");
                ////sb.Append("<td></td>");
                //sb.Append("<td width='20%' style='width:20%' valign='top'>");
                //sb.Append("<table width='100%'>");
                //sb.Append("<tr>");
                //sb.Append("<td style='color:#0086b7;font-size:16px;'><b>A</b></td>");
                //sb.Append("<td style='color:#0086b7;font-size:16px;'><b>B</b></td>");
                //sb.Append("<td style='color:#0086b7;font-size:16px;'><b>C</b></td>");
                //sb.Append("</tr>");
                //sb.Append("<tr>");
                //sb.Append("<td style='font-size:14px;'>" + a_new1 + "</td>");
                //sb.Append("<td style='font-size:14px;'>" + b_new1 + "</td>");
                //sb.Append("<td style='font-size:14px;color:" + c_new1_color + ";'>" + c_new1 + "</td>");
                //sb.Append("</tr>");
                //sb.Append("</table>");
                //sb.Append("</td>");
                //sb.Append("</tr>");
                //sb.Append("</table>");


                sb.Append("<br/><br/>");
                sb.Append("</main>");

                sb2.Append("<main>");
                sb2.Append("<table border='1' width='95%'  align='center' style='width=70%; border: solid gray 1px; border-collapse: collapse;' >");
                sb2.Append("<thead >");
                sb2.Append("<tr bgcolor='gray'>");
                sb2.Append("<th valign='center' style = 'padding:20px; border: solid black 1px;' colspan='10'><font color='white'><b>Likelihood</b></font></th >");
                sb2.Append("</tr >");
                sb2.Append("</thead >");
                sb2.Append("<thead >");
                sb2.Append("<tr bgcolor='silver' >");
                sb2.Append("<th colspan='4' style = 'padding:20px; border: solid black 1px;'><b></b></th >");
                sb2.Append("<th  style = 'padding:20px; border: solid black 1px;'> Zero to very low </th >");
                sb2.Append("<th  style = 'padding:20px; border: solid black 1px;'> Very Unlikely </th >");
                sb2.Append("<th  style = 'padding:20px; border: solid black 1px;'> Unlikely </th >");
                sb2.Append("<th  style = 'padding:20px; border: solid black 1px;'> Likely </th >");
                sb2.Append("<th  style = 'padding:20px; border: solid black 1px;'> Very Likely </th >");
                sb2.Append("<th  style = 'padding:20px; border: solid black 1px;'> Almost Certain </th >");
                sb2.Append("</tr >");
                sb2.Append("<tr bgcolor='whitesmoke'>");
                sb2.Append("<th colspan='4' style = 'padding:20px; border: solid black 1px;'><b>SEVERITY</b></th >");
                sb2.Append("<th  style = 'padding:20px; border: solid black 1px;'>0</th >");
                sb2.Append("<th  style = 'padding:20px; border: solid black 1px;'>1</th >");
                sb2.Append("<th  style = 'padding:20px; border: solid black 1px;'>2</th >");
                sb2.Append("<th  style = 'padding:20px; border: solid black 1px;'>3</th >");
                sb2.Append("<th  style = 'padding:20px; border: solid black 1px;'>4</th >");
                sb2.Append("<th  style = 'padding:20px; border: solid black 1px;'>5</th >");
                sb2.Append("</tr >");
                sb2.Append("</thead >");
                sb2.Append("<tbody >");
                sb2.Append("<tr >");
                string colWin = "";
                string colLoose = "";
                string colHome = "";
                string colPercentage = "";
                string colName = "";
                string colStreak = "";
                var abc = DummyDataProvider.GetTeams();
                foreach (var def in abc)
                {

                    if (def.Name < 3)
                        colName = "#01DF01";
                    if (def.Win < 3)
                        colWin = "#01DF01";
                    if (def.Loose < 3)
                        colLoose = "#01DF01";
                    if (def.Home < 3)
                        colHome = "#01DF01";
                    if (def.Percentage < 3)
                        colPercentage = "#01DF01";
                    if (def.Streak < 3)
                        colStreak = "#01DF01";
                    if (def.Name > 3 && def.Name <= 6)
                        colName = "#ffb240";
                    if (def.Win > 3 && def.Win <= 6)
                        colWin = "#ffb240";
                    if (def.Loose > 3 && def.Loose <= 6)
                        colLoose = "#ffb240";
                    if (def.Home > 3 && def.Home <= 6)
                        colHome = "#ffb240";
                    if (def.Percentage > 3 && def.Percentage <= 6)
                        colPercentage = "#ffb240";
                    if (def.Streak > 3 && def.Streak <= 6)
                        colStreak = "#ffb240";
                    if (def.Name > 6)
                        colName = "#f22626";
                    if (def.Win > 6)
                        colWin = "#f22626";
                    if (def.Loose > 6)
                        colLoose = "#f22626";
                    if (def.Home > 6)
                        colHome = "#f22626";
                    if (def.Percentage > 6)
                        colPercentage = "#f22626";
                    if (def.Streak > 6)
                        colStreak = "#f22626";
                    sb2.Append("<td colspan='3'  align = 'left' style = 'padding:20px;border: solid black 1px;' >" + def.Logo + "</td > ");
                    sb2.Append("<td  align = 'center' style = 'padding:20px;border: solid black 1px;' >" + def.SNo + "</td > ");
                    sb2.Append("<td bgcolor=" + colName + " align = 'center' style = 'padding:20px;border: solid black 1px;' >" + def.Name + " </td > ");
                    sb2.Append("<td bgcolor=" + colWin + " align = 'center' style = 'padding:20px;border: solid black 1px;' >" + def.Win + " </td > ");
                    sb2.Append("<td bgcolor=" + colLoose + " align = 'center' style = 'padding:20px;border: solid black 1px;' >" + def.Loose + " </td >");
                    sb2.Append("<td bgcolor=" + colHome + " align = 'center' style = 'padding:20px;border: solid black 1px;' >" + def.Home + " </td >");
                    sb2.Append("<td bgcolor=" + colPercentage + " align = 'center' style = 'padding:20px;border: solid black 1px;' >" + def.Percentage + " </td >");
                    sb2.Append("<td bgcolor=" + colStreak + " align = 'center' style = 'padding:20px;border: solid black 1px;' >" + def.Streak + " </td >");
                }
                sb2.Append("</tr >");
                sb2.Append("</tbody >");
                sb2.Append("</table >");

                sb2.Append(@"<br><table style='width: 100%;' border='1'>
                    <tbody>
                    <tr>
                    <td colspan='3' rowspan='1'> Signature(s) </td>
                    <td colspan='7' rowspan='2'>  </td>
                    <td colspan='2' rowspan='1'> Date: </td>
                    <td colspan='3' rowspan='2'> </td>
                    <td colspan='2' rowspan='1'> Review Date: </td>
                    <td colspan='3' rowspan='2'> </td>
                    </tr>
                    </tbody>
                    </table>");
                sb2.Append("</main>");



                  
                        

                        
                     
                
                
            }
            catch(Exception ex)
            {

            }

    }







        #region SaveDraft
        private void OnClick_SaveDraft(object sender, EventArgs e)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (FormatException) { }
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

        //txt_name.Text = txt_projname.Text = txt_sitename.Text = txt_fill1.Text = txt_fill2.Text = txt_Check_text11.Text = txt_Check_text12.Text = txt_Check_text21.Text = txt_Check_text22.Text = txt_Check_text31.Text = "";


        //pick_1.SelectedIndex = pick_2.SelectedIndex = pick_3.SelectedIndex = pick_4.SelectedIndex = 0;


        //pick2_1.SelectedIndex = pick2_2.SelectedIndex = pick2_3.SelectedIndex = pick2_4.SelectedIndex = pick2_5.SelectedIndex = pick2_6.SelectedIndex = pick2_7.SelectedIndex = pick2_8.SelectedIndex = 0;
        //pick2_11.SelectedIndex = pick2_9.SelectedIndex = pick2_10.SelectedIndex = pick2_12.SelectedIndex = pick2_13.SelectedIndex = pick2_14.SelectedIndex = pick2_15.SelectedIndex = pick2_16.SelectedIndex = 0;
        //pick2_17.SelectedIndex = pick2_18.SelectedIndex = pick2_19.SelectedIndex = pick2_20.SelectedIndex = pick2_21.SelectedIndex = pick2_22.SelectedIndex = pick2_23.SelectedIndex = pick2_24.SelectedIndex = 0;

        //step2_other.Text = "";
        //pick3_1.SelectedIndex = 0;



        //pick_a_up.SelectedIndex = 0;
        //pick_b_up.SelectedIndex = 0;
        //pick_a_low.SelectedIndex = 0;
        //pick_b_low.SelectedIndex = 0;
        //pick_a_up1.SelectedIndex = 0;
        //pick_b_up1.SelectedIndex = 0;
        //pick_a_up2.SelectedIndex = 0;
        //pick_b_up2.SelectedIndex = 0;
        //pick_a_up3.SelectedIndex = 0;
        //pick_b_up3.SelectedIndex = 0;




        #endregion


        #region OpenDraft
        private async void OnClick_OpenDraft(object sender, EventArgs e)
        {

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


