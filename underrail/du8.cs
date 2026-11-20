using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Comm;
using TimelapseVertigo.Rules.Items;

// Token: 0x020013EE RID: 5102
public sealed class du8 : e4
{
	// Token: 0x060072D7 RID: 29399 RVA: 0x00305010 File Offset: 0x00303210
	public void pe(amc A_0, amc A_1, cd1 A_2, cwt A_3, AmmoType A_4, enp A_5 = null, Action<cwt, amc> A_6 = null)
	{
		if (A_1 == null || A_1.a8() == null || A_1.a8().Area == null || A_1.a8().Zone == null)
		{
			return;
		}
		Point a_ = A_1.a8().aj().a();
		ak1 a_2 = A_1.a8().Area.a(a_);
		this.a(A_0, a_2, A_2, A_4, A_5);
	}

	// Token: 0x060072D8 RID: 29400 RVA: 0x00305080 File Offset: 0x00303280
	public bg3 zj(efk A_0, efk A_1, double A_2, bool A_3, double A_4, AmmoType A_5, cmn A_6)
	{
		if (A_0 == null)
		{
			return null;
		}
		if (A_0.Feats.Contains<d1p>())
		{
			if (A_6 == null)
			{
				A_6 = new cmn();
			}
			A_6.h += d1p.a(A_0);
		}
		bg3 bg = euf.a(A_0, null, A_2, 1.0, true, A_5, A_3, 1.0, A_6, null, null);
		int a_ = A_0.Skills.Get<ct7>().g();
		if (euf.a(A_0, a_, A_2, 0.0)[0] >= 1.0)
		{
			bg.a = 1.0;
		}
		return bg;
	}

	// Token: 0x060072D9 RID: 29401 RVA: 0x00305138 File Offset: 0x00303338
	public void a(amc A_0, ak1 A_1, cd1 A_2, AmmoType A_3, enp A_4 = null)
	{
		if (A_1 != null && A_1.Area != null && A_1.Area.Zone != null && A_0 != null && A_0.a8() != null && A_0.a8().t.b != null && A_2 != null)
		{
			double a_ = aw1.a(A_0.a8(), A_1);
			double num = aw1.a(A_0.a8(), A_1);
			cmn cmn = new cmn();
			bool flag = awq.f(A_0);
			bg3 bg = this.zj(A_0.aa(), null, num, flag, 1.0, A_3, cmn);
			efk a_2 = A_0.aa();
			efk a_3 = null;
			double a_4 = num;
			cmn a_5 = cmn;
			double a_6 = -10000.0;
			double a_7 = 1.0;
			bool a_8 = false;
			bool a_9 = flag;
			double a_10 = 1.0;
			bool a_11 = true;
			double? a_12 = new double?(0.0);
			cwt cwt = euf.a(a_2, a_3, a_4, a_5, a_6, a_7, a_8, A_3, a_9, a_10, a_11, A_2, null, true, a_12);
			if (cwt.f == null || cwt.f.Count == 0)
			{
				return;
			}
			int a_13 = cwt.f[0].Amount;
			efk a_14 = A_0.aa();
			efk a_15 = null;
			double a_16 = num;
			cmn a_17 = cmn;
			double a_18 = -10000.0;
			double a_19 = 1.0;
			bool a_20 = false;
			bool a_21 = flag;
			double a_22 = 1.0;
			bool a_23 = true;
			a_12 = new double?((double)1);
			cwt = euf.a(a_14, a_15, a_16, a_17, a_18, a_19, a_20, A_3, a_21, a_22, a_23, A_2, null, true, a_12);
			if (cwt.f == null || cwt.f.Count == 0)
			{
				return;
			}
			int a_24 = cwt.f[0].Amount;
			ekt ekt = new ekt();
			ekt.a = A_0.aa().Offense.a0();
			ekt.b = A_0.aa().Offense.am();
			int a_25 = A_0.aa().Skills.Get<ct7>().g();
			double[] array = euf.a(A_0.aa(), a_25, a_, 0.0);
			double num2 = bg.a / array[0];
			int a_26 = 3;
			double num3 = cuo.a.NextDouble();
			for (int i = 0; i < array.Length; i++)
			{
				double num4 = array[i] * num2;
				if (i == 2 && A_0.aa().Feats.Contains<d1p>())
				{
					num4 = 100.0;
				}
				if (num3 < num4)
				{
					a_26 = i;
					break;
				}
			}
			ak1 ak = awq.a(A_0.a8().t.b, A_1, a_26, false);
			bool flag2 = !Enumerable.Any<dlp>(Enumerable.OfType<dlp>(A_2.TypedDefinition.n()));
			string text;
			string text2;
			string text3;
			int num5;
			double num6;
			CombatSpeakEvent[] array2;
			blv blv;
			float a_27;
			cuu cuu;
			if (!this.a(A_2, A_3, a_13, a_24, ekt, 1.0, 0.0, cmn, out text, out text2, out text3, out num5, out num6, out array2, out blv, out a_27, out cuu))
			{
				return;
			}
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			if (cuu == null)
			{
				return;
			}
			dus dus = chp.a(A_2.TypedDefinition.w(), A_3);
			if (dus != null)
			{
				if (!string.IsNullOrEmpty(dus.a))
				{
					A_0.a8().c().a(dus.a);
				}
				if (dus.c > 0f)
				{
					eym.a(A_0.a8(), (double)dus.c);
				}
			}
			b0b b0b = null;
			brv brv = new brv();
			brv.c = new EntityAspectReference<amc, amc>(A_0);
			c5x a_28 = A_0.a8();
			Vector3 a_29 = ak.Location.a() + new Vector3(0.5f, 0.5f, 0f);
			string a_30 = text;
			aig[] a_31 = new aig[]
			{
				brv
			};
			dvv dvv = es2.a(a_28, a_29, a_30, out b0b, null, a_31, true, 0.5f, null);
			if (dvv == null || b0b == null || b0b.Zone == null)
			{
				return;
			}
			qy.ad().Add(new cg6(A_0));
			qy.ad().Add(dvv);
			c7 c = new c7(b0b, false, false, true, false);
			c.a(true);
			qy.ad().Add(c);
			c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak.Entities, new Func<b0b, bool>(du8.a.a.a))) as c5x;
			if (flag2 && !aw1.a(ak, false, null, l9.b))
			{
				if (c5x != null)
				{
					qy.ad().Add(new a4s(new bfq("GrenadeWaterSplash"), null, new ar7(c5x), null));
				}
				qy.ad().Add(new kt(new edx(ak)));
			}
			else
			{
				if (c5x != null)
				{
					if (!string.IsNullOrEmpty(text2))
					{
						no no = new no();
						no.a(text2);
						no.a(c5x.Location);
						no.a(new e6z(c5x.Area));
						qy.ad().Add(new a4s(no, null, null, null));
					}
					if (!string.IsNullOrEmpty(text3))
					{
						bfq bfq = new bfq();
						bfq.b("grenade" + Guid.NewGuid().ToString());
						bfq.c(text3);
						bfq.a(bvl.c);
						qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
					}
				}
				cuu.e(new eoj(A_0.aa(), null, A_1));
				cuu.g(new EntityAspectReference<amc, amc>(A_0));
				cuu.i(new edx(ak));
				awb awb = new awb(ak, cuu, (blv != null) ? new ae8?(blv.a.Light) : null, a_27, null, null, false);
				awb.b((double)num5);
				awb.r = true;
				if (blv != null && blv.a != null)
				{
					awb.c(blv.b);
					awb.b(blv.c);
					awb.a(blv.d);
				}
				qy.ad().Add(awb);
				if (num6 > 0.0)
				{
					qy.ad().Add(new cn9(new edx(ak), num6));
				}
			}
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			brv.b = new ActionReference<qy>(qy);
			if (array2 == null && array2.Length != 0)
			{
				a20.a(A_0.a8(), null, array2);
			}
		}
	}

	// Token: 0x060072DA RID: 29402 RVA: 0x00305814 File Offset: 0x00303A14
	private bool a(cd1 A_0, AmmoType A_1, int A_2, int A_3, ekt A_4, double A_5, double A_6, cmn A_7, out string A_8, out string A_9, out string A_10, out int A_11, out double A_12, out CombatSpeakEvent[] A_13, out blv A_14, out float A_15, out cuu A_16)
	{
		dh0 dh = eub.h(A_1);
		A_15 = (float)euf.b(A_1);
		if (A_1 == AmmoType.Grenade_40_Thermobaric)
		{
			A_8 = "Xphw_GlGrenade_Term";
			A_9 = null;
			A_10 = bby.g();
			A_11 = 120;
			A_12 = (double)aju.a6;
			A_13 = new CombatSpeakEvent[]
			{
				CombatSpeakEvent.Battlecry_StandardGrenade
			};
			A_14 = bby.i();
			a3h a3h = new a3h();
			a3h.b = new a1q?(new a1q(DamageType.Heat, Convert.ToInt32(Math.Max(1.0, (double)A_2 * 0.75)), Convert.ToInt32(Math.Max(2.0, (double)A_3 * 0.75))));
			a3h.c = new a1q?(new a1q(DamageType.Mechanical, Convert.ToInt32(Math.Max(1.0, (double)A_2 * 0.5)), Convert.ToInt32(Math.Max(2.0, (double)A_3 * 0.5))));
			a3h.f = A_0.TypedDefinition.ae();
			if (dh != null)
			{
				a3h.ty(dh.a);
			}
			a3h.h = new vu(new b0q());
			a3h.i = A_4;
			A_16 = a3h;
			return true;
		}
		if (A_1 == AmmoType.Grenade_40_Cluster)
		{
			A_8 = "Xphw_GlGrenade_Cls";
			A_9 = null;
			A_10 = bby.g();
			A_11 = bby.h();
			A_12 = (double)aju.a4;
			A_13 = new CombatSpeakEvent[]
			{
				CombatSpeakEvent.Battlecry_StandardGrenade
			};
			A_14 = bby.i();
			eyl eyl = new eyl();
			eyl.b = new a1q(DamageType.Heat, Convert.ToInt32(Math.Max(1.0, (double)A_2 * 0.15)), Convert.ToInt32(Math.Max(2.0, (double)A_3 * 0.15)));
			eyl.c = new a1q(DamageType.Mechanical, Convert.ToInt32(Math.Max(1.0, (double)A_2 * 0.15)), Convert.ToInt32(Math.Max(2.0, (double)A_3 * 0.15)));
			eyl.d = eyl.b;
			eyl.e = eyl.c;
			eyl.h = A_0.TypedDefinition.ae();
			if (dh != null)
			{
				eyl.ty(dh.a);
			}
			eyl.j = new vu(new b0q());
			eyl.k = A_4;
			A_16 = eyl;
			return true;
		}
		if (A_1 == AmmoType.Grenade_25_Concussive)
		{
			A_8 = "Xphw_GlGrenade_Conc";
			A_9 = null;
			A_10 = "ConcussiveGrenade";
			A_11 = 150;
			A_12 = (double)aju.ba;
			A_13 = new CombatSpeakEvent[]
			{
				CombatSpeakEvent.Battlecry_Flashbang
			};
			A_14 = new blv
			{
				a = new ah7("heGrenadeLantern", null),
				a = 
				{
					LightFadeRate = 0.25f,
					Range = 4f,
					Light = new ae8(new Color(200, 200, 255), 1f, LightType.Increment)
				},
				b = 0.25f,
				c = 0.2f,
				d = 4f
			};
			dhx dhx = new dhx();
			dhx.f = new a1q?(new a1q(DamageType.Mechanical, Convert.ToInt32(Math.Max(1.0, (double)A_2 * 0.65)), Convert.ToInt32(Math.Max(2.0, (double)A_3 * 0.65))));
			dhx.g = A_0.TypedDefinition.ae();
			if (dh != null)
			{
				dhx.h = dh.a;
			}
			dhx.j = new vu(new b0q());
			dhx.k = A_4;
			A_16 = dhx;
			return true;
		}
		if (A_1 == AmmoType.Grenade_25_Incendiary)
		{
			A_8 = "Xphw_GlGrenade_Inc";
			A_9 = null;
			A_10 = bby.g();
			A_11 = bby.h();
			A_12 = (double)aju.be;
			A_13 = new CombatSpeakEvent[]
			{
				CombatSpeakEvent.Battlecry_Firebomb
			};
			A_14 = bby.i();
			bsi bsi = new bsi();
			bsi.b = new a1q?(new a1q(DamageType.Heat, Convert.ToInt32(Math.Max(1.0, (double)A_2 * 0.4)), Convert.ToInt32(Math.Max(2.0, (double)A_3 * 0.4))));
			bsi.f = A_0.TypedDefinition.ae();
			bsi.g = new b1j?(new b1j(-1.0, 1.7));
			if (dh != null)
			{
				bsi.ty(dh.a);
			}
			bsi.h = new vu(new b0q());
			bsi.i = A_4;
			A_16 = bsi;
			return true;
		}
		if (A_1 % AmmoType.Caliber_5 == (AmmoType)1)
		{
			A_8 = "Xphw_GlGrenade_He";
			A_9 = null;
			A_10 = bby.g();
			A_11 = bby.h();
			A_12 = (double)aju.a2;
			A_13 = new CombatSpeakEvent[]
			{
				CombatSpeakEvent.Battlecry_StandardGrenade
			};
			A_14 = bby.i();
			e3n e3n = new e3n();
			e3n.b = new a1q?(new a1q(DamageType.Heat, Math.Max(1, A_2 / 2), Math.Max(2, A_3 / 2)));
			e3n.c = new a1q?(new a1q(DamageType.Mechanical, Math.Max(1, A_2 / 2), Math.Max(2, A_3 / 2)));
			e3n.f = A_0.TypedDefinition.ae();
			if (dh != null)
			{
				e3n.ty(dh.a);
			}
			e3n.h = new vu(new b0q());
			e3n.i = A_4;
			A_16 = e3n;
			return true;
		}
		if (A_1 % AmmoType.Caliber_5 == (AmmoType)2)
		{
			A_8 = "Xphw_GlGrenade_Frag";
			A_9 = null;
			A_10 = bby.j();
			A_11 = bby.k();
			A_12 = (double)aju.a2;
			A_13 = new CombatSpeakEvent[]
			{
				CombatSpeakEvent.Battlecry_StandardGrenade
			};
			A_14 = bby.l();
			crc crc = new crc();
			crc.c = new a1q?(new a1q(DamageType.Heat, Math.Max(1, Convert.ToInt32((float)A_2 * 0.25f)), Math.Max(2, Convert.ToInt32((float)A_3 * 0.25f))));
			crc.d = new a1q?(new a1q(DamageType.Mechanical, Math.Max(1, Convert.ToInt32((float)A_2 * 0.2f)), Math.Max(2, Convert.ToInt32((float)A_3 * 0.2f))));
			crc.h = A_0.TypedDefinition.ae();
			if (dh != null)
			{
				crc.ty(dh.a);
			}
			crc.i = new vu(new b0q());
			crc.j = A_4;
			A_16 = crc;
			return true;
		}
		A_8 = null;
		A_9 = null;
		A_10 = null;
		A_11 = 0;
		A_12 = 0.0;
		A_13 = null;
		A_14 = null;
		A_16 = null;
		A_15 = 0f;
		return false;
	}

	// Token: 0x060072DB RID: 29403 RVA: 0x00305F14 File Offset: 0x00304114
	public void ae(amc A_0, amc A_1, cd1 A_2, AmmoType A_3)
	{
	}

	// Token: 0x020013EF RID: 5103
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060072DF RID: 29407 RVA: 0x00305F34 File Offset: 0x00304134
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x04002EF1 RID: 12017
		public static readonly du8.a a = new du8.a();

		// Token: 0x04002EF2 RID: 12018
		public static Func<b0b, bool> b;
	}
}
