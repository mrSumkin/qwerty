using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001079 RID: 4217
[eiz("SHWTJ")]
[Serializable]
public sealed class anj : cze
{
	// Token: 0x060057EB RID: 22507 RVA: 0x00263D28 File Offset: 0x00261F28
	private anj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SHWTJ:L1");
		this.b = A_0.GetString("SHWTJ:L2");
	}

	// Token: 0x060057EC RID: 22508 RVA: 0x00263D54 File Offset: 0x00261F54
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SHWTJ:L1", this.a);
		info.AddValue("SHWTJ:L2", this.b);
	}

	// Token: 0x060057ED RID: 22509 RVA: 0x00263D80 File Offset: 0x00261F80
	public string b()
	{
		return this.a;
	}

	// Token: 0x060057EE RID: 22510 RVA: 0x00263D88 File Offset: 0x00261F88
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060057EF RID: 22511 RVA: 0x00263D94 File Offset: 0x00261F94
	public string a()
	{
		return this.b;
	}

	// Token: 0x060057F0 RID: 22512 RVA: 0x00263D9C File Offset: 0x00261F9C
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060057F1 RID: 22513 RVA: 0x00263DA8 File Offset: 0x00261FA8
	public anj()
	{
	}

	// Token: 0x060057F2 RID: 22514 RVA: 0x00263DB4 File Offset: 0x00261FB4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().a(this.a, this.b);
		}
	}

	// Token: 0x04002384 RID: 9092
	private new string a;

	// Token: 0x04002385 RID: 9093
	private string b;
}
