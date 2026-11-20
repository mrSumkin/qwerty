using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x020017D9 RID: 6105
[eiz("HA1")]
[Serializable]
public sealed class dbx : a6k, ISerializable
{
	// Token: 0x06008215 RID: 33301 RVA: 0x0036C314 File Offset: 0x0036A514
	private dbx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008216 RID: 33302 RVA: 0x0036C320 File Offset: 0x0036A520
	public dbx()
	{
	}

	// Token: 0x06008217 RID: 33303 RVA: 0x0036C32C File Offset: 0x0036A52C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null || base.vg().q() == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("healthHypo");
		if (a4x != null)
		{
			if (a4x.gu(base.vg().e(), base.vg().q().h.b, c5x.h.b))
			{
				if (base.vg().q().IsPlayer)
				{
					cxc.a(eyy.br);
				}
				a20.a(base.vg().q(), null, new CombatSpeakEvent[]
				{
					CombatSpeakEvent.Consume_Healing
				});
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
