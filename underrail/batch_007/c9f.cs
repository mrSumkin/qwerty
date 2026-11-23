using System;
using Microsoft.Xna.Framework;

// Token: 0x02000749 RID: 1865
public sealed class c9f : km
{
	// Token: 0x06002FC9 RID: 12233 RVA: 0x00121B24 File Offset: 0x0011FD24
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		a2f a2f = A_1.b(A_0, "Objects\\Traps\\Xpbl_LeperPoisonBearTrap", new Point(1, 0), null, true);
		if (a2f != null && a2f.d != null)
		{
			for (int i = 0; i < A_2.b.a.Count; i++)
			{
				if (A_2.b.a[i].a == "b")
				{
					A_2.b.a(i + 1, a2f);
					return;
				}
			}
		}
	}
}
