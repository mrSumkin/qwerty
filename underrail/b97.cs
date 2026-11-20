using System;
using System.Runtime.Serialization;

// Token: 0x0200079A RID: 1946
[eiz("FOBobbyRF")]
[Serializable]
public sealed class b97 : egv, ISerializable
{
	// Token: 0x06003101 RID: 12545 RVA: 0x0012D1A4 File Offset: 0x0012B3A4
	private b97(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003102 RID: 12546 RVA: 0x0012D1AC File Offset: 0x0012B3AC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06003103 RID: 12547 RVA: 0x0012D1B0 File Offset: 0x0012B3B0
	public b97()
	{
	}

	// Token: 0x06003104 RID: 12548 RVA: 0x0012D1BC File Offset: 0x0012B3BC
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_fo_mineReopened", new bool?(false)).Value)
				{
					return 2f;
				}
				return bhm.a;
			}
		}
		return bhm.a;
	}
}
