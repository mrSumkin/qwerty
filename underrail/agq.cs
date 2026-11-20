using System;
using System.Runtime.Serialization;

// Token: 0x02000230 RID: 560
[eiz("SUMS")]
[Serializable]
public struct agq : ISerializable
{
	// Token: 0x06000F9D RID: 3997 RVA: 0x00040D14 File Offset: 0x0003EF14
	public agq(uint A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x00040D20 File Offset: 0x0003EF20
	public uint a()
	{
		return this.a;
	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x00040D28 File Offset: 0x0003EF28
	public void a(uint A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x00040D34 File Offset: 0x0003EF34
	private agq(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() >= 6)
		{
			this.a = A_0.GetUInt32("PT");
			return;
		}
		this.a = A_0.GetUInt32("_ProcessingTime");
	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x00040D64 File Offset: 0x0003EF64
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("PT", this.a);
	}

	// Token: 0x04000941 RID: 2369
	private uint a;
}
