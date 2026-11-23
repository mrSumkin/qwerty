using System;
using Microsoft.Xna.Framework;

// Token: 0x02000745 RID: 1861
public sealed class egt : km
{
	// Token: 0x06002FC1 RID: 12225 RVA: 0x001217EC File Offset: 0x0011F9EC
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		int num = A_0.d() % 8;
		a2f a2f = A_1.b(A_0, "Effects\\xpbl_PolarizationLoop", new Point(num, 0), null, true);
		if (a2f != null && a2f.d != null)
		{
			a2f.j = new Vector2(-3f, -10f);
			a2f.h = new float?(1f);
			a2f.e = new Color?(new Color(87, 130, 193));
			A_2.b.a(a2f);
			eyc.a(a2f, A_2, 0.5);
			els els = A_3 as els;
			int num2 = num;
			if (els != null)
			{
				for (int i = 2; i <= els.Stacks; i++)
				{
					num2 = ((num2 == 0) ? 7 : (num2 - 1));
					a2f a2f2 = A_1.b(A_0, "Effects\\xpbl_PolarizationLoop", new Point(num2, 0), null, true);
					a2f2.e = new Color?(new Color(87, 130, 193));
					a2f2.h = new float?(1f - (float)(i - 1) * 0.2f);
					a2f2.j = a2f.j;
					A_2.b.a(a2f2);
				}
			}
		}
	}
}
