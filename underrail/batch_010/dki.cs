using System;
using System.Runtime.Serialization;

// Token: 0x020009E4 RID: 2532
[eiz("XPHWDTRTO")]
[Serializable]
public sealed class dki : bdw, ISerializable
{
	// Token: 0x06003C8F RID: 15503 RVA: 0x00166DA8 File Offset: 0x00164FA8
	private dki(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C90 RID: 15504 RVA: 0x00166DB0 File Offset: 0x00164FB0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C91 RID: 15505 RVA: 0x00166DB4 File Offset: 0x00164FB4
	public dki()
	{
	}

	// Token: 0x06003C92 RID: 15506 RVA: 0x00166DC0 File Offset: 0x00164FC0
	public void av(c1a A_0, cyt A_1)
	{
		d60 addon = A_0.GetAddon<d60>();
		if (addon != null)
		{
			foreach (b0b b0b in addon.ab4(new string[]
			{
				"tunnelObservable"
			}))
			{
				b0b.w();
				b0b.an();
			}
		}
	}
}
