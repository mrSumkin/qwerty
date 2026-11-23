using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02001FDF RID: 8159
public sealed class bw9 : cao
{
	// Token: 0x0600BFA8 RID: 49064 RVA: 0x0042651C File Offset: 0x0042471C
	public override void iv(e6d A_0, cp9 A_1)
	{
		if (!string.IsNullOrEmpty(this.a) && this.c.c > 0 && this.c.d > 0)
		{
			Texture2D texture2D = A_1.a.us(this.a, null);
			if (texture2D != null)
			{
				Point point = base.at();
				Rectangle value = new Rectangle(this.b.X, this.b.Y, this.c.c, this.c.d);
				Rectangle a_ = new Rectangle(point.X, point.Y, base.Size.c, base.Size.d);
				if (base.Checked)
				{
					if (this.g != null)
					{
						Point point2 = new Point((this.g.Value.Width - base.Size.c) / 2, (this.g.Value.Height - base.Size.d) / 2);
						Rectangle a_2 = new Rectangle(point.X - point2.X, point.Y - point2.Y, this.g.Value.Width, this.g.Value.Height);
						A_1.b().w6(texture2D, a_2, this.g, (this.f != null) ? this.f.Value : base.Color);
					}
					else
					{
						Texture2D resource = A_1.a.GetResource<Texture2D>("Locale\\Meta\\Blank", null);
						A_1.b().xa(resource, a_, base.Color);
					}
				}
				Color a_3;
				if (base.Checked)
				{
					a_3 = this.e;
				}
				else if (this.IsMousedOver)
				{
					a_3 = this.d;
				}
				else
				{
					a_3 = base.Color;
				}
				A_1.b().w6(texture2D, a_, new Rectangle?(value), a_3);
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x04004511 RID: 17681
	public new string a;

	// Token: 0x04004512 RID: 17682
	public new Point b;

	// Token: 0x04004513 RID: 17683
	public new esj c;

	// Token: 0x04004514 RID: 17684
	public new Color d = Color.White;

	// Token: 0x04004515 RID: 17685
	public new Color e = Color.Black;

	// Token: 0x04004516 RID: 17686
	public new Color? f;

	// Token: 0x04004517 RID: 17687
	public new Rectangle? g;
}
