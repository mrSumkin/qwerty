using System;

// Token: 0x02000577 RID: 1399
internal static class cdb
{
	// Token: 0x0600242E RID: 9262 RVA: 0x000CA790 File Offset: 0x000C8990
	public static void a(cnk A_0)
	{
		cdb.a = null;
		cdb.b = null;
		if (A_0.aqu() != null && A_0.aqu().c() != null && A_0.aqw() != null)
		{
			cdb.a = A_0.aqw().CustomProperties.GetClassPropertyValue<string>("OpenerSong");
			cdb.b = A_0.aqw().CustomProperties.GetClassPropertyValue<string>("FollowUpSong");
			cdb.c = A_0.aqw().CustomProperties.GetPrimitivePropertyValue<double>("FollowUpSongDelay", new double?(0.0)).Value;
			am7 service = bpo.GetService<am7>();
			if (cdb.b != cdb.d)
			{
				cdb.d = null;
			}
			if (!string.IsNullOrEmpty(cdb.b) && service != null && service.ai2() != null)
			{
				if (service.ai2().a() == cdb.a)
				{
					if (cdb.d == null)
					{
						cdb.d = cdb.b;
						cdb.e = DateTime.Now + TimeSpan.FromMilliseconds(cdb.c);
					}
				}
				else
				{
					cdb.d = null;
				}
			}
			if (!string.IsNullOrEmpty(cdb.d) && DateTime.Now >= cdb.e)
			{
				new dvn(A_0.aqu().c().b(), cdb.d).ym(null, null, null);
				cdb.b = null;
				cdb.d = null;
			}
		}
	}

	// Token: 0x040014FF RID: 5375
	private static string a;

	// Token: 0x04001500 RID: 5376
	private static string b;

	// Token: 0x04001501 RID: 5377
	private static double c;

	// Token: 0x04001502 RID: 5378
	private static string d;

	// Token: 0x04001503 RID: 5379
	private static DateTime e;
}
