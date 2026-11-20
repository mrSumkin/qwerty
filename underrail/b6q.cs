using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x0200103F RID: 4159
public static class b6q
{
	// Token: 0x0600560D RID: 22029 RVA: 0x0025DBA8 File Offset: 0x0025BDA8
	public static List<ar7> a(aud A_0, string A_1, List<Guid> A_2)
	{
		List<ar7> list = new List<ar7>();
		c1a c1a = null;
		if (A_0 != null)
		{
			c1a = A_0.Zone;
		}
		else
		{
			d6j service = bpo.GetService<d6j>();
			if (service != null)
			{
				e3h e3h = service.dx(bl1.a);
				if (e3h != null)
				{
					c1a = Enumerable.FirstOrDefault<c1a>(e3h.Zones);
				}
			}
		}
		if (c1a != null)
		{
			if (!string.IsNullOrEmpty(A_1))
			{
				d60 d = c1a.a();
				if (d != null)
				{
					List<b0b> list2 = d.ab4(new string[]
					{
						A_1
					});
					if (list2 != null)
					{
						foreach (b0b a_ in list2)
						{
							list.Add(new ar7(a_));
						}
					}
				}
			}
			if (A_0 != null && A_2 != null && A_2.Count > 0)
			{
				using (List<Guid>.Enumerator enumerator2 = A_2.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						b6q.a a = new b6q.a();
						a.a = enumerator2.Current;
						if (!Enumerable.Any<ar7>(list, new Func<ar7, bool>(a.a)))
						{
							ar7 item = new ar7(a.a, A_0);
							list.Add(item);
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x0600560E RID: 22030 RVA: 0x0025DD18 File Offset: 0x0025BF18
	public static aud a(b0b A_0, b0b A_1, Dictionary<string, object> A_2, string A_3)
	{
		aud aud = null;
		if (A_2 != null && A_2.ContainsKey(dmh.e))
		{
			e6z e6z = A_2[dmh.e] as e6z;
			if (e6z != null)
			{
				aud = e6z.ao();
			}
		}
		if (aud == null && !string.IsNullOrWhiteSpace(A_3))
		{
			c1a c1a = null;
			if (A_0 != null && A_0.Zone != null)
			{
				c1a = A_0.Zone;
			}
			else if (A_1 != null && A_1.Zone != null)
			{
				c1a = A_1.Zone;
			}
			else if (A_2.ContainsKey(dmh.d))
			{
				a55 a = A_2[dmh.d] as a55;
				if (a != null)
				{
					c1a = a.ao();
				}
			}
			if (c1a != null)
			{
				aud = c1a.n(A_3);
			}
		}
		return aud;
	}

	// Token: 0x02001040 RID: 4160
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06005610 RID: 22032 RVA: 0x0025DDF4 File Offset: 0x0025BFF4
		internal bool a(ar7 A_0)
		{
			return A_0.afl() == this.a;
		}

		// Token: 0x040022F5 RID: 8949
		public Guid a;
	}
}
