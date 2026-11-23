using System;
using System.Runtime.Serialization;

// Token: 0x020009BB RID: 2491
[eiz("LURAOOF")]
[Serializable]
public sealed class u8 : bdw, ISerializable
{
	// Token: 0x06003BE9 RID: 15337 RVA: 0x001626A8 File Offset: 0x001608A8
	private u8(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BEA RID: 15338 RVA: 0x001626B0 File Offset: 0x001608B0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BEB RID: 15339 RVA: 0x001626B4 File Offset: 0x001608B4
	public u8()
	{
	}

	// Token: 0x06003BEC RID: 15340 RVA: 0x001626C0 File Offset: 0x001608C0
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null)
		{
			serviceOrThrow.aqu().ac();
			aud aud = A_0.n("fo3");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("29d0b887-3b9e-445b-8c58-906e4149d660"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.w();
					c5x.an();
				}
			}
		}
	}
}
