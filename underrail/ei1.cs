using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x020017D3 RID: 6099
[eiz("CASA")]
[Serializable]
public sealed class ei1 : a6k, ISerializable
{
	// Token: 0x06008202 RID: 33282 RVA: 0x0036BA30 File Offset: 0x00369C30
	private ei1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008203 RID: 33283 RVA: 0x0036BA3C File Offset: 0x00369C3C
	public ei1()
	{
	}

	// Token: 0x06008204 RID: 33284 RVA: 0x0036BA48 File Offset: 0x00369C48
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("adrenalineShot");
		if (a4x != null)
		{
			if (a4x.gu(base.vg().e(), base.vg().q().h.b, c5x.h.b))
			{
				if (base.vg().q().IsPlayer)
				{
					cxc.a(eyy.bt);
				}
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
