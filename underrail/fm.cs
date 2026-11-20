using System;
using System.Runtime.Serialization;

// Token: 0x020009B0 RID: 2480
[eiz("FOTPE1")]
[Serializable]
public sealed class fm : bdw, ISerializable
{
	// Token: 0x06003BBC RID: 15292 RVA: 0x00161864 File Offset: 0x0015FA64
	private fm(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BBD RID: 15293 RVA: 0x0016186C File Offset: 0x0015FA6C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BBE RID: 15294 RVA: 0x00161870 File Offset: 0x0015FA70
	public fm()
	{
	}

	// Token: 0x06003BBF RID: 15295 RVA: 0x0016187C File Offset: 0x0015FA7C
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null)
		{
			aud aud = A_0.n("lu-c2");
			if (aud != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null)
				{
					c5x c5x2 = new ar7(new Guid("f6667db1-2de2-4330-b37e-ffb7a6c35df0"), aud).ao() as c5x;
					if (c5x2 != null)
					{
						c5x.GetAspect<j7>().a(c5x2.GetAspect<j7>(), false, null, false);
					}
				}
			}
		}
	}
}
