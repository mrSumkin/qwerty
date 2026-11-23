using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200107A RID: 4218
[eiz("SHWLJ")]
[Serializable]
public sealed class a8z : cze
{
	// Token: 0x060057F3 RID: 22515 RVA: 0x00263DEC File Offset: 0x00261FEC
	private a8z(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SHWLJ:L");
	}

	// Token: 0x060057F4 RID: 22516 RVA: 0x00263E08 File Offset: 0x00262008
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SHWLJ:L", this.a);
	}

	// Token: 0x060057F5 RID: 22517 RVA: 0x00263E24 File Offset: 0x00262024
	public string a()
	{
		return this.a;
	}

	// Token: 0x060057F6 RID: 22518 RVA: 0x00263E2C File Offset: 0x0026202C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060057F7 RID: 22519 RVA: 0x00263E38 File Offset: 0x00262038
	public a8z()
	{
	}

	// Token: 0x060057F8 RID: 22520 RVA: 0x00263E40 File Offset: 0x00262040
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().b(this.a);
		}
	}

	// Token: 0x04002386 RID: 9094
	private new string a;
}
