namespace Buses
{
    partial class NewBus
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
            this.gbAddNewBus = new System.Windows.Forms.GroupBox();
            this.lblLocalBus = new System.Windows.Forms.Label();
            this.cbIsLocal = new System.Windows.Forms.CheckBox();
            this.tbBusRegistration = new System.Windows.Forms.TextBox();
            this.lblBusRegistration = new System.Windows.Forms.Label();
            this.tbBusName = new System.Windows.Forms.TextBox();
            this.lblBusName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAddNewBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddNewBus
            // 
            this.gbAddNewBus.Controls.Add(this.btnCancel);
            this.gbAddNewBus.Controls.Add(this.btnSave);
            this.gbAddNewBus.Controls.Add(this.lblLocalBus);
            this.gbAddNewBus.Controls.Add(this.cbIsLocal);
            this.gbAddNewBus.Controls.Add(this.tbBusRegistration);
            this.gbAddNewBus.Controls.Add(this.lblBusRegistration);
            this.gbAddNewBus.Controls.Add(this.tbBusName);
            this.gbAddNewBus.Controls.Add(this.lblBusName);
            this.gbAddNewBus.Location = new System.Drawing.Point(12, 12);
            this.gbAddNewBus.Name = "gbAddNewBus";
            this.gbAddNewBus.Size = new System.Drawing.Size(361, 236);
            this.gbAddNewBus.TabIndex = 0;
            this.gbAddNewBus.TabStop = false;
            this.gbAddNewBus.Text = "Додади автобус";
            // 
            // lblLocalBus
            // 
            this.lblLocalBus.AutoSize = true;
            this.lblLocalBus.Location = new System.Drawing.Point(15, 134);
            this.lblLocalBus.Name = "lblLocalBus";
            this.lblLocalBus.Size = new System.Drawing.Size(63, 16);
            this.lblLocalBus.TabIndex = 5;
            this.lblLocalBus.Text = "Локален";
            // 
            // cbIsLocal
            // 
            this.cbIsLocal.AutoSize = true;
            this.cbIsLocal.Location = new System.Drawing.Point(18, 153);
            this.cbIsLocal.Name = "cbIsLocal";
            this.cbIsLocal.Size = new System.Drawing.Size(138, 20);
            this.cbIsLocal.TabIndex = 4;
            this.cbIsLocal.Text = "Дали е локален?";
            this.cbIsLocal.UseVisualStyleBackColor = true;
            // 
            // tbBusRegistration
            // 
            this.tbBusRegistration.Location = new System.Drawing.Point(18, 92);
            this.tbBusRegistration.Name = "tbBusRegistration";
            this.tbBusRegistration.Size = new System.Drawing.Size(307, 22);
            this.tbBusRegistration.TabIndex = 3;
            this.tbBusRegistration.Validating += new System.ComponentModel.CancelEventHandler(this.tbBusRegistration_Validating);
            // 
            // lblBusRegistration
            // 
            this.lblBusRegistration.AutoSize = true;
            this.lblBusRegistration.Location = new System.Drawing.Point(15, 73);
            this.lblBusRegistration.Name = "lblBusRegistration";
            this.lblBusRegistration.Size = new System.Drawing.Size(95, 16);
            this.lblBusRegistration.TabIndex = 2;
            this.lblBusRegistration.Text = "Регистрација";
            // 
            // tbBusName
            // 
            this.tbBusName.Location = new System.Drawing.Point(18, 48);
            this.tbBusName.Name = "tbBusName";
            this.tbBusName.Size = new System.Drawing.Size(307, 22);
            this.tbBusName.TabIndex = 1;
            this.tbBusName.Validating += new System.ComponentModel.CancelEventHandler(this.tbBusName_Validating);
            // 
            // lblBusName
            // 
            this.lblBusName.AutoSize = true;
            this.lblBusName.Location = new System.Drawing.Point(15, 28);
            this.lblBusName.Name = "lblBusName";
            this.lblBusName.Size = new System.Drawing.Size(34, 16);
            this.lblBusName.TabIndex = 0;
            this.lblBusName.Text = "Име";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 191);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 25);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Зачувај";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(185, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 25);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NewBus
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(385, 260);
            this.Controls.Add(this.gbAddNewBus);
            this.Name = "NewBus";
            this.Text = "Нов автобус";
            this.gbAddNewBus.ResumeLayout(false);
            this.gbAddNewBus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddNewBus;
        private System.Windows.Forms.CheckBox cbIsLocal;
        private System.Windows.Forms.TextBox tbBusRegistration;
        private System.Windows.Forms.Label lblBusRegistration;
        private System.Windows.Forms.TextBox tbBusName;
        private System.Windows.Forms.Label lblBusName;
        private System.Windows.Forms.Label lblLocalBus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}