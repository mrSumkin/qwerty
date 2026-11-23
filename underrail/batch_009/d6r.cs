using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001077 RID: 4215
[eiz("QDEJ")]
[Serializable]
public sealed class d6r : cze
{
	// Token: 0x060057DD RID: 22493 RVA: 0x00263BF0 File Offset: 0x00261DF0
	private d6r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("QDEJ:E", typeof(cd2)) as cd2);
	}

	// Token: 0x060057DE RID: 22494 RVA: 0x00263C1C File Offset: 0x00261E1C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("QDEJ:E", this.a);
	}

	// Token: 0x060057DF RID: 22495 RVA: 0x00263C38 File Offset: 0x00261E38
	public cd2 a()
	{
		return this.a;
	}

	// Token: 0x060057E0 RID: 22496 RVA: 0x00263C40 File Offset: 0x00261E40
	public void a(cd2 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060057E1 RID: 22497 RVA: 0x00263C4C File Offset: 0x00261E4C
	public d6r()
	{
	}

	// Token: 0x060057E2 RID: 22498 RVA: 0x00263C58 File Offset: 0x00261E58
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().b(this.a);
		}
	}

	// Token: 0x04002381 RID: 9089
	private new cd2 a;
}
