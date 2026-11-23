using System;
using System.Runtime.Serialization;

// Token: 0x0200095F RID: 2399
[eiz("RCDMB")]
[Serializable]
public sealed class b28 : bdw, ISerializable
{
	// Token: 0x06003A76 RID: 14966 RVA: 0x0015A6D4 File Offset: 0x001588D4
	private b28(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A77 RID: 14967 RVA: 0x0015A6DC File Offset: 0x001588DC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A78 RID: 14968 RVA: 0x0015A6E0 File Offset: 0x001588E0
	public b28()
	{
	}

	// Token: 0x06003A79 RID: 14969 RVA: 0x0015A6EC File Offset: 0x001588EC
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("rc1");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("4a207008-5ead-46dd-ac22-1101b4be0a13"), aud).ao() as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
		}
	}
}
