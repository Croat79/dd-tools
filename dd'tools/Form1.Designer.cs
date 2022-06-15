
namespace dd_tools
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.site = new System.Windows.Forms.TextBox();
            this.cms = new System.Windows.Forms.Button();
            this.robottxt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.subdomain = new System.Windows.Forms.Button();
            this.whois = new System.Windows.Forms.Button();
            this.reverseiplookup = new System.Windows.Forms.Button();
            this.datafile = new System.Windows.Forms.Button();
            this.shodan = new System.Windows.Forms.Button();
            this.sertifika = new System.Windows.Forms.Button();
            this.dnsrec = new System.Windows.Forms.Button();
            this.reputation = new System.Windows.Forms.Button();
            this.analytic = new System.Windows.Forms.Button();
            this.analytic2 = new System.Windows.Forms.Button();
            this.dnssec = new System.Windows.Forms.Button();
            this.findwp = new System.Windows.Forms.Button();
            this.findsubsub = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // site
            // 
            this.site.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.site.Location = new System.Drawing.Point(241, 63);
            this.site.Multiline = true;
            this.site.Name = "site";
            this.site.Size = new System.Drawing.Size(280, 26);
            this.site.TabIndex = 0;
            this.site.Text = "delosemre.github.io";
            this.site.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cms
            // 
            this.cms.Location = new System.Drawing.Point(47, 127);
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(90, 30);
            this.cms.TabIndex = 1;
            this.cms.Text = "What CMS ?";
            this.cms.UseVisualStyleBackColor = true;
            this.cms.Click += new System.EventHandler(this.cms_Click);
            // 
            // robottxt
            // 
            this.robottxt.Location = new System.Drawing.Point(505, 127);
            this.robottxt.Name = "robottxt";
            this.robottxt.Size = new System.Drawing.Size(90, 30);
            this.robottxt.TabIndex = 2;
            this.robottxt.Text = "Robot.txt";
            this.robottxt.UseVisualStyleBackColor = true;
            this.robottxt.Click += new System.EventHandler(this.robottxt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(352, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "dd\'Tools";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(296, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // subdomain
            // 
            this.subdomain.Location = new System.Drawing.Point(652, 127);
            this.subdomain.Name = "subdomain";
            this.subdomain.Size = new System.Drawing.Size(90, 30);
            this.subdomain.TabIndex = 5;
            this.subdomain.Text = "Subdomain";
            this.subdomain.UseVisualStyleBackColor = true;
            this.subdomain.Click += new System.EventHandler(this.subdomain_Click);
            // 
            // whois
            // 
            this.whois.Location = new System.Drawing.Point(47, 186);
            this.whois.Name = "whois";
            this.whois.Size = new System.Drawing.Size(90, 30);
            this.whois.TabIndex = 6;
            this.whois.Text = "Whois";
            this.whois.UseVisualStyleBackColor = true;
            this.whois.Click += new System.EventHandler(this.whois_Click);
            // 
            // reverseiplookup
            // 
            this.reverseiplookup.Location = new System.Drawing.Point(47, 251);
            this.reverseiplookup.Name = "reverseiplookup";
            this.reverseiplookup.Size = new System.Drawing.Size(90, 38);
            this.reverseiplookup.TabIndex = 7;
            this.reverseiplookup.Text = "Reverse IP Lookup";
            this.reverseiplookup.UseVisualStyleBackColor = true;
            this.reverseiplookup.Click += new System.EventHandler(this.reverseiplookup_Click);
            // 
            // datafile
            // 
            this.datafile.Location = new System.Drawing.Point(200, 255);
            this.datafile.Name = "datafile";
            this.datafile.Size = new System.Drawing.Size(90, 30);
            this.datafile.TabIndex = 8;
            this.datafile.Text = "Database File";
            this.datafile.UseVisualStyleBackColor = true;
            this.datafile.Click += new System.EventHandler(this.datafile_Click);
            // 
            // shodan
            // 
            this.shodan.Location = new System.Drawing.Point(505, 255);
            this.shodan.Name = "shodan";
            this.shodan.Size = new System.Drawing.Size(90, 30);
            this.shodan.TabIndex = 9;
            this.shodan.Text = "Shodan";
            this.shodan.UseVisualStyleBackColor = true;
            this.shodan.Click += new System.EventHandler(this.shodan_Click);
            // 
            // sertifika
            // 
            this.sertifika.Location = new System.Drawing.Point(356, 255);
            this.sertifika.Name = "sertifika";
            this.sertifika.Size = new System.Drawing.Size(90, 30);
            this.sertifika.TabIndex = 10;
            this.sertifika.Text = "Certificates";
            this.sertifika.UseVisualStyleBackColor = true;
            this.sertifika.Click += new System.EventHandler(this.sertifika_Click);
            // 
            // dnsrec
            // 
            this.dnsrec.Location = new System.Drawing.Point(200, 127);
            this.dnsrec.Name = "dnsrec";
            this.dnsrec.Size = new System.Drawing.Size(90, 30);
            this.dnsrec.TabIndex = 11;
            this.dnsrec.Text = "DNS Records";
            this.dnsrec.UseVisualStyleBackColor = true;
            this.dnsrec.Click += new System.EventHandler(this.dnsrec_Click);
            // 
            // reputation
            // 
            this.reputation.Location = new System.Drawing.Point(356, 127);
            this.reputation.Name = "reputation";
            this.reputation.Size = new System.Drawing.Size(90, 30);
            this.reputation.TabIndex = 12;
            this.reputation.Text = "Reputation";
            this.reputation.UseVisualStyleBackColor = true;
            this.reputation.Click += new System.EventHandler(this.reputation_Click);
            // 
            // analytic
            // 
            this.analytic.Location = new System.Drawing.Point(200, 186);
            this.analytic.Name = "analytic";
            this.analytic.Size = new System.Drawing.Size(90, 30);
            this.analytic.TabIndex = 13;
            this.analytic.Text = "Analytic";
            this.analytic.UseVisualStyleBackColor = true;
            this.analytic.Click += new System.EventHandler(this.analytic_Click);
            // 
            // analytic2
            // 
            this.analytic2.Location = new System.Drawing.Point(356, 186);
            this.analytic2.Name = "analytic2";
            this.analytic2.Size = new System.Drawing.Size(90, 30);
            this.analytic2.TabIndex = 14;
            this.analytic2.Text = "Analytic 2";
            this.analytic2.UseVisualStyleBackColor = true;
            this.analytic2.Click += new System.EventHandler(this.analytic2_Click);
            // 
            // dnssec
            // 
            this.dnssec.Location = new System.Drawing.Point(505, 186);
            this.dnssec.Name = "dnssec";
            this.dnssec.Size = new System.Drawing.Size(90, 30);
            this.dnssec.TabIndex = 15;
            this.dnssec.Text = "DNSSEC";
            this.dnssec.UseVisualStyleBackColor = true;
            this.dnssec.Click += new System.EventHandler(this.dnssec_Click);
            // 
            // findwp
            // 
            this.findwp.Location = new System.Drawing.Point(652, 186);
            this.findwp.Name = "findwp";
            this.findwp.Size = new System.Drawing.Size(90, 30);
            this.findwp.TabIndex = 16;
            this.findwp.Text = "Find Wordpress";
            this.findwp.UseVisualStyleBackColor = true;
            this.findwp.Click += new System.EventHandler(this.findwp_Click);
            // 
            // findsubsub
            // 
            this.findsubsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.findsubsub.Location = new System.Drawing.Point(652, 251);
            this.findsubsub.Name = "findsubsub";
            this.findsubsub.Size = new System.Drawing.Size(90, 38);
            this.findsubsub.TabIndex = 17;
            this.findsubsub.Text = "Find Sub-Subdomains";
            this.findsubsub.UseVisualStyleBackColor = true;
            this.findsubsub.Click += new System.EventHandler(this.findsubsub_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(237, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Contact for suggestion";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(317, 366);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(401, 366);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findsubsub);
            this.Controls.Add(this.findwp);
            this.Controls.Add(this.dnssec);
            this.Controls.Add(this.analytic2);
            this.Controls.Add(this.analytic);
            this.Controls.Add(this.reputation);
            this.Controls.Add(this.dnsrec);
            this.Controls.Add(this.sertifika);
            this.Controls.Add(this.shodan);
            this.Controls.Add(this.datafile);
            this.Controls.Add(this.reverseiplookup);
            this.Controls.Add(this.whois);
            this.Controls.Add(this.subdomain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.robottxt);
            this.Controls.Add(this.cms);
            this.Controls.Add(this.site);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "dd\'Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox site;
        private System.Windows.Forms.Button cms;
        private System.Windows.Forms.Button robottxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button subdomain;
        private System.Windows.Forms.Button whois;
        private System.Windows.Forms.Button reverseiplookup;
        private System.Windows.Forms.Button datafile;
        private System.Windows.Forms.Button shodan;
        private System.Windows.Forms.Button sertifika;
        private System.Windows.Forms.Button dnsrec;
        private System.Windows.Forms.Button reputation;
        private System.Windows.Forms.Button analytic;
        private System.Windows.Forms.Button analytic2;
        private System.Windows.Forms.Button dnssec;
        private System.Windows.Forms.Button findwp;
        private System.Windows.Forms.Button findsubsub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

