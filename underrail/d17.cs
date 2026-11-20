using System;
using System.Runtime.Serialization;

// Token: 0x0200097E RID: 2430
[eiz("TCHDN")]
[Serializable]
public sealed class d17 : bdw, ISerializable
{
	// Token: 0x06003AF3 RID: 15091 RVA: 0x0015DB9C File Offset: 0x0015BD9C
	private d17(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003AF4 RID: 15092 RVA: 0x0015DBA4 File Offset: 0x0015BDA4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AF5 RID: 15093 RVA: 0x0015DBA8 File Offset: 0x0015BDA8
	public d17()
	{
	}

	// Token: 0x06003AF6 RID: 15094 RVA: 0x0015DBB4 File Offset: 0x0015BDB4
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("lu-raf");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("38635f83-41f3-4501-80e0-0972730fafa0"), aud).ao() as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
		}
	}
}
