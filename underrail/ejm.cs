using System;
using Microsoft.Xna.Framework;

// Token: 0x0200072B RID: 1835
public sealed class ejm : km
{
	// Token: 0x06002F89 RID: 12169 RVA: 0x0011FB98 File Offset: 0x0011DD98
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		int x = A_0.d() % 4;
		a2f a2f = A_1.b(A_0, "Effects\\GreatFire", new Point(x, 0), null, true);
		if (a2f != null && a2f.d != null)
		{
			for (int i = A_2.b.a.Count - 1; i >= 0; i--)
			{
				a2f a2f2 = A_2.b.a[i];
				if (a2f2.a == "SHD")
				{
					A_2.b.a.RemoveAt(i);
				}
				else if (a2f2.a == "b")
				{
					a2f2.e = new Color?(Color.Black);
					a2f2.h = new float?(1f);
				}
			}
			a2f.s = true;
			a2f.h = new float?(1f);
			A_2.b.a(0, a2f);
		}
	}
}
