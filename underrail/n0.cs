using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020010DE RID: 4318
[eiz("EX0")]
[Serializable]
public sealed class n0 : cze
{
	// Token: 0x06005B0B RID: 23307 RVA: 0x00272DE8 File Offset: 0x00270FE8
	private n0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005B0C RID: 23308 RVA: 0x00272DF4 File Offset: 0x00270FF4
	public n0()
	{
	}

	// Token: 0x06005B0D RID: 23309 RVA: 0x00272E00 File Offset: 0x00271000
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.h.b != null && !c5x.h.b.aa().Passive && !c5x.h.b.aa().Dead)
		{
			if (c5x.h.b.aa().Defense.af()[DamageType.Electricity].c() >= 1.0 && c5x.h.b.aa().Feats.Contains<e6h>())
			{
				ah8 ah = Enumerable.FirstOrDefault<ah8>(c5x.h.b.aa().StatusEffects.Get<ah8>());
				if (ah != null && ah.Stacks == ah.MaxStacks)
				{
					ah.TimeLeft = (double)ah.Duration;
					return;
				}
			}
			c5x a_ = c5x;
			string a_2 = "Electricity";
			int maxValue = int.MaxValue;
			double a_3 = (double)dz6.b(300);
			bool a_4 = true;
			bool a_5 = true;
			float? a_6 = dz6.b();
			boj.a(a_, a_2, maxValue, a_3, a_4, a_5, null, null, null, a_6, false);
			c5x.c().a(Guid.NewGuid().ToString(), "Tazer", 1f, c9z.a, false, false);
			cwt cwt = new cwt();
			cwt.b = true;
			cwt.f.Add(euf.a(as3.bu, 1.0));
			cwt.k = as3.bt;
			c5x.h.b.aa().Defense.a(cwt);
		}
	}
}
