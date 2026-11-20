using System;
using Microsoft.Xna.Framework;

// Token: 0x0200074A RID: 1866
public sealed class ef7 : km
{
	// Token: 0x06002FCB RID: 12235 RVA: 0x00121BB8 File Offset: 0x0011FDB8
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		a2f a2f = A_1.b(A_0, "Objects\\Traps\\HopperTrap", new Point(1, 0), null, true);
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
