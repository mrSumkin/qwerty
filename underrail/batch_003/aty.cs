using System;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;

// Token: 0x02001774 RID: 6004
[eiz("TAA")]
[Serializable]
public sealed class aty : dtb, ISerializable
{
	// Token: 0x060080F1 RID: 33009 RVA: 0x00366888 File Offset: 0x00364A88
	private aty(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (bl6)A_0.GetValue("TAA:P", typeof(bl6));
			this.b = (ar7)A_0.GetValue("TAA:IR", typeof(ar7));
			this.c = (bool?)A_0.GetValue("TAA:TO", typeof(bool?));
			this.d = (bool?)A_0.GetValue("TAA:OTT", typeof(bool?));
			return;
		}
		if (base.GetType() == typeof(aty))
		{
			this.a = (bl6)A_0.GetValue("_Proxy", typeof(bl6));
			this.b = (ar7)A_0.GetValue("_InvokerRef", typeof(ar7));
			this.c = (bool?)A_0.GetValue("_ToggleOn", typeof(bool?));
			this.d = (bool?)A_0.GetValue("_OnlyToggleTo", typeof(bool?));
			return;
		}
		this.a = (bl6)A_0.GetValue("ToggleAuraAction+_Proxy", typeof(bl6));
		this.b = (ar7)A_0.GetValue("ToggleAuraAction+_InvokerRef", typeof(ar7));
		this.c = (bool?)A_0.GetValue("ToggleAuraAction+_ToggleOn", typeof(bool?));
		this.d = (bool?)A_0.GetValue("ToggleAuraAction+_OnlyToggleTo", typeof(bool?));
	}

	// Token: 0x060080F2 RID: 33010 RVA: 0x00366A44 File Offset: 0x00364C44
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TAA:P", this.a);
		info.AddValue("TAA:IR", this.b);
		info.AddValue("TAA:TO", this.c);
		info.AddValue("TAA:OTT", this.d);
	}

	// Token: 0x060080F3 RID: 33011 RVA: 0x00366AA8 File Offset: 0x00364CA8
	public bl6 e()
	{
		return this.a;
	}

	// Token: 0x060080F4 RID: 33012 RVA: 0x00366AB0 File Offset: 0x00364CB0
	public c5x f()
	{
		return this.b.ao() as c5x;
	}

	// Token: 0x060080F5 RID: 33013 RVA: 0x00366AC8 File Offset: 0x00364CC8
	public aty(bl6 A_0, c5x A_1, bool? A_2)
	{
		czh.a(A_0, "proxy");
		czh.a(A_1, "invoker");
		this.a = A_0;
		this.b = new ar7(A_1);
		this.d = A_2;
		base.a(m7.a);
		base.b(true);
		base.c(true);
		this.d();
	}

	// Token: 0x060080F6 RID: 33014 RVA: 0x00366B28 File Offset: 0x00364D28
	public aty(bl6 A_0, c5x A_1) : this(A_0, A_1, null)
	{
	}

	// Token: 0x060080F7 RID: 33015 RVA: 0x00366B48 File Offset: 0x00364D48
	protected override dc4 dt()
	{
		if (this.f() == null || this.e().b8() == null || this.e().p() == null)
		{
			return dc4.e;
		}
		if (!this.a())
		{
			return dc4.e;
		}
		return base.dt();
	}

	// Token: 0x060080F8 RID: 33016 RVA: 0x00366B98 File Offset: 0x00364D98
	private void d()
	{
		cbj cbj = this.b();
		if (cbj == null)
		{
			dux.b(LogSeverity.Error, "Failed to initialize toggle aura action. Failed to retrieve execution plan. " + this.c(), new object[0]);
			return;
		}
		if (this.f().h.b == null)
		{
			dux.b(LogSeverity.Error, "Failed to initialize toggle aura action. The invoker must have Character Entity aspect. " + this.c(), new object[0]);
			return;
		}
		ca5 ca = null;
		this.c = new bool?(!this.a.q());
		if (this.c.Value)
		{
			bool? flag = this.d;
			bool flag2 = false;
			if (!(flag.GetValueOrDefault() == flag2 & flag != null))
			{
				ca = cbj.im(this.f());
				goto IL_D6;
			}
		}
		if (!this.d.GetValueOrDefault())
		{
			ca = cbj.aix(this.f());
		}
		IL_D6:
		if (ca != null)
		{
			ca.aih(this);
			base.ad().Add(ca);
		}
	}

	// Token: 0x060080F9 RID: 33017 RVA: 0x00366C94 File Offset: 0x00364E94
	private string c()
	{
		return string.Format("(Invoker: '{0}', Proxy: '{1}')", this.f(), this.a.ToString());
	}

	// Token: 0x060080FA RID: 33018 RVA: 0x00366CB4 File Offset: 0x00364EB4
	private cbj b()
	{
		return dpo.a(this.a);
	}

	// Token: 0x060080FB RID: 33019 RVA: 0x00366CC4 File Offset: 0x00364EC4
	private new bool a()
	{
		if (this.c != null)
		{
			if (this.c.Value)
			{
				d02 service = bpo.GetService<d02>();
				if (service != null && service.ahh())
				{
					int num = this.e().d(this.f().h.b.aa());
					if (num > 0)
					{
						d4n d4n = service.ahu(this.f().h.b.aa());
						if (d4n == null || d4n != service.ahe())
						{
							return false;
						}
						if (d4n.c < (double)num)
						{
							return false;
						}
						d4n.a(num, true);
					}
				}
				this.f().h.b.aa().Auras.a(this.a.p() as a8s, this.a);
				if (this.a.v() != dsk.c)
				{
					this.f().h.b.u();
				}
			}
			else
			{
				this.f().h.b.aa().Auras.b(this.a.p() as a8s);
				cp.a(this.f(), this.a);
			}
		}
		return true;
	}

	// Token: 0x04003259 RID: 12889
	private new bl6 a;

	// Token: 0x0400325A RID: 12890
	private ar7 b;

	// Token: 0x0400325B RID: 12891
	private bool? c;

	// Token: 0x0400325C RID: 12892
	private bool? d;
}
