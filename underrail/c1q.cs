using System;
using System.Runtime.Serialization;

// Token: 0x02000992 RID: 2450
[eiz("PBMCTCO")]
[Serializable]
public sealed class c1q : bdw, ISerializable
{
	// Token: 0x06003B44 RID: 15172 RVA: 0x0015F51C File Offset: 0x0015D71C
	private c1q(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B45 RID: 15173 RVA: 0x0015F524 File Offset: 0x0015D724
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B46 RID: 15174 RVA: 0x0015F528 File Offset: 0x0015D728
	public c1q()
	{
	}

	// Token: 0x06003B47 RID: 15175 RVA: 0x0015F534 File Offset: 0x0015D734
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("pr-amb");
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (aud != null && serviceOrThrow != null)
		{
			c5x c5x = new ar7(new Guid("8cf6fced-8d88-4c89-ab91-cdbec36847d2"), aud).ao() as c5x;
			if (c5x != null)
			{
				a0l.a(c5x, "colonel_consulsOffice", true);
				bm6 aspect = c5x.GetAspect<bm6>();
				if (aspect != null)
				{
					aspect.y6()[ddq.ay] = new bt4("colonel_consulsOffice");
				}
			}
		}
	}
}
