using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B2D RID: 2861
[eiz("GSFWR3")]
[Serializable]
public sealed class ebt : cze, ISerializable
{
	// Token: 0x060041FA RID: 16890 RVA: 0x00198FA0 File Offset: 0x001971A0
	private ebt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060041FB RID: 16891 RVA: 0x00198FAC File Offset: 0x001971AC
	public ebt()
	{
	}

	// Token: 0x060041FC RID: 16892 RVA: 0x00198FB8 File Offset: 0x001971B8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bv9 bv = serviceOrThrow.aqu().ac() as bv9;
			if (bv != null)
			{
				bv.a((A_1 as c5x).h.b.aa().FactionId, asp.a, h.a, null, true, false, false);
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("gms_l3_takeMeToYourLeader", new bool?(false)).Value)
				{
					bv.a(asp.a8, asp.a, h.a, null, true, false, false);
				}
				cky cky = bv.abu(asp.a9, asp.a);
				cky cky2 = bv.abu(asp.a9, asp.a);
				if (cky.a != h.a)
				{
					bv.a(asp.a, asp.a9, h.d, null, true, false, false);
				}
				if (cky2.a != h.a)
				{
					bv.a(asp.a, asp.ba, h.d, null, true, false, false);
				}
			}
			serviceOrThrow.aqu().r()["gms_l3_fightIntruders"] = true;
			serviceOrThrow.aqu().r()["gms_l3_dealWithRaiders"] = false;
		}
	}
}
