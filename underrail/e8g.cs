using System;
using Microsoft.Xna.Framework;

// Token: 0x02000743 RID: 1859
public sealed class e8g : km
{
	// Token: 0x06002FBD RID: 12221 RVA: 0x001214C0 File Offset: 0x0011F6C0
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		int x = A_0.d() % 8;
		a2f a2f = A_1.b(A_0, "Effects\\AiScramble_Loop", new Point(x, 0), null, true);
		if (a2f != null && a2f.d != null)
		{
			a2f a2f2 = a2f;
			a2f2.j.Y = a2f2.j.Y - 35f;
			A_2.b.a(a2f);
			eyc.a(a2f, A_2, 1.0);
		}
	}
}
