using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001FD7 RID: 8151
public abstract class bbd : cao
{
	// Token: 0x0600BF5D RID: 48989 RVA: 0x00423CCC File Offset: 0x00421ECC
	protected virtual bool rj()
	{
		return false;
	}

	// Token: 0x0600BF5E RID: 48990 RVA: 0x00423CD0 File Offset: 0x00421ED0
	public override bool wo()
	{
		return false;
	}

	// Token: 0x0600BF5F RID: 48991 RVA: 0x00423CD4 File Offset: 0x00421ED4
	protected bbd(c8r A_0, int A_1 = 60)
	{
		this.e = A_0;
		base.Size = new esj(A_1, 60);
	}

	// Token: 0x0600BF60 RID: 48992 RVA: 0x00423CFC File Offset: 0x00421EFC
	public override void iv(e6d A_0, cp9 A_1)
	{
		bool flag = this.e != null && this.e.l == this;
		Point point = base.at();
		Vector2 a_ = point.b();
		wj wj = wj.a(UiSize.Small);
		Texture2D texture2D = A_1.a.us(wj.f, null);
		Color black = adi.a;
		Color a_2 = adi.b;
		int num = 0;
		if (flag)
		{
			num = bbd.b.c * 3;
			black = Color.Black;
		}
		else if (base.Pressed || this.rj())
		{
			num = bbd.b.c * 2;
			black = Color.Black;
		}
		else if (this.IsMousedOver)
		{
			num = bbd.b.c;
			black = adi.d;
		}
		if (texture2D != null)
		{
			if (esj.d(base.Size, bbd.b))
			{
				Rectangle value = bbd.c;
				value.X += num;
				A_1.b().w5(texture2D, a_, new Rectangle?(value), Color.White);
			}
			else if (base.Size.d == bbd.b.d)
			{
				int num2 = bbd.a.X + num;
				Rectangle rectangle = new Rectangle(num2, bbd.a.Y, bbd.b.c / 3, bbd.b.d);
				Rectangle rectangle2 = new Rectangle(point.X, point.Y, rectangle.Width, rectangle.Height);
				A_1.b().w6(texture2D, rectangle2, new Rectangle?(rectangle), Color.White);
				rectangle.X += rectangle.Width * 2;
				rectangle2.X += base.Size.c - rectangle2.Width;
				A_1.b().w6(texture2D, rectangle2, new Rectangle?(rectangle), Color.White);
				rectangle.X = num2 + rectangle.Width;
				rectangle2.X = point.X + rectangle.Width;
				rectangle2.Width = base.Size.c - 2 * rectangle.Width;
				A_1.b().w6(texture2D, rectangle2, new Rectangle?(rectangle), Color.White);
			}
		}
		if (this.g != null)
		{
			Rectangle a_3 = default(Rectangle);
			a_3.X = point.X + this.a((float)this.g.Value.Width, this.h);
			a_3.Y = point.Y + (base.Size.d - this.g.Value.Height) / 2;
			a_3.Width = this.g.Value.Width;
			a_3.Height = this.g.Value.Height;
			A_1.b().w6(texture2D, a_3, new Rectangle?(this.g.Value), black);
		}
		if (this.i)
		{
			string text = this.ri();
			string text2 = this.aio();
			if (this.e.k)
			{
				if (this.j)
				{
					text = text.ToUpperInvariant();
				}
				else if (text != null && text2 != null)
				{
					text = text2;
					text2 = null;
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				string au = egg.au;
				SpriteFont resource = A_1.a.GetResource<SpriteFont>(au, null);
				if (resource != null)
				{
					int num3 = egg.b(au);
					Vector2 vector = resource.MeasureString(text);
					Vector2 zero = Vector2.Zero;
					if (!string.IsNullOrEmpty(text2))
					{
						Vector2 vector2 = resource.MeasureString(text2);
						int num4 = Convert.ToInt32(vector.Y * 0.1f);
						int num5 = Convert.ToInt32(vector.Y + (float)num4 + vector2.Y);
						zero.X = (float)Convert.ToInt32(point.X + this.a(vector2.X));
						zero.Y = (float)Convert.ToInt32(point.Y + (base.Size.d - num5) / 2 + num3);
						A_1.b().xb(resource, text2, zero, a_2);
						zero.X = (float)Convert.ToInt32(point.X + this.a(vector.X));
						zero.Y = (float)Convert.ToInt32(point.Y + (base.Size.d - num5) / 2) + vector2.Y + (float)num4 + (float)num3;
					}
					else
					{
						zero = new Vector2((float)Convert.ToInt32(point.X + this.a(vector.X)), (float)Convert.ToInt32((float)point.Y + ((float)base.Size.d - vector.Y) / 2f + (float)num3));
					}
					A_1.b().xb(resource, text, zero, black);
				}
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600BF61 RID: 48993 RVA: 0x00424224 File Offset: 0x00422424
	private int a(float A_0)
	{
		return this.a(A_0, this.f);
	}

	// Token: 0x0600BF62 RID: 48994 RVA: 0x00424234 File Offset: 0x00422434
	private int a(float A_0, cab A_1)
	{
		if (A_1 == cab.b)
		{
			return Convert.ToInt32(((float)base.Size.c - A_0) / 2f);
		}
		if (A_1 == cab.c)
		{
			return Convert.ToInt32((float)base.Size.c - A_0 - (float)bbd.d);
		}
		return bbd.d;
	}

	// Token: 0x0600BF63 RID: 48995
	protected abstract string ri();

	// Token: 0x0600BF64 RID: 48996 RVA: 0x00424288 File Offset: 0x00422488
	protected virtual string aio()
	{
		return null;
	}

	// Token: 0x040044C9 RID: 17609
	private new static readonly Point a = new Point(777, 379);

	// Token: 0x040044CA RID: 17610
	private new static readonly esj b = new esj(60, 60);

	// Token: 0x040044CB RID: 17611
	private new static readonly Rectangle c = new Rectangle(bbd.a.X, bbd.a.Y, bbd.b.c, bbd.b.d);

	// Token: 0x040044CC RID: 17612
	private new static readonly int d = 10;

	// Token: 0x040044CD RID: 17613
	public new c8r e;

	// Token: 0x040044CE RID: 17614
	public new cab f;

	// Token: 0x040044CF RID: 17615
	public new Rectangle? g;

	// Token: 0x040044D0 RID: 17616
	public cab h;

	// Token: 0x040044D1 RID: 17617
	public bool i = true;

	// Token: 0x040044D2 RID: 17618
	public new bool j;
}
