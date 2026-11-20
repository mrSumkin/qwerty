using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules;

// Token: 0x02001290 RID: 4752
[eiz("XPCEA")]
[Serializable]
public sealed class ehi : Aspect<c5x>, c98, chb
{
	// Token: 0x0600678B RID: 26507 RVA: 0x002BE4E0 File Offset: 0x002BC6E0
	private ehi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.p = A_0.GetInt32("XPCEA:T");
		this.o = A_0.GetDouble("XPCEA:C");
		this.m = (A_0.GetValue("XPCEA:N", typeof(TimeSpan?)) as TimeSpan?);
		this.a = (TimeSpan)A_0.GetValue("XPCEA:V", typeof(TimeSpan));
		this.c = A_0.GetString("XPCEA:P");
		this.d = A_0.GetInt32("XPCEA:H");
		this.e = A_0.GetInt32("XPCEA:S");
		this.f = A_0.GetInt32("XPCEA:EM");
		this.g = A_0.GetInt32("XPCEA:HM");
		this.h = A_0.GetInt32("XPCEA:DM");
		this.j = A_0.GetBoolean("XPCEA:A");
		this.k = A_0.GetInt32("XPCEA:R");
		di7.ReadList<ar7>("XPCEA:E", ref this.l, A_0);
		di7.ReadList<Guid>("XPCEA:L", ref this.i, A_0);
		this.b = (A_0.GetValue("XPCEA:D", typeof(TimeSpan?)) as TimeSpan?);
		this.n = (A_0.GetValue("XPCEA:U", typeof(TimeSpan?)) as TimeSpan?);
		this.q = A_0.GetString("XPCEA:I");
		this.t = (A_0.GetValue("XPCEA:X", typeof(c13)) as c13);
		this.u = (l9)A_0.GetValue("XPCEA:TT", typeof(l9));
		if (ell.a() >= 475)
		{
			this.r = A_0.GetString("XPCEA:Y");
			this.s = (A_0.GetValue("XPCEA:Z", typeof(int?)) as int?);
		}
	}

	// Token: 0x0600678C RID: 26508 RVA: 0x002BE71C File Offset: 0x002BC91C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPCEA:T", this.p);
		info.AddValue("XPCEA:C", this.o);
		info.AddValue("XPCEA:N", this.m);
		info.AddValue("XPCEA:V", this.a);
		info.AddValue("XPCEA:P", this.c);
		info.AddValue("XPCEA:H", this.d);
		info.AddValue("XPCEA:S", this.e);
		info.AddValue("XPCEA:EM", this.f);
		info.AddValue("XPCEA:HM", this.g);
		info.AddValue("XPCEA:DM", this.h);
		info.AddValue("XPCEA:A", this.j);
		info.AddValue("XPCEA:R", this.k);
		info.AddValue("XPCEA:D", this.b);
		info.AddValue("XPCEA:U", this.n);
		di7.WriteList<ar7>("XPCEA:E", this.l, info);
		di7.WriteList<Guid>("XPCEA:L", this.i, info);
		info.AddValue("XPCEA:I", this.q);
		info.AddValue("XPCEA:X", this.t);
		info.AddValue("XPCEA:TT", this.u);
		info.AddValue("XPCEA:Y", this.r);
		info.AddValue("XPCEA:Z", this.s);
	}

	// Token: 0x0600678D RID: 26509 RVA: 0x002BE8B4 File Offset: 0x002BCAB4
	public bool m()
	{
		return this.j;
	}

	// Token: 0x0600678E RID: 26510 RVA: 0x002BE8BC File Offset: 0x002BCABC
	public TimeSpan q()
	{
		return this.a;
	}

	// Token: 0x0600678F RID: 26511 RVA: 0x002BE8C4 File Offset: 0x002BCAC4
	public void a(TimeSpan A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006790 RID: 26512 RVA: 0x002BE8D0 File Offset: 0x002BCAD0
	public TimeSpan? h()
	{
		return this.b;
	}

	// Token: 0x06006791 RID: 26513 RVA: 0x002BE8D8 File Offset: 0x002BCAD8
	public void a(TimeSpan? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006792 RID: 26514 RVA: 0x002BE8E4 File Offset: 0x002BCAE4
	public string j()
	{
		return this.c;
	}

	// Token: 0x06006793 RID: 26515 RVA: 0x002BE8EC File Offset: 0x002BCAEC
	public void c(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006794 RID: 26516 RVA: 0x002BE8F8 File Offset: 0x002BCAF8
	public int l()
	{
		return this.d;
	}

	// Token: 0x06006795 RID: 26517 RVA: 0x002BE900 File Offset: 0x002BCB00
	public void e(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006796 RID: 26518 RVA: 0x002BE90C File Offset: 0x002BCB0C
	public int o()
	{
		return this.e;
	}

	// Token: 0x06006797 RID: 26519 RVA: 0x002BE914 File Offset: 0x002BCB14
	public void c(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006798 RID: 26520 RVA: 0x002BE920 File Offset: 0x002BCB20
	public int t()
	{
		return this.f;
	}

	// Token: 0x06006799 RID: 26521 RVA: 0x002BE928 File Offset: 0x002BCB28
	public void b(int A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600679A RID: 26522 RVA: 0x002BE934 File Offset: 0x002BCB34
	public int p()
	{
		return this.g;
	}

	// Token: 0x0600679B RID: 26523 RVA: 0x002BE93C File Offset: 0x002BCB3C
	public void d(int A_0)
	{
		this.g = A_0;
	}

	// Token: 0x0600679C RID: 26524 RVA: 0x002BE948 File Offset: 0x002BCB48
	public int i()
	{
		return this.h;
	}

	// Token: 0x0600679D RID: 26525 RVA: 0x002BE950 File Offset: 0x002BCB50
	public void f(int A_0)
	{
		this.h = A_0;
	}

	// Token: 0x0600679E RID: 26526 RVA: 0x002BE95C File Offset: 0x002BCB5C
	public string k()
	{
		return this.q;
	}

	// Token: 0x0600679F RID: 26527 RVA: 0x002BE964 File Offset: 0x002BCB64
	public void a(string A_0)
	{
		this.q = A_0;
	}

	// Token: 0x060067A0 RID: 26528 RVA: 0x002BE970 File Offset: 0x002BCB70
	public string s()
	{
		return this.r;
	}

	// Token: 0x060067A1 RID: 26529 RVA: 0x002BE978 File Offset: 0x002BCB78
	public void b(string A_0)
	{
		this.r = A_0;
	}

	// Token: 0x060067A2 RID: 26530 RVA: 0x002BE984 File Offset: 0x002BCB84
	public int? n()
	{
		return this.s;
	}

	// Token: 0x060067A3 RID: 26531 RVA: 0x002BE98C File Offset: 0x002BCB8C
	public void a(int? A_0)
	{
		this.s = A_0;
	}

	// Token: 0x060067A4 RID: 26532 RVA: 0x002BE998 File Offset: 0x002BCB98
	public l9 r()
	{
		return this.u;
	}

	// Token: 0x060067A5 RID: 26533 RVA: 0x002BE9A0 File Offset: 0x002BCBA0
	public void a(l9 A_0)
	{
		this.u = A_0;
	}

	// Token: 0x060067A6 RID: 26534 RVA: 0x002BE9AC File Offset: 0x002BCBAC
	public c13 g()
	{
		return this.t;
	}

	// Token: 0x060067A7 RID: 26535 RVA: 0x002BE9B4 File Offset: 0x002BCBB4
	public void a(c13 A_0)
	{
		this.t = A_0;
	}

	// Token: 0x060067A8 RID: 26536 RVA: 0x002BE9C0 File Offset: 0x002BCBC0
	public ehi(c5x A_0) : base(A_0)
	{
		this.o = 0.0;
	}

	// Token: 0x060067A9 RID: 26537 RVA: 0x002BEA18 File Offset: 0x002BCC18
	public void r7(eds A_0)
	{
		if (!dz6.e())
		{
			if ((this.o -= A_0.b.TotalMilliseconds) <= 0.0)
			{
				this.o += (double)d0u.b;
				this.a(false);
				return;
			}
		}
		else
		{
			this.o = (double)d0u.b;
		}
	}

	// Token: 0x060067AA RID: 26538 RVA: 0x002BEA80 File Offset: 0x002BCC80
	public void c()
	{
		if (this.j)
		{
			this.a(true);
		}
	}

	// Token: 0x060067AB RID: 26539 RVA: 0x002BEA98 File Offset: 0x002BCC98
	private void a(bool A_0 = false)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bool flag = !string.IsNullOrEmpty(this.q) && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(this.q, new bool?(false)).Value;
			if (!flag && !string.IsNullOrEmpty(this.r) && this.s != null)
			{
				int? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(this.r, null);
				if (primitivePropertyValue != null)
				{
					int? num = primitivePropertyValue;
					int value = this.s.Value;
					if (num.GetValueOrDefault() > value & num != null)
					{
						flag = true;
					}
				}
			}
			if (!this.j)
			{
				if (!flag)
				{
					if (this.m == null)
					{
						this.a(serviceOrThrow, true);
						return;
					}
					if (this.m.Value <= serviceOrThrow.aqu().o())
					{
						if ((double)((int)(serviceOrThrow.aqu().o() - this.m.Value).TotalSeconds % (int)this.q().TotalSeconds) / this.q().TotalSeconds > 0.25)
						{
							this.a(serviceOrThrow, false);
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

	// Token: 0x060067AC RID: 26540 RVA: 0x002BEC24 File Offset: 0x002BCE24
	private void f()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() == null)
		{
			return;
		}
		if (this.l == null)
		{
			this.e();
			return;
		}
		int num = 0;
		bool flag = true;
		bool flag2 = false;
		for (int i = 0; i < this.l.Count; i++)
		{
			c5x c5x = this.l[i].ao() as c5x;
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
							aud aud;
							Vector3 a_;
							classPropertyValue.a(c5x.Zone, out aud, out a_);
							if (aud != null)
							{
								ak1 ak = aud.a(a_.a());
								if (ak != null && aw1.a(ak, false, null, this.u) && aw1.a(c5x, ak) <= 4.0)
								{
									goto IL_137;
								}
							}
							flag = false;
							break;
						}
					}
				}
			}
			IL_137:;
		}
		if (num == 0)
		{
			this.e();
			return;
		}
		if (flag && this.k < this.d)
		{
			if (this.b != null)
			{
				if (this.n == null || flag2)
				{
					this.n = new TimeSpan?(serviceOrThrow.aqu().o() + this.b.Value);
					return;
				}
				if (this.n.Value > serviceOrThrow.aqu().o())
				{
					return;
				}
			}
			this.a(this.k + 1);
		}
	}

	// Token: 0x060067AD RID: 26541 RVA: 0x002BEE20 File Offset: 0x002BD020
	private void e()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		this.l = null;
		this.j = false;
		this.n = null;
		this.a(serviceOrThrow, false);
	}

	// Token: 0x060067AE RID: 26542 RVA: 0x002BEE58 File Offset: 0x002BD058
	private void d()
	{
		foreach (Guid a_ in this.i)
		{
			ehi ehi = new EntityAspectReference<ehi, ehi>(base.a8().Area, a_).ao();
			if (ehi != null && ehi.m())
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
			csd csd = base.a8().Zone.g(string.Format("{0}_0_{1}", this.c, i));
			if (csd == null || aw1.a(csd.Tile, false, null, this.u) || this.a(a_2, csd.Tile))
			{
				return;
			}
			list.Add(csd);
		}
		this.j = true;
		this.l = new List<ar7>();
		List<c5x> list2 = this.t.ok(this.c, list);
		int num2 = 0;
		while (num2 < list.Count && list2 != null && num2 < list2.Count)
		{
			csd csd2 = list[num2];
			c5x c5x = list2[num2];
			if (c5x != null)
			{
				this.l.Add(new ar7(c5x));
				if (c5x != null)
				{
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
			num2++;
		}
		this.a(1);
	}

	// Token: 0x060067AF RID: 26543 RVA: 0x002BF0A0 File Offset: 0x002BD2A0
	private int b()
	{
		int num = this.e;
		bu6 service = bpo.GetService<bu6>();
		if (service != null)
		{
			if (service.aq2() == GameDifficulty.Easy)
			{
				num += this.f;
			}
			else if (service.aq2() == GameDifficulty.Hard)
			{
				num += this.g;
			}
			else if (service.aq2() == GameDifficulty.Dominating)
			{
				num += this.h;
			}
		}
		return num;
	}

	// Token: 0x060067B0 RID: 26544 RVA: 0x002BF10C File Offset: 0x002BD30C
	private void a(int A_0)
	{
		this.k = A_0;
		if (this.l != null)
		{
			for (int i = 0; i < this.l.Count; i++)
			{
				c5x c5x = this.l[i].ao() as c5x;
				if (c5x != null && c5x.t.b != null)
				{
					c5x.t.b.y6()[ddq.ay] = new bt4(string.Format("{0}_{1}_{2}", this.c, A_0, i + 1));
					if (this.d == A_0)
					{
						c5x.t.b.y6()[ddq.bg] = true;
					}
				}
			}
		}
	}

	// Token: 0x060067B1 RID: 26545 RVA: 0x002BF1E0 File Offset: 0x002BD3E0
	private string a()
	{
		return "Patrol_" + this.c;
	}

	// Token: 0x060067B2 RID: 26546 RVA: 0x002BF1F4 File Offset: 0x002BD3F4
	private void a(cnk A_0, bool A_1 = false)
	{
		if (A_1)
		{
			this.m = new TimeSpan?(A_0.aqu().o() + TimeSpan.FromSeconds(this.q().TotalSeconds * (-0.5 + cuo.a.NextDouble())));
			return;
		}
		this.m = new TimeSpan?(A_0.aqu().o() + this.q() - TimeSpan.FromMinutes(1.0) + TimeSpan.FromSeconds((double)cuo.a.Next(120)));
	}

	// Token: 0x060067B3 RID: 26547 RVA: 0x002BF298 File Offset: 0x002BD498
	private bool a(bm6 A_0, ak1 A_1)
	{
		return A_0 != null && A_0.ai() && A_0.a(A_1);
	}

	// Token: 0x04002AD3 RID: 10963
	private TimeSpan a = TimeSpan.FromMinutes(5.0);

	// Token: 0x04002AD4 RID: 10964
	private TimeSpan? b;

	// Token: 0x04002AD5 RID: 10965
	private string c;

	// Token: 0x04002AD6 RID: 10966
	private int d;

	// Token: 0x04002AD7 RID: 10967
	private int e;

	// Token: 0x04002AD8 RID: 10968
	private int f = -1;

	// Token: 0x04002AD9 RID: 10969
	private int g = 1;

	// Token: 0x04002ADA RID: 10970
	private int h = 2;

	// Token: 0x04002ADB RID: 10971
	private List<Guid> i = new List<Guid>();

	// Token: 0x04002ADC RID: 10972
	private bool j;

	// Token: 0x04002ADD RID: 10973
	private int k;

	// Token: 0x04002ADE RID: 10974
	private List<ar7> l;

	// Token: 0x04002ADF RID: 10975
	private TimeSpan? m;

	// Token: 0x04002AE0 RID: 10976
	private TimeSpan? n;

	// Token: 0x04002AE1 RID: 10977
	private double o;

	// Token: 0x04002AE2 RID: 10978
	private int p;

	// Token: 0x04002AE3 RID: 10979
	private string q;

	// Token: 0x04002AE4 RID: 10980
	private string r;

	// Token: 0x04002AE5 RID: 10981
	private int? s;

	// Token: 0x04002AE6 RID: 10982
	private c13 t;

	// Token: 0x04002AE7 RID: 10983
	private l9 u;
}
