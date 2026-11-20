using System;
using System.Runtime.Serialization;

// Token: 0x0200098E RID: 2446
[eiz("PBDWP")]
[Serializable]
public sealed class cgn : bdw, ISerializable
{
	// Token: 0x06003B34 RID: 15156 RVA: 0x0015F124 File Offset: 0x0015D324
	private cgn(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B35 RID: 15157 RVA: 0x0015F12C File Offset: 0x0015D32C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B36 RID: 15158 RVA: 0x0015F130 File Offset: 0x0015D330
	public cgn()
	{
	}

	// Token: 0x06003B37 RID: 15159 RVA: 0x0015F13C File Offset: 0x0015D33C
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("pb-baracks");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("b5a5fc12-0809-465a-a196-2d81e60a56df"), aud).ao() as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
		}
	}
}
