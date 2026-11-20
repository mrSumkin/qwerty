using System;
using System.Runtime.Serialization;

// Token: 0x020009BF RID: 2495
[eiz("FODBPP")]
[Serializable]
public sealed class dov : bdw, ISerializable
{
	// Token: 0x06003BF8 RID: 15352 RVA: 0x00162A40 File Offset: 0x00160C40
	private dov(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BF9 RID: 15353 RVA: 0x00162A48 File Offset: 0x00160C48
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BFA RID: 15354 RVA: 0x00162A4C File Offset: 0x00160C4C
	public dov()
	{
	}

	// Token: 0x06003BFB RID: 15355 RVA: 0x00162A58 File Offset: 0x00160C58
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("crys5");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("e7dc530c-eb13-4ef3-8406-2d74f39f6a4a"), aud).ao() as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
		}
	}
}
