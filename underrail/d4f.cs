using System;
using TimelapseVertigo.Common;

// Token: 0x020006CF RID: 1743
public static class d4f
{
	// Token: 0x06002CE9 RID: 11497 RVA: 0x001007D0 File Offset: 0x000FE9D0
	public static void b(ta A_0)
	{
		if (A_0 != null && A_0.zf())
		{
			coh coh = A_0.x6();
			if (coh != null)
			{
				bi3 service = bpo.GetService<bi3>();
				if (service != null && service.aij() != null)
				{
					service.ain(coh);
				}
			}
		}
	}

	// Token: 0x06002CEA RID: 11498 RVA: 0x0010081C File Offset: 0x000FEA1C
	public static bool b()
	{
		bi3 service = bpo.GetService<bi3>();
		return service != null && service.aij() != null && service.aij().eg() is atd;
	}

	// Token: 0x06002CEB RID: 11499 RVA: 0x00100858 File Offset: 0x000FEA58
	public static string a(ta A_0)
	{
		if (A_0 != null)
		{
			bi3 service = bpo.GetService<bi3>();
			if (service != null && service.aij() != null && service.aij().eg() is atd)
			{
				if (A_0.zf())
				{
					coh coh = A_0.x6();
					if (coh != null && service.aij().eg().cg(coh) && service.aij().eh(coh) != null)
					{
						return service.aij().eh(coh).Value.ToString();
					}
				}
				return TimelapseCursor.Impossible.ToString();
			}
		}
		return null;
	}

	// Token: 0x06002CEC RID: 11500 RVA: 0x00100914 File Offset: 0x000FEB14
	public static bool a()
	{
		bi3 service = bpo.GetService<bi3>();
		if (service != null && service.aij() != null && service.aij().eg() is atd)
		{
			service.aim();
			return true;
		}
		return false;
	}

	// Token: 0x04001995 RID: 6549
	public static bool a;
}
