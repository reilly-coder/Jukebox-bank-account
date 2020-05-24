namespace HNDunit20
{
    partial class frmBehavioural
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
            this.btnCollection = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnIterate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCollection
            // 
            this.btnCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollection.Location = new System.Drawing.Point(26, 12);
            this.btnCollection.Name = "btnCollection";
            this.btnCollection.Size = new System.Drawing.Size(118, 45);
            this.btnCollection.TabIndex = 0;
            this.btnCollection.Text = "Collection";
            this.btnCollection.UseVisualStyleBackColor = true;
            this.btnCollection.Click += new System.EventHandler(this.btnCollection_Click);
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(157, 69);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(110, 32);
            this.txtData.TabIndex = 1;
            // 
            // nudMinutes
            // 
            this.nudMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinutes.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMinutes.Location = new System.Drawing.Point(301, 70);
            this.nudMinutes.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudMinutes.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(73, 32);
            this.nudMinutes.TabIndex = 2;
            this.nudMinutes.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(164, 139);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(99, 26);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "lblOutput";
            // 
            // btnPush
            // 
            this.btnPush.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPush.Location = new System.Drawing.Point(26, 69);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(118, 45);
            this.btnPush.TabIndex = 4;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnIterate
            // 
            this.btnIterate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIterate.Location = new System.Drawing.Point(26, 129);
            this.btnIterate.Name = "btnIterate";
            this.btnIterate.Size = new System.Drawing.Size(118, 45);
            this.btnIterate.TabIndex = 5;
            this.btnIterate.Text = "Iterate";
            this.btnIterate.UseVisualStyleBackColor = true;
            this.btnIterate.Click += new System.EventHandler(this.btnIterate_Click);
            // 
            // frmBehavioural
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 505);
            this.Controls.Add(this.btnIterate);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.nudMinutes);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnCollection);
            this.Name = "frmBehavioural";
            this.Text = "frmBehavioural";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCollection;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnIterate;
    }
}