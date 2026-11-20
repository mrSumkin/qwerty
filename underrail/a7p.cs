using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A67 RID: 2663
[eiz("TMTDJ")]
[Serializable]
public sealed class a7p : cze, ISerializable
{
	// Token: 0x06003EE4 RID: 16100 RVA: 0x0017C274 File Offset: 0x0017A474
	private a7p(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003EE5 RID: 16101 RVA: 0x0017C280 File Offset: 0x0017A480
	public a7p()
	{
	}

	// Token: 0x06003EE6 RID: 16102 RVA: 0x0017C288 File Offset: 0x0017A488
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_1 != null)
		{
			bool flag = A_1.a() != null;
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_TchortDefeated", new bool?(false)).Value;
			if (flag && !value && serviceOrThrow.aqu().v() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.h.b != null)
				{
					bpo.GetServiceOrThrow<ps>().ane(1000, null, null, null, null, null);
					c5x.c().a("MutagenTankBreaks");
				}
			}
			foreach (ak1 ak in A_1.l)
			{
				foreach (b0b b0b in ak.c.Values)
				{
					c5x c5x2 = (c5x)b0b;
					if (c5x2.y8() == "MutagenTankDamage" && c5x2.o.b != null && c5x2.i.b != null)
					{
						c5x2.o.b.d = null;
						ny b = c5x2.i.b;
						dqm dqm = new dqm(c5x2.o.b);
						dqm.c(8);
						dqm.a(100.0);
						b.b(dqm, atp.a);
						return;
					}
				}
			}
		}
	}
}
