using System;
using System.Runtime.Serialization;

// Token: 0x02000798 RID: 1944
[eiz("FOEstelleRF")]
[Serializable]
public sealed class a71 : egv, ISerializable
{
	// Token: 0x060030F9 RID: 12537 RVA: 0x0012D0A4 File Offset: 0x0012B2A4
	private a71(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030FA RID: 12538 RVA: 0x0012D0AC File Offset: 0x0012B2AC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030FB RID: 12539 RVA: 0x0012D0B0 File Offset: 0x0012B2B0
	public a71()
	{
	}

	// Token: 0x060030FC RID: 12540 RVA: 0x0012D0BC File Offset: 0x0012B2BC
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
