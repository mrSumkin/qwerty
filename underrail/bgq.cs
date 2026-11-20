using System;
using Ouroboros.Core.Logging;

// Token: 0x02001004 RID: 4100
public static class bgq
{
	// Token: 0x06005450 RID: 21584 RVA: 0x0025478C File Offset: 0x0025298C
	public static b0b a(a6b A_0)
	{
		if (A_0 == null || A_0.a() == null || A_0.a().Count == 0)
		{
			return null;
		}
		double num = 0.0;
		double num2 = zp.a.NextDouble();
		foreach (wa wa in A_0.a())
		{
			if (num2 < num + wa.b())
			{
				if (!string.IsNullOrEmpty(wa.a()))
				{
					c5k c5k = bpo.GetServiceOrThrow<d6j>().dv().a(wa.a());
					if (c5k != null)
					{
						return c5k.a(null, false);
					}
					dux.b(LogSeverity.Error, "Failed to generate character. Could not retrieve blueprint '{0}'.", new object[]
					{
						wa.a()
					});
				}
				else
				{
					dux.b(LogSeverity.Error, "Failed to generate character. Blueprint not set.", new object[0]);
				}
			}
			if (num >= 1.0)
			{
				break;
			}
			num += wa.b();
		}
		return null;
	}
}
