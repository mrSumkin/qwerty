using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020009EE RID: 2542
[eiz("XPBLKL3PFKF")]
[Serializable]
public sealed class b7y : bdw, ISerializable
{
	// Token: 0x06003CC1 RID: 15553 RVA: 0x00168D1C File Offset: 0x00166F1C
	private b7y(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003CC2 RID: 15554 RVA: 0x00168D24 File Offset: 0x00166F24
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003CC3 RID: 15555 RVA: 0x00168D28 File Offset: 0x00166F28
	public b7y()
	{
	}

	// Token: 0x06003CC4 RID: 15556 RVA: 0x00168D34 File Offset: 0x00166F34
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null)
		{
			d60 d = A_0.a();
			if (d != null)
			{
				List<b0b> list = d.ab4(new string[]
				{
					"xpbl_kirillRobots"
				});
				if (list != null)
				{
					foreach (b0b b0b in list)
					{
						b0b.w();
						b0b.an();
					}
				}
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_kirillhunters_goToBattle", new bool?(false)).Value)
				{
					bv9 bv = serviceOrThrow.aqu().ac() as bv9;
					if (bv != null)
					{
						bv.a(asp.gn, asp.a, h.a, null, true, false, false);
					}
				}
			}
		}
	}
}
