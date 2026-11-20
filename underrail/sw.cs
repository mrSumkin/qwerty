using System;
using System.Runtime.Serialization;

// Token: 0x02000793 RID: 1939
[eiz("DCLeoRF")]
[Serializable]
public sealed class sw : egv, ISerializable
{
	// Token: 0x060030E5 RID: 12517 RVA: 0x0012CDE4 File Offset: 0x0012AFE4
	private sw(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030E6 RID: 12518 RVA: 0x0012CDEC File Offset: 0x0012AFEC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030E7 RID: 12519 RVA: 0x0012CDF0 File Offset: 0x0012AFF0
	public sw()
	{
	}

	// Token: 0x060030E8 RID: 12520 RVA: 0x0012CDFC File Offset: 0x0012AFFC
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_dc_findLeosKnifeCompleted", new bool?(false)).Value)
				{
					return bhm.a;
				}
				return bhm.b;
			}
		}
		return bhm.a;
	}
}
