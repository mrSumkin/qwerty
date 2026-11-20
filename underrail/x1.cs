using System;
using System.Runtime.Serialization;

// Token: 0x020009DD RID: 2525
[eiz("COJYP")]
[Serializable]
public sealed class x1 : bdw, ISerializable
{
	// Token: 0x06003C70 RID: 15472 RVA: 0x001662DC File Offset: 0x001644DC
	private x1(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C71 RID: 15473 RVA: 0x001662E4 File Offset: 0x001644E4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C72 RID: 15474 RVA: 0x001662E8 File Offset: 0x001644E8
	public x1()
	{
	}

	// Token: 0x06003C73 RID: 15475 RVA: 0x001662F4 File Offset: 0x001644F4
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			csd a_ = A_0.g("FromDown");
			vq.a("objects\\natural\\BigRockPile", a_, true);
		}
	}
}
