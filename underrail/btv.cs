using System;
using System.Runtime.Serialization;

// Token: 0x0200092E RID: 2350
[eiz("CCAFLFDC")]
[Serializable]
public sealed class btv : bdw, ISerializable
{
	// Token: 0x060039AC RID: 14764 RVA: 0x00155054 File Offset: 0x00153254
	private btv(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039AD RID: 14765 RVA: 0x0015505C File Offset: 0x0015325C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039AE RID: 14766 RVA: 0x00155060 File Offset: 0x00153260
	public btv()
	{
	}

	// Token: 0x060039AF RID: 14767 RVA: 0x0015506C File Offset: 0x0015326C
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		aud aud = A_0.n("cc10");
		if (aud != null && serviceOrThrow != null)
		{
			c5x c5x = new ar7(new Guid("bf8a6e19-0de1-434c-87a7-6bd8f29cba69"), aud).ao() as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
		}
	}
}
