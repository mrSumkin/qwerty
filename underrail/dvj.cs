using System;
using Microsoft.Xna.Framework;

// Token: 0x02000766 RID: 1894
public sealed class dvj : km
{
	// Token: 0x06003007 RID: 12295 RVA: 0x00123778 File Offset: 0x00121978
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		float num = 1f;
		mv mv = A_2.a as mv;
		c5x c5x = A_2.b.b as c5x;
		if (!c5x.IsPlayer && mv != null && mv.n != null)
		{
			blk blk;
			mv.n.TryGetValue(c5x.qe(), out blk);
			if (blk != null && blk.a().f() == cem.c)
			{
				num = 0.33f;
			}
		}
		foreach (a2f a2f in A_2.b.a)
		{
			if (a2f.a == "b" || a2f.a == "d")
			{
				a2f.e = new Color?(new Color(30, 30, 30));
				int num2 = A_0.d() % 17;
				float num3;
				if (num2 < 8)
				{
					num3 = 0.25f + (float)num2 / 16f;
				}
				else if (num2 > 8)
				{
					num3 = 0.75f - (float)(num2 - 8) / 16f;
				}
				else
				{
					num3 = 0.75f;
				}
				if (a2f.h == null)
				{
					a2f.h = new float?(num3 * num);
				}
				else
				{
					a2f.h *= num3 * num;
				}
			}
		}
	}
}
