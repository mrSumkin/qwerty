using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020008F4 RID: 2292
[eiz("SGSDHB")]
[Serializable]
public sealed class aw5 : bdw, ISerializable
{
	// Token: 0x060038BF RID: 14527 RVA: 0x00150A24 File Offset: 0x0014EC24
	private aw5(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038C0 RID: 14528 RVA: 0x00150A2C File Offset: 0x0014EC2C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038C1 RID: 14529 RVA: 0x00150A30 File Offset: 0x0014EC30
	public aw5()
	{
	}

	// Token: 0x060038C2 RID: 14530 RVA: 0x00150A3C File Offset: 0x0014EC3C
	public void av(c1a A_0, cyt A_1)
	{
		d60 d = A_0.a();
		if (d != null)
		{
			b0b b0b = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
			{
				"HaroldsMiniBot"
			}));
			if (b0b != null)
			{
				b0b.w();
				b0b.an();
			}
		}
	}
}
