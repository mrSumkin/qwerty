using System;
using System.Runtime.Serialization;

// Token: 0x02000794 RID: 1940
[eiz("ChFredRF")]
[Serializable]
public sealed class ayi : egv, ISerializable
{
	// Token: 0x060030E9 RID: 12521 RVA: 0x0012CE64 File Offset: 0x0012B064
	private ayi(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030EA RID: 12522 RVA: 0x0012CE6C File Offset: 0x0012B06C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030EB RID: 12523 RVA: 0x0012CE70 File Offset: 0x0012B070
	public ayi()
	{
	}

	// Token: 0x060030EC RID: 12524 RVA: 0x0012CE7C File Offset: 0x0012B07C
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
