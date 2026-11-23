using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x020018E5 RID: 6373
[eiz("LVDP")]
[Serializable]
public sealed class b5o : TypedObjectReference<amf>, ISerializable
{
	// Token: 0x060086F0 RID: 34544 RVA: 0x0037E0CC File Offset: 0x0037C2CC
	private b5o(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("LVDP:P");
	}

	// Token: 0x060086F1 RID: 34545 RVA: 0x0037E0E8 File Offset: 0x0037C2E8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LVDP:P", this.a);
	}

	// Token: 0x060086F2 RID: 34546 RVA: 0x0037E104 File Offset: 0x0037C304
	public b5o(string A_0)
	{
		czh.a(A_0, "path");
		this.a = A_0;
	}

	// Token: 0x060086F3 RID: 34547 RVA: 0x0037E120 File Offset: 0x0037C320
	public override string ToString()
	{
		return string.Format("Path: {0}", this.a);
	}

	// Token: 0x060086F4 RID: 34548 RVA: 0x0037E134 File Offset: 0x0037C334
	protected override amf h4()
	{
		return ao6.c(this.a);
	}

	// Token: 0x0400348B RID: 13451
	private string a;
}
