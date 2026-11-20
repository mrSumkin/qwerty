using System;
using System.Runtime.Serialization;

// Token: 0x0200079C RID: 1948
[eiz("PMRRF")]
[Serializable]
public sealed class ba1 : egv, ISerializable
{
	// Token: 0x06003109 RID: 12553 RVA: 0x0012D2A4 File Offset: 0x0012B4A4
	private ba1(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600310A RID: 12554 RVA: 0x0012D2AC File Offset: 0x0012B4AC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x0600310B RID: 12555 RVA: 0x0012D2B0 File Offset: 0x0012B4B0
	public ba1()
	{
	}

	// Token: 0x0600310C RID: 12556 RVA: 0x0012D2BC File Offset: 0x0012B4BC
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			string name = bp5.j(A_0.ap9().Id);
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				float? primitivePropertyValue = serviceOrThrow.aqu().e().GetPrimitivePropertyValue<float>(name, null);
				if (primitivePropertyValue != null)
				{
					return bhm.a - primitivePropertyValue.Value;
				}
			}
		}
		return bhm.a;
	}
}
