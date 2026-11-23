using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Token: 0x0200201A RID: 8218
public class c68 : t3
{
	// Token: 0x0600C26D RID: 49773 RVA: 0x004351A0 File Offset: 0x004333A0
	public string c()
	{
		return this.l.g();
	}

	// Token: 0x0600C26E RID: 49774 RVA: 0x004351B0 File Offset: 0x004333B0
	public void a(string A_0)
	{
		this.l.a(A_0);
	}

	// Token: 0x0600C26F RID: 49775 RVA: 0x004351C0 File Offset: 0x004333C0
	public new Point e()
	{
		return this.h;
	}

	// Token: 0x0600C270 RID: 49776 RVA: 0x004351C8 File Offset: 0x004333C8
	public void a(Point A_0)
	{
		this.h = A_0;
		this.a();
	}

	// Token: 0x0600C271 RID: 49777 RVA: 0x004351D8 File Offset: 0x004333D8
	public new bool d()
	{
		return this.i;
	}

	// Token: 0x0600C272 RID: 49778 RVA: 0x004351E0 File Offset: 0x004333E0
	public void a(bool A_0)
	{
		this.i = A_0;
		this.a();
	}

	// Token: 0x0600C273 RID: 49779 RVA: 0x004351F4 File Offset: 0x004333F4
	public c68()
	{
		this.b();
		this.a();
		e4z.a(this);
	}

	// Token: 0x0600C274 RID: 49780 RVA: 0x00435248 File Offset: 0x00433448
	public override void iv(e6d A_0, cp9 A_1)
	{
		bool flag = base.IsFocus || bl9.a(this);
		this.l.Text = base.Text;
		if (this.j != null && !flag && string.IsNullOrEmpty(base.Text))
		{
			this.l.Text = this.j;
		}
		if (this.Enabled)
		{
			if (this.IsMousedOver || euz.DesignMode)
			{
				this.l.Color = this.c;
			}
			else
			{
				this.l.Color = this.b;
			}
			if ((this.IsMousedOver || euz.DesignMode || flag) && !string.IsNullOrEmpty(this.e) && this.Enabled)
			{
				cne cne = A_1.a;
				if (cne != null)
				{
					Texture2D resource = cne.GetResource<Texture2D>(this.e, null);
					if (resource != null)
					{
						Point point = base.at();
						as6.a(A_1.b(), resource, point, base.Size, base.Color, new Point?(this.f), this.g);
						SpriteFont resource2 = cne.GetResource<SpriteFont>(this.l.g(), null);
						if (resource2 != null)
						{
							if (this.e != null && this.d != this.e.Value)
							{
								int num = Math.Min(this.d, this.e.Value);
								int length = Math.Abs(this.d - this.e.Value);
								string text = base.Text.Substring(0, num);
								string text2 = base.Text.Substring(num, length);
								int num2 = Convert.ToInt32(resource2.MeasureString(text).X);
								Point a_ = new Point(point.X + this.h.X + num2, point.Y + this.h.Y);
								Vector2 vector = resource2.MeasureString(text2);
								esj a_2 = new esj((int)vector.X, (int)vector.Y);
								if (!string.IsNullOrEmpty(this.m))
								{
									Texture2D resource3 = cne.GetResource<Texture2D>(this.m, null);
									if (resource3 != null)
									{
										as6.a(A_1.b(), resource3, a_, a_2, Color.White * 0.5f, null, null);
									}
								}
								else
								{
									as6.a(A_1.b(), resource, a_, a_2, new Color(100, 100, 100, 255), new Point?(this.f), this.g);
								}
							}
							if (flag && A_0.a().TotalGameTime.Milliseconds % 500 > 250)
							{
								string text3;
								if (!string.IsNullOrEmpty(base.Text))
								{
									text3 = base.Text.Substring(0, base.s());
								}
								else
								{
									text3 = string.Empty;
								}
								string text4;
								if (base.Text == null || base.s() >= base.Text.Length)
								{
									text4 = "0";
								}
								else
								{
									text4 = base.Text.Substring(base.s(), 1);
								}
								Point point2 = d05.a(point, new Point(this.h.X + (int)resource2.MeasureString(text3).X, 2), false);
								esj esj = new esj((int)resource2.MeasureString(text4).X, base.Size.d - 4);
								if (point2.X + esj.c <= point.X + base.Size.c)
								{
									if (!string.IsNullOrEmpty(this.m))
									{
										Texture2D resource4 = cne.GetResource<Texture2D>(this.m, null);
										if (resource4 != null)
										{
											as6.a(A_1.b(), resource4, point2, esj, Color.White, null, null);
										}
									}
									else
									{
										as6.a(A_1.b(), resource, point2, esj, new Color(0, 0, 0, 100), new Point?(this.f), this.g);
									}
								}
							}
						}
					}
				}
			}
		}
		else
		{
			this.l.Color = this.d;
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C275 RID: 49781 RVA: 0x004356E0 File Offset: 0x004338E0
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.a();
	}

	// Token: 0x0600C276 RID: 49782 RVA: 0x004356F0 File Offset: 0x004338F0
	protected override void h8(object A_0, ane A_1)
	{
		base.h8(A_0, A_1);
		if (A_1 != null && A_1.a >= Keys.NumLock && A_1.a <= Keys.RightAlt)
		{
			return;
		}
		e4z.f();
	}

	// Token: 0x0600C277 RID: 49783 RVA: 0x00435728 File Offset: 0x00433928
	protected override bool ahc()
	{
		if (this.k)
		{
			SpriteFont resource = dr3.a().GetResource<SpriteFont>(this.l.g(), null);
			if (resource != null)
			{
				Vector2 vector = resource.MeasureString(base.Text);
				Vector2 vector2 = resource.MeasureString("W");
				if (vector.X + vector2.X > (float)(base.Size.c - 5 - 2 * this.h.X))
				{
					return true;
				}
			}
			return false;
		}
		return base.ahc();
	}

	// Token: 0x0600C278 RID: 49784 RVA: 0x004357B8 File Offset: 0x004339B8
	private void b()
	{
		this.l = new avo();
		this.l.IsPrivateComponent = true;
		this.l.a(false);
		this.l.a(egg.b);
		this.l.a(cab.a);
		this.l.a(ad4.b);
		this.aox(this.l);
	}

	// Token: 0x0600C279 RID: 49785 RVA: 0x00435820 File Offset: 0x00433A20
	private void a()
	{
		if (this.l != null)
		{
			this.l.Location = this.h;
			if (this.i)
			{
				this.l.Size = new esj(base.Size.c - this.h.X, base.Size.d);
				return;
			}
			this.l.Size = new esj(base.Size.c - this.h.X, base.Size.d - this.h.Y);
		}
	}

	// Token: 0x0600C27A RID: 49786 RVA: 0x004358C8 File Offset: 0x00433AC8
	protected override bool ajp()
	{
		return bl9.a(this);
	}

	// Token: 0x0400465B RID: 18011
	private new const int a = 2;

	// Token: 0x0400465C RID: 18012
	public new Color b = Color.White;

	// Token: 0x0400465D RID: 18013
	public new Color c = Color.White;

	// Token: 0x0400465E RID: 18014
	public new Color d = Color.White;

	// Token: 0x0400465F RID: 18015
	public new string e = bo1.b;

	// Token: 0x04004660 RID: 18016
	public new Point f;

	// Token: 0x04004661 RID: 18017
	public new esj? g;

	// Token: 0x04004662 RID: 18018
	private new Point h;

	// Token: 0x04004663 RID: 18019
	private new bool i;

	// Token: 0x04004664 RID: 18020
	public new string j;

	// Token: 0x04004665 RID: 18021
	public new bool k;

	// Token: 0x04004666 RID: 18022
	private new avo l;

	// Token: 0x04004667 RID: 18023
	public new string m;
}
