using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001791 RID: 6033
[eiz("CBH")]
[Serializable]
public sealed class ca8 : a6k, ISerializable
{
	// Token: 0x06008151 RID: 33105 RVA: 0x00367F74 File Offset: 0x00366174
	private ca8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008152 RID: 33106 RVA: 0x00367F80 File Offset: 0x00366180
	public ca8()
	{
	}

	// Token: 0x06008153 RID: 33107 RVA: 0x00367F88 File Offset: 0x00366188
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("bullhead");
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
