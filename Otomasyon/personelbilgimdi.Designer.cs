﻿namespace Otomasyon
{
    partial class personelbilgimdi
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
            this.gridcontrolpersonelinfo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontrolpersonelinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridcontrolpersonelinfo
            // 
            this.gridcontrolpersonelinfo.Location = new System.Drawing.Point(-7, -2);
            this.gridcontrolpersonelinfo.MainView = this.gridView1;
            this.gridcontrolpersonelinfo.Name = "gridcontrolpersonelinfo";
            this.gridcontrolpersonelinfo.Size = new System.Drawing.Size(1225, 644);
            this.gridcontrolpersonelinfo.TabIndex = 0;
            this.gridcontrolpersonelinfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridcontrolpersonelinfo;
            this.gridView1.Name = "gridView1";
            // 
            // personelbilgimdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 645);
            this.Controls.Add(this.gridcontrolpersonelinfo);
            this.Name = "personelbilgimdi";
            this.Text = "personelbilgimdi";
            this.Load += new System.EventHandler(this.personelbilgimdi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontrolpersonelinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridcontrolpersonelinfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}