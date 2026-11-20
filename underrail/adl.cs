using System;
using System.Runtime.Serialization;

// Token: 0x0200077E RID: 1918
[eiz("ABMRF")]
[Serializable]
public sealed class adl : egv, ISerializable
{
	// Token: 0x06003091 RID: 12433 RVA: 0x0012BB18 File Offset: 0x00129D18
	private adl(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003092 RID: 12434 RVA: 0x0012BB20 File Offset: 0x00129D20
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06003093 RID: 12435 RVA: 0x0012BB24 File Offset: 0x00129D24
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

	// Token: 0x06003094 RID: 12436 RVA: 0x0012BBA0 File Offset: 0x00129DA0
	public adl()
	{
	}
}
