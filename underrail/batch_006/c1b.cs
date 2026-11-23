using System;
using System.Collections.Generic;
using System.Diagnostics;
using Ouroboros.Playfield.Space;

// Token: 0x02002211 RID: 8721
[bmq("1.0.0.10_Dc_La2CrawlSpace", "1.0.0.10", "dc-la2", false)]
public sealed class c1b : fg
{
	// Token: 0x0600CA7B RID: 51835 RVA: 0x0047B9E4 File Offset: 0x00479BE4
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("b67f8788-a7a9-4823-963e-f74f89801466"), A_1.n("dc-la2")).ao() as c5x;
			if (c5x != null && c5x.GetAspect<bim>() == null)
			{
				bim bim = new bim(c5x);
				List<cze> list = bim.s();
				a72 a = new a72();
				a.b("interfacing\\dc-la2_crawlspace");
				a.c("Vent");
				list.Add(a);
				bim.a(new List<HorizontalDirection>
				{
					HorizontalDirection.East,
					HorizontalDirection.West
				});
				c5x.SetAspect<bim>(bim);
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
