using System;
using System.Runtime.Serialization;

// Token: 0x0200091A RID: 2330
[eiz("CCRPFSD1")]
[Serializable]
public sealed class evu : bdw, ISerializable
{
	// Token: 0x06003957 RID: 14679 RVA: 0x001534A4 File Offset: 0x001516A4
	private evu(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003958 RID: 14680 RVA: 0x001534AC File Offset: 0x001516AC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003959 RID: 14681 RVA: 0x001534B0 File Offset: 0x001516B0
	public evu()
	{
	}

	// Token: 0x0600395A RID: 14682 RVA: 0x001534BC File Offset: 0x001516BC
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc19");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("964ad61f-a9e4-4179-be24-587b60b9b8be"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.RemoveAspect<c3g>();
				}
			}
		}
	}
}
