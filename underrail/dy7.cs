using System;
using System.Runtime.Serialization;

// Token: 0x02000A02 RID: 2562
[eiz("XPBLJ12DTF")]
[Serializable]
public sealed class dy7 : bdw, ISerializable
{
	// Token: 0x06003D1D RID: 15645 RVA: 0x0016BA40 File Offset: 0x00169C40
	private dy7(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D1E RID: 15646 RVA: 0x0016BA48 File Offset: 0x00169C48
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D1F RID: 15647 RVA: 0x0016BA4C File Offset: 0x00169C4C
	public dy7()
	{
	}

	// Token: 0x06003D20 RID: 15648 RVA: 0x0016BA58 File Offset: 0x00169C58
	public void av(c1a A_0, cyt A_1)
	{
		d60 d = A_0.a();
		if (d != null)
		{
			foreach (b0b b0b in d.ab4(new string[]
			{
				"taskforceL12"
			}))
			{
				b0b.w();
				b0b.an();
			}
		}
	}
}
