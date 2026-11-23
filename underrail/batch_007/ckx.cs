using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020011C2 RID: 4546
[eiz("T41")]
[Serializable]
public sealed class ckx : s0
{
	// Token: 0x0600614E RID: 24910 RVA: 0x002A60E8 File Offset: 0x002A42E8
	private ckx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetString("T41:AN");
		this.c = A_0.GetString("T41:DN");
		this.d = A_0.GetString("T41:DS");
		di7.ReadList<Guid>("T41:S", ref this.a, A_0);
	}

	// Token: 0x0600614F RID: 24911 RVA: 0x002A614C File Offset: 0x002A434C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("T41:AN", this.b);
		info.AddValue("T41:DN", this.c);
		info.AddValue("T41:DS", this.d);
		di7.WriteList<Guid>("T41:S", this.a, info);
	}

	// Token: 0x06006150 RID: 24912 RVA: 0x002A61A8 File Offset: 0x002A43A8
	public List<Guid> c()
	{
		return this.a;
	}

	// Token: 0x06006151 RID: 24913 RVA: 0x002A61B0 File Offset: 0x002A43B0
	public void a(List<Guid> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006152 RID: 24914 RVA: 0x002A61BC File Offset: 0x002A43BC
	public string b()
	{
		return this.b;
	}

	// Token: 0x06006153 RID: 24915 RVA: 0x002A61C4 File Offset: 0x002A43C4
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006154 RID: 24916 RVA: 0x002A61D0 File Offset: 0x002A43D0
	public string a()
	{
		return this.c;
	}

	// Token: 0x06006155 RID: 24917 RVA: 0x002A61D8 File Offset: 0x002A43D8
	public void c(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006156 RID: 24918 RVA: 0x002A61E4 File Offset: 0x002A43E4
	public string d()
	{
		return this.d;
	}

	// Token: 0x06006157 RID: 24919 RVA: 0x002A61EC File Offset: 0x002A43EC
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006158 RID: 24920 RVA: 0x002A61F8 File Offset: 0x002A43F8
	public override string ej()
	{
		return "Безопасность";
	}

	// Token: 0x06006159 RID: 24921 RVA: 0x002A6200 File Offset: 0x002A4400
	public ckx()
	{
	}

	// Token: 0x0600615A RID: 24922 RVA: 0x002A6214 File Offset: 0x002A4414
	public override string ek(e3q A_0)
	{
		return this.c;
	}

	// Token: 0x0600615B RID: 24923 RVA: 0x002A6220 File Offset: 0x002A4420
	public override string el(e3q A_0)
	{
		au2 au = (au2)A_0;
		crx crx = new crx();
		crx.a(this.b);
		crx.c().AddRange(this.a);
		if (crx.a(au.b() as c5x, null, null))
		{
			return string.Format("Открытие: {0}", this.c);
		}
		return string.Format("Закрытие: {0}...", this.c);
	}

	// Token: 0x0600615C RID: 24924 RVA: 0x002A6290 File Offset: 0x002A4490
	public override bool em(e3q A_0)
	{
		au2 au = A_0 as au2;
		return au != null && this.a(au.b() as c5x) != null;
	}

	// Token: 0x0600615D RID: 24925 RVA: 0x002A62C0 File Offset: 0x002A44C0
	public override void en(e3q A_0, c5x A_1)
	{
		A_1.c().a("console", "ConsoleItemPowerToggle", 1f, c9z.a, false, false);
		au2 au = (au2)A_0;
		crx crx = new crx();
		crx.a(this.b);
		crx.c().AddRange(this.a);
		if (crx.a(au.b() as c5x, null, null))
		{
			crx.a(bbo.b);
		}
		else
		{
			crx.a(bbo.c);
		}
		crx.ym(au.b() as c5x, null, null);
	}

	// Token: 0x0600615E RID: 24926 RVA: 0x002A6354 File Offset: 0x002A4554
	public override string eo(e3q A_0)
	{
		return this.d;
	}

	// Token: 0x0600615F RID: 24927 RVA: 0x002A6360 File Offset: 0x002A4560
	public override string ep(e3q A_0)
	{
		au2 au = (au2)A_0;
		crx crx = new crx();
		crx.a(this.b);
		crx.c().AddRange(this.a);
		if (crx.a(au.b() as c5x, null, null))
		{
			return string.Format("{0} - Открыть ворота", this.c);
		}
		return string.Format("{0} - Закрыть ворота", this.c);
	}

	// Token: 0x06006160 RID: 24928 RVA: 0x002A63D0 File Offset: 0x002A45D0
	private c5x a(c5x A_0)
	{
		if (!string.IsNullOrEmpty(this.b) && A_0 != null && A_0.Zone != null && this.a != null && this.a.Count > 0)
		{
			aud aud = A_0.Zone.n(this.b);
			if (aud != null)
			{
				return aud.a(this.a[0]) as c5x;
			}
		}
		return null;
	}

	// Token: 0x04002964 RID: 10596
	private List<Guid> a = new List<Guid>();

	// Token: 0x04002965 RID: 10597
	private string b;

	// Token: 0x04002966 RID: 10598
	private string c;

	// Token: 0x04002967 RID: 10599
	private string d;
}
