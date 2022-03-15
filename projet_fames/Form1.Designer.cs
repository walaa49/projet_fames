
namespace projet_fames
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.pnldroite = new System.Windows.Forms.Panel();
            this.btncreation = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnconnection = new Guna.UI.WinForms.GunaAdvenceButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlgauche = new System.Windows.Forms.Panel();
            this.rdbrappel = new Guna.UI.WinForms.GunaRadioButton();
            this.txtmdp = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtnom = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnidentification = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnldroite.SuspendLayout();
            this.pnlgauche.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnldroite
            // 
            this.pnldroite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnldroite.Controls.Add(this.btncreation);
            this.pnldroite.Controls.Add(this.btnconnection);
            this.pnldroite.Location = new System.Drawing.Point(689, 0);
            this.pnldroite.Name = "pnldroite";
            this.pnldroite.Size = new System.Drawing.Size(310, 549);
            this.pnldroite.TabIndex = 0;
            this.pnldroite.Paint += new System.Windows.Forms.PaintEventHandler(this.pnldroite_Paint);
            // 
            // btncreation
            // 
            this.btncreation.AnimationHoverSpeed = 0.07F;
            this.btncreation.AnimationSpeed = 0.03F;
            this.btncreation.BackColor = System.Drawing.Color.Transparent;
            this.btncreation.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btncreation.BorderColor = System.Drawing.Color.Black;
            this.btncreation.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btncreation.CheckedBorderColor = System.Drawing.Color.Black;
            this.btncreation.CheckedForeColor = System.Drawing.Color.White;
            this.btncreation.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btncreation.CheckedImage")));
            this.btncreation.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btncreation.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btncreation.FocusedColor = System.Drawing.Color.Empty;
            this.btncreation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncreation.ForeColor = System.Drawing.Color.White;
            this.btncreation.Image = null;
            this.btncreation.ImageSize = new System.Drawing.Size(20, 20);
            this.btncreation.LineColor = System.Drawing.Color.Blue;
            this.btncreation.Location = new System.Drawing.Point(52, 200);
            this.btncreation.Name = "btncreation";
            this.btncreation.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btncreation.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btncreation.OnHoverForeColor = System.Drawing.Color.White;
            this.btncreation.OnHoverImage = null;
            this.btncreation.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btncreation.OnPressedColor = System.Drawing.Color.Transparent;
            this.btncreation.Radius = 20;
            this.btncreation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btncreation.Size = new System.Drawing.Size(227, 42);
            this.btncreation.TabIndex = 2;
            this.btncreation.Text = "CREER UN COMPTE";
            this.btncreation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btncreation.Click += new System.EventHandler(this.btncreation_Click);
            // 
            // btnconnection
            // 
            this.btnconnection.AnimationHoverSpeed = 0.07F;
            this.btnconnection.AnimationSpeed = 0.03F;
            this.btnconnection.BackColor = System.Drawing.Color.Transparent;
            this.btnconnection.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnconnection.BorderColor = System.Drawing.Color.Black;
            this.btnconnection.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnconnection.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnconnection.CheckedForeColor = System.Drawing.Color.White;
            this.btnconnection.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnconnection.CheckedImage")));
            this.btnconnection.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnconnection.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnconnection.FocusedColor = System.Drawing.Color.Empty;
            this.btnconnection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnconnection.ForeColor = System.Drawing.Color.White;
            this.btnconnection.Image = null;
            this.btnconnection.ImageSize = new System.Drawing.Size(20, 20);
            this.btnconnection.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnconnection.Location = new System.Drawing.Point(52, 200);
            this.btnconnection.Name = "btnconnection";
            this.btnconnection.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnconnection.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnconnection.OnHoverForeColor = System.Drawing.Color.White;
            this.btnconnection.OnHoverImage = null;
            this.btnconnection.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnconnection.OnPressedColor = System.Drawing.Color.Black;
            this.btnconnection.Radius = 20;
            this.btnconnection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnconnection.Size = new System.Drawing.Size(227, 42);
            this.btnconnection.TabIndex = 1;
            this.btnconnection.Text = "SE CONNECTER";
            this.btnconnection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnconnection.Click += new System.EventHandler(this.btnconnection_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pnlgauche
            // 
            this.pnlgauche.Controls.Add(this.gunaAdvenceButton1);
            this.pnlgauche.Controls.Add(this.btnidentification);
            this.pnlgauche.Controls.Add(this.rdbrappel);
            this.pnlgauche.Controls.Add(this.txtmdp);
            this.pnlgauche.Controls.Add(this.txtnom);
            this.pnlgauche.Location = new System.Drawing.Point(58, 35);
            this.pnlgauche.Name = "pnlgauche";
            this.pnlgauche.Size = new System.Drawing.Size(606, 483);
            this.pnlgauche.TabIndex = 1;
            // 
            // rdbrappel
            // 
            this.rdbrappel.BaseColor = System.Drawing.SystemColors.Control;
            this.rdbrappel.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdbrappel.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdbrappel.FillColor = System.Drawing.Color.White;
            this.rdbrappel.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbrappel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rdbrappel.Location = new System.Drawing.Point(13, 276);
            this.rdbrappel.Name = "rdbrappel";
            this.rdbrappel.Size = new System.Drawing.Size(240, 27);
            this.rdbrappel.TabIndex = 4;
            this.rdbrappel.Text = "SE SEVENIR DE MOI";
            // 
            // txtmdp
            // 
            this.txtmdp.AcceptsReturn = false;
            this.txtmdp.AcceptsTab = false;
            this.txtmdp.AnimationSpeed = 200;
            this.txtmdp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtmdp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtmdp.AutoSizeHeight = true;
            this.txtmdp.BackColor = System.Drawing.SystemColors.Control;
            this.txtmdp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtmdp.BackgroundImage")));
            this.txtmdp.BorderColorActive = System.Drawing.Color.GreenYellow;
            this.txtmdp.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtmdp.BorderColorHover = System.Drawing.Color.GreenYellow;
            this.txtmdp.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtmdp.BorderRadius = 1;
            this.txtmdp.BorderThickness = 1;
            this.txtmdp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtmdp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmdp.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtmdp.DefaultText = "";
            this.txtmdp.FillColor = System.Drawing.SystemColors.Control;
            this.txtmdp.ForeColor = System.Drawing.Color.Black;
            this.txtmdp.HideSelection = true;
            this.txtmdp.IconLeft = null;
            this.txtmdp.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmdp.IconPadding = 10;
            this.txtmdp.IconRight = null;
            this.txtmdp.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmdp.Lines = new string[0];
            this.txtmdp.Location = new System.Drawing.Point(121, 181);
            this.txtmdp.MaxLength = 32767;
            this.txtmdp.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtmdp.Modified = false;
            this.txtmdp.Multiline = false;
            this.txtmdp.Name = "txtmdp";
            stateProperties1.BorderColor = System.Drawing.Color.GreenYellow;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtmdp.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtmdp.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.GreenYellow;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtmdp.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.SystemColors.Control;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtmdp.OnIdleState = stateProperties4;
            this.txtmdp.Padding = new System.Windows.Forms.Padding(3);
            this.txtmdp.PasswordChar = '\0';
            this.txtmdp.PlaceholderForeColor = System.Drawing.Color.Green;
            this.txtmdp.PlaceholderText = "Mot de passe";
            this.txtmdp.ReadOnly = false;
            this.txtmdp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtmdp.SelectedText = "";
            this.txtmdp.SelectionLength = 0;
            this.txtmdp.SelectionStart = 0;
            this.txtmdp.ShortcutsEnabled = true;
            this.txtmdp.Size = new System.Drawing.Size(327, 47);
            this.txtmdp.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtmdp.TabIndex = 3;
            this.txtmdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtmdp.TextMarginBottom = 0;
            this.txtmdp.TextMarginLeft = 3;
            this.txtmdp.TextMarginTop = 1;
            this.txtmdp.TextPlaceholder = "Mot de passe";
            this.txtmdp.UseSystemPasswordChar = false;
            this.txtmdp.WordWrap = true;
            // 
            // txtnom
            // 
            this.txtnom.AcceptsReturn = false;
            this.txtnom.AcceptsTab = false;
            this.txtnom.AnimationSpeed = 200;
            this.txtnom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtnom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtnom.AutoSizeHeight = true;
            this.txtnom.BackColor = System.Drawing.SystemColors.Control;
            this.txtnom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtnom.BackgroundImage")));
            this.txtnom.BorderColorActive = System.Drawing.Color.GreenYellow;
            this.txtnom.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtnom.BorderColorHover = System.Drawing.Color.GreenYellow;
            this.txtnom.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtnom.BorderRadius = 1;
            this.txtnom.BorderThickness = 1;
            this.txtnom.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtnom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnom.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtnom.DefaultText = "";
            this.txtnom.FillColor = System.Drawing.SystemColors.Control;
            this.txtnom.ForeColor = System.Drawing.Color.Black;
            this.txtnom.HideSelection = true;
            this.txtnom.IconLeft = null;
            this.txtnom.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnom.IconPadding = 10;
            this.txtnom.IconRight = null;
            this.txtnom.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnom.Lines = new string[0];
            this.txtnom.Location = new System.Drawing.Point(121, 87);
            this.txtnom.MaxLength = 32767;
            this.txtnom.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtnom.Modified = false;
            this.txtnom.Multiline = false;
            this.txtnom.Name = "txtnom";
            stateProperties5.BorderColor = System.Drawing.Color.GreenYellow;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtnom.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtnom.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.GreenYellow;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtnom.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.SystemColors.Control;
            stateProperties8.ForeColor = System.Drawing.Color.Black;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtnom.OnIdleState = stateProperties8;
            this.txtnom.Padding = new System.Windows.Forms.Padding(3);
            this.txtnom.PasswordChar = '\0';
            this.txtnom.PlaceholderForeColor = System.Drawing.Color.Green;
            this.txtnom.PlaceholderText = "Nom d\'utilisateur";
            this.txtnom.ReadOnly = false;
            this.txtnom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtnom.SelectedText = "";
            this.txtnom.SelectionLength = 0;
            this.txtnom.SelectionStart = 0;
            this.txtnom.ShortcutsEnabled = true;
            this.txtnom.Size = new System.Drawing.Size(327, 47);
            this.txtnom.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtnom.TabIndex = 2;
            this.txtnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnom.TextMarginBottom = 0;
            this.txtnom.TextMarginLeft = 3;
            this.txtnom.TextMarginTop = 1;
            this.txtnom.TextPlaceholder = "Nom d\'utilisateur";
            this.txtnom.UseSystemPasswordChar = false;
            this.txtnom.WordWrap = true;
            // 
            // btnidentification
            // 
            this.btnidentification.AnimationHoverSpeed = 0.07F;
            this.btnidentification.AnimationSpeed = 0.03F;
            this.btnidentification.BackColor = System.Drawing.Color.Transparent;
            this.btnidentification.BaseColor1 = System.Drawing.Color.Lime;
            this.btnidentification.BaseColor2 = System.Drawing.Color.OliveDrab;
            this.btnidentification.BorderColor = System.Drawing.Color.Black;
            this.btnidentification.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnidentification.FocusedColor = System.Drawing.Color.Empty;
            this.btnidentification.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnidentification.ForeColor = System.Drawing.Color.White;
            this.btnidentification.Image = null;
            this.btnidentification.ImageSize = new System.Drawing.Size(20, 20);
            this.btnidentification.Location = new System.Drawing.Point(121, 337);
            this.btnidentification.Name = "btnidentification";
            this.btnidentification.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnidentification.OnHoverBaseColor2 = System.Drawing.Color.Green;
            this.btnidentification.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnidentification.OnHoverForeColor = System.Drawing.Color.White;
            this.btnidentification.OnHoverImage = null;
            this.btnidentification.OnPressedColor = System.Drawing.Color.Black;
            this.btnidentification.Radius = 10;
            this.btnidentification.Size = new System.Drawing.Size(327, 41);
            this.btnidentification.TabIndex = 5;
            this.btnidentification.Text = "S\'IDENTIFIER";
            this.btnidentification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Beige;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.Blue;
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(330, 276);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.DarkRed;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.Radius = 20;
            this.gunaAdvenceButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(264, 22);
            this.gunaAdvenceButton1.TabIndex = 3;
            this.gunaAdvenceButton1.Text = "MOT DE PASSE OUBLIE ?";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 551);
            this.Controls.Add(this.pnlgauche);
            this.Controls.Add(this.pnldroite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnldroite.ResumeLayout(false);
            this.pnlgauche.ResumeLayout(false);
            this.pnlgauche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnldroite;
        private Guna.UI.WinForms.GunaAdvenceButton btncreation;
        private Guna.UI.WinForms.GunaAdvenceButton btnconnection;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel pnlgauche;
        private Bunifu.UI.WinForms.BunifuTextBox txtnom;
        private Bunifu.UI.WinForms.BunifuTextBox txtmdp;
        private Guna.UI.WinForms.GunaRadioButton rdbrappel;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaGradientButton btnidentification;
    }
}

