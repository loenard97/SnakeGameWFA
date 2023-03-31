namespace SnakeWFA
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.labelScoreName = new System.Windows.Forms.Label();
            this.labelScoreValue = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.Gray;
            this.pbCanvas.Location = new System.Drawing.Point(13, 13);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(480, 480);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateGraphics);
            // 
            // labelScoreName
            // 
            this.labelScoreName.AutoSize = true;
            this.labelScoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreName.Location = new System.Drawing.Point(608, 41);
            this.labelScoreName.Name = "labelScoreName";
            this.labelScoreName.Size = new System.Drawing.Size(71, 24);
            this.labelScoreName.TabIndex = 1;
            this.labelScoreName.Text = "Score:";
            // 
            // labelScoreValue
            // 
            this.labelScoreValue.AutoSize = true;
            this.labelScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreValue.Location = new System.Drawing.Point(685, 41);
            this.labelScoreValue.Name = "labelScoreValue";
            this.labelScoreValue.Size = new System.Drawing.Size(32, 24);
            this.labelScoreValue.TabIndex = 2;
            this.labelScoreValue.Text = "00";
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BackColor = System.Drawing.Color.Black;
            this.labelGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.ForeColor = System.Drawing.Color.Yellow;
            this.labelGameOver.Location = new System.Drawing.Point(215, 226);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(161, 24);
            this.labelGameOver.TabIndex = 3;
            this.labelGameOver.Text = "LabelGameOver";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 505);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.labelScoreValue);
            this.Controls.Add(this.labelScoreName);
            this.Controls.Add(this.pbCanvas);
            this.Name = "MainForm";
            this.Text = "Snake Game WFA";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label labelScoreName;
        private System.Windows.Forms.Label labelScoreValue;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Timer gameTimer;
    }
}

