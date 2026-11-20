using System;
using Microsoft.Xna.Framework;

// Token: 0x02000740 RID: 1856
public sealed class abl : km
{
	// Token: 0x06002FB6 RID: 12214 RVA: 0x00120ED0 File Offset: 0x0011F0D0
	public override bool ib()
	{
		return true;
	}

	// Token: 0x06002FB7 RID: 12215 RVA: 0x00120ED4 File Offset: 0x0011F0D4
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		ec4 ec = A_3 as ec4;
		if (ec != null)
		{
			int x = A_0.d() % 6;
			if (ec.d != null)
			{
				int num = (int)a63.b(ec.h);
				a2f a2f = A_1.b(A_0, "Effects\\PsiChainIn", new Point(x, num), null, true);
				if (a2f == null || a2f.d == null)
				{
					return;
				}
				a2f.h = new float?(0.75f);
				a2f.f = 0.95f;
				eyc.a(a2f, A_2, 0.5);
				if (num >= 3 && num <= 6)
				{
					A_2.b.a(a2f);
				}
				else
				{
					A_2.b.a(0, a2f);
				}
			}
			if (ec.e != null)
			{
				int num2 = (int)a63.b(ec.i);
				a2f a2f2 = A_1.b(A_0, "Effects\\PsiChainOut", new Point(x, num2), null, true);
				if (a2f2 == null || a2f2.d == null)
				{
					return;
				}
				a2f2.h = new float?(0.75f);
				a2f2.f = 0.95f;
				eyc.a(a2f2, A_2, 0.5);
				if (num2 >= 3 && num2 <= 6)
				{
					A_2.b.a(a2f2);
					return;
				}
				A_2.b.a(0, a2f2);
			}
		}
	}
}
