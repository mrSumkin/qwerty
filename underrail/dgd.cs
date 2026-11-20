using System;
using System.Runtime.Serialization;

// Token: 0x02000781 RID: 1921
[eiz("ChFreddyRF")]
[Serializable]
public sealed class dgd : egv, ISerializable
{
	// Token: 0x0600309D RID: 12445 RVA: 0x0012BC50 File Offset: 0x00129E50
	private dgd(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600309E RID: 12446 RVA: 0x0012BC58 File Offset: 0x00129E58
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x0600309F RID: 12447 RVA: 0x0012BC5C File Offset: 0x00129E5C
	public dgd()
	{
	}

	// Token: 0x060030A0 RID: 12448 RVA: 0x0012BC68 File Offset: 0x00129E68
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
