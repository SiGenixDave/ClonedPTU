#region --- Revision History ---
/*
 * 
 *  This document and its contents are the property of Bombardier Inc. or its subsidiaries and contains confidential, proprietary information.
 *  The reproduction, distribution, utilization or the communication of this document, or any part thereof, without express authorization is strictly prohibited.  
 *  Offenders will be held liable for the payment of damages.
 * 
 *  (C) 2018    Bombardier Inc. or its subsidiaries. All rights reserved.
 * 
 *  Solution:   PTU
 * 
 *  Project:    PTU Application
 * 
 *  File name:  FormCarId.Designer.cs
 * 
 *  Revision History
 *  ----------------
 * 
 *  Date        Version Author          Comments
 *  02/21/2018    1.0     Vgottam      First Release.
 *
 */
#endregion --- Revision History ---
namespace Bombardier.PTU.Forms
{
    partial class FormCarId
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarId));
            this.m_ButtonOK = new System.Windows.Forms.Button();
            this.m_ButtonCancel = new System.Windows.Forms.Button();
            this.m_PanelOuter = new System.Windows.Forms.Panel();
            this.m_GroupBoxConfigureCarID = new System.Windows.Forms.GroupBox();
            this.m_TableLayoutPanelCarID = new System.Windows.Forms.TableLayoutPanel();
            this.m_LableCarID = new System.Windows.Forms.Label();
            this.m_TextBoxCarID = new System.Windows.Forms.TextBox();
            this.m_PanelOuter.SuspendLayout();
            this.m_GroupBoxConfigureCarID.SuspendLayout();
            this.m_TableLayoutPanelCarID.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_ButtonOK
            // 
            this.m_ButtonOK.Location = new System.Drawing.Point(156, 108);
            this.m_ButtonOK.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.m_ButtonOK.Name = "m_ButtonOK";
            this.m_ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.m_ButtonOK.TabIndex = 3;
            this.m_ButtonOK.Text = "OK";
            this.m_ButtonOK.UseVisualStyleBackColor = true;
            this.m_ButtonOK.Click += new System.EventHandler(this.m_ButtonOK_Click);
            // 
            // m_ButtonCancel
            // 
            this.m_ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_ButtonCancel.Location = new System.Drawing.Point(237, 108);
            this.m_ButtonCancel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.m_ButtonCancel.Name = "m_ButtonCancel";
            this.m_ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.m_ButtonCancel.TabIndex = 2;
            this.m_ButtonCancel.TabStop = false;
            this.m_ButtonCancel.Text = "Cancel";
            this.m_ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // m_PanelOuter
            // 
            this.m_PanelOuter.BackColor = System.Drawing.SystemColors.Window;
            this.m_PanelOuter.Controls.Add(this.m_GroupBoxConfigureCarID);
            this.m_PanelOuter.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_PanelOuter.Location = new System.Drawing.Point(0, 0);
            this.m_PanelOuter.Name = "m_PanelOuter";
            this.m_PanelOuter.Padding = new System.Windows.Forms.Padding(10, 10, 10, 12);
            this.m_PanelOuter.Size = new System.Drawing.Size(326, 97);
            this.m_PanelOuter.TabIndex = 4;
            this.m_PanelOuter.TabStop = true;
            // 
            // m_GroupBoxConfigureCarID
            // 
            this.m_GroupBoxConfigureCarID.Controls.Add(this.m_TableLayoutPanelCarID);
            this.m_GroupBoxConfigureCarID.Location = new System.Drawing.Point(7, 4);
            this.m_GroupBoxConfigureCarID.Name = "m_GroupBoxConfigureCarID";
            this.m_GroupBoxConfigureCarID.Size = new System.Drawing.Size(314, 86);
            this.m_GroupBoxConfigureCarID.TabIndex = 1;
            this.m_GroupBoxConfigureCarID.TabStop = false;
            // 
            // m_TableLayoutPanelCarID
            // 
            this.m_TableLayoutPanelCarID.AutoSize = true;
            this.m_TableLayoutPanelCarID.ColumnCount = 2;
            this.m_TableLayoutPanelCarID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.m_TableLayoutPanelCarID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.m_TableLayoutPanelCarID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.m_TableLayoutPanelCarID.Controls.Add(this.m_LableCarID, 0, 0);
            this.m_TableLayoutPanelCarID.Controls.Add(this.m_TextBoxCarID, 1, 0);
            this.m_TableLayoutPanelCarID.Location = new System.Drawing.Point(87, 21);
            this.m_TableLayoutPanelCarID.Name = "m_TableLayoutPanelCarID";
            this.m_TableLayoutPanelCarID.RowCount = 1;
            this.m_TableLayoutPanelCarID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.m_TableLayoutPanelCarID.Size = new System.Drawing.Size(135, 48);
            this.m_TableLayoutPanelCarID.TabIndex = 2;
            this.m_TableLayoutPanelCarID.TabStop = true;
            // 
            // m_LableCarID
            // 
            this.m_LableCarID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_LableCarID.AutoSize = true;
            this.m_LableCarID.Location = new System.Drawing.Point(3, 17);
            this.m_LableCarID.Name = "m_LableCarID";
            this.m_LableCarID.Size = new System.Drawing.Size(40, 13);
            this.m_LableCarID.TabIndex = 0;
            this.m_LableCarID.Text = "Car ID:";
            // 
            // m_TextBoxCarID
            // 
            this.m_TextBoxCarID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.m_TextBoxCarID.Location = new System.Drawing.Point(50, 14);
            this.m_TextBoxCarID.MaxLength = 11;
            this.m_TextBoxCarID.Name = "m_TextBoxCarID";
            this.m_TextBoxCarID.Size = new System.Drawing.Size(78, 20);
            this.m_TextBoxCarID.TabIndex = 1;
            this.m_TextBoxCarID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_TextBoxCarID_KeyPress);
            // 
            // FormCarId
            // 
            this.AcceptButton = this.m_ButtonOK;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.m_ButtonCancel;
            this.ClientSize = new System.Drawing.Size(326, 143);
            this.Controls.Add(this.m_PanelOuter);
            this.Controls.Add(this.m_ButtonOK);
            this.Controls.Add(this.m_ButtonCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCarId";
            this.Text = "Configure Car Identification Number";
            this.m_PanelOuter.ResumeLayout(false);
            this.m_GroupBoxConfigureCarID.ResumeLayout(false);
            this.m_GroupBoxConfigureCarID.PerformLayout();
            this.m_TableLayoutPanelCarID.ResumeLayout(false);
            this.m_TableLayoutPanelCarID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_ButtonOK;
        private System.Windows.Forms.Button m_ButtonCancel;
        private System.Windows.Forms.Panel m_PanelOuter;
        private System.Windows.Forms.GroupBox m_GroupBoxConfigureCarID;
        private System.Windows.Forms.TableLayoutPanel m_TableLayoutPanelCarID;
        private System.Windows.Forms.Label m_LableCarID;
        private System.Windows.Forms.TextBox m_TextBoxCarID;
    }
}