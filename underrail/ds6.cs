using System;
using System.Collections.Generic;

// Token: 0x02001FC3 RID: 8131
public static class ds6
{
	// Token: 0x0600BF06 RID: 48902 RVA: 0x00421748 File Offset: 0x0041F948
	internal static void a(b5j A_0)
	{
		ds6.a.Add(A_0);
	}

	// Token: 0x0600BF07 RID: 48903 RVA: 0x00421758 File Offset: 0x0041F958
	public static void a()
	{
		ds6.a.Clear();
	}

	// Token: 0x0600BF08 RID: 48904 RVA: 0x00421768 File Offset: 0x0041F968
	public static void a(cp9 A_0, e6d A_1)
	{
		cne service = bpo.GetService<cne>();
		if (service != null)
		{
			foreach (b5j b5j in ds6.a)
			{
				b5j.a(service, A_0, A_1);
			}
		}
	}

	// Token: 0x040044A7 RID: 17575
	private static List<b5j> a = new List<b5j>();
}
