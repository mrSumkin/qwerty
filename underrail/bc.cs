using System;
using Microsoft.Xna.Framework;

// Token: 0x02001FC7 RID: 8135
public static class bc
{
	// Token: 0x0600BF1F RID: 48927 RVA: 0x00421E88 File Offset: 0x00420088
	public static void a(euz A_0, euz A_1, coh A_2, Point A_3, bool A_4 = false, bool A_5 = false)
	{
		if (A_2 != null)
		{
			bcm serviceOrThrow = bpo.GetServiceOrThrow<bcm>();
			if (serviceOrThrow.aau() != null)
			{
				bys bys = new bys(A_3, new Rectangle(0, 0, serviceOrThrow.aau().Size.c, serviceOrThrow.aau().Size.d), A_0, A_1, A_2, A_4, A_5);
				bc.a(bys, serviceOrThrow.aau());
				serviceOrThrow.aau().aox(bys);
				bys.c();
			}
		}
	}

	// Token: 0x0600BF20 RID: 48928 RVA: 0x00421F00 File Offset: 0x00420100
	public static void a(euz A_0, euz A_1, bim A_2, Point A_3)
	{
		if (A_2 != null)
		{
			bcm serviceOrThrow = bpo.GetServiceOrThrow<bcm>();
			if (serviceOrThrow.aau() != null)
			{
				exj exj = new exj(A_3, new Rectangle(0, 0, serviceOrThrow.aau().Size.c, serviceOrThrow.aau().Size.d), A_0, A_1, A_2);
				bc.a(exj, serviceOrThrow.aau());
				serviceOrThrow.aau().aox(exj);
				exj.c();
			}
		}
	}

	// Token: 0x0600BF21 RID: 48929 RVA: 0x00421F74 File Offset: 0x00420174
	private static void a(ao4 A_0, euz A_1)
	{
	}
}
