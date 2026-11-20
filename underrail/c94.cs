using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02001FDA RID: 8154
public sealed class c94 : euz
{
	// Token: 0x0600BF77 RID: 49015 RVA: 0x004252B4 File Offset: 0x004234B4
	public float a()
	{
		return this.h;
	}

	// Token: 0x0600BF78 RID: 49016 RVA: 0x004252BC File Offset: 0x004234BC
	public void a(float A_0)
	{
		if (A_0 > this.f)
		{
			this.h = this.f;
			return;
		}
		if (A_0 < this.e)
		{
			this.h = this.e;
			return;
		}
		this.h = A_0;
	}

	// Token: 0x0600BF79 RID: 49017 RVA: 0x004252F8 File Offset: 0x004234F8
	public c94()
	{
		wj wj = wj.a();
		if (!wj.c())
		{
			this.a = wj.ie;
			this.b = wj.@if;
			this.c = wj.f;
			this.d = wj.ig;
		}
		base.Size = new esj(100, this.a.d);
	}

	// Token: 0x0600BF7A RID: 49018 RVA: 0x004253C0 File Offset: 0x004235C0
	public override void iv(e6d A_0, cp9 A_1)
	{
		if (A_1.a != null)
		{
			float num = this.f - this.e;
			if (num > 0f)
			{
				int num2 = base.Size.c;
				int num3 = Convert.ToInt32(Math.Max(0f, (this.g - this.e) / num) * (float)num2);
				int num4 = num2 - num3;
				Texture2D resource = A_1.a.GetResource<Texture2D>(this.c, null);
				Point point = base.at();
				int num5 = (int)((float)this.b.c * 0.25f);
				if (resource != null)
				{
					if (num3 > 0)
					{
						Rectangle a_;
						if (num4 > 0)
						{
							a_ = new Rectangle(this.d.X, this.d.Y, this.b.c - num5, this.b.d);
						}
						else
						{
							a_ = new Rectangle(this.d.X, this.d.Y, this.b.c, this.b.d);
						}
						c4o.a(A_1, resource, a_, new Rectangle(point.X, point.Y, num3, this.b.d), this.j);
					}
					if (num4 > 0)
					{
						Rectangle a_2;
						if (num3 > 0)
						{
							a_2 = new Rectangle(this.d.X + num5, this.d.Y, this.b.c - num5, this.b.d);
						}
						else
						{
							a_2 = new Rectangle(this.d.X, this.d.Y, this.b.c, this.b.d);
						}
						c4o.a(A_1, resource, a_2, new Rectangle(point.X + num3, point.Y, num4, this.b.d), this.k);
					}
					if (this.i)
					{
						int num6 = Convert.ToInt32((float)num2 * ((this.h - this.e) / num));
						Rectangle value = new Rectangle(this.d.X + this.b.c, this.d.Y, this.a.c, this.a.d);
						Vector2 a_3 = new Point(point.X + num6 - this.a.c / 2, point.Y - (this.a.d - this.b.d) / 2).b();
						A_1.b().w5(resource, a_3, new Rectangle?(value), Color.White);
					}
				}
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x040044E4 RID: 17636
	private new esj a = new esj(11, 27);

	// Token: 0x040044E5 RID: 17637
	private new esj b = new esj(100, 15);

	// Token: 0x040044E6 RID: 17638
	private new string c = bo1.j;

	// Token: 0x040044E7 RID: 17639
	private new Point d;

	// Token: 0x040044E8 RID: 17640
	public new float e = -1f;

	// Token: 0x040044E9 RID: 17641
	public new float f = 1f;

	// Token: 0x040044EA RID: 17642
	public new float g;

	// Token: 0x040044EB RID: 17643
	private float h;

	// Token: 0x040044EC RID: 17644
	public bool i = true;

	// Token: 0x040044ED RID: 17645
	public new Color j = Color.Red;

	// Token: 0x040044EE RID: 17646
	public new Color k = Color.Green;
}
