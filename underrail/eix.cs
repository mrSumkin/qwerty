using System;
using System.Runtime.Serialization;

// Token: 0x0200093E RID: 2366
[eiz("XPBLC3SYSS")]
[Serializable]
public sealed class eix : bdw, ISerializable
{
	// Token: 0x060039EE RID: 14830 RVA: 0x001568B8 File Offset: 0x00154AB8
	private eix(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039EF RID: 14831 RVA: 0x001568C0 File Offset: 0x00154AC0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039F0 RID: 14832 RVA: 0x001568C4 File Offset: 0x00154AC4
	public eix()
	{
	}

	// Token: 0x060039F1 RID: 14833 RVA: 0x001568D0 File Offset: 0x00154AD0
	public void av(c1a A_0, cyt A_1)
	{
		c5x c5x = new ar7(new Guid("a6141084-9273-4cc7-af42-4414b50a2c9e"), A_0.n("xpbl_c3")).ao() as c5x;
		if (c5x != null)
		{
			c5x.ae = new float?((float)1);
			d85 d = c5x.GetAspect<bim>() as d85;
			if (d != null)
			{
				d.g(true);
			}
		}
	}
}
