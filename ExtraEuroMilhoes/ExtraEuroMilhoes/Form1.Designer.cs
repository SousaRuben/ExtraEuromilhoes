namespace ExtraEuroMilhoes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowMain = new System.Windows.Forms.FlowLayoutPanel();
            this.flowUp = new System.Windows.Forms.FlowLayoutPanel();
            this.flowOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.grpSorteio = new System.Windows.Forms.GroupBox();
            this.btnSexta = new System.Windows.Forms.RadioButton();
            this.btnTerca = new System.Windows.Forms.RadioButton();
            this.btnAmbos = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnApostar = new System.Windows.Forms.Button();
            this.flowMain.SuspendLayout();
            this.flowOptions.SuspendLayout();
            this.grpSorteio.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowMain
            // 
            this.flowMain.AutoSize = true;
            this.flowMain.Controls.Add(this.flowUp);
            this.flowMain.Controls.Add(this.flowOptions);
            this.flowMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMain.Location = new System.Drawing.Point(0, 0);
            this.flowMain.Name = "flowMain";
            this.flowMain.Size = new System.Drawing.Size(815, 571);
            this.flowMain.TabIndex = 0;
            // 
            // flowUp
            // 
            this.flowUp.AutoScroll = true;
            this.flowUp.AutoSize = true;
            this.flowUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowUp.Location = new System.Drawing.Point(3, 3);
            this.flowUp.MinimumSize = new System.Drawing.Size(500, 200);
            this.flowUp.Name = "flowUp";
            this.flowUp.Size = new System.Drawing.Size(500, 200);
            this.flowUp.TabIndex = 0;
            this.flowUp.WrapContents = false;
            // 
            // flowOptions
            // 
            this.flowOptions.AutoSize = true;
            this.flowOptions.Controls.Add(this.grpSorteio);
            this.flowOptions.Controls.Add(this.flowLayoutPanel1);
            this.flowOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowOptions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowOptions.Location = new System.Drawing.Point(3, 209);
            this.flowOptions.MinimumSize = new System.Drawing.Size(50, 50);
            this.flowOptions.Name = "flowOptions";
            this.flowOptions.Size = new System.Drawing.Size(500, 126);
            this.flowOptions.TabIndex = 2;
            // 
            // grpSorteio
            // 
            this.grpSorteio.AutoSize = true;
            this.grpSorteio.Controls.Add(this.btnSexta);
            this.grpSorteio.Controls.Add(this.btnTerca);
            this.grpSorteio.Controls.Add(this.btnAmbos);
            this.grpSorteio.Location = new System.Drawing.Point(382, 3);
            this.grpSorteio.Name = "grpSorteio";
            this.grpSorteio.Size = new System.Drawing.Size(115, 120);
            this.grpSorteio.TabIndex = 0;
            this.grpSorteio.TabStop = false;
            this.grpSorteio.Text = "Sorteios";
            // 
            // btnSexta
            // 
            this.btnSexta.AutoSize = true;
            this.btnSexta.Location = new System.Drawing.Point(6, 78);
            this.btnSexta.Name = "btnSexta";
            this.btnSexta.Size = new System.Drawing.Size(101, 21);
            this.btnSexta.TabIndex = 2;
            this.btnSexta.Text = "Sexta-Feira";
            this.btnSexta.UseVisualStyleBackColor = true;
            this.btnSexta.CheckedChanged += setSorteio;
            // 
            // btnTerca
            // 
            this.btnTerca.AutoSize = true;
            this.btnTerca.Location = new System.Drawing.Point(6, 51);
            this.btnTerca.Name = "btnTerca";
            this.btnTerca.Size = new System.Drawing.Size(103, 21);
            this.btnTerca.TabIndex = 1;
            this.btnTerca.Text = "Terça-Feira";
            this.btnTerca.UseVisualStyleBackColor = true;
            this.btnTerca.CheckedChanged += setSorteio;
            // 
            // btnAmbos
            // 
            this.btnAmbos.AutoSize = true;
            this.btnAmbos.Checked = true;
            this.btnAmbos.Location = new System.Drawing.Point(6, 25);
            this.btnAmbos.Name = "btnAmbos";
            this.btnAmbos.Size = new System.Drawing.Size(72, 21);
            this.btnAmbos.TabIndex = 0;
            this.btnAmbos.TabStop = true;
            this.btnAmbos.Text = "Ambos";
            this.btnAmbos.UseVisualStyleBackColor = true;
            this.btnAmbos.CheckedChanged += setSorteio;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.lblValor);
            this.flowLayoutPanel1.Controls.Add(this.btnApostar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(215, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(161, 76);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(3, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(155, 25);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor da aposta:";
            // 
            // btnApostar
            // 
            this.btnApostar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApostar.Location = new System.Drawing.Point(3, 28);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(155, 45);
            this.btnApostar.TabIndex = 0;
            this.btnApostar.Text = "Apostar Já";
            this.btnApostar.UseVisualStyleBackColor = true;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(815, 571);
            this.Controls.Add(this.flowMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Euromilhoes";
            this.flowMain.ResumeLayout(false);
            this.flowMain.PerformLayout();
            this.flowOptions.ResumeLayout(false);
            this.flowOptions.PerformLayout();
            this.grpSorteio.ResumeLayout(false);
            this.grpSorteio.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// Cria os containers com os numeros e estrelas
        /// </summary>
        private void InitializeContainers()
        {
            for(int i = 1; i <= 5; i++)
            {
                var Container = new ExtraEuroMilhoes.Aposta();
                Container.Name = $"Container{i}";
                Container.AutoSize = true;

                Container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                Container.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;

                var Principais = ContainerPrincipais();
                Principais.Name = $"ContainerPrincipais{i}";
                Container.Controls.Add(Principais);


                var Estrelas = ContainerEstrelas();
                Estrelas.Name = $"ContainerEstrelas{i}";
                Container.Controls.Add(Estrelas);

                flowUp.Controls.Add(Container);
            }
        }

        /// <summary>
        /// Cria um container com os 50 numeros principais
        /// </summary>
        private System.Windows.Forms.TableLayoutPanel ContainerPrincipais()
        {
            var Container = new System.Windows.Forms.TableLayoutPanel();
            Container.ColumnCount = 6;
            Container.AutoSize = true;

            for(int i = 1; i <= 50; i++)
            {
                var Button = new ExtraEuroMilhoes.EuroButton();
                Button.Name = $"btnPrincipal{i}";
                Button.Text = $"{i}";
                Button.Width = 30;

                Button.ForeColor = System.Drawing.Color.Red;
                Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                Button.FlatAppearance.BorderColor = System.Drawing.Color.Red;

                Button.Click += BtnPrincipal_Click;
                Container.Controls.Add(Button);
            }

            return Container;
        }

        /// <summary>
        /// Cria um container com as estrelas da sorte
        /// </summary>
        private System.Windows.Forms.TableLayoutPanel ContainerEstrelas()
        {
            var Container = new System.Windows.Forms.TableLayoutPanel();
            Container.ColumnCount = 3;
            Container.AutoSize = true;

            for (int i = 1; i <= 12; i++)
            {
                var Button = new ExtraEuroMilhoes.EuroButton();
                Button.Name = $"btnEstrela{i}";
                Button.Text = $"{i}";

                Button.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);

                Button.BackColor = System.Drawing.Color.Transparent;
                Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                Button.FlatAppearance.BorderSize = 0;

                Button.BackgroundImage = ExtraEuroMilhoes.Properties.Resources.star;
                Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;

                Button.Size = Button.BackgroundImage.Size;

                Button.Click += BtnEstrela_Click;
                Container.Controls.Add(Button);
            }

            return Container;
        }

        private System.Windows.Forms.FlowLayoutPanel flowMain;
        private System.Windows.Forms.FlowLayoutPanel flowUp;
        private System.Windows.Forms.FlowLayoutPanel flowOptions;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.GroupBox grpSorteio;
        private System.Windows.Forms.RadioButton btnSexta;
        private System.Windows.Forms.RadioButton btnTerca;
        private System.Windows.Forms.RadioButton btnAmbos;
    }
}

