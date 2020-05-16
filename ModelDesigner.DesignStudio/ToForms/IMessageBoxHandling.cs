//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

namespace CAS.UA.Model.Designer.ToForms
{
  internal interface IMessageBoxHandling
  {
    void Show(string wrapperTreeNode_menu_paste_cannot_be_done);
    DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon);
  }
  
  //
  // Summary:
  //     Specifies constants defining which information to display.
  internal enum MessageBoxIcon
  {
    //
    // Summary:
    //     The message box contain no symbols.
    None = 0,
    //
    // Summary:
    //     The message box contains a symbol consisting of a white X in a circle with a
    //     red background.
    Hand = 16,
    //
    // Summary:
    //     The message box contains a symbol consisting of white X in a circle with a red
    //     background.
    Stop = 16,
    //
    // Summary:
    //     The message box contains a symbol consisting of white X in a circle with a red
    //     background.
    Error = 16,
    //
    // Summary:
    //     The message box contains a symbol consisting of a question mark in a circle.
    //     The question-mark message icon is no longer recommended because it does not clearly
    //     represent a specific type of message and because the phrasing of a message as
    //     a question could apply to any message type. In addition, users can confuse the
    //     message symbol question mark with Help information. Therefore, do not use this
    //     question mark message symbol in your message boxes. The system continues to support
    //     its inclusion only for backward compatibility.
    Question = 32,
    //
    // Summary:
    //     The message box contains a symbol consisting of an exclamation point in a triangle
    //     with a yellow background.
    Exclamation = 48,
    //
    // Summary:
    //     The message box contains a symbol consisting of an exclamation point in a triangle
    //     with a yellow background.
    Warning = 48,
    //
    // Summary:
    //     The message box contains a symbol consisting of a lowercase letter i in a circle.
    Asterisk = 64,
    //
    // Summary:
    //     The message box contains a symbol consisting of a lowercase letter i in a circle.
    Information = 64
  }
  //
  // Summary:
  //     Specifies constants defining which buttons to display on a System.Windows.Forms.MessageBox.
  public enum MessageBoxButtons
  {
    //
    // Summary:
    //     The message box contains an OK button.
    OK = 0,
    //
    // Summary:
    //     The message box contains OK and Cancel buttons.
    OKCancel = 1,
    //
    // Summary:
    //     The message box contains Abort, Retry, and Ignore buttons.
    AbortRetryIgnore = 2,
    //
    // Summary:
    //     The message box contains Yes, No, and Cancel buttons.
    YesNoCancel = 3,
    //
    // Summary:
    //     The message box contains Yes and No buttons.
    YesNo = 4,
    //
    // Summary:
    //     The message box contains Retry and Cancel buttons.
    RetryCancel = 5
  }
  //
  // Summary:
  //     Specifies identifiers to indicate the return value of a dialog box.
  public enum DialogResult
  {
    //
    // Summary:
    //     Nothing is returned from the dialog box. This means that the modal dialog continues
    //     running.
    None = 0,
    //
    // Summary:
    //     The dialog box return value is OK (usually sent from a button labeled OK).
    OK = 1,
    //
    // Summary:
    //     The dialog box return value is Cancel (usually sent from a button labeled Cancel).
    Cancel = 2,
    //
    // Summary:
    //     The dialog box return value is Abort (usually sent from a button labeled Abort).
    Abort = 3,
    //
    // Summary:
    //     The dialog box return value is Retry (usually sent from a button labeled Retry).
    Retry = 4,
    //
    // Summary:
    //     The dialog box return value is Ignore (usually sent from a button labeled Ignore).
    Ignore = 5,
    //
    // Summary:
    //     The dialog box return value is Yes (usually sent from a button labeled Yes).
    Yes = 6,
    //
    // Summary:
    //     The dialog box return value is No (usually sent from a button labeled No).
    No = 7
  }
}
