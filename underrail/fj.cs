using System;
using Microsoft.Xna.Framework;

// Token: 0x0200074E RID: 1870
public sealed class fj : km
{
	// Token: 0x06002FD4 RID: 12244 RVA: 0x0012202C File Offset: 0x0012022C
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		els els = A_3 as els;
		if (els != null && els.i > 1000.0)
		{
			float value = (float)(0.699999988079071 * Math.Max(1.0, (els.i - 1000.0) / 1000.0));
			int num = -1;
			for (int i = 0; i < A_2.b.a.Count; i++)
			{
				if (A_2.b.a[i].a == "b")
				{
					num = i;
					break;
				}
			}
			if (num != -1)
			{
				int x = A_0.d() % 7;
				int x2 = A_0.d() % 17;
				a2f a2f = A_1.b(A_0, "Effects\\xpbl_EntrRecurLoop", new Point(x, 0), null, true);
				a2f a2f2 = A_1.b(A_0, "Effects\\xpbl_EntrRecurLoop", new Point(x, 1), null, true);
				a2f a2f3 = A_1.b(A_0, "Effects\\xpbl_EntrRecurLoop1", new Point(x2, 0), null, true);
				if (a2f != null && a2f.d != null)
				{
					a2f2.h = new float?(value);
					a2f2.e = new Color?(Color.White);
					eyc.a(a2f2, A_2, 0.4);
					A_2.b.a.Insert(num + 1, a2f2);
					a2f3.h = new float?(value);
					a2f3.e = new Color?(Color.White);
					eyc.a(a2f3, A_2, 0.4);
					A_2.b.a.Insert(num + 1, a2f3);
					a2f.h = new float?(value);
					a2f.e = new Color?(Color.White);
					eyc.a(a2f, A_2, 0.4);
					A_2.b.a.Insert(num, a2f);
				}
			}
		}
	}
}
