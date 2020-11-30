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
            this.flowMain = new System.Windows.Forms.FlowLayoutPanel();
            this.flowUp = new System.Windows.Forms.FlowLayoutPanel();
            this.flowDown = new System.Windows.Forms.FlowLayoutPanel();
            this.flowMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowMain
            // 
            this.flowMain.Controls.Add(this.flowUp);
            this.flowMain.Controls.Add(this.flowDown);
            this.flowMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMain.Location = new System.Drawing.Point(0, 0);
            this.flowMain.Name = "flowMain";
            this.flowMain.Size = new System.Drawing.Size(818, 571);
            this.flowMain.TabIndex = 0;
            // 
            // flowUp
            // 
            this.flowUp.AutoSize = true;
            this.flowUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowUp.Location = new System.Drawing.Point(3, 3);
            this.flowUp.Name = "flowUp";
            this.flowUp.Size = new System.Drawing.Size(0, 0);
            this.flowUp.TabIndex = 0;
            // 
            // flowDown
            // 
            this.flowDown.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowDown.Location = new System.Drawing.Point(3, 9);
            this.flowDown.Name = "flowDown";
            this.flowDown.Size = new System.Drawing.Size(803, 213);
            this.flowDown.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 571);
            this.Controls.Add(this.flowMain);
            this.Name = "Form1";
            this.Text = "Euromilhoes";
            this.flowMain.ResumeLayout(false);
            this.flowMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// Cria os containers com os numeros e estrelas
        /// </summary>
        private void InitializeContainers()
        {
            for(int i = 1; i <= 5; i++)
            {
                var Container = new System.Windows.Forms.FlowLayoutPanel();
                Container.Name = $"Container{i}";
                Container.AutoSize = true;
                Container.BackColor = System.Drawing.Color.Red;
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
                var Button = new System.Windows.Forms.Button();
                Button.Name = $"btnPrincipal{i}";
                Button.Text = $"{i}";
                Button.Width = 30;

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
                var Button = new System.Windows.Forms.Button();
                Button.Name = $"btnEstrela{i}";
                Button.Text = $"{i}";

                Button.Click += BtnEstrela_Click;
                Container.Controls.Add(Button);
            }

            return Container;
        }

        private System.Windows.Forms.FlowLayoutPanel flowMain;
        private System.Windows.Forms.FlowLayoutPanel flowUp;
        private System.Windows.Forms.FlowLayoutPanel flowDown;
    }
}

