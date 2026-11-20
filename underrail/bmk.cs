using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001798 RID: 6040
[eiz("XC2")]
[Serializable]
public sealed class bmk : a6k, ISerializable
{
	// Token: 0x06008166 RID: 33126 RVA: 0x003685E8 File Offset: 0x003667E8
	private bmk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008167 RID: 33127 RVA: 0x003685F4 File Offset: 0x003667F4
	public bmk()
	{
	}

	// Token: 0x06008168 RID: 33128 RVA: 0x00368600 File Offset: 0x00366800
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("coagulationShot");
		if (a4x != null)
		{
			if (a4x.gu(base.vg().e(), base.vg().q().h.b, c5x.h.b))
			{
				a20.a(base.vg().q(), null, new CombatSpeakEvent[]
				{
					CombatSpeakEvent.Consume_Healing
				});
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
