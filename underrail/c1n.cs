using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x020017BF RID: 6079
[eiz("CIG")]
[Serializable]
public sealed class c1n : a6k, ISerializable
{
	// Token: 0x060081C9 RID: 33225 RVA: 0x0036A3F8 File Offset: 0x003685F8
	private c1n(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060081CA RID: 33226 RVA: 0x0036A404 File Offset: 0x00368604
	public c1n()
	{
	}

	// Token: 0x060081CB RID: 33227 RVA: 0x0036A410 File Offset: 0x00368610
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("irongut");
		if (a4x != null)
		{
			if (a4x.gu(base.vg().e(), base.vg().q().h.b, c5x.h.b))
			{
				a20.a(base.vg().q(), null, new CombatSpeakEvent[]
				{
					CombatSpeakEvent.Consume_Booster
				});
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
