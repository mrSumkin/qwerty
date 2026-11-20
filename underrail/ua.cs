using System;
using System.Collections.Generic;

// Token: 0x0200034E RID: 846
public class ua : pd, el7
{
	// Token: 0x060017EF RID: 6127 RVA: 0x000794F4 File Offset: 0x000776F4
	public override bm6 lu()
	{
		return this.a;
	}

	// Token: 0x060017F0 RID: 6128 RVA: 0x000794FC File Offset: 0x000776FC
	public ua(string A_0, bm6 A_1) : base(A_0)
	{
		this.a = A_1;
	}

	// Token: 0x060017F1 RID: 6129 RVA: 0x0007950C File Offset: 0x0007770C
	public virtual void lv(b0b A_0)
	{
	}

	// Token: 0x060017F2 RID: 6130 RVA: 0x00079510 File Offset: 0x00077710
	public override bool acj(TimeSpan A_0, double A_1)
	{
		return true;
	}

	// Token: 0x060017F3 RID: 6131 RVA: 0x00079514 File Offset: 0x00077714
	public override float km(bool A_0)
	{
		return 1f;
	}

	// Token: 0x060017F4 RID: 6132 RVA: 0x0007951C File Offset: 0x0007771C
	public bool lw(Guid A_0)
	{
		return new bzv(this.Subject.y6()).a(A_0);
	}

	// Token: 0x060017F5 RID: 6133 RVA: 0x00079534 File Offset: 0x00077734
	public bool lx(Guid A_0)
	{
		return new bzv(this.Subject.y6()).e(A_0);
	}

	// Token: 0x060017F6 RID: 6134 RVA: 0x0007954C File Offset: 0x0007774C
	public erl ly(Guid A_0)
	{
		return new bzv(this.Subject.y6()).d(A_0);
	}

	// Token: 0x060017F7 RID: 6135 RVA: 0x00079568 File Offset: 0x00077768
	public List<b0b> lz()
	{
		List<b0b> list = new List<b0b>();
		foreach (blk blk in new bzv(this.Subject.y6()).b())
		{
			if (blk.e() != null && blk.e().a8() != null && this.l3(blk.e().a8().qe()))
			{
				list.Add(blk.e().a8());
			}
		}
		return list;
	}

	// Token: 0x060017F8 RID: 6136 RVA: 0x00079614 File Offset: 0x00077814
	public void l0(Guid A_0)
	{
		new bzv(this.Subject.y6()).b(A_0);
	}

	// Token: 0x060017F9 RID: 6137 RVA: 0x0007962C File Offset: 0x0007782C
	public void l1()
	{
		foreach (blk blk in new bzv(this.Subject.y6()).b())
		{
			if (blk.a().f() > cem.c)
			{
				blk.a().a(cem.c);
				blk.a().a(aiy.b3[cem.c] / 2.0);
			}
			else if (blk.a().f() == cem.c)
			{
				blk.a().a(0.0);
			}
		}
	}

	// Token: 0x060017FA RID: 6138 RVA: 0x000796F4 File Offset: 0x000778F4
	public void l2()
	{
		foreach (blk blk in new bzv(this.Subject.y6()).b())
		{
			blk.a(false);
		}
	}

	// Token: 0x060017FB RID: 6139 RVA: 0x00079758 File Offset: 0x00077958
	public bool l3(Guid A_0)
	{
		blk blk = new bzv(this.Subject.y6()).c(A_0);
		return blk != null && blk.a().f() == cem.d && blk.f() == global::h.a;
	}

	// Token: 0x060017FC RID: 6140 RVA: 0x000797A0 File Offset: 0x000779A0
	public bool l4(Guid A_0)
	{
		blk blk = new bzv(this.Subject.y6()).c(A_0);
		return blk != null && blk.a().f() >= cem.c && blk.f() == global::h.a;
	}

	// Token: 0x060017FD RID: 6141 RVA: 0x000797E8 File Offset: 0x000779E8
	public void l5(object A_0, bool A_1)
	{
		amc amc = A_0 as amc;
		if (amc != null && amc.a8() != null)
		{
			bzv bzv = new bzv(this.Subject.y6());
			blk blk = bzv.c(amc.a8().qe());
			if (blk != null)
			{
				blk.a(global::h.a);
				if (A_1)
				{
					blk.a().b();
					return;
				}
			}
			else
			{
				blk = new blk(amc, global::h.a);
				if (A_1)
				{
					blk.a().b();
				}
				bzv.a(amc.a8().qe(), blk);
			}
		}
	}

	// Token: 0x060017FE RID: 6142 RVA: 0x0007987C File Offset: 0x00077A7C
	public void l6(oj A_0, object A_1)
	{
		if (A_0 != null && this.Subject.a8() != null && this.Subject.a8().t.b != null)
		{
			amc amc = A_1 as amc;
			if (amc != null && amc.a8() != null && amc.a8().t.b != null)
			{
				h? h = A_0.abz(amc.aa().FactionId, this.Subject.a8().h.b.aa().FactionId);
				h h2 = global::h.a;
				if (h.GetValueOrDefault() == h2 & h != null)
				{
					bzv bzv = new bzv(this.Subject.y6());
					bzv bzv2 = new bzv(amc.a8().t.b.y6());
					foreach (blk blk in bzv.b())
					{
						if (blk != null && blk.f() == global::h.a && blk.a().f() > cem.b && blk.d().ao() != null && blk.d().ao().a8() != null && amc.aa().FactionId != blk.d().ao().aa().FactionId)
						{
							blk blk2 = bzv2.c(blk.d().ao().a8().qe());
							cem cem = blk.a().f();
							double num = blk.a().c() - 10.0;
							if (num < 0.0)
							{
								if (cem == cem.c)
								{
									continue;
								}
								cem--;
								num = aiy.b3[cem] - 10.0;
							}
							if (blk2 == null || blk2.a().f() < cem || (blk2.a().f() == cem && blk2.a().c() < num))
							{
								blk blk3 = blk.c();
								blk3.a().a(cem);
								blk3.a().a(num);
								bzv2.a(blk.d().ao().a8().qe(), blk3);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060017FF RID: 6143 RVA: 0x00079B28 File Offset: 0x00077D28
	public T GetGlobalProperty<T>(string propName, T defaultValue = default(T))
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			object propertyValue = serviceOrThrow.aqu().r().GetPropertyValue(propName);
			if (propertyValue is T)
			{
				return (T)((object)propertyValue);
			}
		}
		return defaultValue;
	}

	// Token: 0x06001800 RID: 6144 RVA: 0x00079B6C File Offset: 0x00077D6C
	public T GetCortexProperty<T>(string propName, T defaultValue = default(T))
	{
		object propertyValue = this.Subject.y6().GetPropertyValue(propName);
		if (propertyValue is T)
		{
			return (T)((object)propertyValue);
		}
		return defaultValue;
	}

	// Token: 0x06001801 RID: 6145 RVA: 0x00079BA0 File Offset: 0x00077DA0
	public void a(string A_0, object A_1)
	{
		this.Subject.y6()[A_0] = A_1;
	}

	// Token: 0x04000E1D RID: 3613
	private new bm6 a;
}
