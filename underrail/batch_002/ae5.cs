using System;
using Microsoft.Xna.Framework;

// Token: 0x0200072F RID: 1839
public sealed class ae5 : km
{
	// Token: 0x06002F91 RID: 12177 RVA: 0x0011FF8C File Offset: 0x0011E18C
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		a2f a2f = A_1.b(A_0, "Objects\\Traps\\CaveEarPoisonBearTrap", new Point(1, 0), null, true);
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
