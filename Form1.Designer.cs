namespace Esoft_Project
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button buttonOpenAgents;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenRealEstates = new System.Windows.Forms.Button();
            this.buttonOpenDemands = new System.Windows.Forms.Button();
            this.buttonOpenSupplies = new System.Windows.Forms.Button();
            this.buttonOpenDeals = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            buttonOpenAgents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonOpenClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenClients.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonOpenClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenClients.Font = new System.Drawing.Font("Tahoma", 22F);
            this.buttonOpenClients.Location = new System.Drawing.Point(45, 117);
            this.buttonOpenClients.Margin = new System.Windows.Forms.Padding(46, 10, 46, 10);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Size = new System.Drawing.Size(244, 58);
            this.buttonOpenClients.TabIndex = 1;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = false;
            this.buttonOpenClients.Click += new System.EventHandler(this.ButtonOpenClients_Click);
            // 
            // buttonOpenAgents
            // 
            buttonOpenAgents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            buttonOpenAgents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonOpenAgents.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonOpenAgents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            buttonOpenAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonOpenAgents.Font = new System.Drawing.Font("Tahoma", 22F);
            buttonOpenAgents.ForeColor = System.Drawing.Color.Black;
            buttonOpenAgents.Location = new System.Drawing.Point(45, 195);
            buttonOpenAgents.Margin = new System.Windows.Forms.Padding(46, 10, 46, 10);
            buttonOpenAgents.Name = "buttonOpenAgents";
            buttonOpenAgents.Size = new System.Drawing.Size(244, 58);
            buttonOpenAgents.TabIndex = 2;
            buttonOpenAgents.Text = "Риелторы";
            buttonOpenAgents.UseVisualStyleBackColor = false;
            buttonOpenAgents.Click += new System.EventHandler(this.ButtonOpenAgents_Click);
            // 
            // buttonOpenRealEstates
            // 
            this.buttonOpenRealEstates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonOpenRealEstates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenRealEstates.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonOpenRealEstates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenRealEstates.Font = new System.Drawing.Font("Tahoma", 22F);
            this.buttonOpenRealEstates.Location = new System.Drawing.Point(45, 273);
            this.buttonOpenRealEstates.Margin = new System.Windows.Forms.Padding(36, 10, 36, 10);
            this.buttonOpenRealEstates.Name = "buttonOpenRealEstates";
            this.buttonOpenRealEstates.Size = new System.Drawing.Size(244, 102);
            this.buttonOpenRealEstates.TabIndex = 3;
            this.buttonOpenRealEstates.Text = "Объекты недвижимости";
            this.buttonOpenRealEstates.UseVisualStyleBackColor = false;
            this.buttonOpenRealEstates.Click += new System.EventHandler(this.ButtonOpenRealEstates_Click);
            // 
            // buttonOpenDemands
            // 
            this.buttonOpenDemands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonOpenDemands.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenDemands.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonOpenDemands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenDemands.Font = new System.Drawing.Font("Tahoma", 22F);
            this.buttonOpenDemands.Location = new System.Drawing.Point(45, 395);
            this.buttonOpenDemands.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.buttonOpenDemands.Name = "buttonOpenDemands";
            this.buttonOpenDemands.Size = new System.Drawing.Size(244, 56);
            this.buttonOpenDemands.TabIndex = 4;
            this.buttonOpenDemands.Text = "Предложения";
            this.buttonOpenDemands.UseVisualStyleBackColor = false;
            // 
            // buttonOpenSupplies
            // 
            this.buttonOpenSupplies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonOpenSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenSupplies.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonOpenSupplies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenSupplies.Font = new System.Drawing.Font("Tahoma", 22F);
            this.buttonOpenSupplies.Location = new System.Drawing.Point(45, 471);
            this.buttonOpenSupplies.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.buttonOpenSupplies.Name = "buttonOpenSupplies";
            this.buttonOpenSupplies.Size = new System.Drawing.Size(244, 56);
            this.buttonOpenSupplies.TabIndex = 5;
            this.buttonOpenSupplies.Text = "Потребности";
            this.buttonOpenSupplies.UseVisualStyleBackColor = false;
            // 
            // buttonOpenDeals
            // 
            this.buttonOpenDeals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonOpenDeals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenDeals.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonOpenDeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenDeals.Font = new System.Drawing.Font("Tahoma", 22F);
            this.buttonOpenDeals.Location = new System.Drawing.Point(45, 547);
            this.buttonOpenDeals.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.buttonOpenDeals.Name = "buttonOpenDeals";
            this.buttonOpenDeals.Size = new System.Drawing.Size(244, 56);
            this.buttonOpenDeals.TabIndex = 6;
            this.buttonOpenDeals.Text = "Сделки";
            this.buttonOpenDeals.UseVisualStyleBackColor = false;
            this.buttonOpenDeals.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::Esoft_Project.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(-8, -1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(350, 105);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 626);
            this.Controls.Add(this.buttonOpenDeals);
            this.Controls.Add(this.buttonOpenSupplies);
            this.Controls.Add(this.buttonOpenDemands);
            this.Controls.Add(this.buttonOpenRealEstates);
            this.Controls.Add(buttonOpenAgents);
            this.Controls.Add(this.buttonOpenClients);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esoft";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenRealEstates;
        private System.Windows.Forms.Button buttonOpenDemands;
        private System.Windows.Forms.Button buttonOpenSupplies;
        private System.Windows.Forms.Button buttonOpenDeals;
    }
}

