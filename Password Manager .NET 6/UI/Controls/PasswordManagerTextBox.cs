using Secure_The_Pass_Services_Core.Extensions;
using System.ComponentModel;

namespace Secure_The_Pass.UI.Controls
{
    [DefaultEvent(nameof(_TextChanged))]
    public partial class PasswordManagerTextBox : UserControl
    {
        #region Field
        private Color borderColor = Color.FromArgb(158, 161, 176);
        private int borderSize = 2;
        private bool underlinedStyle = true;
        private Color borderFocusColor = SystemColors.Highlight;
        private bool isFocused = false;
        private bool _isInvalid = false;
        #endregion

        #region Constructor 
        public PasswordManagerTextBox()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(24, 30, 54);

            textBox1.Anchor = Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        }
        #endregion

        #region Events
        public event EventHandler _TextChanged;
        #endregion

        #region Properties
        #region Textbox
        [DefaultValue(typeof(Color), "158, 161, 176")]
        [Category("Generally")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Generally")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Generally")]
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("Generally")]
        public bool UseSystemPasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        [Category("Generally")]
        public string PlaceholderText
        {
            get { return textBox1.PlaceholderText; }
            set { textBox1.PlaceholderText = value; }
        }

        [Category("Generally")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        [Category("Generally")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("Generally")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("Generally")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("Generally")]
        public override string Text
        {
            get { return textBox1.Text; }
            set { 
                textBox1.Text = value;
                this.Invalidate();
            }
        }

        [Category("Generally")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        public void Clear()
        {
            textBox1.Clear();
        }

        /// <summary>
        /// If you use the TextBox for Login data and the data are incorrect 
        /// you can set the value to true and the Border Color change to Red.
        /// </summary>
        [Category("Generally")]
        public bool IsInvalid
        {
            get { return _isInvalid; }
            set
            {
                _isInvalid = value;

                if (_isInvalid)
                {
                    BorderColor = Color.Red;
                }
                else if (BorderColor == Color.Red)
                {
                    BorderColor = nameof(BorderColor).GetDefaultValue<Color, PasswordManagerTextBox>();
                    label1.Visible = false;
                }
            }
        }
        #endregion

        #region Label
        public string SetInfoText
        {
            get { return label1.Text; }
            set
            {
                label1.Text = value;
                label1.Visible = !string.IsNullOrEmpty(label1.Text);
                label1.ForeColor = BorderColor;
                UpdateControlHeight();
            }
        }

        public string ErroText
        {
            get { return label1.Text; }
            set
            {
                label1.Text = value;
                IsInvalid = label1.Visible = !string.IsNullOrEmpty(label1.Text);
                label1.ForeColor = BorderColor;
                UpdateControlHeight();
            }
        }

        #endregion
        #endregion

        #region Overridden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            //Draw border
            using (Pen penBorder = new(BorderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (isFocused && !IsInvalid)
                {
                    penBorder.Color = borderFocusColor;
                }

                if (underlinedStyle) //Line Style
                {
                    graph.DrawLine(penBorder, 0, textBox1.Bottom + 3, this.Width, textBox1.Bottom + 3);
                }
                else //Normal Style
                {
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        #endregion

        #region Private methods
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                if (!label1.Visible)
                {
                    this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
                }
                else
                {
                    this.Height = textBox1.Height + label1.Height + 7 + this.Padding.Top + this.Padding.Bottom;
                }
            }
        }

        #region TextBox events
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           IsInvalid = false;
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }
        #endregion
        #endregion
    }
}
