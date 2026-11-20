using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02001FE3 RID: 8163
public sealed class cep : cao
{
	// Token: 0x0600BFCA RID: 49098 RVA: 0x00427250 File Offset: 0x00425450
	public override void iv(e6d A_0, cp9 A_1)
	{
		Point point = base.at();
		if (!string.IsNullOrEmpty(this.a) && this.c.c > 0 && this.c.d > 0)
		{
			Texture2D texture2D = A_1.a.us(this.a, null);
			if (texture2D != null)
			{
				Rectangle value = new Rectangle(this.b.X, this.b.Y, this.c.c, this.c.d);
				Rectangle a_ = new Rectangle(point.X, point.Y, base.Size.c, base.Size.d);
				if (!this.Enabled)
				{
					value.X += this.c.c * 2;
				}
				A_1.b().w6(texture2D, a_, new Rectangle?(value), base.Color);
				if (!string.IsNullOrEmpty(this.e) && !string.IsNullOrEmpty(this.d))
				{
					SpriteFont resource = A_1.a.GetResource<SpriteFont>(this.e, null);
					if (resource != null)
					{
						Vector2 vector = resource.MeasureString(this.d);
						Vector2 a_2 = new Vector2((float)(point.X + Convert.ToInt32((float)base.Size.c * 0.9f - vector.X)), (float)point.Y + ((float)base.Size.d - vector.Y));
						A_1.b().xb(resource, this.d, a_2, this.f);
					}
				}
				if (this.Enabled && (this.IsMousedOver || base.Checked))
				{
					value = new Rectangle(this.b.X + this.c.c, this.b.Y, this.c.c, this.c.d);
					A_1.b().w6(texture2D, a_, new Rectangle?(value), base.Color);
				}
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x04004522 RID: 17698
	public new string a;

	// Token: 0x04004523 RID: 17699
	public new Point b;

	// Token: 0x04004524 RID: 17700
	public new esj c;

	// Token: 0x04004525 RID: 17701
	public new string d;

	// Token: 0x04004526 RID: 17702
	public new string e;

	// Token: 0x04004527 RID: 17703
	public new Color f = Color.White;
}
