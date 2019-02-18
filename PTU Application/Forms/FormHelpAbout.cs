#region --- Revision History ---
/*
 * 
 *  This document and its contents are the property of Bombardier Inc. or its subsidiaries and contains confidential, proprietary information.
 *  The reproduction, distribution, utilization or the communication of this document, or any part thereof, without express authorization is strictly prohibited.  
 *  Offenders will be held liable for the payment of damages.
 * 
 *  (C) 2010    Bombardier Inc. or its subsidiaries. All rights reserved.
 * 
 *  Solution:   PTU
 * 
 *  Project:    PTU Application
 * 
 *  File name:  FormHelpAbout.cs
 * 
 *  Revision History
 *  ----------------
 * 
 *  Date        Version Author          Comments
 *  04/30/10    1.0     K.McDonald      1.  First entry into TortoiseSVN.
 *  
 *  10/10/11    1.1     K.McD           1.  Renamed the LinkLabel control that takes the user to the Bombardier web site.
 *                                      2.  Added a LinkLabel control to display the release notes.
 *                                      
 *  04/15/15    1.2     K.McD           References
 *                                          
 *                                      1.  Although only relevant to Bombardier Field Service Engineers that support a number of PTU projects, the Software User Manual
 *                                          and Release Notes documents are to be made project specific by prepending the project identifier to the file name e.g.
 *                                          'R8PR.Portable Test Unit - Release Notes.pdf', 'CTA.Portable Test Unit - Release Notes.pdf' etc.
 *                                          
 *                                      Modifications
 *                                      1.  Modified the m_LinkLabelReleaseNotes_LinkClicked() method to include the project identifier in the filename for the Software
 *                                          User Manual.
 *                                          
 *  08/11/15    1.3    K.McD            References
 *                                      1.  Changes resulting from documents: 'PTU MOC Findings - .docx' and 'PTU Installation on 64-bit Machine_v1-08022015.docx' sent
 *                                          from Atul Chaudhari on 4th Aug 2015 and the follow up email sent on 5th Aug 2015.
 *                                      
 *                                          1.  On the R188 project only, all references to 'PTU' are to be replaced with 'PTE' and all occurrences of 'Portable Test Unit'
 *                                              are to be replaced with 'Portable Test Equipment'. Where support for multiple legends is not possible, 'Portable Test
 *                                              Application' is to be used as an alternative to 'Portable Test Unit'/'Portable Test Equipment.
 *                                              
 *                                      Modifications
 *                                      1.  Added a check to see if the Dispose() method has been called to all event handlers.
 *                                      2.  Modified the m_LinkLabelReleaseNotes_LinkClicked() method to support 'Portable Test Unit - Release Notes.pdf' and
 *                                          'Portable Test Equipment - Release Notes.pdf'.
 *                                      3.  Modified the signature of the constructor to include the product name that is to be displayed.
 */

/*
 *  11/16/15    1.4     K.McD           References
 *                                      1.  Added support for R179.
 *
 *                                      Modifications
 *                                      1.  Added CommonConstants.ProjectIdR179 to the switch statement in the m_LinkLabelReleaseNotes_LinkClicked() method.
 */

/*
 *  09/13/2016  1.5     K.McD       References
 *                                  1.  Bug Fix - Ref. Email Atul Chaudhari 16 Aug 2016. When using the ProcessStartInfo class to pass parameters to the Process.Start()
 *                                      command, each parameter of the Arguments property that contains any whitespace must be enclosed within double quotes to ensure
 *                                      that it is processed as a single parameter.
 *  
 *                                  Modifications.
 *                                  1.  Included double quotes around each Arguments parameter associated with the ProcessStartInfo class in the
 *                                      m_LinkLabelReleaseNotes_LinkClicked() and m_LinkLabelBombardierTransportation_LinkClicked event handlers.
 */
/*
 * 02/21/2017   1.6     vgottam     References
 *                                  1. Enable the tooltip for buttons on FormHelpAbout.
 *                                      
 *                                  Modifications                              
 *                                  1. Added tooltip text from Resource.resx file for all buttons on FormHelpAbout's Constructor.
 *                                 
 *                                      
 *
 */
/*
 * 06/24/2017   1.7      vgottam     References
 *                                  1.Investigate BART PTU Application to see if “PTE” is used anywhere in help text, tooltips, Windows, Splash Windows, 
 *                                  or any other pop-up windows.
 *                                      
 *                                  Modifications                                  
 *                                  1. Updated the About Form text to display the "Portable Test Unit(PTU)" for BART and "Portable Test Equipment(PTE)"  for other projects.
*/
/*
 * 02/11/2018   1.8      vgottam   Modifications
 *                                  1. Added project ID PAQA to show the About window project titile
 */
/*
 * 07/08/2018   1.9      vgottam   Modifications
 *                                  1. Added project ID MAPA to show the About window project titile
 */
/*
 * 08/02/2018   1.10      vgottam   Modifications
 *                                  1. Updated the conditions to display as PTU for MARTA ,BART,PAQA.
 *                                  2. Removed "Vista" from resource field LegendOS.
 *
 * 12/06/2018   1.11      vgottam   Modifications
 *                                  1.  Updated the code for new project ID: 300R.                                 

 */
#endregion --- Revision History ---

using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

using Common;
using Common.Configuration;
using Common.Forms;
using Bombardier.PTU.Properties;

namespace Bombardier.PTU.Forms
{
    /// <summary>
    /// Form to display the version and copyright information associated with the application.
    /// </summary>
    public partial class FormHelpAbout : FormPTUDialog
    {
        #region --- Constructors ---
        /// <summary>
        /// Initializes a new instance of the form.
        /// </summary>
        /// <param name="productName">The product name, this can be either 'Portable Test Unit' or 'Portable Test Equipment'.</param>
        public FormHelpAbout(string productName)
        {
            InitializeComponent();         
            
            m_LinkLabelBombardierTransportation.Text = Resources.LabelWebAddress;
            this.m_ToolTip.SetToolTip(this.m_LinkLabelBombardierTransportation, Resources.LabelWebAddressToolTip);
            this.m_ToolTip.SetToolTip(this.m_LinkLabelReleaseNotes, Resources.LabelReleaseNotes);
            this.m_ToolTip.SetToolTip(this.m_BtnOK, Resources.AboutWindow_BtnOK_TooTip);
            m_LblProductName.Text = productName;
            m_LblProductVersion.Text = Application.ProductVersion;
            m_LblOS.Text = Resources.LegendOS;

            m_LblDataDictionaryName.Text = Parameter.ProjectInformation.DataDictionaryName;
            m_LblDataDictionaryVersion.Text = Parameter.ProjectInformation.Version;

            m_LblCopyright.Text = Resources.LegendCopyright;
            m_LblRights.Text = Resources.LegendRights;
            if(Parameter.ProjectInformation.ProjectIdentifier== CommonConstants.ProjectIdBART
                || Parameter.ProjectInformation.ProjectIdentifier == CommonConstants.ProjectIdPAQA
                || Parameter.ProjectInformation.ProjectIdentifier == CommonConstants.ProjectIdMAPA
                || Parameter.ProjectInformation.ProjectIdentifier.Equals(CommonConstants.ProjectIdAPM))
                this.Text = "About the " + Resources.ProductNamePTU;
            else
                this.Text = "About the " + Resources.ProductNamePTE;

        }
        #endregion --- Constructors ---

        #region --- Cleanup ---
        /// <summary>
        /// Clean up the resources used by the form.
        /// </summary>
        /// <param name="disposing">True to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Cleanup(bool disposing)
        {
            try
            {
                if (disposing)
                {
                    // Cleanup managed objects by calling their Dispose() methods.
                    if (components != null)
                    {
                        components.Dispose();
                    }
                }

                // Whether called by consumer code or the garbage collector free all unmanaged resources and set the value of managed data members to null.
                
                #region --- Windows Form Designer Variables ---
                // Detach the event handler delegates.

                // Set the Windows Form Designer Variables to null.

                #endregion --- Windows Form Designer Variables ---
            }
            catch (Exception)
            {
                // Don't do anything, just ensure that an exception isn't thrown.
            }
            finally
            {
                base.Cleanup(disposing);
            }
        }
        #endregion --- Cleanup ---

        #region --- Delegated Methods ---
        /// <summary>
        /// Event handler for the OK button. Closes the form.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Parameter passed from the object that raised the event.</param>
        private void m_ButtonOK_Click(object sender, EventArgs e)
        {
            // Skip, if the Dispose() method has been called.
            if (IsDisposed)
            {
                return;
            }

            Close();
        }

        /// <summary>
        /// Event handler for the LinkLabel 'LinkClicked' event. Starts the browser specified in the user settings using the parameter (URL) specified in the 
        /// assembly resource file.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Parameter passed from the object that raised the event.</param>
        private void m_LinkLabelBombardierTransportation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Skip, if the Dispose() method has been called.
            if (IsDisposed)
            {
                return;
            }

            // Change the color of the link text by setting LinkVisited 
            // to true.
            m_LinkLabelBombardierTransportation.LinkVisited = true;
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = Settings.Default.PathBrowser;
            processStartInfo.Arguments = string.Format("\"{0}\"", Resources.LinkBombardier);
            //Call the Process.Start method to open the specified browser 
            //with an URL:
            try
            {
                System.Diagnostics.Process.Start(processStartInfo);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.EMBrowserStartFailed, Resources.MBCaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Event handler for the 'Release Notes' 'LinkClicked' event. Shows the 'Portable Test Unit - Software User Manual.pdf' file.
        /// </summary>
        /// <param name="sender">Reference to the object that raised the event.</param>
        /// <param name="e">Parameter passed from the object that raised the event.</param>
        private void m_LinkLabelReleaseNotes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Skip, if the Dispose() method has been called.
            if (IsDisposed)
            {
                return;
            }

            // Determine the filename of the release notes associated with this project.
            string filenameReleaseNotes = string.Empty;
            switch (Parameter.ProjectInformation.ProjectIdentifier)
            {
                case CommonConstants.ProjectIdNYCT:
                case CommonConstants.ProjectIdR179:
                    filenameReleaseNotes = Resources.FilenameReleaseNotesPTE;
                    break;
                default:
                    filenameReleaseNotes = Resources.FilenameReleaseNotesPTU;
                    break;
            }

            // Check that the release notes document exists.
            string fullyQualifiedFilenameReleaseNotes = DirectoryManager.PathPTUApplicationStartup + Resources.PathRelativeDocumentation + CommonConstants.BindingFilename +
                                                              Parameter.ProjectInformation.ProjectIdentifier + CommonConstants.Period + filenameReleaseNotes;

            FileInfo helpDocumentFileInfo = new FileInfo(fullyQualifiedFilenameReleaseNotes);
            if (helpDocumentFileInfo.Exists)
            {
                // Change the color of the link text by setting LinkVisited to true.
                m_LinkLabelReleaseNotes.LinkVisited = true;
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.FileName = Settings.Default.PathBrowser;
                processStartInfo.Arguments = string.Format("\"{0}\"", fullyQualifiedFilenameReleaseNotes);

                //Call the Process.Start method to open the specified browser 
                //with an URL:
                try
                {
                    System.Diagnostics.Process.Start(processStartInfo);
                }
                catch (Exception)
                {
                    MessageBox.Show(Resources.EMBrowserStartFailed, Resources.MBCaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(Resources.MBTReleaseNotesNotFound, Resources.MBCaptionWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion --- Delegated Methods ---
    }
}