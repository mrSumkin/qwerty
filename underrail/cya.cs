using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.Lightning;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules;

// Token: 0x0200129E RID: 4766
[eiz("XSHEA")]
[Serializable]
public sealed class cya : Aspect<c5x>, ISerializable, chb, cmm, bp1, dqh
{
	// Token: 0x0600681A RID: 26650 RVA: 0x002C0B54 File Offset: 0x002BED54
	private cya(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.f = A_0.GetString("XSHEA:C");
		this.g = A_0.GetDouble("XSHEA:A");
		this.h = A_0.GetDouble("XSHEA:D");
		this.i = A_0.GetDouble("XSHEA:G");
		this.j = A_0.GetDouble("XSHEA:R");
		this.k = A_0.GetInt32("XSHEA:SC");
		this.l = A_0.GetInt32("XSHEA:MS");
		this.m = A_0.GetInt32("XSHEA:WC");
		this.n = A_0.GetInt32("XSHEA:MW");
		if (ell.a() >= 466)
		{
			this.o = A_0.GetBoolean("XSHEA:CI");
		}
		if (ell.a() >= 550)
		{
			this.p = A_0.GetBoolean("XSHEA:DC");
		}
	}

	// Token: 0x0600681B RID: 26651 RVA: 0x002C0C60 File Offset: 0x002BEE60
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XSHEA:C", this.f);
		info.AddValue("XSHEA:A", this.g);
		info.AddValue("XSHEA:D", this.h);
		info.AddValue("XSHEA:G", this.i);
		info.AddValue("XSHEA:R", this.j);
		info.AddValue("XSHEA:SC", this.k);
		info.AddValue("XSHEA:MS", this.l);
		info.AddValue("XSHEA:WC", this.m);
		info.AddValue("XSHEA:MW", this.n);
		info.AddValue("XSHEA:CI", this.o);
		info.AddValue("XSHEA:DC", this.p);
	}

	// Token: 0x0600681C RID: 26652 RVA: 0x002C0D30 File Offset: 0x002BEF30
	public string s()
	{
		return this.f;
	}

	// Token: 0x0600681D RID: 26653 RVA: 0x002C0D38 File Offset: 0x002BEF38
	public void b(string A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600681E RID: 26654 RVA: 0x002C0D44 File Offset: 0x002BEF44
	public int m()
	{
		return this.k;
	}

	// Token: 0x0600681F RID: 26655 RVA: 0x002C0D4C File Offset: 0x002BEF4C
	public void a(int A_0)
	{
		this.k = A_0;
		this.g();
	}

	// Token: 0x06006820 RID: 26656 RVA: 0x002C0D5C File Offset: 0x002BEF5C
	public int o()
	{
		return this.l;
	}

	// Token: 0x06006821 RID: 26657 RVA: 0x002C0D64 File Offset: 0x002BEF64
	public void b(int A_0)
	{
		this.l = A_0;
		this.g();
	}

	// Token: 0x06006822 RID: 26658 RVA: 0x002C0D74 File Offset: 0x002BEF74
	public int r()
	{
		return this.m;
	}

	// Token: 0x06006823 RID: 26659 RVA: 0x002C0D7C File Offset: 0x002BEF7C
	public void c(int A_0)
	{
		this.m = A_0;
		this.g();
	}

	// Token: 0x06006824 RID: 26660 RVA: 0x002C0D8C File Offset: 0x002BEF8C
	public int n()
	{
		return this.n;
	}

	// Token: 0x06006825 RID: 26661 RVA: 0x002C0D94 File Offset: 0x002BEF94
	public void d(int A_0)
	{
		this.n = A_0;
		this.g();
	}

	// Token: 0x06006826 RID: 26662 RVA: 0x002C0DA4 File Offset: 0x002BEFA4
	public bool q()
	{
		return this.j > 0.0;
	}

	// Token: 0x06006827 RID: 26663 RVA: 0x002C0DB8 File Offset: 0x002BEFB8
	public cya(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006828 RID: 26664 RVA: 0x002C0DE0 File Offset: 0x002BEFE0
	public void mx()
	{
		this.g();
	}

	// Token: 0x06006829 RID: 26665 RVA: 0x002C0DE8 File Offset: 0x002BEFE8
	public void my()
	{
	}

	// Token: 0x0600682A RID: 26666 RVA: 0x002C0DEC File Offset: 0x002BEFEC
	public void r7(eds A_0)
	{
		c5x c5x = base.a8();
		amc amc;
		if (c5x == null)
		{
			amc = null;
		}
		else
		{
			QuickAspectAccessor<amc> quickAspectAccessor = c5x.h;
			amc = ((quickAspectAccessor != null) ? quickAspectAccessor.b : null);
		}
		amc amc2 = amc;
		if (!this.o)
		{
			this.o = true;
			this.k = this.d();
			this.m = this.b();
		}
		this.g += A_0.b.TotalMilliseconds;
		if (this.g > 1500.0)
		{
			this.l();
			this.g = 0.0;
			this.e();
		}
		if (!dz6.e() && (amc2 == null || !amc2.aa().SpecialStates.k))
		{
			if ((this.j -= A_0.b.TotalMilliseconds) < 0.0)
			{
				this.j = 0.0;
			}
			this.h += A_0.b.TotalMilliseconds;
			if (this.j > 0.0 && this.h >= (double)d0u.b)
			{
				this.a(true, false);
				this.h = 0.0;
			}
			this.a(A_0.b.TotalMilliseconds);
		}
		this.g();
		this.f();
	}

	// Token: 0x0600682B RID: 26667 RVA: 0x002C0F64 File Offset: 0x002BF164
	public void c()
	{
		c5x c5x = base.a8();
		amc amc;
		if (c5x == null)
		{
			amc = null;
		}
		else
		{
			QuickAspectAccessor<amc> quickAspectAccessor = c5x.h;
			amc = ((quickAspectAccessor != null) ? quickAspectAccessor.b : null);
		}
		amc amc2 = amc;
		if (amc2 == null || !amc2.aa().SpecialStates.k)
		{
			this.l();
			this.g = 0.0;
			if ((this.j -= (double)d0u.b) < 0.0)
			{
				this.j = 0.0;
			}
			if (this.j > 0.0)
			{
				this.a(true, false);
			}
			this.a((double)d0u.b);
		}
		this.e();
	}

	// Token: 0x0600682C RID: 26668 RVA: 0x002C1030 File Offset: 0x002BF230
	public void c9(TimeSpan A_0)
	{
		this.a(A_0.TotalMilliseconds);
	}

	// Token: 0x0600682D RID: 26669 RVA: 0x002C1040 File Offset: 0x002BF240
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x0600682E RID: 26670 RVA: 0x002C1044 File Offset: 0x002BF244
	public void p()
	{
		this.j = 120000.0;
	}

	// Token: 0x0600682F RID: 26671 RVA: 0x002C1058 File Offset: 0x002BF258
	public static void b(c5x A_0)
	{
		a3f a3f = A_0.GetAspect<a3f>();
		if (a3f == null)
		{
			a3f = new a3f(A_0);
			A_0.SetAspect<a3f>(a3f);
		}
		a3f.a()["CustomDeadAnimation"] = CharacterState.Custom2;
		a3f.a()["BloodlessDeath"] = true;
	}

	// Token: 0x06006830 RID: 26672 RVA: 0x002C10B0 File Offset: 0x002BF2B0
	public void a(bool A_0 = true, bool A_1 = false)
	{
		if (base.a8() != null && base.a8().Zone != null && !string.IsNullOrEmpty(this.f) && (this.k > 0 || this.m > 0) && (!this.p || A_1))
		{
			List<csd> list = this.h();
			List<csd> list2 = this.i();
			if (list.Count > 0 && this.k > 0)
			{
				foreach (csd csd in list)
				{
					if (csd.Area != null)
					{
						ak1 ak = csd.Area.a(csd.Location.a());
						if (ak != null && !aw1.a(ak, false, null, l9.a))
						{
							c5x c5x = vq.a("Creatures\\Xpbl\\Strider", csd, false);
							if (c5x != null)
							{
								this.p = true;
								this.a(c5x, this.k());
								this.a(c5x);
								this.k--;
								if (this.k <= 0)
								{
									break;
								}
							}
						}
					}
				}
			}
			if (list2.Count <= 0 || this.m <= 0)
			{
				goto IL_229;
			}
			using (List<csd>.Enumerator enumerator = list2.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					csd csd2 = enumerator.Current;
					if (csd2.Area != null)
					{
						ak1 ak2 = csd2.Area.a(csd2.Location.a());
						if (ak2 != null && !aw1.a(ak2, false, null, l9.c))
						{
							c5x c5x2 = vq.a("Creatures\\Xpbl\\WaterStrider", csd2, false);
							if (c5x2 != null)
							{
								this.p = true;
								this.a(c5x2, this.k());
								this.a(c5x2);
								this.m--;
								cya.b(c5x2);
								if (this.m <= 0)
								{
									break;
								}
							}
						}
					}
				}
				goto IL_229;
			}
		}
		if (this.p)
		{
			this.p = false;
		}
		IL_229:
		if (A_0)
		{
			this.e();
		}
	}

	// Token: 0x06006831 RID: 26673 RVA: 0x002C1310 File Offset: 0x002BF510
	public void aip()
	{
		bsf bsf = Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(base.a8().RaysEmitters), new Func<bsf, bool>(cya.c.a.a)));
		if (bsf != null)
		{
			bsf.ig();
		}
	}

	// Token: 0x06006832 RID: 26674 RVA: 0x002C1368 File Offset: 0x002BF568
	private void l()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.h.b != null && c5x.Area == base.a8().Area)
			{
				bm6 bm = base.a8().t.b;
				if (bm != null)
				{
					erl erl = bm.c(c5x.h.b);
					if (erl != null && erl.f() == cem.d)
					{
						this.p();
					}
				}
			}
		}
	}

	// Token: 0x06006833 RID: 26675 RVA: 0x002C141C File Offset: 0x002BF61C
	private void a(c5x A_0)
	{
		new ah7("striderLantern_" + A_0.qe().ToString(), null)
		{
			Light = new ae8(new Color(255, 115, 125), 0.3f, LightType.Increment),
			Range = 3f,
			LightFadeRate = 0.08f
		}.g().be(A_0);
	}

	// Token: 0x06006834 RID: 26676 RVA: 0x002C1490 File Offset: 0x002BF690
	private void a(c5x A_0, string A_1)
	{
		A_0.b(A_1);
		if (A_0.t.b != null)
		{
			A_0.t.b.y6()["HomeHiveRef"] = new ar7(base.a8());
		}
	}

	// Token: 0x06006835 RID: 26677 RVA: 0x002C14D0 File Offset: 0x002BF6D0
	private string k()
	{
		return string.Format("StriderOfHive_{0}", this.f);
	}

	// Token: 0x06006836 RID: 26678 RVA: 0x002C14E4 File Offset: 0x002BF6E4
	private string j()
	{
		return string.Format("WaterStriderOfHive_{0}", this.f);
	}

	// Token: 0x06006837 RID: 26679 RVA: 0x002C14F8 File Offset: 0x002BF6F8
	private List<csd> i()
	{
		cya.a a = new cya.a();
		a.a = string.Format("HiveWaterExit_{0}", this.f);
		return Enumerable.ToList<csd>(Enumerable.Where<csd>(base.a8().Zone.Waypoints, new Func<csd, bool>(a.a)));
	}

	// Token: 0x06006838 RID: 26680 RVA: 0x002C1548 File Offset: 0x002BF748
	private List<csd> h()
	{
		cya.b b = new cya.b();
		b.a = string.Format("HiveExit_{0}", this.f);
		return Enumerable.ToList<csd>(Enumerable.Where<csd>(base.a8().Zone.Waypoints, new Func<csd, bool>(b.a)));
	}

	// Token: 0x06006839 RID: 26681 RVA: 0x002C1598 File Offset: 0x002BF798
	private void g()
	{
		bsf bsf = Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(base.a8().RaysEmitters), new Func<bsf, bool>(cya.c.a.b)));
		if (bsf == null)
		{
			bsf = new ah7("StriderHiveGlow", null)
			{
				Light = new ae8(new Color(255, 115, 125), 1f, LightType.Increment),
				Range = 5f,
				LightFadeRate = 0.2f
			}.g();
			bsf.be(base.a8());
		}
		int num = this.k + this.m;
		float num2 = Math.Min(1f, (float)num / (float)Math.Max(1, Math.Min(10, this.d() + this.b())));
		float a_ = num2 / 5f;
		int x = d05.a(1, Convert.ToInt32(num2 / 0.24f), 4);
		if (base.a8().p.b != null && base.a8().p.b.a.Count >= 2)
		{
			if (num2 == 0f)
			{
				base.a8().p.b.a[1].d = new float?(0f);
			}
			else
			{
				base.a8().p.b.a[1].d = null;
			}
			base.a8().p.b.a[1].b = new Point(x, base.a8().p.b.a[1].b.Y);
		}
		if (bsf.Definition.Light.c() != num2)
		{
			bsf.Definition.Light = new ae8(bsf.Definition.Light.d(), num2, LightType.Increment);
			bsf.Definition.LightFadeRate = a_;
			bsf.Definition.d();
		}
	}

	// Token: 0x0600683A RID: 26682 RVA: 0x002C17C8 File Offset: 0x002BF9C8
	private void f()
	{
		aru aru = base.a8().c();
		app app;
		aru.e().TryGetValue("hiveBuzzing", out app);
		if (app == null)
		{
			aru.a("hiveBuzzing", "Xpbl_StriderHive" + (1 + new Random(base.a8().GetHashCode()).Next(3)).ToString(), 1f, c9z.b, true, false);
			aru.e().TryGetValue("hiveBuzzing", out app);
		}
		int num = this.k + this.m;
		float num2 = Math.Min(1f, (float)num / (float)Math.Max(1, Math.Min(10, this.d() + this.b())));
		if (app.b() != num2)
		{
			aru.a("hiveBuzzing", num2);
		}
	}

	// Token: 0x0600683B RID: 26683 RVA: 0x002C18A0 File Offset: 0x002BFAA0
	private void a(double A_0)
	{
		int num = this.a(this.j());
		int num2 = this.a(this.k());
		if (num2 < this.d() || num < this.b())
		{
			this.i += A_0;
			while (this.i >= 600000.0)
			{
				this.i -= 600000.0;
				if (num < this.b())
				{
					this.m++;
					num++;
				}
				if (num2 < this.d())
				{
					this.k++;
					num2++;
				}
			}
			return;
		}
		this.i = 0.0;
	}

	// Token: 0x0600683C RID: 26684 RVA: 0x002C1968 File Offset: 0x002BFB68
	private int a(string A_0)
	{
		int num = this.k;
		d60 d = base.a8().Zone.a();
		if (d != null)
		{
			List<b0b> list = d.ab4(new string[]
			{
				A_0
			});
			if (list != null)
			{
				num += list.Count;
			}
		}
		return num;
	}

	// Token: 0x0600683D RID: 26685 RVA: 0x002C19B4 File Offset: 0x002BFBB4
	private void e()
	{
		if (this.k > 0)
		{
			List<csd> a_ = this.h();
			this.a(a_);
		}
		if (this.m > 0)
		{
			List<csd> a_2 = this.i();
			this.a(a_2);
		}
	}

	// Token: 0x0600683E RID: 26686 RVA: 0x002C19F8 File Offset: 0x002BFBF8
	private void a(List<csd> A_0)
	{
		foreach (csd csd in A_0)
		{
			if (csd.Area != null)
			{
				ak1 ak = csd.Area.a(csd.Location.a());
				if (ak != null)
				{
					foreach (b0b b0b in ak.Entities)
					{
						c5x c5x = (c5x)b0b;
						if (c5x.t.b != null && c5x.h.b != null && c5x.h.b.aa().FactionId == asp.ge)
						{
							c5x.t.b.a(null);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600683F RID: 26687 RVA: 0x002C1B10 File Offset: 0x002BFD10
	private int d()
	{
		return (int)(this.a() * (double)this.l);
	}

	// Token: 0x06006840 RID: 26688 RVA: 0x002C1B24 File Offset: 0x002BFD24
	private int b()
	{
		return (int)(this.a() * (double)this.n);
	}

	// Token: 0x06006841 RID: 26689 RVA: 0x002C1B38 File Offset: 0x002BFD38
	private double a()
	{
		bu6 service = bpo.GetService<bu6>();
		if (service != null)
		{
			switch (service.aq2())
			{
			case GameDifficulty.Easy:
				return 0.75;
			case GameDifficulty.Hard:
				return 1.25;
			case GameDifficulty.Dominating:
				return 1.4;
			}
			return 1.0;
		}
		return 1.0;
	}

	// Token: 0x04002B01 RID: 11009
	private const int a = 1500;

	// Token: 0x04002B02 RID: 11010
	private const int b = 120000;

	// Token: 0x04002B03 RID: 11011
	private const int c = 600000;

	// Token: 0x04002B04 RID: 11012
	private const string d = "StriderHiveGlow";

	// Token: 0x04002B05 RID: 11013
	private const int e = 10;

	// Token: 0x04002B06 RID: 11014
	private string f;

	// Token: 0x04002B07 RID: 11015
	private double g;

	// Token: 0x04002B08 RID: 11016
	private double h;

	// Token: 0x04002B09 RID: 11017
	private double i;

	// Token: 0x04002B0A RID: 11018
	private double j;

	// Token: 0x04002B0B RID: 11019
	private int k = 7;

	// Token: 0x04002B0C RID: 11020
	private int l = 7;

	// Token: 0x04002B0D RID: 11021
	private int m = 7;

	// Token: 0x04002B0E RID: 11022
	private int n = 7;

	// Token: 0x04002B0F RID: 11023
	private bool o;

	// Token: 0x04002B10 RID: 11024
	private bool p;

	// Token: 0x0200129F RID: 4767
	[CompilerGenerated]
	[Serializable]
	private sealed class c
	{
		// Token: 0x06006844 RID: 26692 RVA: 0x002C1BB8 File Offset: 0x002BFDB8
		internal bool a(bsf A_0)
		{
			return A_0.Definition != null && A_0.Definition.Name == "StriderHiveGlow";
		}

		// Token: 0x06006845 RID: 26693 RVA: 0x002C1BDC File Offset: 0x002BFDDC
		internal bool b(bsf A_0)
		{
			return A_0.Definition != null && A_0.Definition.Name == "StriderHiveGlow";
		}

		// Token: 0x04002B11 RID: 11025
		public static readonly cya.c a = new cya.c();

		// Token: 0x04002B12 RID: 11026
		public static Func<bsf, bool> b;

		// Token: 0x04002B13 RID: 11027
		public static Func<bsf, bool> c;
	}

	// Token: 0x020012A0 RID: 4768
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06006847 RID: 26695 RVA: 0x002C1C08 File Offset: 0x002BFE08
		internal bool a(csd A_0)
		{
			return A_0.Name != null && A_0.Name.StartsWith(this.a);
		}

		// Token: 0x04002B14 RID: 11028
		public string a;
	}

	// Token: 0x020012A1 RID: 4769
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x06006849 RID: 26697 RVA: 0x002C1C30 File Offset: 0x002BFE30
		internal bool a(csd A_0)
		{
			return A_0.Name != null && A_0.Name.StartsWith(this.a);
		}

		// Token: 0x04002B15 RID: 11029
		public string a;
	}
}
