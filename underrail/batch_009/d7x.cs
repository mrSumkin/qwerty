using System;
using System.Collections.Generic;
using Ouroboros.Playfield.Space;

// Token: 0x0200061A RID: 1562
public static class d7x
{
	// Token: 0x06002859 RID: 10329 RVA: 0x000E84C0 File Offset: 0x000E66C0
	public static ds3 a(c5x A_0, object A_1, float A_2, List<HorizontalDirection> A_3 = null, List<byte> A_4 = null, int A_5 = 0)
	{
		ale b = A_0.k.b;
		if (b == null)
		{
			return null;
		}
		if (A_2 == as3.bk)
		{
			fk fk = new fk(b, A_1, A_3, false, A_5);
			fk.l();
			return new k0(fk.g());
		}
		e1i e1i = new e1i(b, A_1, A_2);
		e1i.l();
		if (A_4 != null)
		{
			e1i.e().AddRange(A_4);
		}
		return new gr(e1i);
	}
}
