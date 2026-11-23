using System;
using System.Runtime.Serialization;

// Token: 0x020001C5 RID: 453
[eiz("MS")]
[Serializable]
public abstract class d33 : ISerializable
{
	// Token: 0x06000D5F RID: 3423 RVA: 0x00038FA4 File Offset: 0x000371A4
	protected d33(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06000D60 RID: 3424 RVA: 0x00038FAC File Offset: 0x000371AC
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06000D61 RID: 3425 RVA: 0x00038FB0 File Offset: 0x000371B0
	public d33()
	{
	}

	// Token: 0x06000D62 RID: 3426 RVA: 0x00038FB8 File Offset: 0x000371B8
	public void b(string A_0)
	{
		eoq.SerializeToBinaryFile<d33>(A_0, this, dds.a(), eh9.c, true);
	}

	// Token: 0x06000D63 RID: 3427 RVA: 0x00038FCC File Offset: 0x000371CC
	public static d33 a(string A_0)
	{
		return eoq.DeserializeFromBinaryFile<d33>(A_0, dds.a(), true);
	}

	// Token: 0x040007E6 RID: 2022
	public const string a = "ums";
}
