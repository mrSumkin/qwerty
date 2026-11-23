using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Common.Data;
using TimelapseVertigo.Game.Controllers;

// Token: 0x02000585 RID: 1413
public sealed class zq : LocaleSubInterfaceController<d49, e89>, bu2
{
	// Token: 0x0600248B RID: 9355 RVA: 0x000CE060 File Offset: 0x000CC260
	public ble nt()
	{
		return this.e;
	}

	// Token: 0x0600248C RID: 9356 RVA: 0x000CE068 File Offset: 0x000CC268
	public ble nu()
	{
		return this.f;
	}

	// Token: 0x0600248D RID: 9357 RVA: 0x000CE070 File Offset: 0x000CC270
	public bool nv()
	{
		return this.a != null && this.a.c();
	}

	// Token: 0x0600248E RID: 9358 RVA: 0x000CE08C File Offset: 0x000CC28C
	public bool d()
	{
		return this.a != null && this.a.g();
	}

	// Token: 0x0600248F RID: 9359 RVA: 0x000CE0A8 File Offset: 0x000CC2A8
	public epf nw()
	{
		return this.d;
	}

	// Token: 0x06002490 RID: 9360 RVA: 0x000CE0B0 File Offset: 0x000CC2B0
	public string nx()
	{
		return this.i;
	}

	// Token: 0x06002491 RID: 9361 RVA: 0x000CE0B8 File Offset: 0x000CC2B8
	public b0b ny()
	{
		return this.m;
	}

	// Token: 0x06002492 RID: 9362 RVA: 0x000CE0C0 File Offset: 0x000CC2C0
	public void a(b0b A_0)
	{
		this.m = A_0;
	}

	// Token: 0x06002493 RID: 9363 RVA: 0x000CE0CC File Offset: 0x000CC2CC
	public zq(dka A_0) : base(A_0, false, false, false)
	{
	}

	// Token: 0x06002494 RID: 9364 RVA: 0x000CE0E4 File Offset: 0x000CC2E4
	public void nz()
	{
		bool flag = this.a();
		this.a(true);
		while (flag)
		{
			this.d.aue();
			this.a(false);
			flag = this.a();
		}
	}

	// Token: 0x06002495 RID: 9365 RVA: 0x000CE124 File Offset: 0x000CC324
	public bool b(b0b A_0)
	{
		return base.j() && (this.h == A_0 || this.g == A_0);
	}

	// Token: 0x06002496 RID: 9366 RVA: 0x000CE14C File Offset: 0x000CC34C
	public ble n0(string A_0)
	{
		zq.a a = new zq.a();
		a.a = A_0;
		if (a.a == null)
		{
			return null;
		}
		if (this.b != null)
		{
			return Enumerable.FirstOrDefault<ble>(Enumerable.Where<ble>(this.b, new Func<ble, bool>(a.a)));
		}
		return null;
	}

	// Token: 0x06002497 RID: 9367 RVA: 0x000CE19C File Offset: 0x000CC39C
	protected override bool n1(e89 A_0)
	{
		czh.a(A_0, "context");
		dpn dpn = bpo.GetServiceOrThrow<cnk>().aqu().e();
		PropertyCollection propertyCollection = new PropertyCollection();
		propertyCollection[c49.a] = A_0.h();
		propertyCollection[c49.b] = A_0.e();
		dpn.a().Add(propertyCollection);
		zq.a(dpn, A_0.h());
		zq.a(dpn, A_0.e());
		this.a = A_0.d();
		this.g = A_0.h();
		this.h = A_0.e();
		this.b = A_0.i();
		this.c = dpn;
		this.j = A_0.c();
		this.k = A_0.b();
		this.l = A_0.a();
		this.m = A_0.g();
		this.a(this.c, this.l, this.g, this.h);
		this.b();
		if (this.j && this.d.at7() != null && (this.d.at7().e() == null || this.d.at7().e().PossibleNextSteps == null || this.d.at7().e().PossibleNextSteps.Count == 0) && this.d.at7().d().Count == 0 && !string.IsNullOrWhiteSpace(this.i))
		{
			b0b b0b;
			if (!(this.h as c5x).IsPlayer)
			{
				b0b = this.h;
			}
			else
			{
				b0b = this.g;
			}
			if (b0b != null)
			{
				c0s aspect = b0b.GetAspect<c0s>();
				if (aspect != null)
				{
					aspect.a(this.i, true, null, null);
					return false;
				}
			}
		}
		base.a(base.g().ac().a(this));
		base.g().aml();
		base.g().amf();
		if (this.a.g())
		{
			base.g().amh();
		}
		return true;
	}

	// Token: 0x06002498 RID: 9368 RVA: 0x000CE3D8 File Offset: 0x000CC5D8
	protected override void n2(el5 A_0)
	{
		base.g().akx().aey();
		base.g().amm();
		base.g().amg();
		if (this.a.g())
		{
			base.g().ami();
		}
		dz6.c(2000);
	}

	// Token: 0x06002499 RID: 9369 RVA: 0x000CE430 File Offset: 0x000CC630
	private void c()
	{
		if (this.e != null && this.e.ActorEntity != null)
		{
			if ((!this.j || this.d.at7() == null || this.d.at7().d().Count > 0 || this.d.at7().e().PossibleNextSteps.Count > 0 || string.IsNullOrWhiteSpace(this.i)) && (this.d.at7() == null || this.d.at7().e() == null || this.d.at7().e().Name == null || !this.d.at7().e().Name.EndsWith("*")) && this.e.ActorEntity != null && this.e.ActorEntity.Area != null)
			{
				base.g().ams(this.e.ActorEntity, false, null);
			}
			if (this.k && this.f != null && this.f.ActorEntity != null && this.e != null && this.e.ActorEntity != null && this.f.ActorEntity.Area == this.e.ActorEntity.Area && this.e.ActorEntity.Area != null)
			{
				if (!(this.e.ActorEntity.GetAspect<j7>() is e6) && this.e.ActorEntity.GetAspect<amc>() != null)
				{
					aw1.b(this.e.ActorEntity, this.f.ActorEntity, true);
					c5x c5x = this.e.ActorEntity as c5x;
					if (c5x.i.b != null)
					{
						c5x.i.b.a(m7.b, true, false);
					}
				}
				if (!(this.f.ActorEntity.GetAspect<j7>() is e6) && this.f.ActorEntity.GetAspect<amc>() != null)
				{
					aw1.b(this.f.ActorEntity, this.e.ActorEntity, true);
				}
			}
		}
	}

	// Token: 0x0600249A RID: 9370 RVA: 0x000CE6AC File Offset: 0x000CC8AC
	private void a(bq8 A_0, PropertyCollection A_1, b0b A_2, b0b A_3)
	{
		if (this.a == null)
		{
			return;
		}
		HashSet<d55> a_ = new HashSet<d55>();
		this.a(this.a.b(), A_0, A_1, a_);
	}

	// Token: 0x0600249B RID: 9371 RVA: 0x000CE6E0 File Offset: 0x000CC8E0
	private void a(d55 A_0, bq8 A_1, PropertyCollection A_2, HashSet<d55> A_3)
	{
		List<d55> list = Enumerable.ToList<d55>(A_0.PossibleNextSteps);
		ad7 ad = A_0 as ad7;
		if (ad != null)
		{
			list.AddRange(ad.PossibleAnswers);
		}
		foreach (d55 d in list)
		{
			if (!A_3.Contains(d))
			{
				A_3.Add(d);
				ad7 ad2 = d as ad7;
				if (ad2 != null && Enumerable.Any<bm5>(Enumerable.OfType<bm5>(ad2.e())))
				{
					zq.a(ad2, A_1, A_2);
				}
				this.a(d, true);
				this.a(d, A_1, A_2, A_3);
			}
		}
	}

	// Token: 0x0600249C RID: 9372 RVA: 0x000CE7AC File Offset: 0x000CC9AC
	private void a(d55 A_0, bool A_1)
	{
		dzc dzc = A_0 as dzc;
		if (dzc != null && dzc.e() != null && dzc.e().Count > 0)
		{
			foreach (esc esc in dzc.e())
			{
				aax aax = esc as aax;
				if (aax != null && (aax.a() || A_1))
				{
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary["dialog"] = this.a;
					dictionary["node"] = dzc;
					dictionary["initiator"] = this.g;
					dictionary["target"] = this.h;
					ea5.a(aax.b(), this.g as c5x, this.h as c5x, dictionary);
				}
			}
		}
	}

	// Token: 0x0600249D RID: 9373 RVA: 0x000CE8A8 File Offset: 0x000CCAA8
	private static void a(ad7 A_0, bq8 A_1, PropertyCollection A_2)
	{
		string text = "__rumorInt_" + A_0.Name;
		int num = 0;
		int num2 = 0;
		foreach (d55 d in Enumerable.ToList<d55>(A_0.PossibleNextSteps))
		{
			ad7 ad = d as ad7;
			if (ad != null)
			{
				if (ad.CausingCondition != null && ad.CausingCondition.h() == "__RumorFilterCondition")
				{
					cq2 cq = ad.CausingCondition as cq2;
					if (cq != null)
					{
						aag aag = cq.a()[0] as aag;
						if (aag != null)
						{
							List<dnh> list = aag.a();
							e7k e7k = new e7k();
							e7k.b("tempcontext." + text);
							e7k.a(ei6.a);
							e7k.a(null);
							e7k.b(false);
							list.Add(e7k);
						}
						List<dnh> list2 = cq.a();
						cjo cjo = new cjo(text);
						cjo.b(num2);
						cjo.a(num2);
						list2.Add(cjo);
					}
					num++;
					num2++;
				}
				else if (ad.CausingCondition == null || ad.CausingCondition.cw(A_1, A_2))
				{
					aag aag2 = new aag();
					if (ad.CausingCondition != null)
					{
						aag2.a().Add(ad.CausingCondition);
					}
					List<dnh> list3 = aag2.a();
					e7k e7k2 = new e7k();
					e7k2.b("tempcontext." + text);
					e7k2.a(ei6.a);
					e7k2.a(null);
					e7k2.b(false);
					list3.Add(e7k2);
					cq2 cq2 = new cq2();
					cq2.d("__RumorFilterCondition");
					cq2 cq3 = cq2;
					ad.CausingCondition = cq3;
					cq3.a().Add(aag2);
					List<dnh> list4 = cq3.a();
					cjo cjo2 = new cjo(text);
					cjo2.b(num2);
					cjo2.a(num2);
					list4.Add(cjo2);
					num++;
					num2++;
				}
				else
				{
					A_0.PossibleNextSteps.Remove(d);
				}
				Collection<esc> collection = ad.e();
				cgg cgg = new cgg();
				cgg.b("tempcontext." + text);
				cgg.a(null);
				collection.Add(cgg);
			}
			else
			{
				A_0.PossibleNextSteps.Remove(d);
			}
		}
		A_0.e().Add(new e72());
		Collection<esc> collection2 = A_0.e();
		eng eng = new eng(text);
		eng.a(num);
		collection2.Add(eng);
	}

	// Token: 0x0600249E RID: 9374 RVA: 0x000CEB50 File Offset: 0x000CCD50
	private void b()
	{
		eve serviceOrThrow = bpo.GetServiceOrThrow<eve>();
		this.d = serviceOrThrow.y5(this.a, this.c, this.l);
		this.d.at1(new EventHandler(this.a));
		this.d.aua();
		this.nz();
	}

	// Token: 0x0600249F RID: 9375 RVA: 0x000CEBAC File Offset: 0x000CCDAC
	private void a(object A_0, EventArgs A_1)
	{
		dzc dzc = A_0 as dzc;
		if (dzc != null)
		{
			this.a(dzc, false);
		}
	}

	// Token: 0x060024A0 RID: 9376 RVA: 0x000CEBD0 File Offset: 0x000CCDD0
	private static void a(dpn A_0, b0b A_1)
	{
		if (A_1 != null)
		{
			a3f aspect = A_1.GetAspect<a3f>();
			if (aspect != null && aspect.a() != null)
			{
				A_0.a().Add(aspect.a());
			}
		}
	}

	// Token: 0x060024A1 RID: 9377 RVA: 0x000CEC0C File Offset: 0x000CCE0C
	private bool a()
	{
		return this.d.at7() != null && this.d.at7().e() != null && this.d.at7().e().Name.EndsWith("*") && (this.d.at7().d() == null || this.d.at7().d().Count == 0);
	}

	// Token: 0x060024A2 RID: 9378 RVA: 0x000CEC94 File Offset: 0x000CCE94
	private bool a(bool A_0)
	{
		if (A_0)
		{
			this.i = "";
		}
		if (this.d.at7() == null)
		{
			base.ad();
			return true;
		}
		this.i += this.d.at7().b();
		if (A_0)
		{
			this.e = this.n0(this.d.at7().f());
			this.f = this.n0(this.d.at7().g());
		}
		this.c();
		return false;
	}

	// Token: 0x04001539 RID: 5433
	private new azm a;

	// Token: 0x0400153A RID: 5434
	private List<ble> b;

	// Token: 0x0400153B RID: 5435
	private bq8 c;

	// Token: 0x0400153C RID: 5436
	private epf d;

	// Token: 0x0400153D RID: 5437
	private new ble e;

	// Token: 0x0400153E RID: 5438
	private ble f;

	// Token: 0x0400153F RID: 5439
	private b0b g;

	// Token: 0x04001540 RID: 5440
	private b0b h;

	// Token: 0x04001541 RID: 5441
	private string i = "";

	// Token: 0x04001542 RID: 5442
	private bool j;

	// Token: 0x04001543 RID: 5443
	private bool k;

	// Token: 0x04001544 RID: 5444
	private PropertyCollection l;

	// Token: 0x04001545 RID: 5445
	private b0b m;

	// Token: 0x02000589 RID: 1417
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060024C9 RID: 9417 RVA: 0x000CFEE8 File Offset: 0x000CE0E8
		internal bool a(ble A_0)
		{
			return A_0.ActorId != null && A_0.ActorId.Equals(this.a);
		}

		// Token: 0x04001560 RID: 5472
		public string a;
	}
}
