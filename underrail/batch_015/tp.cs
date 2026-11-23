using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A10 RID: 2576
[eiz("XPBLPIRRTCC")]
[Serializable]
public sealed class tp : bdw, ISerializable
{
	// Token: 0x06003D57 RID: 15703 RVA: 0x0016D704 File Offset: 0x0016B904
	private tp(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D58 RID: 15704 RVA: 0x0016D70C File Offset: 0x0016B90C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D59 RID: 15705 RVA: 0x0016D710 File Offset: 0x0016B910
	public tp()
	{
	}

	// Token: 0x06003D5A RID: 15706 RVA: 0x0016D71C File Offset: 0x0016B91C
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		ps serviceOrThrow2 = bpo.GetServiceOrThrow<ps>();
		if (A_0 != null)
		{
			aud aud = A_0.n("xpbl_g2_cabine");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("eeeb3815-98da-4fc1-8d8c-29204bc22801"), aud).ao() as c5x;
				List<ble> list = new List<ble>();
				list.AddRange(a37.a(aud));
				if (c5x != null)
				{
					serviceOrThrow2.amu("characters\\xpbl\\pir_grim", serviceOrThrow.aqu().v().b(), c5x, list, false, true, true, null, false, false);
				}
			}
		}
	}
}
