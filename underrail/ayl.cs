using System;
using System.Runtime.Serialization;

// Token: 0x02000906 RID: 2310
[eiz("CCMGTT")]
[Serializable]
public sealed class ayl : bdw, ISerializable
{
	// Token: 0x06003907 RID: 14599 RVA: 0x00151EFC File Offset: 0x001500FC
	private ayl(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003908 RID: 14600 RVA: 0x00151F04 File Offset: 0x00150104
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003909 RID: 14601 RVA: 0x00151F08 File Offset: 0x00150108
	public ayl()
	{
	}

	// Token: 0x0600390A RID: 14602 RVA: 0x00151F14 File Offset: 0x00150114
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null)
		{
			serviceOrThrow.aqu().ac();
			if (A_0.n("cc16") != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null)
				{
					c5x c5x2 = new ar7(new Guid("e19114c9-2185-47b5-812b-7e45863ac33f"), c5x.Area).ao() as c5x;
					if (c5x2 != null)
					{
						c5x.GetAspect<j7>().a(c5x2.GetAspect<j7>(), false, null, false);
					}
				}
			}
		}
	}
}
