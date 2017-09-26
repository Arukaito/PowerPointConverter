// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Form1.cs" company="Alkaworks">
//   Copyright Alkaworks
// </copyright>
// <summary>
//   Defines the Form1 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PowerPointConverter
{
    using System;
    using System.Collections.Generic;
    using System.Drawing.Drawing2D;
    using System.IO;
    using System.Windows.Forms;
    using Microsoft.Office.Core;
    using pptApplication = Microsoft.Office.Interop.PowerPoint;
    
    /// <summary>
    /// The form 1.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// The form 1_ load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Form1Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The button click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ButtonSeleccionClick(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                VariablesGlobales.Directorio = fb.SelectedPath;
            }
            var directory = new DirectoryInfo(VariablesGlobales.Directorio);
            var files = directory.GetFiles("*.pptx");
        
            foreach (var file in files)
            {
               Archivos ar = new Archivos();
                file.FullName = ar.File[0];
            }
        }

        /// <summary>
        /// The button to start converting the files.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ButtonConvertirClick(object sender, EventArgs e)
        {
            FolderBrowserDialog fbe = new FolderBrowserDialog();
            if (fbe.ShowDialog() == DialogResult.OK)
            {
                VariablesGlobales.DirectorioExpo = fbe.SelectedPath;
            }


           pptApplication.Application pptp = new pptApplication.Application();
            pptApplication.Presentation ppps = pptp.Presentations.Open(
                @"\\ramfile01\LGroups\Engineering\Cambios de Ingenieria\Software Developement\ECR Enforcer.pptx",
                MsoTriState.msoFalse,
                MsoTriState.msoFalse,
                MsoTriState.msoFalse);

            var slideCount = ppps.Slides.Count;
            var diff = 0;

            foreach (Microsoft.Office.Interop.PowerPoint.Slide pptSlides in ppps.Slides)
            {
                diff++;
                pptSlides.Export(VariablesGlobales.DirectorioExpo + "\\" + diff + " de " + slideCount + ".jpg", "jpg", 3840, 2160);
            }

            MessageBox.Show("Convertido con Exito!");
        }

        /// <summary>
        /// The Public Variables.
        /// </summary>
        public class VariablesGlobales
        {
            /// <summary>
            /// Gets or sets the directory.
            /// </summary>
            public static string Directorio { get; set; }

            /// <summary>
            /// Gets or sets the directory expo.
            /// </summary>
            public static string DirectorioExpo { get; set; }
        }

        /// <summary>
        /// The archive.
        /// </summary>
        public class Archivos
        {
            /// <summary>
            /// The file.
            /// </summary>
            private string[] file;

            /// <summary>
            /// Gets or sets the file.
            /// </summary>
            public string[] File
            {
                get => this.file;
                set => this.file = value;
            }
        }
    }
}
