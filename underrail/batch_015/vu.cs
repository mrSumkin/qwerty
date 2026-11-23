using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001426 RID: 5158
[eiz("A55")]
[Serializable]
public sealed class vu : bvd
{
	// Token: 0x060073A2 RID: 29602 RVA: 0x0030C0DC File Offset: 0x0030A2DC
	private vu(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("A55:I", typeof(enp)) as enp);
	}

	// Token: 0x060073A3 RID: 29603 RVA: 0x0030C104 File Offset: 0x0030A304
	public void a(SerializationInfo A_0, StreamingContext A_1)
	{
		A_0.AddValue("A55:I", this.a);
	}

	// Token: 0x060073A4 RID: 29604 RVA: 0x0030C118 File Offset: 0x0030A318
	public vu(enp A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060073A5 RID: 29605 RVA: 0x0030C128 File Offset: 0x0030A328
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		this.mm(A_0, A_1, A_2, A_3, new bps());
	}

	// Token: 0x060073A6 RID: 29606 RVA: 0x0030C13C File Offset: 0x0030A33C
	public void mm(amc A_0, amc A_1, cwt A_2, cru A_3, bps A_4)
	{
		if (A_4 == null)
		{
			A_4 = new bps();
		}
		d02 service = bpo.GetService<d02>();
		if (A_1 != null && A_1.a8() != null && A_1.a8().Zone != null)
		{
			d2v a_ = new d2v(A_2, new EntityAspectReference<amc, amc>(A_0), new EntityAspectReference<amc, amc>(A_1), A_3);
			A_1.a8().Zone.ActionManager.g9(a_, atp.a);
			dz6.a(a_);
			if (A_0 != null && A_0.a8() != null)
			{
				cd1 cd = A_2.ai ?? A_0.aa().Offense.u();
				int num;
				if (A_3 == null || A_3.a == null)
				{
					num = 0;
				}
				else
				{
					num = Enumerable.Sum<csk>(A_3.a, new Func<csk, int>(vu.a.a.i));
				}
				int num2 = num;
				cp7 cp = Enumerable.FirstOrDefault<cp7>(A_0.aa().StatusEffects.Get<cp7>());
				if (cp != null && A_2.ai == null && cd.TypedDefinition.e() == btz.d && A_3.c && service != null)
				{
					d4n d4n = service.ahu(A_0.aa());
					if (d4n != null && service.ahe() == d4n)
					{
						int num3 = A_0.aa().Offense.av();
						if (cp.Stacks > 1)
						{
							cp7 cp2 = cp;
							int num4 = cp2.Stacks;
							cp2.Stacks = num4 - 1;
						}
						else
						{
							A_0.aa().StatusEffects.d(cp);
						}
						bz5 microfeat = A_0.aa().GetMicrofeat<bz5>();
						if (microfeat != null)
						{
							num3 = Math.Max(0, Convert.ToInt32((double)num3 * (1.0 + microfeat.a())));
						}
						if (num3 > 0)
						{
							d4n.c += (double)num3;
							bmj.a(A_0.a8(), new d53(string.Format("+{0} ед. действия{1}", num3, (num3 > 1) ? "" : ""), adi.ap, "xpbl_Abilities.25", false));
							vr a_2 = new vr(new ap9(A_0.aa()), null, string.Concat(new string[]
							{
								"{0} восстановлено ",
								num3.ToString(),
								" ед. действия",
								(num3 > 1) ? "" : "",
								" после Весёлой стрельбы."
							}), new Color?(adi.ao), null);
							bey.a(a_2, A_0.aa(), A_0);
							a7v.a(a_2);
						}
					}
				}
				if (A_1.aa().Dead && A_0.aa().Vehicle == null && A_0.aa().Feats.Contains<bjg>() && !A_4.b("hit_and_run") && service != null)
				{
					d4n d4n2 = service.ahu(A_0.aa());
					if (d4n2 != null && service.ahe() == d4n2)
					{
						bm1 bm = Enumerable.FirstOrDefault<bm1>(A_0.aa().StatusEffects.Get<bm1>());
						int num5 = bjg.a(A_0.aa(), (bm != null) ? bm.Stacks : 0);
						if (d4n2.d < (double)A_0.aa().Offense.m() && d4n2.d < (double)num5)
						{
							int num6 = Math.Min(A_0.aa().Offense.m(), num5) - (int)d4n2.d;
							d4n2.d = (double)Math.Min(A_0.aa().Offense.m(), num5);
							if (num6 >= 1)
							{
								A_4.a("hit_and_run");
								bmj.a(A_0.a8(), new d53(string.Format("+{0} ед. передвижения{1}", num6, (num6 > 1) ? "" : ""), adi.ao, "HitAndRun", false));
								vr a_3 = new vr(new ap9(A_0.aa()), null, string.Concat(new string[]
								{
									"{0} восстановлено ",
									num6.ToString(),
									" ед. передвижения",
									(num6 > 1) ? "" : "",
									" благодаря тактике «бей и беги»."
								}), new Color?(adi.ao), null);
								bey.a(a_3, A_0.aa(), A_0);
								a7v.a(a_3);
								A_0.aa().StatusEffects.a(new bm1(), false, false, false);
							}
						}
					}
				}
				if (A_3.c && A_0.aa().Feats.Contains<elj>() && cd.TypedDefinition.e() == btz.d && !A_4.b("shooting_spree_aimedshot_cooldown_triggered"))
				{
					A_4.a("shooting_spree_aimedshot_cooldown_triggered");
					ip ip = A_0.aa().Cooldowns.b(e77.a);
					if (ip != null)
					{
						ip.a -= (double)(d0u.b * elj.a);
					}
					ip ip2 = A_0.aa().Cooldowns.b(bcq.a);
					if (ip2 != null)
					{
						ip2.a -= (double)d0u.b;
					}
				}
				if (A_2.b && A_2.ad.GetPrimitivePropertyValue<bool>("CanTriggerConcentratedFire", new bool?(false)).Value && A_0.aa().Feats.Contains<c12>() && !A_4.b("concentrated_fire"))
				{
					A_4.a("concentrated_fire");
					int num7 = A_0.aa().GetSpecializationValue<enf>(true);
					eh4 microfeat2 = A_0.aa().GetMicrofeat<eh4>();
					if (microfeat2 != null)
					{
						num7 += microfeat2.a();
					}
					A_1.aa().StatusEffects.a(new b3i(num7), false, false, false);
				}
				if (A_2.b && A_2.z && A_0.aa().Vehicle == null && A_0.aa().Feats.Contains<ebd>() && !A_4.b("fancy_footwork") && service != null)
				{
					d4n d4n3 = service.ahu(A_0.aa());
					if (d4n3 != null)
					{
						A_4.a("fancy_footwork");
						double num8 = 1.0 - Math.Max(0.0, A_0.aa().Defense.aj() - ebd.c);
						int num9 = (int)Math.Max((double)ebd.b, num8 * ((double)ebd.a + (double)A_0.aa().GetSpecializationValue<ks>(true) * ks.a));
						ey6 ey = Enumerable.FirstOrDefault<ey6>(A_0.aa().StatusEffects.Get<ey6>());
						if (ey != null)
						{
							num9 -= ey.Stacks;
						}
						if (num9 > 0)
						{
							int num10 = (int)Math.Min((double)num9, (double)(A_0.aa().Offense.m() * 2) - d4n3.d);
							d4n3.d = Math.Min(d4n3.d + (double)num10, (double)(A_0.aa().Offense.m() * 2));
							bmj.a(A_0.a8(), new d53(string.Format("+{0} ед. передвижения{1}", num10, (num10 > 1) ? "" : ""), adi.ao, "FancyFootwork", false));
							vr a_4 = new vr(new ap9(A_0.aa()), null, string.Concat(new string[]
							{
								"{0} получает ",
								num10.ToString(),
								" ед. передвижения",
								(num10 > 1) ? "" : "",
								", работая ногами."
							}), new Color?(adi.ao), null);
							bey.a(a_4, A_0.aa(), A_0);
							a7v.a(a_4);
							if (num10 > 0)
							{
								A_0.aa().StatusEffects.a(new ey6(), false, false, false);
							}
						}
					}
				}
				if (!A_4.b("bone_breaker") && awq.a(A_0, A_1, A_2, A_3, false, false, false))
				{
					A_4.a("bone_breaker");
				}
				if (A_2.b && !A_2.c.GetValueOrDefault() && A_0.aa().Feats.Contains<emq>() && A_2.z && !A_4.b("cheap_shots") && euf.a(emq.b + (double)A_0.aa().GetSpecializationValue<a3l>(true) * a3l.a) && A_3.a != null)
				{
					if (Enumerable.Sum<csk>(A_3.a, new Func<csk, int>(vu.a.a.c)) > 0 && !A_1.aa().Passive && !A_1.aa().b(d8o.e) && !A_1.aa().d(CharacterImmunities.Incapacitation))
					{
						A_4.a("cheap_shots");
						cjy a_5 = new cjy(emq.c * d0u.b);
						A_1.aa().StatusEffects.a(a_5, false, false, false);
						if (A_1.a8() != null && A_1.a8().t.b != null)
						{
							A_1.a8().t.b.ah();
						}
						if (A_0.aa() is e3q && !(A_1.aa() is e3q))
						{
							cxc.a(eyy.b0);
						}
					}
				}
				foreach (epk epk in A_0.aa().GetMicrofeats<epk>())
				{
					if (euf.a(epk.a()))
					{
						awq.a(A_0, A_1, epk.b(), false, true);
					}
				}
				if (A_2.z)
				{
					foreach (cvl cvl in A_0.aa().GetMicrofeats<cvl>())
					{
						if (euf.a(cvl.a()))
						{
							awq.a(A_0, A_0, cvl.b(), true, true);
						}
					}
				}
				if (!A_1.aa().Passive && A_3 != null && A_3.c && A_2 != null && A_2.ae != null && (euf.a(A_2.ae.Value, WeaponAggregateSubtype.LMG) || euf.a(A_2.ae.Value, WeaponAggregateSubtype.Minigun)) && A_0.aa().Feats.Contains<ap6>() && !A_4.b("bullet_trance"))
				{
					A_4.a("bullet_trance");
					crt a_6 = new crt(ap6.b(A_0.aa()), ap6.c(A_0.aa()), ap6.a(A_0.aa()));
					A_0.aa().StatusEffects.a(a_6, false, false, false);
				}
				if (A_2.b && !A_2.c.GetValueOrDefault() && A_0.aa().Feats.Contains<aq0>() && A_2.z && !A_4.b("taste_for_blood"))
				{
					List<a5e> list = A_1.aa().StatusEffects.Get<a5e>();
					int num11 = 0;
					if (list.Count > 0)
					{
						num11 = list.Count;
					}
					else if (A_3 != null && A_3.c && !A_1.aa().Passive && !A_1.aa().c(d8o.e))
					{
						num11 = 1;
					}
					if (num11 > 0)
					{
						A_4.a("taste_for_blood");
						ezn microfeat3 = A_0.aa().GetMicrofeat<ezn>();
						if (microfeat3 != null && cuo.a.NextDouble() < microfeat3.a())
						{
							num11++;
						}
						dd dd = new dd(aq0.c * d0u.b);
						dd.Stacks = num11;
						A_0.aa().StatusEffects.a(dd, false, false, false);
					}
				}
				if (A_2.b && !A_2.c.GetValueOrDefault() && !A_1.aa().Dead && !A_1.aa().b(d8o.e) && !A_1.aa().Passive && A_0.aa().Feats.Contains<q3>() && euf.d(A_2.x) && !A_4.b("wrestling") && cuo.a.NextDouble() < q3.a + (double)A_0.aa().GetSpecializationValue<aai>(true) * aai.a)
				{
					s1 a_7 = new s1(d0u.b * 2, "Status.Wrestled");
					A_1.aa().StatusEffects.a(a_7, false, false, false);
					A_4.a("wrestling");
				}
				bool flag = false;
				ho ho = Enumerable.FirstOrDefault<ho>(A_0.aa().StatusEffects.Get<ho>());
				if (ho != null && !A_4.b("combo") && A_2.k != "armor")
				{
					if (A_0.aa().Feats.Contains<egq>() && euf.d(A_2.x))
					{
						if (A_2.b && num2 > 0)
						{
							if (ho.TargetId == A_1.a8().qe())
							{
								if (ho.Stacks == egq.b)
								{
									A_4.a("combo");
									A_0.aa().StatusEffects.d(ho);
									flag = true;
									if (cuo.a.NextDouble() < egq.c + (double)A_0.aa().GetSpecializationValue<c4u>(true) * c4u.a)
									{
										awq.b(A_0, A_1, egq.d * d0u.b, false);
									}
								}
							}
							else
							{
								A_0.aa().StatusEffects.d(ho);
							}
						}
						else
						{
							A_0.aa().StatusEffects.d(ho);
						}
					}
					else
					{
						A_0.aa().StatusEffects.d(ho);
					}
				}
				if (!flag && A_2.b && num2 > 0 && !A_1.aa().Dead && A_0.aa().Feats.Contains<egq>() && euf.d(A_2.x) && !A_4.b("combo"))
				{
					A_4.a("combo");
					ho a_8 = new ho(A_1.a8().qe());
					A_0.aa().StatusEffects.a(a_8, false, false, false);
				}
				if ((euf.n(cd) || euf.o(cd)) && A_2.b && !A_1.aa().Dead && A_0.aa().StatusEffects.a(c54.a) && A_0.aa().i(new e5o().a(new eoj(A_0.aa(), null, null))))
				{
					A_0.aa().Offense.a1().j(new e5o().a(new eoj(A_0.aa(), null, null)));
					qy qy = new qy();
					qy.b(false);
					qy.c(false);
					List<auv> list2 = qy.ad();
					c5x a_9 = A_1.a8();
					string a_10 = "Psi";
					int a_11 = 1;
					double maxValue = double.MaxValue;
					bool a_12 = true;
					bool a_13 = true;
					float? a_14 = dz6.b();
					list2.Add(new a7j(a_9, a_10, a_11, maxValue, a_12, a_13, null, null, null, a_14, false, null));
					qy.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "ForceEmissionHit"), null, new ar7(A_1.a8()), null));
					qy.ad().Add(new akg(A_0, A_1, this.a(A_0, A_2), new b7x(null), false));
					A_0.a8().Zone.ActionManager.g9(qy, atp.a);
					dz6.a(qy);
					if (egy.a(A_0.a8(), A_1.a8()))
					{
						eg2 eg = egy.a(A_0.a8());
						egy.a(eg);
						eg.b();
						b0b b0b = null;
						dvv item = es2.a(eg.a8(), A_1.a8(), "psi", 0.5f, null, out b0b, false, 0.5f);
						qy qy2 = new qy();
						qy2.ad().Add(new bm3(dz6.b(200)));
						qy2.ad().Add(item);
						List<auv> list3 = qy2.ad();
						c5x a_15 = A_1.a8();
						string a_16 = "Psi";
						int a_17 = 1;
						double maxValue2 = double.MaxValue;
						bool a_18 = true;
						bool a_19 = true;
						a_14 = dz6.b();
						list3.Add(new a7j(a_15, a_16, a_17, maxValue2, a_18, a_19, null, null, null, a_14, false, null));
						qy2.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "ForceEmissionHit"), null, new ar7(A_1.a8()), null));
						qy2.ad().Add(new akg(A_0, A_1, this.a(A_0, A_2), new b7x(null), false));
						qy2.ad().Add(new c7(b0b, false, false, true, false));
						b0b.Zone.ActionManager.g9(qy2, atp.a);
						dz6.a(qy2);
					}
				}
				if (A_2.b && !A_2.c.GetValueOrDefault() && cd.TypedDefinition.e() == btz.f && A_0.aa().Feats.Contains<bo8>() && !A_1.aa().b(d8o.e) && !A_1.aa().Passive && !A_1.aa().Dead && A_3.a != null)
				{
					if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(vu.a.a.e)), new Func<csk, int>(vu.a.a.g)) > 0 && cuo.a.NextDouble() < bo8.a + (double)A_0.aa().GetSpecializationValue<cxr>(true) * cxr.a)
					{
						if (!A_1.aa().d(CharacterImmunities.Daze))
						{
							A_1.aa().StatusEffects.a(new eok(bo8.b * d0u.b), false, false, false);
							vr a_20 = new vr(new ap9(A_1.aa()), new ap9(A_0.aa()), "{0}: дезориентация.", new Color?(adi.j), null);
							bey.a(a_20, A_0.aa(), A_1.aa(), A_1);
							a7v.a(a_20);
						}
						else
						{
							etm a_21 = new etm(new ap9(A_1.aa()), "дезориентации");
							bey.a(a_21, A_0.aa(), A_1.aa(), A_1);
							a7v.a(a_21);
							bmj.a(A_1.a8(), new ba0());
						}
					}
				}
				if (service != null && A_3.c && cd.TypedDefinition.e() == btz.g && A_0.aa().Feats.Contains<avq>() && !A_4.b("brutality") && A_1 != null && A_1.a8() != null && !A_1.aa().Passive)
				{
					A_4.a("brutality");
					foreach (d4n d4n4 in service.ahl())
					{
						if (d4n4.b != null && !(d4n4.b.aa() is e3q) && d4n4.b.a8() != null && d4n4.b != A_0 && d4n4.b.a(A_0) == h.a)
						{
							efk efk = d4n4.b.aa();
							bm6 b = d4n4.b.a8().t.b;
							if (b != null && b.b(A_1, false))
							{
								double num12 = avq.a + (double)A_0.aa().GetSpecializationValue<b78>(true) * b78.a;
								clu microfeat4 = A_0.aa().GetMicrofeat<clu>();
								if (microfeat4 != null && microfeat4.a() != 0.0)
								{
									num12 += microfeat4.a();
								}
								if (cuo.a.NextDouble() < num12 && !efk.Passive && !efk.b(d8o.e) && !efk.d(CharacterImmunities.MindAffecting | CharacterImmunities.Fear))
								{
									if (euf.f(A_0.aa().Skills.Get<bec>().g(), efk))
									{
										c6f a_22 = new c6f(new ap9(d4n4.b.a8().h.b.aa()), new ap9(A_0.aa()), "страху");
										bey.a(a_22, A_0.aa(), efk, d4n4.b);
										a7v.a(a_22);
										bmj.a(d4n4.b.a8(), new dym());
									}
									else
									{
										axo a_23 = new axo(avq.b * d0u.b, new ar7(A_0.a8()));
										efk.StatusEffects.a(a_23, false, false, false);
									}
								}
							}
						}
					}
				}
				if (A_2.b && !A_3.c && A_3.a != null && A_0.aa().Gear.e().Item != null && A_2.x >= AmmoType.Vial_Acid && A_2.x <= AmmoType.Vial_Incendiary && Enumerable.Any<cfx>(Enumerable.OfType<cfx>(A_0.aa().Gear.e().Item.fu().ar())) && !A_4.b("chemical_destabilization"))
				{
					if (Enumerable.Sum<csk>(A_3.a, new Func<csk, int>(vu.a.a.f)) > 0)
					{
						AmmoType x = A_2.x;
						DamageType a_24;
						if (x - AmmoType.Vial_Acid_Regular > 2)
						{
							if (x == AmmoType.Vial_Cryogel)
							{
								a_24 = DamageType.Cold;
								goto IL_17A2;
							}
							if (x == AmmoType.Vial_Incendiary)
							{
								a_24 = DamageType.Heat;
								goto IL_17A2;
							}
						}
						a_24 = DamageType.Acid;
						IL_17A2:
						r9 a_25 = new r9(a_24);
						A_1.aa().StatusEffects.a(a_25, false, false, false);
						A_4.a("chemical_destabilization");
					}
				}
				if (A_0.aa().Feats.Contains<e8>() && euf.g(cd) && !A_4.b("onslaught"))
				{
					int num13 = 0;
					if (A_3 != null && A_3.a != null)
					{
						num13 = Enumerable.Sum<csk>(A_3.a, new Func<csk, int>(vu.a.a.h));
					}
					if (A_2.b && num13 > 0)
					{
						if (A_1 != null && !A_1.aa().Passive)
						{
							dqq a_26 = new dqq();
							A_0.aa().StatusEffects.a(a_26, false, false, false);
						}
					}
					else
					{
						dqq dqq = Enumerable.FirstOrDefault<dqq>(A_0.aa().StatusEffects.Get<dqq>());
						if (dqq != null)
						{
							A_0.aa().StatusEffects.d(dqq);
						}
					}
					A_4.a("onslaught");
				}
				if (A_0.aa().Feats.Contains<alo>() && euf.o(cd) && !A_1.aa().b(d8o.e) && !A_1.aa().Passive && !A_4.b("improved_unarmed_combat") && A_3.a != null)
				{
					if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(vu.a.a.d)), new Func<csk, int>(vu.a.a.b)) > 0)
					{
						A_4.a("improved_unarmed_combat");
						bool flag2 = false;
						if (A_0.aa().Feats.Contains<bfn>() && cuo.a.NextDouble() < bfn.b)
						{
							awq.b(A_0, A_1, bfn.c * d0u.b, false);
							flag2 = true;
						}
						if (!flag2)
						{
							double num14 = alo.b + (double)A_0.aa().GetSpecializationValue<sx>(true) * sx.a;
							if (cuo.a.NextDouble() < num14)
							{
								if (!A_1.aa().d(CharacterImmunities.Daze))
								{
									A_1.aa().StatusEffects.a(new eok(alo.c * d0u.b), false, false, false);
									vr a_27 = new vr(new ap9(A_1.aa()), new ap9(A_0.aa()), "{0}: дезориентация.", new Color?(adi.j), null);
									bey.a(a_27, A_0.aa(), A_1.aa(), A_1);
									a7v.a(a_27);
								}
								else
								{
									etm a_28 = new etm(new ap9(A_1.aa()), "дезориентации");
									bey.a(a_28, A_0.aa(), A_1.aa(), A_1);
									a7v.a(a_28);
									bmj.a(A_1.a8(), new ba0());
								}
							}
						}
					}
				}
				if (A_2.b && A_0.aa().Feats.Contains<cm6>() && euf.b(A_0.aa()) > 0 && euf.b(cd.TypedDefinition) && !A_1.aa().Passive && !A_4.b("boarding_up"))
				{
					A_4.a("boarding_up");
					ddo a_29 = new ddo(cm6.c * d0u.b);
					A_0.aa().StatusEffects.a(a_29, false, false, false);
				}
				if (num2 > 0 && A_2.b && A_1 != null && !A_1.aa().Passive && A_0.aa().Feats.Contains<baj>() && (euf.b(A_2.ae) || euf.a(A_2.ae)) && !A_4.b("gunners_high"))
				{
					A_4.a("gunners_high");
					ebf a_30 = new ebf(baj.b(A_0.aa()), 1, baj.a(A_0.aa()), baj.c(A_0.aa()));
					A_0.aa().StatusEffects.a(a_30, false, false, false);
				}
			}
			if (A_0 != null && A_0.aa() is e3q && A_3.a != null && A_3.a.Count > 0)
			{
				if (Enumerable.Sum<csk>(A_3.a, new Func<csk, int>(vu.a.a.a)) >= 500)
				{
					cxc.c(eyy.aq);
				}
			}
		}
		if (this.a != null)
		{
			bvd bvd = this.a as bvd;
			if (bvd != null)
			{
				bvd.mm(A_0, A_1, A_2, A_3, A_4);
				return;
			}
			this.a.af(A_0, A_1, A_2, A_3);
		}
	}

	// Token: 0x060073A7 RID: 29607 RVA: 0x0030DE60 File Offset: 0x0030C060
	private cwt a(amc A_0, cwt A_1)
	{
		return new cwt
		{
			i = A_1.i,
			j = A_1.j,
			f = 
			{
				euf.a(e5o.a(A_0.aa()), 1.0)
			},
			v = "эмиссия силы",
			b = true,
			h = ImpactSpeed.Low,
			z = true,
			af = A_1.af,
			w = true
		};
	}

	// Token: 0x04002F3A RID: 12090
	private enp a;

	// Token: 0x02001427 RID: 5159
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060073AA RID: 29610 RVA: 0x0030DEF8 File Offset: 0x0030C0F8
		internal int i(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x060073AB RID: 29611 RVA: 0x0030DF04 File Offset: 0x0030C104
		internal int c(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x060073AC RID: 29612 RVA: 0x0030DF10 File Offset: 0x0030C110
		internal bool e(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x060073AD RID: 29613 RVA: 0x0030DF1C File Offset: 0x0030C11C
		internal int g(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x060073AE RID: 29614 RVA: 0x0030DF28 File Offset: 0x0030C128
		internal int f(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x060073AF RID: 29615 RVA: 0x0030DF34 File Offset: 0x0030C134
		internal int h(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x060073B0 RID: 29616 RVA: 0x0030DF40 File Offset: 0x0030C140
		internal bool d(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x060073B1 RID: 29617 RVA: 0x0030DF4C File Offset: 0x0030C14C
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x060073B2 RID: 29618 RVA: 0x0030DF58 File Offset: 0x0030C158
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002F3B RID: 12091
		public static readonly vu.a a = new vu.a();

		// Token: 0x04002F3C RID: 12092
		public static Func<csk, int> b;

		// Token: 0x04002F3D RID: 12093
		public static Func<csk, int> c;

		// Token: 0x04002F3E RID: 12094
		public static Func<csk, bool> d;

		// Token: 0x04002F3F RID: 12095
		public static Func<csk, int> e;

		// Token: 0x04002F40 RID: 12096
		public static Func<csk, int> f;

		// Token: 0x04002F41 RID: 12097
		public static Func<csk, int> g;

		// Token: 0x04002F42 RID: 12098
		public static Func<csk, bool> h;

		// Token: 0x04002F43 RID: 12099
		public static Func<csk, int> i;

		// Token: 0x04002F44 RID: 12100
		public static Func<csk, int> j;
	}
}
