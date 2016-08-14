//---------------------------------------------------------------------------
//
// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Limited Permissive License.
// See http://www.microsoft.com/resources/sharedsource/licensingbasics/limitedpermissivelicense.mspx
// All other rights reserved.
//
// This file is part of the 3D Tools for Windows Presentation Foundation
// project.  For more information, see:
// 
// http://CodePlex.com/Wiki/View.aspx?ProjectName=3DTools
//
//---------------------------------------------------------------------------

using CommandLine;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows;

namespace ModelViewer
{
    /// <summary>
    /// Interaction logic for MyApp.xaml
    /// </summary>

    public partial class MyApp : Application
    {
        class Arguments
        {
            [DefaultArgument(ArgumentType.AtMostOnce, HelpText = "")]
            public string Filename = null;
        }


        void OnStartup(object sender, StartupEventArgs e)
        {
            Arguments parsedArgs = new Arguments();

            if (Parser.ParseArgumentsWithUsage(e.Args, parsedArgs))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

                if (parsedArgs.Filename != null)
                {
                    mainWindow.Load(parsedArgs.Filename);
                }
            }
        }

        internal static void StartupError(string errorMsg)
        {
            MessageBox.Show(errorMsg, "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            Application.Current.Shutdown();
        }
    }
}