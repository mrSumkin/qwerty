using System;
using System.Runtime.Serialization;

// Token: 0x0200126C RID: 4716
[eiz("DWSEAT")]
[Serializable]
public sealed class c5e : ya, ISerializable
{
	// Token: 0x0600664E RID: 26190 RVA: 0x002B7F00 File Offset: 0x002B6100
	private c5e(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600664F RID: 26191 RVA: 0x002B7F0C File Offset: 0x002B610C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06006650 RID: 26192 RVA: 0x002B7F18 File Offset: 0x002B6118
	public c5e()
	{
	}
}
