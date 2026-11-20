using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B69 RID: 2921
[eiz("WWFS")]
[Serializable]
public sealed class c1x : cze, ISerializable
{
	// Token: 0x060042E9 RID: 17129 RVA: 0x001A2190 File Offset: 0x001A0390
	private c1x(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060042EA RID: 17130 RVA: 0x001A219C File Offset: 0x001A039C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060042EB RID: 17131 RVA: 0x001A21A8 File Offset: 0x001A03A8
	public c1x()
	{
	}

	// Token: 0x060042EC RID: 17132 RVA: 0x001A21B0 File Offset: 0x001A03B0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			foreach (aud aud in Enumerable.ToList<aud>(serviceOrThrow.aqw().Areas))
			{
				foreach (ya ya in Enumerable.ToList<ya>(aud.Triggers))
				{
					if (ya.Name.Contains("GuardedTerritory"))
					{
						ya.o();
					}
				}
			}
			bv9 bv = serviceOrThrow.aqu().ac() as bv9;
			bv.abu(asp.er, asp.a);
			bv.a(asp.g0, asp.a, h.c, null, true, false, false);
			d60 d = serviceOrThrow.aqw().a();
			if (d != null)
			{
				foreach (b0b b0b in d.ab4(new string[]
				{
					"slaves"
				}))
				{
					c5x c5x = (c5x)b0b;
					if (c5x.h.b != null)
					{
						c5x.h.b.aa().c(asp.a);
						c5x.h.b.aa().BaseSightRange = 10f;
					}
					if (c5x.t.b != null)
					{
						if (c5x.t.b.y6()[ddq.k] != null)
						{
							c5x.t.b.y6().RemoveProperty(ddq.k);
							c5x.t.b.y6()[ddq.bm] = true;
						}
						if (c5x.t.b.y6()[ddq.w] != null)
						{
							c5x.t.b.y6().RemoveProperty(ddq.w);
						}
					}
					if (c5x.a("dun_wasteWater_up") || c5x.a("dun_wasteWater_down"))
					{
						e3l aspect = c5x.GetAspect<e3l>();
						aspect.a.Remove("dun_wasteWater_up");
						aspect.a.Remove("dun_wasteWater_down");
					}
				}
			}
		}
	}
}
