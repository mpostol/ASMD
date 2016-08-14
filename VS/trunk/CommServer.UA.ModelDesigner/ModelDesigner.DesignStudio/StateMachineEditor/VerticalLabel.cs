//<summary>
//  Title   : Vertical label 
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2009, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>
using System.Drawing;
using System;

namespace CAS.UA.Model.Designer.StateMachineEditor
{
  internal class VerticalLabel: System.Windows.Forms.Label
  {
    bool mAutoSize;
    /// <summary>
    /// </summary>
    /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs"/> that contains the event data.</param>
    protected override void OnPaint( System.Windows.Forms.PaintEventArgs e )
    {
      StringFormat myStrFormat = new StringFormat();
      myStrFormat.FormatFlags = StringFormatFlags.DirectionVertical;
      int strOriginX = this.Margin.Left;
      int strOriginY = this.Margin.Top;
      Rectangle rect = this.ClientRectangle;
      e.Graphics.FillRectangle( new SolidBrush( this.BackColor ), rect.X, rect.Y, rect.Width - 1, rect.Height - 1 );
      e.Graphics.DrawRectangle( Pens.Gray, rect.X, rect.Y, rect.Width - 1, rect.Height - 1 );
      e.Graphics.TranslateTransform( this.Width, this.Height );
      e.Graphics.RotateTransform( 180 );
      e.Graphics.DrawString( this.Text, this.Font, new SolidBrush( this.ForeColor ), strOriginX, strOriginY, myStrFormat );
    }

    /// <summary>
    /// Gets or sets a value indicating whether the control is automatically resized to display its entire contents.
    /// </summary>
    /// <value></value>
    /// <returns>true if the control adjusts its width to closely fit its contents; otherwise, false. The default is true.
    /// </returns>
    /// <PermissionSet>
    /// 	<IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/>
    /// 	<IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/>
    /// 	<IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence"/>
    /// 	<IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/>
    /// </PermissionSet>
    private new bool AutoSize
    {
      get { return mAutoSize; }
      set
      {
        mAutoSize = value;
        VerticalLabel_Resize( null, null );
      }
    }

    /// <summary>
    /// Handles the Resize event of the VerticalLabel control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void VerticalLabel_Resize( object sender, System.EventArgs e )
    {
      if ( mAutoSize )
      {
        Graphics g = this.CreateGraphics();
        int textLength = (int)( g.MeasureString( this.Text, this.Font ).Width );
        this.Height = this.Margin.Top + textLength + this.Margin.Bottom + 3;
        this.Width = this.Margin.Left + this.FontHeight + this.Margin.Right;
      }
    }

    /// <summary>
    /// Handles the AutoSizeChanged event of the VerticalLabel control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void VerticalLabel_AutoSizeChanged( object sender, System.EventArgs e )
    {
      VerticalLabel_Resize( null, null );
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="VerticalLabel"/> class.
    /// </summary>
    internal VerticalLabel()
      : base()
    {
      base.AutoSize = false;
      base.Resize += new EventHandler( VerticalLabel_Resize );
      base.AutoSizeChanged += new EventHandler( VerticalLabel_AutoSizeChanged );
    }
  }
}