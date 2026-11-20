using System;
using System.Runtime.Serialization;

// Token: 0x02000782 RID: 1922
[eiz("ChFreddRF")]
[Serializable]
public sealed class cyq : egv, ISerializable
{
	// Token: 0x060030A1 RID: 12449 RVA: 0x0012BD10 File Offset: 0x00129F10
	private cyq(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030A2 RID: 12450 RVA: 0x0012BD18 File Offset: 0x00129F18
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030A3 RID: 12451 RVA: 0x0012BD1C File Offset: 0x00129F1C
	public cyq()
	{
	}

	// Token: 0x060030A4 RID: 12452 RVA: 0x0012BD28 File Offset: 0x00129F28
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("burrowerEradicationEnded", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("HathorKingSituationResolved", new bool?(false)).Value;
				float num = 3f;
				if (value)
				{
					num -= 0.5f;
				}
				if (value2)
				{
					num -= 0.7f;
				}
				return Math.Max(bhm.c, num);
			}
		}
		return bhm.a;
	}
}
