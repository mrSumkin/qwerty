using System;
using Microsoft.Xna.Framework;

// Token: 0x0200073F RID: 1855
public sealed class crh : km
{
	// Token: 0x06002FB3 RID: 12211 RVA: 0x00120DB8 File Offset: 0x0011EFB8
	public override bool ib()
	{
		return false;
	}

	// Token: 0x06002FB4 RID: 12212 RVA: 0x00120DBC File Offset: 0x0011EFBC
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		ro ro = A_3 as ro;
		if (ro != null)
		{
			int x = A_0.d() % 8 * 2;
			float? h;
			if (ro.Duration > 0)
			{
				h = new float?(0.5f + 0.5f * d05.b(0f, Convert.ToSingle(ro.TimeLeft / (double)ro.Duration), 1f));
			}
			else
			{
				h = null;
			}
			a2f a2f = A_1.b(A_0, "Effects\\PsiRoot", new Point(x, 0), null, true);
			a2f a2f2 = A_1.b(A_0, "Effects\\PsiRoot", new Point(x, 1), null, true);
			foreach (a2f a2f3 in new a2f[]
			{
				a2f,
				a2f2
			})
			{
				eyc.a(a2f3, A_2, 0.0);
				a2f3.h = h;
				a2f3.f = 0.95f;
			}
			A_2.b.a(0, a2f);
			A_2.b.a(a2f2);
		}
	}
}
