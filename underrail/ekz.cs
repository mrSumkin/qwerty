using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules;

// Token: 0x0200141E RID: 5150
[bs6("ZombieMutationAction")]
[eiz("ZMA")]
[Serializable]
public sealed class ekz : bhv, ISerializable
{
	// Token: 0x0600738A RID: 29578 RVA: 0x0030AF7C File Offset: 0x0030917C
	private ekz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600738B RID: 29579 RVA: 0x0030AF88 File Offset: 0x00309188
	public ekz()
	{
	}

	// Token: 0x0600738C RID: 29580 RVA: 0x0030AF90 File Offset: 0x00309190
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.x0().a() != null && base.x2() != null && base.x2().a8() != null)
		{
			ak1 ak = base.x2().a8().Area.a(base.x2().a8().aj().a());
			if (base.x2().a8().i.b != null)
			{
				base.x2().a8().i.b.a(true, false);
			}
			if (base.x2().aa().Vehicle != null)
			{
				base.x2().aa().a(null, null, false);
				return dc4.c;
			}
			c5x c5x = null;
			if (base.x2().am() == "dog")
			{
				c5x = vq.a("creatures\\mutatedDog", base.x2().a8().Zone, new bt4(base.x2().a8().Area.y8(), base.x2().a8().Location), false);
				if (c5x != null)
				{
					c5x.VisualDirection = base.x2().a8().VisualDirection;
					c5x.h.b.aa().FactionId = asp.@as;
					if (base.x2().a8().y8() != "Dog")
					{
						c5x.q(base.x2().a8().y8());
						c5x.h.b.aa().Name = base.x2().a8().y8();
					}
					if (base.x2().a8().x.b != null)
					{
						dqv dqv = new dqv(c5x);
						dqv.a(base.x2().a8().x.b.a());
						c5x.SetAspect<dqv>(dqv);
					}
					base.x2().a8().w();
					base.x2().a8().an();
				}
			}
			else if (base.x2().aa().c(d8o.b))
			{
				e3q e3q = base.x2().aa() as e3q;
				if (e3q != null)
				{
					ps service = bpo.GetService<ps>();
					if (service != null)
					{
						service.al7();
						service.al2();
					}
					c5x = base.x2().a8();
					dcw dcw = new dcw();
					ke.a(base.x2().aa(), dcw, true, false);
					foreach (coh a_ in dcw.z2())
					{
						base.x2().aa().Bag.z3(a_, true);
					}
					foreach (ai8 ai in Enumerable.ToList<ai8>(e3q.Feats))
					{
						if (!ai.IsAvailableToMutant)
						{
							e3q.Feats.b(ai.GetType());
						}
					}
					if (e3q.Feats.Contains<er5>())
					{
						e3q.Feats.d(typeof(er5));
					}
					e3q.SpecialAttacks.a(dgk.Get<c91>());
					base.x2().aa().AttributesBase |= d8o.t;
					base.x2().aa().Portrait = "plmut";
					base.x2().a("plmut");
					base.x2().a8().Size = new Vector3(1f, 1f, 1.85f);
					base.x2().aa().CustomProperties[ddm.a] = base.x2().am();
					base.x2().aa().CustomProperties["DisableGearChanges"] = true;
					if (base.x2().aa().Offense.ai != null)
					{
						base.x2().aa().Offense.ai = new string[base.x2().aa().Offense.ai.Length];
					}
					c5x c5x2 = vq.a("creatures\\mutatedHuman", false);
					if (c5x2 != null)
					{
						amc aspect = c5x2.GetAspect<amc>();
						if (aspect != null)
						{
							base.x2().a6().Add(new dxl());
							base.x2().aa().BaseAbilities.Get<d3m>().a(aspect.aa().BaseAbilities.Get<d3m>().f());
							base.x2().aa().BaseAbilities.Get<cwu>().a(aspect.aa().BaseAbilities.Get<cwu>().f());
							base.x2().aa().BaseAbilities.Get<dqg>().a(aspect.aa().BaseAbilities.Get<dqg>().f());
							base.x2().aa().BaseAbilities.Get<axa>().a(aspect.aa().BaseAbilities.Get<axa>().f());
							base.x2().aa().BaseAbilities.Get<eav>().a(aspect.aa().BaseAbilities.Get<eav>().f());
							base.x2().aa().BaseAbilities.Get<axr>().a(aspect.aa().BaseAbilities.Get<axr>().f());
							base.x2().aa().BaseAbilities.Get<av8>().a(aspect.aa().BaseAbilities.Get<av8>().f());
							base.x2().aa().BaseMovementSpeed = aspect.aa().BaseMovementSpeed;
							base.x2().aa().Skills.Get<jk>().a(Math.Max(aspect.aa().Skills.Get<jk>().f(), base.x2().aa().Skills.Get<jk>().f()));
							base.x2().aa().Skills.Get<bec>().a(Math.Max(aspect.aa().Skills.Get<bec>().f() + 10, base.x2().aa().Skills.Get<bec>().f()));
							base.x2().aa().PsiAbilities.b();
							base.x2().aa().Feats.b(typeof(c3v));
							if (!base.x2().aa().SpecialAbilities.a(typeof(cv5)))
							{
								base.x2().aa().SpecialAbilities.b(dgk.Get<cv5>());
							}
							base.x2().aa().SpecialAbilities.b(dgk.Get<bdk>());
							a9l.a(base.x2().aa());
							a9l.b(base.x2().aa());
							c8d c8d = aspect.aa().Gear.l().Item.fy() as c8d;
							c8d.Definition.g("Мутировавшее тело");
							c8d.Definition.i("В том чтобы быть отвратительным огромным мутантом есть свои плюсы.");
							c8d.Definition.f("Armors.47");
							base.x2().aa().Gear.l().a(c8d, true);
						}
					}
					cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
					if (serviceOrThrow.aqu() != null)
					{
						bv9 bv = serviceOrThrow.aqu().ac() as bv9;
						foreach (string a_2 in Enumerable.Where<string>(bv.abr().Keys, new Func<string, bool>(ekz.a.a.a)))
						{
							bv.a(asp.a, a_2, h.a, null, true, false, false);
						}
						foreach (eza eza in Enumerable.ToList<eza>(serviceOrThrow.aqu().t().c()))
						{
							serviceOrThrow.aqz().atd(eza.Value.Name, true);
						}
						if (dk2.f())
						{
							serviceOrThrow.aqz().atb("xpbl_playerMutated", true);
						}
						serviceOrThrow.aqu().r()[qu.a] = true;
					}
				}
				else
				{
					bu6 serviceOrThrow2 = bpo.GetServiceOrThrow<bu6>();
					double num;
					if (serviceOrThrow2.aq2() == GameDifficulty.Dominating)
					{
						num = 0.8;
					}
					else if (serviceOrThrow2.aq2() == GameDifficulty.Hard)
					{
						num = 0.6;
					}
					else if (serviceOrThrow2.aq2() == GameDifficulty.Normal)
					{
						num = 0.4;
					}
					else
					{
						num = 0.2;
					}
					if (cuo.a.NextDouble() < num)
					{
						c5x = vq.a("creature\\critters\\hunchbackmutant" + cuo.a.Next(1, 4).ToString(), base.x2().a8().Zone, new bt4(base.x2().a8().Area.y8(), base.x2().a8().Location), false);
					}
					else
					{
						c5x = vq.a("creatures\\mutatedHuman", base.x2().a8().Zone, new bt4(base.x2().a8().Area.y8(), base.x2().a8().Location), false);
						if (c5x != null)
						{
							c5x.h.b.a("mutated_human" + cuo.a.Next(1, 4).ToString());
						}
					}
					if (c5x != null)
					{
						c5x.VisualDirection = base.x2().a8().VisualDirection;
						c5x.h.b.aa().FactionId = asp.@as;
						c5x.q(base.x2().a8().y8());
						c5x.h.b.aa().Name = base.x2().a8().y8();
						ke.a(base.x2().aa(), c5x.h.b.aa().Bag, true, false);
						if (base.x2().a8().x.b != null)
						{
							dqv dqv2 = new dqv(c5x);
							dqv2.a(base.x2().a8().x.b.a());
							c5x.SetAspect<dqv>(dqv2);
						}
						base.x2().a8().w();
						base.x2().a8().an();
					}
				}
			}
			if (c5x != null)
			{
				c5x.c().a("AcidFizz");
				c5x a_3 = c5x;
				string a_4 = "AcidSplash";
				int a_5 = 1;
				double maxValue = double.MaxValue;
				bool a_6 = true;
				bool a_7 = true;
				float? a_8 = dz6.b();
				boj.a(a_3, a_4, a_5, maxValue, a_6, a_7, null, null, null, a_8, false);
			}
			if (ak != null)
			{
				new dku(new edx(ak), null, false, true, false).ym(null, null, null);
			}
		}
		return dc4.c;
	}

	// Token: 0x0200141F RID: 5151
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600738F RID: 29583 RVA: 0x0030BBC8 File Offset: 0x00309DC8
		internal bool a(string A_0)
		{
			return A_0 != asp.a2 && A_0 != asp.a && A_0 != asp.d && A_0 != asp.d5 && A_0 != asp.gm && A_0 != asp.gn && A_0 != asp.gl && A_0 != asp.du && A_0 != asp.fm;
		}

		// Token: 0x04002F38 RID: 12088
		public static readonly ekz.a a = new ekz.a();

		// Token: 0x04002F39 RID: 12089
		public static Func<string, bool> b;
	}
}
