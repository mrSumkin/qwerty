using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;
using TimelapseVertigo.AI.Model.TurnBased;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x020002C0 RID: 704
[apc("humanSoldier")]
public class esk : cqw
{
	// Token: 0x170000FD RID: 253
	// (get) Token: 0x06001473 RID: 5235 RVA: 0x00059488 File Offset: 0x00057688
	// (set) Token: 0x06001474 RID: 5236 RVA: 0x00059490 File Offset: 0x00057690
	public bool Caster
	{
		get
		{
			return this.dc;
		}
		set
		{
			this.dc = value;
		}
	}

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x06001475 RID: 5237 RVA: 0x0005949C File Offset: 0x0005769C
	// (set) Token: 0x06001476 RID: 5238 RVA: 0x000594A4 File Offset: 0x000576A4
	public bool AvoidWeaponCombat
	{
		get
		{
			return this.dd;
		}
		set
		{
			this.dd = value;
		}
	}

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x06001477 RID: 5239 RVA: 0x000594B0 File Offset: 0x000576B0
	// (set) Token: 0x06001478 RID: 5240 RVA: 0x000594B8 File Offset: 0x000576B8
	public bool Reckless
	{
		get
		{
			return this.de;
		}
		set
		{
			this.de = value;
		}
	}

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x06001479 RID: 5241 RVA: 0x000594C4 File Offset: 0x000576C4
	// (set) Token: 0x0600147A RID: 5242 RVA: 0x000594CC File Offset: 0x000576CC
	public int KiteDistance
	{
		get
		{
			return this.df;
		}
		set
		{
			this.df = value;
		}
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x0600147B RID: 5243 RVA: 0x000594D8 File Offset: 0x000576D8
	// (set) Token: 0x0600147C RID: 5244 RVA: 0x000594E0 File Offset: 0x000576E0
	public int KiteStep
	{
		get
		{
			return this.dg;
		}
		set
		{
			this.dg = value;
		}
	}

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x0600147D RID: 5245 RVA: 0x000594EC File Offset: 0x000576EC
	// (set) Token: 0x0600147E RID: 5246 RVA: 0x000594F4 File Offset: 0x000576F4
	public bool SwitchesToBetterWeapon
	{
		get
		{
			return this.dh;
		}
		set
		{
			this.dh = value;
		}
	}

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x0600147F RID: 5247 RVA: 0x00059500 File Offset: 0x00057700
	// (set) Token: 0x06001480 RID: 5248 RVA: 0x00059508 File Offset: 0x00057708
	public bool AlwaysBursts
	{
		get
		{
			return this.di;
		}
		set
		{
			this.di = value;
		}
	}

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x06001481 RID: 5249 RVA: 0x00059514 File Offset: 0x00057714
	// (set) Token: 0x06001482 RID: 5250 RVA: 0x0005951C File Offset: 0x0005771C
	public bool RemoveCustomState
	{
		get
		{
			return this.dj;
		}
		set
		{
			this.dj = value;
		}
	}

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x06001483 RID: 5251 RVA: 0x00059528 File Offset: 0x00057728
	// (set) Token: 0x06001484 RID: 5252 RVA: 0x00059530 File Offset: 0x00057730
	public bool KnifeThrower
	{
		get
		{
			return this.dk;
		}
		set
		{
			this.dk = value;
		}
	}

	// Token: 0x17000106 RID: 262
	// (get) Token: 0x06001485 RID: 5253 RVA: 0x0005953C File Offset: 0x0005773C
	// (set) Token: 0x06001486 RID: 5254 RVA: 0x00059544 File Offset: 0x00057744
	public bool PoisonKiting
	{
		get
		{
			return this.dl;
		}
		set
		{
			this.dl = value;
		}
	}

	// Token: 0x17000107 RID: 263
	// (get) Token: 0x06001487 RID: 5255 RVA: 0x00059550 File Offset: 0x00057750
	// (set) Token: 0x06001488 RID: 5256 RVA: 0x00059558 File Offset: 0x00057758
	public bool DoppelgangerKite
	{
		get
		{
			return this.dm;
		}
		set
		{
			this.dm = value;
		}
	}

	// Token: 0x17000108 RID: 264
	// (get) Token: 0x06001489 RID: 5257 RVA: 0x00059564 File Offset: 0x00057764
	// (set) Token: 0x0600148A RID: 5258 RVA: 0x0005956C File Offset: 0x0005776C
	public bool HerculesUser
	{
		get
		{
			return this.@do;
		}
		set
		{
			this.@do = value;
		}
	}

	// Token: 0x17000109 RID: 265
	// (get) Token: 0x0600148B RID: 5259 RVA: 0x00059578 File Offset: 0x00057778
	// (set) Token: 0x0600148C RID: 5260 RVA: 0x00059580 File Offset: 0x00057780
	public string CombatLocale
	{
		get
		{
			return this.dn;
		}
		set
		{
			this.dn = value;
		}
	}

	// Token: 0x1700010A RID: 266
	// (get) Token: 0x0600148D RID: 5261 RVA: 0x0005958C File Offset: 0x0005778C
	// (set) Token: 0x0600148E RID: 5262 RVA: 0x00059594 File Offset: 0x00057794
	public bool UseEffectiveWeaponSkillWhenChoosing
	{
		get
		{
			return this.dp;
		}
		set
		{
			this.dp = value;
		}
	}

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x0600148F RID: 5263 RVA: 0x000595A0 File Offset: 0x000577A0
	// (set) Token: 0x06001490 RID: 5264 RVA: 0x000595A8 File Offset: 0x000577A8
	public bool FrightenPsiAbilityUser
	{
		get
		{
			return this.dq;
		}
		set
		{
			this.dq = value;
		}
	}

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x06001491 RID: 5265 RVA: 0x000595B4 File Offset: 0x000577B4
	// (set) Token: 0x06001492 RID: 5266 RVA: 0x000595BC File Offset: 0x000577BC
	public float WristbladeAttackChance
	{
		get
		{
			return this.dr;
		}
		set
		{
			this.dr = value;
		}
	}

	// Token: 0x06001493 RID: 5267 RVA: 0x000595C8 File Offset: 0x000577C8
	public esk()
	{
		this.q = new ej0();
		this.c = new fh(new arr[0]);
		this.g = new ej0();
		this.h = new ej0();
		this.i = new ej0();
		this.j = new ej0();
		this.k = new ej0();
		this.l = new ej0();
		this.m = new ej0();
		this.n = new ej0();
		this.o = new ej0();
		this.s = new a6w(null);
		this.t = new a6w(null);
		this.u = new a6w(null);
		this.r = new ej0();
		this.v = new ej0();
		this.w = new TryUseConsumableNode<avr>("herculesDrug");
		this.x = new TryUseConsumableNode<ja>("morphineShot");
		this.y = new TryUseConsumableNode<cdi>("med.antidote");
		this.z = new TryUseConsumableNode<cyy>("coagulationShot");
		this.aa = new TryUseConsumableNode<do0>("adrenalineShot");
		this.ab = new TryUseConsumableNode<b6b>("psiBooster");
		this.ac = new TryUseConsumableNode<bai>("spiritPotion");
		this.ad = new TryUseConsumableNode<brp>("med.vitalityPowder");
		this.ae = new TryUseConsumableNode<en4>("supersoldierDrug");
		this.a = new fh(new arr[0]);
		this.b = new fh(new arr[0]);
		this.d = new fh(new arr[0]);
		this.e = new fh(new arr[0]);
		this.f = new fh(new arr[0]);
		this.ai = new TryInvokeSpecialAttackNode<e77>();
		this.aj = new TryInvokeSpecialAttackNode<e21>();
		this.ak = new TryInvokeSpecialAttackNode<d2g>();
		this.am = new TryInvokeSpecialAttackNode<bwh>();
		this.al = new TryInvokeSpecialAttackNode<bch>();
		this.an = new TryInvokeSpecialAttackNode<b67>();
		this.a4 = new TryInvokeSpecialAttackNode<xd>();
		this.ao = new TryInvokeSpecialAttackNode<c91>();
		this.ap = new TryInvokeSpecialAttackNode<d9w>();
		this.aq = new TryInvokeSpecialAttackNode<dxn>();
		this.ar = new TryInvokeSpecialAttackNode<b13>();
		this.@as = new TryInvokeSpecialAttackNode<fz>();
		this.aw = new TryInvokeSpecialAttackNode<cbi>();
		this.at = new TryInvokeSpecialAttackNode<bho>();
		this.au = new TryInvokeSpecialAttackNode<eoy>();
		this.av = new TryInvokeSpecialAttackNode<p8>();
		this.ax = new TryInvokeSpecialAttackNode<bs>();
		this.ay = new TryInvokeSpecialAttackNode<czi>();
		this.az = new TryInvokeSpecialAbilityNode<sy>();
		this.a0 = new TryInvokeSpecialAttackNode<w>();
		this.a1 = new TryInvokeSpecialAttackNode<csr>();
		this.a2 = new TryInvokeSpecialAttackNode<bhw>();
		this.a3 = new TryInvokeSpecialAttackNode<bom>();
		this.a5 = new TryInvokeSpecialAttackNode<a5p>();
		this.a6 = new TryInvokeSpecialAttackNode<et>();
		this.a7 = new TryInvokeSpecialAttackNode<btf>();
		this.a8 = new TryInvokeSpecialAttackNode<aho>();
		this.a9 = new TryInvokeSpecialAttackNode<cmu>();
		this.ba = new TryInvokeSpecialAttackNode<dhh>();
		this.bb = new TryInvokeSpecialAttackNode<bz1>();
		this.bc = new TryInvokeSpecialAttackNode<er6>();
		this.bd = new TryUseQuickSlotItemCapNode<d01>();
		this.be = new TryUseQuickSlotItemCapNode<cvo>();
		this.bf = new TryUseQuickSlotItemCapNode<cl0>();
		this.bg = new TryUseQuickSlotItemCapNode<djc>();
		this.bh = new TryUseQuickSlotItemCapNode<e2v>();
		this.bi = new TryUseQuickSlotItemCapNode<eur>();
		this.bj = new TryUseQuickSlotItemCapNode<dby>();
		this.bk = new TryUseQuickSlotItemCapNode<d61>();
		this.bl = new TryUseQuickSlotItemCapNode<ers>();
		this.bm = new TryUseQuickSlotItemCapNode<ezy>();
		this.bn = new TryUseQuickSlotItemCapNode<a0e>();
		this.bo = new TryUseQuickSlotItemCapNode<emf>();
		this.bp = new TryUseQuickSlotItemCapNode<bka>();
		this.bq = new TryUseQuickSlotItemCapNode<e7b>();
		this.br = new TryUseQuickSlotItemCapNode<bot>();
		this.bs = new TryUseQuickSlotItemCapNode<ctm>();
		this.bt = new TryUseQuickSlotItemCapNode<atu>();
		this.bu = new TryUseQuickSlotItemCapNode<ck7>();
		this.bv = new TryUseQuickSlotItemCapNode<el9>();
		this.bw = new TryUseQuickSlotItemCapNode<aox>();
		this.bx = new TryUseQuickSlotItemCapNode<efr>();
		this.by = new TryUseQuickSlotItemCapNode<euw>();
		this.bz = new TryUseQuickSlotItemCapNode<a93>();
		this.b0 = new TryUseQuickSlotItemCapNode<ew2>();
		this.b1 = new TryUseQuickSlotItemCapNode<d1n>();
		this.b2 = new TryUseQuickSlotItemCapNode<d6z>();
		this.b3 = new TryUseQuickSlotItemCapNode<v0>();
		this.b4 = new TryUseQuickSlotItemCapNode<c0p>();
		this.b5 = new TryUseQuickSlotItemCapNode<e0d>();
		this.b6 = new TryUseQuickSlotItemCapNode<dyp>();
		this.cb = new TryInvokePsiAbilityNode<be7>();
		this.cc = new TryInvokePsiAbilityNode<eq6>();
		this.cd = new TryInvokePsiAbilityNode<cmp>();
		this.ce = new TryInvokePsiAbilityNode<dxh>();
		this.cf = new TryInvokePsiAbilityNode<bfk>();
		this.cg = new TryInvokePsiAbilityNode<bnw>();
		this.ch = new TryInvokePsiAbilityNode<dfd>();
		this.ck = new TryInvokePsiAbilityNode<byu>();
		this.cl = new TryInvokePsiAbilityNode<px>();
		this.cj = new TryInvokePsiAbilityNode<ezt>();
		this.cz = new TryInvokePsiAbilityNode<c4n>();
		this.ci = new TryInvokePsiAbilityNode<dx2>();
		this.cp = new fh(new arr[0]);
		this.cq = new fh(new arr[0]);
		this.cm = new TryInvokePsiAbilityNode<d97>();
		this.cm.a = new Func<e1k, object>(esk.a.a.i);
		this.co = new TryInvokePsiAbilityNode<eod>();
		this.co.a = this.cm.a;
		this.cn = new TryInvokePsiAbilityNode<a9>();
		this.cn.a = this.cm.a;
		this.c1 = new TryInvokePsiAbilityNode<c0o>();
		this.c1.a = this.cm.a;
		this.c2 = new TryInvokePsiAbilityNode<eqr>();
		this.c2.a = this.cm.a;
		this.cr = new TryInvokePsiAbilityNode<h7>();
		this.cs = new TryInvokePsiAbilityNode<dzs>();
		this.ct = new TryInvokePsiAbilityNode<dl3>();
		this.cu = new TryInvokePsiAbilityNode<c5y>();
		this.cv = new TryInvokePsiAbilityNode<evz>();
		this.cw = new TryInvokePsiAbilityNode<c67>();
		this.cx = new TryInvokePsiAbilityNode<d7l>();
		this.cy = new TryInvokePsiAbilityNode<ed3>();
		this.c0 = new TryInvokePsiAbilityNode<e6s>();
		this.ca = new TryUseQuickSlotItemCapNode<anb>();
		this.db = new TryInvokeSpecialAbilityNode<em>();
		this.db.a = e8t.b;
		this.c5 = new TryInvokeSpecialAbilityNode<cv5>();
		this.c5.a = e8t.b;
		this.c3 = new TryInvokeSpecialAbilityNode<e9>();
		this.c3.a = e8t.b;
		this.c4 = new TryInvokeSpecialAbilityNode<zw>();
		this.c4.a = e8t.b;
		this.c6 = new TryInvokeSpecialAbilityNode<bbc>();
		this.c6.a = e8t.b;
		this.c7 = new TryInvokeSpecialAbilityNode<e9>();
		this.c7.a = e8t.b;
		this.c8 = new TryInvokeSpecialAbilityNode<amv>();
		this.c8.a = e8t.b;
		this.c9 = new TryInvokeSpecialAbilityNode<b84>();
		this.c9.a = e8t.b;
		this.da = new TryInvokeSpecialAbilityNode<hy>();
		this.da.a = e8t.b;
		this.b7 = new TryUseQuickSlotItemCapNode<ada>();
		this.b8 = new TryUseQuickSlotItemCapNode<cs>();
		this.b9 = new TryUseQuickSlotItemCapNode<bkz>();
		this.p = new ej0();
		this.af = new TryActivateAuraNode<agj>(new bool?(true));
		this.ag = new TryActivateAuraNode<e6v>(new bool?(true));
		this.ah = new TryActivateAuraNode<bem>(new bool?(true));
		this.r.a = new Action<ej0>(esk.a.a.g);
		this.q.a = new Action<ej0>(this.d);
		this.q.a = this.c.a;
		this.c.a = this.q;
		fh fh = this.c;
		arr[] array = new arr[7];
		array[0] = new arr(this.l, new Func<e1k, bool>(esk.a.a.j));
		array[1] = new arr(this.g, new Func<e1k, bool>(this.cy));
		array[2] = new arr(this.k, new Func<e1k, bool>(this.cx));
		array[3] = new arr(this.h, new Func<e1k, bool>(esk.a.a.k));
		array[4] = new arr(this.i, new Func<e1k, bool>(esk.a.a.l));
		array[5] = new arr(this.j, new Func<e1k, bool>(esk.a.a.d));
		array[6] = new arr(this.i.b, null);
		fh.a(array);
		this.k.a = new Action<ej0>(this.c);
		this.k.a = this.c;
		this.l.a = new Action<ej0>(esk.a.a.h);
		this.l.a = this.c;
		this.g.a = new Action<ej0>(esk.a.a.d);
		this.g.a = this.c;
		this.h.a = new Action<ej0>(esk.a.a.b);
		this.h.a = this.i.b;
		this.i.a = new Action<ej0>(esk.a.a.a);
		this.i.a = this.i.b;
		this.j.a = new Action<ej0>(esk.a.a.f);
		this.j.a = this.i.b;
		this.h.b = this.c;
		this.i.b = this.c;
		this.b.a(new arr[]
		{
			new arr(this.m, new Func<e1k, bool>(this.cw)),
			new arr(this.f, new Func<e1k, bool>(this.cv)),
			new arr(this.e, new Func<e1k, bool>(this.cu)),
			new arr(this.d, new Func<e1k, bool>(this.ct)),
			new arr(this.c, null)
		});
		this.m.a = new Action<ej0>(this.b);
		this.m.a = this.b;
		this.o.a = new Action<ej0>(this.a);
		this.o.a = this.c;
		this.p.a = new Action<ej0>(esk.a.a.e);
		this.p.a = this.a;
		this.v.a = new Action<ej0>(esk.a.a.i);
		this.v.a = this.j;
		this.d.a(new arr[]
		{
			new arr(this.c6, new Func<e1k, bool>(this.cs)),
			new arr(this.bl, new Func<e1k, bool>(this.cr)),
			new arr(this.ar, new Func<e1k, bool>(this.cq)),
			new arr(this.u, new Func<e1k, bool>(this.cp)),
			new arr(this.a3, new Func<e1k, bool>(this.co)),
			new arr(this.ao, new Func<e1k, bool>(this.cn)),
			new arr(this.bb, new Func<e1k, bool>(this.cm)),
			new arr(this.bc, new Func<e1k, bool>(this.cl)),
			new arr(this.ai, new Func<e1k, bool>(this.ck)),
			new arr(this.al, new Func<e1k, bool>(this.cj)),
			new arr(this.am, new Func<e1k, bool>(this.ci)),
			new arr(this.a5, new Func<e1k, bool>(this.ch)),
			new arr(this.a8, new Func<e1k, bool>(this.cg)),
			new arr(this.an, new Func<e1k, bool>(this.cf)),
			new arr(this.aj, new Func<e1k, bool>(this.ce)),
			new arr(this.ak, new Func<e1k, bool>(this.cd)),
			new arr(this.a4, new Func<e1k, bool>(this.cc)),
			new arr(this.bq, new Func<e1k, bool>(this.cb)),
			new arr(this.bm, new Func<e1k, bool>(this.ca)),
			new arr(this.bi, new Func<e1k, bool>(this.b9)),
			new arr(this.bj, new Func<e1k, bool>(this.b8)),
			new arr(this.bk, new Func<e1k, bool>(this.b7)),
			new arr(this.bg, new Func<e1k, bool>(this.b6)),
			new arr(this.bf, new Func<e1k, bool>(this.b5)),
			new arr(this.bh, new Func<e1k, bool>(this.b4)),
			new arr(this.be, new Func<e1k, bool>(this.b3)),
			new arr(this.bd, new Func<e1k, bool>(this.b2)),
			new arr(this.bn, new Func<e1k, bool>(this.b1)),
			new arr(this.bp, new Func<e1k, bool>(this.b0)),
			new arr(this.bo, new Func<e1k, bool>(this.bz)),
			new arr(this.aq, new Func<e1k, bool>(this.by)),
			new arr(this.ap, new Func<e1k, bool>(this.bx)),
			new arr(this.a1, new Func<e1k, bool>(this.bw)),
			new arr(this.a2, new Func<e1k, bool>(this.bv)),
			new arr(this.a0, new Func<e1k, bool>(this.bu)),
			new arr(this.ay, new Func<e1k, bool>(this.bt)),
			new arr(this.az, new Func<e1k, bool>(this.bs)),
			new arr(this.@as, new Func<e1k, bool>(this.br)),
			new arr(this.ba, new Func<e1k, bool>(this.bq)),
			new arr(this.a9, new Func<e1k, bool>(this.bp)),
			new arr(this.a6, new Func<e1k, bool>(this.bo)),
			new arr(this.a7, new Func<e1k, bool>(this.bn)),
			new arr(this.aw, new Func<e1k, bool>(this.bm)),
			new arr(this.av, new Func<e1k, bool>(this.bl)),
			new arr(this.au, new Func<e1k, bool>(this.bk)),
			new arr(this.at, new Func<e1k, bool>(this.bj)),
			new arr(this.ax, new Func<e1k, bool>(this.bi)),
			new arr(this.p.a, null)
		});
		this.r.a = this.d;
		this.ao.a = this.j;
		this.ao.b = this.r;
		this.a3.a = this.j;
		this.a3.b = this.r;
		this.ai.a = this.j;
		this.ai.b = this.p.a;
		this.aj.a = this.j;
		this.aj.b = this.p.a;
		this.ak.a = this.j;
		this.ak.b = this.p.a;
		this.al.a = this.j;
		this.al.b = this.p.a;
		this.am.a = this.j;
		this.am.b = this.p.a;
		this.an.a = this.j;
		this.an.b = this.p.a;
		this.a4.a = this.j;
		this.a4.b = this.p.a;
		this.ap.a = this.j;
		this.ap.b = this.p.a;
		this.aq.a = this.j;
		this.aq.b = this.p.a;
		this.ar.a = this.j;
		this.ar.b = this.p.a;
		this.@as.a = this.j;
		this.@as.b = this.p.a;
		this.aw.a = this.j;
		this.aw.b = this.p.a;
		this.at.a = this.j;
		this.at.b = this.p.a;
		this.au.a = this.j;
		this.au.b = this.p.a;
		this.ax.a = this.j;
		this.ax.b = this.p.a;
		this.ay.a = this.j;
		this.ay.b = this.p.a;
		this.az.a = this.j;
		this.az.b = this.p.a;
		this.a0.a = this.j;
		this.a0.b = this.p.a;
		this.a1.a = this.j;
		this.a1.b = this.p.a;
		this.a2.a = this.j;
		this.a2.b = this.p.a;
		this.a5.a = this.j;
		this.a5.b = this.p.a;
		this.a6.a = this.j;
		this.a6.b = this.p.a;
		this.a7.a = this.j;
		this.a7.b = this.p.a;
		this.a8.a = this.j;
		this.a8.b = this.p.a;
		this.a9.a = this.j;
		this.a9.b = this.p.a;
		this.ba.a = this.j;
		this.ba.b = this.p.a;
		this.bb.a = this.j;
		this.bb.b = this.p.a;
		this.bc.a = this.j;
		this.bc.b = this.p.a;
		this.be.a = this.j;
		this.be.b = this.p.a;
		this.bf.a = this.j;
		this.bf.b = this.p.a;
		this.bg.a = this.j;
		this.bg.b = this.p.a;
		this.bd.a = this.j;
		this.bd.b = this.p.a;
		this.bh.a = this.j;
		this.bh.b = this.p.a;
		this.bi.a = this.j;
		this.bi.b = this.p.a;
		this.bj.a = this.j;
		this.bj.b = this.p.a;
		this.bk.a = this.j;
		this.bk.b = this.p.a;
		this.bl.a = this.j;
		this.bl.b = this.p.a;
		this.bm.a = this.j;
		this.bm.b = this.p.a;
		this.bn.a = this.j;
		this.bn.b = this.p.a;
		this.bo.a = this.j;
		this.bo.b = this.p.a;
		this.bp.a = this.j;
		this.bp.b = this.p.a;
		this.bq.a = this.j;
		this.bq.b = this.p.a;
		this.br.a = this.j;
		this.br.b = this.p.a;
		this.bs.a = this.j;
		this.bs.b = this.p.a;
		this.bt.a = this.j;
		this.bt.b = this.p.a;
		this.bu.a = this.j;
		this.bu.b = this.p.a;
		this.bv.a = this.j;
		this.bv.b = this.p.a;
		this.bw.a = this.j;
		this.bw.b = this.p.a;
		this.bx.a = this.j;
		this.bx.b = this.p.a;
		this.by.a = this.j;
		this.by.b = this.p.a;
		this.bz.a = this.j;
		this.bz.b = this.p.a;
		this.b1.a = this.j;
		this.b1.b = this.p.a;
		this.b1.c = new Func<e1k, object>(esk.a.a.m);
		this.b6.a = this.j;
		this.b6.b = this.p.a;
		this.b6.c = this.b1.c;
		this.b2.a = this.j;
		this.b2.b = this.p.a;
		this.b2.c = this.b1.c;
		this.b3.a = this.j;
		this.b3.b = this.p.a;
		this.b3.c = this.b1.c;
		this.b4.a = this.c;
		this.b4.b = this.p.a;
		this.b4.c = this.b1.c;
		this.b5.a = this.j;
		this.b5.b = this.p.a;
		this.b5.c = this.b1.c;
		this.b0.a = this.j;
		this.b0.b = this.p.a;
		this.b7.a = this.j;
		this.b7.b = this.p.a;
		this.b8.a = this.j;
		this.b8.b = this.p.a;
		this.b9.a = this.j;
		this.b9.b = this.p.a;
		fh fh2 = this.a;
		arr[] array2 = new arr[37];
		array2[0] = new arr(this.p, new Func<e1k, bool>(esk.a.a.f));
		array2[1] = new arr(this.c7, new Func<e1k, bool>(this.bh));
		array2[2] = new arr(this.db, new Func<e1k, bool>(this.bg));
		array2[3] = new arr(this.c8, new Func<e1k, bool>(this.bf));
		array2[4] = new arr(this.af, new Func<e1k, bool>(esk.a.a.n));
		array2[5] = new arr(this.ah, new Func<e1k, bool>(esk.a.a.p));
		array2[6] = new arr(this.ag, new Func<e1k, bool>(esk.a.a.g));
		array2[7] = new arr(this.cm, new Func<e1k, bool>(this.be));
		array2[8] = new arr(this.cn, new Func<e1k, bool>(this.bd));
		array2[9] = new arr(this.c9, new Func<e1k, bool>(this.bc));
		array2[10] = new arr(this.b9, new Func<e1k, bool>(this.bb));
		array2[11] = new arr(this.b8, new Func<e1k, bool>(this.ba));
		array2[12] = new arr(this.b7, new Func<e1k, bool>(this.a9));
		array2[13] = new arr(this.b6, new Func<e1k, bool>(this.a8));
		array2[14] = new arr(this.b1, new Func<e1k, bool>(this.a7));
		array2[15] = new arr(this.b2, new Func<e1k, bool>(this.a6));
		array2[16] = new arr(this.b3, new Func<e1k, bool>(this.a5));
		array2[17] = new arr(this.b5, new Func<e1k, bool>(this.a4));
		array2[18] = new arr(this.b4, new Func<e1k, bool>(this.a3));
		array2[19] = new arr(this.c5, new Func<e1k, bool>(this.a2));
		array2[20] = new arr(this.cb, new Func<e1k, bool>(this.a1));
		array2[21] = new arr(this.ci, new Func<e1k, bool>(this.a0));
		array2[22] = new arr(this.cc, new Func<e1k, bool>(this.az));
		array2[23] = new arr(this.ce, new Func<e1k, bool>(this.ay));
		array2[24] = new arr(this.cf, new Func<e1k, bool>(this.ax));
		array2[25] = new arr(this.cd, new Func<e1k, bool>(this.aw));
		array2[26] = new arr(this.co, new Func<e1k, bool>(this.av));
		array2[27] = new arr(this.cg, new Func<e1k, bool>(this.au));
		array2[28] = new arr(this.ch, new Func<e1k, bool>(this.at));
		array2[29] = new arr(this.c2, new Func<e1k, bool>(this.@as));
		array2[30] = new arr(this.c1, new Func<e1k, bool>(this.ar));
		array2[31] = new arr(this.cl, new Func<e1k, bool>(this.aq));
		array2[32] = new arr(this.cj, new Func<e1k, bool>(this.ap));
		array2[33] = new arr(this.cz, new Func<e1k, bool>(this.ao));
		array2[34] = new arr(this.ck, new Func<e1k, bool>(this.an));
		array2[35] = new arr(this.b0, new Func<e1k, bool>(this.am));
		array2[36] = new arr(this.b, null);
		fh2.a(array2);
		this.cp.a(new arr[]
		{
			new arr(this.cc, new Func<e1k, bool>(this.al)),
			new arr(this.c, null)
		});
		fh fh3 = this.cq;
		arr[] array3 = new arr[3];
		array3[0] = new arr(this.ar, new Func<e1k, bool>(this.ak));
		array3[1] = new arr(this.c, new Func<e1k, bool>(esk.a.a.c));
		array3[2] = new arr(this.b, null);
		fh3.a(array3);
		this.cb.b = this.b;
		this.cb.a = this.cp;
		this.cc.b = this.b;
		this.cc.a = this.b;
		this.cd.b = this.b;
		this.cd.a = this.cq;
		this.ce.b = this.b;
		this.ce.a = this.cq;
		this.cf.b = this.b;
		this.cf.a = this.cq;
		this.cj.b = this.b;
		this.cj.a = this.a;
		this.cz.b = this.b;
		this.cz.a = this.a;
		this.cl.b = this.b;
		this.cl.a = this.a;
		this.cm.b = this.b;
		this.cm.a = this.a;
		this.co.b = this.b;
		this.co.a = this.a;
		this.cg.b = this.b;
		this.cg.a = this.a;
		this.ci.b = this.b;
		this.ci.a = this.cp;
		this.ch.b = this.b;
		this.ch.a = this.a;
		this.c2.b = this.b;
		this.c2.a = this.a;
		this.c1.b = this.b;
		this.c1.a = this.a;
		this.cn.b = this.b;
		this.cn.a = this.a;
		this.ck.b = this.b;
		this.ck.a = this.a;
		this.c5.b = this.b;
		this.c5.a = this.a;
		this.db.b = this.b;
		this.db.a = this.a;
		this.c7.b = this.b;
		this.c7.a = this.a;
		this.c8.b = this.b;
		this.c8.a = this.a;
		this.c9.b = this.b;
		this.c9.a = this.a;
		this.c3.b = this.b;
		this.c3.a = this.e;
		this.c4.b = this.b;
		this.c4.a = this.e;
		this.c6.b = this.b;
		this.c6.a = this.d;
		this.af.b = this.b;
		this.af.a = this.a;
		this.ag.b = this.b;
		this.ag.a = this.a;
		this.ah.b = this.b;
		this.ah.a = this.a;
		this.f.a(new arr[]
		{
			new arr(this.bx, new Func<e1k, bool>(this.aj)),
			new arr(this.by, new Func<e1k, bool>(this.ai)),
			new arr(this.bz, new Func<e1k, bool>(this.ah)),
			new arr(this.bt, new Func<e1k, bool>(this.ag)),
			new arr(this.bw, new Func<e1k, bool>(this.af)),
			new arr(this.bu, new Func<e1k, bool>(this.ae)),
			new arr(this.bs, new Func<e1k, bool>(this.ad)),
			new arr(this.bv, new Func<e1k, bool>(this.ac)),
			new arr(this.br, new Func<e1k, bool>(this.ab)),
			new arr(this.d, new Func<e1k, bool>(this.aa)),
			new arr(this.c, null)
		});
		fh fh4 = this.e;
		arr[] array4 = new arr[16];
		array4[0] = new arr(this.c3, new Func<e1k, bool>(this.z));
		array4[1] = new arr(this.ca, new Func<e1k, bool>(this.y));
		array4[2] = new arr(this.c4, new Func<e1k, bool>(this.x));
		array4[3] = new arr(this.cv, new Func<e1k, bool>(this.w));
		array4[4] = new arr(this.cx, new Func<e1k, bool>(this.v));
		array4[5] = new arr(this.cw, new Func<e1k, bool>(this.u));
		array4[6] = new arr(this.ct, new Func<e1k, bool>(this.t));
		array4[7] = new arr(this.cu, new Func<e1k, bool>(this.s));
		array4[8] = new arr(this.cs, new Func<e1k, bool>(this.r));
		array4[9] = new arr(this.c0, new Func<e1k, bool>(this.q));
		array4[10] = new arr(this.cy, new Func<e1k, bool>(this.p));
		array4[11] = new arr(this.cr, new Func<e1k, bool>(this.o));
		array4[12] = new arr(this.d, new Func<e1k, bool>(this.n));
		array4[13] = new arr(this.k, new Func<e1k, bool>(esk.a.a.e));
		array4[14] = new arr(this.o, new Func<e1k, bool>(this.m));
		array4[15] = new arr(this.c, null);
		fh4.a(array4);
		this.ca.a = this.j;
		this.ca.b = this.d;
		this.ct.a = this.j;
		this.ct.b = this.d;
		this.cs.a = this.j;
		this.cs.b = this.d;
		this.cy.a = this.j;
		this.cy.b = this.d;
		this.c0.a = this.j;
		this.c0.b = this.d;
		this.cr.a = this.j;
		this.cr.b = this.d;
		this.cu.a = this.j;
		this.cu.b = this.d;
		this.cu.a = this.b1.c;
		this.cv.a = this.j;
		this.cv.b = this.d;
		this.cv.a = this.b1.c;
		this.cw.a = this.j;
		this.cw.b = this.d;
		this.cw.a = this.b1.c;
		this.cx.a = this.j;
		this.cx.b = this.d;
		this.cx.a = new Func<e1k, object>(esk.a.a.b);
		this.p.a = this.a;
		this.j.a.Insert(3, new arr(this.y, new Func<e1k, bool>(this.l)));
		this.j.a.Insert(4, new arr(this.z, new Func<e1k, bool>(this.k)));
		this.j.a.Insert(5, new arr(this.w, new Func<e1k, bool>(this.j)));
		this.j.a.Insert(6, new arr(this.x, new Func<e1k, bool>(this.i)));
		this.j.a.Insert(7, new arr(this.da, new Func<e1k, bool>(this.h)));
		this.j.a.Insert(8, new arr(this.v, new Func<e1k, bool>(esk.a.a.o)));
		this.j.a.Insert(9, new arr(this.ae, new Func<e1k, bool>(this.g)));
		this.j.a.Insert(10, new arr(this.aa, new Func<e1k, bool>(this.f)));
		this.j.a.Insert(11, new arr(this.ad, new Func<e1k, bool>(this.e)));
		this.j.a.Insert(12, new arr(this.ab, new Func<e1k, bool>(this.d)));
		this.j.a.Insert(13, new arr(this.ac, new Func<e1k, bool>(this.c)));
		this.j.a.Insert(14, new arr(this.t, new Func<e1k, bool>(this.b)));
		this.j.a.Insert(15, new arr(this.t, new Func<e1k, bool>(esk.a.a.a)));
		this.j.a.Insert(16, new arr(this.n, new Func<e1k, bool>(esk.a.a.h)));
		this.j.a.Insert(17, new arr(this.s, new Func<e1k, bool>(this.a)));
		this.w.a = this.j;
		this.w.b = this.j;
		this.x.a = this.j;
		this.x.b = this.j;
		this.da.a = this.j;
		this.da.b = this.j;
		this.y.a = this.j;
		this.y.b = this.j;
		this.z.a = this.j;
		this.z.b = this.j;
		this.aa.a = this.j;
		this.aa.b = this.j;
		this.ab.a = this.j;
		this.ab.b = this.j;
		this.ac.a = this.j;
		this.ac.b = this.j;
		this.ad.a = this.j;
		this.ad.b = this.j;
		this.ae.a = this.j;
		this.ae.b = this.j;
		this.s.a = this.c;
		this.s.b = this.j;
		this.t.a = new Func<a6w, cst>(esk.a.a.a);
		this.t.a = this.c;
		this.t.b = this.j;
		this.n.a = new Action<ej0>(esk.a.a.c);
		this.n.a = this.c;
		this.s.a = new Func<a6w, cst>(this.b);
		this.u.a = new Func<a6w, cst>(this.a);
		this.u.b = this.d;
		this.u.a = this.d;
	}

	// Token: 0x06001494 RID: 5268 RVA: 0x0005C340 File Offset: 0x0005A540
	private new static int a(d4n A_0, int A_1, double A_2, btz A_3)
	{
		int result;
		if (A_3 == btz.e)
		{
			result = (int)(Math.Max(0.0, A_0.c - (double)(A_0.b.aa().Offense.av() + 1)) + A_0.d);
		}
		else if (A_2 >= 8.0)
		{
			result = (int)(Math.Max(0.0, A_0.c - (double)(A_0.b.aa().Offense.av() + 1)) + A_0.d);
		}
		else if (A_2 > 6.0)
		{
			result = (int)(Math.Max(0.0, A_0.c - (double)(A_0.b.aa().Offense.av() * 2 + 1)) + A_0.d);
		}
		else
		{
			result = (int)(Math.Max(0.0, A_0.c - (double)(A_1 + 1)) + A_0.d);
		}
		return result;
	}

	// Token: 0x06001495 RID: 5269 RVA: 0x0005C448 File Offset: 0x0005A648
	private new bool b(amc A_0)
	{
		if (this.dc)
		{
			if (A_0.aa().SpecialStates.d)
			{
				return true;
			}
			float num = float.MaxValue;
			foreach (aia aia in A_0.aa().PsiAbilities)
			{
				if (aia != null && aia.Value != null)
				{
					bd0 bd = ecf.a(aia.Value, new eru(new EntityAspectReference<amc, amc>(A_0)), null) as bd0;
					if (bd != null)
					{
						num = Math.Min(num, bd.a());
					}
				}
			}
			if (A_0.aa().Offense.aa().zo() < num)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001496 RID: 5270 RVA: 0x0005C524 File Offset: 0x0005A724
	private new bool a(amc A_0)
	{
		if (this.dk)
		{
			foreach (ItemSlot<coh> itemSlot in A_0.aa().Gear.d())
			{
				if (itemSlot.Item != null)
				{
					aia aia = Enumerable.FirstOrDefault<aia>(itemSlot.Item.Definition.a2());
					if (aia != null && aia.Value != null && aia.Value is a0y)
					{
						return false;
					}
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x06001497 RID: 5271 RVA: 0x0005C5B0 File Offset: 0x0005A7B0
	[CompilerGenerated]
	private new void d(ej0 A_0)
	{
		A_0.b().d().RemoveProperty("kited");
		A_0.b().d().RemoveProperty("triedToActivateAlarm");
		A_0.b().d().RemoveProperty("losKited");
		A_0.b().d().RemoveProperty("regularLoSKitingAttempted");
		A_0.b().d().RemoveProperty("meleeKitingAttempted");
		A_0.b().d().RemoveProperty("advancedForBursting");
		A_0.b().d().RemoveProperty("threwShockShuriken");
		A_0.b().d().RemoveProperty("burstFailed");
		if (this.RemoveCustomState)
		{
			A_0.b().g().ap = null;
			A_0.b().g().aq = null;
		}
		if (this.ds != null)
		{
			foreach (string name in this.ds)
			{
				A_0.b().d().RemoveProperty(name);
			}
		}
	}

	// Token: 0x06001498 RID: 5272 RVA: 0x0005C708 File Offset: 0x0005A908
	[CompilerGenerated]
	private bool cy(e1k A_0)
	{
		return d3k.d(A_0.g().aa(), true) || (d3k.a(A_0.g().aa(), this.dp) && this.SwitchesToBetterWeapon);
	}

	// Token: 0x06001499 RID: 5273 RVA: 0x0005C750 File Offset: 0x0005A950
	[CompilerGenerated]
	private bool cx(e1k A_0)
	{
		return d3k.c(A_0.g().aa(), this.dp);
	}

	// Token: 0x0600149A RID: 5274 RVA: 0x0005C768 File Offset: 0x0005A968
	[CompilerGenerated]
	private new void c(ej0 A_0)
	{
		cd1 a_ = d3k.b(A_0.b().g().aa(), this.dp);
		if (A_0.b().g().aa().Gear.j()[A_0.b().g().aa().Offense.au()].Item != null)
		{
			A_0.b().g().aa().Bag.z3(A_0.b().g().aa().Gear.j()[A_0.b().g().aa().Offense.au()].Item, true);
		}
		A_0.b().g().aa().Gear.j()[A_0.b().g().aa().Offense.au()].Item = a_;
		A_0.b().g().aa().Bag.z5(a_);
	}

	// Token: 0x0600149B RID: 5275 RVA: 0x0005C888 File Offset: 0x0005AA88
	[CompilerGenerated]
	private bool cw(e1k A_0)
	{
		if (this.df != 0 && this.dg != 0 && !A_0.d().GetPrimitivePropertyValue<bool>("kited", null).GetValueOrDefault() && !A_0.d().GetPrimitivePropertyValue<bool>("attemptedToAdvanceOnRequest", new bool?(false)).Value)
		{
			if (!this.dc && !this.dk && A_0.g().aa().Offense.u().TypedDefinition.ad() < (float)this.df)
			{
				return false;
			}
			if (this.b(A_0.g()))
			{
				return false;
			}
			if (this.a(A_0.g()))
			{
				return false;
			}
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.a8() != null)
			{
				return aw1.b(A_0.g().a8(), amc.a8()) < (double)this.df;
			}
		}
		return false;
	}

	// Token: 0x0600149C RID: 5276 RVA: 0x0005C9A8 File Offset: 0x0005ABA8
	[CompilerGenerated]
	private bool cv(e1k A_0)
	{
		if (this.dk)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null)
			{
				if (this.dd)
				{
					return true;
				}
				if (aw1.b(A_0.g().a8(), amc.a8()) >= 2.0)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600149D RID: 5277 RVA: 0x0005CA10 File Offset: 0x0005AC10
	[CompilerGenerated]
	private bool cu(e1k A_0)
	{
		return this.dc;
	}

	// Token: 0x0600149E RID: 5278 RVA: 0x0005CA18 File Offset: 0x0005AC18
	[CompilerGenerated]
	private bool ct(e1k A_0)
	{
		return !this.dd || this.a(A_0.g()) || this.b(A_0.g());
	}

	// Token: 0x0600149F RID: 5279 RVA: 0x0005CA50 File Offset: 0x0005AC50
	[CompilerGenerated]
	private new void b(ej0 A_0)
	{
		amc amc = new bzv(A_0.b().c().y6()).g();
		if (amc != null && !amc.aa().Dead)
		{
			ak1 ak = g8.a(A_0.b().c(), amc.a8().t.b, this.dg, 1f, this.df);
			if (ak != null)
			{
				A_0.b().g().a8().k.b.a(ak, 0.0, 1, 0, true);
			}
		}
		A_0.b().d()["kited"] = true;
	}

	// Token: 0x060014A0 RID: 5280 RVA: 0x0005CB10 File Offset: 0x0005AD10
	[CompilerGenerated]
	private new void a(ej0 A_0)
	{
		amc amc = new bzv(A_0.b().c().y6()).g();
		if (amc != null && !amc.aa().Dead)
		{
			ak1 ak = g8.a(A_0.b().c(), amc.a8().t.b, this.dg, 1f, this.df);
			if (ak != null)
			{
				A_0.b().g().a8().k.b.a(ak, 0.0, 1, 0, true);
			}
		}
	}

	// Token: 0x060014A1 RID: 5281 RVA: 0x0005CBB4 File Offset: 0x0005ADB4
	[CompilerGenerated]
	private bool cs(e1k A_0)
	{
		if (this.c6.b(A_0) && !A_0.g().aa().SpecialStates.g && !A_0.g().aa().SpecialStates.b)
		{
			bzv bzv = new bzv(A_0.c().y6());
			if (bzv.g() != null)
			{
				d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
				cmb cmb = bzv.d();
				if (cmb != null)
				{
					float num = cmb.b((int)A_0.g().aa().Offense.u().TypedDefinition.ad());
					if (serviceOrThrow.ahe().d + 5.0 < (double)(num * 10f))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060014A2 RID: 5282 RVA: 0x0005CC84 File Offset: 0x0005AE84
	[CompilerGenerated]
	private bool cr(e1k A_0)
	{
		if (this.bl.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().d(CharacterImmunities.Stun | CharacterImmunities.ShortCircuiting) && !amc.aa().SpecialStates.a)
			{
				if (!this.de)
				{
					if (aw1.b(A_0.g().a8(), amc.a8()) <= 2.0)
					{
						return false;
					}
					foreach (amc a_ in aw1.a(amc.a8(), 1))
					{
						if (A_0.g().a(a_) != global::h.a)
						{
							return false;
						}
					}
					return true;
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014A3 RID: 5283 RVA: 0x0005CD84 File Offset: 0x0005AF84
	[CompilerGenerated]
	private bool cq(e1k A_0)
	{
		if (this.ar.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null && (amc.aa().SpecialStates.a || amc.aa().SpecialStates.c || amc.aa().SpecialStates.h) && !amc.aa().SpecialStates.k)
			{
				cmb cmb = bzv.d();
				if (cmb != null)
				{
					b13 b = dgk.Get<b13>();
					eoj a_ = new eoj(A_0.g().aa(), null, null);
					d4n d4n = dz6.b(A_0.g().aa());
					if (d4n != null && b != null)
					{
						float num = cmb.b((int)b.afi(null));
						return d4n.c - (Math.Max(0.0, (double)(num * 10f) - d4n.d) + (double)b.afh(a_)) > -30.0;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060014A4 RID: 5284 RVA: 0x0005CEA8 File Offset: 0x0005B0A8
	[CompilerGenerated]
	private bool cp(e1k A_0)
	{
		if (!A_0.d().GetPrimitivePropertyValue<bool>("advancedForBursting", new bool?(false)).Value && A_0.g().a8().k.b != null && !A_0.g().aa().SpecialStates.b && (((A_0.g().aa().Offense.u().TypedDefinition.e() == btz.c || A_0.g().aa().Offense.u().TypedDefinition.e() == btz.j || A_0.g().aa().Offense.u().TypedDefinition.e() == btz.k || A_0.g().aa().Offense.u().TypedDefinition.e() == btz.b) && this.ao.a(A_0) && !A_0.d().GetPrimitivePropertyValue<bool>("burstFailed", new bool?(false)).Value && (A_0.g().aa().Offense.u().LoadedAmmo.Count >= 3 || A_0.g().aa().Offense.u().TypedDefinition.g())) || (A_0.g().aa().Offense.u().TypedDefinition.e() == btz.e && this.a3.a(A_0) && (A_0.g().aa().Offense.u().LoadedAmmo.Count >= 3 || A_0.g().aa().Offense.u().TypedDefinition.g()))))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null)
			{
				cmb cmb = bzv.d();
				if (cmb != null)
				{
					double a_ = aw1.b(amc.a8(), A_0.g().a8());
					d4n d4n = bpo.GetServiceOrThrow<d02>().ahu(A_0.g().aa());
					if (d4n != null)
					{
						int a_2 = this.ao.a().afh(new eoj(A_0.g().aa(), null, null));
						int num = esk.a(d4n, a_2, a_, A_0.g().aa().Offense.u().TypedDefinition.e());
						int num2 = -1;
						int num3;
						if (A_0.g().aa().Offense.u().TypedDefinition.e() == btz.e)
						{
							num3 = 2;
						}
						else
						{
							num3 = 4;
						}
						int num4 = num3;
						while ((float)num4 <= A_0.g().aa().Offense.u().TypedDefinition.ad())
						{
							float num5 = cmb.b(num4);
							if (num5 == 0f)
							{
								break;
							}
							if (num5 != -1f && num5 * 10f <= (float)num)
							{
								num2 = num4;
								break;
							}
							num4++;
						}
						if (num2 != -1)
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060014A5 RID: 5285 RVA: 0x0005D1FC File Offset: 0x0005B3FC
	[CompilerGenerated]
	private bool co(e1k A_0)
	{
		if (this.a3.a(A_0) && !A_0.d().GetPrimitivePropertyValue<bool>("burstFailed", new bool?(false)).Value && (A_0.g().aa().Offense.u().LoadedAmmo.Count >= 3 || A_0.g().aa().Offense.u().TypedDefinition.g()))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && (aw1.b(amc.a8(), A_0.g().a8()) <= 4.0 || this.di))
			{
				return this.de || !eb4.a(A_0.g(), amc, A_0.g().aa().Offense.u().TypedDefinition.ad(), A_0.g().aa().Offense.u().TypedDefinition.x().GetValueOrDefault(50) / 2);
			}
		}
		return false;
	}

	// Token: 0x060014A6 RID: 5286 RVA: 0x0005D33C File Offset: 0x0005B53C
	[CompilerGenerated]
	private bool cn(e1k A_0)
	{
		if (this.ao.a(A_0) && !A_0.d().GetPrimitivePropertyValue<bool>("burstFailed", new bool?(false)).Value && (A_0.g().aa().Offense.u().LoadedAmmo.Count >= 3 || A_0.g().aa().Offense.u().TypedDefinition.g()))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && (aw1.b(amc.a8(), A_0.g().a8()) <= 6.0 || this.di))
			{
				return this.de || !eb4.a(A_0.g(), amc, A_0.g().aa().Offense.u().TypedDefinition.ad(), 18);
			}
		}
		return false;
	}

	// Token: 0x060014A7 RID: 5287 RVA: 0x0005D450 File Offset: 0x0005B650
	[CompilerGenerated]
	private bool cm(e1k A_0)
	{
		if (this.bb.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			return amc != null && !amc.aa().d(CharacterImmunities.Stun);
		}
		return false;
	}

	// Token: 0x060014A8 RID: 5288 RVA: 0x0005D4A0 File Offset: 0x0005B6A0
	[CompilerGenerated]
	private bool cl(e1k A_0)
	{
		return this.bc.a(A_0) && new bzv(A_0.c().y6()).g() != null;
	}

	// Token: 0x060014A9 RID: 5289 RVA: 0x0005D4D8 File Offset: 0x0005B6D8
	[CompilerGenerated]
	private bool ck(e1k A_0)
	{
		if (this.ai.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			return amc != null && !amc.aa().d(CharacterImmunities.CriticalHits);
		}
		return false;
	}

	// Token: 0x060014AA RID: 5290 RVA: 0x0005D52C File Offset: 0x0005B72C
	[CompilerGenerated]
	private bool cj(e1k A_0)
	{
		return this.al.a(A_0) && new bzv(A_0.c().y6()).g() != null;
	}

	// Token: 0x060014AB RID: 5291 RVA: 0x0005D564 File Offset: 0x0005B764
	[CompilerGenerated]
	private bool ci(e1k A_0)
	{
		if (this.am.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().d(CharacterImmunities.Decapitation) && !amc.aa().b(d8o.e | d8o.m))
			{
				return euf.f(amc.aa()) < 0.5f;
			}
		}
		return false;
	}

	// Token: 0x060014AC RID: 5292 RVA: 0x0005D5E0 File Offset: 0x0005B7E0
	[CompilerGenerated]
	private bool ch(e1k A_0)
	{
		if (this.a5.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (!euf.b(A_0.g().aa().Offense.u().TypedDefinition))
			{
				cmb cmb = bzv.d();
				if (cmb == null || cmb.b((int)as3.bk) > 3f)
				{
					return false;
				}
			}
			if (amc != null && !amc.aa().d(CharacterImmunities.Daze))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014AD RID: 5293 RVA: 0x0005D680 File Offset: 0x0005B880
	[CompilerGenerated]
	private bool cg(e1k A_0)
	{
		return this.a8.a(A_0);
	}

	// Token: 0x060014AE RID: 5294 RVA: 0x0005D698 File Offset: 0x0005B898
	[CompilerGenerated]
	private bool cf(e1k A_0)
	{
		if (this.an.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null)
			{
				cmn a_ = awq.b(A_0.g(), amc, null);
				return euf.a(A_0.g().aa(), amc.aa(), a_, 1.0, null).a > 0.65;
			}
		}
		return false;
	}

	// Token: 0x060014AF RID: 5295 RVA: 0x0005D714 File Offset: 0x0005B914
	[CompilerGenerated]
	private bool ce(e1k A_0)
	{
		if (this.aj.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			return amc != null && !amc.aa().d(CharacterImmunities.CriticalHits);
		}
		return false;
	}

	// Token: 0x060014B0 RID: 5296 RVA: 0x0005D768 File Offset: 0x0005B968
	[CompilerGenerated]
	private bool cd(e1k A_0)
	{
		return this.ak.a(A_0) && new bzv(A_0.c().y6()).g() != null;
	}

	// Token: 0x060014B1 RID: 5297 RVA: 0x0005D7A0 File Offset: 0x0005B9A0
	[CompilerGenerated]
	private bool cc(e1k A_0)
	{
		if (this.a4.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			cmb cmb = bzv.d();
			d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
			d4n d4n = serviceOrThrow.ahu(A_0.g().aa());
			if (cmb != null && d4n != null && d4n == serviceOrThrow.ahe())
			{
				amc amc = bzv.g();
				if (amc != null)
				{
					float num = euf.f(amc.aa());
					float num2 = cmb.b(0);
					if (num2 != 0f)
					{
						if (A_0.g().aa().SpecialStates.b)
						{
							return true;
						}
						if (num < 0.2f && (double)num2 > d4n.d / 10.0)
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060014B2 RID: 5298 RVA: 0x0005D87C File Offset: 0x0005BA7C
	[CompilerGenerated]
	private bool cb(e1k A_0)
	{
		return this.bq.a(A_0) && new bzv(A_0.c().y6()).g() != null;
	}

	// Token: 0x060014B3 RID: 5299 RVA: 0x0005D8B4 File Offset: 0x0005BAB4
	[CompilerGenerated]
	private bool ca(e1k A_0)
	{
		if (this.bm.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null)
			{
				return (!ew0.a() || !amc.aa().StatusEffects.a(aiw.a)) && (this.de || !eb4.a(A_0.g(), amc, A_0.g().aa().Offense.u().TypedDefinition.ad(), 18));
			}
		}
		return false;
	}

	// Token: 0x060014B4 RID: 5300 RVA: 0x0005D954 File Offset: 0x0005BB54
	[CompilerGenerated]
	private bool b9(e1k A_0)
	{
		if (this.bi.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().b(d8o.e) && !amc.aa().d(CharacterImmunities.Poison))
			{
				return !amc.aa().StatusEffects.a(ddr.a);
			}
		}
		return false;
	}

	// Token: 0x060014B5 RID: 5301 RVA: 0x0005D9D0 File Offset: 0x0005BBD0
	[CompilerGenerated]
	private bool b8(e1k A_0)
	{
		if (this.bj.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().b(d8o.e) && !amc.aa().d(CharacterImmunities.Poison))
			{
				return !amc.aa().StatusEffects.a(dns.a);
			}
		}
		return false;
	}

	// Token: 0x060014B6 RID: 5302 RVA: 0x0005DA4C File Offset: 0x0005BC4C
	[CompilerGenerated]
	private bool b7(e1k A_0)
	{
		if (this.bk.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().b(d8o.e) && !amc.aa().d(CharacterImmunities.Poison))
			{
				return !amc.aa().StatusEffects.a(ehp.a);
			}
		}
		return false;
	}

	// Token: 0x060014B7 RID: 5303 RVA: 0x0005DAC8 File Offset: 0x0005BCC8
	[CompilerGenerated]
	private bool b6(e1k A_0)
	{
		if (this.bg.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			return amc != null && !amc.aa().b(d8o.e) && !amc.aa().d(CharacterImmunities.Poison);
		}
		return false;
	}

	// Token: 0x060014B8 RID: 5304 RVA: 0x0005DB2C File Offset: 0x0005BD2C
	[CompilerGenerated]
	private bool b5(e1k A_0)
	{
		if (this.bf.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			return amc != null && !amc.aa().b(d8o.e) && !amc.aa().d(CharacterImmunities.Poison);
		}
		return false;
	}

	// Token: 0x060014B9 RID: 5305 RVA: 0x0005DB90 File Offset: 0x0005BD90
	[CompilerGenerated]
	private bool b4(e1k A_0)
	{
		if (this.bh.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().b(d8o.e) && !amc.aa().d(CharacterImmunities.Poison))
			{
				bool flag = Enumerable.Any<dl2>(Enumerable.OfType<dl2>(amc.aa().StatusEffects.d()));
				bool flag2 = amc.aa().StatusEffects.a(bhe.a);
				return flag && !flag2;
			}
		}
		return false;
	}

	// Token: 0x060014BA RID: 5306 RVA: 0x0005DC30 File Offset: 0x0005BE30
	[CompilerGenerated]
	private bool b3(e1k A_0)
	{
		if (this.be.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			return amc != null && !amc.aa().b(d8o.e) && !amc.aa().d(CharacterImmunities.Poison);
		}
		return false;
	}

	// Token: 0x060014BB RID: 5307 RVA: 0x0005DC94 File Offset: 0x0005BE94
	[CompilerGenerated]
	private bool b2(e1k A_0)
	{
		if (this.bd.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			return amc != null && !amc.aa().b(d8o.e) && !amc.aa().d(CharacterImmunities.Poison);
		}
		return false;
	}

	// Token: 0x060014BC RID: 5308 RVA: 0x0005DCF8 File Offset: 0x0005BEF8
	[CompilerGenerated]
	private bool b1(e1k A_0)
	{
		return this.bn.a(A_0) && new bzv(A_0.c().y6()).g() != null;
	}

	// Token: 0x060014BD RID: 5309 RVA: 0x0005DD30 File Offset: 0x0005BF30
	[CompilerGenerated]
	private bool b0(e1k A_0)
	{
		return this.bp.a(A_0) && new bzv(A_0.c().y6()).g() != null;
	}

	// Token: 0x060014BE RID: 5310 RVA: 0x0005DD68 File Offset: 0x0005BF68
	[CompilerGenerated]
	private bool bz(e1k A_0)
	{
		return this.bo.a(A_0) && new bzv(A_0.c().y6()).g() != null;
	}

	// Token: 0x060014BF RID: 5311 RVA: 0x0005DDA0 File Offset: 0x0005BFA0
	[CompilerGenerated]
	private bool by(e1k A_0)
	{
		return this.aq.a(A_0) && new bzv(A_0.c().y6()).g() != null;
	}

	// Token: 0x060014C0 RID: 5312 RVA: 0x0005DDD8 File Offset: 0x0005BFD8
	[CompilerGenerated]
	private bool bx(e1k A_0)
	{
		if (this.ap.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			return amc != null && !amc.aa().b(d8o.e | d8o.j);
		}
		return false;
	}

	// Token: 0x060014C1 RID: 5313 RVA: 0x0005DE2C File Offset: 0x0005C02C
	[CompilerGenerated]
	private bool bw(e1k A_0)
	{
		return this.a1.a(A_0);
	}

	// Token: 0x060014C2 RID: 5314 RVA: 0x0005DE3C File Offset: 0x0005C03C
	[CompilerGenerated]
	private bool bv(e1k A_0)
	{
		if (this.a2.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null)
			{
				List<a5e> list = amc.aa().StatusEffects.Get<a5e>();
				if (list.Count >= 3)
				{
					return true;
				}
				if (list.Count >= 2)
				{
					if (Enumerable.Min<a5e>(list, new Func<a5e, double>(esk.a.a.a)) <= (double)d0u.b)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060014C3 RID: 5315 RVA: 0x0005DED8 File Offset: 0x0005C0D8
	[CompilerGenerated]
	private bool bu(e1k A_0)
	{
		if (this.a0.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null)
			{
				double num = 0.0;
				foreach (coh coh in amc.aa().Gear.i())
				{
					num += coh.Battery;
				}
				if (num < 20.0)
				{
					return false;
				}
				if (!euf.b(A_0.g().aa().Offense.u().TypedDefinition))
				{
					cmb cmb = bzv.d();
					if (cmb == null || cmb.b((int)as3.bk) > 3f)
					{
						return false;
					}
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014C4 RID: 5316 RVA: 0x0005DFD8 File Offset: 0x0005C1D8
	[CompilerGenerated]
	private bool bt(e1k A_0)
	{
		if (this.ay.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (!euf.b(A_0.g().aa().Offense.u().TypedDefinition))
			{
				cmb cmb = bzv.d();
				if (cmb == null || cmb.b((int)as3.bk) > 3f)
				{
					return false;
				}
			}
			if (amc != null && !amc.aa().b(d8o.e) && !amc.aa().SpecialStates.a)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014C5 RID: 5317 RVA: 0x0005E088 File Offset: 0x0005C288
	[CompilerGenerated]
	private bool bs(e1k A_0)
	{
		if (this.az.b(A_0) && cuo.a.NextDouble() < (double)this.dr)
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (!euf.b(A_0.g().aa().Offense.u().TypedDefinition))
			{
				cmb cmb = bzv.d();
				if (cmb == null || cmb.b((int)as3.bk) > 3f)
				{
					return false;
				}
			}
			if (amc != null)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014C6 RID: 5318 RVA: 0x0005E128 File Offset: 0x0005C328
	[CompilerGenerated]
	private bool br(e1k A_0)
	{
		return this.@as.a(A_0);
	}

	// Token: 0x060014C7 RID: 5319 RVA: 0x0005E140 File Offset: 0x0005C340
	[CompilerGenerated]
	private bool bq(e1k A_0)
	{
		if (this.ba.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			cmb cmb = bzv.d();
			if (amc != null && cmb != null && cmb.b(0) > 2f)
			{
				cd1 cd = dhh.a();
				int num;
				if (cmb.a((int)cd.TypedDefinition.ad(), out num) != -1f && num > 2)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060014C8 RID: 5320 RVA: 0x0005E1C8 File Offset: 0x0005C3C8
	[CompilerGenerated]
	private bool bp(e1k A_0)
	{
		return this.a9.a(A_0);
	}

	// Token: 0x060014C9 RID: 5321 RVA: 0x0005E1E0 File Offset: 0x0005C3E0
	[CompilerGenerated]
	private bool bo(e1k A_0)
	{
		return this.a6.a(A_0);
	}

	// Token: 0x060014CA RID: 5322 RVA: 0x0005E1F8 File Offset: 0x0005C3F8
	[CompilerGenerated]
	private bool bn(e1k A_0)
	{
		return this.a7.a(A_0);
	}

	// Token: 0x060014CB RID: 5323 RVA: 0x0005E210 File Offset: 0x0005C410
	[CompilerGenerated]
	private bool bm(e1k A_0)
	{
		return this.aw.a(A_0);
	}

	// Token: 0x060014CC RID: 5324 RVA: 0x0005E228 File Offset: 0x0005C428
	[CompilerGenerated]
	private bool bl(e1k A_0)
	{
		return this.av.a(A_0);
	}

	// Token: 0x060014CD RID: 5325 RVA: 0x0005E240 File Offset: 0x0005C440
	[CompilerGenerated]
	private bool bk(e1k A_0)
	{
		if (this.au.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			bool flag = bzv.g() != null;
			d4n d4n = dz6.b(A_0.g().aa());
			if (flag && d4n != null)
			{
				cmb cmb = bzv.d();
				if (cmb != null)
				{
					eoy eoy = dgk.Get<eoy>();
					eoj a_ = new eoj(A_0.g().aa(), null, null);
					float num = cmb.b((int)eoy.afi(null));
					if (num != -1f && d4n.c - Math.Max(0.0, (double)(num * 10f) - d4n.d) >= (double)eoy.afh(a_))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060014CE RID: 5326 RVA: 0x0005E30C File Offset: 0x0005C50C
	[CompilerGenerated]
	private bool bj(e1k A_0)
	{
		if (this.at.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (Enumerable.FirstOrDefault<elk>(amc.aa().StatusEffects.Get<elk>()) == null && amc != null && !amc.aa().b(d8o.e))
			{
				if ((double)Math.Max(amc.aa().Defense.v(), amc.aa().Defense.z()) >= euf.a(A_0.g().aa(), A_0.g().aa().Offense.u().TypedDefinition.e(), false) / 3.0)
				{
					return true;
				}
				cmb cmb = bzv.d();
				if (cmb != null)
				{
					bho bho = dgk.Get<bho>();
					new eoj(A_0.g().aa(), null, null);
					d4n d4n = dz6.b(A_0.g().aa());
					if (d4n != null && bho != null)
					{
						float num = cmb.b((int)bho.afi(null));
						if (d4n.c - Math.Max(0.0, (double)(num * 10f) - d4n.d) < (double)A_0.g().aa().Offense.av())
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060014CF RID: 5327 RVA: 0x0005E478 File Offset: 0x0005C678
	[CompilerGenerated]
	private bool bi(e1k A_0)
	{
		if (this.ax.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			d4n d4n = dz6.b(A_0.g().aa());
			if (d4n != null && this.ax.a() != null && d4n.c < (double)this.ax.a().afh(new eoj(A_0.g().aa(), null, null)))
			{
				return false;
			}
			amc amc = bzv.g();
			if (amc != null)
			{
				du2 du = amc.aa().Defense.af()[DamageType.Mechanical];
				if (du.a() > 0)
				{
					csk csk = Enumerable.FirstOrDefault<csk>(Enumerable.Where<csk>(euf.a(A_0.g().aa(), amc.aa(), new cmn(), 0.0, null, 1.0, null, true).f, new Func<csk, bool>(esk.a.a.a)));
					int num = (int)((double)du.a() * 1.25);
					double num2 = (double)(csk.Amount - num);
					return (double)(csk.Amount * 2 - num) / 2.5 > num2 || cuo.a.NextDouble() < 0.5;
				}
			}
		}
		return false;
	}

	// Token: 0x060014D0 RID: 5328 RVA: 0x0005E5F4 File Offset: 0x0005C7F4
	[CompilerGenerated]
	private bool bh(e1k A_0)
	{
		return this.c7.b(A_0) && A_0.g().aa().SpecialStates.b;
	}

	// Token: 0x060014D1 RID: 5329 RVA: 0x0005E624 File Offset: 0x0005C824
	[CompilerGenerated]
	private bool bg(e1k A_0)
	{
		if (this.db.b(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null)
			{
				blk blk = bzv.c(amc.a8().qe());
				double num = aw1.b(A_0.g().a8(), amc.a8());
				if (blk != null && blk.b() && num <= 2.0)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060014D2 RID: 5330 RVA: 0x0005E6AC File Offset: 0x0005C8AC
	[CompilerGenerated]
	private bool bf(e1k A_0)
	{
		if (this.c8.b(A_0) && !A_0.g().aa().SpecialStates.g)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().IsInControl && euf.b(amc.aa().Offense.u().TypedDefinition) && aw1.b(A_0.g().a8(), amc.a8()) <= 6.0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014D3 RID: 5331 RVA: 0x0005E758 File Offset: 0x0005C958
	[CompilerGenerated]
	private bool be(e1k A_0)
	{
		if (this.cm.a(A_0) && !A_0.g().aa().SpecialStates.g)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().IsInControl)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014D4 RID: 5332 RVA: 0x0005E7C0 File Offset: 0x0005C9C0
	[CompilerGenerated]
	private bool bd(e1k A_0)
	{
		if (this.cn.a(A_0) && !A_0.g().aa().SpecialStates.g)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().IsInControl)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014D5 RID: 5333 RVA: 0x0005E828 File Offset: 0x0005CA28
	[CompilerGenerated]
	private bool bc(e1k A_0)
	{
		if (this.c9.b(A_0) && !A_0.g().aa().SpecialStates.g)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().IsInControl && euf.b(amc.aa().Offense.u().TypedDefinition))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014D6 RID: 5334 RVA: 0x0005E8B0 File Offset: 0x0005CAB0
	[CompilerGenerated]
	private bool bb(e1k A_0)
	{
		if (this.b9.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null && amc.aa().IsInControl && !amc.aa().SpecialStates.b && amc.aa().Vehicle == null && amc.a8().k.b != null)
			{
				cmb cmb = bzv.d();
				if (cmb == null)
				{
					return false;
				}
				float num = dgk.Get<bkz>().afi(new eoj(A_0.g().aa(), null, null));
				float num2 = cmb.b((int)num);
				float num3 = cmb.b((int)A_0.g().aa().Offense.u().TypedDefinition.ad());
				if (num2 <= num3 || euf.b(A_0.g().aa().Offense.u().TypedDefinition))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060014D7 RID: 5335 RVA: 0x0005E9C4 File Offset: 0x0005CBC4
	[CompilerGenerated]
	private bool ba(e1k A_0)
	{
		if (this.b8.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null && amc.aa().IsInControl && !amc.aa().SpecialStates.b && amc.aa().Vehicle == null && amc.a8().k.b != null)
			{
				cmb cmb = bzv.d();
				if (cmb == null)
				{
					return false;
				}
				float num = dgk.Get<cs>().afi(new eoj(A_0.g().aa(), null, null));
				float num2 = cmb.b((int)num);
				float num3 = cmb.b((int)A_0.g().aa().Offense.u().TypedDefinition.ad());
				if (num2 <= num3 || euf.b(A_0.g().aa().Offense.u().TypedDefinition))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060014D8 RID: 5336 RVA: 0x0005EAD8 File Offset: 0x0005CCD8
	[CompilerGenerated]
	private bool a9(e1k A_0)
	{
		if (this.b7.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null && amc.aa().IsInControl && !amc.aa().SpecialStates.b && amc.aa().Vehicle == null && amc.a8().k.b != null)
			{
				cmb cmb = bzv.d();
				if (cmb == null)
				{
					return false;
				}
				float num = dgk.Get<ada>().afi(new eoj(A_0.g().aa(), null, null));
				float num2 = cmb.b((int)num);
				float num3 = cmb.b((int)A_0.g().aa().Offense.u().TypedDefinition.ad());
				if (num2 <= num3 || euf.b(A_0.g().aa().Offense.u().TypedDefinition))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060014D9 RID: 5337 RVA: 0x0005EBEC File Offset: 0x0005CDEC
	[CompilerGenerated]
	private bool a8(e1k A_0)
	{
		if (this.b6.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null)
			{
				if (ew0.a() && amc.aa().StatusEffects.a(aiw.a))
				{
					return false;
				}
				cmb cmb = bzv.d();
				if (cmb == null)
				{
					return false;
				}
				int radius = c18.a();
				return eb4.IsSafeToThrow<dei>(A_0.g(), amc, as3.at, radius, cmb, true, true, this.de, true);
			}
		}
		return false;
	}

	// Token: 0x060014DA RID: 5338 RVA: 0x0005EC84 File Offset: 0x0005CE84
	[CompilerGenerated]
	private bool a7(e1k A_0)
	{
		if (this.b1.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null)
			{
				cmb cmb = bzv.d();
				if (cmb == null)
				{
					return false;
				}
				int radius = c18.j();
				return eb4.IsSafeToThrow<dei>(A_0.g(), amc, as3.at, radius, cmb, true, true, this.de, true);
			}
		}
		return false;
	}

	// Token: 0x060014DB RID: 5339 RVA: 0x0005ECF4 File Offset: 0x0005CEF4
	[CompilerGenerated]
	private bool a6(e1k A_0)
	{
		if (this.b2.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null)
			{
				cmb cmb = bzv.d();
				if (cmb == null)
				{
					return false;
				}
				int radius = c18.i();
				return eb4.IsSafeToThrow<dei>(A_0.g(), amc, as3.at, radius, cmb, true, true, this.de, true);
			}
		}
		return false;
	}

	// Token: 0x060014DC RID: 5340 RVA: 0x0005ED64 File Offset: 0x0005CF64
	[CompilerGenerated]
	private bool a5(e1k A_0)
	{
		if (this.b3.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null && ((amc.aa().Gear.h().Item != null && amc.aa().Gear.h().Item.Battery > 10.0) || (amc.aa().Offense.u().TypedDefinition.ak() == AmmoType.Energy && amc.aa().Offense.u().Battery > 10.0)) && bpo.GetService<d02>() != null)
			{
				cmb cmb = bzv.d();
				if (cmb == null)
				{
					return false;
				}
				int radius = c18.e();
				return eb4.IsSafeToThrow<dei>(A_0.g(), amc, as3.at, radius, cmb, true, true, this.de, true);
			}
		}
		return false;
	}

	// Token: 0x060014DD RID: 5341 RVA: 0x0005EE68 File Offset: 0x0005D068
	[CompilerGenerated]
	private bool a4(e1k A_0)
	{
		if (this.b5.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null && !amc.aa().b(d8o.e) && !amc.aa().SpecialStates.a && bpo.GetService<d02>() != null)
			{
				cmb cmb = bzv.d();
				if (cmb == null)
				{
					return false;
				}
				int radius = c18.g();
				return eb4.IsSafeToThrow<dei>(A_0.g(), amc, as3.at, radius, cmb, true, true, this.de, true);
			}
		}
		return false;
	}

	// Token: 0x060014DE RID: 5342 RVA: 0x0005EF08 File Offset: 0x0005D108
	[CompilerGenerated]
	private bool a3(e1k A_0)
	{
		if (this.b4.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null && !amc.aa().b(d8o.e))
			{
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					d4n d4n = service.ahu(A_0.g().aa());
					if (d4n == null || d4n.c > 30.0)
					{
						return false;
					}
					cmb cmb = bzv.d();
					if (cmb == null)
					{
						return false;
					}
					int radius = c18.i();
					return eb4.IsSafeToThrow<dei>(A_0.g(), amc, as3.at, radius, cmb, true, true, this.de, true);
				}
			}
		}
		return false;
	}

	// Token: 0x060014DF RID: 5343 RVA: 0x0005EFC8 File Offset: 0x0005D1C8
	[CompilerGenerated]
	private bool a2(e1k A_0)
	{
		if (this.c5.b(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null)
			{
				blk blk = bzv.c(amc.a8().qe());
				double num = aw1.b(A_0.g().a8(), amc.a8());
				if (blk != null && blk.b() && num <= (double)(cv5.f - 1) && !amc.aa().StatusEffects.a(ef2.a))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060014E0 RID: 5344 RVA: 0x0005F06C File Offset: 0x0005D26C
	[CompilerGenerated]
	private bool a1(e1k A_0)
	{
		if (this.cb.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().b(d8o.e) && !amc.aa().d(CharacterImmunities.MindAffecting | CharacterImmunities.Incapacitation) && amc.aa().IsInControl)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014E1 RID: 5345 RVA: 0x0005F0E0 File Offset: 0x0005D2E0
	[CompilerGenerated]
	private bool a0(e1k A_0)
	{
		if (this.ci.a(A_0) && this.dq)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().d(CharacterImmunities.Fear) && !amc.aa().d(CharacterImmunities.MindAffecting) && !amc.aa().b(d8o.e) && !amc.aa().Passive)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014E2 RID: 5346 RVA: 0x0005F174 File Offset: 0x0005D374
	[CompilerGenerated]
	private bool az(e1k A_0)
	{
		if (this.cc.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().b(d8o.b) && !amc.aa().d(CharacterImmunities.MindAffecting) && amc.aa().Vehicle == null)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014E3 RID: 5347 RVA: 0x0005F1E8 File Offset: 0x0005D3E8
	[CompilerGenerated]
	private bool ay(e1k A_0)
	{
		if (this.ce.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().b(d8o.e) && !amc.aa().d(CharacterImmunities.Stun) && !amc.aa().SpecialStates.a)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014E4 RID: 5348 RVA: 0x0005F260 File Offset: 0x0005D460
	[CompilerGenerated]
	private bool ax(e1k A_0)
	{
		if (this.cf.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().b(d8o.b) && !amc.aa().d(CharacterImmunities.Root) && amc.aa().Vehicle == null && amc.aa().IsInControl && !amc.aa().SpecialStates.b)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014E5 RID: 5349 RVA: 0x0005F2FC File Offset: 0x0005D4FC
	[CompilerGenerated]
	private bool aw(e1k A_0)
	{
		if (this.cd.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().d(CharacterImmunities.Freeze) && amc.aa().IsInControl)
			{
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					d4n d4n = service.ahu(A_0.g().aa());
					if (d4n == null || d4n.c > 30.0)
					{
						return false;
					}
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014E6 RID: 5350 RVA: 0x0005F39C File Offset: 0x0005D59C
	[CompilerGenerated]
	private bool av(e1k A_0)
	{
		if (this.co.a(A_0) && !A_0.g().aa().SpecialStates.g && !A_0.g().aa().SpecialStates.b)
		{
			bzv bzv = new bzv(A_0.c().y6());
			if (bzv.g() != null)
			{
				cmb cmb = bzv.d();
				if (cmb == null)
				{
					return false;
				}
				float num = cmb.b(0);
				if (num != -1f && num <= 5f)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060014E7 RID: 5351 RVA: 0x0005F43C File Offset: 0x0005D63C
	[CompilerGenerated]
	private bool au(e1k A_0)
	{
		if (this.cg.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().d(CharacterImmunities.MindAffecting) && !amc.aa().b(d8o.e) && amc.aa().b(d8o.c) && !amc.aa().Passive)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014E8 RID: 5352 RVA: 0x0005F4C0 File Offset: 0x0005D6C0
	[CompilerGenerated]
	private bool at(e1k A_0)
	{
		if (this.ch.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().d(CharacterImmunities.MindAffecting) && !amc.aa().b(d8o.e) && !amc.aa().Passive)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014E9 RID: 5353 RVA: 0x0005F534 File Offset: 0x0005D734
	[CompilerGenerated]
	private bool @as(e1k A_0)
	{
		if (this.c2.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && euf.f(A_0.g().aa()) < 0.2f)
			{
				List<csk> classPropertyValue = amc.aa().CustomProperties.GetClassPropertyValue<List<csk>>(ddm.g);
				if (classPropertyValue != null)
				{
					if (Enumerable.Sum<csk>(classPropertyValue, new Func<csk, int>(esk.a.a.b)) >= (int)(amc.aa().Defense.q().zm() * 0.1f))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060014EA RID: 5354 RVA: 0x0005F5F0 File Offset: 0x0005D7F0
	[CompilerGenerated]
	private bool ar(e1k A_0)
	{
		if (this.c1.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().IsInControl)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014EB RID: 5355 RVA: 0x0005F640 File Offset: 0x0005D840
	[CompilerGenerated]
	private bool aq(e1k A_0)
	{
		if (this.cl.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().Feats.Contains<c3v>() && amc.aa().Offense.aa().zo() >= 20f && !amc.aa().SpecialStates.d && amc.aa().IsInControl)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014EC RID: 5356 RVA: 0x0005F6D8 File Offset: 0x0005D8D8
	[CompilerGenerated]
	private bool ap(e1k A_0)
	{
		if (this.cj.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().IsInControl && !amc.aa().StatusEffects.a(cpy.a) && (!euf.b(amc.aa().Offense.u().TypedDefinition) || A_0.g().aa().PsiAbilities.a() == 1))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014ED RID: 5357 RVA: 0x0005F77C File Offset: 0x0005D97C
	[CompilerGenerated]
	private bool ao(e1k A_0)
	{
		if (this.cz.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().IsInControl && !amc.aa().d(CharacterImmunities.TemporalEffects))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014EE RID: 5358 RVA: 0x0005F7E0 File Offset: 0x0005D9E0
	[CompilerGenerated]
	private bool an(e1k A_0)
	{
		if (this.ck.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && euf.f(amc.aa()) >= 0.5f)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014EF RID: 5359 RVA: 0x0005F834 File Offset: 0x0005DA34
	[CompilerGenerated]
	private bool am(e1k A_0)
	{
		if (this.b0.a(A_0) && !A_0.d().GetPrimitivePropertyValue<bool>("threwShockShuriken", new bool?(false)).Value)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().SpecialStates.a && !awq.f(A_0.g()) && !amc.aa().d(CharacterImmunities.Stun))
			{
				A_0.d()["threwShockShuriken"] = true;
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014F0 RID: 5360 RVA: 0x0005F8E4 File Offset: 0x0005DAE4
	[CompilerGenerated]
	private bool al(e1k A_0)
	{
		if (this.cc.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().b(d8o.b) && !amc.aa().d(CharacterImmunities.MindAffecting))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014F1 RID: 5361 RVA: 0x0005F948 File Offset: 0x0005DB48
	[CompilerGenerated]
	private bool ak(e1k A_0)
	{
		if (this.ar.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null && (amc.aa().SpecialStates.a || amc.aa().SpecialStates.c || amc.aa().SpecialStates.h) && !amc.aa().SpecialStates.k)
			{
				cmb cmb = bzv.d();
				if (cmb != null)
				{
					b13 b = dgk.Get<b13>();
					eoj a_ = new eoj(A_0.g().aa(), null, null);
					d4n d4n = dz6.b(A_0.g().aa());
					if (d4n != null && b != null)
					{
						float num = cmb.b((int)b.afi(null));
						return d4n.c - (Math.Max(0.0, (double)(num * 10f) - d4n.d) + (double)b.afh(a_)) > -30.0;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060014F2 RID: 5362 RVA: 0x0005FA6C File Offset: 0x0005DC6C
	[CompilerGenerated]
	private bool aj(e1k A_0)
	{
		if (this.bx.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().b(d8o.e) && !amc.aa().d(CharacterImmunities.Poison))
			{
				return !amc.aa().StatusEffects.a(ddr.a);
			}
		}
		return false;
	}

	// Token: 0x060014F3 RID: 5363 RVA: 0x0005FAE8 File Offset: 0x0005DCE8
	[CompilerGenerated]
	private bool ai(e1k A_0)
	{
		if (this.by.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().b(d8o.e) && !amc.aa().d(CharacterImmunities.Poison))
			{
				return !amc.aa().StatusEffects.a(dns.a);
			}
		}
		return false;
	}

	// Token: 0x060014F4 RID: 5364 RVA: 0x0005FB64 File Offset: 0x0005DD64
	[CompilerGenerated]
	private bool ah(e1k A_0)
	{
		if (this.bz.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().b(d8o.e) && !amc.aa().d(CharacterImmunities.Poison))
			{
				return !amc.aa().StatusEffects.a(ehp.a);
			}
		}
		return false;
	}

	// Token: 0x060014F5 RID: 5365 RVA: 0x0005FBE0 File Offset: 0x0005DDE0
	[CompilerGenerated]
	private bool ag(e1k A_0)
	{
		if (this.bt.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			return amc != null && !amc.aa().b(d8o.e) && !amc.aa().d(CharacterImmunities.Poison);
		}
		return false;
	}

	// Token: 0x060014F6 RID: 5366 RVA: 0x0005FC44 File Offset: 0x0005DE44
	[CompilerGenerated]
	private bool af(e1k A_0)
	{
		if (this.bw.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().b(d8o.e) && !amc.aa().d(CharacterImmunities.Poison))
			{
				bool flag = Enumerable.Any<dl2>(Enumerable.OfType<dl2>(amc.aa().StatusEffects.d()));
				bool flag2 = amc.aa().StatusEffects.a(bhe.a);
				return flag && !flag2;
			}
		}
		return false;
	}

	// Token: 0x060014F7 RID: 5367 RVA: 0x0005FCE4 File Offset: 0x0005DEE4
	[CompilerGenerated]
	private bool ae(e1k A_0)
	{
		if (this.bu.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			return amc != null && !amc.aa().b(d8o.e) && !amc.aa().d(CharacterImmunities.Poison);
		}
		return false;
	}

	// Token: 0x060014F8 RID: 5368 RVA: 0x0005FD48 File Offset: 0x0005DF48
	[CompilerGenerated]
	private new bool ad(e1k A_0)
	{
		if (this.bs.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			return amc != null && !amc.aa().b(d8o.e) && !amc.aa().d(CharacterImmunities.Poison);
		}
		return false;
	}

	// Token: 0x060014F9 RID: 5369 RVA: 0x0005FDAC File Offset: 0x0005DFAC
	[CompilerGenerated]
	private new bool ac(e1k A_0)
	{
		if (this.bv.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			return amc != null && !amc.aa().b(d8o.e) && !amc.aa().d(CharacterImmunities.Poison);
		}
		return false;
	}

	// Token: 0x060014FA RID: 5370 RVA: 0x0005FE10 File Offset: 0x0005E010
	[CompilerGenerated]
	private bool ab(e1k A_0)
	{
		return this.br.a(A_0) && new bzv(A_0.c().y6()).g() != null;
	}

	// Token: 0x060014FB RID: 5371 RVA: 0x0005FE40 File Offset: 0x0005E040
	[CompilerGenerated]
	private bool aa(e1k A_0)
	{
		return !this.dd || this.a(A_0.g());
	}

	// Token: 0x060014FC RID: 5372 RVA: 0x0005FE64 File Offset: 0x0005E064
	[CompilerGenerated]
	private new bool z(e1k A_0)
	{
		return this.c3.b(A_0);
	}

	// Token: 0x060014FD RID: 5373 RVA: 0x0005FE7C File Offset: 0x0005E07C
	[CompilerGenerated]
	private bool y(e1k A_0)
	{
		return this.ca.a(A_0) && new bzv(A_0.c().y6()).g() != null;
	}

	// Token: 0x060014FE RID: 5374 RVA: 0x0005FEAC File Offset: 0x0005E0AC
	[CompilerGenerated]
	private bool x(e1k A_0)
	{
		return this.c4.b(A_0);
	}

	// Token: 0x060014FF RID: 5375 RVA: 0x0005FEC4 File Offset: 0x0005E0C4
	[CompilerGenerated]
	private bool w(e1k A_0)
	{
		if (this.cv.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			if (bzv.g() != null)
			{
				evz evz = this.cv.a();
				if (evz == null)
				{
					return false;
				}
				cmb cmb = bzv.d();
				if (cmb == null)
				{
					return false;
				}
				eoj eoj = new eoj(A_0.g().aa(), null, null);
				float num = evz.afi(eoj);
				float num2 = num * evz.d;
				int num3;
				if (cmb.a((int)num, out num3) > 1.25f || (float)num3 < num2 * 0.8f)
				{
					return false;
				}
				if (!this.de)
				{
					ak1 ak = this.cv.a(A_0) as ak1;
					if (ak == null)
					{
						return false;
					}
					foreach (KeyValuePair<c5x, double> keyValuePair in aeh.a(A_0.g().a8(), ak, eoj, true))
					{
						amc amc = keyValuePair.Key.h.b;
						if (amc != null && amc != A_0.g() && A_0.g().a(amc) != global::h.a)
						{
							return false;
						}
					}
					return true;
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001500 RID: 5376 RVA: 0x00060038 File Offset: 0x0005E238
	[CompilerGenerated]
	private bool v(e1k A_0)
	{
		if (this.cx.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null && this.cx.a(A_0) is ak1)
			{
				if (this.de)
				{
					return true;
				}
				cmb cmb = bzv.d();
				if (cmb == null)
				{
					return false;
				}
				d7l d7l = dgk.Get<d7l>();
				eoj a_ = new eoj(A_0.g().aa(), null, null);
				return eb4.IsSafeToThrow<rs>(A_0.g(), amc, (int)d7l.afi(a_), d7l.g(a_) + 1, cmb, false, false, false, true);
			}
		}
		return false;
	}

	// Token: 0x06001501 RID: 5377 RVA: 0x000600EC File Offset: 0x0005E2EC
	[CompilerGenerated]
	private bool u(e1k A_0)
	{
		if (this.cw.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null)
			{
				if (ew0.a() && amc.aa().StatusEffects.a(aiw.a))
				{
					return false;
				}
				if (this.de)
				{
					return true;
				}
				cmb cmb = bzv.d();
				if (cmb == null)
				{
					return false;
				}
				c67 c = dgk.Get<c67>();
				eoj a_ = new eoj(A_0.g().aa(), null, null);
				return eb4.IsSafeToThrow<rs>(A_0.g(), amc, (int)c.afi(a_), c.g(a_), cmb, false, false, false, true);
			}
		}
		return false;
	}

	// Token: 0x06001502 RID: 5378 RVA: 0x000601A8 File Offset: 0x0005E3A8
	[CompilerGenerated]
	private bool t(e1k A_0)
	{
		if (this.ct.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			amc amc = bzv.g();
			if (amc != null)
			{
				if (!this.de)
				{
					cmb cmb = bzv.d();
					return cmb != null && eb4.IsSafeToThrow<fd>(A_0.g(), amc, (int)dgk.Get<dl3>().afi(new eoj(A_0.g().aa(), null, null)), 4, cmb, false, false, false, false);
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001503 RID: 5379 RVA: 0x00060234 File Offset: 0x0005E434
	[CompilerGenerated]
	private bool s(e1k A_0)
	{
		if (this.cu.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null)
			{
				if (ew0.a() && amc.aa().StatusEffects.a(aiw.a))
				{
					return false;
				}
				if (!this.de)
				{
					float a_ = (float)aw1.b(A_0.g().a8(), amc.a8()) + 1f;
					if (eb4.a(A_0.g(), amc, a_, 18))
					{
						return false;
					}
					foreach (amc amc2 in aw1.a(amc.a8(), 1))
					{
						if (amc2 != A_0.g() && A_0.g().a(amc2) != global::h.a)
						{
							return false;
						}
					}
					return true;
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001504 RID: 5380 RVA: 0x0006034C File Offset: 0x0005E54C
	[CompilerGenerated]
	private new bool r(e1k A_0)
	{
		if (this.cs.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().Passive && !amc.aa().b(d8o.e) && !amc.aa().d(CharacterImmunities.MindAffecting))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001505 RID: 5381 RVA: 0x000603C0 File Offset: 0x0005E5C0
	[CompilerGenerated]
	private new bool q(e1k A_0)
	{
		if (this.c0.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().d(CharacterImmunities.TemporalEffects))
			{
				List<csk> classPropertyValue = amc.aa().CustomProperties.GetClassPropertyValue<List<csk>>(ddm.g);
				if (classPropertyValue != null)
				{
					if (Enumerable.Sum<csk>(classPropertyValue, new Func<csk, int>(esk.a.a.c)) >= (int)(amc.aa().Defense.q().zm() * 0.25f))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06001506 RID: 5382 RVA: 0x00060478 File Offset: 0x0005E678
	[CompilerGenerated]
	private new bool p(e1k A_0)
	{
		if (this.cy.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().d(CharacterImmunities.TemporalEffects))
			{
				int count = amc.aa().StatusEffects.Get<bha>().Count;
				return count >= 3 || count != 2 || cuo.a.NextDouble() >= 0.5;
			}
		}
		return false;
	}

	// Token: 0x06001507 RID: 5383 RVA: 0x0006050C File Offset: 0x0005E70C
	[CompilerGenerated]
	private new bool o(e1k A_0)
	{
		return this.cr.a(A_0);
	}

	// Token: 0x06001508 RID: 5384 RVA: 0x00060524 File Offset: 0x0005E724
	[CompilerGenerated]
	private new bool n(e1k A_0)
	{
		return this.dg <= 0 || !euf.b(A_0.g().aa().Offense.u().TypedDefinition);
	}

	// Token: 0x06001509 RID: 5385 RVA: 0x00060564 File Offset: 0x0005E764
	[CompilerGenerated]
	private new bool m(e1k A_0)
	{
		return this.dg > 0;
	}

	// Token: 0x0600150A RID: 5386 RVA: 0x00060570 File Offset: 0x0005E770
	[CompilerGenerated]
	private new bool l(e1k A_0)
	{
		if (this.y.a(A_0))
		{
			int num = 0;
			List<c2b> list = A_0.g().aa().StatusEffects.Get<c2b>();
			if (list.Count > 0)
			{
				num += Enumerable.Sum<c2b>(list, new Func<c2b, int>(esk.a.a.a));
			}
			List<ab6> list2 = A_0.g().aa().StatusEffects.Get<ab6>();
			if (list2.Count > 0)
			{
				num += Enumerable.Sum<ab6>(list2, new Func<ab6, int>(esk.a.a.a));
			}
			if (num > 0)
			{
				return (double)((float)num / Math.Max(1f, A_0.g().aa().Defense.q().zo())) >= 0.1;
			}
			if (A_0.g().aa().StatusEffects.a(dns.a) && A_0.g().aa().Feats.Contains<c3v>())
			{
				return true;
			}
			if (A_0.g().aa().StatusEffects.a(vs.a))
			{
				return true;
			}
			if (A_0.g().aa().StatusEffects.a(ddr.a))
			{
				return true;
			}
			if (A_0.g().aa().StatusEffects.a(ef5.a))
			{
				return true;
			}
			if (A_0.g().aa().StatusEffects.a(ehp.a))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600150B RID: 5387 RVA: 0x00060728 File Offset: 0x0005E928
	[CompilerGenerated]
	private new bool k(e1k A_0)
	{
		if (this.z.a(A_0))
		{
			List<a5e> list = A_0.g().aa().StatusEffects.Get<a5e>();
			if (list.Count > 0)
			{
				int num = Enumerable.Sum<a5e>(list, new Func<a5e, int>(esk.a.a.b));
				if (num > 0)
				{
					return (double)((float)num / Math.Max(1f, A_0.g().aa().Defense.q().zo())) >= 0.1;
				}
			}
		}
		return false;
	}

	// Token: 0x0600150C RID: 5388 RVA: 0x000607D0 File Offset: 0x0005E9D0
	[CompilerGenerated]
	private new bool j(e1k A_0)
	{
		return this.@do && this.w.a(A_0);
	}

	// Token: 0x0600150D RID: 5389 RVA: 0x000607EC File Offset: 0x0005E9EC
	[CompilerGenerated]
	private new bool i(e1k A_0)
	{
		return this.x.a(A_0) && A_0.g().aa().Defense.q().zo() < A_0.g().aa().Defense.q().zm() * 0.5f;
	}

	// Token: 0x0600150E RID: 5390 RVA: 0x00060848 File Offset: 0x0005EA48
	[CompilerGenerated]
	private new bool h(e1k A_0)
	{
		return this.da.b(A_0) && A_0.g().aa().Defense.q().zo() < A_0.g().aa().Defense.q().zm() * 0.15f;
	}

	// Token: 0x0600150F RID: 5391 RVA: 0x000608A4 File Offset: 0x0005EAA4
	[CompilerGenerated]
	private new bool g(e1k A_0)
	{
		return this.ae.a(A_0) && A_0.g().aa().IsInCombat && new bzv(A_0.c().y6()).g() != null;
	}

	// Token: 0x06001510 RID: 5392 RVA: 0x000608F4 File Offset: 0x0005EAF4
	[CompilerGenerated]
	private new bool f(e1k A_0)
	{
		return this.aa.a(A_0) && A_0.g().aa().IsInCombat && new bzv(A_0.c().y6()).g() != null;
	}

	// Token: 0x06001511 RID: 5393 RVA: 0x00060944 File Offset: 0x0005EB44
	[CompilerGenerated]
	private new bool e(e1k A_0)
	{
		return this.ad.a(A_0) && A_0.g().aa().IsInCombat && new bzv(A_0.c().y6()).g() != null;
	}

	// Token: 0x06001512 RID: 5394 RVA: 0x00060994 File Offset: 0x0005EB94
	[CompilerGenerated]
	private new bool d(e1k A_0)
	{
		return this.ab.a(A_0) && A_0.g().aa().IsInCombat && A_0.g().aa().Feats.Contains<c3v>() && A_0.g().aa().Offense.aa().zo() < 25f && new bzv(A_0.c().y6()).g() != null;
	}

	// Token: 0x06001513 RID: 5395 RVA: 0x00060A20 File Offset: 0x0005EC20
	[CompilerGenerated]
	private new bool c(e1k A_0)
	{
		return this.ac.a(A_0) && A_0.g().aa().IsInCombat && A_0.g().aa().Feats.Contains<c3v>() && A_0.g().aa().Offense.aa().zo() < 25f && new bzv(A_0.c().y6()).g() != null;
	}

	// Token: 0x06001514 RID: 5396 RVA: 0x00060AAC File Offset: 0x0005ECAC
	[CompilerGenerated]
	private new bool b(e1k A_0)
	{
		if (ew0.b() && !A_0.g().aa().SpecialStates.b && (A_0.g().aa().Offense.u().TypedDefinition.ad() > 0f || (this.dg > 0 && this.dc)) && !A_0.d().GetPrimitivePropertyValue<bool>("regularLoSKitingAttempted", new bool?(false)).Value && !A_0.d().GetPrimitivePropertyValue<bool>("attemptedToAdvanceOnRequest", new bool?(false)).Value)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			d4n d4n = bpo.GetServiceOrThrow<d02>().ahu(A_0.g().aa());
			if (amc != null && amc.a8() != null && amc.a8().t.b != null && d4n.c < 10.0 && d4n.d >= 10.0)
			{
				int num = (int)d4n.c + (int)d4n.d;
				if (cgh.b(A_0.g(), amc, num))
				{
					return g8.a(A_0.c(), amc.a8().t.b, num / 10) != null;
				}
			}
		}
		return false;
	}

	// Token: 0x06001515 RID: 5397 RVA: 0x00060C24 File Offset: 0x0005EE24
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		amc amc = new bzv(A_0.c().y6()).g();
		d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
		serviceOrThrow.ahu(A_0.g().aa());
		if (amc != null && !A_0.d().GetPrimitivePropertyValue<bool>("losKited", new bool?(false)).Value && !A_0.d().GetPrimitivePropertyValue<bool>("attemptedToAdvanceOnRequest", new bool?(false)).Value)
		{
			bool flag = false;
			if (this.dl)
			{
				c2b c2b = Enumerable.FirstOrDefault<c2b>(Enumerable.Where<c2b>(amc.aa().StatusEffects.Get<c2b>(), new Func<c2b, bool>(esk.a.a.b)));
				if (c2b != null && c2b.Stacks >= 4 && c2b.TimeLeft > (double)d0u.b)
				{
					flag = true;
				}
			}
			if (!flag && this.dm && !this.cc.a(A_0))
			{
				foreach (d4n d4n in serviceOrThrow.ahl())
				{
					if (d4n.b.a8().t.b != null && d4n.b.a8().t.b.y6().GetPrimitivePropertyValue<bool>(ddq.a6, new bool?(false)).Value)
					{
						Guid? primitivePropertyValue = d4n.b.a8().t.b.y6().GetPrimitivePropertyValue<Guid>(ddq.a3, null);
						if (primitivePropertyValue != null && primitivePropertyValue.Value == amc.a8().qe())
						{
							flag = true;
							break;
						}
					}
				}
			}
			if (flag)
			{
				HashSet<r0> hashSet = amc.a8().t.b.b(serviceOrThrow);
				if (hashSet != null)
				{
					foreach (csd csd in cgh.a(A_0.g(), this.dn))
					{
						r0 r = new r0(csd.Area.c(), csd.Location.a().b());
						if (!hashSet.Contains(r))
						{
							return true;
						}
					}
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x06001516 RID: 5398 RVA: 0x00060EF0 File Offset: 0x0005F0F0
	[CompilerGenerated]
	private new cst b(a6w A_0)
	{
		A_0.b().d()["losKited"] = true;
		if (A_0.b().g().a8().k.b != null)
		{
			amc amc = new bzv(A_0.b().c().y6()).g();
			if (amc != null)
			{
				d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
				HashSet<r0> hashSet = A_0.b().c().b(serviceOrThrow);
				if (hashSet != null)
				{
					r0 r = new r0(amc.a8().Area.c(), amc.a8().Location.a().b());
					if (!hashSet.Contains(r))
					{
						awx awx = new awx();
						A_0.b().g().a8().i.b.b(awx, atp.a);
						return awx;
					}
				}
				HashSet<r0> hashSet2 = amc.a8().t.b.b(serviceOrThrow);
				if (hashSet2 != null)
				{
					List<csd> list = cgh.a(A_0.b().g(), this.dn);
					ak1 ak = null;
					double num = 0.0;
					foreach (csd csd in list)
					{
						r0 r2 = new r0(csd.Area.c(), csd.Location.a().b());
						if (!hashSet2.Contains(r2))
						{
							ak1 ak2 = csd.Area.a(csd.Location.a());
							if (ak2 != null)
							{
								double num2 = aw1.a(A_0.b().g().a8(), ak2);
								if (ak == null || num > num2)
								{
									ak = ak2;
									num = num2;
								}
							}
						}
					}
					if (ak != null)
					{
						return A_0.b().g().a8().k.b.a(ak, 0.0, 1, 0, true);
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06001517 RID: 5399 RVA: 0x0006111C File Offset: 0x0005F31C
	[CompilerGenerated]
	private new cst a(a6w A_0)
	{
		A_0.b().d()["advancedForBursting"] = true;
		if (A_0.b().g().a8().k.b != null && !A_0.b().g().aa().SpecialStates.b)
		{
			bzv bzv = new bzv(A_0.b().c().y6());
			amc amc = bzv.g();
			if (amc != null)
			{
				cmb cmb = bzv.d();
				if (cmb != null)
				{
					d4n d4n = bpo.GetServiceOrThrow<d02>().ahu(A_0.b().g().aa());
					if (d4n != null)
					{
						int a_ = this.ao.a().afh(new eoj(A_0.b().g().aa(), null, null));
						double a_2 = aw1.b(amc.a8(), A_0.b().g().a8());
						int num = esk.a(d4n, a_, a_2, A_0.b().g().aa().Offense.u().TypedDefinition.e());
						int num2 = -1;
						int num3;
						if (A_0.b().g().aa().Offense.u().TypedDefinition.e() == btz.e)
						{
							num3 = 2;
						}
						else
						{
							num3 = 4;
						}
						int num4 = num3;
						while ((float)num4 <= A_0.b().g().aa().Offense.u().TypedDefinition.ad())
						{
							float num5 = cmb.b(num4);
							if (num5 == 0f)
							{
								break;
							}
							if (num5 != -1f && num5 * 10f <= (float)num)
							{
								num2 = num4;
								break;
							}
							num4++;
						}
						if (num2 != -1)
						{
							return A_0.b().g().a8().k.b.a(amc.a8(), (float)num2, 1, 0);
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x04000B38 RID: 2872
	protected new fh a;

	// Token: 0x04000B39 RID: 2873
	protected new fh b;

	// Token: 0x04000B3A RID: 2874
	protected new fh c;

	// Token: 0x04000B3B RID: 2875
	protected new fh d;

	// Token: 0x04000B3C RID: 2876
	protected new fh e;

	// Token: 0x04000B3D RID: 2877
	protected new fh f;

	// Token: 0x04000B3E RID: 2878
	protected new ej0 g;

	// Token: 0x04000B3F RID: 2879
	protected new ej0 h;

	// Token: 0x04000B40 RID: 2880
	protected new ej0 i;

	// Token: 0x04000B41 RID: 2881
	protected new ej0 j;

	// Token: 0x04000B42 RID: 2882
	protected new ej0 k;

	// Token: 0x04000B43 RID: 2883
	protected new ej0 l;

	// Token: 0x04000B44 RID: 2884
	protected new ej0 m;

	// Token: 0x04000B45 RID: 2885
	protected new ej0 n;

	// Token: 0x04000B46 RID: 2886
	protected new ej0 o;

	// Token: 0x04000B47 RID: 2887
	protected new ej0 p;

	// Token: 0x04000B48 RID: 2888
	protected new ej0 q;

	// Token: 0x04000B49 RID: 2889
	private new ej0 r;

	// Token: 0x04000B4A RID: 2890
	protected a6w s;

	// Token: 0x04000B4B RID: 2891
	protected a6w t;

	// Token: 0x04000B4C RID: 2892
	protected a6w u;

	// Token: 0x04000B4D RID: 2893
	protected ej0 v;

	// Token: 0x04000B4E RID: 2894
	protected TryUseConsumableNode<avr> w;

	// Token: 0x04000B4F RID: 2895
	protected TryUseConsumableNode<ja> x;

	// Token: 0x04000B50 RID: 2896
	protected TryUseConsumableNode<cdi> y;

	// Token: 0x04000B51 RID: 2897
	protected new TryUseConsumableNode<cyy> z;

	// Token: 0x04000B52 RID: 2898
	protected TryUseConsumableNode<do0> aa;

	// Token: 0x04000B53 RID: 2899
	protected TryUseConsumableNode<b6b> ab;

	// Token: 0x04000B54 RID: 2900
	protected new TryUseConsumableNode<bai> ac;

	// Token: 0x04000B55 RID: 2901
	protected new TryUseConsumableNode<brp> ad;

	// Token: 0x04000B56 RID: 2902
	protected TryUseConsumableNode<en4> ae;

	// Token: 0x04000B57 RID: 2903
	protected TryActivateAuraNode<agj> af;

	// Token: 0x04000B58 RID: 2904
	protected TryActivateAuraNode<e6v> ag;

	// Token: 0x04000B59 RID: 2905
	protected TryActivateAuraNode<bem> ah;

	// Token: 0x04000B5A RID: 2906
	protected TryInvokeSpecialAttackNode<e77> ai;

	// Token: 0x04000B5B RID: 2907
	protected TryInvokeSpecialAttackNode<e21> aj;

	// Token: 0x04000B5C RID: 2908
	protected TryInvokeSpecialAttackNode<d2g> ak;

	// Token: 0x04000B5D RID: 2909
	protected TryInvokeSpecialAttackNode<bch> al;

	// Token: 0x04000B5E RID: 2910
	protected TryInvokeSpecialAttackNode<bwh> am;

	// Token: 0x04000B5F RID: 2911
	protected TryInvokeSpecialAttackNode<b67> an;

	// Token: 0x04000B60 RID: 2912
	protected TryInvokeSpecialAttackNode<c91> ao;

	// Token: 0x04000B61 RID: 2913
	protected TryInvokeSpecialAttackNode<d9w> ap;

	// Token: 0x04000B62 RID: 2914
	protected TryInvokeSpecialAttackNode<dxn> aq;

	// Token: 0x04000B63 RID: 2915
	protected TryInvokeSpecialAttackNode<b13> ar;

	// Token: 0x04000B64 RID: 2916
	protected TryInvokeSpecialAttackNode<fz> @as;

	// Token: 0x04000B65 RID: 2917
	protected TryInvokeSpecialAttackNode<bho> at;

	// Token: 0x04000B66 RID: 2918
	protected TryInvokeSpecialAttackNode<eoy> au;

	// Token: 0x04000B67 RID: 2919
	protected TryInvokeSpecialAttackNode<p8> av;

	// Token: 0x04000B68 RID: 2920
	protected TryInvokeSpecialAttackNode<cbi> aw;

	// Token: 0x04000B69 RID: 2921
	protected TryInvokeSpecialAttackNode<bs> ax;

	// Token: 0x04000B6A RID: 2922
	protected TryInvokeSpecialAttackNode<czi> ay;

	// Token: 0x04000B6B RID: 2923
	protected TryInvokeSpecialAbilityNode<sy> az;

	// Token: 0x04000B6C RID: 2924
	protected TryInvokeSpecialAttackNode<w> a0;

	// Token: 0x04000B6D RID: 2925
	protected TryInvokeSpecialAttackNode<csr> a1;

	// Token: 0x04000B6E RID: 2926
	protected TryInvokeSpecialAttackNode<bhw> a2;

	// Token: 0x04000B6F RID: 2927
	protected TryInvokeSpecialAttackNode<bom> a3;

	// Token: 0x04000B70 RID: 2928
	protected TryInvokeSpecialAttackNode<xd> a4;

	// Token: 0x04000B71 RID: 2929
	protected TryInvokeSpecialAttackNode<a5p> a5;

	// Token: 0x04000B72 RID: 2930
	protected TryInvokeSpecialAttackNode<et> a6;

	// Token: 0x04000B73 RID: 2931
	protected TryInvokeSpecialAttackNode<btf> a7;

	// Token: 0x04000B74 RID: 2932
	protected TryInvokeSpecialAttackNode<aho> a8;

	// Token: 0x04000B75 RID: 2933
	protected TryInvokeSpecialAttackNode<cmu> a9;

	// Token: 0x04000B76 RID: 2934
	protected TryInvokeSpecialAttackNode<dhh> ba;

	// Token: 0x04000B77 RID: 2935
	protected TryInvokeSpecialAttackNode<bz1> bb;

	// Token: 0x04000B78 RID: 2936
	protected TryInvokeSpecialAttackNode<er6> bc;

	// Token: 0x04000B79 RID: 2937
	protected TryUseQuickSlotItemCapNode<d01> bd;

	// Token: 0x04000B7A RID: 2938
	protected TryUseQuickSlotItemCapNode<cvo> be;

	// Token: 0x04000B7B RID: 2939
	protected TryUseQuickSlotItemCapNode<cl0> bf;

	// Token: 0x04000B7C RID: 2940
	protected TryUseQuickSlotItemCapNode<djc> bg;

	// Token: 0x04000B7D RID: 2941
	protected TryUseQuickSlotItemCapNode<e2v> bh;

	// Token: 0x04000B7E RID: 2942
	protected TryUseQuickSlotItemCapNode<eur> bi;

	// Token: 0x04000B7F RID: 2943
	protected TryUseQuickSlotItemCapNode<dby> bj;

	// Token: 0x04000B80 RID: 2944
	protected TryUseQuickSlotItemCapNode<d61> bk;

	// Token: 0x04000B81 RID: 2945
	protected TryUseQuickSlotItemCapNode<ers> bl;

	// Token: 0x04000B82 RID: 2946
	protected TryUseQuickSlotItemCapNode<ezy> bm;

	// Token: 0x04000B83 RID: 2947
	protected TryUseQuickSlotItemCapNode<a0e> bn;

	// Token: 0x04000B84 RID: 2948
	protected TryUseQuickSlotItemCapNode<emf> bo;

	// Token: 0x04000B85 RID: 2949
	protected TryUseQuickSlotItemCapNode<bka> bp;

	// Token: 0x04000B86 RID: 2950
	protected TryUseQuickSlotItemCapNode<e7b> bq;

	// Token: 0x04000B87 RID: 2951
	protected TryUseQuickSlotItemCapNode<bot> br;

	// Token: 0x04000B88 RID: 2952
	protected TryUseQuickSlotItemCapNode<ctm> bs;

	// Token: 0x04000B89 RID: 2953
	protected TryUseQuickSlotItemCapNode<atu> bt;

	// Token: 0x04000B8A RID: 2954
	protected TryUseQuickSlotItemCapNode<ck7> bu;

	// Token: 0x04000B8B RID: 2955
	protected TryUseQuickSlotItemCapNode<el9> bv;

	// Token: 0x04000B8C RID: 2956
	protected TryUseQuickSlotItemCapNode<aox> bw;

	// Token: 0x04000B8D RID: 2957
	protected TryUseQuickSlotItemCapNode<efr> bx;

	// Token: 0x04000B8E RID: 2958
	protected TryUseQuickSlotItemCapNode<euw> by;

	// Token: 0x04000B8F RID: 2959
	protected TryUseQuickSlotItemCapNode<a93> bz;

	// Token: 0x04000B90 RID: 2960
	protected TryUseQuickSlotItemCapNode<ew2> b0;

	// Token: 0x04000B91 RID: 2961
	protected TryUseQuickSlotItemCapNode<d1n> b1;

	// Token: 0x04000B92 RID: 2962
	protected TryUseQuickSlotItemCapNode<d6z> b2;

	// Token: 0x04000B93 RID: 2963
	protected TryUseQuickSlotItemCapNode<v0> b3;

	// Token: 0x04000B94 RID: 2964
	protected TryUseQuickSlotItemCapNode<c0p> b4;

	// Token: 0x04000B95 RID: 2965
	protected TryUseQuickSlotItemCapNode<e0d> b5;

	// Token: 0x04000B96 RID: 2966
	protected TryUseQuickSlotItemCapNode<dyp> b6;

	// Token: 0x04000B97 RID: 2967
	protected TryUseQuickSlotItemCapNode<ada> b7;

	// Token: 0x04000B98 RID: 2968
	protected TryUseQuickSlotItemCapNode<cs> b8;

	// Token: 0x04000B99 RID: 2969
	protected TryUseQuickSlotItemCapNode<bkz> b9;

	// Token: 0x04000B9A RID: 2970
	protected TryUseQuickSlotItemCapNode<anb> ca;

	// Token: 0x04000B9B RID: 2971
	protected TryInvokePsiAbilityNode<be7> cb;

	// Token: 0x04000B9C RID: 2972
	protected TryInvokePsiAbilityNode<eq6> cc;

	// Token: 0x04000B9D RID: 2973
	protected TryInvokePsiAbilityNode<cmp> cd;

	// Token: 0x04000B9E RID: 2974
	protected TryInvokePsiAbilityNode<dxh> ce;

	// Token: 0x04000B9F RID: 2975
	protected TryInvokePsiAbilityNode<bfk> cf;

	// Token: 0x04000BA0 RID: 2976
	protected TryInvokePsiAbilityNode<bnw> cg;

	// Token: 0x04000BA1 RID: 2977
	protected TryInvokePsiAbilityNode<dfd> ch;

	// Token: 0x04000BA2 RID: 2978
	protected TryInvokePsiAbilityNode<dx2> ci;

	// Token: 0x04000BA3 RID: 2979
	protected TryInvokePsiAbilityNode<ezt> cj;

	// Token: 0x04000BA4 RID: 2980
	protected TryInvokePsiAbilityNode<byu> ck;

	// Token: 0x04000BA5 RID: 2981
	protected TryInvokePsiAbilityNode<px> cl;

	// Token: 0x04000BA6 RID: 2982
	protected TryInvokePsiAbilityNode<d97> cm;

	// Token: 0x04000BA7 RID: 2983
	protected TryInvokePsiAbilityNode<a9> cn;

	// Token: 0x04000BA8 RID: 2984
	protected TryInvokePsiAbilityNode<eod> co;

	// Token: 0x04000BA9 RID: 2985
	protected fh cp;

	// Token: 0x04000BAA RID: 2986
	protected fh cq;

	// Token: 0x04000BAB RID: 2987
	protected TryInvokePsiAbilityNode<h7> cr;

	// Token: 0x04000BAC RID: 2988
	protected TryInvokePsiAbilityNode<dzs> cs;

	// Token: 0x04000BAD RID: 2989
	protected TryInvokePsiAbilityNode<dl3> ct;

	// Token: 0x04000BAE RID: 2990
	protected TryInvokePsiAbilityNode<c5y> cu;

	// Token: 0x04000BAF RID: 2991
	protected TryInvokePsiAbilityNode<evz> cv;

	// Token: 0x04000BB0 RID: 2992
	protected TryInvokePsiAbilityNode<c67> cw;

	// Token: 0x04000BB1 RID: 2993
	protected TryInvokePsiAbilityNode<d7l> cx;

	// Token: 0x04000BB2 RID: 2994
	protected TryInvokePsiAbilityNode<ed3> cy;

	// Token: 0x04000BB3 RID: 2995
	protected new TryInvokePsiAbilityNode<c4n> cz;

	// Token: 0x04000BB4 RID: 2996
	protected new TryInvokePsiAbilityNode<e6s> c0;

	// Token: 0x04000BB5 RID: 2997
	protected TryInvokePsiAbilityNode<c0o> c1;

	// Token: 0x04000BB6 RID: 2998
	protected TryInvokePsiAbilityNode<eqr> c2;

	// Token: 0x04000BB7 RID: 2999
	protected TryInvokeSpecialAbilityNode<e9> c3;

	// Token: 0x04000BB8 RID: 3000
	protected TryInvokeSpecialAbilityNode<zw> c4;

	// Token: 0x04000BB9 RID: 3001
	protected TryInvokeSpecialAbilityNode<cv5> c5;

	// Token: 0x04000BBA RID: 3002
	protected TryInvokeSpecialAbilityNode<bbc> c6;

	// Token: 0x04000BBB RID: 3003
	protected TryInvokeSpecialAbilityNode<e9> c7;

	// Token: 0x04000BBC RID: 3004
	protected TryInvokeSpecialAbilityNode<amv> c8;

	// Token: 0x04000BBD RID: 3005
	protected TryInvokeSpecialAbilityNode<b84> c9;

	// Token: 0x04000BBE RID: 3006
	protected TryInvokeSpecialAbilityNode<hy> da;

	// Token: 0x04000BBF RID: 3007
	protected TryInvokeSpecialAbilityNode<em> db;

	// Token: 0x04000BC0 RID: 3008
	private bool dc;

	// Token: 0x04000BC1 RID: 3009
	private bool dd;

	// Token: 0x04000BC2 RID: 3010
	private bool de;

	// Token: 0x04000BC3 RID: 3011
	private int df;

	// Token: 0x04000BC4 RID: 3012
	private int dg;

	// Token: 0x04000BC5 RID: 3013
	private bool dh = true;

	// Token: 0x04000BC6 RID: 3014
	private bool di;

	// Token: 0x04000BC7 RID: 3015
	private bool dj = true;

	// Token: 0x04000BC8 RID: 3016
	private bool dk;

	// Token: 0x04000BC9 RID: 3017
	private bool dl;

	// Token: 0x04000BCA RID: 3018
	private bool dm;

	// Token: 0x04000BCB RID: 3019
	private string dn;

	// Token: 0x04000BCC RID: 3020
	private bool @do;

	// Token: 0x04000BCD RID: 3021
	private bool dp;

	// Token: 0x04000BCE RID: 3022
	private bool dq;

	// Token: 0x04000BCF RID: 3023
	private float dr = 1f;

	// Token: 0x04000BD0 RID: 3024
	protected List<string> ds = new List<string>();

	// Token: 0x0200031F RID: 799
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060016CF RID: 5839 RVA: 0x00071490 File Offset: 0x0006F690
		internal object i(e1k A_0)
		{
			if (A_0.g() != null)
			{
				return A_0.g().a8();
			}
			return null;
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x000714AC File Offset: 0x0006F6AC
		internal void g(ej0 A_0)
		{
			A_0.b().d()["burstFailed"] = true;
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x000714CC File Offset: 0x0006F6CC
		internal bool j(e1k A_0)
		{
			return d3k.e(A_0.g().aa(), false);
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x000714E0 File Offset: 0x0006F6E0
		internal bool k(e1k A_0)
		{
			return d3k.b(A_0.g().aa());
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x000714F4 File Offset: 0x0006F6F4
		internal bool l(e1k A_0)
		{
			return dqe.a(A_0.g().aa());
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x00071508 File Offset: 0x0006F708
		internal bool d(e1k A_0)
		{
			return brf.a(A_0.g().aa());
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x0007151C File Offset: 0x0006F71C
		internal void h(ej0 A_0)
		{
			if (A_0.b().g().aa().Gear.j()[A_0.b().g().aa().Offense.au()].Item != null)
			{
				A_0.b().g().aa().Bag.z3(A_0.b().g().aa().Gear.j()[A_0.b().g().aa().Offense.au()].Item, true);
				A_0.b().g().aa().Gear.j()[A_0.b().g().aa().Offense.au()].Item = null;
			}
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x00071604 File Offset: 0x0006F804
		internal void d(ej0 A_0)
		{
			A_0.b().g().aa().Offense.k();
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x0007162C File Offset: 0x0006F82C
		internal void b(ej0 A_0)
		{
			d3k.a(A_0.b().g().aa(), A_0.b().g());
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x0007165C File Offset: 0x0006F85C
		internal void a(ej0 A_0)
		{
			dqe.a(A_0.b().g().aa(), A_0.b().g());
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x0007168C File Offset: 0x0006F88C
		internal void f(ej0 A_0)
		{
			brf.a(A_0.b().g().aa(), A_0.b().g());
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x000716BC File Offset: 0x0006F8BC
		internal void e(ej0 A_0)
		{
			A_0.b().d()["triedToActivateAlarm"] = true;
			Guid? primitivePropertyValue = A_0.b().c().y6().GetPrimitivePropertyValue<Guid>(ddq.ao, null);
			string classPropertyValue = A_0.b().c().y6().GetClassPropertyValue<string>(ddq.ap);
			if (primitivePropertyValue != null)
			{
				EntityAspectReference<bim, bim> entityAspectReference = new EntityAspectReference<bim, bim>(A_0.b().c().a8().Area, primitivePropertyValue.Value);
				if (entityAspectReference.ao() != null)
				{
					ale ale = A_0.b().c().a8().k.b;
					if (ale != null)
					{
						ale.b(entityAspectReference.ao().a8(), entityAspectReference.ao().t(), 1, false, null);
						return;
					}
				}
			}
			else if (!string.IsNullOrEmpty(classPropertyValue))
			{
				d60 addon = A_0.b().g().a8().Zone.GetAddon<d60>();
				if (addon != null)
				{
					List<b0b> list = addon.ab4(new string[]
					{
						classPropertyValue
					});
					if (list != null && list.Count > 0)
					{
						ale ale2 = A_0.b().c().a8().k.b;
						if (ale2 != null)
						{
							double num = double.MaxValue;
							bim bim = null;
							foreach (b0b b0b in list)
							{
								c5x c5x = b0b as c5x;
								if (c5x != null && c5x.s.b != null)
								{
									double num2 = aw1.b(b0b, A_0.b().g().a8());
									if (bim == null || num2 < num)
									{
										num = num2;
										bim = c5x.s.b;
									}
								}
							}
							if (bim != null)
							{
								ale2.b(bim.a8(), bim.t(), 1, false, null);
							}
						}
					}
				}
			}
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x000718E8 File Offset: 0x0006FAE8
		internal void i(ej0 A_0)
		{
			cot.a(A_0.b().g());
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x000718FC File Offset: 0x0006FAFC
		internal double a(a5e A_0)
		{
			return A_0.TimeLeft;
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x00071904 File Offset: 0x0006FB04
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x00071914 File Offset: 0x0006FB14
		internal object m(e1k A_0)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.a8() != null && amc.a8().Area != null)
			{
				return amc.a8().Area.a(amc.a8().aj().a());
			}
			return null;
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x0007197C File Offset: 0x0006FB7C
		internal bool f(e1k A_0)
		{
			if (!A_0.d().GetPrimitivePropertyValue<bool>("triedToActivateAlarm", new bool?(false)).Value)
			{
				bool flag = A_0.c().a8().k.b != null;
				Guid? primitivePropertyValue = A_0.c().y6().GetPrimitivePropertyValue<Guid>(ddq.ao, null);
				string classPropertyValue = A_0.c().y6().GetClassPropertyValue<string>(ddq.ap);
				string classPropertyValue2 = A_0.c().y6().GetClassPropertyValue<string>(ddq.aq);
				if (flag && !string.IsNullOrEmpty(classPropertyValue2) && (primitivePropertyValue != null || !string.IsNullOrEmpty(classPropertyValue)))
				{
					cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
					if (serviceOrThrow.aqw() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(classPropertyValue2, new bool?(false)).Value)
					{
						if (primitivePropertyValue != null)
						{
							return new EntityAspectReference<bim, bim>(A_0.c().a8().Area, primitivePropertyValue.Value).ao() != null;
						}
						d60 addon = A_0.g().a8().Zone.GetAddon<d60>();
						if (addon != null)
						{
							List<b0b> list = addon.ab4(new string[]
							{
								classPropertyValue
							});
							return list != null && list.Count > 0;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x00071AE8 File Offset: 0x0006FCE8
		internal bool n(e1k A_0)
		{
			cgk cgk = A_0.g().aa().Gear.l().Item;
			if (cgk != null && cgk.Definition != null)
			{
				if (Enumerable.Any<aia>(cgk.fu().@as(), new Func<aia, bool>(esk.a.a.a)) && cgk.Battery > 0.0 && !A_0.g().aa().StatusEffects.a(aee.a))
				{
					bl6 bl = ecf.a(dgk.Get<agj>(), new eru(new EntityAspectReference<amc, amc>(A_0.g())), null) as bl6;
					if (bl != null && bl.yw())
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00071BC0 File Offset: 0x0006FDC0
		internal bool a(aia A_0)
		{
			return A_0.CapabilityFullTypeName == "WirelessChargingAura";
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x00071BD4 File Offset: 0x0006FDD4
		internal bool p(e1k A_0)
		{
			cgk cgk = A_0.g().aa().Gear.l().Item;
			if (cgk != null && cgk.Definition != null)
			{
				if (Enumerable.Any<aia>(cgk.fu().@as(), new Func<aia, bool>(esk.a.a.b)) && cgk.Battery > 0.0 && !A_0.g().aa().StatusEffects.a(bzz.a))
				{
					bl6 bl = ecf.a(dgk.Get<bem>(), new eru(new EntityAspectReference<amc, amc>(A_0.g())), null) as bl6;
					if (bl != null && bl.yw())
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00071CAC File Offset: 0x0006FEAC
		internal bool b(aia A_0)
		{
			return A_0.CapabilityFullTypeName == "CombatExoskeletonAura";
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00071CC0 File Offset: 0x0006FEC0
		internal bool g(e1k A_0)
		{
			cgk cgk = A_0.g().aa().Gear.l().Item;
			if (cgk != null && cgk.Definition != null)
			{
				if (Enumerable.Any<aia>(cgk.fu().@as(), new Func<aia, bool>(esk.a.a.c)) && cgk.Battery > 0.0 && !A_0.g().aa().StatusEffects.a(jg.a))
				{
					bl6 bl = ecf.a(dgk.Get<e6v>(), new eru(new EntityAspectReference<amc, amc>(A_0.g())), null) as bl6;
					if (bl != null && bl.yw())
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x00071D98 File Offset: 0x0006FF98
		internal bool c(aia A_0)
		{
			return A_0.CapabilityFullTypeName == "IndustrialExoskeletonAura";
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00071DAC File Offset: 0x0006FFAC
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x00071DB8 File Offset: 0x0006FFB8
		internal bool c(e1k A_0)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			return amc != null && amc.aa().SpecialStates.c;
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x00071DF4 File Offset: 0x0006FFF4
		internal int c(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00071E00 File Offset: 0x00070000
		internal bool e(e1k A_0)
		{
			return A_0.g().aa().SpecialStates.d;
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00071E18 File Offset: 0x00070018
		internal object b(e1k A_0)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.a8() != null && amc.a8().Area != null)
			{
				List<ak1> list = aw1.c(amc.a8().Area.a(amc.a8().aj().a()));
				if (list.Count > 0)
				{
					List<ak1> list2 = new List<ak1>();
					foreach (ak1 ak in list)
					{
						if (!ak.Formation.b(4L))
						{
							list2.Add(ak);
						}
					}
					if (list2.Count > 0)
					{
						return list2[cuo.a.Next(list2.Count)];
					}
				}
			}
			return null;
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00071F14 File Offset: 0x00070114
		internal int a(c2b A_0)
		{
			return A_0.Power * A_0.Stacks;
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00071F24 File Offset: 0x00070124
		internal int a(ab6 A_0)
		{
			return A_0.Power * A_0.Stacks;
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00071F34 File Offset: 0x00070134
		internal int b(a5e A_0)
		{
			return A_0.Power * A_0.Stacks;
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00071F44 File Offset: 0x00070144
		internal bool o(e1k A_0)
		{
			return cot.b(A_0.g());
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00071F54 File Offset: 0x00070154
		internal bool a(e1k A_0)
		{
			if (ew0.a() && euf.b(A_0.g().aa().Offense.u().TypedDefinition) && !A_0.g().aa().SpecialStates.b && !A_0.d().GetPrimitivePropertyValue<bool>("regularLoSKitingAttempted", new bool?(false)).Value)
			{
				amc amc = new bzv(A_0.c().y6()).g();
				d4n d4n = bpo.GetServiceOrThrow<d02>().ahu(A_0.g().aa());
				if (amc != null && amc.aa().SpecialStates.b && amc.a8() != null && amc.a8().t.b != null && d4n.c < (double)A_0.g().aa().Offense.av() && d4n.d >= 10.0)
				{
					int num = (int)d4n.c + (int)d4n.d;
					if (cgh.a(A_0.g(), amc, num))
					{
						return g8.a(A_0.c(), amc.a8().t.b, Math.Min(A_0.g().aa().Offense.m() / 20, num / 10)) != null;
					}
				}
			}
			return false;
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x000720CC File Offset: 0x000702CC
		internal bool h(e1k A_0)
		{
			if (ew0.a() && !A_0.g().aa().SpecialStates.b && euf.b(A_0.g().aa().Offense.u().TypedDefinition) && !A_0.d().GetPrimitivePropertyValue<bool>("meleeKitingAttempted", new bool?(false)).Value && !A_0.d().GetPrimitivePropertyValue<bool>("attemptedToAdvanceOnRequest", new bool?(false)).Value)
			{
				amc amc = new bzv(A_0.c().y6()).g();
				d4n d4n = bpo.GetServiceOrThrow<d02>().ahu(A_0.g().aa());
				if (amc != null && amc.aa().SpecialStates.b && amc.a8() != null && amc.a8().t.b != null && d4n.c < (double)A_0.g().aa().Offense.av() && d4n.d >= 10.0)
				{
					int a_ = (int)d4n.c + (int)d4n.d;
					if (cgh.a(A_0.g(), amc, a_))
					{
						return g8.a(A_0.c(), amc.a8().t.b, A_0.g().aa().Offense.m() / 20, 1.8f, 3) != null;
					}
				}
			}
			return false;
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00072264 File Offset: 0x00070464
		internal bool b(c2b A_0)
		{
			return A_0.Code == "poison:BurrowerPoison";
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x0007227C File Offset: 0x0007047C
		internal cst a(a6w A_0)
		{
			A_0.b().d()["regularLoSKitingAttempted"] = true;
			amc amc = new bzv(A_0.b().c().y6()).g();
			d4n d4n = bpo.GetServiceOrThrow<d02>().ahu(A_0.b().g().aa());
			if (amc != null && amc.a8() != null && amc.a8().t.b != null && d4n.c < 10.0 && d4n.d >= 10.0)
			{
				int num = (int)d4n.c + (int)d4n.d;
				ak1 ak = g8.a(A_0.b().c(), amc.a8().t.b, num / 10);
				if (ak != null)
				{
					return A_0.b().g().a8().k.b.a(ak, 0.0, 1, 0, true);
				}
			}
			return null;
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00072394 File Offset: 0x00070594
		internal void c(ej0 A_0)
		{
			amc amc = new bzv(A_0.b().c().y6()).g();
			if (amc != null && !amc.aa().Dead)
			{
				ak1 ak = g8.a(A_0.b().c(), amc.a8().t.b, A_0.b().g().aa().Offense.m() / 20, 1.8f, 3);
				if (ak != null)
				{
					A_0.b().g().a8().k.b.a(ak, 0.0, 1, 0, true);
				}
			}
			A_0.b().d()["meleeKitingAttempted"] = true;
		}

		// Token: 0x04000D6B RID: 3435
		public static readonly esk.a a = new esk.a();

		// Token: 0x04000D6C RID: 3436
		public static Func<e1k, object> b;

		// Token: 0x04000D6D RID: 3437
		public static Action<ej0> c;

		// Token: 0x04000D6E RID: 3438
		public static Func<e1k, bool> d;

		// Token: 0x04000D6F RID: 3439
		public static Func<e1k, bool> e;

		// Token: 0x04000D70 RID: 3440
		public static Func<e1k, bool> f;

		// Token: 0x04000D71 RID: 3441
		public static Func<e1k, bool> g;

		// Token: 0x04000D72 RID: 3442
		public static Action<ej0> h;

		// Token: 0x04000D73 RID: 3443
		public static Action<ej0> i;

		// Token: 0x04000D74 RID: 3444
		public static Action<ej0> j;

		// Token: 0x04000D75 RID: 3445
		public static Action<ej0> k;

		// Token: 0x04000D76 RID: 3446
		public static Action<ej0> l;

		// Token: 0x04000D77 RID: 3447
		public static Action<ej0> m;

		// Token: 0x04000D78 RID: 3448
		public static Action<ej0> n;

		// Token: 0x04000D79 RID: 3449
		public static Func<a5e, double> o;

		// Token: 0x04000D7A RID: 3450
		public static Func<csk, bool> p;

		// Token: 0x04000D7B RID: 3451
		public static Func<e1k, object> q;

		// Token: 0x04000D7C RID: 3452
		public static Func<e1k, bool> r;

		// Token: 0x04000D7D RID: 3453
		public static Func<aia, bool> s;

		// Token: 0x04000D7E RID: 3454
		public static Func<e1k, bool> t;

		// Token: 0x04000D7F RID: 3455
		public static Func<aia, bool> u;

		// Token: 0x04000D80 RID: 3456
		public static Func<e1k, bool> v;

		// Token: 0x04000D81 RID: 3457
		public static Func<aia, bool> w;

		// Token: 0x04000D82 RID: 3458
		public static Func<e1k, bool> x;

		// Token: 0x04000D83 RID: 3459
		public static Func<csk, int> y;

		// Token: 0x04000D84 RID: 3460
		public static Func<e1k, bool> z;

		// Token: 0x04000D85 RID: 3461
		public static Func<csk, int> aa;

		// Token: 0x04000D86 RID: 3462
		public static Func<e1k, bool> ab;

		// Token: 0x04000D87 RID: 3463
		public static Func<e1k, object> ac;

		// Token: 0x04000D88 RID: 3464
		public static Func<c2b, int> ad;

		// Token: 0x04000D89 RID: 3465
		public static Func<ab6, int> ae;

		// Token: 0x04000D8A RID: 3466
		public static Func<a5e, int> af;

		// Token: 0x04000D8B RID: 3467
		public static Func<e1k, bool> ag;

		// Token: 0x04000D8C RID: 3468
		public static Func<e1k, bool> ah;

		// Token: 0x04000D8D RID: 3469
		public static Func<e1k, bool> ai;

		// Token: 0x04000D8E RID: 3470
		public static Func<c2b, bool> aj;

		// Token: 0x04000D8F RID: 3471
		public static Func<a6w, cst> ak;

		// Token: 0x04000D90 RID: 3472
		public static Action<ej0> al;
	}
}
