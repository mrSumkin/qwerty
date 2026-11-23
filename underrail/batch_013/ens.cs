using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x020017BE RID: 6078
[eiz("XM2")]
[Serializable]
public sealed class ens : a6k, ISerializable
{
	// Token: 0x060081C6 RID: 33222 RVA: 0x0036A2FC File Offset: 0x003684FC
	private ens(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060081C7 RID: 33223 RVA: 0x0036A308 File Offset: 0x00368508
	public ens()
	{
	}

	// Token: 0x060081C8 RID: 33224 RVA: 0x0036A314 File Offset: 0x00368514
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("morphineShot");
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
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
