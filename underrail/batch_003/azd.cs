using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001797 RID: 6039
[eiz("CHCXA")]
[Serializable]
public sealed class azd : a6k, ISerializable
{
	// Token: 0x06008163 RID: 33123 RVA: 0x0036850C File Offset: 0x0036670C
	private azd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008164 RID: 33124 RVA: 0x00368518 File Offset: 0x00366718
	public azd()
	{
	}

	// Token: 0x06008165 RID: 33125 RVA: 0x00368524 File Offset: 0x00366724
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("hypercerebrix");
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
