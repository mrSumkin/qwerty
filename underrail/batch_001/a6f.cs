using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x0200179C RID: 6044
[eiz("CSPA")]
[Serializable]
public sealed class a6f : a6k, ISerializable
{
	// Token: 0x06008172 RID: 33138 RVA: 0x00368984 File Offset: 0x00366B84
	private a6f(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008173 RID: 33139 RVA: 0x00368990 File Offset: 0x00366B90
	public a6f()
	{
	}

	// Token: 0x06008174 RID: 33140 RVA: 0x00368998 File Offset: 0x00366B98
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null || base.vg().q() == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("spiritPotion");
		if (a4x != null)
		{
			if (a4x.gu(base.vg().e(), base.vg().q().h.b, c5x.h.b))
			{
				a20.a(base.vg().q(), null, new CombatSpeakEvent[]
				{
					CombatSpeakEvent.Consume_Psi
				});
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
