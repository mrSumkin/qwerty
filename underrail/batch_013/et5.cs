using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02001195 RID: 4501
public static class et5
{
	// Token: 0x0600600C RID: 24588 RVA: 0x0029D86C File Offset: 0x0029BA6C
	public static c5x a(b0b A_0, string A_1, List<coh> A_2, bool A_3, bool A_4, bool A_5, c5x A_6 = null)
	{
		if (A_0 == null)
		{
			return null;
		}
		Vector3 vector = A_0.aj();
		return et5.a(A_0.Area.b((int)vector.X, (int)vector.Y), A_1, A_2, A_3, A_4, A_5, A_6);
	}

	// Token: 0x0600600D RID: 24589 RVA: 0x0029D8B0 File Offset: 0x0029BAB0
	public static c5x a(ak1 A_0, string A_1, List<coh> A_2, bool A_3, bool A_4, bool A_5, c5x A_6 = null)
	{
		if (A_0 == null)
		{
			return null;
		}
		if (!A_4 && (A_2 == null || A_2.Count == 0))
		{
			return null;
		}
		d6j serviceOrThrow = bpo.GetServiceOrThrow<d6j>();
		c5x c5x;
		if (A_6 != null)
		{
			c5x = A_6;
		}
		else
		{
			c5x = et5.a(A_0);
			if (c5x == null && !string.IsNullOrEmpty(A_1) && serviceOrThrow.dv() != null)
			{
				c5k c5k = serviceOrThrow.dv().a("locale\\objects\\containers\\remains\\" + A_1);
				if (c5k != null)
				{
					c5x = (c5k.a(null, false) as c5x);
					if (c5x != null)
					{
						c5x.Layer = aju.x;
						c5x.Location = new Vector3((float)A_0.Location.X, (float)A_0.Location.Y, 0f);
						a3f a3f = c5x.GetAspect<a3f>();
						if (a3f == null)
						{
							a3f = new a3f(c5x);
							c5x.SetAspect<a3f>(a3f);
						}
						a3f.a()["IsLootbag"] = true;
						A_0.Area.a(c5x);
						if (A_3)
						{
							ad6 ad = new ad6(c5x);
							ad.b(0.0);
							ad.c(1.0);
							ad.a(dz6.a(0.002));
							c5x.Zone.ActionManager.g9(ad, atp.a);
							dz6.a(ad);
						}
					}
				}
			}
		}
		if (c5x != null)
		{
			if (A_5 || (A_2 != null && A_2.Count > 0))
			{
				c7j c7j = c5x.s.b as c7j;
				if (c7j == null)
				{
					c7j = new c7j(c5x);
					c5x.SetAspect<bim>(c7j);
				}
				c7j.g(true);
				c7j.k = true;
				using (List<coh>.Enumerator enumerator = A_2.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						coh a_ = enumerator.Current;
						c7j.ItemContainer.z3(a_, true);
					}
					return c5x;
				}
			}
			c5x.RemoveAspect<bim>();
		}
		return c5x;
	}

	// Token: 0x0600600E RID: 24590 RVA: 0x0029DAD4 File Offset: 0x0029BCD4
	private static c5x a(ak1 A_0)
	{
		if (A_0 != null)
		{
			foreach (b0b b0b in A_0.Entities)
			{
				c5x c5x = (c5x)b0b;
				if (c5x.s.b is c7j)
				{
					a3f aspect = c5x.GetAspect<a3f>();
					if (aspect != null && aspect.a().GetPrimitivePropertyValue<bool>("IsLootbag", new bool?(false)).Value)
					{
						return c5x;
					}
				}
			}
		}
		return null;
	}
}
