using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AAC RID: 2732
[eiz("PEMJ")]
[Serializable]
public sealed class aqc : cze
{
	// Token: 0x06003FE3 RID: 16355 RVA: 0x00183B48 File Offset: 0x00181D48
	private aqc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003FE4 RID: 16356 RVA: 0x00183B54 File Offset: 0x00181D54
	public aqc()
	{
	}

	// Token: 0x06003FE5 RID: 16357 RVA: 0x00183B60 File Offset: 0x00181D60
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			bxc aspect = c5x.GetAspect<bxc>();
			if (aspect != null)
			{
				if (aspect.f(1))
				{
					c5x c5x2 = A_0 as c5x;
					if (c5x2 != null && (c5x2.h.b == null || c5x2.h.b.aa().FactionId != "lakeGame"))
					{
						bfq bfq = new bfq();
						bfq.c("MushroomPick");
						bfq.ym(null, c5x, null);
					}
					coh coh = new d48(ez2.CreateDefinitonProvider<cv9>("consumables\\food\\lakeMushroom"));
					coh.Stacks = 2;
					coh.Lootable = false;
					coh.Stealable = false;
					mk mk = new mk();
					mk.StaticItems.z3(coh, true);
					mk.ym(null, A_0, null);
					if (c5x2 != null && c5x2.IsPlayer)
					{
						cxc.a(eyy.bv);
					}
				}
				if (aspect.i())
				{
					c5x.RemoveAspect<bim>();
					c5x.TileFormationModifiers.s4(1);
					c5x.z();
				}
			}
		}
	}

	// Token: 0x04001BE5 RID: 7141
	private new const int a = 5;
}
