using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001778 RID: 6008
[eiz("XM3")]
[Serializable]
public sealed class b7g : a6k, ISerializable
{
	// Token: 0x06008109 RID: 33033 RVA: 0x00366F90 File Offset: 0x00365190
	private b7g(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600810A RID: 33034 RVA: 0x00366F9C File Offset: 0x0036519C
	public b7g()
	{
	}

	// Token: 0x0600810B RID: 33035 RVA: 0x00366FA4 File Offset: 0x003651A4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("nervosomnifer");
		if (a4x != null)
		{
			if (a4x.gu(base.vg().e(), base.vg().q().h.b, c5x.h.b))
			{
				if (base.vg().q().IsPlayer)
				{
					cxc.a(eyy.bu);
				}
				a20.a(base.vg().q(), null, new CombatSpeakEvent[]
				{
					CombatSpeakEvent.Consume_Painkiller
				});
				c7w.a(base.vg().q().h.b.aa(), cuo.a.Next(1, 4));
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
