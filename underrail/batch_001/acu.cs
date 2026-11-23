using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x0200021E RID: 542
public static class acu
{
	// Token: 0x06000F1B RID: 3867 RVA: 0x0003F390 File Offset: 0x0003D590
	public static void a(doq A_0)
	{
		ewf service = bpo.GetService<ewf>();
		if (service != null)
		{
			foreach (cpe cpe in A_0.e())
			{
				for (int i = cpe.Entities.Count - 1; i >= 0; i--)
				{
					if (!service.ys(cpe.Entities[i]))
					{
						cpe.Entities[i].w();
						cpe.Entities.RemoveAt(i);
					}
				}
				for (int j = cpe.Triggers.Count - 1; j >= 0; j--)
				{
					if (!service.yt(cpe.Triggers[j], cpe))
					{
						cpe.Triggers.RemoveAt(j);
					}
				}
			}
		}
	}

	// Token: 0x06000F1C RID: 3868 RVA: 0x0003F488 File Offset: 0x0003D688
	public static void a(c1a A_0)
	{
		ewf service = bpo.GetService<ewf>();
		if (service != null)
		{
			foreach (aud aud in A_0.Areas)
			{
				for (int i = aud.Entities.Count - 1; i >= 0; i--)
				{
					if (!service.ys(aud.Entities[i]))
					{
						aud.Entities[i].w();
						aud.Entities[i].an();
					}
				}
				for (int j = aud.Triggers.Count - 1; j >= 0; j--)
				{
					if (!service.yu(aud.Triggers[j], aud))
					{
						aud.Triggers[j].o();
					}
				}
			}
		}
	}

	// Token: 0x06000F1D RID: 3869 RVA: 0x0003F58C File Offset: 0x0003D78C
	public static void a(c1a A_0, doq A_1)
	{
		if (A_0 != null && A_1 != null)
		{
			using (List<cpe>.Enumerator enumerator = A_1.e().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					acu.a a = new acu.a();
					a.a = enumerator.Current;
					aud aud = A_0.d(a.a.AreaId);
					if (aud != null)
					{
						for (int i = a.a.Entities.Count - 1; i >= 0; i--)
						{
							if (aud.a(a.a.Entities[i].qe()) != null)
							{
								a.a.Entities[i].w();
								a.a.Entities.RemoveAt(i);
							}
						}
						a.b = a.a.Triggers.Count - 1;
						while (a.b >= 0)
						{
							IEnumerable<ya> enumerable = aud.Triggers;
							Func<ya, bool> func;
							if ((func = a.c) == null)
							{
								func = (a.c = new Func<ya, bool>(a.a));
							}
							if (Enumerable.Any<ya>(Enumerable.Where<ya>(enumerable, func)))
							{
								a.a.Triggers.RemoveAt(a.b);
							}
							int b = a.b;
							a.b = b - 1;
						}
					}
				}
			}
			for (int j = A_1.d().Count - 1; j >= 0; j--)
			{
				if (A_0.g(A_1.d()[j].Name) != null)
				{
					A_1.d().RemoveAt(j);
				}
			}
		}
	}

	// Token: 0x0200021F RID: 543
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06000F1F RID: 3871 RVA: 0x0003F764 File Offset: 0x0003D964
		internal bool a(ya A_0)
		{
			return A_0.Id == this.a.Triggers[this.b].Id;
		}

		// Token: 0x0400090D RID: 2317
		public cpe a;

		// Token: 0x0400090E RID: 2318
		public int b;

		// Token: 0x0400090F RID: 2319
		public Func<ya, bool> c;
	}
}
