using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x020017D2 RID: 6098
[eiz("CPBA")]
[Serializable]
public sealed class ez1 : a6k, ISerializable
{
	// Token: 0x060081FF RID: 33279 RVA: 0x0036B934 File Offset: 0x00369B34
	private ez1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008200 RID: 33280 RVA: 0x0036B940 File Offset: 0x00369B40
	public ez1()
	{
	}

	// Token: 0x06008201 RID: 33281 RVA: 0x0036B94C File Offset: 0x00369B4C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("psiBooster");
		if (a4x != null)
		{
			if (a4x.gu(base.vg().e(), base.vg().q().h.b, c5x.h.b))
			{
				if (base.vg().q().IsPlayer)
				{
					cxc.a(eyy.bs);
				}
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
