using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x020017C1 RID: 6081
[eiz("QCA")]
[Serializable]
public sealed class aht : a6k, ISerializable
{
	// Token: 0x060081CF RID: 33231 RVA: 0x0036A5DC File Offset: 0x003687DC
	private aht(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060081D0 RID: 33232 RVA: 0x0036A5E8 File Offset: 0x003687E8
	public aht()
	{
	}

	// Token: 0x060081D1 RID: 33233 RVA: 0x0036A5F0 File Offset: 0x003687F0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("aegis");
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
