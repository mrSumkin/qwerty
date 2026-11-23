using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200201D RID: 8221
public class aqw : cao
{
	// Token: 0x0600C28E RID: 49806 RVA: 0x00435C1C File Offset: 0x00433E1C
	public override void iv(e6d A_0, cp9 A_1)
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			cne cne = dr3.a();
			if (cne != null)
			{
				Texture2D resource = cne.GetResource<Texture2D>(this.a, null);
				if (resource != null)
				{
					Rectangle value = default(Rectangle);
					value.Width = this.c.c;
					value.Height = this.c.d;
					value.Y = this.b.Y;
					if (base.Pressed || base.Checked)
					{
						value.X = this.b.X + 2 * this.c.c;
					}
					else if (this.IsMousedOver)
					{
						value.X = this.b.X + this.c.c;
					}
					else
					{
						value.X = this.b.X;
					}
					Point point = base.at();
					Rectangle a_ = default(Rectangle);
					a_.X = point.X;
					a_.Y = point.Y;
					if (this.d)
					{
						a_.Width = base.Size.c;
						a_.Height = base.Size.d;
					}
					else
					{
						a_.Width = this.c.c;
						a_.Height = this.c.d;
					}
					A_1.b().w6(resource, a_, new Rectangle?(value), base.Color);
				}
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x04004673 RID: 18035
	public new string a = bo1.a6;

	// Token: 0x04004674 RID: 18036
	public new Point b;

	// Token: 0x04004675 RID: 18037
	public new esj c = new esj(24, 23);

	// Token: 0x04004676 RID: 18038
	public new bool d;
}
