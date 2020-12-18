namespace FinalTermAssignment
{
    partial class DeleteEvent
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
            this.deleteDataGridView = new System.Windows.Forms.DataGridView();
            this.delete_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eventIdtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.deleteDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteDataGridView
            // 
            this.deleteDataGridView.AllowUserToAddRows = false;
            this.deleteDataGridView.AllowUserToDeleteRows = false;
            this.deleteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteDataGridView.Location = new System.Drawing.Point(631, 42);
            this.deleteDataGridView.Name = "deleteDataGridView";
            this.deleteDataGridView.ReadOnly = true;
            this.deleteDataGridView.RowHeadersWidth = 51;
            this.deleteDataGridView.RowTemplate.Height = 24;
            this.deleteDataGridView.Size = new System.Drawing.Size(728, 304);
            this.deleteDataGridView.TabIndex = 7;
            this.deleteDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // delete_Button
            // 
            this.delete_Button.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_Button.Location = new System.Drawing.Point(153, 164);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(309, 43);
            this.delete_Button.TabIndex = 15;
            this.delete_Button.Text = "Delete";
            this.delete_Button.UseVisualStyleBackColor = true;
            this.delete_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eventIdtextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.delete_Button);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 254);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Event";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Event Id";
            // 
            // eventIdtextBox
            // 
            this.eventIdtextBox.Location = new System.Drawing.Point(153, 85);
            this.eventIdtextBox.Name = "eventIdtextBox";
            this.eventIdtextBox.Size = new System.Drawing.Size(309, 29);
            this.eventIdtextBox.TabIndex = 17;
            // 
            // DeleteEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 406);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteDataGridView);
            this.Name = "DeleteEvent";
            this.Text = "DeleteEvent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteEvent_FormClosing);
            this.Load += new System.EventHandler(this.DeleteEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deleteDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView deleteDataGridView;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox eventIdtextBox;
        private System.Windows.Forms.Label label1;
    }
}