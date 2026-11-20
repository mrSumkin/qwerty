using System;
using System.Runtime.Serialization;

// Token: 0x0200098A RID: 2442
[eiz("PBMCBTO")]
[Serializable]
public sealed class l : bdw, ISerializable
{
	// Token: 0x06003B24 RID: 15140 RVA: 0x0015EE50 File Offset: 0x0015D050
	private l(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B25 RID: 15141 RVA: 0x0015EE58 File Offset: 0x0015D058
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B26 RID: 15142 RVA: 0x0015EE5C File Offset: 0x0015D05C
	public l()
	{
	}

	// Token: 0x06003B27 RID: 15143 RVA: 0x0015EE68 File Offset: 0x0015D068
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("pr-amb");
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (aud != null && serviceOrThrow != null)
		{
			c5x c5x = new ar7(new Guid("cf94f20a-95fd-4a56-b773-9f1fc7e52c7a"), aud).ao() as c5x;
			if (c5x != null)
			{
				a0l.a(c5x, "guard_consul", true);
				bm6 aspect = c5x.GetAspect<bm6>();
				if (aspect != null)
				{
					aspect.y6()[ddq.ay] = new bt4("guard_consul");
				}
			}
		}
	}
}
