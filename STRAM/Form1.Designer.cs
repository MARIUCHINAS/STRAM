namespace STRAM
{
    partial class STRAM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STRAM));
            pictureBox_STRAM = new PictureBox();
            label_GameID = new Label();
            label_WorkshopID = new Label();
            textBox_GameID = new TextBox();
            textBox_WorkshopID = new TextBox();
            richTextBox_Input = new RichTextBox();
            button_Download = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_STRAM).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_STRAM
            // 
            pictureBox_STRAM.Image = Properties.Resources.STRAM__Custom_;
            pictureBox_STRAM.Location = new Point(407, 11);
            pictureBox_STRAM.Name = "pictureBox_STRAM";
            pictureBox_STRAM.Size = new Size(128, 128);
            pictureBox_STRAM.TabIndex = 0;
            pictureBox_STRAM.TabStop = false;
            // 
            // label_GameID
            // 
            label_GameID.AutoSize = true;
            label_GameID.Font = new Font("Verdana Pro Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label_GameID.Location = new Point(12, 12);
            label_GameID.Name = "label_GameID";
            label_GameID.Size = new Size(91, 20);
            label_GameID.TabIndex = 1;
            label_GameID.Text = "Game id:";
            // 
            // label_WorkshopID
            // 
            label_WorkshopID.AutoSize = true;
            label_WorkshopID.Font = new Font("Verdana Pro Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label_WorkshopID.Location = new Point(12, 44);
            label_WorkshopID.Name = "label_WorkshopID";
            label_WorkshopID.Size = new Size(129, 20);
            label_WorkshopID.TabIndex = 2;
            label_WorkshopID.Text = "Workshop id:";
            // 
            // textBox_GameID
            // 
            textBox_GameID.Location = new Point(109, 11);
            textBox_GameID.Name = "textBox_GameID";
            textBox_GameID.Size = new Size(203, 26);
            textBox_GameID.TabIndex = 3;
            textBox_GameID.TextChanged += textBox_GameID_TextChanged;
            // 
            // textBox_WorkshopID
            // 
            textBox_WorkshopID.Location = new Point(147, 44);
            textBox_WorkshopID.Name = "textBox_WorkshopID";
            textBox_WorkshopID.Size = new Size(165, 26);
            textBox_WorkshopID.TabIndex = 4;
            textBox_WorkshopID.TextChanged += textBox_WorkshopID_TextChanged;
            // 
            // richTextBox_Input
            // 
            richTextBox_Input.Location = new Point(12, 76);
            richTextBox_Input.Name = "richTextBox_Input";
            richTextBox_Input.Size = new Size(386, 176);
            richTextBox_Input.TabIndex = 5;
            richTextBox_Input.Text = "";
            // 
            // button_Download
            // 
            button_Download.Font = new Font("Verdana Pro Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Download.ForeColor = Color.FromArgb(179, 112, 176);
            button_Download.Location = new Point(12, 258);
            button_Download.Name = "button_Download";
            button_Download.Size = new Size(105, 32);
            button_Download.TabIndex = 6;
            button_Download.Text = "Download";
            button_Download.UseVisualStyleBackColor = true;
            button_Download.Click += button_Download_Click;
            // 
            // STRAM
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(135, 37, 91);
            ClientSize = new Size(547, 301);
            Controls.Add(button_Download);
            Controls.Add(richTextBox_Input);
            Controls.Add(textBox_WorkshopID);
            Controls.Add(textBox_GameID);
            Controls.Add(label_WorkshopID);
            Controls.Add(label_GameID);
            Controls.Add(pictureBox_STRAM);
            Font = new Font("Verdana Pro Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(195, 195, 230);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "STRAM";
            Text = "STRAM";
            Load += STRAM_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_STRAM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_STRAM;
        private Label label_GameID;
        private Label label_WorkshopID;
        private TextBox textBox_GameID;
        private TextBox textBox_WorkshopID;
        private RichTextBox richTextBox_Input;
        private Button button_Download;
    }
}