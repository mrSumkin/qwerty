using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020011C1 RID: 4545
[eiz("EJCI")]
[Serializable]
public sealed class ef6 : s0
{
	// Token: 0x06006136 RID: 24886 RVA: 0x002A5E54 File Offset: 0x002A4054
	private ef6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<cze>("EJCI:J", ref this.a, A_0);
		this.b = A_0.GetString("EJCI:N");
		this.c = A_0.GetString("EJCI:D");
		this.d = A_0.GetString("EJCI:U");
		this.e = A_0.GetString("EJCI:S");
		this.f = A_0.GetString("EJCI:C");
		this.g = (A_0.GetValue("EJCI:O", typeof(dth)) as dth);
	}

	// Token: 0x06006137 RID: 24887 RVA: 0x002A5EFC File Offset: 0x002A40FC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<cze>("EJCI:J", this.a, info);
		info.AddValue("EJCI:N", this.b);
		info.AddValue("EJCI:D", this.c);
		info.AddValue("EJCI:U", this.d);
		info.AddValue("EJCI:S", this.e);
		info.AddValue("EJCI:C", this.f);
		info.AddValue("EJCI:O", this.g);
	}

	// Token: 0x06006138 RID: 24888 RVA: 0x002A5F88 File Offset: 0x002A4188
	public List<cze> e()
	{
		return this.a;
	}

	// Token: 0x06006139 RID: 24889 RVA: 0x002A5F90 File Offset: 0x002A4190
	public void a(List<cze> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600613A RID: 24890 RVA: 0x002A5F9C File Offset: 0x002A419C
	public string g()
	{
		return this.b;
	}

	// Token: 0x0600613B RID: 24891 RVA: 0x002A5FA4 File Offset: 0x002A41A4
	public void c(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600613C RID: 24892 RVA: 0x002A5FB0 File Offset: 0x002A41B0
	public string f()
	{
		return this.c;
	}

	// Token: 0x0600613D RID: 24893 RVA: 0x002A5FB8 File Offset: 0x002A41B8
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600613E RID: 24894 RVA: 0x002A5FC4 File Offset: 0x002A41C4
	public string d()
	{
		return this.e;
	}

	// Token: 0x0600613F RID: 24895 RVA: 0x002A5FCC File Offset: 0x002A41CC
	public void e(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006140 RID: 24896 RVA: 0x002A5FD8 File Offset: 0x002A41D8
	public string b()
	{
		return this.d;
	}

	// Token: 0x06006141 RID: 24897 RVA: 0x002A5FE0 File Offset: 0x002A41E0
	public void d(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006142 RID: 24898 RVA: 0x002A5FEC File Offset: 0x002A41EC
	public dth c()
	{
		return this.g;
	}

	// Token: 0x06006143 RID: 24899 RVA: 0x002A5FF4 File Offset: 0x002A41F4
	public void a(dth A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06006144 RID: 24900 RVA: 0x002A6000 File Offset: 0x002A4200
	public override string ej()
	{
		return this.f;
	}

	// Token: 0x06006145 RID: 24901 RVA: 0x002A6008 File Offset: 0x002A4208
	public string a()
	{
		return this.f;
	}

	// Token: 0x06006146 RID: 24902 RVA: 0x002A6010 File Offset: 0x002A4210
	public void a(string A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06006147 RID: 24903 RVA: 0x002A601C File Offset: 0x002A421C
	public ef6()
	{
	}

	// Token: 0x06006148 RID: 24904 RVA: 0x002A6030 File Offset: 0x002A4230
	public override string ek(e3q A_0)
	{
		return this.b;
	}

	// Token: 0x06006149 RID: 24905 RVA: 0x002A6038 File Offset: 0x002A4238
	public override string el(e3q A_0)
	{
		return this.e;
	}

	// Token: 0x0600614A RID: 24906 RVA: 0x002A6040 File Offset: 0x002A4240
	public override bool em(e3q A_0)
	{
		return this.g == null || this.g.jh(A_0);
	}

	// Token: 0x0600614B RID: 24907 RVA: 0x002A6060 File Offset: 0x002A4260
	public override void en(e3q A_0, c5x A_1)
	{
		foreach (cze cze in this.a)
		{
			au2 au = A_0 as au2;
			cze.ym((au != null) ? au.b() : null, A_1, new Dictionary<string, object>());
		}
	}

	// Token: 0x0600614C RID: 24908 RVA: 0x002A60D8 File Offset: 0x002A42D8
	public override string eo(e3q A_0)
	{
		return this.c;
	}

	// Token: 0x0600614D RID: 24909 RVA: 0x002A60E0 File Offset: 0x002A42E0
	public override string ep(e3q A_0)
	{
		return this.d;
	}

	// Token: 0x0400295D RID: 10589
	private List<cze> a = new List<cze>();

	// Token: 0x0400295E RID: 10590
	private string b;

	// Token: 0x0400295F RID: 10591
	private string c;

	// Token: 0x04002960 RID: 10592
	private string d;

	// Token: 0x04002961 RID: 10593
	private string e;

	// Token: 0x04002962 RID: 10594
	private string f;

	// Token: 0x04002963 RID: 10595
	private dth g;
}
