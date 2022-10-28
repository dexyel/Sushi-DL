using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Windows.Forms;
using HtmlAgilityPack;
using WebPWrapper;

namespace Sushi_DL
{
    public partial class MainForm : Form
    {        
        string listLink = "https://sushiscan.su/manga/list-mode/";

        Dictionary<string, string> _mangasUrl = new();
        Dictionary<string, string> _volumesUrl = new();
        Dictionary<string, string> _chaptersUrl = new();

        List<string> titles = new();
        List<string> titlesUrl = new();

        public static List<string> selectedVolumes = new();
        public static List<string> selectedVolumesUrl = new();
        public static List<string> selectedChapters = new();
        public static List<string> selectedChaptersUrl = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ParseTitles();            
        }

        //Parse la liste complète des mangas
        private void ParseTitles()
        {
            HtmlWeb web = new();
            HtmlAgilityPack.HtmlDocument doc = web.Load(listLink);

            ///Ajoute les titres à la listbox
            foreach (HtmlNode li in doc.DocumentNode.SelectNodes("//div[@class='soralist']//li"))
            {
                if (li.InnerHtml.Contains("series"))
                {
                    string s = li.InnerText;
                    string a = HttpUtility.HtmlDecode(s);

                    titleBox.Items.Add(a);                    
                    titles.Add(a);
                }
            }

            ///Ajoute les urls dans une liste
            foreach (HtmlNode href in doc.DocumentNode.SelectNodes("//div[5]//li/a[@href]"))
            {
                titlesUrl.Add(href.GetAttributeValue("href", string.Empty));
            }

            ///Combine les titres et les url dans un dictionnaire
            for (var i = 0; i < titles.Count; i++)
            {
                _mangasUrl.Add(titles[i], titlesUrl[i]);
            }
        }

        //Parse les détails du manga sélectionné
        private void ParseDetails(string t)
        {
            string url = _mangasUrl[t];

            HtmlWeb web = new();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);

            ///Titre
            foreach (HtmlNode h1 in doc.DocumentNode.SelectNodes("//div[@id='titlemove']/h1"))
            {
                if (h1.NodeType == HtmlNodeType.Element)
                {
                    string s = h1.InnerText;
                    string a = HttpUtility.HtmlDecode(s);

                    titleLabel.Text = a;
                }
            }

            ///Couverture
            foreach (HtmlNode src in doc.DocumentNode.SelectNodes("//div[@class='thumb']/img"))
            {
                if (src.NodeType == HtmlNodeType.Element)
                {
                    ///Decode and display WebP
                    if (src.OuterHtml.Contains(".webp"))
                    {
                        var webpLink = src.GetAttributeValue("src", string.Empty);
                        var file = "cover.webp";

                        using (WebClient client = new WebClient())
                        {
                            client.Headers.Add("User-Agent: Other");
                            client.DownloadFile(webpLink, file);

                            byte[] rawWebP = File.ReadAllBytes("cover.webp");

                            using (var webP = new WebP())
                            {
                                coverBox.Image = webP.Decode(rawWebP);
                            }
                        }
                    }
                    ///Display JPG
                    else
                    {
                        coverBox.Load(src.GetAttributeValue("src", string.Empty));
                    }
                }
            }

            ///Genre(s)
            if (doc.DocumentNode.SelectNodes("//span[@class='mgen']") != null)
            {
                foreach (HtmlNode a in doc.DocumentNode.SelectNodes("//span[@class='mgen']"))
                {
                    genreLabel1.Text = a.FirstChild.InnerText;

                    if (a.ChildNodes.Count > 1)
                    {
                        genreLabel2.Text = a.LastChild.InnerText;
                    }
                    else
                    {
                        genreLabel2.Text = string.Empty;
                    }
                }
            }
            else
            {
                genreLabel1.Text = string.Empty;
                genreLabel2.Text = string.Empty;
            }

            ///Synopsis
            foreach (HtmlNode p in doc.DocumentNode.SelectNodes("//div[@itemprop='description']"))
            {
                string s1 = p.FirstChild.InnerText;
                string a1 = HttpUtility.HtmlDecode(s1);

                if (p.ChildNodes.Count > 0)
                {
                    string s2 = p.LastChild.InnerText;
                    string a2 = HttpUtility.HtmlDecode(s2);

                    synopsisLabel.Text = a1 + "\n" + a2;
                }
                else
                {
                    synopsisLabel.Text = a1;
                }
            }

            ///Ajoute les tomes et les chapitres dans des listbox; Combine les numéros et url à des dictionnaires
            foreach (HtmlNode li in doc.DocumentNode.SelectNodes("//div[@id='chapterlist']/ul//li/div[1]/div[1]/a[@href]"))
            {
                if (li.NodeType == HtmlNodeType.Element)
                {
                    if (li.ParentNode.OuterHtml.Contains("Volume"))
                    {
                        var tmpListVolumes = new List<string>();
                        var tmpVolumesUrl = new List<string>();

                        tmpListVolumes.Add(li.ParentNode.ParentNode.ParentNode.GetAttributeValue("data-num", string.Empty));
                        tmpVolumesUrl.Add(li.GetAttributeValue("href", string.Empty));

                        for (var i = 0; i < tmpListVolumes.Count; i++)
                        {
                            volumeBox.Items.Insert(i, tmpListVolumes[i]);
                            _volumesUrl.Add(tmpListVolumes[i], tmpVolumesUrl[i]);
                        }                        
                    }

                    if (li.OuterHtml.Contains("Chapitre"))
                    {
                        var tmpListChapters = new List<string>();
                        var tmpChaptersUrl = new List<string>();

                        tmpListChapters.Add(li.ParentNode.ParentNode.ParentNode.GetAttributeValue("data-num", string.Empty));
                        tmpChaptersUrl.Add(li.GetAttributeValue("href", string.Empty));

                        for (var i = 0; i < tmpListChapters.Count; i++)
                        {
                            chapterBox.Items.Add(tmpListChapters[i]);
                            _chaptersUrl.Add(tmpListChapters[i], tmpChaptersUrl[i]);
                        }
                    }
                }
            }
            #region Debug Dictionnaires URL (Volume/Chapitre)
            /*
            foreach (var kvp in _volumesUrl)
            {
                Debug.WriteLine("Key = {0}, value = {1}", kvp.Key, kvp.Value);
            }

            if (_chaptersUrl.Count != 0)
            {
                foreach (var kvp in _chaptersUrl)
                {
                    Debug.WriteLine("Key = {0}, value = {1}", kvp.Key, kvp.Value);
                }
            }
            */
            #endregion
        }

        private void titleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var t = titleBox.SelectedItem.ToString();

            volumeBox.Items.Clear();
            chapterBox.Items.Clear();

            _volumesUrl.Clear();
            _chaptersUrl.Clear();

            ParseDetails(t);
        }

        //Search titles
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            titleBox.Items.Clear();

            foreach (string str in titles)
            {
                if (str.StartsWith(searchBox.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    titleBox.Items.Add(str);
                }
            }
        }

        private void volumeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (volumeBox.SelectedIndex > -1)
            {
                chapterBox.SelectedIndex = -1;

                volumeRadio.Enabled = true;
                chapterRadio.Enabled = false;
                combineRadio.Enabled = false;

                volumeRadio.Checked = true;
            }
        }

        private void chapterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chapterBox.SelectedIndex > -1)
            {
                volumeBox.SelectedIndex = -1;

                chapterRadio.Enabled = true;
                combineRadio.Enabled = true;
                volumeRadio.Enabled = false;

                chapterRadio.Checked = true;
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            selectedVolumes.Clear();
            selectedVolumesUrl.Clear();
            selectedChapters.Clear();
            selectedChaptersUrl.Clear();

            if (volumeRadio.Checked)
            {
                ListBox.SelectedObjectCollection selected = volumeBox.SelectedItems;

                foreach (var item in selected)
                {
                    selectedVolumes.Add(titleLabel.Text + " - " +  item.ToString());
                    selectedVolumesUrl.Add(_volumesUrl[item.ToString()]);
                }
            }

            var form2 = new DownloadList();
            form2.Show();
        }
    }
}