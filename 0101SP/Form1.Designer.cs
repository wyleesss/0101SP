using System.Diagnostics;

namespace _0101SP
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            openButton = new Button();
            closeButton = new Button();
            timeLabel = new Label();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // openButton
            // 
            openButton.BackColor = SystemColors.ControlLightLight;
            openButton.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            openButton.Location = new Point(148, 99);
            openButton.Name = "openButton";
            openButton.Size = new Size(219, 60);
            openButton.TabIndex = 0;
            openButton.Text = "Open Notebook";
            openButton.UseVisualStyleBackColor = false;
            openButton.Click += openButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = SystemColors.ControlLightLight;
            closeButton.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.Location = new Point(148, 182);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(219, 60);
            closeButton.TabIndex = 1;
            closeButton.Text = "Close Notebook";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Yu Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(173, 30);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(168, 47);
            timeLabel.TabIndex = 2;
            timeLabel.Text = "00:00:00";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timerTick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 270);
            Controls.Add(timeLabel);
            Controls.Add(closeButton);
            Controls.Add(openButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Systems Programming";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openButton;
        private Button closeButton;
        private Label timeLabel;
        private System.Windows.Forms.Timer timer;
    }
}