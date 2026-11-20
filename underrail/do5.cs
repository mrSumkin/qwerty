using System;
using Microsoft.Xna.Framework;

// Token: 0x0200072A RID: 1834
public sealed class do5 : km
{
	// Token: 0x06002F87 RID: 12167 RVA: 0x0011FB04 File Offset: 0x0011DD04
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		a2f a2f = A_1.b(A_0, "Objects\\Natural\\AcidBlob", Point.Zero, null, true);
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
