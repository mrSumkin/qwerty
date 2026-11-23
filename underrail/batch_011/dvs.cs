using System;
using Microsoft.Xna.Framework;

// Token: 0x02000753 RID: 1875
public sealed class dvs : km
{
	// Token: 0x06002FDE RID: 12254 RVA: 0x0012248C File Offset: 0x0012068C
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		els els = A_3 as els;
		if (els != null)
		{
			int x = A_0.d() % 9 / 3;
			int num = 0;
			for (int i = 0; i < A_2.b.a.Count; i++)
			{
				if (A_2.b.a[i].a == "b")
				{
					num = i;
					Vector2 j = A_2.b.a[i].j;
				}
			}
			for (int k = 1; k <= els.Stacks; k++)
			{
				a2f a2f = A_1.b(A_0, "Effects\\CryoShieldIdle", new Point(x, k - 1), null, true);
				a2f.h = new float?(0.8f);
				if (k == 2 || k == 5)
				{
					A_2.b.a(num, a2f);
					num++;
				}
				else
				{
					A_2.b.a(num + 1, a2f);
				}
			}
		}
	}
}
