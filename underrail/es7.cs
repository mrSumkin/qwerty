using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B9B RID: 2971
[eiz("XPBLE3UCITHA")]
[Serializable]
public sealed class es7 : cze, ISerializable
{
	// Token: 0x06004397 RID: 17303 RVA: 0x001A868C File Offset: 0x001A688C
	private es7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004398 RID: 17304 RVA: 0x001A8698 File Offset: 0x001A6898
	public es7()
	{
	}

	// Token: 0x06004399 RID: 17305 RVA: 0x001A86A4 File Offset: 0x001A68A4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_thrasher_awakened", new bool?(false)).Value && !(new ar7(new Guid("9fb08409-9756-4e5e-a524-1367b830dfb7"), aud).ao() is c5x))
			{
				serviceOrThrow.aqu().r()["npc_xpbl_thrasher_awakened"] = true;
			}
		}
	}
}
