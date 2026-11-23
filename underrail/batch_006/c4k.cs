using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012D9 RID: 4825
[eiz("XR")]
[Serializable]
public sealed class c4k : Aspect<c5x>, ISerializable
{
	// Token: 0x06006AB5 RID: 27317 RVA: 0x002CEF64 File Offset: 0x002CD164
	private c4k(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("XR:E", typeof(b0b)) as b0b);
		this.b = (A_0.GetValue("XR:T", typeof(TimeSpan?)) as TimeSpan?);
	}

	// Token: 0x06006AB6 RID: 27318 RVA: 0x002CEFC0 File Offset: 0x002CD1C0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XR:E", this.a);
		info.AddValue("XR:T", this.b);
	}

	// Token: 0x06006AB7 RID: 27319 RVA: 0x002CEFF4 File Offset: 0x002CD1F4
	public c4k(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x04002BCF RID: 11215
	public b0b a;

	// Token: 0x04002BD0 RID: 11216
	public TimeSpan? b;
}
