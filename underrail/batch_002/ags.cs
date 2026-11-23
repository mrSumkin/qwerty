using System;
using System.Collections.Generic;
using System.Linq;
using TimelapseVertigo.Playfield.CustomLogic.Data;

// Token: 0x020008C1 RID: 2241
public sealed class ags : deq
{
	// Token: 0x060037DD RID: 14301 RVA: 0x0014CE80 File Offset: 0x0014B080
	public ags() : base(1)
	{
	}

	// Token: 0x060037DE RID: 14302 RVA: 0x0014CE8C File Offset: 0x0014B08C
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		d60 addon = A_1.GetAddon<d60>();
		if (addon != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(addon.ab6(new string[]
			{
				"burglar",
				base.c()
			})) as c5x;
			if (c5x != null)
			{
				if (c5x.h.b != null)
				{
					new gx().a(c5x.h.b.am(), null, null);
					c5x = base.a(c5x, A_1);
				}
				Dictionary<PlayerHouseElement, string> dictionary = d39.a(A_0, null);
				string text;
				if (c5x.t.b != null && dictionary.TryGetValue(PlayerHouseElement.UpperFloorDebris, out text) && text != null && text == "cleared")
				{
					List<string> classPropertyValue = c5x.t.b.y6().GetClassPropertyValue<List<string>>(ddq.k);
					if (classPropertyValue != null && Enumerable.Any<string>(classPropertyValue))
					{
						classPropertyValue.Add("bur_u1");
						classPropertyValue.Add("bur_u2");
						classPropertyValue.Add("bur_u3");
						c5x.t.b.y6()[ddq.k] = classPropertyValue;
					}
				}
				d9m d9m = new d9m();
				d9m.a(1000);
				List<cze> list = d9m.c();
				bfq bfq = new bfq("BurglarRummaging");
				bfq.a(bvl.d);
				list.Add(bfq);
				d9m.ym(null, null, null);
				d9m d9m2 = new d9m();
				d9m2.a(2200);
				List<cze> list2 = d9m2.c();
				egx egx = new egx();
				egx.b(true);
				egx.a("Что это?");
				list2.Add(egx);
				d9m2.ym(A_0.v().b(), null, null);
			}
		}
	}
}
