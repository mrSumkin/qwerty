using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x020017C2 RID: 6082
[eiz("CFSA")]
[Serializable]
public sealed class asj : a6k, ISerializable
{
	// Token: 0x060081D2 RID: 33234 RVA: 0x0036A6B4 File Offset: 0x003688B4
	private asj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060081D3 RID: 33235 RVA: 0x0036A6C0 File Offset: 0x003688C0
	public asj()
	{
	}

	// Token: 0x060081D4 RID: 33236 RVA: 0x0036A6CC File Offset: 0x003688CC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null || base.vg().q() == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("focusStim");
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
