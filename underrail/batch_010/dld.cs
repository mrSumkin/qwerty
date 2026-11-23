using System;
using System.Collections.Generic;
using System.Linq;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000BB9 RID: 3001
[euj]
public class dld
{
	// Token: 0x06004481 RID: 17537 RVA: 0x001B6750 File Offset: 0x001B4950
	[ayh("NPCJJQIABP")]
	public void f(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.h.b != null && A_2 != null && A_2["attackResult"] != null)
		{
			cwt cwt = A_2["attackResult"] as cwt;
			if (cwt != null)
			{
				ap9 i = cwt.i;
				if (i != null && !string.IsNullOrWhiteSpace(i.b) && i.b == "player")
				{
					cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
					if (serviceOrThrow.aqu() != null)
					{
						serviceOrThrow.aqu().r()["npc_jackQuicksilver_attacked"] = true;
					}
				}
			}
		}
	}

	// Token: 0x06004482 RID: 17538 RVA: 0x001B6800 File Offset: 0x001B4A00
	[ayh("NPCJCAUABP")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk service = bpo.GetService<cnk>();
		if (service.aqw() != null && (service.aqw().y8() == "lup_freeDroneBase" || service.aqw().y8() == "lup-a6") && A_1 != null && A_1.h.b != null && !A_1.h.b.aa().IsInCombat)
		{
			a27 a_ = new a27(service.aqu().v().b().GetAspect<amc>(), A_1.h.b, false, false, false, true);
			service.aqw().ActionManager.g9(a_, atp.a);
		}
	}

	// Token: 0x06004483 RID: 17539 RVA: 0x001B68C0 File Offset: 0x001B4AC0
	[ayh("LUPGWP")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
			{
				"grampus"
			})) as c5x;
			c5x c5x2 = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x2 != null)
			{
				a1q a_ = default(a1q);
				cwt cwt = new cwt();
				cwt.i = new ap9(c5x.y8(), c5x.h.b.aa().FactionId);
				cwt.l = true;
				cwt.b = true;
				cwt.e = false;
				cwt.w = false;
				if (serviceOrThrow.aqu().ae() <= GameDifficulty.Normal)
				{
					a_ = new a1q(DamageType.Heat, 8, 21);
				}
				if (serviceOrThrow.aqu().ae() == GameDifficulty.Hard)
				{
					a_ = new a1q(DamageType.Heat, 12, 29);
				}
				if (serviceOrThrow.aqu().ae() == GameDifficulty.Dominating)
				{
					a_ = new a1q(DamageType.Heat, 21, 47);
				}
				cwt.f.Clear();
				cwt.f.Add(euf.a(a_, 1.0));
				c5x2.h.b.aa().Defense.a(cwt);
				bfq bfq = new bfq();
				bfq.c("TchortSowerAttack");
				bfq.a(bvl.d);
				bfq.ym(c5x2, c5x2, null);
				bfq bfq2 = new bfq();
				bfq2.c("FireballSpread");
				bfq2.a(bvl.d);
				bfq2.ym(c5x2, c5x2, null);
			}
		}
	}

	// Token: 0x06004484 RID: 17540 RVA: 0x001B6A54 File Offset: 0x001B4C54
	[ayh("LUPGBP")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(serviceOrThrow.aqw().a().ab4(new string[]
			{
				"grampus"
			})) as c5x;
			c5x c5x2 = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x2 != null)
			{
				a1q a_ = default(a1q);
				cwt cwt = new cwt();
				cwt.i = new ap9(c5x.y8(), c5x.h.b.aa().FactionId);
				cwt.l = true;
				cwt.b = true;
				cwt.e = false;
				cwt.w = false;
				if (serviceOrThrow.aqu().ae() <= GameDifficulty.Normal)
				{
					a_ = new a1q(DamageType.Heat, 45, 97);
				}
				if (serviceOrThrow.aqu().ae() == GameDifficulty.Hard)
				{
					a_ = new a1q(DamageType.Heat, 67, 112);
				}
				if (serviceOrThrow.aqu().ae() == GameDifficulty.Dominating)
				{
					a_ = new a1q(DamageType.Heat, 105, 182);
				}
				cwt.f.Clear();
				cwt.f.Add(euf.a(a_, 1.0));
				c5x2.h.b.aa().Defense.a(cwt);
				bfq bfq = new bfq();
				bfq.c("FireballSpread");
				bfq.a(bvl.d);
				bfq.ym(c5x2, c5x2, null);
				bfq bfq2 = new bfq();
				bfq2.c("FireballLaunch");
				bfq2.a(bvl.d);
				bfq2.ym(c5x2, c5x2, null);
				c5x2.h.b.aa().d(CharacterImmunities.Daze);
			}
		}
	}

	// Token: 0x06004485 RID: 17541 RVA: 0x001B6C08 File Offset: 0x001B4E08
	[ayh("XPBLRIGSGDADIP")]
	public void d(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (A_0 != null && !A_0.IsPlayer)
		{
			c5x = A_0;
		}
		else if (A_1 != null && !A_1.IsPlayer)
		{
			c5x = A_1;
		}
		if (c5x != null && c5x.t.b != null)
		{
			cnk service = bpo.GetService<cnk>();
			if (service.aqu() != null)
			{
				service.aqu().r()["loc_xpbl_rig_dogs_timeTillNextAutoDialogInit"] = service.aqu().o() + TimeSpan.FromSeconds((double)cuo.a.Next(5, 7));
				c5x.t.b.y6()[ddq.bf] = "loc_xpbl_rig_dogs_timeTillNextAutoDialogInit";
			}
		}
	}

	// Token: 0x06004486 RID: 17542 RVA: 0x001B6CC4 File Offset: 0x001B4EC4
	[ayh("XPBLBUFFWBA")]
	public void e(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (A_0 != null && !A_0.IsPlayer)
		{
			c5x = A_0;
		}
		else if (A_1 != null && !A_1.IsPlayer)
		{
			c5x = A_1;
		}
		if (c5x == null || c5x.Zone == null || c5x.t.b == null || c5x.h.b == null || c5x.i.b == null || c5x.t.b.ac().Equals("buffalo"))
		{
			return;
		}
		TimeSpan? primitivePropertyValue = c5x.t.b.y6().GetPrimitivePropertyValue<TimeSpan>(ddq.a, null);
		if (primitivePropertyValue == null || primitivePropertyValue.Value <= c5x.Zone.ElapsedZoneTime)
		{
			string text = new amt(c5x.t.b).a(c5x.h.b);
			if (text != null)
			{
				c5x.c().a("mooing", text, 1f, c9z.a, false, false);
				awx awx = new awx();
				awx awx2 = awx;
				awx2.a(awx2.kh() | m7.b);
				awx.ad().Add(new e4t(c5x.h.b, CharacterState.Custom4, cux.a, 0, null, 1));
				c5x.i.b.b(awx, atp.a);
			}
			c5x.t.b.y6()[ddq.a] = c5x.Zone.ElapsedZoneTime + TimeSpan.FromMilliseconds(1500.0);
		}
	}
}
