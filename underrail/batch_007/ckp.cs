using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Comm;
using TimelapseVertigo.Rules.Items;

// Token: 0x020013E3 RID: 5091
public sealed class ckp : e4
{
	// Token: 0x060072AF RID: 29359 RVA: 0x003026BC File Offset: 0x003008BC
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

	// Token: 0x060072B0 RID: 29360 RVA: 0x0030272C File Offset: 0x0030092C
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
		int a_ = A_0.Skills.Get<e8k>().g();
		if (euf.a(A_0, a_, A_2, 0.0)[0] >= 1.0)
		{
			bg.a = 1.0;
		}
		return bg;
	}

	// Token: 0x060072B1 RID: 29361 RVA: 0x003027E4 File Offset: 0x003009E4
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
			int num2 = cwt.f[0].Amount;
			efk a_13 = A_0.aa();
			efk a_14 = null;
			double a_15 = num;
			cmn a_16 = cmn;
			double a_17 = -10000.0;
			double a_18 = 1.0;
			bool a_19 = false;
			bool a_20 = flag;
			double a_21 = 1.0;
			bool a_22 = true;
			a_12 = new double?((double)1);
			int? num3 = null;
			cwt = euf.a(a_13, a_14, a_15, a_16, a_17, a_18, a_19, A_3, a_20, a_21, a_22, A_2, num3, true, a_12);
			if (cwt.f == null || cwt.f.Count == 0)
			{
				return;
			}
			int num4 = cwt.f[0].Amount;
			ekt ekt = new ekt();
			ekt.a = A_0.aa().Offense.a0();
			ekt.b = A_0.aa().Offense.am();
			int a_23 = A_0.aa().Skills.Get<e8k>().g();
			double[] array = euf.a(A_0.aa(), a_23, a_, 0.0);
			double num5 = bg.a / array[0];
			int a_24 = 3;
			double num6 = cuo.a.NextDouble();
			for (int i = 0; i < array.Length; i++)
			{
				double num7 = array[i] * num5;
				if (i == 2 && A_0.aa().Feats.Contains<d1p>())
				{
					num7 = 100.0;
				}
				if (num6 < num7)
				{
					a_24 = i;
					break;
				}
			}
			ak1 ak = awq.a(A_0.a8().t.b, A_1, a_24, false);
			bool flag2 = !Enumerable.Any<dlp>(Enumerable.OfType<dlp>(A_2.TypedDefinition.n()));
			Guid a_25 = Guid.NewGuid();
			string text;
			string text2;
			string text3;
			int num8;
			double num9;
			CombatSpeakEvent[] array2;
			blv blv;
			float a_26;
			cuu cuu;
			aig[] array3;
			if (!this.a(A_0, A_2, A_3, num2, num4, ekt, 1.0, 0.0, cmn, false, a_25, out text, out text2, out text3, out num8, out num9, out array2, out blv, out a_26, out cuu, out array3))
			{
				return;
			}
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			if (text == null)
			{
				return;
			}
			if (A_2.TypedDefinition.ao)
			{
				A_2.Durability = 0.0;
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
			Vector3 zero = Vector3.Zero;
			if (A_0.aa().Vehicle != null)
			{
				zero.Z = 0.25f;
			}
			b0b b0b = null;
			brv brv = new brv();
			brv.c = new EntityAspectReference<amc, amc>(A_0);
			c5x a_27 = A_0.a8();
			Vector3 a_28 = ak.Location.a() + new Vector3(0.5f, 0.5f, 0f);
			string a_29 = text;
			aig[] a_30 = array3;
			dvv dvv = es2.a(a_27, a_28, a_29, out b0b, null, a_30, true, 0.5f, null);
			if (dvv == null || b0b == null || b0b.Zone == null)
			{
				return;
			}
			b0b.Location += zero;
			b0b.ah();
			HorizontalDirection horizontalDirection = A_0.a8().VisualDirection;
			int num10 = (int)((horizontalDirection + 9) % (HorizontalDirection)8);
			string text4;
			if (num10 < 4)
			{
				text4 = "xphw_Rocketlauncher_muzzle_0";
			}
			else
			{
				text4 = "xphw_Rocketlauncher_muzzle_1";
				num10 -= 4;
			}
			aud a_31 = A_0.a8().Area;
			Vector3 a_32 = A_0.a8().Location + zero;
			HorizontalDirection? a_33 = new HorizontalDirection?(A_0.a8().VisualDirection);
			string a_34 = text4;
			int a_35 = 1;
			double maxValue = double.MaxValue;
			num3 = new int?(num10);
			c5x c5x = boj.a(a_31, a_32, a_33, a_34, a_35, maxValue, null, null, null, num3);
			if (c5x != null)
			{
				if (horizontalDirection == HorizontalDirection.North || horizontalDirection == HorizontalDirection.Northwest || horizontalDirection == HorizontalDirection.West)
				{
					c5x.VisualPriority = 99;
				}
				else
				{
					c5x.VisualPriority = -1;
				}
				c5x.@as();
			}
			b4u aspect = b0b.GetAspect<b4u>();
			if (aspect != null)
			{
				aspect.b().Add(new d2h(b0b));
			}
			qy.ad().Add(new cg6(A_0));
			new ah7("__rocketLantern", null)
			{
				Light = new ae8(new Color(255, 225, 225), 0.75f, LightType.Increment),
				Range = 3f,
				LightFadeRate = 0.25f
			}.g().be(b0b);
			qy.ad().Add(dvv);
			c7 c = new c7(b0b, false, false, true, false);
			c.a(true);
			qy.ad().Add(c);
			c5x c5x2 = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak.Entities, new Func<b0b, bool>(ckp.a.a.a))) as c5x;
			if (flag2 && !aw1.a(ak, false, null, l9.b))
			{
				if (c5x2 != null)
				{
					qy.ad().Add(new a4s(new bfq("GrenadeWaterSplash"), null, new ar7(c5x2), null));
				}
				qy.ad().Add(new kt(new edx(ak)));
			}
			else
			{
				if (c5x2 != null)
				{
					if (!string.IsNullOrEmpty(text2))
					{
						no no = new no();
						no.a(text2);
						no.a(c5x2.Location);
						no.a(new e6z(c5x2.Area));
						qy.ad().Add(new a4s(no, null, null, null));
					}
					if (!string.IsNullOrEmpty(text3))
					{
						bfq bfq = new bfq();
						bfq.b("grenade" + Guid.NewGuid().ToString());
						bfq.c(text3);
						bfq.a(bvl.c);
						qy.ad().Add(new a4s(bfq, null, new ar7(c5x2), null));
					}
				}
				if (cuu != null)
				{
					cuu.e(new eoj(A_0.aa(), null, A_1));
					cuu.g(new EntityAspectReference<amc, amc>(A_0));
					cuu.i(new edx(ak));
					awb awb = new awb(ak, cuu, (blv != null) ? new ae8?(blv.a.Light) : null, a_26, null, null, false);
					awb.b((double)num8);
					awb.r = true;
					if (blv != null && blv.a != null)
					{
						awb.c(blv.b);
						awb.b(blv.c);
						awb.a(blv.d);
					}
					qy.ad().Add(awb);
				}
				if (num9 > 0.0)
				{
					qy.ad().Add(new cn9(new edx(ak), num9));
				}
				string text5;
				string text6;
				string text7;
				int num11;
				double num12;
				CombatSpeakEvent[] array4;
				blv blv2;
				float a_36;
				cuu cuu2;
				if (this.a(A_0, A_2, A_3, num2, num4, ekt, 1.0, 0.0, cmn, true, a_25, out text5, out text6, out text7, out num11, out num12, out array4, out blv2, out a_36, out cuu2, out a_30))
				{
					if (!string.IsNullOrEmpty(text6))
					{
						no no2 = new no();
						no2.a(text6);
						no2.a(c5x2.Location);
						no2.a(new e6z(c5x2.Area));
						qy.ad().Add(new a4s(no2, null, null, null));
					}
					if (!string.IsNullOrEmpty(text7))
					{
						bfq bfq2 = new bfq();
						bfq2.b("grenade" + Guid.NewGuid().ToString());
						bfq2.c(text7);
						bfq2.a(bvl.c);
						qy.ad().Add(new a4s(bfq2, null, new ar7(c5x2), null));
					}
					if (cuu2 != null)
					{
						cuu2.e(new eoj(A_0.aa(), null, A_1));
						cuu2.g(new EntityAspectReference<amc, amc>(A_0));
						cuu2.i(new edx(ak));
						awb awb2 = new awb(ak, cuu2, (blv2 != null) ? new ae8?(blv2.a.Light) : null, a_36, null, null, false);
						awb2.b((double)num11);
						awb2.r = true;
						if (blv2 != null && blv2.a != null)
						{
							awb2.c(blv2.b);
							awb2.b(blv2.c);
							awb2.a(blv2.d);
						}
						qy.ad().Add(awb2);
					}
				}
			}
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			brv.b = new ActionReference<qy>(qy);
			if (array2 != null && array2.Length != 0)
			{
				a20.a(A_0.a8(), null, array2);
			}
			aru aru = A_0.a8().c();
			aru.a("LaunchRocket" + Guid.NewGuid().ToString(), "LaunchRocket", 1f, c9z.a, false, false);
			aru.a("fireballLaunch" + Guid.NewGuid().ToString(), "FireballLaunch", 1f, c9z.a, false, false);
			eym.a(A_0.a8(), (double)aju.bo);
			ct2 ct = Enumerable.FirstOrDefault<ct2>(Enumerable.OfType<ct2>(A_2.TypedDefinition.n()));
			if (ct != null && ct.a > 0f)
			{
				int value = (int)((A_0.a8().VisualDirection + 9) % (HorizontalDirection)8);
				aud a_37 = A_0.a8().Area;
				Vector3 a_38 = A_0.a8().Location;
				HorizontalDirection? a_39 = new HorizontalDirection?(A_0.a8().VisualDirection);
				string a_40 = "xphw_Rocketlauncher_backblast";
				int a_41 = 1;
				double maxValue2 = double.MaxValue;
				num3 = new int?(value);
				c5x c5x3 = boj.a(a_37, a_38, a_39, a_40, a_41, maxValue2, null, null, null, num3);
				if (c5x3 != null)
				{
					if (horizontalDirection == HorizontalDirection.North || horizontalDirection == HorizontalDirection.Northwest || horizontalDirection == HorizontalDirection.West)
					{
						c5x3.VisualPriority = 99;
					}
					else
					{
						c5x3.VisualPriority = -1;
					}
					c5x3.@as();
				}
				Point a_42 = A_0.a8().aj().a();
				Point a_43 = d05.a(a_42, bnx.b(aw1.b(A_0.a8().VisualDirection)).a(), false);
				bool flag3 = false;
				ak1 ak2 = A_0.a8().Area.a(a_43);
				if (ak2 == null || ak2.Formation.c(4L))
				{
					ak2 = A_0.a8().Area.a(a_42);
					flag3 = true;
				}
				if (ak2 != null)
				{
					c5x c5x4 = boj.a(A_0.a8().Area, ak2.Location.a(), null, "xphw_rocketlauncher_backblast_flame", 1, double.MaxValue, null, null, null, null);
					if (c5x4 != null)
					{
						new ah7("__backblast", null)
						{
							Light = new ae8(new Color(1f, 0.9f, 0.9f), 1f, LightType.Increment),
							Range = 3f,
							LightFadeRate = 0.4f,
							Layer = 1
						}.g().be(c5x4);
					}
					a1q a_44 = new a1q(DamageType.Heat, Math.Max(1, Convert.ToInt32((float)num2 * ct.a)), Math.Max(2, Convert.ToInt32((float)num4 * ct.a)));
					Guid af = Guid.NewGuid();
					foreach (b0b b0b2 in Enumerable.ToList<b0b>(ak2.Entities))
					{
						c5x c5x5 = (c5x)b0b2;
						if (c5x5.h.b != null && (c5x5.h.b != A_0 || flag3))
						{
							amc b = c5x5.h.b;
							cwt cwt2 = new cwt();
							cwt2.af = af;
							cwt2.f.Add(euf.a(a_44, 1.0));
							cwt2.b = true;
							cwt2.e = false;
							cwt2.x = AmmoType.None;
							cwt2.q = true;
							cwt2.ak = 0.5;
							cwt2.i = new ap9((A_0 != null) ? A_0.aa() : null);
							cwt2.h = ImpactSpeed.High;
							cwt2.v = "Обратный удар";
							cwt2.ae = A_2.TypedDefinition.ae();
							b.aa().Defense.a(cwt2);
							if (b != A_0)
							{
								awq.a(A_0, b, true, true, null, true, true, false, false);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060072B2 RID: 29362 RVA: 0x00303684 File Offset: 0x00301884
	private bool a(amc A_0, cd1 A_1, AmmoType A_2, int A_3, int A_4, ekt A_5, double A_6, double A_7, cmn A_8, bool A_9, Guid A_10, out string A_11, out string A_12, out string A_13, out int A_14, out double A_15, out CombatSpeakEvent[] A_16, out blv A_17, out float A_18, out cuu A_19, out aig[] A_20)
	{
		A_20 = null;
		dh0 dh = eub.h(A_2);
		A_18 = (float)euf.a(A_2);
		if (A_9)
		{
			if (A_2 == AmmoType.Rocket_40_Tandem)
			{
				A_11 = "Xphw_RLRocket_Tandem";
				A_12 = null;
				A_13 = bby.g();
				A_14 = bby.h();
				A_15 = (double)aju.a2;
				A_16 = new CombatSpeakEvent[]
				{
					CombatSpeakEvent.Battlecry_StandardGrenade
				};
				A_17 = bby.i();
				e3n e3n = new e3n(A_10);
				e3n.b = new a1q?(new a1q(DamageType.Heat, Math.Max(1, Convert.ToInt32((float)A_3 * 0.5f)), Math.Max(2, Convert.ToInt32((float)A_4 * 0.5f))));
				e3n.c = new a1q?(new a1q(DamageType.Mechanical, Math.Max(1, Convert.ToInt32((float)A_3 * 0.5f)), Math.Max(2, Convert.ToInt32((float)A_4 * 0.5f))));
				e3n.f = A_1.TypedDefinition.ae();
				if (dh != null)
				{
					e3n.ty(dh.a);
				}
				e3n.h = new vu(new b0q());
				e3n.i = A_5;
				A_19 = e3n;
				return true;
			}
		}
		else
		{
			if (A_2 == AmmoType.Rocket_40_Tandem)
			{
				A_11 = "Xphw_RLRocket_Tandem";
				A_12 = null;
				A_13 = bby.g();
				A_14 = bby.h();
				A_15 = (double)aju.a2;
				A_16 = new CombatSpeakEvent[]
				{
					CombatSpeakEvent.Battlecry_StandardGrenade
				};
				A_17 = bby.i();
				e3n e3n2 = new e3n(A_10);
				e3n2.b = new a1q?(new a1q(DamageType.Heat, Math.Max(1, Convert.ToInt32((float)A_3 * 0.3f)), Math.Max(2, Convert.ToInt32((float)A_4 * 0.3f))));
				e3n2.c = new a1q?(new a1q(DamageType.Mechanical, Math.Max(1, Convert.ToInt32((float)A_3 * 0.3f)), Math.Max(2, Convert.ToInt32((float)A_4 * 0.3f))));
				e3n2.f = A_1.TypedDefinition.ae();
				if (dh != null)
				{
					e3n2.ty(dh.a);
				}
				e3n2.h = new vu(new cfk(new b0q(), new bwi(2)));
				e3n2.i = A_5;
				A_19 = e3n2;
				A_18 = 1f;
				return true;
			}
			if (A_2 == AmmoType.Rocket_66_Incendiary)
			{
				A_11 = "Xphw_RLRocket_Incendiary";
				A_12 = null;
				A_13 = bby.g();
				A_14 = bby.h();
				A_15 = (double)aju.be;
				A_16 = new CombatSpeakEvent[]
				{
					CombatSpeakEvent.Battlecry_Firebomb
				};
				A_17 = bby.i();
				bsi bsi = new bsi();
				bsi.b = new a1q?(new a1q(DamageType.Heat, Math.Max(1, Convert.ToInt32((float)A_3 * 1f)), Math.Max(2, Convert.ToInt32((float)A_4 * 1f))));
				bsi.f = A_1.TypedDefinition.ae();
				bsi.g = new b1j?(new b1j(1.0, 4.0));
				bsi.j = new float?(0.4f);
				bsi.k = new float?(1f);
				bsi.l = new int?(3);
				if (dh != null)
				{
					bsi.ty(dh.a);
				}
				bsi.h = new vu(new b0q());
				bsi.i = A_5;
				A_19 = bsi;
				return true;
			}
			if (A_2 == AmmoType.Rocket_84_Kin)
			{
				A_11 = "Xphw_RLRocket_Kin";
				A_20 = new aig[]
				{
					new jf((A_0 != null) ? A_0.a8() : null)
					{
						i = A_5,
						g = new vu(null),
						d = A_0.a8().aj(),
						e = new a1q(DamageType.Mechanical, Math.Max(1, Convert.ToInt32((float)A_3 * 2f)), Math.Max(2, Convert.ToInt32((float)A_4 * 2f)))
					}
				};
				A_12 = null;
				A_13 = "SledgehammerHitMetal";
				A_14 = 0;
				A_15 = (double)aju.a0;
				A_16 = null;
				A_17 = null;
				A_19 = null;
				A_18 = 0f;
				return true;
			}
			if (A_2 == AmmoType.Rocket_84_Wp)
			{
				A_11 = "Xphw_RLRocket_Wp";
				A_12 = null;
				A_13 = bby.g();
				A_14 = 150;
				A_15 = (double)aju.a2;
				A_16 = new CombatSpeakEvent[]
				{
					CombatSpeakEvent.Battlecry_StandardGrenade
				};
				A_17 = bby.i();
				A_19 = new bsu
				{
					e = new a1q?(new a1q(DamageType.Heat, Math.Max(1, Convert.ToInt32((float)A_3 * 0.45f)), Math.Max(2, Convert.ToInt32((float)A_4 * 0.45f)))),
					f = new a1q?(new a1q(DamageType.Mechanical, Math.Max(1, Convert.ToInt32((float)A_3 * 0.2f)), Math.Max(2, Convert.ToInt32((float)A_4 * 0.2f)))),
					g = (((dh != null) ? dh.a : null) ?? null),
					h = new vu(new b0q()),
					b = A_5
				};
				return true;
			}
			if (A_2 == AmmoType.Rocket_84_Cs)
			{
				A_11 = "Xphw_RLRocket_Cs";
				A_12 = null;
				A_13 = bby.g();
				A_14 = bby.h();
				A_15 = (double)aju.a5;
				A_16 = new CombatSpeakEvent[]
				{
					CombatSpeakEvent.Battlecry_StandardGrenade
				};
				A_17 = bby.i();
				A_19 = new ic
				{
					e = new a1q?(new a1q(DamageType.Heat, Math.Max(1, Convert.ToInt32((float)A_3 * 0.25f)), Math.Max(2, Convert.ToInt32((float)A_4 * 0.25f)))),
					f = new a1q?(new a1q(DamageType.Mechanical, Math.Max(1, Convert.ToInt32((float)A_3 * 1f)), Math.Max(2, Convert.ToInt32((float)A_4 * 1f)))),
					g = (((dh != null) ? dh.a : null) ?? null),
					h = new vu(new b0q()),
					b = A_5
				};
				return true;
			}
			if (A_2 == AmmoType.Rocket_84_He)
			{
				A_11 = "Xphw_RLRocket_HE";
				A_12 = null;
				A_13 = bby.g();
				A_14 = bby.h();
				A_15 = (double)aju.a2;
				A_16 = new CombatSpeakEvent[]
				{
					CombatSpeakEvent.Battlecry_StandardGrenade
				};
				A_17 = bby.i();
				e3n e3n3 = new e3n();
				e3n3.b = new a1q?(new a1q(DamageType.Heat, Math.Max(1, Convert.ToInt32((float)A_3 * 0.5f)), Math.Max(2, Convert.ToInt32((float)A_4 * 0.5f))));
				e3n3.c = new a1q?(new a1q(DamageType.Mechanical, Math.Max(1, Convert.ToInt32((float)A_3 * 0.5f)), Math.Max(2, Convert.ToInt32((float)A_4 * 0.5f))));
				e3n3.f = A_1.TypedDefinition.ae();
				if (dh != null)
				{
					e3n3.ty(dh.a);
				}
				e3n3.h = new vu(new b0q());
				e3n3.i = A_5;
				A_19 = e3n3;
				return true;
			}
		}
		A_11 = null;
		A_12 = null;
		A_13 = null;
		A_14 = 0;
		A_15 = 0.0;
		A_16 = null;
		A_17 = null;
		A_19 = null;
		A_18 = 0f;
		return false;
	}

	// Token: 0x060072B3 RID: 29363 RVA: 0x00303DDC File Offset: 0x00301FDC
	public void ae(amc A_0, amc A_1, cd1 A_2, AmmoType A_3)
	{
	}

	// Token: 0x020013E5 RID: 5093
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060072B8 RID: 29368 RVA: 0x00303DFC File Offset: 0x00301FFC
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x04002ED6 RID: 11990
		public static readonly ckp.a a = new ckp.a();

		// Token: 0x04002ED7 RID: 11991
		public static Func<b0b, bool> b;
	}
}
