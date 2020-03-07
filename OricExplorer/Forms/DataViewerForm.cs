﻿namespace OricExplorer.Forms
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public partial class DataViewerForm : Form
    {
        DataViewerControl dataViewerControl;

        public DataViewerForm(OricFileInfo fileInfo, OricProgram programData)
        {
            InitializeComponent();

            dataViewerControl = new DataViewerControl();
            dataViewerControl.ProgramInfo = fileInfo;
            dataViewerControl.ProgramData = programData;
            dataViewerControl.InitialiseView();

            this.Controls.Add(dataViewerControl);
            this.Size = new Size(dataViewerControl.Width + 15, dataViewerControl.Height + 40);

            this.Text = string.Format("Data Viewer - {0} ({1})", fileInfo.ProgramName, Path.GetFileName(fileInfo.ParentName));
        }
    }
}
