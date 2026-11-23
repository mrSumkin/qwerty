using System;
using System.Runtime.Serialization;

// Token: 0x02000958 RID: 2392
[eiz("LUDDB")]
[Serializable]
public sealed class exf : bdw, ISerializable
{
	// Token: 0x06003A5A RID: 14938 RVA: 0x0015A13C File Offset: 0x0015833C
	private exf(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A5B RID: 14939 RVA: 0x0015A144 File Offset: 0x00158344
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A5C RID: 14940 RVA: 0x0015A148 File Offset: 0x00158348
	public exf()
	{
	}

	// Token: 0x06003A5D RID: 14941 RVA: 0x0015A154 File Offset: 0x00158354
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("lu-b29");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("d2b25e64-9b02-46a8-855a-98f9e179871d"), aud).ao() as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
		}
	}
}
