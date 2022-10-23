using System.Collections;
using System.Net;
using System.Web;
using HtmlAgilityPack;
using WebPWrapper;

namespace Sushi_DL
{
    public partial class Form1 : Form
    {        
        string listLink = "https://sushiscan.su/manga/list-mode/";

        Dictionary<string, string> _mangasUrl = new();
        Dictionary<string, string> _volumes = new();
        Dictionary<string, string> _chapters = new();

        List<string> titles = new();
        List<string> urls = new();

        public static List<string> selectedVolumes = new();
        public static List<string> selectedChapters = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ParseTitles();            
        }

        //Parse manga titles
        private void ParseTitles()
        {
            HtmlWeb web = new();
            HtmlAgilityPack.HtmlDocument doc = web.Load(listLink);

            ///Add titles to box and list
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

            ///Add urls to list
            foreach (HtmlNode href in doc.DocumentNode.SelectNodes("//div[5]//li/a[@href]"))
            {
                urls.Add(href.GetAttributeValue("href", string.Empty));
            }

            ///Combine titles and urls to dictionary
            for (var i = 0; i < titles.Count; i++)
            {
                _mangasUrl.Add(titles[i], urls[i]);
            }
        }

        //Parse details of selected manga
        private void ParseDetails(string t)
        {
            string url = _mangasUrl[t];

            HtmlWeb web = new();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);

            ///Add title
            foreach (HtmlNode h1 in doc.DocumentNode.SelectNodes("//div[@id='titlemove']/h1"))
            {
                if (h1.NodeType == HtmlNodeType.Element)
                {
                    string s = h1.InnerText;
                    string a = HttpUtility.HtmlDecode(s);

                    titleLabel.Text = a;
                }
            }            

            ///Add cover
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

            ///Add genre
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

            ///Add synopsis
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

            ///Add volumes and chapters to dedicated boxes
            foreach (var li in doc.DocumentNode.SelectNodes("//div[@id='chapterlist']/ul//li"))
            {
                if (li.NodeType == HtmlNodeType.Element)
                {
                    if (li.OuterHtml.Contains("Volume"))
                    {
                        var tmp = new List<string>();

                        tmp.Add(li.GetAttributeValue("data-num", string.Empty));

                        for (var i = 0; i < tmp.Count; i++)
                        {
                            volumeBox.Items.Insert(i, tmp[i]);                            
                        }
                    }

                    if (li.OuterHtml.Contains("Chapitre"))
                    {
                        chapterBox.Items.Add(li.GetAttributeValue("data-num", string.Empty));
                    }
                }
            }
        }

        private void titleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var t = titleBox.SelectedItem.ToString();

            volumeBox.Items.Clear();
            chapterBox.Items.Clear();

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
            selectedChapters.Clear();

            if (volumeRadio.Checked)
            {
                ListBox.SelectedObjectCollection selected = volumeBox.SelectedItems;

                foreach (var item in selected)
                {
                    selectedVolumes.Add(item.ToString());
                }
            }

            var form2 = new Form2();
            form2.Show();
        }
    }
}