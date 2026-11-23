using System;
using System.Runtime.Serialization;

// Token: 0x020009C6 RID: 2502
[eiz("JYUE2")]
[Serializable]
public sealed class exb : bdw, ISerializable
{
	// Token: 0x06003C13 RID: 15379 RVA: 0x001631CC File Offset: 0x001613CC
	private exb(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C14 RID: 15380 RVA: 0x001631D4 File Offset: 0x001613D4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C15 RID: 15381 RVA: 0x001631D8 File Offset: 0x001613D8
	public exb()
	{
	}

	// Token: 0x06003C16 RID: 15382 RVA: 0x001631E4 File Offset: 0x001613E4
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("lu-b31");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("e2b54316-4a57-4e9f-a607-de354e307465"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("9d03c2ed-e71b-45ca-8c89-82de6aa283cd"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.RemoveAspect<c3g>();
				}
				if (c5x2 != null)
				{
					c5x2.RemoveAspect<c3g>();
				}
			}
		}
	}
}
