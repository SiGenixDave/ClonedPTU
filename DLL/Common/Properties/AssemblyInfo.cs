﻿#region --- Revision History ---
/*
 * 
 *  This assembly is the property of Bombardier Inc. or its subsidiaries and contains confidential, proprietary information. The reproduction,
 *  distribution, utilization or the communication of this document, or any part thereof, without express authorization is strictly prohibited.
 *  Offenders will be held liable for the payment of damages.
 * 
 *  (C) 2010    Bombardier Inc. or its subsidiaries. All rights reserved.
 * 
 *  Solution:   Portable Test Unit
 * 
 *  Project:    Common
 * 
 *  File name:  AssemblyInfo.cs
 * 
 *  Revision History
 *  ----------------
 * 
 *  Date        Version Author          Comments
 */

#region - [1.0 - 1.9] -
/*
 *  03/29/10    1.0     K.McD           1.  First entry into TortoiseSVN.
 * 
 *  10/15/10    1.1     K.McD           1.  Link to the SolutionInfo.cs file broken so that the configuration management of this subsystem is now controlled
 *                                          independently.
 *                                      2.  Included support for the CommunicationParent class instead of the ICommunication interface.
 *                                      3.  Created the Forms directory and moved all forms associated with the project into that directory.
 *                                      4.  Created the CommunicationParent class.
 *                                      5.  Created the VariableTable abstract class to replace the WatchTable static class.
 * 
 *  10/19/10    1.2     K.McD           1.  Created a set of classes and interfaces to simplify access to the fields associated with the watch, event and self-test data
 *                                          tables defined in the data dictionary.
 * 
 *  10/19/10    1.3     K.McD           1.  Modified: PlotterScalar, PlotterBitmask, WorksetManager and CommunicationParent to access the fields of
 *                                          the watch variable data table contained within the data dictionary using the static class 'Lookup' rather than 'WatchTable'.
 * 
 *  10/22/10    1.4     K.McD           1.  Added support for accessing the data dictionary data tables associated with the self-test and event sub-systems.
 *                                      2.  Replaced the static WatchTable class with the WatchVariableTable class.
 *                                      3.  Changes resulting from the replacing the static WatchTable class with the Lookup static class.
 * 
 *  11/02/10    1.5     K.McD           1.  Added support for the events subsystem.
 *                                      2.  Modified a number of: XML tags, variable names and class names for consistency. No functional changes.
 *                                      3.  Included changes to allow each subsystem to develop communication interfaces to the vehicle control unit independently.
 * 
 *  11/02/10    1.6     K.McD           1.  Deleted the generic version of the PTUDialog class as any form that inherited from this class could not be shown in the 
 *                                          Visual Studio developer window. Each dialog box that communicates with the VCU now implements the ICommunicationInterface 
 *                                          interface on a per form basis.
 * 
 *  11/04/10    1.7     K.McD           1.  Included support for ScaleFactor values below 0.00001.
 *                                      2.  Added the ICommunicationEvent interface.
 *                                      3.  Modified the EventRecord, EventTable and General classes to include support for retrieving event variables from the VCU.
 *                                      4.  Corrected all user controls that inherit from the VariableControl user control so that they can be sized correctly.
 * 
 *  11/05/10    1.8     K.McD           1.  Modified the user controls so the the value foreground color is defined in the EventControl and WatchControl user controls.
 *                                      2.  Cleaned the designer files for each user control.
 *                                      3.  The text vertical alignment is now in the centre of the user control.
 *                                      4.  Added horizontal and vertical scroll bars to the TabPage associated with FormPTU.
 * 
 *  11/16/10    1.9     K.McD           1.  Modifications required to support the implementation of the event log sub-system.
 */
#endregion - [1.0 - 1.9] -

#region - [1.10] -
/* 
 * `11/17/10    1.10    K.McD           1.  Replaced the WorksetManager static class with the combination of: (a) the WorksetCollection class, a non-static class used 
 *                                          to manage the workset collections associated with individual sub-systems and (b) the Workset class, a static class containing 
 *                                          WorksetCollection classes for each sub-system.
 * 
 *                                      2.  Bug fix - SNCR001.16. Modified the form used to manage the watch variable worksets so that it is scrollable.
 *                                      3.  Moved the AutoScale_t structure from FileHandling.cs to AutoScale.cs.
 * 
 *  11/17/10    1.10.1  K.McD           1.  Modified the FormViewDataStream class so that it is no longer an abstract class as child forms cannot be shown in the 
 *                                          Visual Studio designer if they are derived from an abstract form.
 * 
 *                                      2.  Modified the FormWatch and FormWatchReplay classes so that array sizes were specified using the Length of the Column 
 *                                          property of the workset rather than a constant.
 * 
 *  11/26/10    1.10.2  K.McD           1.  Bug fix - SNCR001.60. The Copy context menu option associate with the form used to manage worksets now creates a fully
 *                                          independent copy of the workset i.e. all arrays are copied using the Array.Copy() method and each element of every list is
 *                                          manually copied.
 * 
 *                                      2.  SNCR001.29. Added support for a security tag associated with each workset to prevent accidental deletion of worksets.
 *                                      3.  Added form to allow the user to set the security level of a workset.
 *                                      4.  Modified the FormWorksetManager and FormWorksetDefine classes to be generic.
 * 
 *  12/01/10    1.10.3  K.McD           1.  Included support to save the event log in XML format.
 *                                              (a) Deleted: IRecord, IEventRecord, IStruct, ILog, IVariable, IEventVariable, IWatchVariable, ISelfTestVariable, 
 *                                                  and IDataDictionaryInformation. The associated structures and classes are now all accessed directly.
 * 
 *                                              (b) Modified the following interfaces, classes and structures  as a result of the changes outlined in item 1: 
 *                                                  ICommunicationEvent, EventRecord, EventTable, EventVariableTable, Log, LogTable, SelfTestVariable, 
 *                                                  SelfTestVariableTable, WatchVariable, WatchVariableTable, Struct_t, DataDictionaryInformation_t, Parameter, 
 *                                                  VariableTable<>, WorksetCollection, FileHeader.
 * 
 *                                              (c) Added support for XML serialization in the following classes: EventVariable, EventRecord, 
 * 
 *                                      2.  Added support to save the downloaded fault log.
 *                                      3.  Separated the simulated fault log and fault log directories.
 *                                      4.  Minor changes to a number of XML tags and variables names.
 *                                      5.  Bug fix - SNCR001.60. The Copy context menu option associate with the form used to manage worksets now creates a fully 
 *                                          independent copy of the workset i.e. all arrays are copied using the Array.Copy() method and each element of every 
 *                                          list is manually copied.
 * 
 *  01/05/11    1.10.4  K.McD           1.  Modified the WorksetCollection class so that any previously defined worksets will continue to work if any watch variables are 
 *                                          added to or removed from the data dictionary provided that all of the watch variables defined in the workset are still 
 *                                          contained within the updated data dictionary.
 * 
 *                                      2.  Bug fix - SNCR001.19. Disabled the 'Change Value' context menu option and associated double-click option associated with each 
 *                                          of the user controls associated with this form.
 * 
 *                                      3.  Added the PollScheduler class to control the interval between polls.
 * 
 *  01/10/11    1.10.5  K.McD           1.  Bug fix. Modified the constructor of FormWatchReplay to initialize the timer used to play back the recorded data.
 *                                      2.  Renamed the InstructionUseDefault resource to PathUseDefault to be consistent with the resource name used in the PTU 
 *                                          application.
 * 
 *  01/12/11    1.10.6  K.McD           1.  Bug fix SNCR001.84. Added the second parameter to all calls to the System.Threading.WaitHandle.WaitOne() method, as advised by
 *                                          the following blog entries: 
 *                                              (1) http://www.mikeplate.com/missingmethodexception-and-waitone/ and (2) 
 *                                              (2) http://blog.darrenstokes.com/2009/03/30/watch-out-for-those-waitone-overloads-when-you-need-backwards-compatibility
 * 
 *  01/17/11    1.10.7  K.McD           1.  Removed the SimulateCommunicationLink conditional compilation.
 * 
 *  01/18/11    1.10.8  K.McD           1.  Bug fix SNCR001.79 - In previous releases, the contents of the data streams associated with some of the events 
 *                                          occasionally had all watch variable values set to 0. This bug has been addressed by correcting the stream number value 
 *                                          passed to the call to the PTUDLL32.GetStream() method in Event.CommunicationEvent.GetStream(). 
 * 
 *                                          The data stream number associated with each event record is determined as follows. Starting from the oldest event record, 
 *                                          whenever an event record is found that has an associated data stream, the stream number for the event record is incremented 
 *                                          from a starting value of 0. Any event record that does not have an associated data stream will have the stream number set 
 *                                          to CommonConstants.NotUsed. 
 * 
 *                                          As part of this bug fix the StreamNumber property was added to the EventRecord class.
 * 
 *  01/19/11    1.10.9  K.McD           1.  Modified the Parameter class as follows:
 * 
 *                                              (1) SNCR001.76. Added the StreamNumberMax property to allow the programmer to determine the maximum number of data streams
 *                                                  that can be recorded by the VCU.
 * 
 *                                              (2) SNCR001.42. Modified the default font to be 'Trebuchet MS' 8pt as this is available on the basic installation of
 *                                                  Windows XP.
 *
 *                                              (3) SNCR001.87. Modified the value of the DefaultWatchSizeFaultLog constant to be 20 to cater for the number of data
 *                                                  stream parameters associated with the Propulsion, Engineering and Snapshot event logs on the CTA project.
 * 
 *  01/26/11    1.10.10 K.McD           1.  Modified the design so that the: (1) fault log data streams, (2) application data directory, (3) WatchSize and (4) 
 *                                          VCU sample interval are configured using the data dictionary.
 */
#endregion - [1.10] - 

#region - [1.11] -
/*
 *  01/27/11    1.11    K.McD           1.  Bug fix - SNCR001.88/89. Modified the ShowDataStreamFile() method of the MenuInterface class to return a flag to indicate 
 *                                          whether the selected data stream file was valid.
 * 
 *                                      2.  Modified the Common.CommunicationParent class to include a mutex to ensure that multiple processes can't access the 
 *                                          serial port at the same time.
 * 
 *                                      3.  Modified the EventLogFile_t structure defined in the FileHandling class to allow the programmer to easily append new records 
 *                                          to the existing records.
 * 
 *                                      4.  Added support for a mutex to control read/write access to the communication port in the CommunicationParent class.
 */
#endregion - [1.11] -

#region - [1.12] -
/*
 *  02/03/11    1.12    K.McD           1.  Modified a number of XML tags and comments and renamed a number of variables and methods.
 * 
 *                                      2.  Standardized the function key event handlers associated with the FormViewDataStream and FormWatchReplay classes to: 
 *                                          (a) display the wait cursor, (b) enable the Checked property of the function key and (c) clear any status message.
 * 
 *                                      3.  Included an additional signature for the AppendEventRecordList() method of the FileHandling.EventLogFile_t structure 
 *                                          which will append the records in the specified event record list but will ignore duplicate entries.
 * 
 *                                      4.  Removed the try catch block for an InvalidDataException when calling the FileHandling.Load() method from within the 
 *                                          MenuInterface.ShowDataStreamFile() method as this is no longer appropriate.
 */
#endregion - [1.12] -

#region - [1.13] -
/* 
 *  02/14/11    1.13     K.McD          1.  Added support for debug mode; this allows users to log the parameter values associated with all calls to the methods 
 *                                          associated with the PTUDLL32 dynamic link library.
 * 
 *                                      2.  Removed the ISecurity interface.
 * 
 *                                      3.  Modified the FormWatchReplay class so that it did not modify the MainWindow.TaskProgressBar.Visible property as the 
 *                                          progress bar is now permanently on display.
 * 
 *                                      4.  Bug fix - SNCR001.100/53. Added the UpdateMenu() virtual method to the FormPTU class; this re-applies any form specific 
 *                                          changes to the main menu that were applied after the form was instantiated. Used following a change to the security level 
 *                                          of the user and this action will 'reset' the main menu to its initial state.
 */
#endregion - [1.13] -

#region - [1.14] -
/* 
 *  02/15/11    1.14    K.McD           1.  Removed the DataStreamCount property of the Log class as the stream number field of each event record is now derived 
 *                                          directly from the call to the PTULL32.GetFaultHdr() method, see event.dll, version 1.12.2.
 * 
 *  02/28/11    1.14.1  K.McD           1.  Modified the DoubleClick event handler of those user controls derived from the WatchControl class such that if the user
 *                                          control is not write enabled and the user attempts to modify the current value, the information message reported to the user
 *                                          will differentiate between a read-only watch variable and one where the current security level is insufficient to allow the
 *                                          user to modify the value.
 * 
 *                                      2.  Modified the names of a number of resources, classes and methods.
 * 
 *                                      3.  Modified the FormDataStreamReplay class constructor to check whether the calling form was itself called from a multiple
 *                                          document interface child form or from the main application and display the appropriate text and image associated with the
 *                                          escape key. If called from the main application, the escape key will return the user home, however, if the calling form is
 *                                          called from an MDI child form the escape key will return the user back to the MDI child form.
 * 
 *                                      4.  Modified the FormDataStreamReplay event handler for the escape key to check whether the the calling form was itself called 
 *                                          from a multiple document interface (MDI) child form and, if so, to restore the keys associated with the MDI child form and 
 *                                          then show that form rather than returning the user home.
 * 
 *                                      5.  Included support to manage the Visible property of the main application progress bar as this is no longer permanently on 
 *                                          display.
 * 
 *                                      6.  Added an event handler for the context menu Opened event to the FormWorksetManager class so that the Enabled property of each 
 *                                          context menu could be set or cleared depending upon the selected context menu and current security level.
 *                                   
 *                                      7.  Modified the event handler for the 'Set As Default' context menu option associated with the FormWorksetManager class to ensure
 *                                          that the security level of the workset that has been set to be the default workset is set to the highest security level.
 * 
 *                                      8.  Added a TextBox control to the FormWorksetDefine class to show the security level of the current workset.
 * 
 *  03/01/11    1.14.2  K.McD           1.  Corrected the parameters passed to the DeriveName() method in the General.GetFullyQualifiedFaulLogFilename() methods.
 * 
 *                                      2.  Modified the event handler for the 'F5-Trip' function key in the FormDataStreamReplay class such that, if an entry 
 *                                          corresponding to the time of the trip is not found, the 'F5-Trip' function key is unchecked and the cursor is set to the 
 *                                          default cursor.
 * 
 *  03/18/11    1.14.3  K.McD           1.  Modified the WriteDataSetToXml() method of the DataDictionary class to include try/catch blocks for those tables that are 
 *                                          not automatically created by the data dictionary builder utility in case those tables have not been included in the data 
 *                                          dictionary.
 * 
 *                                      2.  Added support for the Security table of the Access 'E1' database and modified the Security class to use the security 
 *                                          configuration parameters defined in this table.
 * 
 *                                      3.  Modified the Parameter class to include support for the Security table of the data dictionary and included the Initialize() 
 *                                          static method to update the security parameters with the parameters defined in the Security table of the data dictionary.
 * 
 *                                      4.  Added the WinHlp32 class to support the Windows help engine.
 * 
 *                                      5.  Modified the LoadDataDictionary() method of the General class such that the same call to the FileInfo.CopyTo() method is 
 *                                          made nomatter whether the destination file exists or not.
 * 
 *                                      6.  Modified the AppendEventRecordList() method of the FileHandling class to include a match for the event index in the 
 *                                          Find() method call when trying to locate the correct record in the list of event records. This was added to cater 
 *                                          for the case where multiple events with the same description and date/time stamp are generated by the VCU, but with 
 *                                          different event variable information e.g. in the case of the 'Inverter Fault' event.
 * 
 *                                      7.  Modified the PauseCommunication() method of the FormPTUDialog class to update the status message box of the main application 
 *                                          window.
 * 
 *                                      8.  Modified the watch and event user controls to:
 *                                              (a) include support for diagnostic help information.
 *                                              (b) ensure that an exception is not thrown and to correctly handle the case where an invalid watch identifier is specified
 *                                                  for the Identifier property of the control.
 * 
 *                                      9.  Modified the FormShowFlags class to support the FormShowFlagsEvent child class and created the FormShowFlagsEvent child class.
 * 
 *                                      10. Added the CopyTo() method to the EventVariable class to allow the selected event variable to be copied to a newly instantiated
 *                                          event variable.
 * 
 *                                      11. Added the CommonEventVariableCount property to the EventTable class. This gives the number of common event variables per event
 *                                          associated with the current data dictionary.
 * 
 *                                      12. Bug fix - SNCR001.114. Modified the CreateEventVariableList() of the EventTable class to create a list of newly instantiated 
 *                                          event variables to store the event variable values associated with the the specified event identifier.
 * 
 *  03/28/11    1.14.4  K.McD           1.  Bug fix SNCR001.112. Modified the assembly to use the old identifier field of the data dictionary rather 
 *                                          than the watch identifier field to define the watch variables that are to be included in the workset as these remain 
 *                                          consistent following a data dictionary update.
 * 
 *                                      2.  Added the WatchVariableTableByOldIdentifier class to support access to the watch variables defined in the data dictionary
 *                                          using the old identifier field of the watch variables.
 * 
 *  03/31/11    1.14.5  K.McD           1.  SNCR001.025. Added support for the enumerator user control.
 * 
 *  04/07/11    1.14.6  K.McD           1.  SNCR001.115. Modified the FormShowHeaderInformation class such that the username field displays the saved username rather 
 *                                          than the current Windows username.
 * 
 *                                      2.  Modified the AutoScaleMode property of the FormPTUDialog class to Inherit.
 * 
 *                                      3.  Added the methods required to configure the event flags and show the event history to the ICommunicationEvent interface.
 * 
 *  04/08/11    1.14.7  K.McD           1.  Minor modifications to support the screen capture feature.
 */
#endregion - [1.14] -

#region - [1.15] -
/* 
 *  04/27/11    1.15    K.McD           1.  Included support to allow the user to configure the chart recorder and set the mode of the chart recorder.
 */
#endregion - [1.15] -

#region - [1.16] -
/*
 *  05/23/11    1.16    K.McD           1.  Migrated to Visual Studio 2010.
 *                                      2.  Added support to allow the user to define the chart recorder scaling information in the chart recorder worksets.
 *                                      3.  Modified the form that allows the user to configure the chart recorder to include support for the chart recorder 
 *                                          scaling information defined within the chart recorder worksets.
 *                                      4.  Added a number of resources.
 *                                      5.  Included support for recording the chart recorder scaling information in each chart recorder workset.
 *                                      
 *  05/24/11    1.16.1  K.McD           1.  Moved a number of methods associated with the configuration of the chart recorder to the CommunicationParent class.
 *                                      2.  Added the DownloadWorkset() virtual method to the FormConfigure class.
 *                                      
 *  05/26/11    1.16.2  K.McD           1.  Added and renamed a number of constants in the CommonConstants class.
 *                                      2.  Auto-modified the following classes as a result of name changes to a number of constants in the CommonConstants class:
 *  
 *                                              (a) DataStream
 *                                              (b) WorksetCollection.
 *                                              (c) EventBitmaskControl.
 *                                              (d) EventControl.
 *                                              (e) EventEnumeratorControl.
 *                                              (f) EventScalarControl.
 *                                              (g) WatchBitmaskControl.
 *                                              (h) WatchControl.
 *                                              (i) WatchEnumeratorControl.
 *                                              (j) WatchScalarControl.
 *                                              (k) CommunicationParent.
 *                                              
 *                                          Note: The revision history associated with each of the above classes was not updated to reflect this change.
 *                                              
 *                                      3.  Corrected the SetChartScale() method in the CommunicationParent class to download the specified parameter values rather than 
 *                                          the upper and lower limits defined in the data dictionary.
 *                                          
 *                                      4.  Bug fix. Modified the FormConfigure class to allow child classes to clear all ListBox controls when creating a new workset.
 *                                          
 *                                      5.  Corrected the CompareWorkset() method in the FormConfigure class.
 *
 *  06/21/11    1.16.3  K.McD           1.  Added the ShowHelpWindow() method to the WinHlp32 class. This method shows the specified help information using the standard 
 *                                          Windows help window.     
 *                                      2.  Added the self test communication methods to the DebugMode class.
 *                                      3.  Modified the FormConfigure class to display the name of the selected workset in the 'TabPage' header.
 *                                      4.  Modified the FormWorksetDefine class to support the changes to the chart recorder configuration discussed in the 
 *                                          May 2011 sprint review.
 *                                      5.  Added the communication interface associated with the self test methods.
 *                                      6.  Added support for the self test sub-system to the Lookup class.
 *                                      7.  Added the classes required to support access to the data dictionary tables associated with the self test sub-system.
 *                                      
 *  06/23/11    1.16.4  K.McD           1.  Added debug mode information to the following communication methods: GetChartMode(), SetChartMode(), SetChartIndex() and 
 *                                          SetChartScale().
 *                                          
 *  06/31/11    1.16.5  K.McD           1.  Target framework updated to .NET Framework 4.0.
 *                                      2.  Minor changes to the Size and Location properties of a number of controls associated with the FormWorksetDefine and 
 *                                          FormConfigure classes.
 *                                      3.  Modified the BackColor property of a number of controls associated with the FormWorksetDefine class to Transparent.
 *                                      4.  Set the ReadOnly and Enabled  properties of the TextBox controls used to display the workset name and the security level to 
 *                                          False when displaying a pre-defined workset so that the ForeColor intensity is consistent in the FormWorksetDefine class.
 *                                      5.  Added a number of general and hexadecimal formatting constants to the CommonConstants class.
 *                                      
 *  07/07/11    1.16.6  K.McD           1.  Modified the maximum number of self test variables that can be supported by each interactive tests. 
 *                                      2.  Added support for the HideHelpWindow() method in class WinHlp32.
 *                                      3.  Modified the MainWindow property of the FormPTU class to allow the property to be set.
 *                                      4.  Carried out the following modifications to the IMainWindow interface: 
 *                                              (a) Added the ShowBusyAnimation property.
 *                                              (b) Added the SetMode() method to allow the current mode of the application to be modified.
 *                                              (c) Added the SelfTest and Simulation modes to the Mode enumerator.
 *                                              (d) Modified one or more XML tags.
 *                                      5.  Removed command to force Focus when the selected index changes on the ComboBoxWorkset control in FormConfigure
 *                                      6.  Carried out the following modifications to the SelfTestTableBySelfTest class
 *                                              (a) Added System.Diagnostics to the Using directive
 *                                              (b) Added testMessagesDataTable parameter to constructor
 *                                              (c) Added the CreateSelfTestVariableList method.
 *                                      7.  Carried out the following modifications to the SelfTestTable class
 *                                              (a)  Added the TestMessage_t struct
 *                                              (b)  Added the m_TestMessageLists member variable for tracking Test Messages
 *                                              (c)  Added the testMessagesDataTable field to the Constructor
 *                                              (d)  Made the CreateSelfTestVariableList method virtual
 *                                              (e)  Added the BuildTestMessageLists method.
 *                                              (f)  Added the GetTestMessageHelpIndex method.
 *                                      8.  Minor changes in Resources.
 *                                      
 *  07/13/11    1.16.7  K.McD           1.  Changed the definition of the Mode enumerator in the IMainWindow interface to take into account the redefinition of 
 *                                          off-line mode and diagnostic mode discussed in the June sprint review.
 *                                          
 *  07/25/11    1.16.8  K.McD           1.  Modified the ToXML() method of the GetSelfTestResult_t structure in the DebugMode class to use an int for the Tag element 
 *                                          of the InteractiveResults_t structure rather than short.
 *                                      2.  Modified the WinHlp32 class.
 *                                              (a) Added the following User32 methods: SetWindowPos(), FindWindow(), GetWindowRect(), SetActiveWindow() and 
 *                                                  EnableWindow().
 *                                              (b) Modified the ShowHelpWindow() method to position the help window within the boundary of the form/control associated 
 *                                                  with the specified handle.       
 *                                      3.  Added the user controls to support self test variables.
 *                                      4.  Corrected one or more XML tags associated with the user controls used to display event variables.
 *                                      5.  Included support for off-line mode.
 *                                              (a) Added the SIMULATOR element to the Protocol enumerator.
 *                                              (b) Modified the constructor signature of the CommunicationPArent class to use the ICommunicationParent interface.
 *                                              (c) Added the CommunicationParentOffline class.
 *                                              (d) Modified the CommunicationInterface property of the IMainWindow interface to inherit from ICommunicationParent.
 *                                              
 *  07/25/11    1.16.8.1    K.McD       1.  Very minor corrections.
 *  
 *  07/25/11    1.16.9      K.McD       1.  Added support for the Universal Resource Indicator (URI) table of the data dictionary. This table defines valid tcp/ip 
 *                                          addresses in URI format and is required for ethernet communication.
 *                                              (a) Modified DataDictionary.mdb. 
 *                                                      (a) Added the URI table.
 *                                                      (b) Added the CommunicationType parameter to the CONFIGUREPTU table. 
 *                                                          0 - RS232 only, 1 - ethernet only, 3 - both.
 *                                              (b) Added support for the URITableAdapter class in the WriteDataSetToXml method of 
 *                                                  the DataDictionary class.
 *                                              (c) Auto-updated DataDictionary.xsc and DataDictionary.xss.
 *                                              
 *  07/26/11    1.16.9.1    K.McD       1.  Modified the signature of the ShowHelpWindow() method in the WinHlp32 class to allow the programmer to specify the 
 *                                          hWndInsertAfter parameter.
 *                                          
 *  07/29/11    1.16.9.2    K.McD       1.  Included support to allow the user to view the individual bits of a self test bitmask variables.
 *                                              (a) Modified the m_MenuItemShowFlags_DoubleClick() method of the SelfTestBitmaskControl user control to call the 
 *                                                  FormShowFlagsSelfTest form.
 *                                          
 *                                              (b) Added the FormShowFlagsSelfTest form.
 *                                              
 *                                      2.  Modified the FormPTU class to include support for capturing the self test screen.
 *                                      
 *                                      3.  Corrected the event handler associated with the 'F2-Print' function key in the FormPTU class to include the capture type 
 *                                          in the extension of the default filename.
 *                                          
 *                                      4.  Removed the Trace constant from the Release build in the project file.
 *                                      
 *  08/04/11    1.16.9.3    K.McD       1.  Minor modifications to the WinHlp32 and VariableTable.Generic classes.
 *  
 *  08/05/11    1.16.10     K.McD       1   Modified the FormConfigure class to support the form which allows the user to configure the fault log parameters.
 *                                              (a) Changed the modifiers associated with the ConfigurationModified() and CompareName() methods to private.
 *                                              (b) Made the LoadWorkset() method virtual.
 *                                              (c) Removed the CompareWorksetNoChartScale() methods.
 *                                              (d) Modified the CompareWorkset() method such that the chart scaling information is now excluded from the workset
 *                                                  comparison. 
 *                                              
 *  08/10/11    1.16.11     K.McD       1.  Set the default font to be 'Segoe UI'.
 *                                      2.  Minor adjustments to the Size and Location properties of one or more controls in a number of classes derived from 
 *                                          FormPTUDialog.
 *                                      3.  Changed the BackColor property of one or more controls to Transparent.
 *                                      4.  Modified the DropDownHeight property of the ToolStripComboBox control in the FormPTU class.
 *                                      5.  Added a BackgroundImage to the Panel control used to display information in the FormPTU class.
 *                                      
 *  08/17/11    1.16.12     K.McD       1.  Bug fix - SNCR002.21. Modified the FormWorksetManager class so that it no longer displays a warning message if the user 
 *                                          attempts to edit the default workset.
 */
#endregion - [1.16] -

#region - [1.17] -
/*
 *  08/24/11    1.17        K.McD       1.  Modified each method of the CommunicationParent class to implement a standard pattern that improves the error handling 
 *                                          in the event that communications to the target hardware is lost.
 *                                          
 *                                      2.  Modified the signature of the SetPauseAndWait() method in the IPollTarget interface.
 *                                      
 *                                      3.  Added a watchdog counter to the WorkerThread class and added a timeout on the call to the Join() method from within 
 *                                          the Kill() method. Also: implemented the disposal pattern, removed the Mutex from the EndLoop property and ensured 
 *                                          that a number of objects were instantiated before making calls to their member methods.
 *                                          
 *                                      4.  Updated the CommonConstants class.
 *                                      
 *  08/24/11    1.17.1     K.McD        1.  Added a check on the success of the call to the IPollTarget.SetPauseAndWait() method before attempting to write the new 
 *                                          value to the target in the FormChangeScalar, FormChangeEnumerator and FormChangeBitmask classes.
 *                                          
 *  08/25/11    1.17.2      K.McD       1.  Updated the CommonConstants class to increase the TimeoutMsPauseFeedback value to 1,000 ms.
 *
 *	09/12/11	1.17.3		Sean.D		1.	Added to Parameter.cs m_URIList and m_CommunicationProtocol member variables to track the list of URIs to be checked and 
 *											a setting for whether to check network, serial, or both connections. Items were already in the database.
 *											
 *	09/20/11	1.17.4		Sean.D		1.	Added the SetWatchSize method to PTUDLL32.cs to set a new watch variable list size.
 *										2.	Added code in to the Initialize() method of the Parameter class to attempt to set the number of watch variables in 
 *										    PTUDLL32 based on the WatchSize field of the ConfigurePTU table of the data dictionary.
 * 											
 *	09/26/11	1.17.5		Sean.D      1.  PlotterControlLayout.PlotWatchValues(). Corrected the implementation of the check to determine if the bit associated with 
 *                                          the PlotterBitmask control is asserted.
 *                                          
 *                                      2.  MenuInterface. Initialized the FullFilename property of the WatchFile_t structure in the ShowDataStreamFile() method.
 *                                      
 *                                      3.  Modified the FileHandling class to allow to user to read and write to an existing watch file.
 *                                              (a) Added the FullFilename property to the WatchFile_t and EventLogFile_t structures.
 *                                              (b) Modified the Serialize<T>() method to use the 'FileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite,
 *                                                  FileShare.ReadWrite)'method and to include a try/catch block to catch UnauthorizedAccess exceptions.
 *                                                  
 *                                          --- Interfaces ---
 *                                      4.  Added the CheckBoxUInt32 class to implement the ICheckBoxUInt32 interface. This interface is used to display the state of 
 *                                          the individual flags of a <c>uint</c> bitmask watch variable using an array of <c>CheckBox</c> controls and to convert the 
 *                                          Checked state of the individual controls in the array back to a <c>uint</c> value.
 *                                          
 *                                      5.  Added the ICheckBoxUInt32, IEventLogFile and IWatchFile interfaces.
 *                                      
 *                                          --- UserControls ---
 *                                      6.  Added the 'Remove' context menu option to the PlotterScalar, PlotterBitmask and PlotterEnumerator user controls to allow 
 *                                          the user to remove the selected user control from the current plot display.
 *                                          
 *                                      7.  Modified the DrawXYText() method of the FormPlotterEnumeratorParent class to accommodate the change to the signature of the 
 *                                          Plotter.FindY() method.
 *                                          
 *                                      8.  Corrected the Name property of the: SelfTestControl, SelfTestScalarControl, SelfTestEnumeratorControl and the 
 *                                          SelfTestBitmaskControl user controls.
 *                                          
 *                                          --- Configuration ---
 *                                      9.  Corrected the implemetation of the check to determine which bits of a bitmask watch variable were set in the: 
 *                                          GetFlagStateList(), GetAssertedFlagList(), GetFlagDescription() and the BuildBitCountTable() methods of the 
 *                                          VariableTable.Generic class.
 *                                          
 *                                      10. Modified the WorksetCollection class.
 *                                              (a) Added support to allow the user to modify the plot layout of saved watch data files.
 *                                              (b) Added a Contains() method to check whether the workset collection contains a workset with the specified name.
 *										        (c) Modified the Add() method so that it only adds non-duplicate entries and returns a flag regarding the
 *											        success of the call.
 *											        
 *								        11. Minor changes to the Parameter class to ensure compliance with the coding standard. Also changed the default 
 *								            CommunicationTypeEnum to RS232.
 *								        
 *                                          --- Forms ---
 *                                      12. Modified the DataUpdate event handler of the FormConfigure class to check whether a call to the Dispose() method has been 
 *                                          called.
 *                                      
 *                                      13. Modified the FormShowHeaderInformation class to allow the user to edit the Comments field of the watch file.
 *                                              (a) Added the Header_t member variable to record the header information passed in the constructor.
 *                                              (b) Renamed the event handler associated with the OK button Click event and added support to save the comments to the 
 *                                                  IWatchFile interface associated with the calling form.
 *                                                  
 *                                      14. Added the FormPlotDefineBitmask class to allow the user to define which bits of a bitmask watch variable are to be plotted on 
 *                                          the plotter display.
 *                                          
 *                                      15. Added the FormPlotDefine class to allow the user to define how saved watch files and fault logs are to be plotted.
 *                                      
 *                                      16. Modified the FormPTU class.
 *                                              (a) Removed the call to the CloseShowFlags() method in the Cleanup() method. This call is now made in the individual 
 *                                                  child classes as the user may want the state of the individual bits of a bitmask watch variable to remain on 
 *                                                  display when switching from the Replay form to the Plot form.
 *                                                      
 *                                              (b) Modified the OpenedDialogBoxList property so that it is read/write.
 *                                                  
 *                                      17. Modified the FormDataStreamReplay class.
 *                                              (a) Modified the event handler for the YTPlot function key:
 *                                                      (b) Updated the WatchFile property of the calling class to ensure that any modifications to the 
 *                                                          WatchFile.Comments property while displaying the Replay form are reflected when the user changes to the 
 *                                                          Plot display.
 *                                                      (c) Updated the OpenDialogBoxList property of the calling form to ensure that any bitmask displays that are 
 *                                                          deliberately left open when the user switches back to the Plot display will be closed when the user exits the
 *                                                          Plot display.
 *                                                  
 *                                              (b) Refactored the implementation of the IWatchFile interface.
 *                                              
 *                                      18. Modified the FormDataStreamPlot class.
 *                                              (a) Refactored the implementation of the IWatchFile interface.
 *                                              (b) Added support for the Edit function key. This key calls the form which allows the user to define the layout of the 
 *                                                  Plot display.
 *                                              (c) Moved a number of virtual methods and added logic to the virtual PlotHistoricData() method.
 *                                              (d) Removed the call to clear the status message from a number of delegated methods.
 *                                              (e) Added a call to the CloseShowFlags() method in the: F4_Click() and Exit() methods.
 *                                              (f) Modified the ConfigureTabControl() method to use the PlotTabPages property of the workset.
 *                                              (g) Modified the ConfigureTableLayoutPanel() method to display only those bits of a bitmask watch variable that have 
 *                                                  been specified in the PlotTabPages property of the workset.
 *                                              (h) Changed the modifiers of a number of methods.
 *                                              
 *                                      19. Modified the FormWorksetDefine class.
 *                                              (a) Added the event handler m_TextBoxName_TextChanged to disable the OK Button when the text in the TextBox control 
 *                                                  either matches the name of an existing workset or is empty. The event handler also displays a warning message 
 *                                                  if the specified text matches an existing workset.
 *	                                            (b) Modified the WatchItemAddRange() method to initialize the DisplayMask field of the WatchItem_t structure.
 *	                                            (c) Added a number of virtual methods associated with the context menus to support child classes.
 *											
 *  10/05/11    1.17.6		Sean.D		1.	Fixed version numbers in Revision History of PTUDLL32.cs and Parameter.cs.
 *                                      2.	Fixed a small bug in the CompareWorkset() method of the FormConfigure class where an exception was raised when the 
 *                                          OldIdentifier list in the given column of worksetToCompare had fewer items than workset.
 *                                      3.	In FormDataStreamPlot.cs, set the F5 ToolTip to refer to a Resource string.
 *                                      4.	In FormDataStreamPlot.cs, added the F6 key and event-handler to switch between regular and Multi cursor settings for
 *                                          SNCR002.1 Enhancement.
 *                                      5.  In FormShowHeaderInformation, Changed constructor to run a regular expression replacement for lone Line Feed characters for
 *                                          SNCR002.12 Bug fix.
 *                                      6.	In PlotterControlLayout.cs:
 *                                      	A.	Add the m_listPlotters and m_MultiCursor member variables as well as public property MultiCursor.
 *                                      	B.	Added the OnPlotMouseMoved function to handle updating the MouseHoverCoordinates for all of the plots
 *												on the current display.
 *                                      	C.	Modified ConstructPlotterScalar, ConstructPlotterEnumerator, and ConstructLogicAnalyzerControl to
 *												store a reference in m_listPlotters and to set their MouseMove event.
 *                                      7.	Added the FunctionKeyTextMultiCursor, FunctionKeyToolTipEditPlotLayout, FunctionKeyToolTipMultiCursor, and MultiCursor 
 *                                          resources to Resources.cs.
 *                                      8.	Added SimulCursorHS.png to the Resources directory.
 *                                      
 *  10/07/11    1.17.7      K.McD       1.  Reverted the PlotterControlLayout class back to revision 1.10 as the changes implemented in revision 1.11 are not required 
 *                                          for the current multiple cursor implementation. Also added the constants that define the height for the scalar, enumerator 
 *                                          and bitmask plotter controls.
 *                                          
 *                                      2.  Added support for the Remove context menu option to the scalar, enumerator and bitmask plotter controls. This menu option 
 *                                          removes the control from the current plot display. Also added the Removed property to the IPlotterWatch interface definition. 
 *                                          This flag indicates whether the user has actively removed the plotter control from the current plot display.
 *                                          
 *                                      3.  Modified the FormDataStreamPlot class.
 *                                              (a) Included support to allow the user to remove individual plots from the display by means of the Remove context menu 
 *                                                  option associated with each of the plotter user controls.
 *                                                  
 *                                              (b) Modified the Shown event handler to size the scalar, enumerator and bitmask plot controls based upon the height 
 *                                                  defined in the PlotterControlLayout class rather than upon the size of the form.
 *                                                  
 *                                      4.  Removed the check that the mouse hover Y coordinate is within the bounds of the graph area from the DrawXYText() method of 
 *                                          the PlotterEnumeratorParent class. This modification was carried out as, firstly, the Y coordinate is not used and secondly, 
 *                                          when displaying multiple/simultaneous cursors the Y coordinate of the mouse cursor may well fall outside the bounds of the 
 *                                          control as common coordinates are used for each control and the scalar plotter controls are a different height to the 
 *                                          enumerator and bitmask plotter controls.
 *                                          
 *                                      5.  Bug fix. Modified the FormWorksetDefine class to ensure that the status message label is only visible if the text in 
 *                                          the text box matches an existing workset name.
 *                                          
 *                                      6.  Bug fix. Modified the Serialize<T>() method of the FileHandling class to delete the file if it already exists. If the file 
 *                                          is not deleted there can be problems when saving the data in XML mode. If the size of the data is smaller than the data 
 *                                          in the existing file then the new data appears to be overlayed into the existing file which mean that when the file is 
 *                                          read the XML code may contains spurious remnants of the existing XML code at the end of the file which may throw an 
 *                                          exception when the code is read using the Deserialize() method.
 *                                          
 *  10/10/11    1.17.8      K.McD       1.  SNCR002.12. - Improved the regular expression logic in the constructor of the FormShowHeaderInformation class to find 
 *                                          consecutive multiple carriage returns/line feeds.
 *                                          
 *  10/13/11    1.17.9      K.McD       1.  Rationalized the Resources.resx file and renamed a number of resources. Note: No revision history updates were carried out 
 *                                          on individual files that were auto-updated as a result of the resource name changes.
 *                                          
 *                                      2.  Added icons to a number of form classes.
 *                                      
 *  10/14/11    1.17.10     K.McD       1.  Modified the WinHlp32 class.
 *  
 *                                              (a) SNCR002.42. Modified the ShowHelpWindow(), ShowPopup() and HideHelpWindow() methods to ensure that they don't throw 
 *                                                  an exception if the class hasn't been initialized; instead, they simply ignore the request. The problem with the 
 *                                                  previous implementation was that an exception was thrown if the user selected any of the 'Show Definition' context 
 *                                                  menu options for a data dictionary that did not have an associated diagnostic help file.
 *                                          
 *                                              (b) SNCR002.43. Ensured that the IsInitialized flag is cleared at the beginning of the Initialize() method in case the 
 *                                                  user switches from a data dictionary that has an associated diagnostic help file to one that doesn't - via the 
 *                                                  'File/Select Data Dictinary' menu option. With the previous implementation all 'Show Definition' context menu 
 *                                                  options for the new data dictionary would display the help information associated with the previous data dictionary.
 *                                          
 *                                              (c) Corrected the check statement associated with the IsInitialized flag in the Close() method.
 *                                          
 *                                      2.  Modified the FormDataStreamPlot class to set the single cursor option as the default display and changed the Image 
 *                                          associated with the multi-cursor function key.
 *
 *                                      
 *	10/18/11	1.17.10		Sean.D		1.  Added a call in FormPlotDefine to UpdateCount() in m_ButtonRestoreDefaults_Click to ensure the counts match.
 *										2.  SNCR002.12 - Bug fix in FormShowHeaderInformation. Modified code in constructor to check for native NewLine and to catch
 *										    consecutive \n characters.
 *										3.  Made the CreateBaselineWorkset() method in WorksetCollection public so that it could be used to create a workset when none
 *										    works within variable constraints.
 *										4.	Modified CheckCompatibility() in WorksetCollection to check whether the workset has an upper limit of watch variables
 *										    different from the data dictionary.
 *										5.	SNCR002.36 - Modified Update() in WorksetCollection to set the correct upper limit watch size according to the data dictionary
 *										    and notify the user if doing so will potentially lose data. 
 *										6.	Made a very minor correction in the summary comment of FormPTU.
 *										7.	Added into FormWorksetDefine the ClearStatusMessage(), DisableApplyButton(), DisableOKButton(), and ReenableApplyAndOKButton()
 *										    methods.
 *										8.	Modified FormWorksetDefine constructors to call ClearStatusMessage to ensure that the status message stays clear. I was
 *										    getting the occasional anomalous result where the error icon started displayed.
 *										9.	Modified the FormWorksetDefine constructor which took in a workset to disable the Apply button if there are more variables
 *										    than we can handle.
 *										10.	Added an EntryMax property to FormWorksetDefine to track the maximum number of allowed entries, by default based on the
 *										    EntryMax of the current workset.
 *										11.	Modified m_ListBoxTarget_DragDrop method in FormWorksetDefine to refer to the EntryMax property rather than the EntryMax of
 *										    the workset directly.
 *										12.	Changed FileDialogSaveImageFile in General.cs to override the file extension based on the format we're saving as.
 *										
 *  10/24/11    1.17.11     K.McD       1. WorksetCollection - version 1.8.2.
 *                                          1.  Added a ThreadSleep() statement to the CheckCompatibility() method after the call to the De-Serialize() method to give 
 *                                              the file time to close properly.
 *                                          
 *                                          2.  Moved the error reporting from the CheckCompatibility() method to the Update() method. Also added consistency checking 
 *                                              on the CountMax parameter of the individual worksets within the collection to the CheckCompatibility() method.
 *                                                  
 *                                          3.  Removed the 'List<short> invalidOldIdentifierList' parameter from the signature of the Load() and CheckCompatibility() 
 *                                              methods. Error reporting is now carried out directly within the Update() method rather than passing the information 
 *                                              back through the call stack.
 *                                          
 *                                          4.  Refactored the error reporting. Created the GetIncompatibleOldIdentifierList(), GetIncompatibleWorksetList and 
 *                                              ReportIncompatibleWorksets() methods.
 *                                          
 *                                          5.  Major modifications to the Update() method.
 *                                                  (a) Now responsble for reporting workset incompatibilities with the current data dictionary.
 *                                                  (b) Now updates the EntryCountMax field of the workset collection and the CountMax fields of individual worksets
 *                                                      within the collection with the values appropriate to the current data dictionary.
 *                                                  (c) Now updates the baseline workset to be compatible with the current data dictionary.
 *                                                  
 *                                      2.  WinHlp32 - version 1.3.3.
 *                                          1.  SNCR002.42. Modified the ShowHelpWindow(), ShowPopup() and HideHelpWindow() methods to ensure that they don't throw an 
 *                                              exception if the class hasn't been initialized; instead, they simply ignore the request. The problem with the previous 
 *                                              implementation was that an exception was thrown if the user selected any of the 'Show Definition' context menu options for
 *                                              a data dictionary that did not have an associated diagnostic help file.
 *                                          
 *                                          2.  SNCR002.43. Ensured that the IsInitialized flag is cleared at the beginning of the Initialize() method in case the user 
 *                                              switches from a data dictionary that has an associated diagnostic help file to one that doesn't - via the 
 *                                              'File/Select Data Dictinary' menu option. With the previous implementation all 'Show Definition' context menu options 
 *                                              for the new data dictionary would display the help information associated with the previous data dictionary.
 *                                          
 *                                          3.  Corrected the check statement associated with the IsInitialized flag in the Close() method.
 *                                          
 *                                      3.  Auto-modified a number of classes as a result of name changes to: constants, variables, properties, methods and resources.
 *                                      
 *                                      4.  IMainWindow interface - version 1.10.3.
 *                                              1.  Added the KeyPreview property.
 *                                              2.  Modified the Mode enumerator such that the startup mode of the PTU was renamed to be Configuration rather than 
 *                                                  Diagnostic.
 *                                                  
 *                                      5.  FormWorksetDefine - version 1.9.5.  
 *                                              1.  Re-organized the layout of the file i.e. location of a number of methods.
 *                                              2.  Modified the names of a number of methods.
 *                                              3.  Made the status message icon a separate Label control and included this and the original status label within a Panel
 *                                                  control to improve layout of multi-line messages.
 *                                              4.  Removed the redundant call to the ReenableApplyAndOKButtons() method from the m_ButtonRemove_Click() method.
 *                                              5.  Replaced direct text to resource references in the constructor.
 *                                              
 *                                      6.  FormDataStreamReplay - version 1.11.5, FormDataStreamPlot - version 1.17.
 *                                              1.  Bug fix - SNCR002.41. Included a check in the event handler for each ToolStripButton Click event to ensure that the 
 *                                                  logic associated with the event handler is ignored if the control isn't enabled. This check is required because 
 *                                                  the event handler is also called by the FormPTU.Form_KeyDown() event handler whenever the function key associated 
 *                                                  with the ToolStripButton control is pressed. Consequently, in the previous implementation, the action associated 
 *                                                  with the ToolStripButton would be carried out whenever the user pressed the corresponding function key, 
 *                                                  regardless of whether the ToolStropButton control was enabled or not.
 *                                                  
 *                                      7.  FormDataStreamPlot. Modified the constructor to set the static MultiCursor property of the Plotter user control to be false 
 *                                          to ensure that the single cursor option is used as the default. Also changed the Image associated with the multi-cursor 
 *                                          function key.
 *                                          
 *                                      8.  FormPTU - version 1.15.4.
 *                                              1.  Bug fix - SNCR002.41. Modified the Shown event handler and the Exit() method to clear and assert the KeyPreview 
 *                                                  property of the IMainWindow interface respectively. This ensures that any Key related events are not routed to the 
 *                                                  KeyDown event handler of the main application window when the child form is on display. In the previous 
 *                                                  implementation, pressing the F2 function key while displaying the watch window would acively toggle the Online 
 *                                                  ToolStripButton defined on the main application window.
 *                                          
 *                                              2.  Bug fix - SNCR002.41. Included a check in the event handler for each ToolStripButton Click event to ensure that the 
 *                                                  logic associated with the event handler is ignored if the control isn't enabled. This check is required because 
 *                                                  the event handler is also called by the FormPTU.Form_KeyDown() event handler whenever the function key associated 
 *                                                  with the ToolStripButton control is pressed. Consequently, in the previous implementation, the action associated 
 *                                                  with the ToolStripButton would be carried out whenever the user pressed the corresponding function key, regardless 
 *                                                  of whether the ToolStropButton control was enabled or not.
 *                                          
 *                                              3.  Removed the redundant ToolStripFunctionKeysPTU property.
 *                                      
 *                                              4.  Removed the redundant m_PanelInformation_Click() and m_ToolStrip_Click() event handlers as these did not appear to 
 *                                                  move the focus away from a selected user control.
 *                                                  
 *                                      9.  IPlotterWatch interface - version 1.3.
 *                                              1.  Added the Visible property of the control.
 *                                              2.  Made the Removed property Read/Write.
 *                                              3.  Included the SetHighlight() method to set the <c>UserControl</c> to the specified highlighted state.
 *                                              
 *                                      10. Modified the PlotterScalar - version 1.4, PlotterEnumerator - version 1.4 and PlotterBitmask - version 1.4 user controls.
 *                                              1.  Added support for the 'Show Definition' context menu option.
 *                                              2.  Changed the order of the context menu options so that the 'Show Definition' menu option was the first option. 
 *                                                  This was implemented to improve the positioning of the help window when the definition was displayed.
 *                                              3.  Made the Removed property read/write so that it may be manipulated by the 'Remove Selected Plot(s)' context menu 
 *                                                  event handler.
 *                                              4.  Modified the layout of a number of properties.
 *                                              5.  Added the SetHighlight() and ShowHelpPopup() methods.
 *                                              6.  Removed the redundant m_ButtonYAxisPlus_Click() and m_ButtonYAxisMinus_Click() event handlers.
 *                                              7.  Modified the m_ToolStripMenuItemRemove_Click() event handler to remove all selected Plotter derived user controls.
 *                                              8.  Added the event handler for the MouseDown event.
 *                                              9.  Modified the Size property such that the width of the Description label spans the full width of the user control up 
 *                                                  to the Units label. This ensures that the SetHighlight() method highlights the full width of the user control.
 *                                              10. Added the context menu Opened event handler to ensure that only the 'Remove Selected Plot(s)' context menu option is 
 *                                                  enabled if multiple controls are selected when the user opens the context menu.
 *                                                  
 *  10/26/11    1.17.12     K.McD       1.  Modified the FormWorksetDefine class. Changed the modifier of the ClearStatusMessage() method to protected and added the 
 *                                          WriteStatusMessage() method to allow child classes to write status messages.
 *                                          
 *                                      2.  Modified the FormConfigure class. Moved the location of the Panel control associated with the status message.
 *                                      
 *  10/28/11    1.17.13     K.McD       1.  Changed the CommunicationTypeEnum definition in the Parameter class to be: 0 - RS232, 1 - TCPIP, 2 - Both.
 *
 *	11/03/11	1.17.14		Sean.D		1.	General.cs:	Changed LoadDataDictionary to reject trying to load PTU Configuration.xml file with a clear error message.
 *										2.  PlotterControlLayout.cs:	Added check in ContextMenu_Opened for object type to prevent casting errors if a plot is selected
 *										    and the user right-clicks on the title.
 *										3.	Resources.resx:	Added MBTCantReloadDefaultConfig to the strings.
 *										    Note:	AssemblyInfo.cs was not included when revision 359, as described above, was checked in. Instead checked in as part
 *										    of 361.
 *										
 *	11/14/11	1.17.15		Sean.D		1.	FormDataStreamPlot.cs:	In Cleanup, added code to remove event handlers from m_PlotterControlLayout, set code to set the
 *	                                        m_TabControl to null, and moved the setting of variables to null after the code for removing the event handlers.
 *										2.	In Exit, added code to cycle through the tabs and call Dispose on each Plotter on the panels on the
 *										    tabs.
 *										3.	FormPTU.cs:	In Cleanup, added code to remove the Shown event and added checks to ensure MainWindow and
 *										    m_ToolStripFunctionKeysPTU are not null prior to accessing them.
 *										4.	PlotterEnumeratorParent.cs:	Modified DrawXYText to use "using" to ensure proper disposal of StringFormat and Pen objects. 
 *										5.	PlotterEnumeratorParent.Design.cs:	Modified Dispose to set ClientForm to null to ensure that all objects get disposed of when
 *										    out of scope.
 *										6.	PlotterScalar.Design.cs:	Modified Dispose to check Plot and ContextMenuStrip are not null prior to calling their Dispose
 *										    methods and to set ContextMenuStrip to null after Dispose has been run on it.
 *										
 *  11/23/11    1.17.16      K.McD      1.  Modified the FormDataStreamPlot and FormDataDtreamReplay classes.
 *                                              (a) Ensured that all event handler methods were detached and that the component designer variables were set to null on
 *                                                  disposal.
 *                                              (b) Modified the Escape_Click() and Exit() methods to ensure that no member variables were referenced after the Close() 
 *                                                  method had been called.
 *                                                  
 *                                      2. Ensured that all event handler methods were detached and that the component designer variables were set to null on disposal
 *                                          in the FormPTU class.
 *                                      
 *                                      3.  Implemented the standard Dispose()/Cleanup() implementation for the PlotterBitmask, PlotterEnumerator, PlotterEnumerator 
 *                                          and the PlotterScalar classes.
 *                                          
 *                                      4.  Ensured that all event handler methods were detached on disposal of all VariableControl derived user controls.
 *                                      
 *                                      5.  Ensured that all event handler methods were detached and that the component designer variables were set to null on disposal 
 *                                          of the Plotter user controls.
 *                                          
 *  12/01/11    1.17.17     K.McD       1.  Attached the m_Plotter_MouseDown() event handler method to the MouseDown events associated with the 'Description' and 'Units' 
 *                                          Labels in the PlotterEnumerator and PlotterScalar classes to ensure that the plotter is selected if the user clicks 
 *                                          on either of those controls.
 *                                          
 *                                      2.  Attached the m_Plotter_MouseDown() event handler method to the MouseDown events associated with the 'Description' Label in 
 *                                          the PlotterBitmask class to ensure that the plotter is selected if the user clicks on the control.
 *                                          
 *                                      3.  Modified the PlotterControlLayout class.
 *                                      
 *                                              1.  Added constants for the offset values required to access the Size, Font and BackColor properties from the parameter 
 *                                                  object array passed to the SetAestheticProperties() method.
 *                                          
 *                                              2.  Added check to skip the method logic if the plotterWatch parameter was null in the: SetAestheticProperties(), 
 *                                                  SetRangeProperties() and Reset() methods.
 *                                          
 *                                              3.  Added check to the SetAestheticProperties() method to skip the method logic if the length of the parameter array was 
 *                                                  invalid.
 *                                                  
 *                                      4.  Modified the FormDataStreamPlot class.
 *                                      
 *                                              1.  Corrected the F5_Click() method to ensure that the HistoricDataManager class is reset if the user has reset the plot 
 *                                                  layout to the default setting.
 *                                          
 *                                              2.  Modified the CallFunction() method.
 *                                      
 *                                                      1.  Included a check to continue to the next TabPage control if the tableLayoutPanel object associated with the 
 *                                                          current TabPage control is null.
 *                                                  
 *                                                      2.  Modified the check within the for loop to exit the loop when the current row index is >= the number of 
 *                                                          controls associated with the TableLayoutPanel control.
 *  
 *  02/08/12    1.17.18     Sean.D		1.	Modified Settings.Designer.cs to not set default values for HashCodeLevel1 and HashCodeLevel2.
 *										2.	Security.cs - Modified the hash codes provided for DefaultHashCodeLevel1, DefaultHashCodeLevel2, and DefaultHashCodeLevel3 
 *											to fit new hashing algorithm.
 *										3.	Security.cs - Removed a comment on DefaultHashCodeLevel3 which was inaccurate.
 *										4.	Security.cs - Changed Initialize() to draw the default hash codes for levels 1 and 2 from the constants rather than the 
 *											settings file.
 *										5.	Security.cs - Modified GetHashCode(string) to use a modified SHA256 to get the hash code instead of using String.GetHashCode 
 *											to avoid an error where 64 bit machines calculate the hash differently.
 *											
 *  02/14/12    1.17.19	    Sean.D		1.	Reverting Changes 1 and 4 above. Apparently that's how we save changed passwords.
 * 
 *  06/04/12    1.17.20     Sean.D      1.  Within FormWorksetDefine.cs:
 *                                          a.  Added the Protected m_RemovedItems member variable to track what items we've removed so that they can be re-added if the 
 *                                              dialog is canceled.
 *                                          b.  Modified m_ButtonCancel_Click to re-add removed items if the Cancel button is pressed.
 *                                          c.  Modified the Add method to properly track the removed items.
 */
#endregion - [1.17] -

#region - [1.18] -
/*
 *  06/04/12    1.18        K.McD       1.  Modifications associated with the NYCT - R188 Propulsion Car Control Unit Project. Added support for the
 *                                          WibuBox security device.
 *                                              1.  Corrected the file name in the header of the DataDictionaryInformation.cs file.
 *                                              2.  Modified the XML tag associated with the DataDictionaryInformation_t structure.
 *                                              3.  Added the NewPara constant to the CommonConstants class.
 *                                              4.  Added the project information strings to the CommonConstants class.
 *                                              5.  Added support for the WibuBox parameters in the Parameter class.
 *                                              6.  Added the WibuBox_t structure definition (WibuBox.cs).
 *                                              7.  Corrected the Open() method in the DebugMode class. The call to StreamWriter() now specified the
 *                                                  fully qualified filename of the debug file.
 *                                              8.  Modified the PathWorksetFiles property of the DirectoryManager class to use the the '\Bombardier
 *                                                  \Portable Test Unit\Workset Files' sub-directory of the directory that serves as the common
 *                                                  repository for the current roaming user (User Application Data directory) rather than the 
 *                                                  startup directory.
 *                                              9.  Added support for a WibuBox security device to the MenuInterface class.
 *                                              10. Unticked the 'Enable the Visual Studio hosting process' and the 'Enable unmanaged code debugging'
 *                                                  boxes on the Debug tab page of the project Properties page for the Release configuration.
 *                                                  Note: Both are enabled for the Debug configuration.
 *                                                  
 *  07/16/13    1.18.1     K.McD        1.  Modified the PathPTUConfigurationFiles property of the DirectoryManager class to use the
 *                                          '\Bombardier\Portable Test Unit\PTU Configuration Files' sub-directory of the directory that serves as the
 *                                          common repository for the current roaming user (User Application Data directory) rather than the
 *                                          startup directory.
 *                                          
 *                                          This modification was the result of an exception being thrown when, following an update of the
 *                                          configuration file to a newer version, the PTU detected a mismatch between the version of the
 *                                          configuration file and that of the embedded software. This mismatch resulted in the PTU asking if the
 *                                          user wanted to select the data dictionary associated with the current embedded software. On selecting Yes,
 *                                          an UnauthorizedAccessException was thrown when the PTU tried to copy the matched configuration file to
 *                                          PTU Configuration.xml because the \Configuration Files sub-directory did not have write-enabled access
 *                                          for the standard user.
 *                                          
 *  07/24/13    1.18.2      K.McD       On systems where the number of fault log watch variables is fixed, only allow the user to add the specified
 *                                      number of watch variables to each Fault Log workset. Also, display the allowed number of watch variables on
 *                                      the forms used to configure the fault log parameters and to define the worksets.
 *                                      
 *                                      1.  Modified the BuildDataStreamTypeParametersTable() method of the LogTable class to include the
 *                                          WatchVariablesMax and Name fields from the DataStreamTypes table.
 *                                      2.  Added the WatchVariablesMax and Name fields to the DataStreamTypeParameters_t structure.
 *                                      3.  Modified the Parameter class:
 *                                              1.  Removed the WatchSizeFaultLogMax constant.
 *                                              2.  Added support for the WatchSizeFaultLog and SupportsMultipleDataStreamTypes properties.
 *                                              3.  Added the DefaultDataStreamTypeWatchVariablesMax constant.
 *                                      4.  Automatic update of the Workset class as a result of replacing the WatchSizeFaultLogMax constant with the
 *                                          WatchSizeFaultLog property in the Parameter class.
 *                                      5.  Added the WatchVariablesMax field to the DataStreamTypes table of DataDictonary.mdb.
 *                                      6.  Updated DataDictionary.xsd to reflect the modified structure of the DataStreamType table. Note: Automatic
 *                                          update of DataDictionary.Designer.cs.
 *                                      7.  Modified the FormWorksetDefine class to allow the EntryCountMax property to be updated by child classes
 *                                          by adding the, protected, m_EntryCountMax variable, initializing this to m_WorksetCollection.EntryCountMax
 *                                          in the constructors and defining the EntryCountMax property to return this value rather than 
 *                                          m_WorksetCollection.EntryCountMax. 
 *                                          
 *                                          This requirement is only associated with projects that do not record a fixed number of watch variables for
 *                                          each event log. Under these circumstances, the EntryCountMax property is set to the number of watch
 *                                          variables associated with the event log that can record the largest number of watch variables. 
 *                                          Consequently, the list of fault log worksets will consist of worksets associated with each datastream
 *                                          type. When the user configures the fault log parameters, using a child of this form, it is possible that a
 *                                          workset is selected that exceeds the permitted number of watch variables for the current event log,
 *                                          however, by allowiing the form to update the EntryCountMax property it is possible to manage this much
 *                                          better.
 *                                          
 *  07/31/13    1.18.3      K.McD       1.  Modified the LoadDictionary() method of the General class to copy the source file to the file that is
 *                                          defined as the current XML data dictionary file rather than the default XML data dictionary file. The
 *                                          current XML data dictionary filename can specify either: (a) the default XML data dictionary file or
 *                                          (b) the project XML data dictionary file.
 *                                          
 *                                      2.  Added the FilenameDataDictionary property to the IMainWindow interface definition, this specifies the
 *                                          filename of the current XML data dictionary filename.
 *                                      
 *  08/02/13    1.18.4      K.McD       1.  Increased the width, in pixels, of the name field associated with the watch control from 200 to 230 in the
 *                                          WatchControlLayout class to prevent some of the longer variable names being displayed incorrectly. 
 *                                          
 *                                          In the WatchControl user control, the label associated with the variable name has the TextAlign property
 *                                          set to MiddleLeft and the AutoEllipsis property set to True. If the variable name text, when printed using
 *                                          the selected font, exceeds the width of the label the text is automatically aligned to TopLeft, truncated
 *                                          and an ellipsis i.e. '...' is appended to the text to show that it has been truncated. Although the text
 *                                          is still readable, it appears vertically misaligned.
 *                                          
 *  08/05/13    1.18.5      K.McD       1.  For all Label controls that make up the VariableControl user control, changed the TextAlign property from
 *                                          MiddleLeft/MiddleRight to TopLeft/TopRight, as appropriate, and modified the Padding property to 0,5,0,0.
 *                                          This prevents misalignment of the display when the width of the text string associated with the label
 *                                          exceeds the width of the label.
 *                                          
 *                                      2.  Changed the WidthWatchControlVariableNameField constant in the WatchControlLayout class to 210 to optimize
 *                                          the size of the the Watch Window user controls for a display resolution of 1280 x 960.
 *                                          
 *                                      3.  Modified the FormPTU class to change the text associated with the escape key from 'Esc - Home' to 'Esc' to
 *                                          prevent overflow when using larger fonts.
 *                                      
 *                                      4.  Modified the Parameter class to allow different default fonts to be specified for Windows XP and Windows
 *                                          7.
 *                                              1.  Replaced the constants DefaultFontFamily and DefaultFontSize with DefaultFontFamilyXP and
 *                                                  DefaultFontSizeXP respectively.
 *                                              2.  Added the constants DefaultFontFamilyWin7 and DefaultFontSizeWin7.
 *                                              3.  Set the default font and sizes to be Tahoma - 8pt for Windows XP and Segoe UI - 8.25pt for Windows
 *                                                  7.
 *                                              
 *  08/06/13    1.18.6      K.McD       1.  Added the 'Remove Selected Plot(s)' ToolStripMenuItem control as a property to the IPlotterWatch interface
 *                                          definition to allow client programs to access the properties of this context menu option. Specifically to
 *                                          allow the menu option to be enabled/disabled as it is not appropriate when viewing fault logs that have
 *                                          just been downloaded from the VCU. Updated PlotterBitmask, PlotterScalar and PlotterEnumerator, which all
 *                                          include the interface definition, accordingly.
 *                                          
 *  08/07/13    1.18.7      K.McD       1.  Modified the MenuInterface class. In those methods where it is applicable, the cursor was set to the wait
 *                                          cursor after the call to the MainWindow.CloseChildForms() method as if any child forms are open, the
 *                                          cursor may be set to the default cursor as part of the call to the Exit() method within the child form.
 *                                          
 *                                      2.  Modified the PTUDLL32 class as follows:
 *                                              1.  Changed the order of the methods to match the order defined in the prototype 
 *                                                  list and Com.cpp.
 *                                              2.  Added SetWatchSize() to the prototype list.
 *                                              3.  Changed the prototype definition of the GetEmbeddedInformation() method to use: 
 *                                                  [MarshalAs(UnmanagedType.BStr)]
 *                                                  
 *                                      3.  Modified CommunicationParent as follows:
 *                                              1.  Corrected the call to PTUDLL32.GetEmbeddedInformation() in the GetEmbeddedInformation() method to
 *                                                  pass 'out localTargetConfiguration.ConversionMask' rather than
 *                                                  'out targetConfiguration.ConversionMask'.
 *                                              2.  Changed the call to PTUDLL32.GetChartMode() in the GetChartMode() method to 
 *                                                   match the new prototype, now uses 'out' rather than 'ref'.
 */
#endregion - [1.18] -

#region - [1.19] -
/*
 *  03/17/15     1.19   K.McD       References
 *                                  1.  Upgrade the PTU software to extend the support for the R188 project as defined in purchase order
 *                                      4800010525-CU2/19.03.2015.
 *  
 *                                      1.  Changes outlined in the email to Mark Smorul on 30th May 2014 – PTUDLL32 modifications 
 *                                          to support both 32 and 64 bit architecture.
 *                                          
 *                                      2.  Changes to allow the PTU to handle both 2 and 4 character date codes.
 *  
 *                                      3.  Changes to address the items outlined in the minutes of the meeting between BTPC, 
 *                                          Kawasaki Rail Car and NYTC on 12th April 2013 - MOC-0171:
 *                                          
 *                                              1.  MOC-0171-06. All references to 'Fault Logs', including menu options and directory 
 *                                                  names, to be replaced by 'Data Streams' for all projects.
 *                                                  
 *                                              2.  MOC-0171-18. The ‘Time’ legend will be reserved for system information time, the legend 
 *                                                  ‘PC Time’ will be used when displaying the PC time.
 *                                                  
 *                                              3.  MOC-0171-27. All occurrences of the ‘Edit’ legend, including function key legends and context menu
 *                                                  options will be replaced with the ‘Modify’ legend on ALL projects.
 *                                                  
 *                                              4.  MOC-0171-29/34. Kawasaki requested that any function that is not available to the current mode, either Maintenance
 *                                                  or Administrative, should not be displayed, or be 'greyed out'. BTPC agreed to review the software to ensure that
 *                                                  non-active menu items are ‘greyed out’ or not shown.
 *                                                  
 *                                              5.  MOC-0171-28. A check will be included as part of the ‘Save’ procedure to ensure that an empty workset cannot be saved.
 *                                          
 *                                                  As a result of a review of the software, it is proposed that it should only be possible to save a workset if the
 *                                                  following criteria are met:
 *                                              
 *                                                      1.  The workset must contain at least one watch variable.
 *                                                      2.  The workset must have a valid name that is not currently in use.
 *                                                  
 *                                  2.  Updated Resources with a number of premium 28 x 28 images purchased from Iconfinder.
 *                                     
 *                                  3.  SNCR - R188 PTU [20 Mar 2015] item 1. When trying to build version 1.19 of Common.dll the following error message was displayed
 *                                      "Error 4 'Common.Configuration.DataDictionary' does not contain a definition for 'LOG' and no extension method 'LOG' accepting
 *                                      a first argument of type 'Common.Configuration.DataDictionary' could be found (are you missing a using directive or an assembly
 *                                      reference?)".
 *                                      
 *                                  4.  SNCR - R188 PTU [20 Mar 2015] Item 3. Menu option 'Configuration/Worksets/Data Stream'. If, while editing a workset, the user
 *                                      removes one or more watch variables from the workset and then selects the 'Cancel' button; when the workset is re-opened,
 *                                      the 'Available' ListBox contains the watch variables that were previosly removed from the workset.
 *                                      
 *                                  5.  SNCR - R188 PTU [20 Mar 2015] Item 8. When using the 'Tools/Convert Engineering Database' menu option (Factory Mode Only)
 *                                      to convert the .e1 database to an XML configuration file; if any of the tables that are not automatically generated by the
 *                                      Data Dictionary Builder utility have not been manually updated correctly then the conversion should be terminated and the
 *                                      table where the error was detected should be reported to the user.
 *                                      
 *                                  6.  SNCR - R188 PTU [20 Mar 2015] Item 9. Do not throw an exception if the flag returned from a call to the
 *                                      WinHelp engine isn't true.
 *                                              
 *                                  Modifications
 *                                  1.  Deleted: PTUDLL32. Ref.: 1.1.
 *                                  2.  Added: VcuCommunication64.cs. Rev. 1.0. Ref.: 1.1, 1.2.
 *                                  3.  Modified: VcuCommunication32.cs. Rev. 1.6. Ref.: 1.1, 1.2.
 *                                  4.  Modified: CommunicationParent.cs. Rev. 2.0, Ref.: 1.1, 1.2.
 *                                  5.  Resources.resx. Ref.: 1.3.1, 1.3.2, 1.3.3, 2, 5. Also changed ToolTipText to be contained within square brackets
 *                                      e.g. F4 - [Continue].
 *                                  6.  Modified: FormConfigure.Designer.cs. Rev. 1.2 FormPlotDefine.Designer.cs. Rev. 1.1.
 *                                      FormWorksetDefine.Designer.cs. Rev. 1.11. - Ref.: 1.3.3.
 *                                  7.  Modified: FormWorksetManager.resx. Ref.: 1.3.3.
 *                                  8.  Modified: FormDataStreamPlot. Rev. 1.18. Ref.: 1.3.3.
 *                                  9.  Modified: FormDataStreamReplay.cs. Rev. 1.18. Ref.: 1.4.
 *                                  10. Modified: FormPTU.Designer.cs. Rev. 1.7. Ref.: 1.2, 1.1.4.
 *                                  11. Modified: Parameter.cs. Rev. 1.12. Ref.: 1.1, 1.2, 3.
 *                                  12. Modified: General.cs. Rev. 1.13. - Ref. 1.2.
 *                                  13. Modified: ICommunicationApplication.cs. Rev. 1.1. - Ref.: 1.2.
 *                                  14. Modified: CommonConstants.cs. Rev. 1.12. - Ref.: 1.3.4.
 *                                  15. Modified: FormWorksetDefine. Rev. 1.11. - Ref.: 1.3.5.
 *                                  16. Modified: FormConfigure.cs. Rev.: 1.9, FormPlotDefine.cs. Rev. 1.1. - Ref.: 1.3.5.
 *                                  17. Modified: DataDictionary.mdb and DataDictionary.xsd to include the YearCodeSize field. Ref.: 1.2.
 *                                  18. Modified: DataDictionary.cs. Rev. 1.7. Ref.: 5.
 *                                  19. Modified: WinHlp32.cs. Rev. 1.4. Ref.: 6.
 *                                  
 */
#endregion - [1.19] -

#region -[1.20] -
/*
 *  04/15/15    1.20    K.McD       References
 *              
 *                                  1.  Upgrade the PTU software to extend the support for the R188 project as defined in purchase order
 *                                      4800010525-CU2/19.03.2015.
 *                                      
 *                                      1.  Changes to address the items outlined in the minutes of the meeting between BTPC, Kawasaki Rail Car and NYTC on
 *                                          12th April 2013 - MOC-0171:
 *                                              
 *                                          1.  MOC-0171-06. All references to 'Fault Logs', including menu options and directory names to be replaced by 'Data Streams'
 *                                              for all projects.
 *
 *                                      2.  NK-U-6505 Section 5.1.3. Log File Naming. The filename of all event logs, fault logs, real time data etc will be modified to
 *                                          meet the KRC specification. This modification will be specific to the KRC project; for all other projects, the current naming
 *                                          convention will still apply.
 *                                          
 *                                      3.  NK-U-6505 Section 2.2. Mandatory MDI Global Screen Representation - Part 1. The proposal is to add additional status
 *                                          labels to the status bar at the bottom of the PTU screen to include ‘Log: [Saved | Unsaved]’ and
 *                                          ‘WibuBox: [Present | Not Present]’.
 *              
 *                                  2.  Although only relevant to Bombardier Field Service Engineers that support a number of PTU projects, the Software User Manual and
 *                                      Release Notes documents are to be made project specific by prepending the project identifier to the file name e.g.
 *                                      'R8PR.Portable Test Unit - Release Notes.pdf', 'CTPA.Portable Test Unit - Release Notes.pdf' etc.
 *                                      
 *                                  3.  SNCR - R188 PTU [20 Mar 2015] Item 10. If, while viewing a saved datasteam in replay mode, that has been accessed from the
 *                                      'Open/Event Log' screen, the user opens one or more 'Show Flags' dialog boxes and then selects the 'Back' (Esc) key, these
 *                                      dialog boxes are not automatically closed. If the user then tries to close these dialog boxes once the PTU has returned to the
 *                                      Open/Event Log' screen, an exception is thrown. On further investigation it was discovered that these dialog boxes are not
 *                                      automatically closed if the user uses the F4 key to toggle between the 'Replay' and the'YTPlot' screens.
 *                                      
 *                                  4.  The 'Tools/Convert Engineering Database' menu option is to be modified to generate the XML file from two separate (.e1) files.
 *                                      The first file is the engineering data dictionary (.e1) database that is generated automatically from the Database Builder
 *                                      Utility. The second file is a project specific PTU configuration database that contains the following supplemental tables that
 *                                      are required for the correct operation of the PTU: CONFIGUREPTU, DataStreamTypes, LOGS, Security and URI. Partly populated
 *                                      CONFIGUREPTU and LOGS tables are created by the Database Builder Utility in the engineering data dictionary (.e1) database,
 *                                      however, these tables are ignored in the conversion process. The information contained in these partly populated tables can be
 *                                      useful when initially setting up the tables in the project PTU configuration database. 
 *                                      
 *                                      Both files are selected by the user and should be, ideally, located in the 
 *                                      '<User Application Data>\Bombardier\Portable Test Unit\PTU Configuration Files' sub-directory. The convention
 *                                      is to name the project PTU configuration database '<project-id>.PTU Configuration.e1' e.g. R8PR.PRU Configuration.e1.
 *                                      
 *                                      The purpose for this change is that once the project PTU configuration database is set up, new vesions of the XML file can
 *                                      be easily created using the Database Builder Utility as the output of the utility can be directly used to create the new XML 
 *                                      file whereas before, the supplemental tables had to be added manually to the (.e1) file output from the Database Builder Utility.
 *                                      
 *                                  5.  A FunctionFlags bitmask field is to be added to the  CONFIGUREPTU table. This field is a bitmask that specifies the function
 *                                      options that are required for the current project. So far, the following flags have been defined:
 *
 *                                          Bit 0   -   Use4DigitYearCode - Flag to specify whether the project VCU uses a 2 or 4 digit year code. True, if the project
 *                                                      uses a 4 digit year code; otherwise, false.
 *                                          Bit 1   -   ShowEventLogType - Flag to specify whether the event log type field is to be shown when saved event logs are
 *                                                      displayed. True, if the log type is to be displayed; otherwise, false.
 *                                          .
 *                                          .
 *                                          .
 *                                          Bit 7   -   Not Used.
 *                                          
 *                                  6.  The height of the event variable user control must be increased to allow characters such as 'g', 'j', 'p', 'q', 'y' to be 
 *                                      displayed correctly when using the default font.
 *                                      
 *                                  Modifications
 *                                  1.  Modified: DataStream.cs. Rev. 1.4, FormDataStreamReplay.cs. Rev. 1.19, FileHandling.cs. Rev. 1.11. - Ref.: 1.1.1, 1.2.
 *                                  2.  Modified FormPTU.cs. Rev. 1.16. - Ref.: 1.2, 2, 3.
 *                                  3.  Modified: Resources.resx. - Ref.: 2, 4. app.config, Settings.settings. - Ref.: 4.
 *                                  4.  Modified General.cs. Rev. 1.14. - Ref.: 1.2, 4.
 *                                  5.  Modified FormDataStreamReplay.cs. Rev. 1.19. - Ref.: 3.
 *                                  6.  Modified CommonConstants.cs. Rev. 1.12. - Ref.: 5.
 *                                  7.  Added PTU Configuration.mdb. - Ref.: 4, 5.
 *                                  8.  Modified DataDictionary.xsd, DataDictionary.cs. Rev. 1.7. - Ref.: 4
 *                                  9.  Modified EventControl.Designer.cs. Rev. 1.1. - Ref.: 6.
 *                                  10. Modified Parameter.cs. Rev. 1.13. - Ref.: 5.
 *                                  11. Modified IMainWindow. Rev. 1.12. - Ref.: 1.3.
 */
#endregion -[1.20] -

#region - [1.21] -
/*
 *  05/12/15    1.21    K.McD       References
 *                                  1.  Upgrade the PTU software to extend the support for the R188 project as defined in purchase order
 *                                      4800010525-CU2/19.03.2015.
 *                                      
 *                                      1.  Changes to address the items outlined in the minutes of the meeting between BTPC, 
 *                                              Kawasaki Rail Car and NYTC on 12th April 2013 - MOC-0171:
 *                                                  
 *                                              1.  MOC-0171-30. The ‘F4 – Rec.’ Function key will toggle between the industry standard icons
 *                                                  representing stop and start recording.
 *                                                  
 *                                              2.  MOC-0171-26. Kawasaki pointed out that Chart Recorder tabs are identified as ‘COLUMNS’ and requested that this
 *                                                  be changed.
 *                                              
 *                                                  For Chart Recorder and Data Stream worksets, the GroupBox will now be titled 'Workset Layout', as per the
 *                                                  'Watch Window' workset, and the TabPage header will show the type of workset i.e. 'Data Stream' or
 *                                                  'Chart Recorder'. For the Data Stream 'Create/Edit Workset' and 'Configure' dialog boxes, if the project does
 *                                                  not support multiple data stream types and the number of data stream channels does not exceed 16, it is proposed to
 *                                                  add a row header showing the channel numbers 1 - 16. If the project supports multiple data streams or the number
 *                                                  of parameters exceeds 16 then the row header will not be shown. The form used to define the plot layout of
 *                                                  data stream files will also display the type of workset in the TabPage header.
 *                                      
 *                                      2.  NK-U-6505 Section 2.2. Mandatory MDI Global Screen Representation - Part 1. The proposal is to add additional status
 *                                          labels to the status bar at the bottom of the PTU screen to include ‘Log: [Saved | Unsaved]’ and
 *                                          ‘WibuBox: [Present | Not Present]’.
 *                                          
 *                                  2.  SNCR - R188 PTU [20 Mar 2015] Item 15. While trying to modify the plot layout of a data stream that had been created as part
 *                                      of the CTA PTU installation, the exception ‘ER-150506 – Attempt to modify default plot layout’ was thrown. On further
 *                                      investigation, it was discovered that files that are created as part of the PTU installation are read only for the current
 *                                      user, even if they have administrative privileges. On changing the plot layout the exception is thrown on attempting to
 *                                      write the new layout to disk.
 *                                      
 *                                  3.  The 'Tools/Convert Engineering Database' menu option is to be modified to track the read directory where the engineering
 *                                      data dictionary (.e1) database and the project specific PTU configuration(.e1) database are located. This directory will
 *                                      remain the default directory for the remainder of the session.
 *                                      
 *                                  4.  SNCR - R188 PTU [20 Mar 2015] Item 17. If the user uses the ‘Remove Selected Plot(s)’ context menu option to remove one or more
 *                                      plots from the 'File/Open/Watch File', 'File/Open/Data Stream', or 'File/Open/Simulated Data Stream' screen, the
 *                                      ‘Modified Layout’ status message is not displayed until the screen is closed and then re-loaded from disk. Also, if the user
 *                                      toggles between the Replay and Plot screens the ‘Modified Layout’ status message is cleared.
 *                                      
 *                                  5.  SNCR - R188 PTU [20 Mar 2015] Item 13. On project R188, the bitmask flags associated with the ‘IPA Status’ bitmask do not tie
 *                                      in with the bitmask value of 0x1034 as the FormShowFlags dialog box shows the first two flags associated with the bitmask as
 *                                      being asserted. On further investigation it was found that the first two bits of the ‘IPA Status’ bitmask had not been defined
 *                                      and were therefore not added to the list of bitmask flags shown by the FormShowFlags dialog box.
 *                                      
 *                                  6.  Hide the ToolTip text for the [First], [Next], [Previous] and [Last] function keys on the 'Replay' screens as these ToolTips
 *                                      obscure the [Frame No.] information label.
 *                                      
 *                                  7.  SNCR - R188 PTU [20-Mar-2015] Item 18. If the user uses the dragdrop feature of FormPlotDefine to modify the plot layout, 
 *                                      the OK and Apply buttons are not enabled.
 *                                      
 *                                  8.  SNCR - R188 PTU [20-Mar-15] Item 19. Until the engineering password is actively set to the default value using the
 *                                      'Configure/Password Protection' menu option it does not allow access to the engineering security level. On further investigation
 *                                      it was found that the HashCodeLevel1 and HashCodeLevel2 values associated with the Common Settings file had not been updated since
 *                                      the hashing algorithm was changed by Sean Duggan on 7-Feb-12. The HashCodeLevel1 and HashCodeLevel2 values were updated in
 *                                      the Settings file and the problem appears to be resolved. An investigation is still required as to why the password appeared to
 *                                      work on earlier releases of the PTU.
 *                                  
 *                                  Modifications
 *                                  1.  IMainWindow.cs. Rev. 1.12.
 *                                  2.  Resources.resx. Ref.: 1.2, 2, 4.
 *                                  3.  FileHandling.cs. Rev. 1.12. - Ref.: 2.
 *                                  4.  General.cs. Rev. 1.15. - Ref.: 3.
 *                                  5.  PlotterControlLayout.cs. Rev. 1.14, FormDataStreamPlot.cs. Rev. 1.19. - Ref.: 4.
 *                                  6.  CommunicationParentOffline.cs. Rev. 1.5. - Ref.: 1.2.
 *                                  7.  InitialDirectory.cs. Rev. 1.1. - Ref.: 3.
 *                                  8.  VariableTable.Generic.cs. Rev.: 1.6. - Ref.: 5.
 *                                  9.  FormWatch.Designer.cs. Rev. 1.1. - Ref.: 1.2.
 *                                  10. FormPTU.cs. Rev. 1.17, FormPTU.Designer.cs. Rev. 1.8. - Ref.: 6.
 *                                  11. FormPlotDefine.cs. Rev. 1.2 , FormPlotDefine.Designer.cs. Rev. 1.2. - Ref.: 7, 1.1.2.
 *                                  12. FormDataStreamReplay.cs. Rev. 1.20. - Ref.: 1.1, 1.2, 4.
 *                                  13. Settings.settings. Ref.: 8.
 */
#endregion - [1.21] -

#region - [1.22] -
/*  07/13/15    1.22    K.McD           References
 *                                      1.  Upgrade the PTU software to extend the support for the R188 project as defined in purchase order
 *                                          4800010525-CU2/19.03.2015.
 *                                          
 *                                          1.  NK-U-6505 Section 2.2. Mandatory MDI Global Screen Representation - Part 1. Following a conference call on 9-Jul-15,
 *                                              the current proposal is to extend the options associated with the log saved status StatusLabel to include:
 *                                              ‘[Saved | Unsaved | Unknown | Not Applicable (-)]’.
 *                                              
 *                                          2.  NK-U-6505 Section 2.2. Mandatory MDI Global Screen Representation - Part 2.  Addition of the Control Panel window.
 *                                          
 *                                          3.  NK-U-6505 Section 5.1.3. Log File Naming. The filename of all event logs, fault logs, real time data etc will be
 *                                              modified to meet the KRC specification. This modification will be specific to the KRC project; for all other projects,
 *                                              the current naming convention will still apply.
 *                                              
 *                                      Modifications
 *                                      1.  IMainWindow.cs. Rev. 1.13. Added Configuration.MostRecentDownloadedEvents.cs. Rev. 1.0. - Ref. 1.1.
 *                                      2.  CommonConstants.cs. Rev. 1.13. - Ref. 1.2.
 *                                      3.  General.cs. Rev. 1.13. - Ref.: 1.3.
 */

#endregion - [1.22] -

#region - [1.23] -
/*
 *  07/24/15    1.23    K.McD       References
 *                                  1.  Part 1 of the upgrade to the Chicago 5000 PTU software that allows the user to download the configuration and help files for
 *                                      a particular Chicago 5000 vehicle control unit (VCU) via an ethernet connection to the FTP (File Transfer Protocol) server
 *                                      running on the VCU. The scope of Part 1 of the upgrade is defined in purchase order 4800011369-CU2 07.07.2015.
 *                                      
 *                                      The upgrade is implemented in two parts, the first part, Part 1, replaces the existing screens and logic with those outlined
 *                                      in slides 6, 7, 8 and 9 of the PowerPoint presentation '076_CTA - PTU file pullback from VCU - 20150127.pptx', but does NOT
 *                                      implement the file transfer; it merely calls an empty external batch file from within the PTU application. The second stage,
 *                                      Part 2, implements the batch file that downloads the configuration and help files from the Vehicle Control Unit (VCU) to the
 *                                      appropriate directory on the PTU computer. As described in the PowerPoint Presentation, this download is only carried out if the
 *                                      appropriate configuration file is not already present on the PTU computer.
 *                                      
 *                                  2.  An informal review of version 6.11 of the PTU concluded that, where possible - i.e. if the PTU is started from a shortcut
 *                                      that passes the project identifier as a shortcut parameter, the project specific PTU initialization should be carried out
 *                                      in the MDI Form contructor that has the parameter string array as its signature rather than by the LoadDictionary() method.
 *                                      This streamlines the display construction of the Control Panel associated with the R188 project. In the 6.11 implementation
 *                                      the CTA layout is momentarily displayed before the Control Panel is drawn, however by initializing the project specific
 *                                      features in the constructor the Control Panel associated with the R188 project is drawn immediately and the CTA layout
 *                                      is not shown at all.
 *                                      
 *                                  3.  Bug Fix - SNCR - R188 PTU [20-Mar-2015] Item 21. It is possible to load a data dictionary that is not associated with the
 *                                      current project, i.e. the project associated with the project identifier that was passed via the desktop shortcut, when using
 *                                      the 'File/Select Data Dictionary' menu option. It is also possible to select the '<project-identifier>.PTU Configuration.xml'
 *                                      file.
 *  
 *                                  Modifications
 *                                  1.  MenuInterface.cs. Rev. 1.12. - Ref.: 2.
 *                                  2.  General.cs. Rev.1.17. - Ref.: 2, 3.
 *                                  3.  IMainWindow.cs Rev. 1.14. - Ref.: 1, 2.
 *                                  4.  Resources.resx. - Ref.: 3.
 */
#endregion - [1.23] -

#region - [1.24] -
/*
 *  08/11/15    1.24    K.McD           References
 *                                      1.  Changes resulting from documents: 'PTU MOC Findings - .docx' and 'PTU Installation on 64-bit Machine_v1-08022015.docx' sent
 *                                          from Atul Chaudhari on 4th Aug 2015 and the follow up email sent on 5th Aug 2015.
 *                                      
 *                                          1.  On the R188 project only, all references to 'PTU' are to be replaced with 'PTE' and all occurrences of 'Portable Test
 *                                              Unit' are to be replaced with 'Portable Test Equipment'. Where support for multiple legends is not possible, 'Portable
 *                                              Test Application' is to be used as an alternative to 'Portable Test Unit'/'Portable Test Equipment.
 *                                              
 *                                      2.  Bug Fix - SNCR - R188 PTU [20-Mar-2015] Item 27. If the Factory user uses the ‘Select Data Dictionary’ menu option to update
 *                                          the configuration file, or, the PTU tries to update the configuration file because of a mismatch between the version of the
 *                                          embedded software and that of the XML configuration file; the selected file is not copied across to the project default
 *                                          configuration file, consequently, the next time that the application is run; the PTU reports that it cannot locate the default
 *                                          project configuration file.
 *                                          
 *                                      3.  Bug Fix - SNCR - R188 PTU [20-Mar-2015] Item 28. If the project requires a Wibu-Key and the files ‘Configuration.xml’ and
 *                                          ‘project-identifier.Configuration.xml’ do not exist, there is a problem trying to log on as a Factory user in order to
 *                                          select the required data dictionary file.
 *                                          
 *                                          As the project-identifier is now passed as a desktop shortcut parameter, the Wibu-Key timer is initialized in the MDI
 *                                          constructor, if required; as soon as the user tries to log on they are automatically logged out as the initialized timer
 *                                          calls the WibuBoxCheckIfRemoved() method which returns a value of true because the FormLogin Form is instantiated without
 *                                          first calling the WibuBoxCheckForValidEntry() method as the Parameter.ProjectInformation.ProjectIdentifier parameter used
 *                                          in the call to WibuBoxCheckIfRequires() is still set to string.Empty at that stage as no data dictionary had been selected.
 *                                              
 *                                      Modifications
 *                                      1.  AssemblyInfo.cs. Rev. 1.24. Changed the ApplicationProduct attribute to 'Portable Test Application'. - Ref.: 1.1.
 *                                      2.  Resources.resx. - Ref.: 1.1.
 *                                          1.  Removed any reference to PTU in the message box captions e.g. replaced 'PTU - Error' with 'Error'.
 *                                          2.  Changed 'PathRelativePTUApplicationData' from '\Bombardier\Portable Test Unit' to
 *                                              '\Bombardier\Portable Test Application'.
 *                                          3.  Removed 'PathRelativeSoftwareUserManual' and 'PathRelativeReleaseNotes'. No longer used.
 *                                          4.  Renamed 'PathRelativePTUConfigurationFiles' to 'PathRelativeConfigurationFilesPTU'.
 *                                          5.  Removed 'FilenameSoftwareUserManual'.
 *                                          6.  Added 'FilenameSoftwareUserManualPTE' and 'FilenameSoftwareUserManualPTU'.
 *                                          7.  Changed 'PathRelativeConfigurationFilesPTU' from '\PTU Configuration Files' to '\Configuration Files'.
 *                                          8.  Changed 'FilenameDefaultDataDictionary' from 'PTU Configuration.xml' to 'Configuration.xml.
 *                                          9.  Changed 'FileMnemonicDefaultWorkset' from 'PTU Workset' to 'Workset'.
 *                                         
 *                                      3.  FormPTU.cs. Rev. 1.18. - Ref.: 1.1.
 *                                      4.  DirectoryManager.cs. Rev. 1.3. Auto-update as a result of 2. - Ref.: 1.1.
 *                                      5.  General.cs. Rev. 1.18. - Ref.: 2.
 *                                      6.  MenuInterface.cs. Rev. 1.13. - Ref.: 3.
 */
#endregion - [1.24] -

#region - [1.25] -
/*
 *  08/26/15    1.25    K.McD       References
 *                                  1.  Part 2 of the upgrade to the Chicago 5000 PTU software that allows the user to download the configuration and help files for
 *                                      a particular Chicago 5000 vehicle control unit (VCU) via an ethernet connection to the FTP (File Transfer Protocol) server
 *                                      running on the VCU. The scope of Part 2 of the upgrade is defined in purchase order  4800011369-CU2 28.07.2015.
 *                                      
 *                                      The upgrade is implemented in two parts, the first part, Part 1, replaces the existing screens and logic with those outlined
 *                                      in slides 6, 7, 8 and 9 of the PowerPoint presentation '076_CTA - PTU file pullback from VCU - 20150127.pptx', but does NOT
 *                                      implement the file transfer; it merely calls an empty external batch file from within the PTU application. The second stage,
 *                                      Part 2, implements the batch file that downloads the configuration and help files from the Vehicle Control Unit (VCU) to the
 *                                      appropriate directory on the PTU computer. As described in the PowerPoint Presentation, this download is only carried out if the
 *                                      appropriate configuration file is not already present on the PTU computer.
 *                                      
 *                                  2.  Bug Fix - SNCR - R188 PTU [20-Mar-2015] Item 30. Whenever the Solution is built, a 'Configuration' sub-directory is
 *                                      created under the 'Release' or 'Debug' directory that contains the file 'PTU Configuration.mdb'.
 *                                      
 *                                  Modifications
 *                                  1.  DirectoryManager.cs. Rev. 1.4. - Ref.: 1.
 *                                  2.  Renamed 'PTU Configuration.mdb' to 'Configuration.mdb' and changed the 'Copy to output directory' file property to
 *                                      'Do not copy'. - Ref. 2. 
 * 
 */
#endregion - [1.25] -

#region - [1.26] -
/*
 *  09/30/15    1.26    K.McD       References
 *                                  1.  Bug Fix - SNCR - R188 [20-Mar215] Item 32. The R188 project requires that the PTE can be used on a 1024 x 768 laptop.
 *                                      When release 6.14 is displayed at a resolution of 1024 x 768: (a) the ‘Help’ and ‘Exit’ buttons at the bottom of the control panel
 *                                      are partly cut off (b) the ‘View/Event Log’, ‘View/Test Results’ and ‘Data Stream Replay’ screens are only fully visible
 *                                      (without resorting to the horizontal scroll bar) if the R188 control panel is removed; (c) the ‘Open/Saved Event Log’ screen
 *                                      is not fully visible because of the additional ‘real-estate’ occupied by the ‘[Log]’ column of the DataGridView
 *                                      control; and (d) the watch worksets can only use 2 of the 3 available columns if all watch variables in the workset are to be
 *                                      visible without resorting to the horizontal scroll bar.
 *                                      
 *                                  Modifications
 *                                  1.  FormWatch.cs. Rev. 1.9. - Ref.: 1.
 *                                  2.  CommonConstants.cs. Rev. 1.14. - Ref.: 1.
 *                                  3.  EventControl.Designer.cs. Rev. 1.2. - Ref.: 1.
 * 
 */
#endregion - [1.26] -

#region - [1.27] -
/*
 *  11/16/15    1.27    K.McD       References
 *                                  1.  Added support for R179.
 *                                  2.  Bug Fix - SNCR-R188 PTU [20th Mar 2015] Item 35. The ‘Show Flags’ context menu associated with viewing the event variables
 *                                      does not work correctly, however, double-clicking on the 'Units' section of the Event Variable User Control does display the 
 *                                      'FormShowFlags' form.
 *                                  3.  Bug Fix - SNCR-R188 PTU [20th Mar 2015] Item 36. If the WATCHSIZE is set to 40 and the number of watch variables is less than
 *                                      40 an exception is thrown on start-up. 
 *                                  
 *                                  Modifications
 *                                  1.  CommonConstants.cs. Rev. 1.15. - Ref.: 1.
 *                                  2.  General.cs. Rev. 1.19. - Ref.: 1.
 *                                  3.  MenuInterface.cs. Rev. 1.14. - Ref.: 1.
 *                                  4.  FormPTU.cs. Rev. 1.19. - Ref.: 1.
 *                                  5.  SelfTestBitmaskControl.cs. Rev. 1.2. SelfTestBitmaskControl.Designer.cs. Rev. 1.2. - Ref.: 2.
 *                                  6.  EventBitmaskControl.cs. Rev. 1.4. EventBitmaskControl.Designer.cs. Rev. 1.1. - Ref.: 2.
 *                                  7.  WorksetCollection.cs. Rev. 1.9. - Ref.: 3.                          
 */
#endregion - [1.27] -

#region - [1.28] -
/*
 *  01/20/2016   1.28    DAS        References
 *                                  1.  Purchase order to replace the unmanaged communication project/dll - VcuCommunication, with the managed communication
 *                                      project/dll - VcuComm1 so that the PTU application is x32/x64 independent.
 *  
 *                                  Modifications
 *                                  1.  Added \Communication\EventStreamMarshal.cs Rev. 1.0.
 *                                  2.  Added \Communication\PtuTargetCommunication.cs Rev. 1.0.
 *                                  3.  Added \Communication\SelfTestMarshalMarshal.cs Rev. 1.0.
 *                                  4.  Added \Communication\WatchClockMarshal.cs Rev. 1.0. 
 *                                  5.  Modified Parameter.cs Rev. 1.14.
 *                                  6.  Modified \Communication\CommunicationParent.cs Rev.3.0.
 *                                  7.  Modified \Communication\CommunicationParentOffline.cs Rev. 1.6.
 *                                  8.  Modified \Interfaces\ICommunicationEvent.cs Rev. 1.5, ICommunicationParent.cs Rev. 1.4.
 *                                  9.  Removed \Communication\VcuCommunication32.cs, \Communication\VcuCommunication64.cs. - Ref.: 1.
 */
#endregion - [1.28] -

#region - [1.29] -
/*
 *  03/11/2016  1.29     D.S        References
 *                                  1.  PTU Modifications to Support the Requirements Defined in the San Francisco Bay Area Rapid Transport (BART) PTU Generic
 *                                      Requirements and Interface Description document (071-ICD-0011).
 *                                      
 *                                      1.  [REQ 7] - The PTU software shall offer the possibility to view the fault records and to export the result as a
 *                                          Comma-Separated Value (CSV) file format, as per RFC 4180. The PTU software shall resolve the event IDs and subsystem ID's
 *                                          and store them in human readable format in additional columns within the CSV file. Event counters shall be stored in a
 *                                          separate CSV file. The columns of the CSV file shall follow the event log file format definition in 071-ICD-0004 [2],
 *                                          Section 3.1, Table 12 (Counters) and Table 13 (Event Records).
 *                                          
 *                                  2.  Bug fix - SNCR - PTU [01 Mar 2016] - Item 13. When viewing the Event Screen, the Maintenance log always downloads and updates
 *                                      properly,however, when the drop down box to switch to the Engineering log is selected, the PTU indicates a timeout about 50%-75%
 *                                      of the time when using the ethernet port.
 *
 *                                  3.  Bug Fix - SNCR - PTU [01 Mar 2016] - Item 8. The timeGetTime() function of winmm.dll, which is used in the PollScheduler class, 
 *                                      has potential to cause problems when running the PTU on 64 bit machines. Replace this functions with the .NET
 *                                      System.Environment.TickCount property instead.
 *                                      
 *                                  4.  Bug fix - SNCR - PTU [01 Mar 2016] - Item 12. There is an issue with saving fault/event logs on BART. BART has car ID's that are
 *                                      "prepended" with the letter "D" or "E" (e.g D1234, E4321). When trying to save a fault log, an exception is thrown in file
 *                                      "FormViewEventLog.cs" when executing the conditional check: 
 *                                      
 *                                          if (eventLogFile.EventRecordList[0] != Settings.Default.MostRecentDownloadedEventsSaved.DownloadedEvents
 *                                              [MainWindow.CarNumber])
 *                                          {
 *                                              ...
 *                                          }
 *                                          
 *                                      as MainWindow.CarNumber is not successfully converted to an integer because of the "D" or "E", hence the exception being thrown.
 *                                      
 *                                  Modifications
 *                                  1.  Modified PollScheduler.cs. Rev. 1.1. - Ref.: 3.
 *                                  2.  Modified FormShowHeaderInformation.cs. Rev. 1.7. - Ref.: 1.
 *                                  3.  Modified CommonConstants.cs. Rev. 1.16. - Ref.: 1, 2.
 *                                  4.  Modified FileHandling.cs. Rev. 1.13. - Ref.: 1.
 *                                  5.  Modified IMainWindow.cs. Rev. 1.15. - Ref.: 4.
 *                                  6.  Modified FileHeader.cs. Rev. 1.5. - Ref.: 1.
 *                                  7.  Modified CommunicationParent.cs. Rev. 3.1. - Ref.: 1.
 *                                  8.  Added CsvSerializer.cs. Rev. 1.0. - Ref.: 1.
 */
#endregion - [1.29] -

#region - [1.30] -
/*
 *  03/31/2016  1.30    D.S         References
 *                                  1.  Bug Fix - SNCR-PTU [01 Mar 2016] - Item 10. While trying out version 6.16.3 of the PTU, there was a problem if the user tries
 *                                      to download an, albeit invalid, data stream. Polling for new events was initially OK, however once the download was complete,
 *                                      the PTU reported ‘Unable to retrieve the data stream associated with the MVB Communication Failure event’ and polling for new
 *                                      events was never resumed. After a 10 second period, Windows reported that the ‘Portable Test Application has stopped working’
 *                                      without ever throwing an exception.
 *                                      
 *                                  2.  Bug Fix - SNCR-PTU [01 Mar 2016] - Item 14. This is linked to SNCR-PTU [01 Mar 2016] - Item 10. While trying to save a CTA 
 *                                      event log containing invalid data streams, in order to demonstrate the generation of a CSV file, once the invalid data stream
 *                                      had been unsuccessfully downloaded and the PTU resumed polling for new events an ApplicationException was thrown by the call
 *                                      to m_MutexCommuncationInterface.ReleaseMutex() in the finally block of the try/catch block in the
 *                                      CommunicationEvent.CheckFaultLogger() method. Details of the exception are as follows:
 *                                      
 *                                          System.ApplicationException was unhandled HResult=-2146232832
 *                                          Message=Object synchronization method was called from an unsynchronized block of code.
 *                                          Source=mscorlib
 *                                          StackTrace:
 *                                          at System.Threading.Mutex.ReleaseMutex()
 *                                          at Event.Communication.CommunicationEvent.CheckFaultLogger(Int16& eventCount, UInt32& newIndex, UInt32& newEventsLogged) in
 *                                          \\psf\Home\Documents\Contracts\Bombardier PTU\Working\Visual Studio Solutions\Portable Test Unit\DLL\Event\Communication
 *                                          \CommunicationEvent.cs:line 908
 *                                          at Event.ThreadPollEvent.Run() in \\psf\Home\Documents\Contracts\Bombardier PTU\Working\Visual Studio Solutions\Portable
 *                                          Test Unit\DLL\Event\ThreadPollEvent.cs:line 235
 *                                          .
 *                                          .
 *                                          .
 *                                          at System.Threading.ThreadHelper.ThreadStart()
 *                                      
 *                                  3.  Bug Fix - SNCR - PTU [01 Mar 2016] - Item 15. While testing out the Csv file generation using the CTA VCU the CarID property
 *                                      of the embInfo structure returned from the call to WatchClockMarshal.GetEmbeddedInformation(ref embInfo) in the
 *                                      GetEmbeddedInformation() method sometimes appended a character to the car identifier string e.g. 9999D.
 *                                      
 *                                  4.  Bug Fix - SNCR-PTU [01 Mar 16] Item 18. While testing the changes associated with items 10, 11, 14 and 15 a number of valid
 *                                      fault datastreams were generated for the CTA project using the following procedure:
 *                                      
 *                                          (1) synchronised the VCU time with the PC time; 
 *                                          (2) ensured that the event flags were configured such that a ‘Battery Voltage Out of Range’ event generates a data stream; 
 *                                          (3) initialised the event log system; 
 *                                          (4) ensured that the data stream workset loaded into the VCU was set to the ‘Factory Settings‘ workset; and; 
 *                                          (5) created a number of ‘Battery Voltage Out of Range’ faults using the procedure outlined by John Paul in the document
 *                                              ‘[J.P.] - Method to Generate Event Variables.pdf’.
 *                                          
 *                                      Once the fault log datastreams had been created, they were randomly downloaded, using the ‘Show DataStream’ context menu, and 
 *                                      in each case, instead of displaying the expected data values, the vertical bar that represents the event trip time is displayed
 *                                      way over to the left, the duration is incorrect and the data values bear little correlation to the actual data values.
 *                                      
 *                                  5.  Bug Fix - SNCR-PTU [01 Mar 2016] - Item 19. Release 6.16.4 of the PTU can't access fault data streams that have been generated
 *                                      by older releases of the PTU.
 *  
 *                                  Modifications
 *                                  1.  Modified WatchClockMarshal.cs. Rev. 1.1. - Ref.: 3.
 *                                  2.  Modified EventStreamMarshal.cs. Rev. 1.1. - Ref.: 1, 2, 4.
 *                                  3.  Modified FileHeader. Rev. 1.6. - Ref.: 5.
 *                                  4.  Modified CommunicationParemnt.cs. Rev. 3.2. - Ref.: 5.
 *                                  5.  Modified CsvSerializer.cs. Rev. 1.1. - Ref.: 5.
 */
#endregion - [1.30] -

#region - [1.31] -
/*
 * 04/07/2016   1.31     K.McD      References
 *                                  1.  Email 'D.Smail 24th March 2016 - Self Test Error Message Finding' and subsequent request in the conference call of Monday 31st
 *                                      March 2016 to modify the PTU code to inform the user of the reason why Self Tests cannot be run if the VCU fails to enter
 *                                      Self Test mode.
 *                                  
 *                                  Modifications
 *                                  1.  Added \Configuration\SelfTest\SelfTestErrorMessage.cs. Rev. 1.0. - Ref.: 1.
 *                                  2.  Modified Lookup.cs. Rev. 1.4. - Ref.: 1.
 */

/*
 *  04/14/2016  1.31.1  K.McD       References
 *                                  1.  Conference Call 4th April 2016 - CSV File generation is to be controlled by a bit within the FunctionFlags bitmask field of
 *                                      the CONFIGUREPTU table of the data dictionary.
 *                                      
 *                                  2.  Conference Call 4th April 2016 - Changes to the CSV content and layout resulting from the feedback from the demonstration
 *                                      to BT-AME/San Fransisco BART Team. 
 *                                  
 *                                  Modifications
 *                                  1.  \Configuration\Parameter.cs. Rev. 1.14.1. - Ref.: 1.
 *                                  2.  CSVSerializer.cs. Rev. 1.1.1. - Ref.: 2.
 *                                  3.  Updated \Configuration\Configuration.mdb. Extended bitmask description of the FunctionFlags field of the CONFIGUREPTU
 *                                      table to include the GenerateCSV flag.
 */
#endregion - [1.31] -

#region - [1.32] -
/*
 *  05/12/2016  1.32        K.McD   References
 *                                  1.  BART 071-ICD-0011 PTU Requirement and Interface Description document [REQ-72] and [REQ-78]. These requirements apply to 
 *                                      Windows-based PTU applications only.
 *                                      
 *                                      1.  [REQ-72] As a minimum, the Windows based PTU shall have the access level as a command line parameter to allow third party
 *                                          software to launch it directly with the required access level.
 *                                          
 *                                          The parameter to define the access level shall be -l number with number being the access level (either "2" or "3", as
 *                                          defined in [REQ-25] and [REQ-27]).
 *                                          
 *                                          Where no access level is passed, the PTU shall query Windows for the user group that the current user belongs to (refer to
 *                                          [REQ-78]) or otherwise deny access to all functions.
 *                                          
 *                                      2.  [REQ-78] Users on the PTU laptop are members of the user group PrimaryMaintenance or Engineering. If no access level is passed
 *                                          (refer to [REQ-72]) the PTU application shall query Windows for the user group that the current user belongs to. If the user
 *                                          is part of the Engineering group, access according to Level 3 shall be granted. If the user is not part of the Engineering
 *                                          group, but part of the PrimaryMaintenance group, access according to Level 2 shall be granted. If the user is not part of
 *                                          any of those two groups, access to all functions shall be denied.
 *                                          
 *                                  2.  Ensure that only the XML configuration files associated with the current project, as defined by the project identifier that is
 *                                      passed by the command line, are displayed when the Factory User selects the 'File/Select Data Dictionary' menu option.
 * 
 *                                  Modifications
 *                                  1.  CommonConstants.cs. Rev. 1.17. - Ref.: 1.
 *                                  2.  DirectoryManager.cs. Rev. 1.5. - Ref.: 1.
 *                                  3.  Resources.resx. - Ref.: 2.
 *                                      1.  Modified the text associated with MBTConfigSelectionInvalid.
 *                                      2.  Deleted MBTConfigProjectAsParameterMismatch.
 *                                      3.  Added MBTConfigProjectIDMismatch.
 *                                  4.  General.cs. Rev. 1.20. - Ref. 2.
 */
#endregion - [1.32] -

#region - [1.33] -
/*
 *  06/28/2016  1.33        K.McD   References
 *                                  1.  PTE Changes - List 5-17-2016.xlsx Item 14. Chart Recorder/DataStream Configuration Screens - Change the word 'Download'
 *                                      to 'Upload'.
 *                                  2.  PTE Changes - List 5-17-2016.xlsx Items 40, 50, 52, 55. All Child Forms - Remove "F1-Help".
 *                                  3.  PTE Changes - List 5-17-2016.xlsx Items 41, 51, 53, 57. All Child Forms - Change "F2-Print" to "F2-PrtScn".
 *                                  4.  PTE Changes - List 5-17-2016.xlsx Items 39, 54. All Child Forms - Change "Esc" to "Home" on all child forms.
 *                                  
 *                                  Modifications
 *                                  1.  FormConfigure.cs. Rev. 1.10, FormConfigure.Designer.cs. Rev. 1.3, FormConfigure.resx. - Ref.: 1. 
 *                                  2.  FormPTU.cs. Rev. 1.20. - Ref.: 2, FormPTU.Designer.cs. Rev. 1.9. - Ref.: 2, 3, 4.
 *                                  3.  Resources.resx. Added 'Upload' icon. - Ref.: 1.
 *                                  4.  CommunicationParent.cs. Rev. 3.3. - Ref.: Not Known - Investigate Further.
 *                                  5.  FormPlotDefine.cs. Reverted back to Rev.: 1.2. Previous change by Dave Smail was incorrect. The individual column count
 *                                      information was not shown for column 1 when viewing WatchWindow worksets.
 *                                  6.  FormWorksetDefine.cs. Reverted back to Rev. 1.11, FormWorksetDefine.Designer.cs. Reverted back to Rev. 1.5. Previous changes
 *                                      by Dave Smail were incorrect. The individual column count information was not shown for column 1 when viewing WatchWindow
 *                                      worksets.                            
 */

/*
 *    07/21/2016  1.33.1    K.McD   References
 *                                  1.  PTE Changes - List 5-17-2016.xlsx Item 12. Under the 'Help' drop-down menu, add a 'Show User Manual menu option above the 'About'
 *                                      menu option with a link to the 'Software User Manual'.
 *                                      
 *                                  2.  PTE Changes - List 5-17-2016.xlsx Item 62. On all screens, change the green text to black.
 *                                  
 *                                  3.  PTE Changes - List 5-17-2016.xlsx Item 63. Change the '(Bit Mask)' component of the Bitmask UserControl to say 'Detail'
 *                                      and make it look like a clickable button.
 *                                      
 *                                  4.  PTE Changes - List 5-17-2016.xlsx Item 64. When double-clicking on the '(Bit Mask)' component of the Watch Variable
 *                                      UserControl, the window that shows the individual status of the bitmask flags is shown in front of everything, including other
 *                                      windows applications, even if the user uses the command to minimize the Portable Test Application Window.
 *                                      
 *                                  5.  PTE Changes - List 5-17-2016.xlsx Item 10, 49, 58. The 'Configure/Enumeration' drop-down menu option is to be replaced by
 *                                      individual ToolStripButton controls on the 'Watch Window', 'Event Log' and 'Self Test' screens.
 *                                      
 *                                  6.  Bug Fix - SNCR-PTU [01 Mar 2016] - Item 22. On the event screen, modify the width of the event variable user control to allow
 *                                      for a vertical scroll bar.
 *                                      
 *                                  7.  Bug Fix - SNCR - PTU [01 Mar 2016] - Item 21. When displaying enumerator variables the display should toggle between the raw
 *                                      integer values and the equivalent text strings as soon as the user selects the 'Enumeration' ToolStripButton.
 *                                      
 *                                  8.  PTE Changes - List 5-17-2016.xlsx Item 13, 27, 34. When configuring the Fault Log DataStream, Chart Recorder or Watch Window,
 *                                      the user must only be allowed to select variables from either the 'Available Watch Variables' list or the or 'Workset Layout' list
 *                                      but not both at the same time.
 *    
 *                                  Modifications
 *                                  1.  CommonConstants.cs. Rev. 1.17.1. - Ref.: 1.
 *                                  2.  FormShowFlags.cs. Rev. 1.9. - Ref.: 2.
 *                                  3.  CheckBoxUInt32.cs. Rev. 1.1. - Ref.: 2.
 *                                  4.  WatchControlLayout.cs. Rev. 1.6. - Ref.: 2.
 *                                  5.  VariableControl.cs. Rev. 1.4. - Ref.: 3, 6.
 *                                  6.  WatchBitmaskControl.cs. Rev. 1.4. - Ref.: 3. WatchBitmaskControl.Designer.cs. Rev. 1.1.- Ref.: 3.
 *                                  7.  SelfTestBitmaskControl.cs. Rev. 1.3. - Ref.: 3. SelfTestBitmaskControl.Designer.cs. Rev. 1.3.- Ref.: 3.
 *                                  8.  EventBitmaskControl.cs. Rev. 1.3. - Ref.: 3. EventBitmaskControl.Designer.cs. Rev. 1.2.- Ref.: 3.
 *                                  9.  FormPTU.cs. Rev. 1.21. - Ref.: 4, 5.
 *                                  10. WatchControl.Designer.cs. Rev. 1.1. EventControl.Designer.cs. Rev. 1.3. SelfTestControl.Designer.cs. Rev. 1.1. - Ref.: 2.
 *                                  11. IMainWindow.cs. Rev. 1.15.1. - Ref. 5.
 *                                  12. Resources.resx. - Ref.: 5.
 *                                  13. FormDataStreamReplay.cs. Rev. 1.21. - Ref.: 7.
 *                                  14. FormWorksetDefine.cs. Rev. 1.12. FormWorksetDefine.Designer.cs. Rev. 1.6. - Ref.: 8.
 */

/*
 *    08/01/2016  1.33.2    K.McD   References
 *                                  1.  Bug Fix Associated with item [7] of 6.18.1. PTE Changes - List 5-17-2016.xlsx Item 13, 27, 34. When configuring the Self Test
 *                                      Lists, the user must only be allowed to select items from either the 'Test Categories' ListBox controls or the
 *                                      'Selected Tests' ListBox control but not both at the same time.
 *                                      
 *                                  2.  PTE Changes - List 5-17-2016.xlsx Item 59. On the 'View/Watch Window' and 'Diagnostics/Self-Tests' screens, change the name of the
 *                                      F5 ToolStripButton control to 'F5-Config.' and change the associated ToolTipText properties to 'F5 - [Configure Watch Window]'
 *                                      and 'F5 - [Configure Test List]' respectively.
 *                                      
 *                                  3.  PTE Changes - List 5-17-2016.xlsx Items 16, 24, 61.  For the Chart Recorder, Data Stream and Watch Window configuration
 *                                      dialog boxes, change the word 'Workset' to 'Chart Recorder Configuration', 'Data Stream Configuration' and 'Watch Window
 *                                      Configuration' respectively and change the title of each dialogbox to be 'Configure - Chart Recorder', 'Configure - Data
 *                                      Stream' and 'Configure - Watch Window'.
 *    
 *                                  Modifications
 *                                  1.  FormWorksetDefine.cs. Rev. 1.13. - Ref.: 1.
 *                                  2.  FormPlotDefine.Designer.cs. Rev. 1.3. - Ref.: 3.
 *                                  3.  FormWorksetDefine.Designer.cs. Rev. 1.7. - Ref.: 2, 3.
 *                                  4.  FormConfigure.Designer.cs. Rev. 1.4. - Ref.: 2, 3.
 *                                  5.  Resources.resx. - Ref.: 2, 3.
 *                                      1.  FunctionKeyTextEdit changed from 'Modify' to 'Config'.
 *                                      2.  FunctionKeyToolTipEditPlotLayout changed from [Modify Plot Layout] to [Configure Plot Layout].
 *                                      3.  FunctionKeyToolTipEdit changed from [Modify Current Workset] to '[Configure Watch Window]'.
 *                                      4.  FunctionKeyTextEnumerator changed to 'Enum.'.
 *                                  6.  CommonConstants.cs. Rev. 1.17.2. - Ref.: 3.
 *                                  
 */

/*
 *    08/01/2016  1.33.3    K.McD   References
 *                                  1.  PTE Changes - List 5-17-2016.xlsx Item 10, 49, 58. The 'Configure/Enumeration' drop-down menu option is to be replaced by
 *                                      individual ToolStripButton controls on the 'Watch Window', 'Event Log' and 'Self Test' screens.
 *                                      
 *                                  2.  PTE Changes - List 5-17-2016.xlsx Item 66. The “/” and other characters that are invalid for a filename cause certain events
 *                                      not to be saved. The Data Dictionary should be changed to remove any invalid characters OR the software should look for these
 *                                      characters and replace them prior to saving.
 *    
 *                                  Modifications
 *                                  1.  Resources.resx. - Ref.: 1.
 *                                      1.  Added the EnumeratorsAsText and EnumeratorsAsNumbers images.
 *                                  2.  Modified FormPTU.cs. Rev. 1.22. - Ref.: 1.
 *                                  3.  Modified FormPTU.Designer.cs. Rev. 1.10. - Ref.: 1.
 *                                  4.  Added EnumeratorsAsNumbers.png and EnumeratorsAsText.png images to the '\Resources\' sub-directory.
 *                                  5.  General.cs. Rev. 1.21. - Ref.: 2.
 *                                  
 */

/*
 *  08/09/2016      1.33.4  K.McD/  References
 *                          D.S     1.  Bug Fix. With reference to the email from Dave Smail to Keith McDonald on 09-Aug-2016 16:57 BST - Subject: PTU Solution Update.
 *                                      There is an issue with the GetChartMode() method in the WatchClockMarshal class.
 *                                      
 *                                  2.  PTE Changes - List 5-17-2016.xlsx Item 15, 22, 23, 23, 25, 47, 48. Add 'Delete', 'Set As Default' and 'Override Security'
 *                                      ToolStripButton controls to the Chart Recorder, Data Stream and Watch Window configuration dialogbox forms. On selecting the
 *                                      'Delete' ToolStripButton, a pop-up asking 'Are you sure you want to delete the ...?' should appear with the option to
 *                                      answer 'Yes' or 'Cancel'.
 *                                      
 *                                  3.  Bug - Self test results screen locked up when running interactive test.
 *                                  
 *                                  Modifications
 *                                  1.  WatchClockMarshal.cs. Rev. 1.2. - Ref.: 1.
 *                                  2.  FormConfigure.cs. Rev. 1.11. - Ref.: 2.
 *                                  3.  FormConfigure.Designer.cs. Rev. 1.5. - Ref.: 2.
 *                                  4.  FormWorksetDefine.cs. Rev. 1.14. - Ref.: Internal Audit of Code, 2.
 *                                  5.  FormWorksetManager.cs. Rev. 1.6. - Internal Audi of Code. Set all Windows Form Designer variables to null and detached all event
 *                                      handlers.
 *                                  6.  IMainWindow,cs. Rev. 1.15.2. - Ref.: 2.
 *                                  7.  CommonConstants.cs. Rev. 1.17.3. - Ref.: 2.
 *                                  8.  Resources.resx. Added images for the 'Delete', 'Set As Default' and 'Override Security' ToolStripButton controls and a
 *                                      number of strings to support the: Upload, Save, Configure, Create New, Copy, Rename, Delete, SetAsDefault and 
 *                                      Override Security operations. - Ref.: 2.
 *                                  9.  FormSetSecurityLevel.cs. Rev. 1.2, FormSetSecurityLevel.Designer.cs. Rev.: 1.1. - Ref.: 2.
 *                                  10. SelfTestMarshal.cs. Rev. 1.1. - Ref.: 3.
 */

/*
 *  09/13/2016      1.33.5  K.McD/  References
 *                          D.S     1.  Bug Fix - Support 4 digit year code returned from VCU.
 *                                  2.  Bug Fix - The status message is not cleared when the user undoes the 'Create New' operation.
 *                                  3.  Bug Fix - SNCR-PTU [01 Mar 2016] - Item 23. Only ask the user if they wish to terminate the application if they select
 *                                      the 'File/Exit' menu option or select the [x] button. If the close is as a result of a fatal error just close the program
 *                                      regardless.  
 *                          
 *                                  Modifications
 *                                  1.  EventStreamMarshal.cs. Rev. 1.2. - Ref.: 1.
 *                                  2.  FormConfigure.cs. Rev. 1.12. - Ref.: 2.
 *                                  3.  IMainWindow.cs. Rev. 1.15.3. - Ref.: 3.
 *                                  4.  General.cs. Rev. 1.21.1. Ref.: 3.
 */

/*
 *  10/12/2016      1.33.6  K.McD   References
 *                                  1.  Ref.: Conference Call 3rd Oct 2016. For both BART and R188, the fields of the CSV file that is produced whenever and new event
 *                                      log XML file is generated should should be based upon document 'NYCT R188 - Variation Order (14th Jan 2016) - XML to CSV.pdf'.
 *
 *                                  Modifications
 *                                  1.  CsvSerializer.cs. Rev. 1.2. - Ref.: 1.
 */
/*
 *  02/21/2017      1.33.7  Vgott    References
 *                                  1. Update the tooltip text format by adding '[' and ']' characters to functionkeys only and keys are at the end of the text.
 *                                      
 *                                  Modifications
 *                                  1. Update the tooltip text format for all tooltips in Resource.resx file.
 *                                  2. Update the tooltip text for common buttons Esc,F1,F2.
 *                                  3. Update the tooltip text format and chages done in the DisplayFunctionKey() for suggested tooltip format.
 *                                      
 * 
 */
#endregion - [1.33] -

#region - [1.34] -
/*
 *  03/02/2017     1.34.1   D.Smail Modifications
 *                                  1.  Added interface method ResumePollingTargetHardware() so that child MDI
 *                                      can inform Main Window to resume target hardware polling when child exits.
 *                                  2.  Added set mutator to CommunicationInterface property so that child MDI
 *                                      can inform Main Window that communication has been lost with the hardware 
 *                                      target
 *                                  3.  Modified because watch variable polling wouldn't resume after trying to configure
 *                                      worksets in the Data Monitoring window. Because the dialog wasn't invoked from 
 *                                      the main window, main window was being set to null prior to the call to 
 *                                      resume the data variable polling
 *                                  4.  Added EnableSTCommWatchdog static property and the associated static member variable that supports
 *                                      the ability for the PTU to perform continuous watchdog checks during self test.
 *                                  5.  Added CommunicationWatchdog() method to support communication checks with VCU during self test.
 *                                  6.  Added a reference parameter to CommunicationWatchdog() method that is updated to indicate
 *                                      whether or not the target hardware is in self test.
 *
 */
/*
 *  06/23/2017     1.34.2   Vgott   References
 *                                  1.  Update the tooltip text for F5-Config and F1-Enum buttons.
 *                                  2.  Change the default filename structure for the BART PTU Application to include the Truck ID, Event Log variable 
 *                                  called “Truck Type”, which can be obtained from the first event structure.  The Truck ID is either “X” or “Y”.  The change will be 
 *                                  to append the Car Number with either “X” or “Y”.
 *                                  3.  The PTU Application shall convert the Car ID to all capitals
 *                                  
 *                                  Modifications
 *                                  1.  Update the tooltip text as "Open Plot Layout Configuration window" instead "Configure Plot Layout" for Open\Watch >F5-Config.
 *                                  2.  Update the tooltip text as "Show words/error text as their value" instead "Show enumerators as Integer values" for F1-Enum common to all.
 *                                  3.  Added truck type parameter as as empty to DeriveName() method if the default file structure is other than EventLogs.
 *                                  4.  Converted CarID to upper which is recieved from m_RxMessage of request type "GET_EMBEDDED_INFORMATION"
 *                                  
 *  09/15/2017     1.34.3  D.Smail  Modifications
 *                                  1.  Added a delay in StartSelfTestTask() to support Windows XP issue for CTA (serial). When using 
 *                                      the PTU on an XP machine for CTA only, entering self test properly is marginal. We believe the 
 *                                      problem is on the target side, but an investigation may take weeks. This "band-aid" solves CTA's 
 *                                      issue, but has no side effects on other projects (either serial or TCP).
 *                                      
 *  11/06/2017     1.34.4  Vgottam  Modifications
 *                                  1.  CTA 5000 - PTU issue with delay time and updated "DefaultMutexWaitDurationMs" with 120 seconds from 20 seconds.                                      
 *                                  
 *  02/11/2018     1.34.5  Vgottam  Modifications
 *                                  1.  Added new project ID as PAQA for Pgh LRV.
 *                                  2.  Updated subsystem name only for PAQA as "PTUP"
 *                                  3.  Enabled the code related to Set Car ID command.
 *                                  
 *  05/19/2018     1.34.6   Vgottam  Modifications
 *                                      1. Added F8 function key for Print the Plots with Print option as to export to MS Word document or print directly.
 *                                      2. Update Icon as screenshot for F2 function key.
 *                                      3. Replaced WinHelp Pop-ups with HelpWindow.  
 *  06/24/2018     1.34.7  Vgottam   Modifications 
 *                                   1. Introduced PTU Help windows using CHM instead of HLP file extensions. 
 *                                   
 *  07/08/2018     1.34.8  Vgottam   Modifications 
 *                                   1. Change the default Engineering Password from “TGX216028A” to “BTRoQEngineer”
 *                                   2. Added new project ID MAPA for MARTA and updated as per PAQA functionality.
 *
 *  12/06/2018     1.34.9  Vgottam  Modifications
 *                                  1.  Updated the code for new project ID: 300R.    
 *                                  2.  Enable Password Manager for all the security levels.
 *                                  
 */

#endregion - [1.34] -
#region - [1.35] -
/*
 *  01/21/2019     1.35.0  Vgottam  Modifications
 *                                  1. Retracted the constant 'TimeoutMsPauseFeedback' from 10000ms to 3000ms
 *                                  
 */

#endregion - [1.35] -
#endregion --- Revision History ---

using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyCompany("Bombardier Transportation (Holdings) USA Inc.")]
[assembly: AssemblyProduct("Portable Test Application")]
[assembly: AssemblyCopyright("(C) 2010 - 2019 Bombardier Transportation (Holdings) USA Inc.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: NeutralResourcesLanguageAttribute("")]

// General Information about an assembly is controlled through the following set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Portable Test Application - Common Classes")]
[assembly: AssemblyDescription("A collection of common classes")]
[assembly: AssemblyConfiguration("")]

// Setting ComVisible to false makes the types in this assembly not visible to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("38584931-B8D8-434d-B7EE-FF5F9F0380E9")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers by using the '*'.

[assembly: AssemblyVersion("1.35.0.0")]
