using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001076 RID: 4214
[eiz("RDEJ")]
[Serializable]
public sealed class azq : cze
{
	// Token: 0x060057D7 RID: 22487 RVA: 0x00263B68 File Offset: 0x00261D68
	private azq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("RDEJ:C");
	}

	// Token: 0x060057D8 RID: 22488 RVA: 0x00263B84 File Offset: 0x00261D84
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RDEJ:C", this.a);
	}

	// Token: 0x060057D9 RID: 22489 RVA: 0x00263BA0 File Offset: 0x00261DA0
	public string a()
	{
		return this.a;
	}

	// Token: 0x060057DA RID: 22490 RVA: 0x00263BA8 File Offset: 0x00261DA8
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060057DB RID: 22491 RVA: 0x00263BB4 File Offset: 0x00261DB4
	public azq()
	{
	}

	// Token: 0x060057DC RID: 22492 RVA: 0x00263BC0 File Offset: 0x00261DC0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().d(this.a);
		}
	}

	// Token: 0x04002380 RID: 9088
	private new string a;
}
