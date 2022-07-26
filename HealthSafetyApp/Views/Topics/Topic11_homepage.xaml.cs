using System;
using System.Collections.Generic;
using System.IO;

using Xamarin.Forms;

namespace HealthSafetyApp.Views.Topics
{
    public partial class Topic11_homepage : ContentPage
    {


        public Topic11_homepage()
        {
            InitializeComponent();
            this.Title = "TOOLBOX TALKS";
            string dt = DateTime.Now.ToString();
            
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            
        }
        //public async void OnTap_Nav_List(object sender, EventArgs args)
        //{

        //    //string filename = "1";
        //    //var abc = Nav_List.SelectedItem;
        //    Nav ListSelectedItem = (Nav)Nav_List.SelectedItem;
        //    var gid = ListSelectedItem.Id;
        //    if (gid == 0)
        //        await assets.open("AbrasiveWheelsToolboxTalk.pdf");
        //        //await Navigation.PushAsync(new Topic1(filename));
        //    //await Navigation.PushAsync(new Topic11_1());
        //    if (gid == 1)
        //        await Navigation.PushAsync(new Topic11_2());
        //    if (gid == 2)
        //        await Navigation.PushAsync(new Topic11_3());
        //    if (gid == 3)
        //        await Navigation.PushAsync(new Topic11_4());
        //    if (gid == 4)
        //        await Navigation.PushAsync(new Topic11_5());
        //    if (gid == 5)
        //        await Navigation.PushAsync(new Topic11_6());
        //    if (gid == 6)
        //        await Navigation.PushAsync(new Topic11_7());
        //    if (gid == 7)
        //        await Navigation.PushAsync(new Topic11_8());

        //}

        class Nav
        {
            public string Name
            {
                get;
                set;
            }
            public string Icon
            {
                get;
                set;
            }

            public int Id
            {
                get;
                set;
            }
        }

        private async void OnTap_Nav_List(object sender, EventArgs e)
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

        }
       
    }

}
