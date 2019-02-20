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
 *  File name:  FormCarId.cs
 * 
 *  Revision History
 *  ----------------
 * 
 *  Date        Version Author          Comments
 *  02/21/2018    1.0     Vgottam      First Release.
 *
 */
#endregion --- Revision History ---
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common.Communication;
using Common;
using Common.Forms;
using Bombardier.PTU.Communication;
using System.Diagnostics;
using Bombardier.PTU.Properties;
using System.Text.RegularExpressions;

namespace Bombardier.PTU.Forms
{
    /// <summary>
    /// Form used to configure the VCU Car ID
    /// </summary>
    public partial class FormCarId : FormPTUDialog, ICommunicationInterface<ICommunicationApplication>
    {
        #region --- Member Variables ---
        /// <summary>
        /// Reference to the selected communication interface.
        /// </summary>
        private ICommunicationApplication m_CommunicationInterface;
        #endregion --- Member Variables ---

        #region --- Constructors ---
        
        /// <summary>
        /// Initializes a new instance of the class. Zero parameter constructor, required by Visual Studio.
        /// </summary>
        public FormCarId()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the class. 
        /// </summary>
        /// <param name="communicationInterface">Reference to the communication interface that is to be used to communicate with the VCU.</param>
        public FormCarId(ICommunicationParent communicationInterface)
            : this()
        {
            if (communicationInterface is CommunicationParent)
			{
                CommunicationInterface = new CommunicationApplication(communicationInterface);
			}
			else
	        {
                CommunicationInterface = new CommunicationApplicationOffline(communicationInterface);
			}

            Debug.Assert(CommunicationInterface != null);
        }
        #endregion --- Constructors ---

        #region --- Properties ---
        /// <summary>
        /// Gets or sets the communication interface that is to be used to communicate with the target.
        /// </summary>
        /// <remarks>This property is set by the child class, if appropriate.</remarks>
        public ICommunicationApplication CommunicationInterface
        {
            get { return m_CommunicationInterface; }
            set { m_CommunicationInterface = value; }
        }
        #endregion --- Properties ---

        private void m_ButtonOK_Click(object sender, EventArgs e)
        {
            if (IsDisposed)
            {
                return;
            }
                      

            try
            {
                if( m_TextBoxCarID.Text.Length<1)
                {
                    MessageBox.Show(Resources.MBTInvalidCarIdEntered, Resources.MBCaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    m_TextBoxCarID.Text=m_TextBoxCarID.Text.ToUpper();
                    CommunicationInterface.SetCarID(m_TextBoxCarID.Text);
                    MainWindow.WriteCarIdentifier(m_TextBoxCarID.Text);
                }
                
            }
            catch (CommunicationException)
            {
                
                MessageBox.Show(Resources.MBTCarIdSetFailed, Resources.MBCaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            DialogResult = DialogResult.Yes;
        }

        private void m_TextBoxCarID_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {


                if (Regex.IsMatch(e.KeyChar.ToString(), @"[a-z]"))
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                e.Handled = false;
            }
            else
                e.Handled = true;

        }

    }
}
