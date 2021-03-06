#region --- Revision History ---
/*
 * 
 *  This document and its contents are the property of Bombardier Inc. or its subsidiaries and contains confidential, proprietary information.
 *  The reproduction, distribution, utilization or the communication of this document, or any part thereof, without express authorization is strictly prohibited.  
 *  Offenders will be held liable for the payment of damages.
 * 
 *  (C) 2010    Bombardier Inc. or its subsidiaries. All rights reserved.
 * 
 *  Solution:   Portable Test Unit
 * 
 *  Project:    Common
 * 
 *  File name:  WatchControl.Designer.cs
 * 
 *  Revision History
 *  ----------------
 * 
 *  Date        Version Author          Comments
 *  11/02/10    1.0     K.McD           1.  First entry into TortoiseSVN.
 *  
 *  07/25/2016  1.1     K.McD           References
 *                                      1.  PTE Changes - List 5-17-2016.xlsx Item 62. On all screens, change the green text to black.
 *                                      
 *                                      Modifications
 *                                      1.  Change the ForeColor property of the m_LabelValueField Label to SystemColors.ControlText and the ForeColorValueFieldNonZero
 *                                          and ForeColorValueFieldZero properties of this UserControl to Color.Black.
 * 
 */
#endregion --- Revision History ---

namespace Common.UserControls
{
    partial class WatchControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // m_LabelNameField
            // 
            this.m_LabelNameField.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // m_LabelValueField
            // 
            this.m_LabelValueField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.m_LabelValueField.ForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // m_LabelUnitsField
            // 
            this.m_LabelUnitsField.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // WatchControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackColorValueFieldNonZero = System.Drawing.Color.WhiteSmoke;
            this.BackColorValueFieldZero = System.Drawing.Color.WhiteSmoke;
            this.ForeColorValueFieldNonZero = System.Drawing.Color.Black;
            this.ForeColorValueFieldZero = System.Drawing.Color.Black;
            this.Name = "WatchControl";
            this.ResumeLayout(false);

        }

        #endregion
    }
}
