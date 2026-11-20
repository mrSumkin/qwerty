using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B3A RID: 2874
[eiz("S41")]
[Serializable]
public sealed class bb7 : cze, ISerializable
{
	// Token: 0x06004224 RID: 16932 RVA: 0x0019A294 File Offset: 0x00198494
	private bb7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004225 RID: 16933 RVA: 0x0019A2A0 File Offset: 0x001984A0
	public bb7()
	{
	}

	// Token: 0x06004226 RID: 16934 RVA: 0x0019A2AC File Offset: 0x001984AC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && !serviceOrThrow.aqu().v().Dead && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_si_pillarsDormant", new bool?(false)).Value)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.j == cgy.b && c5x.h.b != null && c5x.h.b.aa().Vehicle == null && c5x.l() < 0.53)
			{
				cfb cfb = Enumerable.FirstOrDefault<cfb>(serviceOrThrow.aqu().v().StatusEffects.Get<cfb>());
				if (cfb != null && cfb.Stacks == cfb.MaxStacks)
				{
					List<ak1> list = aw1.b(c5x, true);
					if (list.Count > 0)
					{
						ak1 ak = list[cuo.a.Next(list.Count)];
						new d8g(null, c5x, new bt4(c5x.Area.y8(), ak.Location.a()), null, true, null, null, null, null).ym(null, null, null);
						serviceOrThrow.aqu().v().StatusEffects.d(cfb);
						return;
					}
				}
				cfb a_ = new cfb();
				serviceOrThrow.aqu().v().StatusEffects.a(a_, false, false, false);
			}
		}
	}
}
