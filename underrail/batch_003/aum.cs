using System;
using Microsoft.Xna.Framework;

// Token: 0x02000747 RID: 1863
public sealed class aum : km
{
	// Token: 0x06002FC5 RID: 12229 RVA: 0x001219FC File Offset: 0x0011FBFC
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		a2f a2f = A_1.b(A_0, "Objects\\Natural\\RustingAcidBlob", Point.Zero, null, true);
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
