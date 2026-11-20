using System;
using System.Runtime.Serialization;

// Token: 0x02000791 RID: 1937
[eiz("WaPhyllisRF")]
[Serializable]
public sealed class ac1 : egv, ISerializable
{
	// Token: 0x060030DD RID: 12509 RVA: 0x0012CCE4 File Offset: 0x0012AEE4
	private ac1(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030DE RID: 12510 RVA: 0x0012CCEC File Offset: 0x0012AEEC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030DF RID: 12511 RVA: 0x0012CCF0 File Offset: 0x0012AEF0
	public ac1()
	{
	}

	// Token: 0x060030E0 RID: 12512 RVA: 0x0012CCFC File Offset: 0x0012AEFC
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
