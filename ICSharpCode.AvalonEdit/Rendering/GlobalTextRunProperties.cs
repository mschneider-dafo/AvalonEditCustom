﻿// Copyright (c) 2014 AlphaSierraPapa for the SharpDevelop Team
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this
// software and associated documentation files (the "Software"), to deal in the Software
// without restriction, including without limitation the rights to use, copy, modify, merge,
// publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
// to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or
// substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
// FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.

using System.Windows;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;

namespace AcAvalonEdit.Rendering
{
	sealed class GlobalTextRunProperties : TextRunProperties
	{
		internal Typeface typeface;
		internal double fontRenderingEmSize;
		internal Brush foregroundBrush;
		internal Brush backgroundBrush;
		internal System.Globalization.CultureInfo cultureInfo;

		public override Typeface Typeface { get { return typeface; } }
		public override double FontRenderingEmSize { get { return fontRenderingEmSize; } }
		public override double FontHintingEmSize { get { return fontRenderingEmSize; } }
		public override TextDecorationCollection TextDecorations { get { return null; } }
		public override Brush ForegroundBrush { get { return foregroundBrush; } }
		public override Brush BackgroundBrush { get { return backgroundBrush; } }
		public override System.Globalization.CultureInfo CultureInfo { get { return cultureInfo; } }
		public override TextEffectCollection TextEffects { get { return null; } }
	}
}
