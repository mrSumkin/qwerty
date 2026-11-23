using System;
using System.Runtime.Serialization;

// Token: 0x02000989 RID: 2441
[eiz("PBDBG")]
[Serializable]
public sealed class e3p : bdw, ISerializable
{
	// Token: 0x06003B20 RID: 15136 RVA: 0x0015EDE8 File Offset: 0x0015CFE8
	private e3p(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B21 RID: 15137 RVA: 0x0015EDF0 File Offset: 0x0015CFF0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B22 RID: 15138 RVA: 0x0015EDF4 File Offset: 0x0015CFF4
	public e3p()
	{
	}

	// Token: 0x06003B23 RID: 15139 RVA: 0x0015EE00 File Offset: 0x0015D000
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("pb-mainhall");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("331f77d8-d71a-4709-a930-c17c7373323c"), aud).ao() as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
		}
	}
}
