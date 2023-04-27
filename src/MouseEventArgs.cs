// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#if !NETSTANDARD
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Windows.Forms.MouseEventArgs))]
#endif

namespace System.Windows.Forms;

#if NETSTANDARD
/// <summary>
///  Provides data for the <see cref='Control.MouseUp'/>, <see cref='Control.MouseDown'/> and
/// <see cref='Control.MouseMove'/> events.
/// </summary>
public class MouseEventArgs : EventArgs
{
    /// <summary>
    ///  Initializes a new instance of the <see cref='MouseEventArgs'/> class.
    /// </summary>
    public MouseEventArgs(MouseButtons button, int clicks, int x, int y, int delta)
    {
        Button = button;
        Clicks = clicks;
        X = x;
        Y = y;
        Delta = delta;
    }

    /// <summary>
    ///  Gets which mouse button was pressed.
    /// </summary>
    public MouseButtons Button { get; }

    /// <summary>
    ///  Gets the number of times the mouse button was pressed and released.
    /// </summary>
    public int Clicks { get; }

    /// <summary>
    ///  Gets the x-coordinate of a mouse click.
    /// </summary>
    public int X { get; }

    /// <summary>
    ///  Gets the y-coordinate of a mouse click.
    /// </summary>
    public int Y { get; }

    /// <summary>
    ///  Gets a signed count of the number of detents the mouse wheel has rotated.
    /// </summary>
    public int Delta { get; }
}
#endif
