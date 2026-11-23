using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000135 RID: 309
internal partial class bog : Form, dk1
{
	// Token: 0x0600078B RID: 1931 RVA: 0x00020550 File Offset: 0x0001E750
	public bog(eni A_0)
	{
		this.a = A_0;
		this.a();
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x00020568 File Offset: 0x0001E768
	private void a(object A_0, EventArgs A_1)
	{
		string[] array = this.e.Text.Split(new char[]
		{
			' '
		}, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length != 0)
		{
			string a_ = array[0];
			List<string> list = new List<string>();
			if (array.Length > 1)
			{
				for (int i = 1; i < array.Length; i++)
				{
					list.Add(array[i]);
				}
			}
			this.y9(Color.Black, 12, FontStyle.Bold, "\n> " + this.e.Text);
			this.a.a(a_, list.ToArray());
		}
		this.e.Text = "";
		this.e.Focus();
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x00020620 File Offset: 0x0001E820
	public void y9(Color A_0, int A_1, FontStyle A_2, string A_3)
	{
		this.c.ScrollToCaret();
		this.za(A_0, A_1, A_2, A_3 + "\n");
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x00020650 File Offset: 0x0001E850
	public void za(Color A_0, int A_1, FontStyle A_2, string A_3)
	{
		this.c.SelectionFont = new Font("Arial", 10f, A_2);
		this.c.SelectionColor = A_0;
		this.c.AppendText(A_3);
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x00020688 File Offset: 0x0001E888
	private void a(object A_0, FormClosedEventArgs A_1)
	{
		this.a.a(false);
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x000206C0 File Offset: 0x0001E8C0
	private void a()
	{
		this.c = new RichTextBox();
		this.d = new Button();
		this.e = new TextBox();
		base.SuspendLayout();
		this.c.BackColor = SystemColors.Window;
		this.c.Dock = DockStyle.Top;
		this.c.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.c.Location = new Point(0, 0);
		this.c.MaxLength = 2100000000;
		this.c.Name = "txtConsole";
		this.c.ReadOnly = true;
		this.c.Size = new Size(732, 477);
		this.c.TabIndex = 2;
		this.c.TabStop = false;
		this.c.Text = "";
		this.d.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.d.Location = new Point(618, 481);
		this.d.Name = "btnSend";
		this.d.Size = new Size(108, 23);
		this.d.TabIndex = 1;
		this.d.Text = "Send";
		this.d.UseVisualStyleBackColor = true;
		this.d.Click += this.a;
		this.e.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.e.Location = new Point(0, 483);
		this.e.Name = "txtCmdLine";
		this.e.Size = new Size(612, 20);
		this.e.TabIndex = 0;
		base.AcceptButton = this.d;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(732, 506);
		base.Controls.Add(this.d);
		base.Controls.Add(this.e);
		base.Controls.Add(this.c);
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.Name = "CommandConsoleForm";
		this.Text = "Ouroboros Console";
		base.FormClosed += this.a;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x0400056A RID: 1386
	private eni a;

	// Token: 0x0400056C RID: 1388
	private RichTextBox c;

	// Token: 0x0400056D RID: 1389
	private Button d;

	// Token: 0x0400056E RID: 1390
	private TextBox e;
}
