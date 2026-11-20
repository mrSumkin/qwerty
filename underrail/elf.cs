using System;
using System.Runtime.Serialization;

// Token: 0x020004B4 RID: 1204
[eiz("S89")]
[Serializable]
public abstract class elf : ISerializable
{
	// Token: 0x06001EBD RID: 7869 RVA: 0x000AA990 File Offset: 0x000A8B90
	protected elf(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("S89:R", typeof(ls)) as ls);
	}

	// Token: 0x06001EBE RID: 7870 RVA: 0x000AA9B8 File Offset: 0x000A8BB8
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("S89:R", this.a);
	}

	// Token: 0x06001EBF RID: 7871 RVA: 0x000AA9CC File Offset: 0x000A8BCC
	public ls y()
	{
		return this.a;
	}

	// Token: 0x06001EC0 RID: 7872 RVA: 0x000AA9D4 File Offset: 0x000A8BD4
	internal void b(ls A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001EC1 RID: 7873 RVA: 0x000AA9E0 File Offset: 0x000A8BE0
	protected elf(ls A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0400138A RID: 5002
	private ls a;
}
