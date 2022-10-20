using Acr.UserDialogs;
using HealthSafetyApp.Views.Topics;
using PCLStorage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HealthSafetyApp.Views
{
    public partial class DraftsList : ContentPage
    {
        private string topic;
        public DraftsList(string topic_nam, int i)
        {
            InitializeComponent();
            if (i == 1)
            {
                topic = topic_nam;
                this.Title = "Drafts List";
                lbl_alert.IsVisible = false;
                OpenDraft();
            }
            else if (i == 2)
            {
                topic = topic_nam;
                this.Title = "PDFs List";
                lbl_alert.IsVisible = false;
                OpenPDFS();
            }
            else if (i == 3)
            {
                topic = topic_nam;
                this.Title = "Drafts List";
                lbl_alert.IsVisible = false;
                OpenDraftAll();
            }
        }

        private async Task OpenDraft()
        {
            List<fileenam> lstfile = new List<fileenam>();
            IFolder rootFolder = null;
            if (Device.RuntimePlatform == Device.iOS)
            {
                rootFolder = await FileSystem.Current.GetFolderFromPathAsync(PCLStorage.FileSystem.Current.LocalStorage.Path + "/HandSAppDrafts/");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                rootFolder = await FileSystem.Current.GetFolderFromPathAsync("/storage/emulated/0/HandSAppDrafts/");
            }
            var file1 = await rootFolder.GetFilesAsync();
            foreach (var abc in file1)
            {

                string def = abc.Name.ToString();

                bool sdef = def.Contains(".json");
                if (sdef == true)
                {
                    if (def.Contains("_DRA") && topic == "_DRA")
                    {
                        int hj = def.IndexOf('.');
                        if (hj >= 0)
                            def = def.Substring(0, hj);
                        lstfile.Add(new fileenam { Name = def });
                    }
                    if (def.Contains("_CA") && topic == "_CA")
                    {
                        int hj = def.IndexOf('.');
                        if (hj >= 0)
                            def = def.Substring(0, hj);
                        lstfile.Add(new fileenam { Name = def });
                    }
                    if (def.Contains("_WSA") && topic == "_WSA")
                    {
                        int hj = def.IndexOf('.');
                        if (hj >= 0)
                            def = def.Substring(0, hj);
                        lstfile.Add(new fileenam { Name = def });
                    }
                    if (def.Contains("_MHA") && topic == "_MHA")
                    {
                        int hj = def.IndexOf('.');
                        if (hj >= 0)
                            def = def.Substring(0, hj);
                        lstfile.Add(new fileenam { Name = def });
                    }
                    if (def.Contains("_ARF") && topic == "_ARF")
                    {
                        int hj = def.IndexOf('.');
                        if (hj >= 0)
                            def = def.Substring(0, hj);
                        lstfile.Add(new fileenam { Name = def });
                    }
                    if (def.Contains("_SSW") && topic == "_SSW")
                    {
                        int hj = def.IndexOf('.');
                        if (hj >= 0)
                            def = def.Substring(0, hj);
                        lstfile.Add(new fileenam { Name = def });
                    }
                    if (def.Contains("_ASI") && topic == "_ASI")
                    {
                        int hj = def.IndexOf('.');
                        if (hj >= 0)
                            def = def.Substring(0, hj);
                        lstfile.Add(new fileenam { Name = def });
                    }
                    if (def.Contains("topic8") && topic == "topic8")
                    {
                        int hj = def.IndexOf('.');
                        if (hj >= 0)
                            def = def.Substring(0, hj);
                        lstfile.Add(new fileenam { Name = def });
                    }
                    if (def.Contains("topic9") && topic == "topic9")
                    {
                        int hj = def.IndexOf('.');
                        if (hj >= 0)
                            def = def.Substring(0, hj);
                        lstfile.Add(new fileenam { Name = def });
                    }
                    if (def.Contains("topic10_1") && topic == "topic10_1")
                    {
                        int hj = def.IndexOf('.');
                        if (hj >= 0)
                            def = def.Substring(0, hj);
                        lstfile.Add(new fileenam { Name = def });
                    }
                    if (def.Contains("topic10_2") && topic == "topic10_2")
                    {
                        int hj = def.IndexOf('.');
                        if (hj >= 0)
                            def = def.Substring(0, hj);
                        lstfile.Add(new fileenam { Name = def });
                    }
                    if (def.Contains("topic10_3") && topic == "topic10_3")
                    {
                        int hj = def.IndexOf('.');
                        if (hj >= 0)
                            def = def.Substring(0, hj);
                        lstfile.Add(new fileenam { Name = def });
                    }
                    if (def.Contains("topic10_4") && topic == "topic10_4")
                    {
                        int hj = def.IndexOf('.');
                        if (hj >= 0)
                            def = def.Substring(0, hj);
                        lstfile.Add(new fileenam { Name = def });
                    }
                }

            }
            var a = lstfile.Count;
            if (a == 0)
                lbl_alert.IsVisible = true;
            MainListView_drafts.ItemsSource = lstfile;

        }
        private async Task OpenDraftAll()
        {


            List<fileenam> lstfile = new List<fileenam>();
            IFolder rootFolder = null;
            if (Device.RuntimePlatform == Device.iOS)
            {
                rootFolder = await FileSystem.Current.GetFolderFromPathAsync(PCLStorage.FileSystem.Current.LocalStorage.Path + "/HandSAppDrafts/");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                rootFolder = await FileSystem.Current.GetFolderFromPathAsync("/storage/emulated/0/HandSAppDrafts/");
            }
            var file1 = await rootFolder.GetFilesAsync();
            foreach (var abc in file1)
            {

                string def = abc.Name.ToString();

                bool sdef = def.Contains(".json");
                if (sdef == true)
                {
                    int hj = def.IndexOf('.');
                    if (hj >= 0)
                        def = def.Substring(0, hj);
                    lstfile.Add(new fileenam { Name = def });
                }
            }
            var a = lstfile.Count;
            if (a == 0)
                lbl_alert.IsVisible = true;
            MainListView_drafts.ItemsSource = lstfile;

        }
        private async Task OpenPDFS()
        {


            List<fileenam> lstfile = new List<fileenam>();
            IFolder rootFolder = null;
            if (Device.RuntimePlatform == Device.iOS)
            {
                rootFolder = await FileSystem.Current.GetFolderFromPathAsync(PCLStorage.FileSystem.Current.LocalStorage.Path + "/HandSAppPdf/");
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                 rootFolder = await FileSystem.Current.GetFolderFromPathAsync("/storage/emulated/0/HandSAppPdf/");
            }
            IList<IFile> file1 = await rootFolder.GetFilesAsync();
            foreach (var abc in file1)
            {
                string def = abc.Name.ToString();

                bool sdef = def.Contains(".pdf");
                if (sdef == true)
                {
                    lstfile.Add(new fileenam { Name = def });

                }

            }
            var a = lstfile.Count;
            if (a == 0)
                lbl_alert.IsVisible = true;
            MainListView_drafts.ItemsSource = lstfile;
        }


        private async void MainListView_drafts_OnItemTapped(object sender, EventArgs e)
        {
            fileenam st = (fileenam)MainListView_drafts.SelectedItem;
            UserDialogs.Instance.ShowLoading("Please wait..");
            if (topic == "PDFS")
            {
                // Open_PDF(st.Name);
                UserDialogs.Instance.HideLoading();
                return;
            }
            else
            {
                topic = st.Name.Substring(st.Name.IndexOf("_"), st.Name.Length - st.Name.IndexOf("_"));
            }


            if (topic == "_DRA")
                await Navigation.PushAsync(new Topic1(st.Name + ".json"));
            if (topic == "_CA")
                await Navigation.PushAsync(new Topic2(st.Name + ".json"));
            if (topic == "_WSA")
                await Navigation.PushAsync(new Topic3(st.Name + ".json"));
            if (topic == "_MHA")
                await Navigation.PushAsync(new Topic4(st.Name + ".json"));
            if (topic == "_ARF")
                await Navigation.PushAsync(new Topic5(st.Name + ".json"));
            if (topic == "_SSW")
                await Navigation.PushAsync(new Topic6(st.Name + ".json"));
            if (topic == "_ASI")
                await Navigation.PushAsync(new AuditForm(st.Name + ".json"));
            /*if (topic == "topic7")
                await Navigation.PushAsync(new Topic7(st.Name + ".json"));
            if (topic == "topic8")
                await Navigation.PushAsync(new Topic8(st.Name + ".json"));
            
            if (topic == "topic10_1")
                await Navigation.PushAsync(new Topic10_1(st.Name + ".json"));
            if (topic == "topic10_2")
                await Navigation.PushAsync(new Topic10_2(st.Name + ".json"));
            if (topic == "topic10_3")
                await Navigation.PushAsync(new Topic10_3(st.Name + ".json"));
            if (topic == "topic10_4")
                await Navigation.PushAsync(new Topic10_4(st.Name + ".json"));*/

            UserDialogs.Instance.HideLoading();
            topic = "";
        }
        /*private async void Open_PDF(string name)
        {


            IFolder path = await FileSystem.Current.GetFolderFromPathAsync("/storage/emulated/0/HandSAppPdf/");
            string dbPath = Path.Combine(path.Path, name);


            var documentViewer = DependencyService.Get<IDocumentViewer>();
            var mimeType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
            if (Path.GetExtension(dbPath).ToLower() == ".pdf")
                mimeType = "application/pdf";

            try
            {
                documentViewer.ShowDocumentFile(dbPath, mimeType);
            }
            catch (Exception ex)
            {

            }
        }*/
    

    public class fileenam
    {
        public string Name { get; set; }
    }
}
}
