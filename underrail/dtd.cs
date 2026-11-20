using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02001FF3 RID: 8179
public class dtd : cao
{
	// Token: 0x0600C080 RID: 49280 RVA: 0x0042B480 File Offset: 0x00429680
	public dtd()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			base.Size = new esj(43, 43);
			return;
		}
		base.Size = wj.d8;
	}

	// Token: 0x0600C081 RID: 49281 RVA: 0x0042B4C0 File Offset: 0x004296C0
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		wj wj = wj.a();
		Vector2 vector = base.at().b();
		if (wj.c())
		{
			if (base.Checked)
			{
				Texture2D resource = A_1.a.GetResource<Texture2D>(bo1.a9, null);
				A_1.b().w5(resource, vector, new Rectangle?(new Rectangle(0, 0, 43, 43)), Color.White);
			}
			if (this.a != null)
			{
				c3i c3i = ejh.b(this.a.Definition.a3(), A_1.a);
				Vector2 a_ = new Vector2(vector.X + 5f, vector.Y + 5f);
				if (c3i != null)
				{
					c3i.a(A_1, a_, Color.White, 1f, 0, null);
					return;
				}
			}
		}
		else
		{
			Texture2D resource2 = A_1.a.GetResource<Texture2D>(wj.f, null);
			if (base.Checked)
			{
				A_1.b().w5(resource2, vector, new Rectangle?(new Rectangle(wj.d7.X, wj.d7.Y, wj.d8.c, wj.d8.d)), Color.White);
			}
			if (this.a != null)
			{
				c3i c3i2 = ejh.b(this.a.Definition.a3(), A_1.a);
				if (c3i2 != null)
				{
					Point point = new Point((wj.d8.c - wj.o.c) / 2, (wj.d8.d - wj.d9 - wj.o.d) / 2);
					Rectangle a_2 = new Rectangle((int)vector.X + point.X, (int)vector.Y + point.Y, wj.o.c, wj.o.d);
					c3i2.a(A_1, a_2, Color.White, 0, null);
					as6.a(A_1, wj.w, wj.x, a_2.Location.b(), wj.o.b(), resource2, this.a);
				}
			}
		}
	}

	// Token: 0x0400458C RID: 17804
	public new coh a;
}
