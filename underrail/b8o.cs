using System;
using System.Runtime.Serialization;

// Token: 0x020007DF RID: 2015
[eiz("RCMBST")]
[Serializable]
public sealed class b8o : ya, ISerializable
{
	// Token: 0x06003280 RID: 12928 RVA: 0x00139EFC File Offset: 0x001380FC
	private b8o(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003281 RID: 12929 RVA: 0x00139F08 File Offset: 0x00138108
	public b8o()
	{
	}

	// Token: 0x06003282 RID: 12930 RVA: 0x00139F10 File Offset: 0x00138110
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.h.b != null && c5x.h.b.aa().Id == "jared")
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				serviceOrThrow.aqu().r()["npc_rcjared_enteredMedbayStorage"] = true;
			}
		}
	}

	// Token: 0x06003283 RID: 12931 RVA: 0x00139F94 File Offset: 0x00138194
	protected override void pq(b0b A_0)
	{
		base.pq(A_0);
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.h.b != null && c5x.h.b.aa().Id == "jared")
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				serviceOrThrow.aqu().r()["npc_rcjared_enteredMedbayStorage"] = false;
			}
		}
	}
}
