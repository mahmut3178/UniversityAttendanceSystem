using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.UI.UI.Controls;

namespace Karebase.WinFormsUI.Controls
{
    public static class MMessageBox
    {
        public static DialogResult ShowMessage(string message, string caption, MessageBoxButtons button, MessageBoxIcon icon)
        {
            DialogResult dlgResult = DialogResult.None;
            switch (button)
            {
                case MessageBoxButtons.OK:
                    using (MessageOk msgOK = new MessageOk())
                    {
                        //Change text, caption, icon
                        msgOK.Caption = caption;
                        msgOK.Message = message;
                        switch (icon)
                        {
                            case MessageBoxIcon.Information:
                                msgOK.MessageIcon = WinForm.UI.Properties.Resources.information_ico;
                                break;
                            case MessageBoxIcon.Question:
                                msgOK.MessageIcon = WinForm.UI.Properties.Resources.question_ico;
                                break;
                        }
                        dlgResult = msgOK.ShowDialog();
                    }
                    break;
                case MessageBoxButtons.YesNo:
                    using (MessageYesNo msgYesNo = new MessageYesNo())
                    {
                        msgYesNo.Caption = caption;
                        msgYesNo.Message = message;
                        switch (icon)
                        {
                            case MessageBoxIcon.Information:
                                msgYesNo.MessageIcon = WinForm.UI.Properties.Resources.information_ico;
                                break;
                            case MessageBoxIcon.Question:
                                msgYesNo.MessageIcon = WinForm.UI.Properties.Resources.question_ico;
                                break;
                        }
                        dlgResult = msgYesNo.ShowDialog();
                    }
                    break;
            }
            return dlgResult;
        }
    }
}
