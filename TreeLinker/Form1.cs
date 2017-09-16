using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using TreeLinker.Resource;

namespace TreeLinker
{
    public partial class Form1 : Form
    {
        public List<NodeList> OpenList;
        public List<NodeList> LinkrList;
        public List<string> BanList;
        public HttpWebRequest Request;
        public HttpWebResponse Response;
        public int Depth;
        public BackgroundWorker Worker;
        public Form1()
        {
            InitializeComponent();
            BanList = new List<string>();
            OpenList = new List<NodeList>();
            LinkrList = new List<NodeList>();
            Depth = 0;

            Worker = new BackgroundWorker();
            Worker.WorkerReportsProgress = true;

            Worker.DoWork += worker_DoWork;
            Worker.ProgressChanged += worker_ProgressChanged;
            Worker.RunWorkerCompleted += worker_RunWorkerCompleted;
        }
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < LinkrList.Count; i++)
            {
                NodeTree(LinkrList[i], ConstantName.StartDepth, 
                    treeView1.Nodes[ConstantName.Index], ConstantName.Index);
                ((BackgroundWorker)sender).ReportProgress(i);
            }
        }
        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            OpenList.Clear();
            BanList.Clear();
            LinkrList.Clear();
            lbWaite.Text = ConstantName.DoneMessage;
            btBuildTree.Enabled = true;
        }

        private void btBuildTree_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            lbException.Visible = false;
            
            
            if (Regex.IsMatch(tbLink.Text, ConstantName.HrefPattern))
            {
                Depth = (int)numDepthTree.Value;
                btBuildTree.Enabled = false;
                lbWaite.Text = ConstantName.WaitMessage;
                lbWaite.Visible = true;

                string html = GetHtml(tbLink.Text);
                var titleHtml = Regex.Match(html, ConstantName.RegexTitle);
                var node = new TreeNode(titleHtml + " (" + tbLink.Text + ")");
                treeView1.Nodes.Add(node);
                BanList.Add(tbLink.Text);
                LinkrList = FilterLink(0, html);
                progressBar1.Maximum = LinkrList.Count - 1;

                Worker.RunWorkerAsync();
            }

            else
            {
                lbException.Visible = true;
                lbException.Text = ConstantName.InvalidUrlMessage;
            }
        }
        
        private string GetHtml(string url)
        {
            StringBuilder strinhBuilder = new StringBuilder();
            byte[] buf = new byte[8192];
            Request = (HttpWebRequest)WebRequest.Create(url);
            Response = (HttpWebResponse)Request.GetResponse();
            var resStream = Response.GetResponseStream();
            int count = 0;
            do
            {
                count = resStream.Read(buf, 0, buf.Length);
                if (count != 0)
                {
                    strinhBuilder.Append(Encoding.UTF8.GetString(buf, 0, count));
                }
            }
            while (count > 0);

            return strinhBuilder.ToString();
        }
        public void NodeTree(NodeList link, int depth, TreeNode node,int index)
        {

            if (BanList.Contains(link.Link))
            {
               --index;
               return;
            }

            if (depth == Depth)
            {
                return;
            }
            
            if (link.Depth == depth && OpenList.Any(x => x.Depth == link.Depth && x.Link == link.Link))
            {
                try
                {
                    string html = GetHtml(link.Link);
                    var titleHtml = Regex.Match(html, ConstantName.RegexTitle);
                    BeginInvoke(new Action(() => node.Nodes.Add(new TreeNode(titleHtml + " (" + link.Link + ")"))));
                    ++depth;
                    BanList.Add(link.Link);

                    if (depth != Depth)
                    {
                        var tempList = FilterLink(depth, html);
                        for (int j = 0; j < tempList.Count; j++)
                        {
                            if (!BanList.Contains(tempList[j].Link))
                            {
                                NodeTree(tempList[j], depth, node.Nodes[node.Nodes.Count - 1], node.Nodes[node.Nodes.Count - 1].Index);
                            }
                        }
                    }
                }
                catch (Exception e)// Pages 404 and who do not have access
                {
                    return;
                }
            }
        }

        public List<NodeList> FilterLink(int depth, string html)
        {
            var itemList = new List<string>();
            var nodeList = new List<NodeList>();
            var hrefs = Regex.Matches(html, ConstantName.RegexAHref);

            foreach (var hrefValue in hrefs)
            {
                var hrefRegex = Regex.Match(hrefValue.ToString(), ConstantName.HrefPattern);
                var href = hrefRegex.ToString().Trim(ConstantName.TrimChar);
                if (!String.IsNullOrEmpty(href))
                    itemList.Add(href);
            }
            
            var linkList = itemList.Distinct().ToList();

            foreach (var link in linkList)
            {
                if (link.Length > 1)
                {
                    if (!Regex.IsMatch(link, ConstantName.RegexHttp) && !Regex.IsMatch(link, ConstantName.RegexLattice))
                    {
                        var fullLink = ConvertUrlsToLinks(link);
                        if (!OpenList.Any(x => x.Link == fullLink))
                        {
                            nodeList.Add(new NodeList(depth, fullLink));
                            OpenList.Add(new NodeList(depth, fullLink));
                        }
                    }
                }
            }
            return nodeList;
        }

        private string ConvertUrlsToLinks(string msg)
        {
            var r = Regex.Match(msg, ConstantName.HrefPattern);

            if (Regex.IsMatch(msg, ConstantName.HrefPattern))
            {
                return r.ToString();
            }

            return String.Format("{0}{1}", tbLink.Text, msg);
        }

        public static void SaveItems(XElement curNode, TreeNode item)
        {
            foreach (TreeNode itemloc in item.Nodes)
            {
                XElement newNode = new XElement(ConstantName.XElementFolder, new XAttribute(ConstantName.XAttributeTitle, itemloc.Text));
                SaveItems(newNode, itemloc);
                curNode.Add(newNode);
            }
        }

        private void saveToXmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XElement root = new XElement(ConstantName.XElementXbel, new XAttribute(ConstantName.XAttributeVersion, ConstantName.XAttributeVersionNumber),
                new XElement(ConstantName.XElementFolder, new XAttribute(ConstantName.XAttributeTitle, treeView1.Nodes[0].Text)));

            foreach (TreeNode item in treeView1.Nodes)
                SaveItems(root, item);
            root.Save(ConstantName.FileName);
            MessageBox.Show(ConstantName.SavedSuccessfullyMessage);
        }
    }

   
}
