using System;
using Microsoft.Xna.Framework;

// Token: 0x02000762 RID: 1890
public sealed class dle : km
{
	// Token: 0x06002FFE RID: 12286 RVA: 0x00123438 File Offset: 0x00121638
	public dle(bool A_0 = false)
	{
		this.a = A_0;
	}

	// Token: 0x06002FFF RID: 12287 RVA: 0x0012344C File Offset: 0x0012164C
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		a2f a2f;
		if (this.a)
		{
			a2f = A_1.b(A_0, "Objects\\Items\\ThrowingNetBarbed", Point.Zero, null, true);
		}
		else
		{
			a2f = A_1.b(A_0, "Objects\\Items\\ThrowingNet", Point.Zero, null, true);
		}
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

	// Token: 0x04001A43 RID: 6723
	private bool a;
}
