using System;
using System.Runtime.Serialization;

// Token: 0x020009C7 RID: 2503
[eiz("JYUE1")]
[Serializable]
public sealed class exa : bdw, ISerializable
{
	// Token: 0x06003C17 RID: 15383 RVA: 0x0016325C File Offset: 0x0016145C
	private exa(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C18 RID: 15384 RVA: 0x00163264 File Offset: 0x00161464
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C19 RID: 15385 RVA: 0x00163268 File Offset: 0x00161468
	public exa()
	{
	}

	// Token: 0x06003C1A RID: 15386 RVA: 0x00163274 File Offset: 0x00161474
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("jye3");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("3b935ef4-c719-47bb-bb0f-9f9da03d51f2"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.RemoveAspect<c3g>();
				}
			}
		}
	}
}
