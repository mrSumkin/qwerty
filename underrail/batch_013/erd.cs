using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000BB8 RID: 3000
[euj]
public sealed class erd
{
	// Token: 0x0600447D RID: 17533 RVA: 0x001B6508 File Offset: 0x001B4708
	[ayh("SporeFarm_GrowTick")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.o.b != null)
		{
			int x = d05.a(0, A_1.o.b.b.X + 1, 8);
			A_1.o.b.b = new Point(x, A_1.o.b.b.Y);
		}
	}

	// Token: 0x0600447E RID: 17534 RVA: 0x001B6578 File Offset: 0x001B4778
	[ayh("SporeFarm_Used")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.o.b != null && A_0 != null && A_0.h.b != null)
		{
			int num = Math.Max(0, A_1.o.b.b.X - 3);
			if (num > 0)
			{
				num = cuo.a.Next(Math.Min(1, num / 2), num + 1);
				A_1.o.b.b = new Point(2, A_1.o.b.b.Y);
				LibraryItemDefinitionProvider<a1k> a_ = new LibraryItemDefinitionProvider<a1k>("components\\plants\\PsychodelicSpore");
				mk mk = new mk();
				mk.StaticItems.z3(new fv(a_)
				{
					Stacks = num
				}, true);
				mk.PublishEventsForPlayer = true;
				mk.ym(null, A_0, null);
				d0c aspect = A_1.GetAspect<d0c>();
				if (aspect != null)
				{
					aspect.a(new int?(2));
					return;
				}
			}
			else
			{
				bmj.a(A_1, new ccq(ScrollingCombatTextOptions.Mandatory, "Empty", adi.m, null, false));
			}
		}
	}

	// Token: 0x0600447F RID: 17535 RVA: 0x001B6684 File Offset: 0x001B4884
	[ayh("Dc_SporeSac_GrowTick")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			c7j c7j = A_1.s.b as c7j;
			if (c7j != null)
			{
				LibraryItemDefinitionProvider<a1k> libraryItemDefinitionProvider = new LibraryItemDefinitionProvider<a1k>("components\\plants\\PsychodelicSpore");
				foreach (coh coh in c7j.ItemContainer.z2())
				{
					if (coh.Definition.a5() == libraryItemDefinitionProvider.wl().a5() && coh.Stacks >= 9)
					{
						return;
					}
				}
				c7j.ItemContainer.z3(new fv(libraryItemDefinitionProvider), true);
			}
		}
	}
}
