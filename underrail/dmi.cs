using System;
using System.Runtime.Serialization;

// Token: 0x0200079B RID: 1947
[eiz("FOBarkeeperRF")]
[Serializable]
public sealed class dmi : egv, ISerializable
{
	// Token: 0x06003105 RID: 12549 RVA: 0x0012D224 File Offset: 0x0012B424
	private dmi(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003106 RID: 12550 RVA: 0x0012D22C File Offset: 0x0012B42C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06003107 RID: 12551 RVA: 0x0012D230 File Offset: 0x0012B430
	public dmi()
	{
	}

	// Token: 0x06003108 RID: 12552 RVA: 0x0012D23C File Offset: 0x0012B43C
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
