namespace WindowsFormsApp1
{
    partial class frmMass
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtn = new System.Windows.Forms.TextBox();
            this.txtm = new System.Windows.Forms.TextBox();
            this.txtRez = new System.Windows.Forms.TextBox();
            this.dgvMass = new System.Windows.Forms.DataGridView();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество строк n=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество столбцов m=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Результат:";
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(16, 43);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(198, 26);
            this.txtn.TabIndex = 3;
            this.txtn.TextChanged += new System.EventHandler(this.txtn_TextChanged);
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(16, 105);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(198, 26);
            this.txtm.TabIndex = 4;
            this.txtm.TextChanged += new System.EventHandler(this.txtm_TextChanged);
            // 
            // txtRez
            // 
            this.txtRez.Location = new System.Drawing.Point(12, 169);
            this.txtRez.Multiline = true;
            this.txtRez.Name = "txtRez";
            this.txtRez.Size = new System.Drawing.Size(273, 201);
            this.txtRez.TabIndex = 5;
            // 
            // dgvMass
            // 
            this.dgvMass.AllowUserToOrderColumns = true;
            this.dgvMass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMass.Location = new System.Drawing.Point(291, 20);
            this.dgvMass.Name = "dgvMass";
            this.dgvMass.Size = new System.Drawing.Size(391, 350);
            this.dgvMass.TabIndex = 6;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(16, 393);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(141, 32);
            this.cmdStart.TabIndex = 7;
            this.cmdStart.Text = "Вычислить";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(499, 393);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(183, 32);
            this.cmdExit.TabIndex = 8;
            this.cmdExit.Text = "Завершить работу";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(232, 393);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(205, 32);
            this.cmdClear.TabIndex = 9;
            this.cmdClear.Text = "Очистка полей";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // frmMass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 453);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.dgvMass);
            this.Controls.Add(this.txtRez);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMass";
            this.Text = "Двумерные массивы";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.TextBox txtRez;
        private System.Windows.Forms.DataGridView dgvMass;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdClear;
    }
}

