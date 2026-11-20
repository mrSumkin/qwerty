using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001437 RID: 5175
public static class awq
{
	// Token: 0x06007414 RID: 29716 RVA: 0x00311B10 File Offset: 0x0030FD10
	public static void a(amc A_0, amc A_1, cwt A_2, cd1 A_3, enp A_4 = null, Action<cwt, amc> A_5 = null)
	{
		ay7 ay = null;
		if (A_3 != null && A_3.TypedDefinition != null && !string.IsNullOrEmpty(A_3.TypedDefinition.b()))
		{
			ay = ckf.a(A_3.TypedDefinition.b());
		}
		if (ay != null)
		{
			ay.pe(A_0, A_1, A_3, A_2, A_2.x, A_4, A_5);
			return;
		}
		awq.a(A_0, A_1, A_2, A_3, A_4, true, null, null, null, false, false, true, null, null);
	}

	// Token: 0x06007415 RID: 29717 RVA: 0x00311B90 File Offset: 0x0030FD90
	public static void a(amc A_0, amc A_1, cwt A_2, cd1 A_3, enp A_4 = null, bool A_5 = true, Vector3? A_6 = null, string A_7 = null, aig[] A_8 = null, bool A_9 = false, bool A_10 = false, bool A_11 = true, string A_12 = null, string A_13 = null)
	{
		bke bke = null;
		if (A_3 != null)
		{
			bke = A_3.TypedDefinition;
		}
		float? primitivePropertyValue = bke.a7().GetPrimitivePropertyValue<float>("ProjectileSourceZOffset", null);
		awq.a(A_0, A_1, A_2);
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		dus dus = chp.a(bke.w(), A_2.x);
		awq.a(qy, A_0, bke, dus, A_5);
		if (A_11)
		{
			qy.ad().Add(new cg6(A_0));
		}
		b0b b0b = null;
		if (dus != null && (!string.IsNullOrEmpty(dus.b) || !string.IsNullOrEmpty(A_7)) && A_7 != "None")
		{
			if (primitivePropertyValue != null)
			{
				if (A_6 == null)
				{
					A_6 = new Vector3?(Vector3.Zero);
				}
				A_6 += Vector3.UnitZ * primitivePropertyValue.Value;
			}
			dvv dvv = es2.a(A_0.a8(), A_1.a8(), (A_7 != null) ? A_7 : dus.b, 0.65f, out b0b, (A_6 != null) ? A_6.Value : Vector3.Zero, A_8, true, 0.5f, dus.d);
			if (dvv != null)
			{
				qy.ad().Add(dvv);
			}
		}
		if (!A_10 && (A_2.b || !A_9))
		{
			awq.a(qy, A_0.a8(), A_1.a8(), true, true);
		}
		if (A_2.b)
		{
			if (!string.IsNullOrEmpty(dus.e) || !string.IsNullOrEmpty(A_12))
			{
				qy.ad().Add(new a7j(A_1.a8(), A_12 ?? dus.e, 1, double.MaxValue, true, false, null, null, null, null, false, null));
			}
			if (!string.IsNullOrEmpty(dus.f) || !string.IsNullOrEmpty(A_13))
			{
				qy.ad().Add(new a4s(new bfq(A_13 ?? dus.f), null, new ar7(A_1.a8()), null));
			}
		}
		awq.a(qy, A_0, A_1, bke, A_2, new vu(A_4), null, false);
		qy.ad().Add(new nu(A_0, A_3, A_11));
		if (A_2.b)
		{
			qy.ad().Add(new yl(A_0, A_3, A_11));
		}
		if (b0b != null)
		{
			c7 item = new c7(b0b, false, false, true, false);
			qy.ad().Add(item);
		}
		A_1.a8().Zone.ActionManager.g9(qy, atp.a);
		dz6.a(qy);
	}

	// Token: 0x06007416 RID: 29718 RVA: 0x00311EB8 File Offset: 0x003100B8
	public static void a(amc A_0, amc A_1, cwt A_2, cd1 A_3, enp A_4 = null)
	{
		awq.a(A_0, A_1, A_2);
		if (A_1 != null && !A_1.aa().SpecialStates.a && !A_1.aa().SpecialStates.c && !A_1.aa().SpecialStates.k)
		{
			dij dij = Enumerable.FirstOrDefault<dij>(A_1.aa().StatusEffects.Get<dij>());
			if (dij != null)
			{
				if (dij.Stacks == 1)
				{
					A_1.aa().StatusEffects.d(dij);
				}
				else
				{
					dij.Stacks--;
				}
				A_2.b = false;
			}
		}
		qy a_ = awq.a(A_0, A_1, A_2, A_3, A_4, true, false);
		A_1.a8().Zone.ActionManager.g9(a_, atp.a);
		dz6.a(a_);
		A_2.ab = Enumerable.ToList<d09>(Enumerable.OfType<d09>(A_0.aa().Defense.j().Keys));
		foreach (d09 d in A_2.ab)
		{
			List<cwt> list = d.ar5(A_2);
			if (list != null && list.Count > 0)
			{
				foreach (cwt a_2 in list)
				{
					qy a_3 = awq.a(A_0, A_1, a_2, null, null, false, false);
					A_1.a8().Zone.ActionManager.g9(a_3, atp.a);
					dz6.a(a_3);
				}
			}
		}
	}

	// Token: 0x06007417 RID: 29719 RVA: 0x00312084 File Offset: 0x00310284
	public static dtb a(amc A_0, amc A_1, cwt A_2, cd1 A_3, enp A_4 = null, bool A_5 = true, bool A_6 = false)
	{
		bke bke = null;
		if (A_3 != null)
		{
			bke = A_3.TypedDefinition;
		}
		dtb dtb = new dtb();
		dtb.b(false);
		dtb.c(false);
		if (bke != null)
		{
			dus a_ = chp.a(bke.w(), A_2.x);
			awq.a(dtb, A_0, bke, a_, true);
			if (A_2.b && (A_0.aa().Offense.u() == A_3 || A_3 == null))
			{
				dtb.ad().Add(new cg6(A_0));
			}
		}
		awq.a(dtb, A_0.a8(), A_1.a8(), true, true);
		awq.a(dtb, A_0, A_1, bke, A_2, A_5 ? new vu(A_4) : null, null, A_6);
		dtb.ad().Add(new nu(A_0, A_3, true));
		if (A_2.b)
		{
			dtb.ad().Add(new yl(A_0, A_3, true));
		}
		return dtb;
	}

	// Token: 0x06007418 RID: 29720 RVA: 0x00312178 File Offset: 0x00310378
	public static void a(c5x A_0, c5x A_1, bool A_2 = true, bool A_3 = true, bool A_4 = true, bool A_5 = true, bool A_6 = false, bool A_7 = false)
	{
		if (A_0 != null && A_0.h.b != null && A_1 != null && A_1.h.b != null)
		{
			awq.a(A_0.h.b, A_1.h.b, A_2, A_3, null, A_4, A_5, A_6, A_7);
		}
	}

	// Token: 0x06007419 RID: 29721 RVA: 0x003121D8 File Offset: 0x003103D8
	public static void a(amc A_0, amc A_1, bool A_2 = true, bool A_3 = true, object A_4 = null, bool A_5 = true, bool A_6 = true, bool A_7 = false, bool A_8 = false)
	{
		if (A_0 != null && A_1 != null)
		{
			object a_;
			if (A_4 != null)
			{
				a_ = A_4;
			}
			else if (A_0.a8() != null)
			{
				a_ = A_0.a8().Zone;
			}
			else
			{
				a_ = null;
			}
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			bool flag = A_0.aa().FactionId == A_1.aa().FactionId;
			if (!flag && A_0.aa().FactionId != asp.a && A_1.aa().FactionId != asp.a && A_0.aa().a(serviceOrThrow.aqu().ac(), A_1.aa().FactionId) == h.e && A_1.aa().a(serviceOrThrow.aqu().ac(), A_0.aa().FactionId) == h.e)
			{
				flag = true;
			}
			if ((A_0.aa().FactionId == asp.a && A_1.aa().c(d8o.u)) || (A_1.aa().FactionId == asp.a && A_0.aa().c(d8o.u)))
			{
				flag = true;
			}
			bool flag2 = false;
			if (!flag && A_0.aa().FactionId != asp.a && A_1.aa().FactionId != asp.a && (A_0.aa().FactionId == asp.a3 || A_1.aa().FactionId == asp.a3))
			{
				flag2 = true;
			}
			if (!flag && !flag2)
			{
				if (A_8 || (!A_0.aa().Passive && !A_1.aa().Passive) || A_0.aa().b(d8o.p) || A_1.aa().b(d8o.p))
				{
					A_0.aa().a(serviceOrThrow.aqu().ac(), A_1.aa().FactionId, A_1.aa().Id, a_, A_6);
					if (!A_1.aa().Passive && A_6)
					{
						bm6 b = A_0.a8().t.b;
						if (b != null)
						{
							b.a(A_1, A_3);
						}
					}
					A_1.aa().a(serviceOrThrow.aqu().ac(), A_0.aa().FactionId, A_0.aa().Id, a_, A_6);
					if (!A_0.aa().Passive && A_6)
					{
						bm6 b2 = A_1.a8().t.b;
						if (b2 != null)
						{
							b2.a(A_0, A_2);
						}
					}
				}
				if (A_0.aa().HostilityBroadcastMode == c2n.b || A_0.aa().HostilityBroadcastMode == c2n.d)
				{
					a7v.a(new ext(A_0, A_1));
				}
				if (A_1.aa().HostilityBroadcastMode == c2n.b || A_1.aa().HostilityBroadcastMode == c2n.d)
				{
					a7v.a(new ext(A_1, A_0));
				}
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					if (A_5 && service.ahg())
					{
						service.ah1(A_0, A_1);
					}
					bool flag3 = A_0.aa() is e3q || (A_0.aa().a(serviceOrThrow.aqu().ac(), asp.a) == h.e && !A_1.aa().Passive) || awq.d(A_0);
					bool flag4 = A_1.aa() is e3q || (A_1.aa().a(serviceOrThrow.aqu().ac(), asp.a) == h.e && !A_1.aa().Passive) || awq.d(A_1);
					if (A_6 && A_0 != A_1 && ((flag3 && !A_1.aa().Passive) || (flag4 && !A_0.aa().Passive)))
					{
						if (A_7)
						{
							service.ahn(null, false);
						}
						else
						{
							service.ahn(A_0, false);
						}
					}
				}
			}
			if (A_2)
			{
				A_0.u();
			}
			if (A_3)
			{
				A_1.u();
			}
		}
	}

	// Token: 0x0600741A RID: 29722 RVA: 0x00312664 File Offset: 0x00310864
	public static void a(qy A_0, c5x A_1, c5x A_2, bool A_3 = true, bool A_4 = true)
	{
		if (A_1 != null && A_1.h.b != null && A_2 != null && A_2.h.b != null)
		{
			A_0.ad().Add(new a27(A_1.h.b, A_2.h.b, A_3, A_4, false, true));
		}
	}

	// Token: 0x0600741B RID: 29723 RVA: 0x003126C8 File Offset: 0x003108C8
	public static cmn a(amc A_0, amc A_1, cd1 A_2 = null, bool A_3 = false)
	{
		cmn cmn;
		if (A_0 != null)
		{
			cmn = A_0.aa().Offense.a(new object[]
			{
				as3.a
			});
			cd1 cd;
			if (A_2 != null)
			{
				cd = A_2;
			}
			else
			{
				cd = A_0.aa().Offense.u();
			}
			WeaponSubtype? weaponSubtype = euf.d(cd.TypedDefinition);
			if (cd.TypedDefinition.e() == btz.g)
			{
				dd dd = Enumerable.FirstOrDefault<dd>(A_0.aa().StatusEffects.Get<dd>());
				if (dd != null)
				{
					cmn.b += aq0.a(A_0.aa()) * (double)dd.Stacks;
				}
			}
			if (A_0.aa().StatusEffects.a(ak3.a))
			{
				cmn.b += oh.a(A_0.aa());
			}
			if (A_0.aa().Feats.Contains<e8>() && euf.g(cd))
			{
				dqq dqq = Enumerable.FirstOrDefault<dqq>(A_0.aa().StatusEffects.Get<dqq>());
				if (dqq != null)
				{
					cmn.b += dqq.a(A_0.aa());
				}
			}
			if (A_1 != null)
			{
				if (A_1.a8() != null)
				{
					bm6 b = A_1.a8().t.b;
					if (b != null && !b.b(A_0, false))
					{
						cmn.f = true;
					}
				}
				if (A_0.aa().Feats.Contains<zf>() && !A_1.aa().Passive && !A_1.aa().b(d8o.e))
				{
					double num = zf.a(A_0.aa(), A_1.aa(), ref cmn.a);
					cmn.b += num;
				}
				if (A_0.aa().StatusEffects.a(brr.b))
				{
					double num2 = 0.0;
					List<d1> list = A_1.aa().StatusEffects.Get<d1>();
					if (list != null && list.Count > 0)
					{
						foreach (d1 d in list)
						{
							ar7 ar = d.b as ar7;
							if (ar != null && ar.ao() != null && ar.ao() == A_0.a8())
							{
								num2 = Math.Max(d.c, num2);
							}
						}
						if (A_3)
						{
							num2 *= 2.0;
						}
						if (A_1.aa().StatusEffects.Get<axo>().Count > 0)
						{
							num2 *= 2.0;
						}
					}
					if (num2 > 0.0)
					{
						cmn.b += num2;
					}
					else
					{
						cmn.g *= 1.0 - dfd.h;
					}
				}
				cwa cwa = Enumerable.FirstOrDefault<cwa>(A_0.aa().StatusEffects.Get<cwa>());
				if (cwa != null && A_1.a8() != null && A_1.a8().qe() == cwa.TargetId)
				{
					cmn.b += cwa.c();
					cmn.e += cwa.b();
				}
				if (A_0.aa().Feats.Contains<d52>() && A_1.aa().SpecialStates.g)
				{
					cmn.b += d52.c + (double)A_0.aa().GetSpecializationValue<cg8>(true) * cg8.a;
				}
				if (!A_1.aa().Passive && !A_1.aa().b(d8o.b | d8o.c | d8o.e) && A_0.aa().Feats.Contains<d7v>() && (cd.TypedDefinition.e() == btz.f || (weaponSubtype != null && (weaponSubtype.Value / (WeaponSubtype)100 == WeaponSubtype.Pistol_762 || weaponSubtype.Value / (WeaponSubtype)100 == WeaponSubtype.Pistol_44))))
				{
					cmn.b += d7v.a;
				}
				if (A_0.aa().Feats.Contains<egq>() && euf.d(cd.TypedDefinition.ak()))
				{
					ho ho = Enumerable.FirstOrDefault<ho>(A_0.aa().StatusEffects.Get<ho>());
					if (ho != null && ho.Stacks == egq.b && ho.TargetId == A_1.a8().qe())
					{
						cmn.b += egq.a + (double)A_0.aa().GetSpecializationValue<d3x>(true) * d3x.a;
					}
				}
				if (A_0.aa().Feats.Contains<b46>() && A_1.aa().b(d8o.b | d8o.c))
				{
					cmn.b += b46.a;
				}
				if (A_0.aa().Feats.Contains<cce>() && !A_1.aa().Passive && !A_1.aa().b(d8o.b | d8o.c | d8o.e))
				{
					cmn.b += cce.a;
				}
				if (A_0.aa().Feats.Contains<bld>() && !A_1.aa().Passive && !A_1.aa().b(d8o.b | d8o.c | d8o.e))
				{
					cmn.b += bld.a;
				}
				if (A_0.aa().Feats.Contains<bg6>() && A_1.aa().b(d8o.e))
				{
					cmn.b += bg6.a;
				}
				if (A_0.aa().Feats.Contains<aaw>() && !A_1.aa().Passive && !A_1.aa().b(d8o.e | d8o.i))
				{
					cmn.c += aaw.a;
				}
			}
			using (List<dxa>.Enumerator enumerator2 = A_0.aa().GetMicrofeats<dxa>().GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					dxa dxa = enumerator2.Current;
					dxa.afb(cmn, A_0, A_1, cd);
				}
				return cmn;
			}
		}
		cmn = new cmn();
		return cmn;
	}

	// Token: 0x0600741C RID: 29724 RVA: 0x00312D74 File Offset: 0x00310F74
	public static cmn a(amc A_0, amc A_1, cd1 A_2 = null, bool? A_3 = null)
	{
		cd1 cd;
		if (A_2 != null)
		{
			cd = A_2;
		}
		else
		{
			cd = A_0.aa().Offense.u();
		}
		cmn cmn = awq.a(A_0, A_1, A_2, false);
		if (A_0 != null && A_0.a8() != null)
		{
			if (A_1 != null && A_1.a8() != null && awq.a(A_0, A_1, cd) && !A_3.GetValueOrDefault())
			{
				cmn.c += dbe.a + (double)A_0.aa().Skills.Get<a2n>().g() * dbe.b + (double)A_0.aa().GetSpecializationValue<a16>(true) * a16.a;
				cmn.a |= c3u.e;
			}
			if (euf.m(cd) && !euf.k(cd) && !euf.i(cd) && cd.LoadedAmmo.Count == 0)
			{
				cmn.a |= c3u.f;
			}
			if (A_1 != null && A_1.a8() != null && A_0.aa().Feats.Contains<ry>() && cd.TypedDefinition.e() == btz.f && (A_1.aa().StatusEffects.a(dt9.a) || A_1.aa().StatusEffects.a(e32.a)))
			{
				cmn.a |= c3u.b;
				cmn.c = 100000.0;
				cmn.d += (double)A_0.aa().GetSpecializationValue<aj0>(true) * aj0.a;
			}
			if (A_1 != null && A_1.a8() != null)
			{
				double num = aw1.b(A_0.a8(), A_1.a8());
				if (A_0.aa().Feats.Contains<afn>() && euf.k(cd) && num <= 1.75)
				{
					cmn.b += afn.a + (double)A_0.aa().GetSpecializationValue<b1v>(true) * b1v.a;
					cmn.a |= c3u.g;
				}
			}
			if (A_0.aa().Feats.Contains<n4>() && euf.p(cd))
			{
				double num2 = n4.a(A_0.aa());
				if (num2 > 0.0)
				{
					cmn.b += num2;
				}
			}
			mc microfeat = A_0.aa().GetMicrofeat<mc>();
			if (microfeat != null && microfeat.a(A_0.aa()))
			{
				cmn.b += cvk.b(A_0.aa());
			}
			if (A_0.aa().Feats.Contains<chc>() && (chc.a(cd) || A_3.GetValueOrDefault()))
			{
				cmn.b += chc.b(A_0.aa());
				cmn.i = Math.Max(cmn.i, chc.a(A_0.aa()));
			}
			foreach (dxa dxa in A_0.aa().GetMicrofeats<dxa>())
			{
				dxa.a(cmn, A_0, A_1, cd, A_3);
			}
			bk0.b(A_0.aa(), (A_1 != null) ? A_1.aa() : null, cd, cmn);
		}
		return cmn;
	}

	// Token: 0x0600741D RID: 29725 RVA: 0x00313100 File Offset: 0x00311300
	public static cmn b(amc A_0, amc A_1, cd1 A_2 = null)
	{
		cmn cmn = awq.a(A_0, A_1, A_2, true);
		cd1 cd;
		if (A_2 != null)
		{
			cd = A_2;
		}
		else
		{
			cd = A_0.aa().Offense.u();
		}
		if (euf.o(cd) || cd.TypedDefinition.ae().GetValueOrDefault() == WeaponSubtype.Glove_Boxing)
		{
			double num = 0.0;
			if (A_0.aa().Feats.Contains<alo>())
			{
				num += alo.a + (double)A_0.aa().GetSpecializationValue<bu1>(true) * bu1.a;
			}
			if (A_0.aa().Feats.Contains<bfn>())
			{
				num += bfn.a;
			}
			if (cd.TypedDefinition.ae().GetValueOrDefault() == WeaponSubtype.Glove_Boxing)
			{
				num /= 2.0;
			}
			cmn.b += num;
		}
		if (cd.TypedDefinition.ae().GetValueOrDefault() == WeaponSubtype.Crowbar && A_0.aa().Feats.Contains<e0f>())
		{
			cmn.b += e0f.c(A_0.aa());
		}
		if (cd.TypedDefinition.ae().GetValueOrDefault() == WeaponSubtype.Spear && A_0.aa().Gear.l().Item != null && A_0.aa().Gear.l().Item.fu().a())
		{
			cmn.g *= 1.0 - (don.a - (double)A_0.aa().GetSpecializationValue<bc8>(true) * bc8.a);
		}
		foreach (dxa dxa in A_0.aa().GetMicrofeats<dxa>())
		{
			dxa.a(cmn, A_0, A_1, cd);
		}
		bk0.a(A_0.aa(), (A_1 != null) ? A_1.aa() : null, cd, cmn);
		return cmn;
	}

	// Token: 0x0600741E RID: 29726 RVA: 0x00313334 File Offset: 0x00311534
	public static bool a(amc A_0, amc A_1, cd1 A_2)
	{
		if (A_0.aa().Feats.Contains<dbe>() && A_2 != null && A_2.TypedDefinition.e() != btz.g && !euf.k(A_2) && !euf.i(A_2) && !euf.h(A_2))
		{
			double num = A_0.a8().l();
			double num2 = A_1.a8().l();
			if (num <= 0.45 && num2 >= 0.62)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600741F RID: 29727 RVA: 0x003133C8 File Offset: 0x003115C8
	public static bool a(amc A_0, cd1 A_1)
	{
		bke bke = A_1.TypedDefinition;
		if (bke == null)
		{
			return false;
		}
		if (!eub.a(A_1) && !eub.a(A_0.aa(), A_1))
		{
			if (bke.ak() == AmmoType.Energy)
			{
				bmj.a(A_0.a8(), new e5x("Недостаточно энергии!", adi.m, bke.a3(), false));
			}
			else if (bke.ak() == AmmoType.Bolts)
			{
				bmj.a(A_0.a8(), new e5x("Нет болтов!", adi.m, bke.a3(), false));
			}
			else
			{
				bmj.a(A_0.a8(), new e5x("Нет боеприпасов!", adi.m, bke.a3(), false));
			}
			awq.a(A_0.a8(), A_1);
			return false;
		}
		return true;
	}

	// Token: 0x06007420 RID: 29728 RVA: 0x0031349C File Offset: 0x0031169C
	public static void a(c5x A_0, cd1 A_1)
	{
		if (A_0 == null || A_1 == null)
		{
			return;
		}
		string text = null;
		if (euf.m(A_1) && (A_1.TypedDefinition.e() == btz.a || A_1.TypedDefinition.e() == btz.b))
		{
			text = "DryFire.Pistol";
		}
		else if (euf.m(A_1) && A_1.TypedDefinition.e() == btz.d)
		{
			text = "DryFire.Sniper";
		}
		else if (euf.m(A_1) && (A_1.TypedDefinition.e() == btz.c || A_1.TypedDefinition.e() == btz.j || A_1.TypedDefinition.e() == btz.k))
		{
			text = "DryFire.Rifle";
		}
		else if (A_1.TypedDefinition.e() == btz.e || A_1.TypedDefinition.e() == btz.h || A_1.TypedDefinition.e() == btz.l)
		{
			text = "DryFire.Shotgun";
		}
		else if (euf.h(A_1.TypedDefinition))
		{
			text = "DryFire.Energy";
		}
		else if (euf.f(A_1.TypedDefinition))
		{
			text = "DryFire.Energy";
		}
		if (!string.IsNullOrEmpty(text))
		{
			A_0.c().a(text);
		}
	}

	// Token: 0x06007421 RID: 29729 RVA: 0x003135EC File Offset: 0x003117EC
	public static bool f(amc A_0)
	{
		if (A_0 == null || A_0.a8() == null || A_0.a8().Area == null)
		{
			return false;
		}
		aud aud = A_0.a8().Area;
		Point point;
		Point point2;
		A_0.a8().a(out point, out point2);
		for (int i = point.X - 1; i <= point2.X + 1; i++)
		{
			for (int j = point.Y - 1; j <= point2.Y + 1; j++)
			{
				ak1 ak = aud.b(i, j);
				if (ak != null)
				{
					foreach (b0b b0b in ak.Entities)
					{
						c5x c5x = (c5x)b0b;
						if (c5x.t.b != null && aw1.b(A_0.a8(), c5x) < 2.0 && c5x.t.b.e(A_0))
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06007422 RID: 29730 RVA: 0x0031372C File Offset: 0x0031192C
	public static bool a(amc A_0, b0b A_1)
	{
		return A_0 != null && A_0.a8() != null && A_0.a8().Area != null && A_1 != null && A_1.Area == A_0.a8().Area && aw1.b(A_0.a8(), A_1) < 2.0;
	}

	// Token: 0x06007423 RID: 29731 RVA: 0x00313798 File Offset: 0x00311998
	public static double a(eu7 A_0, amc A_1, double A_2)
	{
		if (A_0 != null)
		{
			bon bon = A_0.p() as bon;
			if (bon != null)
			{
				return bon.l9(new eoj(A_0.b8(), A_0.b9(), A_1), A_2);
			}
		}
		return 1.0;
	}

	// Token: 0x06007424 RID: 29732 RVA: 0x003137E0 File Offset: 0x003119E0
	public static double a(bon A_0, efk A_1, object A_2, amc A_3, double A_4)
	{
		if (A_0 != null)
		{
			return A_0.l9(new eoj(A_1, A_2, A_3), A_4);
		}
		return 1.0;
	}

	// Token: 0x06007425 RID: 29733 RVA: 0x00313804 File Offset: 0x00311A04
	public static void a(efk A_0)
	{
		aw0 aw = Enumerable.FirstOrDefault<aw0>(A_0.StatusEffects.Get<aw0>());
		if (aw != null)
		{
			A_0.StatusEffects.d(aw);
		}
	}

	// Token: 0x06007426 RID: 29734 RVA: 0x00313834 File Offset: 0x00311A34
	public static ak1 a(a6k A_0, ak1 A_1, int A_2, bool A_3 = false)
	{
		return awq.a(A_0.vg().q().t.b, A_1, A_2, A_3);
	}

	// Token: 0x06007427 RID: 29735 RVA: 0x00313854 File Offset: 0x00311A54
	public static ak1 a(bm6 A_0, ak1 A_1, int A_2, bool A_3 = false)
	{
		if (A_2 > 0 && A_0 != null)
		{
			bpo.GetServiceOrThrow<d02>();
			List<ak1> list = A_0.af();
			A_0.z();
			if (list != null && list.Count > 0)
			{
				HashSet<ak1> hashSet = new HashSet<ak1>();
				List<ak1>[] array = new List<ak1>[4];
				array[0] = new List<ak1>();
				array[0].Add(A_1);
				for (int i = 1; i < 4; i++)
				{
					array[i] = new List<ak1>();
					foreach (ak1 a_ in array[i - 1])
					{
						foreach (ak1 ak in aw1.c(a_))
						{
							if (!hashSet.Contains(ak))
							{
								if (!ak.Formation.b(4L) && (!A_3 || !ak.Formation.b(2L)) && list.Contains(ak))
								{
									array[i].Add(ak);
								}
								hashSet.Add(ak);
							}
						}
					}
				}
				for (int j = A_2; j >= 0; j--)
				{
					while (array[j].Count > 0)
					{
						int index = cuo.a.Next(array[j].Count);
						ak1 ak2 = array[j][index];
						array[j].RemoveAt(index);
						if (j <= 0)
						{
							return ak2;
						}
						bbg bbg = new bbg();
						bbg.a(false);
						bbg.a().Add(new awq.a(ak2.Area));
						bbg.a(float.MaxValue);
						if (new exm(bbg, A_0.a8().aj().b(), ak2.Location.b() + new Vector2(0.5f, 0.5f)).a(null).b())
						{
							return ak2;
						}
					}
				}
			}
		}
		return A_1;
	}

	// Token: 0x06007428 RID: 29736 RVA: 0x00313AA4 File Offset: 0x00311CA4
	public static void a(qy A_0, amc A_1, amc A_2, bke A_3, cwt A_4, enp A_5, string A_6 = null, bool A_7 = false)
	{
		string a_ = null;
		string a_2 = null;
		string a_3 = null;
		string a_4 = null;
		float a_5 = 0f;
		float a_6 = 0f;
		if (A_4.b)
		{
			awq.a(A_2, A_3, out a_, out a_2, out a_3, out a_4, out a_5, out a_6, A_6, A_4.c.GetValueOrDefault());
		}
		akg item = new akg(A_1, A_2, A_4, new kg(A_5, a_, a_2, a_3, a_4, a_5, a_6), A_7);
		A_0.ad().Add(item);
		if (A_3 != null && A_4.b)
		{
			foreach (string a_7 in A_3.am())
			{
				A_0.ad().Add(new a4s(new bfq(a_7), null, new ar7(A_2.a8()), null));
			}
			foreach (string a_8 in A_3.j())
			{
				A_0.ad().Add(new a7j(A_2.a8(), a_8, 1, double.MaxValue, true, false, null, null, null, null, false, null));
			}
		}
	}

	// Token: 0x06007429 RID: 29737 RVA: 0x00313C34 File Offset: 0x00311E34
	public static void b(amc A_0, amc A_1, int A_2)
	{
		if (A_1 == null)
		{
			return;
		}
		if (!A_1.aa().Dead && !A_1.aa().c(d8o.e) && !A_1.aa().Passive)
		{
			if (A_1.aa().d(CharacterImmunities.Unbalancing))
			{
				etm a_ = new etm(new ap9(A_1.aa()), "неустойчивости");
				bey.a(a_, A_0.aa(), A_1.aa(), A_1);
				a7v.a(a_);
				bmj.a(A_1.a8(), new ba0());
				return;
			}
			if (!A_1.aa().SpecialStates.k)
			{
				elk a_2 = new elk(bho.c);
				A_1.aa().StatusEffects.a(a_2, false, false, false);
			}
		}
	}

	// Token: 0x0600742A RID: 29738 RVA: 0x00313D04 File Offset: 0x00311F04
	public static void a(amc A_0, amc A_1, int A_2, bool A_3, bool A_4 = true)
	{
		if (A_1 == null || A_2 <= 0 || A_1.aa().Dead)
		{
			return;
		}
		if (A_1.aa().d(CharacterImmunities.Daze) || A_1.aa().Passive || A_1.aa().c(d8o.e))
		{
			if (A_4)
			{
				etm a_ = new etm(new ap9(A_1.aa()), "дезориентации");
				bey.a(a_, A_0.aa(), A_1.aa(), A_1);
				a7v.a(a_);
				bmj.a(A_1.a8(), new ba0());
			}
			return;
		}
		if (!A_3 && euf.l(A_1.aa()))
		{
			c6f a_2 = new c6f(new ap9(A_1.aa()), (A_0 != null) ? new ap9(A_0.aa()) : null, "дезориентации");
			bey.a(a_2, (A_0 != null) ? A_0.aa() : null, A_1.aa(), A_1);
			a7v.a(a_2);
			bmj.a(A_1.a8(), new dym());
			return;
		}
		A_1.aa().StatusEffects.a(new eok(A_2 * d0u.b), false, false, false);
		vr a_3 = new vr(new ap9(A_1.aa()), new ap9(A_0.aa()), "{0}: дезориентация.", new Color?(adi.j), null);
		bey.a(a_3, A_0.aa(), A_1.aa(), A_1);
		a7v.a(a_3);
	}

	// Token: 0x0600742B RID: 29739 RVA: 0x00313E88 File Offset: 0x00312088
	public static void b(amc A_0, amc A_1, int A_2, bool A_3 = false)
	{
		if (A_1.aa().c(d8o.e) || A_1.aa().d(CharacterImmunities.Stun))
		{
			etm a_ = new etm(new ap9(A_1.aa()), "эффекту оглушения");
			bey.a(a_, A_0.aa(), A_1.aa(), A_1);
			a7v.a(a_);
			bmj.a(A_1.a8(), new ba0());
			return;
		}
		if (!A_3 && euf.l(A_1.aa()))
		{
			c6f a_2 = new c6f(new ap9(A_1.aa()), (A_0 != null) ? new ap9(A_0.aa()) : null, "оглушению");
			bey.a(a_2, A_0.aa(), A_1.aa(), A_1);
			a7v.a(a_2);
			bmj.a(A_1.a8(), new dym());
			return;
		}
		string str;
		els els = awq.a(A_1.aa(), A_2, out str);
		A_1.aa().StatusEffects.a(els, false, false, false);
		string a_3 = "{0}: " + str + ".";
		vr a_4 = new vr(new ap9(A_1.aa()), (A_0 != null) ? new ap9(A_0.aa()) : null, a_3, new Color?(adi.j), null);
		A_1.a8().c().a(Guid.NewGuid().ToString(), "Stun", 1f, c9z.a, false, false);
		bey.a(a_4, A_0.aa(), A_1.aa(), A_1);
		a7v.a(a_4);
		if (els is ab3 && A_0.aa() is e3q && !(A_1.aa() is e3q))
		{
			cxc.a(eyy.by);
		}
	}

	// Token: 0x0600742C RID: 29740 RVA: 0x00314048 File Offset: 0x00312248
	public static void a(amc A_0, amc A_1, int A_2, bool A_3 = false)
	{
		if (A_1 == null || A_1.a8() == null)
		{
			return;
		}
		if (A_1.aa().Passive)
		{
			return;
		}
		efk efk = (A_0 != null) ? A_0.aa() : null;
		if (A_1.aa().c(d8o.e))
		{
			if (A_1.aa().d(CharacterImmunities.ShortCircuiting))
			{
				etm a_ = new etm(new ap9(A_1.aa()), "короткому замыканию");
				bey.a(a_, efk, A_1.aa(), A_1);
				a7v.a(a_);
				bmj.a(A_1.a8(), new ba0());
				return;
			}
			clt a_2 = new clt(A_2);
			A_1.aa().StatusEffects.a(a_2, false, false, false);
			vr a_3 = new vr(new ap9(A_1.aa()), (efk != null) ? new ap9(efk) : null, "{0}: короткое замыкание.", new Color?(adi.j), null);
			bey.a(a_3, efk, A_1.aa(), A_1);
			a7v.a(a_3);
			if (efk is e3q && !(A_1.aa() is e3q))
			{
				cxc.a(eyy.bz);
				return;
			}
		}
		else
		{
			if (A_1.aa().d(CharacterImmunities.Stun))
			{
				etm a_4 = new etm(new ap9(A_1.aa()), "эффекту оглушения");
				bey.a(a_4, efk, A_1.aa(), A_1);
				a7v.a(a_4);
				bmj.a(A_1.a8(), new ba0());
				return;
			}
			if (!A_3 && euf.l(A_1.aa()))
			{
				c6f a_5 = new c6f(new ap9(A_1.aa()), (efk != null) ? new ap9(efk) : null, "оглушению");
				bey.a(a_5, efk, A_1.aa(), A_1);
				a7v.a(a_5);
				bmj.a(A_1.a8(), new dym());
				return;
			}
			string str;
			els els = awq.a(A_1.aa(), A_2, out str);
			A_1.aa().StatusEffects.a(els, false, false, false);
			string a_6 = "{0}: " + str + ".";
			vr a_7 = new vr(new ap9(A_1.aa()), (efk != null) ? new ap9(efk) : null, a_6, new Color?(adi.j), null);
			A_1.a8().c().a(Guid.NewGuid().ToString(), "Stun", 1f, c9z.a, false, false);
			bey.a(a_7, efk, A_1.aa(), A_1);
			a7v.a(a_7);
			if (els is ab3 && efk is e3q && !(A_1.aa() is e3q))
			{
				cxc.a(eyy.by);
			}
		}
	}

	// Token: 0x0600742D RID: 29741 RVA: 0x003142FC File Offset: 0x003124FC
	public static void c(amc A_0, amc A_1)
	{
		if (A_0 != null && A_1 != null && A_0.aa().Feats.Contains<c6t>())
		{
			List<a5e> list = A_1.aa().StatusEffects.Get<a5e>();
			if (list.Count > 0)
			{
				e1l a_ = new e1l((int)Enumerable.Max<a5e>(list, new Func<a5e, double>(awq.b.a.a)), c6t.a + (double)A_0.aa().GetSpecializationValue<del>(true) * del.a, c6t.b + (double)A_0.aa().GetSpecializationValue<b09>(true) * b09.a);
				A_1.aa().StatusEffects.a(a_, false, false, false);
			}
		}
	}

	// Token: 0x0600742E RID: 29742 RVA: 0x003143C0 File Offset: 0x003125C0
	public static void e(amc A_0)
	{
		if (A_0 != null)
		{
			List<els> list = new List<els>();
			list.AddRange(A_0.aa().StatusEffects.Get<bk9>());
			list.AddRange(A_0.aa().StatusEffects.Get<aiw>());
			list.AddRange(A_0.aa().StatusEffects.Get<d0f>());
			foreach (els a_ in list)
			{
				A_0.aa().StatusEffects.d(a_);
			}
			a0s a0s = Enumerable.FirstOrDefault<a0s>(A_0.aa().StatusEffects.Get<a0s>());
			if (a0s != null)
			{
				if (a0s.Stacks > 1)
				{
					a0s a0s2 = a0s;
					int num = a0s2.Stacks;
					a0s2.Stacks = num - 1;
					return;
				}
				A_0.aa().StatusEffects.d(a0s);
			}
		}
	}

	// Token: 0x0600742F RID: 29743 RVA: 0x003144B4 File Offset: 0x003126B4
	public static void b(dtb A_0, amc A_1)
	{
		if (A_1 != null)
		{
			A_0.ad().Add(new duh(A_1, new string[]
			{
				bk9.a,
				aiw.a,
				d0f.a
			}));
		}
	}

	// Token: 0x06007430 RID: 29744 RVA: 0x003144F8 File Offset: 0x003126F8
	public static void a(amc A_0, bool A_1 = false)
	{
		if (A_0 != null)
		{
			List<els> list = new List<els>();
			list.AddRange(A_0.aa().StatusEffects.Get<b34>());
			list.AddRange(A_0.aa().StatusEffects.Get<a2>());
			list.AddRange(A_0.aa().StatusEffects.Get<e6y>());
			list.AddRange(A_0.aa().StatusEffects.Get<a3w>());
			list.AddRange(A_0.aa().StatusEffects.Get<b31>());
			if (A_1)
			{
				list.AddRange(A_0.aa().StatusEffects.Get<ata>());
			}
			foreach (els a_ in list)
			{
				A_0.aa().StatusEffects.d(a_);
			}
		}
	}

	// Token: 0x06007431 RID: 29745 RVA: 0x003145EC File Offset: 0x003127EC
	public static void a(dtb A_0, amc A_1)
	{
		if (A_1 != null)
		{
			A_0.ad().Add(new duh(A_1, new string[]
			{
				b34.c,
				a2.a,
				e6y.a,
				a3w.a,
				ata.a,
				b31.a
			}));
		}
	}

	// Token: 0x06007432 RID: 29746 RVA: 0x00314648 File Offset: 0x00312848
	public static bool d(amc A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bqi bqi = serviceOrThrow.aqu().ac().abt(A_0.aa().FactionId);
			return bqi != null && bqi.a();
		}
		return false;
	}

	// Token: 0x06007433 RID: 29747 RVA: 0x00314694 File Offset: 0x00312894
	public static els a(efk A_0, int A_1)
	{
		string text;
		return awq.a(A_0, A_1, out text);
	}

	// Token: 0x06007434 RID: 29748 RVA: 0x003146AC File Offset: 0x003128AC
	public static els a(efk A_0, int A_1, out string A_2)
	{
		if (A_0.b(d8o.e))
		{
			A_2 = "короткое замыкание";
			return new clt(A_1);
		}
		if (A_0.Feats.Contains<efa>())
		{
			A_2 = "дезориентация";
			return new eok(A_1);
		}
		A_2 = "оглушение";
		return new ab3(A_1);
	}

	// Token: 0x06007435 RID: 29749 RVA: 0x00314700 File Offset: 0x00312900
	public static void b(amc A_0, amc A_1)
	{
		if (A_0.aa().Feats.Contains<c7q>() && !A_1.aa().Passive && !A_1.aa().c(d8o.e) && cuo.a.NextDouble() < c7q.a + (double)A_0.aa().GetSpecializationValue<xu>(true) * xu.a)
		{
			if (A_1.aa().d(CharacterImmunities.Root))
			{
				etm a_ = new etm(new ap9(A_1.aa()), "обездвиживанию");
				bey.a(a_, A_0.aa(), A_1.aa(), A_1);
				a7v.a(a_);
				bmj.a(A_1.a8(), new ba0());
				return;
			}
			if (!euf.b(A_0.aa().Skills.Get<dei>().g(), A_1.aa()) && !euf.k(A_1.aa()))
			{
				A_1.aa().StatusEffects.a(new bo4(c7q.b * d0u.b), false, false, false);
				vr a_2 = new vr(new ap9(A_1.aa()), new ap9(A_0.aa()), "{0}: обездвижен.", new Color?(adi.j), null);
				bey.a(a_2, A_0.aa(), A_1.aa(), A_1);
				a7v.a(a_2);
				return;
			}
			bjq a_3 = new bjq(new ap9(A_1.aa()), new ap9(A_0.aa()), "обездвиживанию");
			bey.a(a_3, A_0.aa(), A_1.aa(), A_1);
			a7v.a(a_3);
		}
	}

	// Token: 0x06007436 RID: 29750 RVA: 0x00314898 File Offset: 0x00312A98
	public static void a(amc A_0, amc A_1)
	{
		if (A_0.aa().Feats.Contains<d2f>() && !A_1.aa().Passive)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				d4n d4n = service.ahu(A_0.aa());
				if (d4n == service.ahe())
				{
					ip ip = A_0.aa().Cooldowns.b(d2f.c);
					if (ip == null || ip.a <= 0.0)
					{
						int num = d2f.b + A_0.aa().GetSpecializationValue<dv9>(true) * dv9.a;
						d4n.c += (double)num;
						bmj.a(A_0.a8(), new d53(string.Format("+{0} очков действия", num), adi.ap, "FatalThrow", false));
						vr a_ = new vr(new ap9(A_0.aa()), null, "{0} получает " + num.ToString() + " очков действия от смертельного броска.", new Color?(adi.ap), null);
						bey.a(a_, A_0.aa(), A_0);
						a7v.a(a_);
						A_0.aa().Cooldowns.a(new cfd[]
						{
							new cfd(d2f.c, d2f.d * d0u.b, false, true)
						});
					}
				}
			}
		}
	}

	// Token: 0x06007437 RID: 29751 RVA: 0x003149E8 File Offset: 0x00312BE8
	public static bool a(b0b A_0)
	{
		if (A_0 != null)
		{
			amc aspect = A_0.GetAspect<amc>();
			if (aspect != null)
			{
				if (aspect.aa().SpecialStates.g)
				{
					return true;
				}
				ip ip = aspect.aa().Cooldowns.b(e5b.d);
				if (ip != null && ip.a > 0.0)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06007438 RID: 29752 RVA: 0x00314A54 File Offset: 0x00312C54
	public static void a(amc A_0, amc A_1, cwt A_2)
	{
		if (A_0 != null && A_1 != null && !A_0.aa().b(d8o.e) && !A_0.aa().Truesighted)
		{
			alf alf = Enumerable.FirstOrDefault<alf>(A_1.aa().StatusEffects.Get<alf>());
			if (alf != null && !euf.f(A_1.aa().Offense.ag()[PsiSchool.ThoughtControl].b(), A_0.aa()))
			{
				int num = Math.Max(1, A_2.ad.GetPrimitivePropertyValue<int>("MaxMirrorImageHits", new int?(1)).Value);
				for (int i = 0; i < num; i++)
				{
					if (alf.Stacks == 1)
					{
						A_1.aa().StatusEffects.d(alf);
						break;
					}
					alf.Stacks--;
				}
				A_2.b = false;
			}
		}
	}

	// Token: 0x06007439 RID: 29753 RVA: 0x00314B44 File Offset: 0x00312D44
	public static bool a(amc A_0, efk A_1, CharacterImmunities A_2, string A_3, bool A_4)
	{
		if (A_0 != null && A_0.aa().d(A_2))
		{
			if (A_4)
			{
				etm a_ = new etm(new ap9(A_0.aa()), A_3);
				bey.a(a_, A_1, A_0.aa(), A_0);
				a7v.a(a_);
				if (A_0.a8() != null)
				{
					bmj.a(A_0.a8(), new ba0());
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x0600743A RID: 29754 RVA: 0x00314BB4 File Offset: 0x00312DB4
	public static void c(amc A_0)
	{
		awq.a(A_0);
	}

	// Token: 0x0600743B RID: 29755 RVA: 0x00314BBC File Offset: 0x00312DBC
	public static void b(amc A_0)
	{
		awq.a(A_0);
	}

	// Token: 0x0600743C RID: 29756 RVA: 0x00314BC8 File Offset: 0x00312DC8
	public static void a(amc A_0)
	{
		if (A_0 != null && A_0.aa().Feats.Contains<a2k>())
		{
			ip ip = A_0.aa().Cooldowns.b(a2k.e);
			if (ip == null || ip.a <= 0.0)
			{
				el a_ = new el(a2k.c * d0u.b);
				A_0.aa().StatusEffects.a(a_, false, false, false);
				A_0.aa().Cooldowns.a(new cfd[]
				{
					new cfd(a2k.e, a2k.d * d0u.b, false, true)
				});
			}
		}
	}

	// Token: 0x0600743D RID: 29757 RVA: 0x00314C78 File Offset: 0x00312E78
	public static bool a(amc A_0, amc A_1, cwt A_2, cru A_3, bool A_4 = false, bool A_5 = false, bool A_6 = false)
	{
		if (A_0 == null || A_1 == null || A_2 == null || A_3 == null)
		{
			return false;
		}
		if (A_2.b && (A_5 || A_2.e) && !A_2.c.GetValueOrDefault() && (A_4 || A_0.aa().Feats.Contains<bsx>()) && A_2.z && (A_6 || A_2.x == AmmoType.Sledgehammer || A_2.x == AmmoType.Crowbar || euf.d(A_2.x)) && !A_1.aa().Passive && !A_1.aa().b(d8o.e | d8o.i | d8o.k) && !A_1.aa().d(CharacterImmunities.CriticalHits) && A_3.a != null)
		{
			int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(awq.b.a.b)), new Func<csk, int>(awq.b.a.a));
			if (num > 0 && (double)((float)num / Math.Max(1f, A_1.aa().Defense.q().zm())) > bsx.a)
			{
				e8b a_ = new e8b(bsx.a(A_0.aa()));
				A_1.aa().StatusEffects.a(a_, false, false, false);
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600743E RID: 29758 RVA: 0x00314E24 File Offset: 0x00313024
	public static void a(amc A_0, amc A_1, int A_2)
	{
		if (A_1 == null || A_1.aa() == null || A_2 <= 0)
		{
			return;
		}
		int a_ = euf.n(A_1.aa());
		ap9 a_2 = (A_0 != null) ? new ap9(A_0.aa()) : null;
		efk a_3 = (A_0 != null) ? A_0.aa() : null;
		efk efk = A_1.aa();
		if (efk.Passive || efk.b(d8o.e) || efk.d(CharacterImmunities.MindAffecting | CharacterImmunities.Fear))
		{
			etm a_4 = new etm(new ap9(efk), "страху");
			bey.a(a_4, a_3, efk, A_1);
			a7v.a(a_4);
			bmj.a(A_1.a8(), new ba0());
			return;
		}
		if (euf.f(a_, A_1.aa()))
		{
			c6f a_5 = new c6f(new ap9(A_1.aa()), a_2, "страху");
			bey.a(a_5, a_3, A_1.aa(), A_1);
			a7v.a(a_5);
			bmj.a(A_1.a8(), new dym());
			return;
		}
		double num = euf.d(a_, A_1.aa());
		int a_6 = (int)d05.b((double)d0u.b, Math.Ceiling((1.0 - num) * (double)A_2 * (double)d0u.b / (double)d0u.b) * (double)d0u.b, (double)(A_2 * d0u.b));
		A_1.aa().StatusEffects.a(new axo(a_6, A_0), false, false, false);
		vr a_7 = new vr(new ap9(A_1.aa()), a_2, "{0} паникует.", new Color?(adi.j), null);
		bey.a(a_7, a_3, A_1.aa(), A_1);
		a7v.a(a_7);
	}

	// Token: 0x0600743F RID: 29759 RVA: 0x00314FC8 File Offset: 0x003131C8
	public static void a(amc A_0, bke A_1, out string A_2, out string A_3, out string A_4, out string A_5, out float A_6, out float A_7, string A_8 = null, bool A_9 = false)
	{
		awq.a(A_0, (A_1 != null) ? new esu?(A_1.q()) : null, out A_2, out A_3, out A_4, out A_5, out A_6, out A_7, A_8, A_9);
	}

	// Token: 0x06007440 RID: 29760 RVA: 0x00315008 File Offset: 0x00313208
	public static void a(amc A_0, esu? A_1, out string A_2, out string A_3, out string A_4, out string A_5, out float A_6, out float A_7, string A_8 = null, bool A_9 = false)
	{
		ai5 a_ = A_0.b(A_9);
		if (A_1 == null)
		{
			A_2 = null;
			A_3 = null;
			A_4 = null;
			A_5 = null;
			A_6 = 0f;
			A_7 = 0f;
		}
		else
		{
			esu a_2;
			if (A_1.Value == esu.a)
			{
				a_2 = esu.a;
			}
			else
			{
				a_2 = A_1.Value + 100;
			}
			A_2 = cf0.c(a_, A_1.Value);
			A_3 = cf0.c(a_, a_2);
			A_4 = cf0.b(a_, A_1.Value);
			A_5 = cf0.b(a_, a_2);
			A_6 = cf0.a(a_, A_1.Value);
			A_7 = cf0.a(a_, a_2);
		}
		if (A_2 == null)
		{
			A_2 = A_8;
		}
	}

	// Token: 0x06007441 RID: 29761 RVA: 0x003150C4 File Offset: 0x003132C4
	private static void a(qy A_0, amc A_1, bke A_2, dus A_3)
	{
		if (A_3 != null && !string.IsNullOrEmpty(A_3.a))
		{
			bfq bfq = new bfq();
			bfq.a(bvl.b);
			bfq.c(A_3.a);
			bfq.b("weaponAttack_" + Guid.NewGuid().ToString());
			a4s item = new a4s(bfq, new ar7(A_1.a8()), null, null);
			A_0.ad().Add(item);
			if (A_3.c > 0f && A_1 != null && A_1.a8() != null && A_1.a8().Area != null)
			{
				ak1 ak = A_1.a8().Area.a(A_1.a8().aj().a());
				if (ak != null)
				{
					A_0.ad().Add(new cn9(new edx(ak), (double)A_3.c));
				}
			}
		}
	}

	// Token: 0x06007442 RID: 29762 RVA: 0x003151B8 File Offset: 0x003133B8
	private static void a(qy A_0, amc A_1, bke A_2, dus A_3, bool A_4)
	{
		if (A_4)
		{
			awq.a(A_0, A_1, A_2, A_3);
		}
	}

	// Token: 0x06007443 RID: 29763 RVA: 0x003151CC File Offset: 0x003133CC
	public static void a(amc A_0, int A_1 = 1)
	{
		if (A_0 != null && A_0.aa() != null && A_0.a6() != null && A_0.a6().Count > 0)
		{
			if (Enumerable.Any<cze>(A_0.a6(), new Func<cze, bool>(awq.b.a.a)))
			{
				dm3 dm = new dm3(5 * d0u.b);
				dm.Stacks = A_1;
				A_0.aa().StatusEffects.a(dm, false, false, false);
			}
		}
	}

	// Token: 0x06007444 RID: 29764 RVA: 0x00315264 File Offset: 0x00313464
	public static List<byte> a(bke A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		if (A_0.e() == btz.l || A_0.e() == btz.h)
		{
			return new List<byte>
			{
				5
			};
		}
		return null;
	}

	// Token: 0x06007445 RID: 29765 RVA: 0x00315298 File Offset: 0x00313498
	public static int a(int A_0, string A_1 = null)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() == null || serviceOrThrow.aqu().v() == null)
		{
			return 0;
		}
		au2 au = serviceOrThrow.aqu().v();
		bool flag = c2h.a(au);
		A_0 = serviceOrThrow.aqu().v().c(A_0);
		bool flag2 = !flag && c2h.a(au);
		a7v.a(new ey2(new ap9(au), A_0, flag2, A_1));
		if (flag2 && au.b() != null)
		{
			boj.a(au.b() as c5x, "LevelUp", 1, double.MaxValue, false, true, null, null, null, null, false);
			(au.b() as c5x).c().a("LevelUp", "LevelUp", 1f, c9z.a, false, false);
			bmj.a(au.b(), new d53("Новый уровень!", adi.c, null, true));
		}
		return A_0;
	}

	// Token: 0x02001438 RID: 5176
	private class a : ok
	{
		// Token: 0x06007446 RID: 29766 RVA: 0x003153B4 File Offset: 0x003135B4
		public a(aud A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06007447 RID: 29767 RVA: 0x003153C8 File Offset: 0x003135C8
		public bool g5(anl A_0)
		{
			ak1 ak = this.a.a(A_0.d());
			return ak != null && !ak.Formation.c(36L);
		}

		// Token: 0x04002F72 RID: 12146
		private aud a;
	}

	// Token: 0x02001439 RID: 5177
	[CompilerGenerated]
	[Serializable]
	private sealed class b
	{
		// Token: 0x0600744A RID: 29770 RVA: 0x00315418 File Offset: 0x00313618
		internal double a(a5e A_0)
		{
			return A_0.TimeLeft;
		}

		// Token: 0x0600744B RID: 29771 RVA: 0x00315420 File Offset: 0x00313620
		internal bool b(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x0600744C RID: 29772 RVA: 0x0031542C File Offset: 0x0031362C
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x0600744D RID: 29773 RVA: 0x00315438 File Offset: 0x00313638
		internal bool a(cze A_0)
		{
			cxz cxz = A_0 as cxz;
			return cxz != null && cxz.a() == "exo_attacked";
		}

		// Token: 0x04002F73 RID: 12147
		public static readonly awq.b a = new awq.b();

		// Token: 0x04002F74 RID: 12148
		public static Func<a5e, double> b;

		// Token: 0x04002F75 RID: 12149
		public static Func<csk, bool> c;

		// Token: 0x04002F76 RID: 12150
		public static Func<csk, int> d;

		// Token: 0x04002F77 RID: 12151
		public static Func<cze, bool> e;
	}
}
