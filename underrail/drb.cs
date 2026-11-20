using System;
using System.Runtime.Serialization;

// Token: 0x02000A12 RID: 2578
[eiz("XPBLLEATTC")]
[Serializable]
public sealed class drb : bdw, ISerializable
{
	// Token: 0x06003D5F RID: 15711 RVA: 0x0016D8A0 File Offset: 0x0016BAA0
	private drb(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D60 RID: 15712 RVA: 0x0016D8A8 File Offset: 0x0016BAA8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D61 RID: 15713 RVA: 0x0016D8AC File Offset: 0x0016BAAC
	public drb()
	{
	}

	// Token: 0x06003D62 RID: 15714 RVA: 0x0016D8B8 File Offset: 0x0016BAB8
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			aud aud = A_0.n("xpbl_d5");
			if (serviceOrThrow != null && aud != null)
			{
				c5x c5x = new ar7(new Guid("fb77cf3a-ae4a-4ab8-9ef3-695f0920db83"), aud).ao() as c5x;
				c5x c5x2 = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x2 != null)
				{
					c5x2.GetAspect<j7>().a(c5x.GetAspect<j7>(), false, null, false);
				}
			}
		}
	}
}
