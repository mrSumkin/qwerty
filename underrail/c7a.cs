using System;
using System.Runtime.Serialization;

// Token: 0x02000A2D RID: 2605
[eiz("CCPHPP")]
[Serializable]
public sealed class c7a : bdw, ISerializable
{
	// Token: 0x06003DEA RID: 15850 RVA: 0x001750C4 File Offset: 0x001732C4
	private c7a(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003DEB RID: 15851 RVA: 0x001750CC File Offset: 0x001732CC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003DEC RID: 15852 RVA: 0x001750D0 File Offset: 0x001732D0
	public c7a()
	{
	}

	// Token: 0x06003DED RID: 15853 RVA: 0x001750DC File Offset: 0x001732DC
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_1.r().GetPrimitivePropertyValue<bool>("loc_cc_ph_hasOccupants", new bool?(false)).Value)
		{
			serviceOrThrow.aqu().r()["loc_cc_ph_hasOccupants"] = false;
		}
	}
}
