using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x020017BC RID: 6076
[eiz("CA9")]
[Serializable]
public sealed class axf : a6k, ISerializable
{
	// Token: 0x060081C0 RID: 33216 RVA: 0x00369F3C File Offset: 0x0036813C
	private axf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060081C1 RID: 33217 RVA: 0x00369F48 File Offset: 0x00368148
	public axf()
	{
	}

	// Token: 0x060081C2 RID: 33218 RVA: 0x00369F54 File Offset: 0x00368154
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("antidote");
		if (a4x != null)
		{
			if (a4x.gu(base.vg().e(), base.vg().q().h.b, c5x.h.b))
			{
				a20.a(base.vg().q(), null, new CombatSpeakEvent[]
				{
					CombatSpeakEvent.Consume_Antidote
				});
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
