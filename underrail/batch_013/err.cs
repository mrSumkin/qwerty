using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x0200179D RID: 6045
[eiz("CVPA")]
[Serializable]
public sealed class err : a6k, ISerializable
{
	// Token: 0x06008175 RID: 33141 RVA: 0x00368A88 File Offset: 0x00366C88
	private err(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008176 RID: 33142 RVA: 0x00368A94 File Offset: 0x00366C94
	public err()
	{
	}

	// Token: 0x06008177 RID: 33143 RVA: 0x00368A9C File Offset: 0x00366C9C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("vitalityPowder");
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
