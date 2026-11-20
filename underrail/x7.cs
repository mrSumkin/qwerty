using System;
using Microsoft.Xna.Framework;

// Token: 0x02000759 RID: 1881
public sealed class x7 : km
{
	// Token: 0x06002FEB RID: 12267 RVA: 0x00122C2C File Offset: 0x00120E2C
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		ata ata = A_3 as ata;
		a2f a2f;
		if (dk2.f() && ata != null && ata.FineWeb)
		{
			a2f = A_1.b(A_0, "Effects\\xpbl_SpitSpiderWebEntangle", Point.Zero, null, true);
		}
		else
		{
			a2f = A_1.b(A_0, "Objects\\Natural\\SpiderWebRoot", Point.Zero, null, true);
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
}
