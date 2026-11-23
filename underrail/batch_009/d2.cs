using System;
using System.Runtime.Serialization;

// Token: 0x02000973 RID: 2419
[eiz("DCTLX")]
[Serializable]
public sealed class d2 : bdw, ISerializable
{
	// Token: 0x06003AC7 RID: 15047 RVA: 0x0015CE4C File Offset: 0x0015B04C
	private d2(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003AC8 RID: 15048 RVA: 0x0015CE54 File Offset: 0x0015B054
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AC9 RID: 15049 RVA: 0x0015CE58 File Offset: 0x0015B058
	public d2()
	{
	}

	// Token: 0x06003ACA RID: 15050 RVA: 0x0015CE64 File Offset: 0x0015B064
	public void av(c1a A_0, cyt A_1)
	{
		d60 d = A_0.a();
		if (d != null)
		{
			foreach (b0b b0b in d.ab4(new string[]
			{
				"projectedDoppelganger"
			}))
			{
				c5x c5x = (c5x)b0b;
				c5x.w();
				c5x.an();
			}
		}
	}
}
