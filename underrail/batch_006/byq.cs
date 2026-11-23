using System;
using System.Runtime.Serialization;

// Token: 0x020009C5 RID: 2501
[eiz("JYEPARC")]
[Serializable]
public sealed class byq : bdw, ISerializable
{
	// Token: 0x06003C0F RID: 15375 RVA: 0x00163158 File Offset: 0x00161358
	private byq(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C10 RID: 15376 RVA: 0x00163160 File Offset: 0x00161360
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C11 RID: 15377 RVA: 0x00163164 File Offset: 0x00161364
	public byq()
	{
	}

	// Token: 0x06003C12 RID: 15378 RVA: 0x00163170 File Offset: 0x00161370
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("jye3");
			if (aud != null)
			{
				axh aspect = (new ar7(new Guid("fe4db539-7f80-4101-b109-987f44526c9e"), aud).ao() as c5x).GetAspect<axh>();
				if (aspect != null)
				{
					aspect.a(null, true, null);
				}
			}
		}
	}
}
