using System;
using System.Runtime.Serialization;

// Token: 0x020011BF RID: 4543
[eiz("T42")]
[Serializable]
public sealed class bxq : s0
{
	// Token: 0x06006116 RID: 24854 RVA: 0x002A5A38 File Offset: 0x002A3C38
	private bxq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = A_0.GetString("T42:AN");
		this.d = A_0.GetString("T42:DN");
		this.e = A_0.GetString("T42:DS");
		this.a = (Guid)A_0.GetValue("T42:L", typeof(Guid));
		this.b = (Guid)A_0.GetValue("T42:R", typeof(Guid));
	}

	// Token: 0x06006117 RID: 24855 RVA: 0x002A5AC0 File Offset: 0x002A3CC0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("T42:AN", this.c);
		info.AddValue("T42:DN", this.d);
		info.AddValue("T42:DS", this.e);
		info.AddValue("T42:L", this.a);
		info.AddValue("T42:R", this.b);
	}

	// Token: 0x06006118 RID: 24856 RVA: 0x002A5B34 File Offset: 0x002A3D34
	public Guid d()
	{
		return this.a;
	}

	// Token: 0x06006119 RID: 24857 RVA: 0x002A5B3C File Offset: 0x002A3D3C
	public void b(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600611A RID: 24858 RVA: 0x002A5B48 File Offset: 0x002A3D48
	public Guid e()
	{
		return this.b;
	}

	// Token: 0x0600611B RID: 24859 RVA: 0x002A5B50 File Offset: 0x002A3D50
	public void a(Guid A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600611C RID: 24860 RVA: 0x002A5B5C File Offset: 0x002A3D5C
	public string c()
	{
		return this.c;
	}

	// Token: 0x0600611D RID: 24861 RVA: 0x002A5B64 File Offset: 0x002A3D64
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600611E RID: 24862 RVA: 0x002A5B70 File Offset: 0x002A3D70
	public string b()
	{
		return this.d;
	}

	// Token: 0x0600611F RID: 24863 RVA: 0x002A5B78 File Offset: 0x002A3D78
	public void c(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006120 RID: 24864 RVA: 0x002A5B84 File Offset: 0x002A3D84
	public string a()
	{
		return this.e;
	}

	// Token: 0x06006121 RID: 24865 RVA: 0x002A5B8C File Offset: 0x002A3D8C
	public void a(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006122 RID: 24866 RVA: 0x002A5B98 File Offset: 0x002A3D98
	public override string ej()
	{
		return "Безопасность";
	}

	// Token: 0x06006123 RID: 24867 RVA: 0x002A5BA0 File Offset: 0x002A3DA0
	public bxq()
	{
	}

	// Token: 0x06006124 RID: 24868 RVA: 0x002A5BA8 File Offset: 0x002A3DA8
	public override string ek(e3q A_0)
	{
		return this.d;
	}

	// Token: 0x06006125 RID: 24869 RVA: 0x002A5BB0 File Offset: 0x002A3DB0
	public override string el(e3q A_0)
	{
		au2 au = (au2)A_0;
		b6r b6r = new b6r();
		b6r.b(this.c);
		b6r.b(this.a);
		b6r.a(this.e());
		if (b6r.a(au.b() as c5x, null, null))
		{
			return string.Format("Открытие: {0}", this.d);
		}
		return string.Format("Закрытие: {0}...", this.d);
	}

	// Token: 0x06006126 RID: 24870 RVA: 0x002A5C28 File Offset: 0x002A3E28
	public override bool em(e3q A_0)
	{
		au2 au = A_0 as au2;
		if (au != null && !string.IsNullOrEmpty(this.c) && au.b() != null && au.b().Zone != null && this.a != Guid.Empty && this.b != Guid.Empty)
		{
			aud aud = au.b().Zone.n(this.c);
			if (aud != null)
			{
				bool flag = aud.a(this.a) is c5x;
				c5x c5x = aud.a(this.b) as c5x;
				return flag && c5x != null;
			}
		}
		return false;
	}

	// Token: 0x06006127 RID: 24871 RVA: 0x002A5CE4 File Offset: 0x002A3EE4
	public override void en(e3q A_0, c5x A_1)
	{
		A_1.c().a("console", "ConsoleItemPowerToggle", 1f, c9z.a, false, false);
		au2 au = (au2)A_0;
		b6r b6r = new b6r();
		b6r.b(this.c);
		b6r.b(this.a);
		b6r.a(this.e());
		if (b6r.a(au.b() as c5x, null, null))
		{
			b6r.a(bbo.b);
		}
		else
		{
			b6r.a(bbo.c);
		}
		b6r.ym(au.b() as c5x, null, null);
	}

	// Token: 0x06006128 RID: 24872 RVA: 0x002A5D80 File Offset: 0x002A3F80
	public override string eo(e3q A_0)
	{
		return this.e;
	}

	// Token: 0x06006129 RID: 24873 RVA: 0x002A5D8C File Offset: 0x002A3F8C
	public override string ep(e3q A_0)
	{
		au2 au = (au2)A_0;
		b6r b6r = new b6r();
		b6r.b(this.c);
		b6r.b(this.a);
		b6r.a(this.e());
		if (b6r.a(au.b() as c5x, null, null))
		{
			return string.Format("{0} - Открыть ворота", this.d);
		}
		return string.Format("{0} - Закрыть ворота", this.d);
	}

	// Token: 0x04002957 RID: 10583
	private Guid a;

	// Token: 0x04002958 RID: 10584
	private Guid b;

	// Token: 0x04002959 RID: 10585
	private string c;

	// Token: 0x0400295A RID: 10586
	private string d;

	// Token: 0x0400295B RID: 10587
	private string e;
}
