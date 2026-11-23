using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200102D RID: 4141
[eiz("ALMJ")]
[Serializable]
public sealed class d23 : cze
{
	// Token: 0x0600557C RID: 21884 RVA: 0x0025BA70 File Offset: 0x00259C70
	private d23(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("ALMJ:A");
		this.b = A_0.GetString("ALMJ:P");
		this.c = A_0.GetString("ALMJ:C");
		this.d = A_0.GetString("ALMJ:N");
		di7.ReadList<string>("ALMJ:R", ref this.e, A_0);
	}

	// Token: 0x0600557D RID: 21885 RVA: 0x0025BADC File Offset: 0x00259CDC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ALMJ:A", this.a);
		info.AddValue("ALMJ:P", this.b);
		info.AddValue("ALMJ:C", this.c);
		info.AddValue("ALMJ:N", this.d);
		di7.WriteList<string>("ALMJ:R", this.e, info);
	}

	// Token: 0x0600557E RID: 21886 RVA: 0x0025BB48 File Offset: 0x00259D48
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600557F RID: 21887 RVA: 0x0025BB50 File Offset: 0x00259D50
	public void c(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005580 RID: 21888 RVA: 0x0025BB5C File Offset: 0x00259D5C
	public string d()
	{
		return this.b;
	}

	// Token: 0x06005581 RID: 21889 RVA: 0x0025BB64 File Offset: 0x00259D64
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005582 RID: 21890 RVA: 0x0025BB70 File Offset: 0x00259D70
	public string e()
	{
		return this.c;
	}

	// Token: 0x06005583 RID: 21891 RVA: 0x0025BB78 File Offset: 0x00259D78
	public void d(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005584 RID: 21892 RVA: 0x0025BB84 File Offset: 0x00259D84
	public string c()
	{
		return this.d;
	}

	// Token: 0x06005585 RID: 21893 RVA: 0x0025BB8C File Offset: 0x00259D8C
	public void b(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005586 RID: 21894 RVA: 0x0025BB98 File Offset: 0x00259D98
	public List<string> b()
	{
		return this.e;
	}

	// Token: 0x06005587 RID: 21895 RVA: 0x0025BBA0 File Offset: 0x00259DA0
	public void a(List<string> A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005588 RID: 21896 RVA: 0x0025BBAC File Offset: 0x00259DAC
	public d23()
	{
	}

	// Token: 0x06005589 RID: 21897 RVA: 0x0025BBB8 File Offset: 0x00259DB8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			cqh cqh = new cqh(this.c, this.d, (this.e != null) ? this.e.ToArray() : null);
			cqh.Author = this.a;
			cqh.Portrait = this.b;
			serviceOrThrow.aqu().w().Add(cqh);
		}
	}

	// Token: 0x040022CC RID: 8908
	private new string a;

	// Token: 0x040022CD RID: 8909
	private string b;

	// Token: 0x040022CE RID: 8910
	private string c;

	// Token: 0x040022CF RID: 8911
	private string d;

	// Token: 0x040022D0 RID: 8912
	private List<string> e;
}
