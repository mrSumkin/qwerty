using System;
using System.Runtime.Serialization;

// Token: 0x02001731 RID: 5937
[eiz("PPAA")]
[Serializable]
public sealed class abk : a6k
{
	// Token: 0x06008028 RID: 32808 RVA: 0x0036241C File Offset: 0x0036061C
	private abk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008029 RID: 32809 RVA: 0x00362428 File Offset: 0x00360628
	public abk()
	{
	}

	// Token: 0x0600802A RID: 32810 RVA: 0x00362430 File Offset: 0x00360630
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() != null && base.vg().q().Zone != null && base.vg().q().h.b != null)
		{
			if (base.vg().e() != null && base.vg().e().b9() is coh)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null)
				{
					if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_fo5_insideTank", new bool?(false)).Value)
					{
						base.vg().e().a(true);
						bpo.GetServiceOrThrow<ps>().am3("Fo_PlacePsiAmplifier");
					}
					else
					{
						a7v.a(new h0("Это нужно установить под дуговой печью.", null));
					}
				}
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
