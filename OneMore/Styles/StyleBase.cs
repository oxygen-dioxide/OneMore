﻿//************************************************************************************************
// Copyright © 2020 Steven M Cohn. All rights reserved.
//************************************************************************************************

#pragma warning disable CS3005 // Identifiers differ only in case

namespace River.OneMoreAddIn
{
	using System;
	using System.Drawing;


	/// <summary>
	/// Base properties of a style to be inherited by all other style classes.
	/// </summary>
	public abstract class StyleBase
	{
		public static readonly string DefaultFontFamily = "Calibri";
		public static readonly double DefaultFontSize = 11.0;

		protected string color;
		protected string highlight;
		protected double fontSize;
		protected double spaceBefore;
		protected double spaceAfter;

		protected readonly ILogger logger;


		/// <summary>
		/// Initializes a new instance with defaults.
		/// </summary>
		public StyleBase()
		{
			Color = "automatic";
			Highlight = "automatic";
			FontFamily = DefaultFontFamily;
			fontSize = DefaultFontSize;
			ApplyColors = true;

			logger = Logger.Current;
		}


		/// <summary>
		/// Base copy constructor, to be invoked by inheritor's copy constructors.
		/// </summary>
		/// <param name="other">
		/// Inheritors may extend their own constructor to manage additional properties
		/// as appropriate.
		/// </param>
		public StyleBase(StyleBase other) : this()
		{
			Name = other.Name;
			StyleType = other.StyleType;
			Index = other.Index;
			Color = other.Color;
			Highlight = other.Highlight;
			FontFamily = other.FontFamily;
			fontSize = other.fontSize;
			IsBold = other.IsBold;
			IsItalic = other.IsItalic;
			IsUnderline = other.IsUnderline;
			IsStrikethrough = other.IsStrikethrough;
			IsSuperscript = other.IsSuperscript;
			IsSubscript = other.IsSubscript;
			spaceBefore = other.spaceBefore;
			spaceAfter = other.spaceAfter;

			ApplyColors = other.ApplyColors;
		}


		/// <summary>
		/// Gets or sets the name of the style, mainly for user-defined styles.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the type of this style and the scope to which it should be applied.
		/// </summary>
		public StyleType StyleType { get; set; }

		/// <summary>
		/// Gets or sets an index that can be used as a QuickStyleDef index or an ordering
		/// of custom styles.
		/// </summary>
		public int Index { get; set; }

		/// <summary>
		/// Gets or sets the font foreground color.
		/// </summary>
		public string Color
		{
			get { return color; }

			set
			{
				if (value.Equals("automatic"))
					color = value;
				else
				{
					// normalize as #RGB to avoid case-sensitive comparison problems
					var c = ColorTranslator.FromHtml(value);
					color = $"#{c.R:X2}{c.G:X2}{c.B:X2}";
				}
			}
		}

		/// <summary>
		/// Gets or sets the font background color.
		/// </summary>
		public string Highlight
		{
			get { return highlight; }

			set
			{
				if (value.Equals("automatic"))
					highlight = value;
				else
				{
					// normalize as #RGB to avoid case-sensitive comparison problems
					var c = ColorTranslator.FromHtml(value);
					highlight = $"#{c.R:X2}{c.G:X2}{c.B:X2}";
				}
			}
		}

		/// <summary>
		/// Gets or sets the font family name; can be a comma-separated list of names.
		/// </summary>
		public string FontFamily { get; set; }

		/// <summary>
		/// Gets or sets the font size as a string.
		/// </summary>
		public virtual string FontSize
		{
			get { return fontSize.ToString("0.0#"); }
			set { fontSize = Convert.ToDouble(value); }
		}

		/// <summary>
		/// Gets or sets a Boolean indicating whether the font style is bold.
		/// </summary>
		public bool IsBold { get; set; }

		/// <summary>
		/// Gets or sets a Boolean indicating whether the font style is italicized.
		/// </summary>
		public bool IsItalic { get; set; }

		/// <summary>
		/// Gets or sets a Boolean indicating whether the font style is underlined.
		/// </summary>
		public bool IsUnderline { get; set; }

		/// <summary>
		/// Gets or sets a Boolean indicating whether the font style is strikethrough.
		/// </summary>
		public bool IsStrikethrough { get; set; }

		/// <summary>
		/// Gets or sets a Boolean indicating whether the font style is superscript.
		/// </summary>
		public bool IsSuperscript { get; set; }

		/// <summary>
		/// Gets or sets a Boolean indicating whether the font style is subscript.
		/// </summary>
		public bool IsSubscript { get; set; }

		/// <summary>
		/// Gets or sets the space added before the paragraph.
		/// </summary>
		public virtual string SpaceBefore
		{
			get { return spaceBefore.ToString("0.0#"); }
			set { spaceBefore = Convert.ToDouble(value); }
		}

		/// <summary>
		/// Gets or sets the space added after the paragraph.
		/// </summary>
		public virtual string SpaceAfter
		{
			get { return spaceAfter.ToString("0.0#"); }
			set { spaceAfter = Convert.ToDouble(value); }
		}


		//----------------------------------------------------------------------------------------
		// extended

		/// <summary>
		/// Gets or sets a Boolean indicating whether colors should be applied along
		/// with the rest of the style.
		/// </summary>
		/// <remarks>
		/// Stored by StyleRecord and used by Style but ignored by QuickStyleDef
		/// </remarks>
		public bool ApplyColors { get; set; }

	}
}