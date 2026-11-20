using System;
using TimelapseVertigo.Rules.Items;

// Token: 0x020020C6 RID: 8390
[bmq("1.1.5.0_Dc_ForestSporeContainers", "1.1.5.0", "dc-f1,dc-f2,dc-f3,dc-f4,dc-f5,dc-f6,dc-f7,dc-fs1,dc-fs2,dc-fs3,dc-fs4,dc-fs5", true)]
public sealed class cn1 : fg
{
	// Token: 0x0600C7F7 RID: 51191 RVA: 0x00467864 File Offset: 0x00465A64
	public bool b5(cyt A_0, c1a A_1)
	{
		LibraryItemDefinitionProvider<a1k> a_ = new LibraryItemDefinitionProvider<a1k>("components\\plants\\PsychodelicSpore");
		foreach (aud aud in A_1.Areas)
		{
			foreach (b0b b0b in aud.Entities)
			{
				c5x c5x = (c5x)b0b;
				if (c5x.Layer == aju.x && c5x.GetAspect<dri>() != null)
				{
					c5x.q("Spore Sac");
					int num = 9;
					int num2 = cuo.a.Next(num + 1);
					dm dm = new dm(c5x);
					c5x.SetAspect<dm>(dm);
					dm.d().Add(cze.a("Dc_SporeSac_GrowTick"));
					dm.c(true);
					dm.a(new int?(300000));
					c7j c7j = new c7j(c5x);
					c7j.c("SporePick");
					c5x.SetAspect<bim>(c7j);
					c7j.ItemContainer.z3(new fv(a_)
					{
						Stacks = num - num2
					}, true);
				}
			}
		}
		return true;
	}
}
