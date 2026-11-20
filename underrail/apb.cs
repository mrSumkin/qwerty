using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000BBB RID: 3003
[euj]
public class apb
{
	// Token: 0x0600448F RID: 17551 RVA: 0x001B72FC File Offset: 0x001B54FC
	public void b()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		c5x c5x = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
		{
			"xpbl_deb_bomb1"
		})) as c5x;
		if (c5x != null)
		{
			dm aspect = c5x.GetAspect<dm>();
			if (aspect != null)
			{
				(Enumerable.FirstOrDefault<cze>(aspect.d()) as b08).a(cuo.a.Next(130, 185));
			}
		}
		c5x c5x2 = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
		{
			"xpbl_deb_bomb2"
		})) as c5x;
		if (c5x2 != null)
		{
			dm aspect2 = c5x2.GetAspect<dm>();
			if (aspect2 != null)
			{
				(Enumerable.FirstOrDefault<cze>(aspect2.d()) as b08).a(cuo.a.Next(140, 170));
			}
		}
		c5x c5x3 = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
		{
			"xpbl_deb_bomb3"
		})) as c5x;
		if (c5x3 != null)
		{
			dm aspect3 = c5x3.GetAspect<dm>();
			if (aspect3 != null)
			{
				(Enumerable.FirstOrDefault<cze>(aspect3.d()) as b08).a(cuo.a.Next(125, 200));
			}
		}
		c5x c5x4 = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
		{
			"xpbl_deb_sailor"
		})) as c5x;
		if (c5x4 != null && c5x4.h != null && Enumerable.FirstOrDefault<axo>(c5x4.h.b.aa().StatusEffects.Get<axo>()) == null)
		{
			c5x4.h.b.aa().StatusEffects.a(new axo(0, null), false, false, false);
		}
	}

	// Token: 0x06004490 RID: 17552 RVA: 0x001B74CC File Offset: 0x001B56CC
	[ayh("XPBLDEBJDBO")]
	public void j(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.b("bomb1", "xpbl_deb_bomb1");
	}

	// Token: 0x06004491 RID: 17553 RVA: 0x001B74E0 File Offset: 0x001B56E0
	[ayh("XPBLDEBJDBT")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.b("bomb2", "xpbl_deb_bomb2");
	}

	// Token: 0x06004492 RID: 17554 RVA: 0x001B74F4 File Offset: 0x001B56F4
	[ayh("XPBLDEBJDBTR")]
	public void k(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.b("bomb3", "xpbl_deb_bomb3");
	}

	// Token: 0x06004493 RID: 17555 RVA: 0x001B7508 File Offset: 0x001B5708
	[ayh("XPBLDEBJDABO")]
	public void g(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.c("xpbl_deb_destroyPart1", "xpbl_deb_revealPart1");
	}

	// Token: 0x06004494 RID: 17556 RVA: 0x001B751C File Offset: 0x001B571C
	[ayh("XPBLDEBJDABOC")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.c("xpbl_deb_destroyPart1", "xpbl_deb_revealPart1");
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		serviceOrThrow.aqu().r()["xpbl_deb_allBombsExploded"] = true;
		dtb dtb = new dtb();
		dtb.ad().Add(new bm3(cuo.a.Next(2000, 3600)));
		dtb.ad().Add(new eae("XPBLDEBJDABT", null, new ar7(A_1), null));
		dtb.ad().Add(new bm3(cuo.a.Next(1000, 3600)));
		dtb.ad().Add(new eae("XPBLDEBJDABTR", null, new ar7(A_1), null));
		serviceOrThrow.aqw().ActionManager.g9(dtb, atp.a);
	}

	// Token: 0x06004495 RID: 17557 RVA: 0x001B75F4 File Offset: 0x001B57F4
	[ayh("XPBLDEBJDABT")]
	public void i(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.c("xpbl_deb_destroyPart2", "xpbl_deb_revealPart2");
	}

	// Token: 0x06004496 RID: 17558 RVA: 0x001B7608 File Offset: 0x001B5808
	[ayh("XPBLDEBJDABTC")]
	public void m(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.c("xpbl_deb_destroyPart2", "xpbl_deb_revealPart2");
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		serviceOrThrow.aqu().r()["xpbl_deb_allBombsExploded"] = true;
		dtb dtb = new dtb();
		dtb.ad().Add(new bm3(cuo.a.Next(2000, 3600)));
		dtb.ad().Add(new eae("XPBLDEBJDABO", null, new ar7(A_1), null));
		dtb.ad().Add(new bm3(cuo.a.Next(1000, 3600)));
		dtb.ad().Add(new eae("XPBLDEBJDABTR", null, new ar7(A_1), null));
		serviceOrThrow.aqw().ActionManager.g9(dtb, atp.a);
	}

	// Token: 0x06004497 RID: 17559 RVA: 0x001B76E0 File Offset: 0x001B58E0
	[ayh("XPBLDEBJDABTR")]
	public void h(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.c("xpbl_deb_destroyPart3", "xpbl_deb_revealPart3");
	}

	// Token: 0x06004498 RID: 17560 RVA: 0x001B76F4 File Offset: 0x001B58F4
	[ayh("XPBLDEBJDABTRC")]
	public void l(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.c("xpbl_deb_destroyPart3", "xpbl_deb_revealPart3");
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		serviceOrThrow.aqu().r()["xpbl_deb_allBombsExploded"] = true;
		dtb dtb = new dtb();
		dtb.ad().Add(new bm3(cuo.a.Next(2000, 3600)));
		dtb.ad().Add(new eae("XPBLDEBJDABO", null, new ar7(A_1), null));
		dtb.ad().Add(new bm3(cuo.a.Next(1000, 3600)));
		dtb.ad().Add(new eae("XPBLDEBJDABT", null, new ar7(A_1), null));
		serviceOrThrow.aqw().ActionManager.g9(dtb, atp.a);
	}

	// Token: 0x06004499 RID: 17561 RVA: 0x001B77CC File Offset: 0x001B59CC
	[ayh("XPBLDEBJDTBO")]
	public void d(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.b("bomb1", "xpbl_deb_bomb1");
		this.a("xpbl_deb_bomb1");
	}

	// Token: 0x0600449A RID: 17562 RVA: 0x001B77EC File Offset: 0x001B59EC
	[ayh("XPBLDEBJDTBT")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.b("bomb2", "xpbl_deb_bomb2");
		this.a("xpbl_deb_bomb2");
	}

	// Token: 0x0600449B RID: 17563 RVA: 0x001B780C File Offset: 0x001B5A0C
	[ayh("XPBLDEBJDTBTH")]
	public void f(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		this.b("bomb3", "xpbl_deb_bomb3");
		this.a("xpbl_deb_bomb3");
	}

	// Token: 0x0600449C RID: 17564 RVA: 0x001B782C File Offset: 0x001B5A2C
	[ayh("XPBLDEBJDTUB")]
	public void n(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		List<b0b> list = serviceOrThrow.aqw().a().ab4(new string[]
		{
			"xpbl_deb_box"
		});
		serviceOrThrow.aqu().r()["xpbl_deb_boxAccessGranted"] = true;
		foreach (b0b b0b in list)
		{
			c5x c5x = (c5x)b0b;
			c5x.RemoveAspect<c3g>();
			cid cid = new cid();
			cid.d(false);
			cid.ym(c5x, c5x, null);
		}
	}

	// Token: 0x0600449D RID: 17565 RVA: 0x001B78D8 File Offset: 0x001B5AD8
	[ayh("XPBLDEBJDTUV")]
	public void e(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d60 d = serviceOrThrow.aqw().a();
		serviceOrThrow.aqu().r()["xpbl_deb_valveAccessGranted"] = true;
		foreach (b0b b0b in d.ab4(new string[]
		{
			"xpbl_deb_valve"
		}))
		{
			bim aspect = ((c5x)b0b).GetAspect<bim>();
			if (aspect != null)
			{
				aspect.g(true);
			}
		}
	}

	// Token: 0x0600449E RID: 17566 RVA: 0x001B797C File Offset: 0x001B5B7C
	public void a(string A_0, string A_1)
	{
		d60 d = bpo.GetServiceOrThrow<cnk>().aqw().a();
		List<b0b> list = d.ab4(new string[]
		{
			A_0
		});
		foreach (b0b b0b in list)
		{
			c5x c5x = (c5x)b0b;
			c5x.w();
			c5x.an();
		}
		list.Clear();
		list = d.ab4(new string[]
		{
			A_1
		});
		foreach (b0b b0b2 in list)
		{
			((c5x)b0b2).ae = new float?((float)1);
		}
		cav cav = new cav();
		cav.a(cuo.a.Next(15, 22) * 100);
		cav.ym(null, null, null);
	}

	// Token: 0x0600449F RID: 17567 RVA: 0x001B7A84 File Offset: 0x001B5C84
	public void b(string A_0, string A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		c5x c5x = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
		{
			"xpbl_deb_dataSource"
		})) as c5x;
		if (c5x != null)
		{
			a3f aspect = c5x.GetAspect<a3f>();
			if (aspect != null)
			{
				List<string> classPropertyValue = aspect.a().GetClassPropertyValue<List<string>>("ActiveBombs");
				classPropertyValue.Remove(A_0);
				aspect.a()["ActiveBombs"] = classPropertyValue;
				if (classPropertyValue.Count == 0)
				{
					serviceOrThrow.aqu().r()["xpbl_deb_allBombsDeactivated"] = true;
					c5x c5x2 = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
					{
						"xpbl_deb_sailor"
					})) as c5x;
					if (c5x2 != null && c5x2.h != null)
					{
						axo axo = Enumerable.FirstOrDefault<axo>(c5x2.h.b.aa().StatusEffects.Get<axo>());
						if (axo != null)
						{
							c5x2.h.b.aa().StatusEffects.d(axo);
						}
					}
				}
			}
		}
		c5x c5x3 = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
		{
			A_1
		})) as c5x;
		if (c5x3 != null)
		{
			aru aspect2 = c5x3.GetAspect<aru>();
			if (aspect2 != null)
			{
				aspect2.a("leak", false);
			}
			alv aspect3 = c5x3.GetAspect<alv>();
			if (aspect3 != null)
			{
				aspect3.a[1].d = new float?(0f);
			}
			dm aspect4 = c5x3.GetAspect<dm>();
			if (aspect4 != null)
			{
				aspect4.b(false);
			}
		}
	}

	// Token: 0x060044A0 RID: 17568 RVA: 0x001B7C38 File Offset: 0x001B5E38
	public void c(string A_0, string A_1)
	{
		string text = "";
		if (!(A_0 == "xpbl_deb_destroyPart1"))
		{
			if (!(A_0 == "xpbl_deb_destroyPart2"))
			{
				if (A_0 == "xpbl_deb_destroyPart3")
				{
					text = "xpbl_deb_bomb3Center";
				}
			}
			else
			{
				text = "xpbl_deb_bomb2Center";
			}
		}
		else
		{
			text = "xpbl_deb_bomb1Center";
		}
		c5x c5x = Enumerable.FirstOrDefault<b0b>(bpo.GetServiceOrThrow<cnk>().aqw().a().ab4(new string[]
		{
			text
		})) as c5x;
		if (c5x != null)
		{
			ak1 a_ = c5x.Area.b((int)c5x.Location.X, (int)c5x.Location.Y);
			boj.a(c5x, "NapalmExplosion", 1, double.MaxValue, false, false, null, null, null, null, false);
			dd5.a(null, a_, 1.0, int.MaxValue, true);
			dm5 dm = new dm5();
			dm.d(c5x.y8());
			dm.a(6);
			dm.d(true);
			dm.s().Add(new a1q(DamageType.Heat, 10000, 20000));
			dm.s().Add(new a1q(DamageType.Mechanical, 7500, 17500));
			dm.ym(null, c5x, null);
			dm.a(new AmmoType?(AmmoType.HighExplosives));
			dm.a(0.1);
			dm.c(true);
			dm.ym(null, c5x, null);
			c5x.w();
			c5x.an();
			this.a(A_0, A_1);
		}
	}

	// Token: 0x060044A1 RID: 17569 RVA: 0x001B7DE8 File Offset: 0x001B5FE8
	public void a(string A_0)
	{
		c5x c5x = Enumerable.FirstOrDefault<b0b>(bpo.GetServiceOrThrow<cnk>().aqw().a().ab4(new string[]
		{
			A_0
		})) as c5x;
		if (c5x != null)
		{
			Vector3 value = new Vector3(1f, 0f, 0f);
			if (A_0.Equals("xpbl_deb_bomb1"))
			{
				value.X = 0f;
				value.Y = 1f;
			}
			boj.a(c5x, "WaterSplashLarge", 1, double.MaxValue, false, false, new Vector3?(value), null, null, null, false);
			bfq bfq = new bfq();
			bfq.c("WaterSplashGiant");
			bfq.a(bvl.e);
			bfq.a(new Guid?(c5x.qe()));
			bfq.ym(null, null, null);
			c5x.w();
			c5x.an();
		}
	}

	// Token: 0x060044A2 RID: 17570 RVA: 0x001B7EDC File Offset: 0x001B60DC
	public void a()
	{
		c5x c5x = Enumerable.FirstOrDefault<b0b>(bpo.GetServiceOrThrow<cnk>().aqw().a().ab4(new string[]
		{
			"xpbl_deb_dataSource"
		})) as c5x;
		if (c5x != null)
		{
			aud aud = cze.a(null, c5x, c5x, null);
			foreach (ya ya in Enumerable.ToList<ya>(c5x.Area.Triggers))
			{
				if (ya.Name.Equals("OilArea"))
				{
					for (int i = ya.Location.X; i < ya.Location.X + ya.Size.c; i++)
					{
						for (int j = ya.Location.Y; j < ya.Location.Y + ya.Size.d; j++)
						{
							new e3d(new edx(aud.b(i, j)), null, false, true).ym(c5x, c5x, null);
						}
					}
				}
			}
		}
	}
}
