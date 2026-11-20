using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;

// Token: 0x02000370 RID: 880
public static class ein
{
	// Token: 0x06001889 RID: 6281 RVA: 0x0007D9F4 File Offset: 0x0007BBF4
	public static c5x a(c5x A_0, c5x A_1)
	{
		if (A_0 != null && A_1 != null && A_0.Area == A_1.Area)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				List<c5x> list = ein.a(A_0.Area, true);
				if (A_0.t.b != null)
				{
					HashSet<r0> hashSet = A_0.t.b.b(service);
					for (int i = list.Count - 1; i >= 0; i--)
					{
						c5x c5x = list[i];
						r0 r = new r0(c5x.Area.c(), c5x.Location.a().b());
						if (!hashSet.Contains(r))
						{
							list.RemoveAt(i);
						}
					}
				}
				if (list.Count > 0 && A_1.t.b != null)
				{
					HashSet<r0> hashSet2 = A_1.t.b.b(service);
					for (int j = list.Count - 1; j >= 0; j--)
					{
						c5x c5x2 = list[j];
						r0 r2 = new r0(c5x2.Area.c(), c5x2.Location.a().b());
						if (!hashSet2.Contains(r2))
						{
							list.RemoveAt(j);
						}
					}
				}
				if (list.Count > 0)
				{
					double num = 0.0;
					c5x c5x3 = null;
					foreach (c5x c5x4 in list)
					{
						ak1 ak = Enumerable.FirstOrDefault<ak1>(c5x4.l);
						if (ak != null && !aw1.a(A_0, ak, false, A_0))
						{
							double num2 = aw1.b(A_0, c5x4);
							if (c5x3 == null || num2 < num)
							{
								c5x3 = c5x4;
								num = num2;
							}
						}
					}
					return c5x3;
				}
			}
		}
		return null;
	}

	// Token: 0x0600188A RID: 6282 RVA: 0x0007DBE4 File Offset: 0x0007BDE4
	public static bool a(c5x A_0)
	{
		List<c5x> list = ein.a(A_0.Area, true);
		if (list.Count > 0)
		{
			Point a = A_0.aj().a();
			foreach (c5x c5x in list)
			{
				if (a == c5x.Location.a())
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x0600188B RID: 6283 RVA: 0x0007DC78 File Offset: 0x0007BE78
	public static List<c5x> a(aud A_0, bool A_1)
	{
		List<b0b> list = A_0.Zone.GetAddon<d60>().ab4(new string[]
		{
			"rechargeBay"
		});
		List<c5x> list2 = new List<c5x>();
		foreach (b0b b0b in list)
		{
			c5x c5x = (c5x)b0b;
			if (c5x.Area == A_0)
			{
				dt5 aspect = c5x.GetAspect<dt5>();
				if (aspect == null || aspect.e().GetValueOrDefault())
				{
					list2.Add(c5x);
				}
			}
		}
		return list2;
	}
}
