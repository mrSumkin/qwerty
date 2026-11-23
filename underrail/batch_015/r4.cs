using System;
using System.Runtime.Serialization;

// Token: 0x02000A00 RID: 2560
[eiz("XPBLJ1RNM")]
[Serializable]
public sealed class r4 : bdw, ISerializable
{
	// Token: 0x06003D12 RID: 15634 RVA: 0x0016B8AC File Offset: 0x00169AAC
	private r4(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D13 RID: 15635 RVA: 0x0016B8B4 File Offset: 0x00169AB4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D14 RID: 15636 RVA: 0x0016B8B8 File Offset: 0x00169AB8
	public r4()
	{
	}

	// Token: 0x06003D15 RID: 15637 RVA: 0x0016B8C4 File Offset: 0x00169AC4
	public void av(c1a A_0, cyt A_1)
	{
		foreach (b0b b0b in A_0.a().ab4(new string[]
		{
			"navalMines"
		}))
		{
			if (b0b != null)
			{
				b0b.w();
				b0b.an();
			}
		}
	}
}
