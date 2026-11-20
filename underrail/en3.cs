using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x020017C4 RID: 6084
[eiz("CHCA")]
[Serializable]
public sealed class en3 : a6k, ISerializable
{
	// Token: 0x060081D8 RID: 33240 RVA: 0x0036A894 File Offset: 0x00368A94
	private en3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060081D9 RID: 33241 RVA: 0x0036A8A0 File Offset: 0x00368AA0
	public en3()
	{
	}

	// Token: 0x060081DA RID: 33242 RVA: 0x0036A8AC File Offset: 0x00368AAC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null || base.vg().q() == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("hercules");
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
