using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common.Settings;

// Token: 0x0200203F RID: 8255
public sealed class j9 : euz
{
	// Token: 0x0600C3AC RID: 50092 RVA: 0x0043D330 File Offset: 0x0043B530
	public j9(esj A_0)
	{
		base.Size = A_0;
		wj wj = wj.a();
		if (wj.d != UiSize.Classic)
		{
			this.c = wj.df;
			this.d = wj.dg;
		}
		this.g = new cri();
		this.g.Location = new Point(this.d, base.Size.d - this.c + 4);
		this.g.Size = new esj(base.Size.c, 20);
		this.g.c(bo1.b);
		this.g.b(egg.am);
		this.g.i = false;
		if (wj.d != UiSize.Classic)
		{
			this.g.b(wj.di);
			this.i = wj.dh;
			this.g.Size = new esj(base.Size.c, this.c - 8);
			if (!string.IsNullOrEmpty(this.i))
			{
				SpriteFont resource = bpo.GetServiceOrThrow<cne>().GetResource<SpriteFont>(this.i, null);
				if (resource != null)
				{
					this.g.a(new Point(this.g.e().X, (this.g.Size.d - resource.LineSpacing) / 2));
				}
			}
		}
		this.g.a(true);
		this.g.b(adi.c);
		this.g.a(adi.a);
		this.g.d(adi.b);
		this.g.h = new Func<object, Keys, List<Keys>, bool, bool>(this.a);
		this.g.o = new Func<string, string>(bdg.b);
		this.g.Text = j9.e;
		this.g.i(new EventHandler(this.a));
		this.g.o(new EventHandler<c1>(this.a));
		this.aox(this.g);
	}

	// Token: 0x0600C3AD RID: 50093 RVA: 0x0043D580 File Offset: 0x0043B780
	private void a(object A_0, c1 A_1)
	{
		this.h = bdg.a(this.g.Text, 20, false);
	}

	// Token: 0x0600C3AE RID: 50094 RVA: 0x0043D59C File Offset: 0x0043B79C
	public void b()
	{
		this.g.Enabled = true;
		if (!this.g.IsFocus)
		{
			this.g.a9();
		}
	}

	// Token: 0x0600C3AF RID: 50095 RVA: 0x0043D5C8 File Offset: 0x0043B7C8
	public void a()
	{
		this.g.Enabled = false;
		j9.e = this.g.Text;
		if (this.g.IsFocus)
		{
			this.g.bp();
		}
	}

	// Token: 0x0600C3B0 RID: 50096 RVA: 0x0043D604 File Offset: 0x0043B804
	public override void iv(e6d A_0, cp9 A_1)
	{
		Texture2D texture2D = A_1.a.us(bo1.u, null);
		Point point = base.at();
		if (texture2D != null)
		{
			Rectangle a_ = new Rectangle(point.X, point.Y, base.Size.c, base.Size.d - this.c);
			c4o.b(A_1, texture2D, j9.a, Point.Zero, a_, Color.White * 0.7f, true, null);
		}
		Texture2D texture2D2 = A_1.a.us(bo1.a1, null);
		if (texture2D2 != null)
		{
			Rectangle a_2 = new Rectangle(point.X, point.Y + base.Size.d - this.c, base.Size.c, this.c);
			c4o.b(A_1, texture2D2, j9.b, Point.Zero, a_2, Color.White * 0.7f, true, null);
		}
		dn3 dn = bdg.d().b();
		Point a_3 = new Point(point.X + bdg.j, point.Y + base.Size.d - this.c - dn.b.d);
		dn.a(a_3, A_1, null, 0.85f);
		base.iv(A_0, A_1);
		if (this.h != null && this.h.Count > 0)
		{
			SpriteFont resource = A_1.a.GetResource<SpriteFont>(this.i, null);
			if (resource != null)
			{
				Texture2D texture2D3 = A_1.a.us(bo1.a3, null);
				if (texture2D3 != null)
				{
					int num = 0;
					foreach (string text in this.h)
					{
						num = Convert.ToInt32(Math.Max((float)num, resource.MeasureString(text).X));
					}
					Rectangle a_4 = new Rectangle(point.X + base.Size.c - num - 20, point.Y + base.Size.d - this.c - resource.LineSpacing * (this.h.Count + 1) - 8, num + 20, resource.LineSpacing * this.h.Count + 16);
					c4o.b(A_1, texture2D3, new esj(20, 20), Point.Zero, a_4, Color.White * 0.75f, true, null);
				}
				for (int i = 0; i < this.h.Count; i++)
				{
					string text2 = this.h[i];
					if (text2 != null && text2.Length > 30)
					{
						text2.Substring(0, 30);
					}
					Vector2 a_5 = new Vector2((float)(point.X + base.Size.c) - resource.MeasureString(text2).X - 10f, (float)(point.Y + base.Size.d - this.c - resource.LineSpacing * (1 + this.h.Count - i)));
					A_1.b().xb(resource, text2, a_5, Color.Gray * 0.75f);
				}
			}
		}
	}

	// Token: 0x0600C3B1 RID: 50097 RVA: 0x0043D9B0 File Offset: 0x0043BBB0
	protected override void h8(object A_0, ane A_1)
	{
		base.h8(A_0, A_1);
		if (A_1.a == Keys.OemTilde)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.ang(false);
			}
		}
	}

	// Token: 0x0600C3B2 RID: 50098 RVA: 0x0043D9E8 File Offset: 0x0043BBE8
	private bool a(object A_0, Keys A_1, List<Keys> A_2, bool A_3)
	{
		if (A_1 == Keys.OemTilde)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.ang(false);
			}
			return true;
		}
		if (A_1 == Keys.Escape)
		{
			this.g.Text = "";
			return true;
		}
		if (A_1 == Keys.Enter)
		{
			this.f = -1;
			bdg.c(this.g.Text);
			this.g.Text = "";
			return true;
		}
		if (A_1 == Keys.Tab)
		{
			string str = bdg.b(this.g.Text);
			cri cri = this.g;
			cri.Text += str;
			this.g.p();
		}
		else if (A_1 == Keys.Up)
		{
			this.f = Math.Min(bdg.d.Count - 1, this.f + 1);
			if (this.f != -1)
			{
				string text = bdg.d[this.f];
				if (text != null)
				{
					this.g.Text = text;
					this.g.p();
				}
			}
		}
		else if (A_1 == Keys.Down)
		{
			this.f = Math.Max(-1, this.f - 1);
			if (this.f == -1)
			{
				this.g.Text = "";
			}
			else
			{
				string text2 = bdg.d[this.f];
				if (text2 != null)
				{
					this.g.Text = text2;
					this.g.p();
				}
			}
		}
		return false;
	}

	// Token: 0x0600C3B3 RID: 50099 RVA: 0x0043DB74 File Offset: 0x0043BD74
	private void a(object A_0, EventArgs A_1)
	{
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.ang(false);
		}
	}

	// Token: 0x0400472C RID: 18220
	private new static readonly esj a = new esj(40, 40);

	// Token: 0x0400472D RID: 18221
	private new static readonly esj b = new esj(120, 14);

	// Token: 0x0400472E RID: 18222
	private new int c = 28;

	// Token: 0x0400472F RID: 18223
	private new int d = 7;

	// Token: 0x04004730 RID: 18224
	private new static string e;

	// Token: 0x04004731 RID: 18225
	private new int f = -1;

	// Token: 0x04004732 RID: 18226
	private new cri g;

	// Token: 0x04004733 RID: 18227
	private List<string> h;

	// Token: 0x04004734 RID: 18228
	private string i = egg.ad;
}
