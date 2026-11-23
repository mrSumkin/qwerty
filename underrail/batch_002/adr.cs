using System;
using System.Runtime.Serialization;

// Token: 0x02000792 RID: 1938
[eiz("WaConstantineRF")]
[Serializable]
public sealed class adr : egv, ISerializable
{
	// Token: 0x060030E1 RID: 12513 RVA: 0x0012CD64 File Offset: 0x0012AF64
	private adr(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030E2 RID: 12514 RVA: 0x0012CD6C File Offset: 0x0012AF6C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030E3 RID: 12515 RVA: 0x0012CD70 File Offset: 0x0012AF70
	public adr()
	{
	}

	// Token: 0x060030E4 RID: 12516 RVA: 0x0012CD7C File Offset: 0x0012AF7C
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_wa_oldManNosek_finished", new bool?(false)).Value)
				{
					return 2f;
				}
				return 3f;
			}
		}
		return bhm.a;
	}
}
