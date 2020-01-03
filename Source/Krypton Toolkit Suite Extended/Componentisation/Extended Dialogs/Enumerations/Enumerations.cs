﻿#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

namespace ExtendedDialogs.Enumerations
{
    public enum InputBoxIcon
    {
        CUSTOM,
        OK,
        ERROR,
        EXCLAMATION,
        INFORMATION,
        QUESTION,
        NONE,
        STOP,
        HAND
    }

    public enum InputBoxIconImageSize
    {
        CUSTOM,
        THIRTYTWO,
        FOURTYEIGHT,
        SIXTYFOUR,
        ONEHUNDREDANDTWENTYEIGHT
    }

    public enum InputBoxType
    {
        COMBOBOX,
        TEXTBOX,
        NOTHING
    }

    public enum InputBoxButtons
    {
        OK,
        OKCANCEL,
        YESNO,
        YESNOCANCEL
    }

    public enum InputBoxMessageTextAlignment
    {
        LEFT,
        CENTRE,
        RIGHT,
        INHERIT
    }

    public enum InputBoxUserInputTextAlignment
    {
        LEFT,
        CENTRE,
        RIGHT,
        INHERIT
    }

    public enum InputBoxUserSelectionTextAlignment
    {
        LEFT,
        CENTRE,
        RIGHT,
        INHERIT
    }

    public enum InputBoxMessageRightToLeft
    {
        NO,
        YES,
        INHERIT
    }

    /// <summary>The chosen language for buttons.</summary>
    public enum Language
    {
        /// <summary>The Czech definition.</summary>
        CZECH,
        /// <summary>The English definition.</summary>
        ENGLISH,
        /// <summary>The Français definition.</summary>
        FRANÇAIS,
        /// <summary>The Deutsch definition.</summary>
        DEUTSCH,
        /// <summary>The Slovakian definition.</summary>
        SLOVAKIAN,
        /// <summary>The Español definition.</summary>
        ESPAÑOL,
        /// <summary>A custom language definition.</summary>
        CUSTOM
    }

    public enum InputBoxDefaultButton
    {
        BUTTONONE,
        BUTTONTWO,
        BUTTONTHREE
    }
}