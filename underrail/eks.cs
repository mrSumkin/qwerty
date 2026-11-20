using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.Space;

// Token: 0x020012B7 RID: 4791
[a(typeof(bim))]
[eiz("FEA0")]
[Serializable]
public sealed class eks : bim, ISerializable, cmm, chb
{
	// Token: 0x0600696F RID: 26991 RVA: 0x002C7564 File Offset: 0x002C5764
	private eks(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (g0)A_0.GetValue("FEA0:S", typeof(g0));
		this.b = A_0.GetBoolean("FEA0:M");
		this.c = A_0.GetDouble("FEA0:C");
		this.d = A_0.GetDouble("FEA0:H");
		if (ell.a() >= 400)
		{
			this.e = A_0.GetDouble("FEA0:E");
		}
		if (ell.a() >= 623)
		{
			this.i = (A_0.GetValue("FEA0:BDO", typeof(double?)) as double?);
			this.j = (A_0.GetValue("FEA0:BLDO", typeof(double?)) as double?);
			this.k = (A_0.GetValue("FEA0:EDO", typeof(double?)) as double?);
		}
	}

	// Token: 0x06006970 RID: 26992 RVA: 0x002C766C File Offset: 0x002C586C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FEA0:S", this.a);
		info.AddValue("FEA0:M", this.b);
		info.AddValue("FEA0:C", this.c);
		info.AddValue("FEA0:H", this.d);
		info.AddValue("FEA0:E", this.e);
		info.AddValue("FEA0:BDO", this.i);
		info.AddValue("FEA0:BLDO", this.j);
		info.AddValue("FEA0:EDO", this.k);
	}

	// Token: 0x06006971 RID: 26993 RVA: 0x002C7720 File Offset: 0x002C5920
	public g0 i()
	{
		return this.a;
	}

	// Token: 0x06006972 RID: 26994 RVA: 0x002C7728 File Offset: 0x002C5928
	public void a(g0 A_0)
	{
		this.a = A_0;
		this.b();
	}

	// Token: 0x06006973 RID: 26995 RVA: 0x002C7738 File Offset: 0x002C5938
	public bool n()
	{
		return this.b;
	}

	// Token: 0x06006974 RID: 26996 RVA: 0x002C7740 File Offset: 0x002C5940
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006975 RID: 26997 RVA: 0x002C774C File Offset: 0x002C594C
	public double m()
	{
		return this.c;
	}

	// Token: 0x06006976 RID: 26998 RVA: 0x002C7754 File Offset: 0x002C5954
	public void b(double A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006977 RID: 26999 RVA: 0x002C7760 File Offset: 0x002C5960
	public new double? q()
	{
		return this.i;
	}

	// Token: 0x06006978 RID: 27000 RVA: 0x002C7768 File Offset: 0x002C5968
	public void b(double? A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06006979 RID: 27001 RVA: 0x002C7774 File Offset: 0x002C5974
	public double? h()
	{
		return this.j;
	}

	// Token: 0x0600697A RID: 27002 RVA: 0x002C777C File Offset: 0x002C597C
	public void c(double? A_0)
	{
		this.j = A_0;
	}

	// Token: 0x0600697B RID: 27003 RVA: 0x002C7788 File Offset: 0x002C5988
	public double? r()
	{
		return this.k;
	}

	// Token: 0x0600697C RID: 27004 RVA: 0x002C7790 File Offset: 0x002C5990
	public void a(double? A_0)
	{
		this.k = A_0;
	}

	// Token: 0x0600697D RID: 27005 RVA: 0x002C779C File Offset: 0x002C599C
	public eks(c5x A_0) : base(A_0)
	{
		this.ps(d98.b);
		base.l(false);
		base.c(2f);
		this.af2(true);
		this.d = (double)d0u.b;
	}

	// Token: 0x0600697E RID: 27006 RVA: 0x002C77DC File Offset: 0x002C59DC
	public override void mx()
	{
		base.mx();
		this.f = TimeSpan.FromMinutes(this.i.GetValueOrDefault(20.0)).TotalMilliseconds;
		this.g = TimeSpan.FromMinutes(this.j.GetValueOrDefault(10.0)).TotalMilliseconds;
		this.h = TimeSpan.FromMinutes(this.k.GetValueOrDefault(60.0)).TotalMilliseconds;
	}

	// Token: 0x0600697F RID: 27007 RVA: 0x002C7864 File Offset: 0x002C5A64
	public new void l()
	{
		this.c = 0.0;
	}

	// Token: 0x06006980 RID: 27008 RVA: 0x002C7878 File Offset: 0x002C5A78
	public bool o()
	{
		string text;
		return this.b(out text);
	}

	// Token: 0x06006981 RID: 27009 RVA: 0x002C7890 File Offset: 0x002C5A90
	public bool b(out string A_0)
	{
		A_0 = null;
		switch (this.a)
		{
		case g0.a:
			this.a = g0.b;
			this.c = 0.0;
			return true;
		case g0.b:
		case g0.c:
			A_0 = "Огонь уже горит.";
			return false;
		case g0.d:
			A_0 = "Угли ещё горячие, нужно только добавить топлива.";
			return false;
		case g0.e:
			A_0 = "В костре нечему гореть.";
			return false;
		default:
			return false;
		}
	}

	// Token: 0x06006982 RID: 27010 RVA: 0x002C78FC File Offset: 0x002C5AFC
	public bool a(out string A_0)
	{
		A_0 = null;
		switch (this.a)
		{
		case g0.a:
			A_0 = "Топливо уже есть.";
			return false;
		case g0.b:
			this.c = 0.0;
			this.g();
			return true;
		case g0.c:
		case g0.d:
			this.g();
			this.a = g0.b;
			this.c = 0.0;
			return true;
		case g0.e:
			this.a = g0.a;
			return true;
		default:
			return false;
		}
	}

	// Token: 0x06006983 RID: 27011 RVA: 0x002C797C File Offset: 0x002C5B7C
	public new bool p()
	{
		if (this.a != g0.a && this.a != g0.e)
		{
			this.a = g0.e;
			this.c = 0.0;
			return true;
		}
		return false;
	}

	// Token: 0x06006984 RID: 27012 RVA: 0x002C79B0 File Offset: 0x002C5BB0
	public void c9(TimeSpan A_0)
	{
		double num = A_0.TotalMilliseconds;
		if (num > 0.0 && this.a == g0.b && !this.b)
		{
			this.c += num;
			if (this.c >= this.f)
			{
				this.a = g0.c;
				this.c = 0.0;
				num -= this.f;
			}
		}
		if (num > 0.0 && this.a == g0.c && !this.b)
		{
			this.c += num;
			if (this.c >= this.g)
			{
				this.a = g0.d;
				this.c = 0.0;
				num -= this.f;
			}
		}
		if (num > 0.0 && this.a == g0.d)
		{
			if (this.b)
			{
				this.a = g0.b;
				this.c = 0.0;
				return;
			}
			this.c += num;
			if (this.c >= this.h)
			{
				this.a = g0.e;
				this.c = 0.0;
			}
		}
	}

	// Token: 0x06006985 RID: 27013 RVA: 0x002C7B00 File Offset: 0x002C5D00
	public void da(TimeSpan A_0)
	{
	}

	// Token: 0x06006986 RID: 27014 RVA: 0x002C7B08 File Offset: 0x002C5D08
	public void r7(eds A_0)
	{
		a2r a2r = base.a8().GetAspect<a2r>();
		if (a2r == null)
		{
			a2r = new a2r(base.a8());
			base.a8().SetAspect<a2r>(a2r);
		}
		if (this.a == g0.b || this.a == g0.c)
		{
			a2r.a(true);
			a2r.a((float)((this.j() <= 0) ? 0 : (this.j() * 2)));
			if (!base.a8().TileFormationModifiers.c(8192L))
			{
				base.a8().TileFormationModifiers.s3(13);
				base.a8().z();
			}
		}
		else
		{
			a2r.a(false);
			if (base.a8().TileFormationModifiers.c(8192L))
			{
				base.a8().TileFormationModifiers.s4(13);
				base.a8().z();
			}
		}
		this.f();
		if (!dz6.e())
		{
			if ((this.d -= A_0.b.TotalMilliseconds) <= 0.0)
			{
				this.d += (double)d0u.b;
				this.k();
			}
		}
		else
		{
			this.d = (double)d0u.b;
		}
		if (!dz6.e())
		{
			this.a(A_0.b.TotalMilliseconds);
		}
		if ((this.e -= A_0.b.TotalMilliseconds) <= 0.0)
		{
			this.e += 1000.0;
			if (this.a == g0.b || this.a == g0.c)
			{
				dd5.a(base.a8());
			}
		}
	}

	// Token: 0x06006987 RID: 27015 RVA: 0x002C7CDC File Offset: 0x002C5EDC
	private void a(double A_0)
	{
		if (this.a == g0.b)
		{
			if (this.b)
			{
				this.c = 0.0;
			}
			else
			{
				this.c += A_0;
			}
			if (this.c >= this.f)
			{
				this.a = g0.c;
				this.c = 0.0;
				return;
			}
		}
		else if (this.a == g0.c)
		{
			if (this.b)
			{
				this.c = 0.0;
			}
			else
			{
				this.c += A_0;
			}
			if (this.c >= this.g)
			{
				this.a = g0.d;
				this.c = 0.0;
				return;
			}
		}
		else if (this.a == g0.d)
		{
			if (this.b)
			{
				this.a = g0.b;
				this.c = 0.0;
				return;
			}
			this.c += A_0;
			if (this.c >= this.h)
			{
				this.a = g0.e;
				this.c = 0.0;
				return;
			}
		}
		else
		{
			this.c = 0.0;
		}
	}

	// Token: 0x06006988 RID: 27016 RVA: 0x002C7E20 File Offset: 0x002C6020
	public new int j()
	{
		if (this.a == g0.b)
		{
			return 2;
		}
		if (this.a == g0.c)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x06006989 RID: 27017 RVA: 0x002C7E40 File Offset: 0x002C6040
	public void c()
	{
		this.k();
		this.a((double)d0u.b);
	}

	// Token: 0x0600698A RID: 27018 RVA: 0x002C7E58 File Offset: 0x002C6058
	public new void k()
	{
		int num = this.j();
		if (num > 0)
		{
			ak1 ak = Enumerable.FirstOrDefault<ak1>(base.a8().l);
			if (ak != null)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x != base.a8() && c5x.h.b != null && !c5x.h.b.aa().Passive && c5x.aj().a() == ak.Location)
					{
						a1q a_ = c18.a(c5x.h.b.aa(), num, false);
						cwt cwt = new cwt();
						cwt.i = new ap9("Fire", null);
						cwt.f.Add(euf.a(a_, 1.0));
						cwt.l = true;
						cwt.v = "огонь";
						cwt.b = true;
						cwt.w = true;
						c5x.h.b.aa().Defense.a(cwt);
					}
					else if (c5x.y.b != null)
					{
						c5x.y.b.a(null);
					}
				}
				ak.Zone.ActionManager.g9(new eu8(base.a8(), d8o.g, ak, 5, d0u.b * 2, null), atp.a);
			}
		}
	}

	// Token: 0x0600698B RID: 27019 RVA: 0x002C8018 File Offset: 0x002C6218
	public void a(c5x A_0)
	{
		int num = this.j();
		if (num > 0)
		{
			a1q a_ = c18.a(A_0.h.b.aa(), num, true);
			if (A_0.h.b != null && !A_0.h.b.aa().Passive)
			{
				cwt cwt = new cwt();
				cwt.i = new ap9("Fire", null);
				cwt.f.Add(euf.a(a_, 1.0));
				cwt.l = true;
				cwt.v = "огонь";
				cwt.b = true;
				cwt.w = true;
				A_0.h.b.aa().Defense.a(cwt);
			}
		}
	}

	// Token: 0x0600698C RID: 27020 RVA: 0x002C80E4 File Offset: 0x002C62E4
	protected override void mz(c5x A_0, string A_1 = null)
	{
		base.mz(A_0, A_1);
		if (A_0 != null)
		{
			string text = "";
			switch (this.a)
			{
			case g0.a:
				text = "Уголь готов к горению";
				break;
			case g0.b:
				text = "Пламя полыхает.";
				break;
			case g0.c:
				text = "Пламя слабеет.";
				break;
			case g0.d:
				text = "Пока вы смотрите на угли вы успокаиваетесь.";
				break;
			case g0.e:
				text = "Огонь потух.";
				break;
			}
			if (!string.IsNullOrEmpty(text))
			{
				bmj.a(A_0, new d53(text, adi.h, null, true));
				if (A_0.h.b != null)
				{
					a7v.a(new h0(text, null));
				}
			}
		}
	}

	// Token: 0x0600698D RID: 27021 RVA: 0x002C81A0 File Offset: 0x002C63A0
	private void g()
	{
		if (base.a8() != null && base.a8().j == cgy.b && base.a8().Area != null)
		{
			base.a8().c().a("FireplaceRefuel");
			aud a_ = base.a8().Area;
			Vector3 a_2 = base.a8().Location + new Vector3(0f, 0f, 0.15f);
			HorizontalDirection? a_3 = null;
			string a_4 = "ScorchGround";
			int a_5 = 1;
			double maxValue = double.MaxValue;
			float? a_6 = dz6.b();
			boj.a(a_, a_2, a_3, a_4, a_5, maxValue, null, null, a_6, null);
		}
	}

	// Token: 0x0600698E RID: 27022 RVA: 0x002C8260 File Offset: 0x002C6460
	private void f()
	{
		this.b();
		this.a();
		this.e();
	}

	// Token: 0x0600698F RID: 27023 RVA: 0x002C8278 File Offset: 0x002C6478
	private void e()
	{
		ah7 ah = base.a8().Zone.i("Fireplace");
		ah7 ah2 = base.a8().Zone.i("FireplaceLow");
		if (ah == null)
		{
			ah = base.a8().Zone.k("Fireplace");
			ah.Light = new ae8(new Color(255, 150, 40), 1f, LightType.Increment);
			ah.LightFadeRate = 0.22f;
			ah.Range = 5f;
			ah.Layer = aju.x;
			this.d();
		}
		if (ah2 == null)
		{
			ah2 = base.a8().Zone.k("FireplaceLow");
			ah2.Light = new ae8(new Color(255, 150, 40), 0.5f, LightType.Increment);
			ah2.LightFadeRate = 0.15f;
			ah2.Range = 3f;
			ah2.Layer = aju.x;
		}
		bsf bsf = null;
		bsf bsf2 = null;
		foreach (ejt ejt in base.a8().RaysEmitters)
		{
			bsf bsf3 = ejt as bsf;
			if (bsf3 != null)
			{
				if (bsf3.Definition == ah)
				{
					bsf = bsf3;
				}
				else if (bsf3.Definition == ah2)
				{
					bsf2 = bsf3;
				}
			}
		}
		if (this.a == g0.b)
		{
			if (bsf == null)
			{
				bsf = ah.g();
				bsf.be(base.a8());
			}
			if (bsf2 != null)
			{
				bsf2.ig();
				return;
			}
		}
		else if (this.a == g0.c)
		{
			if (bsf2 == null)
			{
				bsf2 = ah2.g();
				bsf2.be(base.a8());
			}
			if (bsf != null)
			{
				bsf.ig();
				return;
			}
		}
		else
		{
			if (bsf != null)
			{
				bsf.ig();
			}
			if (bsf2 != null)
			{
				bsf2.ig();
			}
		}
	}

	// Token: 0x06006990 RID: 27024 RVA: 0x002C8474 File Offset: 0x002C6674
	private void d()
	{
		if (base.a8().GetAspect<t6>() == null)
		{
			t6 t = new t6(base.a8());
			t.b(1);
			t.a(0);
			t.c(0);
			this.a(t, "Fireplace", 0.88f, 1f, 0.0005f);
			this.a(t, "FireplaceLow", 0.45f, 0.5f, 0.00025f);
			base.a8().SetAspect<t6>(t);
		}
	}

	// Token: 0x06006991 RID: 27025 RVA: 0x002C84F8 File Offset: 0x002C66F8
	private void a(t6 A_0, string A_1, float A_2, float A_3, float A_4)
	{
		List<cze> list = A_0.d();
		blw blw = new blw();
		blw.a(A_1);
		blw.b(A_2);
		blw.a(A_3);
		blw.a((double)A_4);
		list.Add(blw);
	}

	// Token: 0x06006992 RID: 27026 RVA: 0x002C8534 File Offset: 0x002C6734
	private void b()
	{
		if (base.a8() != null && base.a8().p.b != null && base.a8().p.b.a.Count >= 3)
		{
			alv alv = base.a8().p.b;
			int x = (int)((this.a > g0.b) ? (this.a - 1) : this.a);
			alv.a[0].b = new Point(x, alv.a[0].b.Y);
			alv.a[1].b = new Point(x, alv.a[1].b.Y);
			if (this.a == g0.b || this.a == g0.c)
			{
				alv.a[2].d = null;
				alv.a[2].b = new Point(alv.a[2].b.X, this.a - g0.b);
				return;
			}
			alv.a[2].d = new float?(0f);
		}
	}

	// Token: 0x06006993 RID: 27027 RVA: 0x002C868C File Offset: 0x002C688C
	private void a()
	{
		aru aru = base.a8().c();
		app app;
		aru.e().TryGetValue("горению", out app);
		if (this.a == g0.b)
		{
			if (app == null)
			{
				aru.a("горению", "FireplaceBurning", 1f, c9z.b, true, false);
			}
		}
		else if (app != null)
		{
			aru.a("горению", false);
		}
		app app2;
		aru.e().TryGetValue("burningLow", out app2);
		if (this.a == g0.c)
		{
			if (app2 == null)
			{
				aru.a("burningLow", "FireplaceBurningLow", 1f, c9z.b, true, false);
				return;
			}
		}
		else if (app2 != null)
		{
			aru.a("burningLow", false);
		}
	}

	// Token: 0x06006994 RID: 27028 RVA: 0x002C8750 File Offset: 0x002C6950
	private static bool a(ak1 A_0, b0b A_1, Point A_2, int A_3)
	{
		return A_0 != null && (double)bnx.a(A_0.Location, A_2) <= 0.9 + (double)A_3 && !A_0.Formation.b(4L);
	}

	// Token: 0x04002B74 RID: 11124
	private new g0 a;

	// Token: 0x04002B75 RID: 11125
	private bool b;

	// Token: 0x04002B76 RID: 11126
	private double c;

	// Token: 0x04002B77 RID: 11127
	private double d;

	// Token: 0x04002B78 RID: 11128
	private double e;

	// Token: 0x04002B79 RID: 11129
	private double f;

	// Token: 0x04002B7A RID: 11130
	private double g;

	// Token: 0x04002B7B RID: 11131
	private double h;

	// Token: 0x04002B7C RID: 11132
	private double? i;

	// Token: 0x04002B7D RID: 11133
	private new double? j;

	// Token: 0x04002B7E RID: 11134
	private new double? k;
}
