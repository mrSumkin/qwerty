using System;
using System.Runtime.Serialization;

// Token: 0x0200022E RID: 558
[eiz("PS")]
[Serializable]
public sealed class etb : ISerializable
{
	// Token: 0x06000F86 RID: 3974 RVA: 0x00040934 File Offset: 0x0003EB34
	private etb(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (cat)A_0.GetValue("PS:CS", typeof(cat));
			return;
		}
		if (base.GetType() == typeof(etb))
		{
			this.a = (cat)A_0.GetValue("_CollisionSettings", typeof(cat));
			return;
		}
		this.a = (cat)A_0.GetValue("PlayfieldSchema+_CollisionSettings", typeof(cat));
	}

	// Token: 0x06000F87 RID: 3975 RVA: 0x000409D8 File Offset: 0x0003EBD8
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("PS:CS", this.a);
	}

	// Token: 0x06000F88 RID: 3976 RVA: 0x000409EC File Offset: 0x0003EBEC
	public cat a()
	{
		return this.a;
	}

	// Token: 0x06000F89 RID: 3977 RVA: 0x000409F4 File Offset: 0x0003EBF4
	public void a(cat A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000F8A RID: 3978 RVA: 0x00040A00 File Offset: 0x0003EC00
	public etb()
	{
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x00040A14 File Offset: 0x0003EC14
	public void b(string A_0)
	{
		eoq.SerializeToBinaryFileCompressed<etb>(A_0, this, dds.a(), eh9.c, true);
	}

	// Token: 0x06000F8C RID: 3980 RVA: 0x00040A28 File Offset: 0x0003EC28
	public static etb a(string A_0)
	{
		return eoq.DeserializeFromBinaryFileCompressed<etb>(A_0, dds.a(), true);
	}

	// Token: 0x04000936 RID: 2358
	private cat a = new cat();
}
