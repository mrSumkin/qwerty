using System;
using System.Runtime.Serialization;

// Token: 0x020007AC RID: 1964
[eiz("BlaineRF")]
[Serializable]
public sealed class eut : egv, ISerializable
{
	// Token: 0x06003149 RID: 12617 RVA: 0x0012E9A8 File Offset: 0x0012CBA8
	private eut(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600314A RID: 12618 RVA: 0x0012E9B0 File Offset: 0x0012CBB0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x0600314B RID: 12619 RVA: 0x0012E9B4 File Offset: 0x0012CBB4
	public eut()
	{
	}

	// Token: 0x0600314C RID: 12620 RVA: 0x0012E9C0 File Offset: 0x0012CBC0
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("SpecialMerchandiseLevel_blaine", new int?(-1)).Value;
				if (value < 0)
				{
					return 3f;
				}
				if (value >= 1)
				{
					return 2f;
				}
				return bhm.a;
			}
		}
		return bhm.a;
	}
}
