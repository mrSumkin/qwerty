using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012B9 RID: 4793
[eiz("ISCTEA")]
[Serializable]
public sealed class dwt : Aspect<c5x>, bp1
{
	// Token: 0x060069A2 RID: 27042 RVA: 0x002C8A80 File Offset: 0x002C6C80
	private dwt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 368)
		{
			this.a = (A_0.GetValue("ISCTEA:H", typeof(int?)) as int?);
		}
	}

	// Token: 0x060069A3 RID: 27043 RVA: 0x002C8AC0 File Offset: 0x002C6CC0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ISCTEA:H", this.a);
	}

	// Token: 0x060069A4 RID: 27044 RVA: 0x002C8AE0 File Offset: 0x002C6CE0
	public dwt(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060069A5 RID: 27045 RVA: 0x002C8AEC File Offset: 0x002C6CEC
	public void mx()
	{
		base.a8().e = true;
	}

	// Token: 0x060069A6 RID: 27046 RVA: 0x002C8AFC File Offset: 0x002C6CFC
	public void my()
	{
	}

	// Token: 0x04002B83 RID: 11139
	public int? a;
}
