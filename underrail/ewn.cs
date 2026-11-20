using System;
using System.Runtime.Serialization;

// Token: 0x02000916 RID: 2326
[eiz("CCRCTPD1")]
[Serializable]
public sealed class ewn : bdw, ISerializable
{
	// Token: 0x06003947 RID: 14663 RVA: 0x00153130 File Offset: 0x00151330
	private ewn(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003948 RID: 14664 RVA: 0x00153138 File Offset: 0x00151338
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003949 RID: 14665 RVA: 0x0015313C File Offset: 0x0015133C
	public ewn()
	{
	}

	// Token: 0x0600394A RID: 14666 RVA: 0x00153148 File Offset: 0x00151348
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc19");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("d22697eb-e9ad-4748-a64e-c4fbc4546a2a"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("0f864d63-8cda-4e61-9987-20f0cd7c7438"), aud).ao() as c5x;
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
