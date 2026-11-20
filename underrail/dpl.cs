using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001078 RID: 4216
[eiz("DIMAEJ")]
[Serializable]
public sealed class dpl : cze
{
	// Token: 0x060057E3 RID: 22499 RVA: 0x00263C88 File Offset: 0x00261E88
	private dpl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("DIMAEJ:L");
		this.b = A_0.GetString("DIMAEJ:C");
	}

	// Token: 0x060057E4 RID: 22500 RVA: 0x00263CB4 File Offset: 0x00261EB4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DIMAEJ:L", this.a);
		info.AddValue("DIMAEJ:C", this.b);
	}

	// Token: 0x060057E5 RID: 22501 RVA: 0x00263CE0 File Offset: 0x00261EE0
	public string a()
	{
		return this.a;
	}

	// Token: 0x060057E6 RID: 22502 RVA: 0x00263CE8 File Offset: 0x00261EE8
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060057E7 RID: 22503 RVA: 0x00263CF4 File Offset: 0x00261EF4
	public string b()
	{
		return this.b;
	}

	// Token: 0x060057E8 RID: 22504 RVA: 0x00263CFC File Offset: 0x00261EFC
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060057E9 RID: 22505 RVA: 0x00263D08 File Offset: 0x00261F08
	public dpl()
	{
	}

	// Token: 0x060057EA RID: 22506 RVA: 0x00263D10 File Offset: 0x00261F10
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		bpo.GetServiceOrThrow<e5f>().ash(this.b, this.a);
	}

	// Token: 0x04002382 RID: 9090
	private new string a;

	// Token: 0x04002383 RID: 9091
	private string b;
}
