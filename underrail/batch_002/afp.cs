using System;
using System.Runtime.Serialization;

// Token: 0x020011C3 RID: 4547
[eiz("X97")]
[Serializable]
public sealed class afp : s0
{
	// Token: 0x06006161 RID: 24929 RVA: 0x002A644C File Offset: 0x002A464C
	private afp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("X97:P");
		this.b = A_0.GetString("X97:DN");
		this.c = A_0.GetString("X97:DS");
		this.d = A_0.GetString("X97:ON");
		this.e = A_0.GetString("X97:OF");
	}

	// Token: 0x06006162 RID: 24930 RVA: 0x002A64CC File Offset: 0x002A46CC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("X97:P", this.a);
		info.AddValue("X97:DN", this.b);
		info.AddValue("X97:DS", this.c);
		info.AddValue("X97:ON", this.d);
		info.AddValue("X97:OF", this.e);
	}

	// Token: 0x06006163 RID: 24931 RVA: 0x002A6538 File Offset: 0x002A4738
	public string d()
	{
		return this.a;
	}

	// Token: 0x06006164 RID: 24932 RVA: 0x002A6540 File Offset: 0x002A4740
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006165 RID: 24933 RVA: 0x002A654C File Offset: 0x002A474C
	public string b()
	{
		return this.b;
	}

	// Token: 0x06006166 RID: 24934 RVA: 0x002A6554 File Offset: 0x002A4754
	public void c(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006167 RID: 24935 RVA: 0x002A6560 File Offset: 0x002A4760
	public string c()
	{
		return this.c;
	}

	// Token: 0x06006168 RID: 24936 RVA: 0x002A6568 File Offset: 0x002A4768
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006169 RID: 24937 RVA: 0x002A6574 File Offset: 0x002A4774
	public override string ej()
	{
		return "Безопасность";
	}

	// Token: 0x0600616A RID: 24938 RVA: 0x002A657C File Offset: 0x002A477C
	public string e()
	{
		return this.d;
	}

	// Token: 0x0600616B RID: 24939 RVA: 0x002A6584 File Offset: 0x002A4784
	public void d(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600616C RID: 24940 RVA: 0x002A6590 File Offset: 0x002A4790
	public string a()
	{
		return this.e;
	}

	// Token: 0x0600616D RID: 24941 RVA: 0x002A6598 File Offset: 0x002A4798
	public void e(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600616E RID: 24942 RVA: 0x002A65A4 File Offset: 0x002A47A4
	public afp()
	{
	}

	// Token: 0x0600616F RID: 24943 RVA: 0x002A65C4 File Offset: 0x002A47C4
	public override string ek(e3q A_0)
	{
		return this.b;
	}

	// Token: 0x06006170 RID: 24944 RVA: 0x002A65CC File Offset: 0x002A47CC
	public override string el(e3q A_0)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && !string.IsNullOrEmpty(this.a))
		{
			return "Операция успешно завершена.";
		}
		return "#ERROR: Controls disonnected";
	}

	// Token: 0x06006171 RID: 24945 RVA: 0x002A65F8 File Offset: 0x002A47F8
	public override bool em(e3q A_0)
	{
		return true;
	}

	// Token: 0x06006172 RID: 24946 RVA: 0x002A65FC File Offset: 0x002A47FC
	public override void en(e3q A_0, c5x A_1)
	{
		A_1.c().a("console", "ConsoleItemPowerToggle", 1f, c9z.a, false, false);
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && !string.IsNullOrEmpty(this.a))
		{
			bool? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(this.a, null);
			if (primitivePropertyValue == null || !primitivePropertyValue.Value)
			{
				serviceOrThrow.aqu().r()[this.a] = true;
				return;
			}
			serviceOrThrow.aqu().r()[this.a] = false;
		}
	}

	// Token: 0x06006173 RID: 24947 RVA: 0x002A66BC File Offset: 0x002A48BC
	public override string eo(e3q A_0)
	{
		return this.c;
	}

	// Token: 0x06006174 RID: 24948 RVA: 0x002A66C8 File Offset: 0x002A48C8
	public override string ep(e3q A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && !string.IsNullOrEmpty(this.a))
		{
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(this.a, new bool?(false)).Value;
			return this.b + " - Изменить на: " + (value ? this.e : this.d);
		}
		return "#ERROR: Power controls disonnected";
	}

	// Token: 0x04002968 RID: 10600
	private string a;

	// Token: 0x04002969 RID: 10601
	private string b;

	// Token: 0x0400296A RID: 10602
	private string c;

	// Token: 0x0400296B RID: 10603
	private string d = "On";

	// Token: 0x0400296C RID: 10604
	private string e = "Off";
}
