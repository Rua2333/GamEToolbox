using System;
using System.Collections.Generic;
using System.Drawing;

namespace UIWigets
{
    public class RichText
    {
        private string str;
        private Color _color = Color.Azure;
        private TextStyle _textStyle = TextStyle.NONE;
        private string richTxet = null;

        public enum TextStyle
        {
            NONE = 0,
            B = 1,
            I = 2,
            BI = 3
        }

        private readonly string[] styleTags =
        {
            "", "b", "i"
        };

        public RichText() : this("", null, null) { }

        public RichText(string str) : this(str, null, null) { }

        public RichText(string str, TextStyle textStyle) : this(str, textStyle, null) { }
        
        public RichText(string str, Color color) : this(str, null, color) { }

        public RichText(string str, RTStyle rtStyle) : this(str, rtStyle.getTextStyle(), rtStyle.getColor()) { }

        public RichText(string str, TextStyle? textStyle, Color? color)
        {
            this.str = str;
            this.applyProp(new RTStyle(textStyle, color));
        }

        public string append(string str) => this.str += str;
        public string append(RichText richText) => this.append(richText.ToString());

        public string applyColor(Color color)
        {
            this._color = color;
            return _ApplySelfProp();
        }

        public string applyStyle(TextStyle textStyle)
        {
            this._textStyle = textStyle;
            return _ApplySelfProp();
        }


        public string surroundWithColor(Color color)
        {
            this.str = this.richTxet;
            return this.applyColor(color);
        }

        public string surroundWithStyle(TextStyle textStyle)
        {
            this.str = this.richTxet;
            return this.applyStyle(textStyle);
        }

        public string surroundWithProp(RTStyle rtStyle)
        {
            this.str = this.richTxet;
            return this.applyProp(rtStyle);
        }

        public string applyProp(RTStyle rtStyle)
        {
            Color? newColor = rtStyle.getColor();
            TextStyle? newTextStyle = rtStyle.getTextStyle();
            this._color = newColor.Equals(null) ? this._color : (Color) newColor;
            this._textStyle = newTextStyle.Equals(null) ? this._textStyle : (TextStyle) newTextStyle;
            return _ApplySelfProp();
        }

        private string _ApplySelfProp()
        {
            this.richTxet = $"{this.str}";
            if (this._textStyle != TextStyle.NONE)
            {
                var styleTag = styleTags[(int) this._textStyle];
                this._textStyle = (TextStyle) this._textStyle;
                this.richTxet = $"<{styleTag}>{this.richTxet}</{styleTag}>";
            }

            var colorTag = _GetColorValueInHex(this._color);
            this.richTxet = $"<color={colorTag}>{this.richTxet}</color>";
            return this.richTxet;
        }

        public TextStyle? getTextStyle() => this._textStyle;
        public string getOriginStr() => this.str;
        public string getRichText() => this.richTxet;

        private static string _GetColorValueInHex(Color color) =>
            $"#{_GetHexOfByte(color.R)}{_GetHexOfByte(color.G)}{_GetHexOfByte(color.B)}{_GetHexOfByte(color.A)}";

        private static string _GetHexOfByte(byte b)
        {
            const string hex = "0123456789abcdef";
            return "" + hex[(b & 0xF0) >> 4] + hex[b & 0x0F];
        }

        public static string getRichTextStrForEvent(bool successed, string eventName, string message = "") =>
            $"{new RichText(message, Color.Silver)}" + $"[{new RichText(eventName, Color.CornflowerBlue)}]" +
            Toolkit.Toolkit._GetTimeStamp_simple() +
            (successed ? $"{new RichText("[√]", Color.Lime)}" : $"{new RichText("[X]", Color.Red)}");

        public static string getRichTextStrForEvent(string eventName, string message = "") =>
            $"{new RichText(message, Color.Silver)}" + $"[{new RichText(eventName, Color.CornflowerBlue)}]" +
            Toolkit.Toolkit._GetTimeStamp_simple() + $" {new RichText("<", Color.CornflowerBlue)}";

        public static RichText operator +(RichText rt1, RichText rt2) => new RichText(rt1.ToString() + rt2.ToString());

        public override string ToString() => this.richTxet;
    }


    public class RTStyle
    {
        private Color? _color;
        private RichText.TextStyle? _textStyle;

        public RTStyle() : this(null, null) { }

        public RTStyle(Color? color) : this(null, color) { }

        public RTStyle(RichText.TextStyle? textStyle) : this(textStyle, null) { }

        public RTStyle(RichText.TextStyle? textStyle, Color? color)
        {
            this._color = color;
            this._textStyle = textStyle;
        }

        public Color? getColor() => this._color;
        public RichText.TextStyle? getTextStyle() => this._textStyle;
    }
}