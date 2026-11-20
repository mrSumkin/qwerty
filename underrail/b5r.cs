using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Token: 0x02001FE9 RID: 8169
public sealed class b5r : euz
{
	// Token: 0x0600BFEF RID: 49135 RVA: 0x00428C84 File Offset: 0x00426E84
	public void a()
	{
		this.g = 1.0;
		this.h = (double)b5r.d;
	}

	// Token: 0x0600BFF0 RID: 49136 RVA: 0x00428CA4 File Offset: 0x00426EA4
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		if (this.g > 0.0)
		{
			Texture2D resource = A_1.a.GetResource<Texture2D>(bo1.p, null);
			if (resource != null)
			{
				Point point = base.at();
				Rectangle a_ = new Rectangle(point.X, point.Y, base.Size.c, base.Size.d);
				c4o.b(A_1, resource, new esj(24, 24), Point.Zero, a_, Color.White * (float)(0.699999988079071 * this.g), true, null);
				SpriteFont resource2 = A_1.a.GetResource<SpriteFont>(egg.b, null);
				if (resource2 != null)
				{
					string text = Convert.ToInt32(ces.b().aq8() * 100f).ToString() + "%";
					Vector2 vector = resource2.MeasureString(text);
					Vector2 a_2 = new Vector2((float)point.X + ((float)base.Size.c - vector.X) / 2f, (float)point.Y + ((float)base.Size.d - vector.Y) / 2f + 6f);
					A_1.b().xb(resource2, text, a_2, adi.a * (float)this.g);
				}
			}
		}
	}

	// Token: 0x0600BFF1 RID: 49137 RVA: 0x00428E24 File Offset: 0x00427024
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		double totalMilliseconds = A_0.a().ElapsedGameTime.TotalMilliseconds;
		if (this.h > 0.0)
		{
			this.h -= totalMilliseconds;
			return;
		}
		if (this.g > 0.0)
		{
			this.g = Math.Max(0.0, this.g - totalMilliseconds * b5r.e);
		}
	}

	// Token: 0x0600BFF2 RID: 49138 RVA: 0x00428EA8 File Offset: 0x004270A8
	public override bool iz(MouseState A_0)
	{
		return false;
	}

	// Token: 0x04004547 RID: 17735
	private new const int a = 200;

	// Token: 0x04004548 RID: 17736
	private new static readonly string b = bo1.ad;

	// Token: 0x04004549 RID: 17737
	private new static readonly Rectangle c = new Rectangle(0, 218, 19, 30);

	// Token: 0x0400454A RID: 17738
	private new static readonly int d = 800;

	// Token: 0x0400454B RID: 17739
	private new static readonly double e = 0.0015;

	// Token: 0x0400454C RID: 17740
	private new static readonly int f = 5;

	// Token: 0x0400454D RID: 17741
	private new double g;

	// Token: 0x0400454E RID: 17742
	private double h;
}
