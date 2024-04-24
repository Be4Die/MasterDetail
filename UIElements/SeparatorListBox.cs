using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing;

namespace MasterDetail.UIElements
{
    public class SeparatorListBox : ListBox
	{
		#region Constructor
		public SeparatorListBox()
		{
			DrawMode		= DrawMode.OwnerDrawVariable;
			_separatorStyle = DashStyle.Solid;

			_separatorStyle		= DashStyle.Solid;
			_separatorColor		= Color.Black;
			_separatorMargin	= 1;
			_separatorWidth		= 1;
			_autoAdjustItemHeight = false;
		}
        #endregion

        #region Medthods

        private void DrawSeparator(Graphics g, int x, int y)
        {
            using (Pen pen = new Pen(_separatorColor, _separatorWidth))
            {
                pen.DashStyle = _separatorStyle;
                g.DrawLine(pen, x + _separatorMargin, y, x + Width - _separatorMargin, y);
            }
        }

        #endregion

        #region Properties

        [Description("Gets or sets the Separator Style"), Category("Separator")]
		public DashStyle SeparatorStyle
		{
			get{ return _separatorStyle; }
			set{ _separatorStyle = value; }
		}

		[Description("Gets or sets the Separator Color"), Category("Separator")]
		public Color SeparatorColor
		{
			get{ return _separatorColor; }
			set{ _separatorColor = value; }
		}

		[Description("Gets or sets the Separator Width"), Category("Separator")]
		public int SeparatorWidth
		{
			get{ return _separatorWidth; }
			set{ _separatorWidth = value; }
		}

		[Description("Gets or sets the Separator Margin"), Category("Separator")]
		public int SeparatorMargin
		{
			get{ return _separatorMargin; }
			set{ _separatorMargin = value; }
		}

		[Description("Gets or sets Auto Adjust Item Height"), Category("Separator")]
		public bool AutoAdjustItemHeight
		{
			get{ return _autoAdjustItemHeight; }
			set{ _autoAdjustItemHeight = value; }
		}

        #endregion

        #region Overrides
        protected override void OnMeasureItem(MeasureItemEventArgs e)
		{
			if (_autoAdjustItemHeight)
				e.ItemHeight += _separatorWidth;

			base.OnMeasureItem(e);
		}

        protected override void OnDrawItem(DrawItemEventArgs e)
		{
            if (e.Index < 0 || e.Index >= Items.Count) return;

            int textY = e.Bounds.Top + (e.Bounds.Height - e.Font.Height) / 2;
            int separatorY = e.Bounds.Bottom - 1;
			
			if (SelectedIndex == e.Index)
			{
				e.DrawBackground();
				e.DrawFocusRectangle();
			}

            DrawSeparator(e.Graphics, e.Bounds.Left, e.Bounds.Top + _separatorMargin);
            using (Pen pen = new Pen(_separatorColor, _separatorWidth))
            {
                pen.DashStyle = _separatorStyle;
                e.Graphics.DrawLine(pen, e.Bounds.Left + _separatorMargin, separatorY + _separatorMargin + _separatorWidth, e.Bounds.Right - _separatorMargin, separatorY + _separatorMargin + _separatorWidth);
            }

            if (e.Index < Items.Count - 1 || true)
            {
                using (Pen pen = new Pen(_separatorColor, _separatorWidth))
                {
                    pen.DashStyle = _separatorStyle;
                    e.Graphics.DrawLine(pen, e.Bounds.Left + _separatorMargin, separatorY + _separatorMargin + _separatorWidth, e.Bounds.Right - _separatorMargin, separatorY + _separatorMargin + _separatorWidth);
                }
            }
            DrawSeparator(e.Graphics, e.Bounds.Left, separatorY + _separatorWidth + _separatorMargin);

			Brush brush = (e.State & DrawItemState.Selected) == DrawItemState.Selected ? SystemBrushes.HighlightText : new SolidBrush(e.ForeColor);
            e.Graphics.DrawString(Items[e.Index].ToString(), e.Font, brush, e.Bounds.Left, textY);

            base.OnDrawItem(e);
        }
		#endregion

		#region Data members

		DashStyle	_separatorStyle;
		Color		_separatorColor;
        int			_separatorWidth;
		int			_separatorMargin;
		bool		_autoAdjustItemHeight;
		#endregion
	}
}
