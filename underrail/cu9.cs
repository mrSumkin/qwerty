using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000BA4 RID: 2980
[euj]
public class cu9
{
	// Token: 0x060043B4 RID: 17332 RVA: 0x001A9B5C File Offset: 0x001A7D5C
	[ayh("CCRJBWMA")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			b0b b0b = serviceOrThrow.aqu().v().b();
			b0b b0b2 = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
			{
				"mock"
			}));
			if (b0b != null && b0b2 != null)
			{
				bpo.GetServiceOrThrow<ps>().amw(b0b, b0b2);
			}
		}
	}

	// Token: 0x060043B5 RID: 17333 RVA: 0x001A9BC4 File Offset: 0x001A7DC4
	[ayh("CCRJUTD")]
	public void d(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
			{
				"trapDoor"
			})) as c5x;
			if (c5x != null)
			{
				c2r c2r = c5x.GetAspect<bim>() as c2r;
				if (c2r != null)
				{
					c2r.a(null, null, true, false);
				}
			}
		}
	}

	// Token: 0x060043B6 RID: 17334 RVA: 0x001A9C2C File Offset: 0x001A7E2C
	[ayh("CCRJCHBI")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
			{
				"locker"
			})) as c5x;
			if (c5x != null)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				object obj;
				if (c7j != null && A_2 != null && A_2.TryGetValue("tempcontext", out obj))
				{
					bq8 bq = obj as bq8;
					if (bq != null)
					{
						if (c7j.ItemContainer.z2().a("gasMask", 1).Count > 0 && c7j.ItemContainer.z2().a("wep.xm25", 1).Count > 0)
						{
							bq.set_Item("items", "both");
							return;
						}
						if (c7j.ItemContainer.z2().a("gasMask", 1).Count > 0)
						{
							bq.set_Item("items", "mask");
							return;
						}
						bq.set_Item("items", "none");
					}
				}
			}
		}
	}

	// Token: 0x060043B7 RID: 17335 RVA: 0x001A9D48 File Offset: 0x001A7F48
	[ayh("CCRJTITR")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
			{
				"locker"
			})) as c5x;
			c5x c5x2 = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
			{
				"ragEntity"
			})) as c5x;
			if (c5x != null && c5x2 != null)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					d5o d5o = Enumerable.FirstOrDefault<d5o>(c7j.ItemContainer.z2().a("wep.xm25", 1));
					if (d5o != null)
					{
						c5x2.h.b.aa().Bag.z3(d5o.Item, true);
						c7j.ItemContainer.z2().Remove(d5o.Item);
					}
				}
			}
		}
	}
}
