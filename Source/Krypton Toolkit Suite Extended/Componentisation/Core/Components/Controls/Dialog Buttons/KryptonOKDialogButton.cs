﻿#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.480/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KryptonToolkitSuiteExtendedCore.Components.Controls.DialogButtons
{
    [ToolboxBitmap(typeof(KryptonButton))]
    public class KryptonOKDialogButton : KryptonButton
    {
        public KryptonOKDialogButton()
        {
            DialogResult = DialogResult.OK;

            ParentChanged += KryptonOKDialogButton_ParentChanged;

            TextChanged += KryptonOKDialogButton_TextChanged;
        }

        private void KryptonOKDialogButton_TextChanged(object sender, EventArgs e)
        {
            if (Text == Name) Text = "&OK";
        }

        private void KryptonOKDialogButton_ParentChanged(object sender, EventArgs e)
        {
            Control parent = Parent;

            while (!(Parent is KryptonForm) && !(parent == null))
            {
                parent = parent.Parent;
            }

            if (parent is KryptonForm)
            {
                KryptonForm form = (KryptonForm)parent;

                form.AcceptButton = this;
            }
        }
    }
}