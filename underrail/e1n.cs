using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x0200179E RID: 6046
[eiz("CBLSHA")]
[Serializable]
public sealed class e1n : a6k, ISerializable
{
	// Token: 0x06008178 RID: 33144 RVA: 0x00368B60 File Offset: 0x00366D60
	private e1n(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008179 RID: 33145 RVA: 0x00368B6C File Offset: 0x00366D6C
	public e1n()
	{
	}

	// Token: 0x0600817A RID: 33146 RVA: 0x00368B78 File Offset: 0x00366D78
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("bioluminousSwampHoney");
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
