using System;
using Microsoft.Xna.Framework;
using Ouroboros.Core.Logging;

// Token: 0x02000523 RID: 1315
public static class a7v
{
	// Token: 0x060021D8 RID: 8664 RVA: 0x000B44E0 File Offset: 0x000B26E0
	public static void a(dli A_0)
	{
		if (A_0 == null)
		{
			dux.b(LogSeverity.Error, "Attempted to publish null event.", new object[0]);
			return;
		}
		eta service = bpo.GetService<eta>();
		if (service != null)
		{
			service.ao6(A_0);
			return;
		}
		dux.b(LogSeverity.Warning, "Attempted to publish event '{0}', but IGlobalEventAggregator service was not found", new object[]
		{
			A_0.ToString()
		});
	}

	// Token: 0x060021D9 RID: 8665 RVA: 0x000B4534 File Offset: 0x000B2734
	public static void a(Color? A_0, string A_1, ecs A_2)
	{
		ecs ecs = new ecs();
		foreach (dl6 dl in A_2.a)
		{
			dl6 dl2 = new dl6();
			foreach (bph bph in dl.a)
			{
				bph item = new bph(new d22(b94.a(), bph.a.b), bph.b, null);
				dl2.a.Add(item);
			}
			ecs.a.Add(dl2);
		}
		bph item2 = new bph(new d22(b94.a(), A_0 ?? cm3.c), "- " + A_1 + ": ", null);
		ecs.a[0].a.Insert(0, item2);
		a7v.a(new dx(ecs));
	}
}
