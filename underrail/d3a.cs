using System;
using System.Runtime.Serialization;

// Token: 0x0200098F RID: 2447
[eiz("LUPDBFD")]
[Serializable]
public sealed class d3a : bdw, ISerializable
{
	// Token: 0x06003B38 RID: 15160 RVA: 0x0015F18C File Offset: 0x0015D38C
	private d3a(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B39 RID: 15161 RVA: 0x0015F194 File Offset: 0x0015D394
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B3A RID: 15162 RVA: 0x0015F198 File Offset: 0x0015D398
	public d3a()
	{
	}

	// Token: 0x06003B3B RID: 15163 RVA: 0x0015F1A4 File Offset: 0x0015D3A4
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("lup_freeDroneBase");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("e00293b5-9858-4689-bf2a-b12d99fbbf07"), aud).ao() as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
		}
	}
}
