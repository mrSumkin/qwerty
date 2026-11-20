using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules;

// Token: 0x02000F8C RID: 3980
[eiz("FPCEA")]
[Serializable]
public sealed class cl1 : Aspect<c5x>, c98, chb
{
	// Token: 0x06005128 RID: 20776 RVA: 0x00248E08 File Offset: 0x00247008
	private cl1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.n = A_0.GetInt32("FPCEA:T");
		this.m = A_0.GetDouble("FPCEA:C");
		this.k = (A_0.GetValue("FPCEA:N", typeof(TimeSpan?)) as TimeSpan?);
		this.d = A_0.GetString("FPCEA:P");
		this.e = A_0.GetInt32("FPCEA:H");
		this.f = A_0.GetInt32("FPCEA:S");
		this.h = A_0.GetBoolean("FPCEA:A");
		this.i = A_0.GetInt32("FPCEA:R");
		di7.ReadList<ar7>("FPCEA:E", ref this.j, A_0);
		if (ell.a() >= 292)
		{
			di7.ReadList<Guid>("FPCEA:L", ref this.g, A_0);
			this.c = (A_0.GetValue("FPCEA:D", typeof(TimeSpan?)) as TimeSpan?);
			this.l = (A_0.GetValue("FPCEA:U", typeof(TimeSpan?)) as TimeSpan?);
		}
	}

	// Token: 0x06005129 RID: 20777 RVA: 0x00248F40 File Offset: 0x00247140
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FPCEA:T", this.n);
		info.AddValue("FPCEA:C", this.m);
		info.AddValue("FPCEA:N", this.k);
		info.AddValue("FPCEA:P", this.d);
		info.AddValue("FPCEA:H", this.e);
		info.AddValue("FPCEA:S", this.f);
		info.AddValue("FPCEA:A", this.h);
		info.AddValue("FPCEA:R", this.i);
		info.AddValue("FPCEA:D", this.c);
		info.AddValue("FPCEA:U", this.l);
		di7.WriteList<ar7>("FPCEA:E", this.j, info);
		di7.WriteList<Guid>("FPCEA:L", this.g, info);
	}

	// Token: 0x0600512A RID: 20778 RVA: 0x00249030 File Offset: 0x00247230
	public bool j()
	{
		return this.h;
	}

	// Token: 0x0600512B RID: 20779 RVA: 0x00249038 File Offset: 0x00247238
	public TimeSpan? h()
	{
		return this.c;
	}

	// Token: 0x0600512C RID: 20780 RVA: 0x00249040 File Offset: 0x00247240
	public void a(TimeSpan? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600512D RID: 20781 RVA: 0x0024904C File Offset: 0x0024724C
	public string i()
	{
		return this.d;
	}

	// Token: 0x0600512E RID: 20782 RVA: 0x00249054 File Offset: 0x00247254
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600512F RID: 20783 RVA: 0x00249060 File Offset: 0x00247260
	public int k()
	{
		return this.e;
	}

	// Token: 0x06005130 RID: 20784 RVA: 0x00249068 File Offset: 0x00247268
	public void b(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005131 RID: 20785 RVA: 0x00249074 File Offset: 0x00247274
	public int g()
	{
		return this.f;
	}

	// Token: 0x06005132 RID: 20786 RVA: 0x0024907C File Offset: 0x0024727C
	public void c(int A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005133 RID: 20787 RVA: 0x00249088 File Offset: 0x00247288
	public cl1(c5x A_0) : base(A_0)
	{
		this.m = 0.0;
	}

	// Token: 0x06005134 RID: 20788 RVA: 0x002490AC File Offset: 0x002472AC
	public void r7(eds A_0)
	{
		if (!dz6.e())
		{
			if ((this.m -= A_0.b.TotalMilliseconds) <= 0.0)
			{
				this.m += (double)d0u.b;
				this.a(false);
				return;
			}
		}
		else
		{
			this.m = (double)d0u.b;
		}
	}

	// Token: 0x06005135 RID: 20789 RVA: 0x00249114 File Offset: 0x00247314
	public void c()
	{
		if (this.h)
		{
			this.a(true);
		}
	}

	// Token: 0x06005136 RID: 20790 RVA: 0x0024912C File Offset: 0x0024732C
	private void a(bool A_0 = false)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_TchortDefeated", new bool?(false)).Value;
			if (!this.h)
			{
				if (!value)
				{
					if (this.k == null)
					{
						this.a(serviceOrThrow);
						return;
					}
					if (this.k.Value <= serviceOrThrow.aqu().o())
					{
						if ((double)((int)(serviceOrThrow.aqu().o() - this.k.Value).TotalSeconds % (int)cl1.b.TotalSeconds) / cl1.b.TotalSeconds > 0.25)
						{
							this.a(serviceOrThrow);
							return;
						}
						this.d();
						return;
					}
				}
			}
			else
			{
				this.f();
			}
		}
	}

	// Token: 0x06005137 RID: 20791 RVA: 0x00249220 File Offset: 0x00247420
	private void f()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() == null)
		{
			return;
		}
		if (this.j == null)
		{
			this.e();
			return;
		}
		int num = 0;
		bool flag = true;
		bool flag2 = false;
		for (int i = 0; i < this.j.Count; i++)
		{
			c5x c5x = this.j[i].ao() as c5x;
			if (c5x != null && c5x.j == cgy.b)
			{
				if (c5x.h.b != null && c5x.h.b.aa().IsInCombat)
				{
					flag2 = true;
				}
				if (c5x.t.b != null)
				{
					bt4 classPropertyValue = c5x.t.b.y6().GetClassPropertyValue<bt4>(ddq.ay);
					if (classPropertyValue != null)
					{
						num++;
						if (!aw1.a(c5x, classPropertyValue, false))
						{
							flag = false;
							break;
						}
					}
				}
			}
		}
		if (num == 0)
		{
			this.e();
			return;
		}
		if (flag && this.i < this.e)
		{
			if (this.c != null)
			{
				if (this.l == null || flag2)
				{
					this.l = new TimeSpan?(serviceOrThrow.aqu().o() + this.c.Value);
					return;
				}
				if (this.l.Value > serviceOrThrow.aqu().o())
				{
					return;
				}
			}
			this.a(this.i + 1);
		}
	}

	// Token: 0x06005138 RID: 20792 RVA: 0x002493C0 File Offset: 0x002475C0
	private void e()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		this.j = null;
		this.h = false;
		this.l = null;
		this.a(serviceOrThrow);
	}

	// Token: 0x06005139 RID: 20793 RVA: 0x002493F4 File Offset: 0x002475F4
	private void d()
	{
		foreach (Guid a_ in this.g)
		{
			cl1 cl = new EntityAspectReference<cl1, cl1>(base.a8().Area, a_).ao();
			if (cl != null && cl.j())
			{
				return;
			}
		}
		bm6 a_2 = null;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Zone != null)
		{
			a_2 = serviceOrThrow.aqu().v().b().GetAspect<bm6>();
		}
		List<csd> list = new List<csd>();
		int num = this.b();
		for (int i = 1; i <= num; i++)
		{
			csd csd = base.a8().Zone.g(string.Format("{0}_0_{1}", this.d, i));
			if (csd == null || aw1.a(null, csd.Tile, false, null) || this.a(a_2, csd.Tile))
			{
				return;
			}
			list.Add(csd);
		}
		this.h = true;
		this.j = new List<ar7>();
		int num2 = 0;
		if (this.c != null)
		{
			num2 = -2;
		}
		foreach (csd a_3 in list)
		{
			c5x c5x = vq.a(cl1.a[cuo.a.Next(cl1.a.Length + num2)], a_3, false);
			if (c5x != null)
			{
				this.j.Add(new ar7(c5x));
				if (c5x != null)
				{
					if (c5x.h.b != null)
					{
						c5x.h.b.aa().FactionId = asp.ch;
					}
					if (c5x.t.b != null && c5x.t.b.ac() == "Rathound")
					{
						c5x.t.b.b("soldierPatrol");
						a6p aspect = c5x.GetAspect<a6p>();
						if (aspect != null)
						{
							aspect.d().Add("-ai");
						}
					}
					e3l e3l = c5x.GetAspect<e3l>();
					if (e3l == null)
					{
						e3l = new e3l(c5x);
						c5x.SetAspect<e3l>(e3l);
					}
					e3l.a.Add(this.a());
					e3l.a();
				}
			}
		}
		this.a(1);
	}

	// Token: 0x0600513A RID: 20794 RVA: 0x00249708 File Offset: 0x00247908
	private int b()
	{
		int num = this.f;
		bu6 service = bpo.GetService<bu6>();
		if (service != null)
		{
			if (service.aq2() == GameDifficulty.Easy)
			{
				num--;
			}
			else if (service.aq2() == GameDifficulty.Hard)
			{
				num++;
			}
			else if (service.aq2() == GameDifficulty.Dominating)
			{
				num += 2;
			}
		}
		return num;
	}

	// Token: 0x0600513B RID: 20795 RVA: 0x00249764 File Offset: 0x00247964
	private void a(int A_0)
	{
		this.i = A_0;
		if (this.j != null)
		{
			for (int i = 0; i < this.j.Count; i++)
			{
				c5x c5x = this.j[i].ao() as c5x;
				if (c5x != null && c5x.t.b != null)
				{
					c5x.t.b.y6()[ddq.ay] = new bt4(string.Format("{0}_{1}_{2}", this.d, A_0, i + 1));
					if (this.e == A_0)
					{
						c5x.t.b.y6()[ddq.bg] = true;
					}
				}
			}
		}
	}

	// Token: 0x0600513C RID: 20796 RVA: 0x00249838 File Offset: 0x00247A38
	private string a()
	{
		return "FacelessPatrol_" + this.d;
	}

	// Token: 0x0600513D RID: 20797 RVA: 0x0024984C File Offset: 0x00247A4C
	private void a(cnk A_0)
	{
		this.k = new TimeSpan?(A_0.aqu().o() + cl1.b - TimeSpan.FromMinutes(1.0) + TimeSpan.FromSeconds((double)cuo.a.Next(120)));
	}

	// Token: 0x0600513E RID: 20798 RVA: 0x002498A4 File Offset: 0x00247AA4
	private bool a(bm6 A_0, ak1 A_1)
	{
		return A_0 != null && A_0.ai() && A_0.a(A_1);
	}

	// Token: 0x04002141 RID: 8513
	private static readonly string[] a = new string[]
	{
		"creature\\Faceless\\FacelessSoldier-AssaultRifle",
		"creature\\Faceless\\FacelessSoldier-EnergyPistol",
		"creature\\Faceless\\FacelessSoldier-Sledgehammer",
		"creature\\Faceless\\FacelessSoldier-Smg",
		"creatures\\Faceless\\FacelessDoctor",
		"creatures\\Faceless\\FacelessDoctor",
		"creatures\\Faceless\\FacelessCentaur",
		"creatures\\Faceless\\FacelessCentaur",
		"creatures\\Faceless\\FacelessMindreader",
		"creatures\\Faceless\\FacelessMindreader",
		"creatures\\Faceless\\AugmentedRathound",
		"creatures\\Faceless\\AugmentedRathound"
	};

	// Token: 0x04002142 RID: 8514
	private static readonly TimeSpan b = TimeSpan.FromMinutes(20.0);

	// Token: 0x04002143 RID: 8515
	private TimeSpan? c;

	// Token: 0x04002144 RID: 8516
	private string d;

	// Token: 0x04002145 RID: 8517
	private int e;

	// Token: 0x04002146 RID: 8518
	private int f;

	// Token: 0x04002147 RID: 8519
	private List<Guid> g = new List<Guid>();

	// Token: 0x04002148 RID: 8520
	private bool h;

	// Token: 0x04002149 RID: 8521
	private int i;

	// Token: 0x0400214A RID: 8522
	private List<ar7> j;

	// Token: 0x0400214B RID: 8523
	private TimeSpan? k;

	// Token: 0x0400214C RID: 8524
	private TimeSpan? l;

	// Token: 0x0400214D RID: 8525
	private double m;

	// Token: 0x0400214E RID: 8526
	private int n;
}
