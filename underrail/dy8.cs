using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules;

// Token: 0x02000F6E RID: 3950
[eiz("ICEA")]
[Serializable]
public abstract class dy8 : Aspect<c5x>, c98, chb
{
	// Token: 0x0600502E RID: 20526 RVA: 0x0023F1B8 File Offset: 0x0023D3B8
	protected dy8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = A_0.GetInt32("ICEA:T");
		this.b = A_0.GetDouble("ICEA:C");
		this.d = A_0.GetBoolean("ICEA:A");
		this.e = (A_0.GetValue("ICEA:E", typeof(TimeSpan?)) as TimeSpan?);
		this.f = (A_0.GetValue("ICEA:O", typeof(TimeSpan?)) as TimeSpan?);
		this.g = (TimeSpan)A_0.GetValue("ICEA:M", typeof(TimeSpan));
		this.h = (TimeSpan)A_0.GetValue("ICEA:L", typeof(TimeSpan));
		this.i = (TimeSpan)A_0.GetValue("ICEA:D", typeof(TimeSpan));
		this.j = A_0.GetDouble("ICEA:R");
		this.l = A_0.GetString("ICEA:S");
		if (ell.a() >= 290)
		{
			di7.ReadList<Guid>("ICEA:I", ref this.k, A_0);
			if (this.k == null)
			{
				this.k = new List<Guid>();
			}
		}
		else
		{
			Guid item = (Guid)A_0.GetValue("ICEA:I", typeof(Guid));
			this.k = new List<Guid>();
			this.k.Add(item);
		}
		if (ell.a() >= 291)
		{
			this.m = (A_0.GetValue("ICEA:X", typeof(Guid?)) as Guid?);
		}
	}

	// Token: 0x0600502F RID: 20527 RVA: 0x0023F3C4 File Offset: 0x0023D5C4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ICEA:T", this.c);
		info.AddValue("ICEA:C", this.b);
		info.AddValue("ICEA:A", this.d);
		info.AddValue("ICEA:E", this.e);
		info.AddValue("ICEA:O", this.f);
		info.AddValue("ICEA:M", this.g);
		info.AddValue("ICEA:L", this.h);
		info.AddValue("ICEA:D", this.i);
		info.AddValue("ICEA:R", this.j);
		info.AddValue("ICEA:S", this.l);
		info.AddValue("ICEA:X", this.m);
		di7.WriteList<Guid>("ICEA:I", this.k, info);
	}

	// Token: 0x06005030 RID: 20528 RVA: 0x0023F4C4 File Offset: 0x0023D6C4
	public TimeSpan f()
	{
		return this.g;
	}

	// Token: 0x06005031 RID: 20529 RVA: 0x0023F4CC File Offset: 0x0023D6CC
	public void b(TimeSpan A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06005032 RID: 20530 RVA: 0x0023F4D8 File Offset: 0x0023D6D8
	public TimeSpan k()
	{
		return this.h;
	}

	// Token: 0x06005033 RID: 20531 RVA: 0x0023F4E0 File Offset: 0x0023D6E0
	public void c(TimeSpan A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06005034 RID: 20532 RVA: 0x0023F4EC File Offset: 0x0023D6EC
	public TimeSpan l()
	{
		return this.i;
	}

	// Token: 0x06005035 RID: 20533 RVA: 0x0023F4F4 File Offset: 0x0023D6F4
	public void a(TimeSpan A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06005036 RID: 20534 RVA: 0x0023F500 File Offset: 0x0023D700
	public double g()
	{
		return this.j;
	}

	// Token: 0x06005037 RID: 20535 RVA: 0x0023F508 File Offset: 0x0023D708
	public void a(double A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06005038 RID: 20536 RVA: 0x0023F514 File Offset: 0x0023D714
	public List<Guid> j()
	{
		return this.k;
	}

	// Token: 0x06005039 RID: 20537 RVA: 0x0023F51C File Offset: 0x0023D71C
	public void f(List<Guid> A_0)
	{
		this.k = A_0;
	}

	// Token: 0x0600503A RID: 20538 RVA: 0x0023F528 File Offset: 0x0023D728
	public string i()
	{
		return this.l;
	}

	// Token: 0x0600503B RID: 20539 RVA: 0x0023F530 File Offset: 0x0023D730
	public void b(string A_0)
	{
		this.l = A_0;
	}

	// Token: 0x0600503C RID: 20540 RVA: 0x0023F53C File Offset: 0x0023D73C
	public Guid? m()
	{
		return this.m;
	}

	// Token: 0x0600503D RID: 20541 RVA: 0x0023F544 File Offset: 0x0023D744
	public void a(Guid? A_0)
	{
		this.m = A_0;
	}

	// Token: 0x0600503E RID: 20542 RVA: 0x0023F550 File Offset: 0x0023D750
	public dy8(c5x A_0) : base(A_0)
	{
		this.b = 0.0;
	}

	// Token: 0x0600503F RID: 20543 RVA: 0x0023F5CC File Offset: 0x0023D7CC
	public void r7(eds A_0)
	{
		if (this.d && !dz6.e())
		{
			if ((this.b -= A_0.b.TotalMilliseconds) <= 0.0)
			{
				this.b += (double)d0u.b;
				this.a(false);
				return;
			}
		}
		else
		{
			this.b = (double)d0u.b;
		}
	}

	// Token: 0x06005040 RID: 20544 RVA: 0x0023F640 File Offset: 0x0023D840
	public void c()
	{
		if (this.d)
		{
			this.a(true);
		}
	}

	// Token: 0x06005041 RID: 20545 RVA: 0x0023F658 File Offset: 0x0023D858
	public void h()
	{
		if (!this.d && !this.a())
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_dc_irisStatus");
				if (classPropertyValue != "converted" && classPropertyValue != "disabled")
				{
					if (this.f != null && this.f.Value > serviceOrThrow.aqu().o())
					{
						return;
					}
					TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>(dy8.a, null);
					if (primitivePropertyValue != null && primitivePropertyValue.Value > serviceOrThrow.aqu().o())
					{
						return;
					}
					if (cuo.a.NextDouble() < this.j)
					{
						this.e();
						return;
					}
					this.f = new TimeSpan?(serviceOrThrow.aqu().o() + this.g);
				}
			}
		}
	}

	// Token: 0x06005042 RID: 20546
	protected abstract void o2();

	// Token: 0x06005043 RID: 20547
	protected abstract void o3();

	// Token: 0x06005044 RID: 20548
	protected abstract void o4();

	// Token: 0x06005045 RID: 20549 RVA: 0x0023F778 File Offset: 0x0023D978
	protected void h(List<Guid> A_0)
	{
		foreach (Guid a_ in A_0)
		{
			c5x c5x = new ar7(a_, base.a8().Area).ao() as c5x;
			if (c5x != null)
			{
				cnb cnb = c5x.s.b as cnb;
				if (cnb != null)
				{
					if (!cnb.q())
					{
						d2b aspect = c5x.GetAspect<d2b>();
						if (aspect != null && aspect.n())
						{
							aspect.a(true, true);
						}
					}
				}
				else if (c5x.o.b != null)
				{
					if (c5x.o.b.a != null)
					{
						if (c5x.o.b.a.StartsWith("Doors\\SciFiRollGate", StringComparison.OrdinalIgnoreCase))
						{
							b6x b6x = new b6x();
							b6x.a(base.a8().Area.y8());
							b6x.a(bbo.b);
							b6x.c().Add(c5x.qe());
							b6x.ym(base.a8(), null, null);
						}
						else if (c5x.o.b.a.StartsWith("Doors\\WarehouseGate", StringComparison.OrdinalIgnoreCase))
						{
							crx crx = new crx();
							crx.a(base.a8().Area.y8());
							crx.a(bbo.b);
							crx.c().Add(c5x.qe());
							crx.ym(base.a8(), null, null);
						}
					}
				}
				else if (c5x.p.b != null && c5x.p.b.a.Count == 2 && c5x.p.b.a[0].a != null && c5x.p.b.a[0].a.StartsWith("Doors\\SciFiRollGate"))
				{
					esv esv = new esv();
					esv.a(base.a8().Area.y8());
					esv.a(bbo.b);
					esv.c().Add(c5x.qe());
					esv.ym(base.a8(), null, null);
				}
			}
		}
	}

	// Token: 0x06005046 RID: 20550 RVA: 0x0023F9E0 File Offset: 0x0023DBE0
	protected void g(List<Guid> A_0)
	{
		foreach (Guid a_ in A_0)
		{
			c5x c5x = new ar7(a_, base.a8().Area).ao() as c5x;
			if (c5x != null)
			{
				cnb cnb = c5x.s.b as cnb;
				if (cnb != null)
				{
					if (cnb.q())
					{
						cnb.a(null, null, false, false);
					}
					if (!cnb.q())
					{
						d2b aspect = c5x.GetAspect<d2b>();
						if (aspect != null && !aspect.n())
						{
							aspect.b(true, true);
						}
					}
				}
				else if (c5x.o.b != null)
				{
					if (c5x.o.b.a != null)
					{
						if (c5x.o.b.a.StartsWith("Doors\\SciFiRollGate", StringComparison.OrdinalIgnoreCase))
						{
							b6x b6x = new b6x();
							b6x.a(base.a8().Area.y8());
							b6x.a(bbo.c);
							b6x.c().Add(c5x.qe());
							b6x.ym(base.a8(), null, null);
						}
						else if (c5x.o.b.a.StartsWith("Doors\\WarehouseGate", StringComparison.OrdinalIgnoreCase))
						{
							crx crx = new crx();
							crx.a(base.a8().Area.y8());
							crx.a(bbo.c);
							crx.c().Add(c5x.qe());
							crx.ym(base.a8(), null, null);
						}
					}
				}
				else if (c5x.p.b != null && c5x.p.b.a.Count == 2 && c5x.p.b.a[0].a != null && c5x.p.b.a[0].a.StartsWith("Doors\\SciFiRollGate"))
				{
					esv esv = new esv();
					esv.a(base.a8().Area.y8());
					esv.a(bbo.c);
					esv.c().Add(c5x.qe());
					esv.ym(base.a8(), null, null);
				}
			}
		}
	}

	// Token: 0x06005047 RID: 20551 RVA: 0x0023FC60 File Offset: 0x0023DE60
	private void e()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().r()[dy8.a] = serviceOrThrow.aqu().o() + this.i + TimeSpan.FromSeconds(10.0);
			this.e = new TimeSpan?(serviceOrThrow.aqu().o() + this.i);
			this.d = true;
			foreach (Guid a_ in this.k)
			{
				c0s c0s = new EntityAspectReference<c0s, c0s>(base.a8().Area, a_).ao();
				if (c0s != null)
				{
					c0s.a(this.l, true, null, null);
				}
			}
			this.o2();
		}
	}

	// Token: 0x06005048 RID: 20552 RVA: 0x0023FD74 File Offset: 0x0023DF74
	private void d()
	{
		this.o3();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			this.f = new TimeSpan?(serviceOrThrow.aqu().o() + this.b());
		}
		this.d = false;
	}

	// Token: 0x06005049 RID: 20553 RVA: 0x0023FDC0 File Offset: 0x0023DFC0
	private TimeSpan b()
	{
		double num;
		switch (bpo.GetServiceOrThrow<bu6>().aq2())
		{
		case GameDifficulty.Easy:
			num = 2.0;
			goto IL_67;
		case GameDifficulty.Hard:
			num = 0.66;
			goto IL_67;
		case GameDifficulty.Dominating:
			num = 0.33;
			goto IL_67;
		}
		num = 1.0;
		IL_67:
		return TimeSpan.FromSeconds(this.h.TotalSeconds * num);
	}

	// Token: 0x0600504A RID: 20554 RVA: 0x0023FE48 File Offset: 0x0023E048
	private void a(bool A_0 = false)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_dc_irisStatus");
			if (this.e == null || serviceOrThrow.aqu().o() > this.e.Value || (classPropertyValue != "converted" && classPropertyValue == "disabled"))
			{
				this.d();
				return;
			}
			this.o4();
		}
	}

	// Token: 0x0600504B RID: 20555 RVA: 0x0023FEDC File Offset: 0x0023E0DC
	private bool a()
	{
		if (this.m != null)
		{
			c5x c5x = new ar7(this.m.Value, base.a8().Area).ao() as c5x;
			if (c5x != null && c5x.t.b != null)
			{
				EntityAspectReference<amc, amc> classPropertyValue = c5x.t.b.y6().GetClassPropertyValue<EntityAspectReference<amc, amc>>(ddq.f);
				return classPropertyValue == null || classPropertyValue.ao() == null || classPropertyValue.ao().a8() == null || !classPropertyValue.ao().a8().IsPlayer;
			}
		}
		return false;
	}

	// Token: 0x040020B0 RID: 8368
	private static readonly string a = "global_irisChallenge_nextTriggerTime";

	// Token: 0x040020B1 RID: 8369
	private double b;

	// Token: 0x040020B2 RID: 8370
	private int c;

	// Token: 0x040020B3 RID: 8371
	private bool d;

	// Token: 0x040020B4 RID: 8372
	private TimeSpan? e;

	// Token: 0x040020B5 RID: 8373
	private TimeSpan? f;

	// Token: 0x040020B6 RID: 8374
	private TimeSpan g = TimeSpan.FromSeconds(20.0);

	// Token: 0x040020B7 RID: 8375
	private TimeSpan h = TimeSpan.FromMinutes(15.0);

	// Token: 0x040020B8 RID: 8376
	private TimeSpan i = TimeSpan.FromMinutes(3.0);

	// Token: 0x040020B9 RID: 8377
	private double j = 0.5;

	// Token: 0x040020BA RID: 8378
	private List<Guid> k = new List<Guid>();

	// Token: 0x040020BB RID: 8379
	private string l;

	// Token: 0x040020BC RID: 8380
	private Guid? m;
}
