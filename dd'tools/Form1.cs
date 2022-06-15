using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace dd_tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cms_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://whatcms.org/?s=" + HttpUtility.UrlEncode(site.Text));

        }

        private void robottxt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=" + HttpUtility.UrlEncode(site.Text) + "/robots.txt");

        }

        private void subdomain_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=" + "site:*." + HttpUtility.UrlEncode(site.Text));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://delosemre.github.io/");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/delosemre");
        }

        private void whois_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.whois.com/whois/" + HttpUtility.UrlEncode(site.Text));

        }

        private void reverseiplookup_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://viewdns.info/reverseip/?host=" + HttpUtility.UrlEncode(site.Text));

        }

        private void datafile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=" + "site:" + HttpUtility.UrlEncode(site.Text) + " ext:sql | ext:dbf | ext:mdb");

        }

        private void shodan_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.shodan.io/search?query="+ HttpUtility.UrlEncode(site.Text));

        }

        private void sertifika_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://crt.sh/?q=" + HttpUtility.UrlEncode(site.Text));

        }

        private void dnsrec_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://securitytrails.com/domain/" + HttpUtility.UrlEncode(site.Text));
        }

        private void reputation_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.urlvoid.com/scan/"+ HttpUtility.UrlEncode(site.Text));

        }

        private void analytic_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://builtwith.com/"+ HttpUtility.UrlEncode(site.Text));

        }

        private void analytic2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.siteliner.com/" + HttpUtility.UrlEncode(site.Text));

        }

        private void dnssec_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dnsviz.net/d/" + HttpUtility.UrlEncode(site.Text)+ "/dnssec");

        }

        private void findwp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=" + "site:*." + HttpUtility.UrlEncode(site.Text) + " inurl:wp-content | inurl:wp-includes");

        }

        private void findsubsub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=" + "site:*.*." + HttpUtility.UrlEncode(site.Text));

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://delosemre.github.io/");

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:emre@emreylmz.com");

        }
    }
}
