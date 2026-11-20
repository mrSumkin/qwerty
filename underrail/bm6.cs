using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Ouroboros.Common.Aspects;
using Ouroboros.Common.Data;
using Ouroboros.Core.Logging;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001317 RID: 4887
[eiz("IEA")]
[Serializable]
public sealed class bm6 : Aspect<c5x>, bp1, c98, cte, ISerializable
{
	// Token: 0x06006DA7 RID: 28071 RVA: 0x002DCFE0 File Offset: 0x002DB1E0
	private bm6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.f = (PropertyCollection)A_0.GetValue("IEA:C", typeof(PropertyCollection));
		this.g = A_0.GetString("IEA:B");
		di7.ReadList<dkv>("IEA:S", ref this.j, A_0);
		this.k = A_0.GetInt32("IEA:PSI");
		this.l = A_0.GetInt32("IEA:GSI");
		this.m = A_0.GetInt32("IEA:RI");
		di7.ReadList<string>("IEA:CBP", ref this.w, A_0);
		this.x = (e7i)A_0.GetValue("IEA:WC", typeof(e7i));
		this.y = A_0.GetBoolean("IEA:WQFS");
		this.z = A_0.GetBoolean("IEA:WII");
		if (ell.a() >= 58)
		{
			this.h = A_0.GetString("IEA:T");
		}
		if (ell.a() >= 149)
		{
			this.ac = A_0.GetBoolean("IEA:E");
		}
		else
		{
			this.ac = true;
		}
		if (ell.a() >= 168)
		{
			this.i = (PropertyCollection)A_0.GetValue("IEA:TP", typeof(PropertyCollection));
		}
		else
		{
			this.i = new PropertyCollection();
		}
		if (ell.a() >= 243)
		{
			this.ad = A_0.GetString("IEA:CS");
		}
	}

	// Token: 0x06006DA8 RID: 28072 RVA: 0x002DD1A4 File Offset: 0x002DB3A4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("IEA:C", this.f);
		info.AddValue("IEA:B", this.g);
		di7.WriteList<dkv>("IEA:S", this.j, info);
		info.AddValue("IEA:PSI", this.k);
		info.AddValue("IEA:GSI", this.l);
		info.AddValue("IEA:RI", this.m);
		di7.WriteList<string>("IEA:CBP", this.w, info);
		info.AddValue("IEA:WC", this.x);
		info.AddValue("IEA:WQFS", this.y);
		info.AddValue("IEA:WII", this.z);
		info.AddValue("IEA:T", this.h);
		info.AddValue("IEA:E", this.ac);
		info.AddValue("IEA:TP", this.i);
		info.AddValue("IEA:CS", this.ad);
	}

	// Token: 0x06006DA9 RID: 28073 RVA: 0x002DD2A8 File Offset: 0x002DB4A8
	public bool y()
	{
		return this.ac;
	}

	// Token: 0x06006DAA RID: 28074 RVA: 0x002DD2B0 File Offset: 0x002DB4B0
	public void a(bool A_0)
	{
		this.ac = A_0;
	}

	// Token: 0x06006DAB RID: 28075 RVA: 0x002DD2BC File Offset: 0x002DB4BC
	public bool v()
	{
		return this.r > 0;
	}

	// Token: 0x06006DAC RID: 28076 RVA: 0x002DD2C8 File Offset: 0x002DB4C8
	public string ac()
	{
		return this.g;
	}

	// Token: 0x06006DAD RID: 28077 RVA: 0x002DD2D0 File Offset: 0x002DB4D0
	public void b(string A_0)
	{
		if (this.g != A_0)
		{
			this.g = A_0;
			if (base.a8().Initialized)
			{
				this.k();
			}
		}
	}

	// Token: 0x06006DAE RID: 28078 RVA: 0x002DD300 File Offset: 0x002DB500
	public string ab()
	{
		return this.h;
	}

	// Token: 0x06006DAF RID: 28079 RVA: 0x002DD308 File Offset: 0x002DB508
	public void c(string A_0)
	{
		if (this.h != A_0)
		{
			this.c = null;
			this.d = null;
			this.h = A_0;
		}
	}

	// Token: 0x06006DB0 RID: 28080 RVA: 0x002DD338 File Offset: 0x002DB538
	public List<dkv> x()
	{
		return this.j;
	}

	// Token: 0x06006DB1 RID: 28081 RVA: 0x002DD340 File Offset: 0x002DB540
	public void a(List<dkv> A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06006DB2 RID: 28082 RVA: 0x002DD34C File Offset: 0x002DB54C
	public int ag()
	{
		return this.k;
	}

	// Token: 0x06006DB3 RID: 28083 RVA: 0x002DD354 File Offset: 0x002DB554
	public void a(int A_0)
	{
		this.k = A_0;
	}

	// Token: 0x06006DB4 RID: 28084 RVA: 0x002DD360 File Offset: 0x002DB560
	public int q()
	{
		return this.l;
	}

	// Token: 0x06006DB5 RID: 28085 RVA: 0x002DD368 File Offset: 0x002DB568
	public void c(int A_0)
	{
		this.l = A_0;
	}

	// Token: 0x06006DB6 RID: 28086 RVA: 0x002DD374 File Offset: 0x002DB574
	public int ae()
	{
		return this.m;
	}

	// Token: 0x06006DB7 RID: 28087 RVA: 0x002DD37C File Offset: 0x002DB57C
	public void d(int A_0)
	{
		this.m = A_0;
	}

	// Token: 0x06006DB8 RID: 28088 RVA: 0x002DD388 File Offset: 0x002DB588
	public List<string> m()
	{
		return this.w;
	}

	// Token: 0x06006DB9 RID: 28089 RVA: 0x002DD390 File Offset: 0x002DB590
	public void a(List<string> A_0)
	{
		this.w = A_0;
	}

	// Token: 0x06006DBA RID: 28090 RVA: 0x002DD39C File Offset: 0x002DB59C
	public PropertyCollection y6()
	{
		return this.f;
	}

	// Token: 0x06006DBB RID: 28091 RVA: 0x002DD3A4 File Offset: 0x002DB5A4
	public void b(PropertyCollection A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06006DBC RID: 28092 RVA: 0x002DD3B0 File Offset: 0x002DB5B0
	public PropertyCollection ad()
	{
		return this.i;
	}

	// Token: 0x06006DBD RID: 28093 RVA: 0x002DD3B8 File Offset: 0x002DB5B8
	public void a(PropertyCollection A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06006DBE RID: 28094 RVA: 0x002DD3C4 File Offset: 0x002DB5C4
	public string p()
	{
		return this.ad;
	}

	// Token: 0x06006DBF RID: 28095 RVA: 0x002DD3CC File Offset: 0x002DB5CC
	public void a(string A_0)
	{
		if (this.ad != A_0)
		{
			this.ad = A_0;
			this.af = null;
			this.ae = null;
		}
	}

	// Token: 0x06006DC0 RID: 28096 RVA: 0x002DD3FC File Offset: 0x002DB5FC
	public bm6(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006DC1 RID: 28097 RVA: 0x002DD450 File Offset: 0x002DB650
	public void r7(eds A_0)
	{
		this.a(A_0);
		if (A_0.c)
		{
			if (!this.aa)
			{
				this.aa = true;
				if (this.b != null)
				{
					this.b.ack();
				}
			}
			if (base.a8() != null)
			{
				this.b(A_0);
			}
		}
		else
		{
			this.ab = null;
			this.aa = false;
			if (this.c != null)
			{
				this.c.avh();
			}
			this.c = null;
			this.d = null;
			this.c(A_0);
		}
		if (this.ai == null)
		{
			this.ai = new DateTime?(DateTime.Now + TimeSpan.FromSeconds((double)(10 + cuo.a.Next(30))));
			return;
		}
		if (this.af.GetValueOrDefault() && this.ai.Value < DateTime.Now)
		{
			this.a();
			this.ai = null;
		}
	}

	// Token: 0x06006DC2 RID: 28098 RVA: 0x002DD568 File Offset: 0x002DB768
	public void mx()
	{
		if (this.k == 0)
		{
			if ((base.a8().g & e2b.d) != (e2b)0)
			{
				this.n = aju.s;
			}
			else
			{
				this.n = aju.r;
			}
		}
		else
		{
			this.n = this.k;
		}
		if (this.m == 0)
		{
			this.o = aju.u;
		}
		else
		{
			this.o = this.m;
		}
		this.p = (double)this.n;
		this.q = (double)this.n;
		this.h();
		this.j();
		this.f();
		if (this.b != null)
		{
			this.b.l2();
		}
	}

	// Token: 0x06006DC3 RID: 28099 RVA: 0x002DD628 File Offset: 0x002DB828
	public void my()
	{
		anp classPropertyValue = this.y6().GetClassPropertyValue<anp>(ddq.a1);
		if (classPropertyValue != null)
		{
			this.y6()[ddq.a1] = classPropertyValue.f();
		}
		d02 service = bpo.GetService<d02>();
		if (service == null || service.ahf() == null || service.ahf().b == null || service.ahf().b.a8() != base.a8())
		{
			e4w.b(this.f);
			if (this.b != null)
			{
				this.b.l2();
			}
		}
		e4w.a(this.f);
		this.g();
		this.i();
		this.e();
	}

	// Token: 0x06006DC4 RID: 28100 RVA: 0x002DD6E4 File Offset: 0x002DB8E4
	public void t()
	{
		this.v = true;
	}

	// Token: 0x06006DC5 RID: 28101 RVA: 0x002DD6F0 File Offset: 0x002DB8F0
	public void a(ai A_0)
	{
		if (this.x != null)
		{
			this.z = false;
			A_0.a(ddb.a, bat.a, new ar7(base.a8()));
			this.x.a(A_0);
		}
	}

	// Token: 0x06006DC6 RID: 28102 RVA: 0x002DD72C File Offset: 0x002DB92C
	public void aj()
	{
		this.y = true;
	}

	// Token: 0x06006DC7 RID: 28103 RVA: 0x002DD738 File Offset: 0x002DB938
	public void o()
	{
		this.y = false;
		if (this.x != null)
		{
			this.x.c();
		}
	}

	// Token: 0x06006DC8 RID: 28104 RVA: 0x002DD758 File Offset: 0x002DB958
	public bool a(amc A_0)
	{
		return this.b != null && A_0 != null && A_0.a8() != null && this.b.lw(A_0.a8().qe());
	}

	// Token: 0x06006DC9 RID: 28105 RVA: 0x002DD794 File Offset: 0x002DB994
	public bool b(amc A_0, bool A_1 = false)
	{
		if (this.b != null && A_0 != null && A_0.a8() != null && this.b.lx(A_0.a8().qe()))
		{
			if (A_1)
			{
				d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
				HashSet<r0> hashSet = this.b(serviceOrThrow);
				if (hashSet != null)
				{
					r0 r = new r0(A_0.a8().Area.c(), A_0.a8().Location.a().b());
					return hashSet.Contains(r);
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x06006DCA RID: 28106 RVA: 0x002DD82C File Offset: 0x002DBA2C
	public erl c(amc A_0)
	{
		if (this.b != null && A_0 != null && A_0.a8() != null)
		{
			return this.b.ly(A_0.a8().qe());
		}
		return null;
	}

	// Token: 0x06006DCB RID: 28107 RVA: 0x002DD864 File Offset: 0x002DBA64
	public erl a(Guid A_0)
	{
		if (this.b != null)
		{
			return this.b.ly(A_0);
		}
		return null;
	}

	// Token: 0x06006DCC RID: 28108 RVA: 0x002DD880 File Offset: 0x002DBA80
	public void a(c5x A_0)
	{
		if (this.b != null && A_0 != null)
		{
			this.b.l0(A_0.qe());
		}
	}

	// Token: 0x06006DCD RID: 28109 RVA: 0x002DD8A4 File Offset: 0x002DBAA4
	public void ah()
	{
		if (this.b != null)
		{
			this.b.l1();
		}
	}

	// Token: 0x06006DCE RID: 28110 RVA: 0x002DD8C0 File Offset: 0x002DBAC0
	public bkp b(string[] A_0)
	{
		anp anp = this.d();
		bkp bkp = new bkp(A_0.Length);
		anp.a(new object[]
		{
			A_0,
			bkp
		});
		anp.a(new EventHandler<EventArgs>(this.d));
		anp.k();
		this.r++;
		return bkp;
	}

	// Token: 0x06006DCF RID: 28111 RVA: 0x002DD918 File Offset: 0x002DBB18
	public bool e(amc A_0)
	{
		return this.b != null && A_0.a8() != null && this.b.l3(A_0.a8().qe());
	}

	// Token: 0x06006DD0 RID: 28112 RVA: 0x002DD948 File Offset: 0x002DBB48
	public List<b0b> r()
	{
		if (this.b != null)
		{
			return this.b.lz();
		}
		return new List<b0b>();
	}

	// Token: 0x06006DD1 RID: 28113 RVA: 0x002DD968 File Offset: 0x002DBB68
	public bool b(amc A_0)
	{
		return this.b != null && A_0.a8() != null && this.b.l4(A_0.a8().qe());
	}

	// Token: 0x06006DD2 RID: 28114 RVA: 0x002DD998 File Offset: 0x002DBB98
	public void a(amc A_0, bool A_1)
	{
		if (this.b != null && A_0.a8() != null)
		{
			this.b.l5(A_0, A_1);
		}
	}

	// Token: 0x06006DD3 RID: 28115 RVA: 0x002DD9C0 File Offset: 0x002DBBC0
	public bool s()
	{
		d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
		if (this.a(serviceOrThrow) && base.a8().a())
		{
			this.c.ag8();
			string[] array = this.c.avj();
			if (array != null && array.Length != 0)
			{
				this.b(array);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06006DD4 RID: 28116 RVA: 0x002DDA20 File Offset: 0x002DBC20
	public void l()
	{
		d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
		if (this.a(serviceOrThrow))
		{
			this.c.jm();
		}
	}

	// Token: 0x06006DD5 RID: 28117 RVA: 0x002DDA4C File Offset: 0x002DBC4C
	public bool u()
	{
		d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
		if (this.a(serviceOrThrow) && base.a8().a())
		{
			string[] array = this.c.avk();
			if (array != null && array.Length != 0)
			{
				this.b(array);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06006DD6 RID: 28118 RVA: 0x002DDAA0 File Offset: 0x002DBCA0
	public bool n()
	{
		this.aj = false;
		d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
		if (this.a(serviceOrThrow))
		{
			this.c.ag9();
			if (base.a8().a())
			{
				string[] array = this.c.avl();
				if (array != null && array.Length != 0)
				{
					this.b(array);
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06006DD7 RID: 28119 RVA: 0x002DDB08 File Offset: 0x002DBD08
	public List<ak1> af()
	{
		if (base.a8() == null || base.a8().Area == null)
		{
			return null;
		}
		aud aud = base.a8().Area;
		d02 service = bpo.GetService<d02>();
		if (service != null && service.ahg())
		{
			HashSet<r0> hashSet = this.b(service);
			if (hashSet != null && hashSet.Count > 0)
			{
				List<ak1> list = new List<ak1>();
				foreach (r0 r in hashSet)
				{
					ak1 ak = aud.b((int)r.a.X, (int)r.a.Y);
					if (ak != null)
					{
						list.Add(ak);
					}
				}
				return list;
			}
		}
		else
		{
			List<Point> list2 = this.z();
			if (list2 != null && list2.Count > 0)
			{
				List<ak1> list3 = new List<ak1>();
				foreach (Point point in list2)
				{
					ak1 ak2 = aud.b(point.X, point.Y);
					if (ak2 != null)
					{
						list3.Add(ak2);
					}
				}
				return list3;
			}
		}
		return null;
	}

	// Token: 0x06006DD8 RID: 28120 RVA: 0x002DDC78 File Offset: 0x002DBE78
	public HashSet<r0> b(d02 A_0)
	{
		if (this.a(A_0))
		{
			return this.c.avn();
		}
		return null;
	}

	// Token: 0x06006DD9 RID: 28121 RVA: 0x002DDC94 File Offset: 0x002DBE94
	public bool a(ak1 A_0)
	{
		if (base.a8().h.b != null && A_0.Area == base.a8().Area)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null && service.ahg())
			{
				HashSet<r0> hashSet = base.a8().t.b.b(service);
				if (hashSet != null)
				{
					r0 r = new r0(A_0.Area.c(), new Vector2((float)A_0.Location.X, (float)A_0.Location.Y));
					return hashSet.Contains(r);
				}
			}
			else
			{
				List<Point> list = base.a8().t.b.z();
				if (list != null)
				{
					return list.Contains(A_0.Location);
				}
			}
		}
		return false;
	}

	// Token: 0x06006DDA RID: 28122 RVA: 0x002DDD64 File Offset: 0x002DBF64
	public bool ai()
	{
		d02 service = bpo.GetService<d02>();
		if (service != null && service.ahg())
		{
			if (this.b(service) != null)
			{
				return true;
			}
		}
		else if (this.z() != null)
		{
			return true;
		}
		return false;
	}

	// Token: 0x06006DDB RID: 28123 RVA: 0x002DDDA4 File Offset: 0x002DBFA4
	public List<Point> z()
	{
		return this.y6().GetClassPropertyValue<List<Point>>(ddq.a1);
	}

	// Token: 0x06006DDC RID: 28124 RVA: 0x002DDDB8 File Offset: 0x002DBFB8
	public void a(d4n A_0, double A_1)
	{
		d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
		TimeSpan a_ = TimeSpan.FromMilliseconds(500.0 * A_1);
		if (this.a(serviceOrThrow) && base.a8().a())
		{
			string[] array = this.c.avm();
			if (array != null && array.Length != 0)
			{
				bool flag = false;
				HashSet<r0> hashSet = this.c.avn();
				if (hashSet != null && hashSet.Count > 0)
				{
					r0 r = A_0.b();
					flag = (r.b != -1 && hashSet.Contains(r));
				}
				if (!flag)
				{
					bm6 bm = A_0.b.a8().t.b;
					if (bm != null)
					{
						hashSet = bm.b(serviceOrThrow);
						if (hashSet != null)
						{
							d4n d4n = serviceOrThrow.ahu(base.a8().h.b.aa());
							if (d4n != null)
							{
								r0 r2 = d4n.b();
								flag = (r2.b != -1 && hashSet.Contains(r2));
							}
						}
					}
				}
				foreach (ot ot in this.a(array))
				{
					clp clp = ot as clp;
					if (clp != null)
					{
						clp.agd(A_0.b.a8());
					}
					ot.age(this, TimeSpan.Zero, a_);
					if (flag)
					{
						ot.abj(this, A_0.b.a8());
					}
					ot.agf(this, TimeSpan.Zero, a_);
				}
			}
		}
	}

	// Token: 0x06006DDD RID: 28125 RVA: 0x002DDF78 File Offset: 0x002DC178
	public void d(amc A_0)
	{
		if (A_0 != null && this.b != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
			{
				this.b.l6(serviceOrThrow.aqu().ac(), A_0);
			}
		}
	}

	// Token: 0x06006DDE RID: 28126 RVA: 0x002DDFC4 File Offset: 0x002DC1C4
	private List<ot> a(string[] A_0)
	{
		List<ot> list = new List<ot>();
		for (int i = 0; i < A_0.Length; i++)
		{
			ot ot = eph.a(A_0[i]);
			if (ot != null)
			{
				list.Add(ot);
			}
		}
		return list;
	}

	// Token: 0x06006DDF RID: 28127 RVA: 0x002DE008 File Offset: 0x002DC208
	public ed2 b(int A_0)
	{
		if (base.a8().h.b != null)
		{
			List<ak1> list = base.a8().h.b.y();
			if (list.Count > 0)
			{
				float num = float.MaxValue;
				ed2 ed = null;
				foreach (ak1 ak in list)
				{
					if (ak.Formation.b(1024L))
					{
						foreach (b0b b0b in ak.c.Values)
						{
							ed2 ed2 = ((c5x)b0b).r.b as ed2;
							if (ed2 != null && ed2.a.Contains(base.a8().qe()) && ed2.d <= A_0)
							{
								float num2 = bnx.a(ak.Location, base.a8());
								if (ed == null || num > num2)
								{
									ed = ed2;
									num = num2;
									break;
								}
							}
						}
					}
				}
				return ed;
			}
		}
		return null;
	}

	// Token: 0x06006DE0 RID: 28128 RVA: 0x002DE170 File Offset: 0x002DC370
	public yp aa()
	{
		if (base.a8().h.b != null)
		{
			List<ak1> list = base.a8().h.b.y();
			if (list.Count > 0)
			{
				float num = float.MaxValue;
				yp yp = null;
				foreach (ak1 ak in list)
				{
					if (ak.Formation.b(4096L))
					{
						foreach (b0b b0b in ak.c.Values)
						{
							yp yp2 = ((c5x)b0b).s.b as yp;
							if (yp2 != null)
							{
								float num2 = bnx.a(ak.Location, base.a8());
								if (yp == null || num > num2)
								{
									yp = yp2;
									num = num2;
									break;
								}
							}
						}
					}
				}
				return yp;
			}
		}
		return null;
	}

	// Token: 0x06006DE1 RID: 28129 RVA: 0x002DE2AC File Offset: 0x002DC4AC
	public bool a(ap9 A_0, CombatSpeakEvent[] A_1, double A_2 = 0.0, bool A_3 = false)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bq8 bq = serviceOrThrow.aqu().e();
			if (this.b() && base.a8().u.b != null && (this.ah == null || this.ah.Value + TimeSpan.FromMilliseconds(as3.bq) <= DateTime.Now))
			{
				double num;
				if (this.ah == null)
				{
					num = 0.7 + A_2;
				}
				else
				{
					int num2 = (int)(DateTime.Now - this.ah.Value - TimeSpan.FromSeconds(5.0)).TotalSeconds;
					num = d05.b(0.05, 0.5 + (double)num2 * 0.05, 0.7) + A_2;
				}
				if (cuo.a.NextDouble() < num && (!base.a8().u.b.h() || A_3))
				{
					List<KeyValuePair<ad7, PropertyCollection>> list = new List<KeyValuePair<ad7, PropertyCollection>>();
					foreach (CombatSpeakEvent combatSpeakEvent in A_1)
					{
						PropertyCollection propertyCollection = new PropertyCollection();
						propertyCollection["combatSpeakEvent"] = combatSpeakEvent;
						propertyCollection["otherParty"] = A_0;
						ad7 ad = a20.a(this.ae, A_0, combatSpeakEvent);
						if (ad != null)
						{
							list.Add(new KeyValuePair<ad7, PropertyCollection>(ad, propertyCollection));
						}
					}
					if (list.Count > 0)
					{
						this.ah = new DateTime?(DateTime.Now);
						KeyValuePair<ad7, PropertyCollection> keyValuePair = list[cuo.a.Next(list.Count)];
						base.a8().u.b.a(keyValuePair.Key.a("English", bq, keyValuePair.Value), true, null, null);
						foreach (esc esc in keyValuePair.Key.e())
						{
							esc.d5(bq, keyValuePair.Value);
						}
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06006DE2 RID: 28130 RVA: 0x002DE534 File Offset: 0x002DC734
	public void a(bm6 A_0)
	{
		this.f[ddq.bt] = true;
	}

	// Token: 0x06006DE3 RID: 28131 RVA: 0x002DE54C File Offset: 0x002DC74C
	public bool w()
	{
		this.a(bpo.GetServiceOrThrow<d02>());
		return base.a8() != null && this.c != null && base.a8().k.b == null && !this.c.vz();
	}

	// Token: 0x06006DE4 RID: 28132 RVA: 0x002DE5A4 File Offset: 0x002DC7A4
	public void a(b0b A_0)
	{
		if (this.b != null)
		{
			this.b.lv(A_0);
		}
	}

	// Token: 0x06006DE5 RID: 28133 RVA: 0x002DE5C0 File Offset: 0x002DC7C0
	private void c(eds A_0)
	{
		if (this.ac && base.a8().Zone != null && !base.a8().Zone.CustomProperties.GetPrimitivePropertyValue<bool>(a46.a, null).GetValueOrDefault())
		{
			double totalMilliseconds = A_0.b.TotalMilliseconds;
			if (base.a8().h.b == null || base.a8().h.b.aa().Dead)
			{
				return;
			}
			if (this.b != null && this.x.a() != atk.c)
			{
				try
				{
					this.b.aci(A_0.a, totalMilliseconds);
				}
				catch (Exception a_)
				{
					dux.a(LogSeverity.Error, a_, "Error occurred while updating behavior ('{1}') of entity '{0}'.", new object[]
					{
						base.a8(),
						this.b
					});
				}
				if (this.v || (this.o >= 0 && (this.u -= totalMilliseconds) <= 0.0))
				{
					this.u = (double)this.o * (1.0 + bm6.a.NextDouble() / 4.0);
					try
					{
						if (this.b != null)
						{
							this.b.aa(A_0.a, totalMilliseconds);
						}
					}
					catch (Exception a_2)
					{
						dux.a(LogSeverity.Error, a_2, "Error occurred while reconsidering behavior ('{1}') of entity '{0}'.", new object[]
						{
							base.a8(),
							this.b
						});
					}
					this.v = false;
				}
			}
			if (!this.v() && this.n >= 0 && (this.p -= totalMilliseconds) <= 0.0)
			{
				if (base.a8().a() && base.a8().Area != null)
				{
					this.a(A_0.a, TimeSpan.FromMilliseconds(this.q - this.p));
				}
				this.q = (double)this.n * (1.0 + bm6.a.NextDouble() / 5.0);
				this.p = this.q;
			}
			if (this.e == null || this.e.Count <= 0)
			{
				return;
			}
			using (List<ez0>.Enumerator enumerator = this.e.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ez0 ez = enumerator.Current;
					ez.a(this, A_0.a, A_0.b);
				}
				return;
			}
		}
		if (this.b != null)
		{
			this.b.ack();
		}
	}

	// Token: 0x06006DE6 RID: 28134 RVA: 0x002DE8BC File Offset: 0x002DCABC
	private void b(eds A_0)
	{
		d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
		if (base.a8() != null && base.a8().Area != null && base.a8().h.b != null)
		{
			d4n d4n = serviceOrThrow.ahu(base.a8().h.b.aa());
			if (d4n != null && d4n == serviceOrThrow.ahe())
			{
				if (base.a8().IsPlayer)
				{
					if (serviceOrThrow.ahi() == bh3.b && base.a8().i.b != null && base.a8().k.b != null && base.a8().h.b.aa().SpecialStates.i && base.a8().i.b.a() == null)
					{
						if (this.aj)
						{
							return;
						}
						c5x c5x = null;
						axo axo = Enumerable.FirstOrDefault<axo>(base.a8().h.b.aa().StatusEffects.Get<axo>());
						if (axo != null)
						{
							ar7 ar = axo.ObjectOfFear as ar7;
							if (ar != null)
							{
								c5x = (ar.ao() as c5x);
							}
						}
						if (c5x == null)
						{
							c5x = (bpo.GetServiceOrThrow<er9>().aql(base.a8().h.b) as c5x);
						}
						ak1 ak = bpo.GetServiceOrThrow<er9>().aqm(this, c5x, 10);
						if (ak != null)
						{
							base.a8().k.b.a(ak, 0.0, 1, 0, true);
							this.aj = true;
						}
					}
					return;
				}
				this.y6().RemoveProperty(ddq.a);
				if (this.ab == null)
				{
					this.ab = new TimeSpan?(A_0.a + d0u.a);
				}
				if (!this.ac || (this.d != null && !this.d.Value) || !base.a8().a())
				{
					d4n.f();
					return;
				}
				if (!this.a(serviceOrThrow))
				{
					return;
				}
				if (this.v())
				{
					return;
				}
				if (serviceOrThrow.ahi() == bh3.b && this.c.avi())
				{
					d4n.f();
				}
				if (A_0.a > this.ab.Value)
				{
					if (base.a8().i.b != null)
					{
						base.a8().i.b.a(true, false);
					}
					d4n.f();
					this.c.avf();
					this.ab = null;
					return;
				}
			}
			else
			{
				this.ab = null;
			}
		}
	}

	// Token: 0x06006DE7 RID: 28135 RVA: 0x002DEBA0 File Offset: 0x002DCDA0
	private bool a(d02 A_0)
	{
		if (this.c == null)
		{
			this.c = eph.a(this.h, this.i);
			if (this.c == null)
			{
				this.d = new bool?(false);
				return false;
			}
			this.c.avg(this, A_0);
		}
		return true;
	}

	// Token: 0x06006DE8 RID: 28136 RVA: 0x002DEBF8 File Offset: 0x002DCDF8
	private void a(eds A_0)
	{
		if (this.x != null)
		{
			e6d a_ = new e6d(new GameTime(A_0.a, A_0.b), default(MouseState), default(KeyboardState));
			if (this.y)
			{
				if (this.x.a() == atk.b)
				{
					this.x.b(a_);
				}
				this.y = false;
			}
			ebs ebs = this.x.b() as ebs;
			if (this.x.a() == atk.c)
			{
				if (!this.z && ebs != null && ebs.fe(this))
				{
					this.x.d();
					this.z = true;
					return;
				}
				this.x.a(a_);
				return;
			}
			else if (this.x.a() == atk.d && this.z && ebs != null && ebs.ff(this))
			{
				this.x.e();
				this.z = false;
			}
		}
	}

	// Token: 0x06006DE9 RID: 28137 RVA: 0x002DED0C File Offset: 0x002DCF0C
	private void k()
	{
		this.g();
		this.h();
	}

	// Token: 0x06006DEA RID: 28138 RVA: 0x002DED20 File Offset: 0x002DCF20
	private void j()
	{
		this.e = new List<ez0>();
		if (this.j != null && this.j.Count > 0)
		{
			foreach (dkv dkv in this.j)
			{
				if (dkv != null)
				{
					ot ot = eph.a(dkv.a());
					if (ot != null)
					{
						ot.aks(this);
						ez0 item = new ez0(ot, dkv.b());
						this.e.Add(item);
					}
				}
			}
		}
	}

	// Token: 0x06006DEB RID: 28139 RVA: 0x002DEDD4 File Offset: 0x002DCFD4
	private void i()
	{
		if (this.e != null)
		{
			foreach (ez0 ez in this.e)
			{
				if (ez.b() != null)
				{
					ez.b().akt(this);
				}
			}
		}
		this.e = null;
	}

	// Token: 0x06006DEC RID: 28140 RVA: 0x002DEE50 File Offset: 0x002DD050
	private void h()
	{
		if (!string.IsNullOrEmpty(this.g))
		{
			this.b = eph.a(this.g, this);
			if (this.b != null && this.w != null && this.w.Count > 0)
			{
				this.b.ac(this.w);
				return;
			}
		}
		else
		{
			this.b = null;
		}
	}

	// Token: 0x06006DED RID: 28141 RVA: 0x002DEEC0 File Offset: 0x002DD0C0
	private void g()
	{
		if (this.b != null)
		{
			this.w = this.b.ab();
			this.b.ack();
			this.b = null;
		}
	}

	// Token: 0x06006DEE RID: 28142 RVA: 0x002DEEF0 File Offset: 0x002DD0F0
	private void f()
	{
		if (this.x == null)
		{
			this.x = new e7i();
		}
		if (this.x.a() == atk.d && !this.z)
		{
			this.x.e();
		}
	}

	// Token: 0x06006DEF RID: 28143 RVA: 0x002DEF34 File Offset: 0x002DD134
	private void e()
	{
		if (this.x != null)
		{
			this.x.h(new EventHandler<EventArgs>(this.a));
			this.x.k(new EventHandler<EventArgs>(this.b));
			this.x.c(new EventHandler<EventArgs>(this.c));
		}
		if (this.x != null && this.x.a() == atk.c && !this.z)
		{
			this.x.d();
		}
	}

	// Token: 0x06006DF0 RID: 28144 RVA: 0x002DEFC4 File Offset: 0x002DD1C4
	private void a(TimeSpan A_0, TimeSpan A_1)
	{
		this.s = A_0;
		this.t = A_1;
		anp anp = this.d();
		anp.a(new EventHandler<EventArgs>(this.e));
		anp.k();
		this.r++;
	}

	// Token: 0x06006DF1 RID: 28145 RVA: 0x002DF00C File Offset: 0x002DD20C
	private anp d()
	{
		Vector3 vector = base.a8().aj();
		Point a_ = new Point((int)vector.X, (int)vector.Y);
		float a_2;
		if (base.a8().IsPlayer)
		{
			a_2 = base.a8().h.b.aa().SightRange + (float)aju.v;
		}
		else
		{
			a_2 = Math.Max(base.a8().h.b.aa().SightRange, (float)aju.w);
		}
		long num = 1L;
		if (base.a8() != null && base.a8().h.b != null && !base.a8().h.b.aa().b(d8o.b | d8o.c | d8o.d))
		{
			num |= 2097152L;
		}
		return new anp(a_, base.a8().Area, a_2, num, false, 0L);
	}

	// Token: 0x06006DF2 RID: 28146 RVA: 0x002DF0F8 File Offset: 0x002DD2F8
	private void a(anp A_0)
	{
		int num = this.r - 1;
		this.r = num;
		if (num < 0)
		{
			this.r = 0;
		}
		this.y6()[ddq.a1] = A_0.f();
	}

	// Token: 0x06006DF3 RID: 28147 RVA: 0x002DF13C File Offset: 0x002DD33C
	private void a(anp A_0, List<ez0> A_1)
	{
		HashSet<b0b> hashSet = new HashSet<b0b>();
		List<ot> list = null;
		List<ot> list2 = null;
		HashSet<ot> hashSet2 = new HashSet<ot>();
		if (A_1 != null && A_1.Count > 0)
		{
			foreach (ez0 ez in A_1)
			{
				if (ez.b().abf())
				{
					if (list == null)
					{
						list = new List<ot>();
					}
					list.Add(ez.b());
					hashSet2.Add(ez.b());
					ez.b().age(this, this.s, this.t);
				}
				if (ez.b().abh())
				{
					if (list2 == null)
					{
						list2 = new List<ot>();
					}
					list2.Add(ez.b());
					hashSet2.Add(ez.b());
					if (list == null || !list.Contains(ez.b()))
					{
						ez.b().age(this, this.s, this.t);
					}
				}
			}
		}
		if (A_0.f() != null)
		{
			foreach (Point point in A_0.f())
			{
				ak1 ak = A_0.d().b(point.X, point.Y);
				if (ak != null)
				{
					if (list != null)
					{
						foreach (ot ot in list)
						{
							ot.akn(this, ak);
						}
					}
					if (list2 != null)
					{
						foreach (b0b b0b in ak.Entities)
						{
							c5x c5x = b0b as c5x;
							if (c5x != null && c5x != base.a8() && c5x.h.b != null && !hashSet.Contains(b0b))
							{
								foreach (ot ot2 in list2)
								{
									ot2.abj(this, c5x);
								}
								hashSet.Add(c5x);
							}
						}
					}
				}
			}
		}
		foreach (ot ot3 in hashSet2)
		{
			ot3.agf(this, this.s, this.t);
		}
	}

	// Token: 0x06006DF4 RID: 28148 RVA: 0x002DF494 File Offset: 0x002DD694
	private bool b()
	{
		if (this.af != null)
		{
			string text = this.ag;
			evo evo = aji.a;
			if (!(text != ((evo != null) ? evo.a : null)))
			{
				goto IL_140;
			}
		}
		if (base.a8().h.b != null && !base.a8().IsPlayer)
		{
			eve serviceOrThrow = bpo.GetServiceOrThrow<eve>();
			try
			{
				if (!string.IsNullOrWhiteSpace(this.p()))
				{
					string text2 = "CombatSpeak\\" + this.ad;
					this.ae = serviceOrThrow.y3(text2);
					aji.a(this.ae, text2);
				}
				else if (base.a8().h.b.aa().b(d8o.b))
				{
					string text3 = "CombatSpeak\\General";
					this.ae = serviceOrThrow.y3(text3);
					aji.a(this.ae, text3);
				}
			}
			catch (Exception ex)
			{
				dux.b(LogSeverity.Error, "Failed to load combat speak dialog model with name '{0}'. Exception: {1}", new object[]
				{
					this.ad,
					ex.ToString()
				});
			}
		}
		this.af = new bool?(this.ae != null);
		evo evo2 = aji.a;
		this.ag = ((evo2 != null) ? evo2.a : null);
		IL_140:
		return this.af.Value;
	}

	// Token: 0x06006DF5 RID: 28149 RVA: 0x002DF5FC File Offset: 0x002DD7FC
	private void a()
	{
		if (this.b() && base.a8().h.b != null && !base.a8().h.b.aa().SpecialStates.a && !base.a8().h.b.aa().SpecialStates.c && !base.a8().h.b.aa().SpecialStates.h)
		{
			HashSet<CombatSpeakEvent> hashSet = new HashSet<CombatSpeakEvent>();
			ap9 a_ = null;
			if (base.a8().h.b.aa().StatusEffects.a(bk9.a))
			{
				hashSet.Add(CombatSpeakEvent.Affliction_Burning);
			}
			if (base.a8().h.b.aa().StatusEffects.a(b34.c))
			{
				hashSet.Add(CombatSpeakEvent.Affliction_Chilled);
			}
			if (base.a8().h.b.aa().SpecialStates.b)
			{
				hashSet.Add(CombatSpeakEvent.Affliction_Rooted);
			}
			if (base.a8().h.b.aa().StatusEffects.a(bv0.a))
			{
				hashSet.Add(CombatSpeakEvent.Affliction_Enraged);
			}
			if (base.a8().h.b.aa().StatusEffects.Get<c2b>().Count > 0)
			{
				hashSet.Add(CombatSpeakEvent.Affliction_Poisoned);
			}
			if (base.a8().h.b.aa().StatusEffects.a(axo.a))
			{
				hashSet.Add(CombatSpeakEvent.Affliction_Fear);
			}
			if (base.a8().h.b.aa().StatusEffects.a(e8b.a))
			{
				hashSet.Add(CombatSpeakEvent.Affliction_BrokenRibs);
			}
			if (base.a8().h.b.aa().StatusEffects.a(cr.a))
			{
				hashSet.Add(CombatSpeakEvent.Affliction_MentalSubversion);
			}
			if (base.a8().h.b.aa().StatusEffects.Get<a5e>().Count > 0)
			{
				hashSet.Add(CombatSpeakEvent.Affliction_Bleeding);
			}
			if ((double)euf.f(base.a8().h.b.aa()) <= 0.15)
			{
				hashSet.Add(CombatSpeakEvent.Hit_LowHealth);
			}
			foreach (ak1 ak in base.a8().l)
			{
				foreach (b0b b0b in ak.c.Values)
				{
					cry aspect = ((c5x)b0b).GetAspect<cry>();
					if (aspect != null && aspect.gw())
					{
						hashSet.Add(CombatSpeakEvent.Hit_ToxicGas);
					}
				}
			}
			if (base.a8().h.b.aa().IsInControl && !base.a8().h.b.aa().StatusEffects.a(bk9.a) && !base.a8().t.b.ad().GetPrimitivePropertyValue<bool>("Civilian", new bool?(false)).Value)
			{
				EntityAspectReference<amc, amc> classPropertyValue = this.y6().GetClassPropertyValue<EntityAspectReference<amc, amc>>(cy1.b);
				if (classPropertyValue != null && classPropertyValue.ao() != null && !classPropertyValue.ao().aa().Dead && this.b(classPropertyValue.ao(), false) && a20.a(classPropertyValue.ao()))
				{
					hashSet.Add(CombatSpeakEvent.Taunt_General);
					if ((double)euf.f(classPropertyValue.ao().aa()) <= 0.15)
					{
						hashSet.Add(CombatSpeakEvent.Taunt_LowHealth);
					}
					if (classPropertyValue.ao().aa().StatusEffects.a(bk9.a))
					{
						hashSet.Add(CombatSpeakEvent.Taunt_Burning);
					}
					if (classPropertyValue.ao().aa().StatusEffects.a(b34.c))
					{
						hashSet.Add(CombatSpeakEvent.Taunt_Chilled);
					}
					if (classPropertyValue.ao().aa().SpecialStates.b)
					{
						hashSet.Add(CombatSpeakEvent.Taunt_Rooted);
					}
					if (classPropertyValue.ao().aa().SpecialStates.a)
					{
						hashSet.Add(CombatSpeakEvent.Taunt_Stunned);
					}
					if (classPropertyValue.ao().aa().StatusEffects.Get<c2b>().Count > 0)
					{
						hashSet.Add(CombatSpeakEvent.Taunt_Poisoned);
					}
					if (classPropertyValue.ao().aa().StatusEffects.Get<a5e>().Count > 0)
					{
						hashSet.Add(CombatSpeakEvent.Taunt_Bleeding);
					}
					a_ = new ap9(classPropertyValue.ao().aa());
				}
			}
			if (hashSet.Count > 0)
			{
				a20.a(base.a8(), a_, Enumerable.ToArray<CombatSpeakEvent>(hashSet));
			}
		}
	}

	// Token: 0x06006DF6 RID: 28150 RVA: 0x002DFBA4 File Offset: 0x002DDDA4
	[dcc("IEA:mSF")]
	private void e(object A_0, EventArgs A_1)
	{
		this.a(A_0 as anp, this.e);
		this.a(A_0 as anp);
	}

	// Token: 0x06006DF7 RID: 28151 RVA: 0x002DFBC4 File Offset: 0x002DDDC4
	[dcc("IEA:mSSF")]
	private void d(object A_0, EventArgs A_1)
	{
		anp anp = A_0 as anp;
		object[] array = anp.a() as object[];
		string[] array2 = array[0] as string[];
		bkp bkp = array[1] as bkp;
		if (array2 != null && array2.Length != 0)
		{
			List<ez0> list = new List<ez0>();
			foreach (string text in array2)
			{
				if (!string.IsNullOrEmpty(text))
				{
					ot ot = eph.a(text);
					if (ot != null)
					{
						ot.aks(this);
						ez0 item = new ez0(ot, 0);
						list.Add(item);
					}
					else
					{
						bkp.b();
					}
				}
				else
				{
					bkp.b();
				}
			}
			foreach (ez0 ez in list)
			{
				if (ez.b().akm())
				{
					bkp.a(ez.b());
				}
				else
				{
					bkp.b();
				}
				ez.b().abi(this, this.s, this.t);
			}
			this.t = TimeSpan.Zero;
			this.a(anp, list);
			foreach (ez0 ez2 in list)
			{
				ez2.b().akt(this);
			}
		}
		this.a(anp);
	}

	// Token: 0x06006DF8 RID: 28152 RVA: 0x002DFD60 File Offset: 0x002DDF60
	[dcc("IEA:mWC_WS")]
	private void c(object A_0, EventArgs A_1)
	{
		this.z = false;
	}

	// Token: 0x06006DF9 RID: 28153 RVA: 0x002DFD6C File Offset: 0x002DDF6C
	[dcc("IEA:mWC_WC")]
	private void b(object A_0, EventArgs A_1)
	{
		this.z = false;
	}

	// Token: 0x06006DFA RID: 28154 RVA: 0x002DFD78 File Offset: 0x002DDF78
	[dcc("IEA:mWC_WF")]
	private void a(object A_0, EventArgs A_1)
	{
		this.z = false;
	}

	// Token: 0x04002CDB RID: 11483
	private static Random a = new Random();

	// Token: 0x04002CDC RID: 11484
	[NonSerialized]
	private el7 b;

	// Token: 0x04002CDD RID: 11485
	[NonSerialized]
	private ckn c;

	// Token: 0x04002CDE RID: 11486
	[NonSerialized]
	private bool? d;

	// Token: 0x04002CDF RID: 11487
	[NonSerialized]
	private List<ez0> e;

	// Token: 0x04002CE0 RID: 11488
	private PropertyCollection f = new PropertyCollection();

	// Token: 0x04002CE1 RID: 11489
	private string g;

	// Token: 0x04002CE2 RID: 11490
	private string h;

	// Token: 0x04002CE3 RID: 11491
	private PropertyCollection i = new PropertyCollection();

	// Token: 0x04002CE4 RID: 11492
	private List<dkv> j = new List<dkv>();

	// Token: 0x04002CE5 RID: 11493
	private int k;

	// Token: 0x04002CE6 RID: 11494
	private int l;

	// Token: 0x04002CE7 RID: 11495
	private int m;

	// Token: 0x04002CE8 RID: 11496
	[NonSerialized]
	private int n;

	// Token: 0x04002CE9 RID: 11497
	[NonSerialized]
	private int o;

	// Token: 0x04002CEA RID: 11498
	[NonSerialized]
	private double p;

	// Token: 0x04002CEB RID: 11499
	[NonSerialized]
	private double q;

	// Token: 0x04002CEC RID: 11500
	[NonSerialized]
	private int r;

	// Token: 0x04002CED RID: 11501
	[NonSerialized]
	private TimeSpan s;

	// Token: 0x04002CEE RID: 11502
	[NonSerialized]
	private TimeSpan t;

	// Token: 0x04002CEF RID: 11503
	[NonSerialized]
	private double u;

	// Token: 0x04002CF0 RID: 11504
	[NonSerialized]
	private bool v;

	// Token: 0x04002CF1 RID: 11505
	private List<string> w = new List<string>();

	// Token: 0x04002CF2 RID: 11506
	private e7i x = new e7i();

	// Token: 0x04002CF3 RID: 11507
	private bool y;

	// Token: 0x04002CF4 RID: 11508
	private bool z;

	// Token: 0x04002CF5 RID: 11509
	[NonSerialized]
	private bool aa;

	// Token: 0x04002CF6 RID: 11510
	[NonSerialized]
	private TimeSpan? ab;

	// Token: 0x04002CF7 RID: 11511
	private bool ac = true;

	// Token: 0x04002CF8 RID: 11512
	private string ad;

	// Token: 0x04002CF9 RID: 11513
	[NonSerialized]
	private azm ae;

	// Token: 0x04002CFA RID: 11514
	[NonSerialized]
	private bool? af;

	// Token: 0x04002CFB RID: 11515
	[NonSerialized]
	private string ag;

	// Token: 0x04002CFC RID: 11516
	[NonSerialized]
	private DateTime? ah;

	// Token: 0x04002CFD RID: 11517
	[NonSerialized]
	private DateTime? ai;

	// Token: 0x04002CFE RID: 11518
	private bool aj;
}
