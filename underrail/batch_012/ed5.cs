using System;
using Microsoft.Xna.Framework;

// Token: 0x02000751 RID: 1873
public sealed class ed5 : km
{
	// Token: 0x06002FDA RID: 12250 RVA: 0x00122380 File Offset: 0x00120580
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		a2f a2f = A_1.b(A_0, "Objects\\Natural\\CorrosiveAcidBlob", Point.Zero, null, true);
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
