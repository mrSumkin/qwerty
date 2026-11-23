using System;
using System.Runtime.Serialization;

// Token: 0x020012A7 RID: 4775
[eiz("RGSEA")]
[a(typeof(cd0))]
[Serializable]
public sealed class cge : cd0, ISerializable
{
	// Token: 0x0600687A RID: 26746 RVA: 0x002C2C48 File Offset: 0x002C0E48
	private cge(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("RGSEA:Z");
	}

	// Token: 0x0600687B RID: 26747 RVA: 0x002C2C64 File Offset: 0x002C0E64
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RGSEA:Z", this.a);
	}

	// Token: 0x0600687C RID: 26748 RVA: 0x002C2C80 File Offset: 0x002C0E80
	public new int a()
	{
		return this.a;
	}

	// Token: 0x0600687D RID: 26749 RVA: 0x002C2C88 File Offset: 0x002C0E88
	public new void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600687E RID: 26750 RVA: 0x002C2C94 File Offset: 0x002C0E94
	public cge(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x04002B27 RID: 11047
	private new int a;
}
