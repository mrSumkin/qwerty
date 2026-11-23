using System;
using System.Runtime.Serialization;

// Token: 0x02001276 RID: 4726
[a(typeof(c5i))]
[eiz("ITCRPEA")]
[Serializable]
public sealed class hw : c5i, ISerializable
{
	// Token: 0x0600669C RID: 26268 RVA: 0x002B9F10 File Offset: 0x002B8110
	private hw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600669D RID: 26269 RVA: 0x002B9F1C File Offset: 0x002B811C
	public hw(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x0600669E RID: 26270 RVA: 0x002B9F28 File Offset: 0x002B8128
	public override string g1()
	{
		return "crc";
	}
}
