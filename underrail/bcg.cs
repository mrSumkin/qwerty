using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000A69 RID: 2665
[eiz("RTJ")]
[Serializable]
public sealed class bcg : cze, ISerializable
{
	// Token: 0x06003EEE RID: 16110 RVA: 0x0017C6D8 File Offset: 0x0017A8D8
	private bcg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003EEF RID: 16111 RVA: 0x0017C6E4 File Offset: 0x0017A8E4
	public bcg()
	{
	}

	// Token: 0x06003EF0 RID: 16112 RVA: 0x0017C6F0 File Offset: 0x0017A8F0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		int num = (int)A_2["tickCount"];
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_1 != null)
		{
			d60 d = A_1.a();
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_TchortDefeated", new bool?(false)).Value;
			int value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("global_tchortRegenTanksDestroyed", new int?(0)).Value;
			bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_dc_tchb_tentacleTrueDeathTime", new bool?(false)).Value;
			if (!value && value2 < 4)
			{
				int a_ = (4 - value2) * 50;
				if (d != null)
				{
					foreach (b0b b0b in d.ab4(new string[]
					{
						"primeTentacle",
						"tchort"
					}))
					{
						c5x c5x = (c5x)b0b;
						if (c5x.h.b != null && !c5x.h.b.aa().Dead)
						{
							c5x.h.b.aa().Defense.a(a_, null, null, true, false, false, null);
						}
					}
				}
			}
			if (num > 25 && num % 3 == 0 && d != null && !value && serviceOrThrow.aqu().v() != null && !value3)
			{
				c5x c5x2 = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"tchort"
				})) as c5x;
				if (c5x2 != null && c5x2.h.b != null && !c5x2.h.b.aa().Dead)
				{
					c5x c5x3 = serviceOrThrow.aqu().v().b() as c5x;
					if (c5x3 != null && c5x3.h.b != null && !c5x3.h.b.aa().IsInCombat)
					{
						ps serviceOrThrow2 = bpo.GetServiceOrThrow<ps>();
						int num2 = c5x2.h.b.aa().Skills.Get<dql>().f();
						float num3 = Math.Min(1f, 0.3f + 0.7f * ((float)num2 / 100f));
						int a_2 = 250 + (int)(250f * num3);
						serviceOrThrow2.ane(a_2, null, null, null, null, null);
						c5x3.c().a("tchortHeartbeat", "TchortHeartbeat", num3, c9z.a, false, false);
						dql dql = c5x2.h.b.aa().Skills.Get<dql>();
						dql.a(dql.f() + 1);
						c5x2.h.b.aa().bl();
						bcg.a(c5x2, c5x3);
					}
				}
			}
		}
	}

	// Token: 0x06003EF1 RID: 16113 RVA: 0x0017CA3C File Offset: 0x0017AC3C
	internal static void a(c5x A_0, c5x A_1)
	{
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		a7j item = new a7j(A_1, "NeuralOverload", 1, double.MaxValue, true, true, new Vector3?(new Vector3(0f, 0f, A_1.Size.Z / 2f)), null, null, null, false, null);
		qy.ad().Add(item);
		if (!A_1.h.b.aa().Passive)
		{
			if (A_1.h.b.aa().c(d8o.e) || A_1.h.b.aa().d(CharacterImmunities.MindAffecting))
			{
				etm a_ = new etm(new ap9(A_1.h.b.aa()), "невральной перегрузке");
				bey.a(a_, A_0.h.b.aa(), A_1.h.b.aa(), A_1.h.b);
				a7v.a(a_);
				bmj.a(A_1, new ba0());
			}
			else
			{
				cwt a_2 = bcg.a(A_0.h.b.aa(), A_1.h.b.aa());
				akg item2 = new akg(A_0.h.b, A_1.h.b, a_2, null, false);
				qy.ad().Add(item2);
				if (A_0.h.b.aa().Feats.c(typeof(cgu)))
				{
					cr cr = u6.a(A_1.h.b.aa(), 5);
					if (cr != null)
					{
						amd item3 = new amd(A_1.h.b, new els[]
						{
							cr
						});
						qy.ad().Add(item3);
					}
				}
			}
		}
		A_1.Zone.ActionManager.g9(qy, atp.a);
		dz6.a(qy);
	}

	// Token: 0x06003EF2 RID: 16114 RVA: 0x0017CC64 File Offset: 0x0017AE64
	private static cwt a(efk A_0, efk A_1)
	{
		bas bas = A_0.Offense.ag()[PsiSchool.ThoughtControl];
		double num = dzs.a(A_1, bas.b());
		double a_ = dzs.a(A_1);
		double a_2 = 1.0;
		if (A_1.StatusEffects.a(am0.a))
		{
			a_2 = 2.0;
		}
		cwt cwt = new cwt();
		cwt.l = true;
		cwt.p = true;
		cwt.i = new ap9(A_0);
		cwt.j = new ap9(A_1);
		cwt.b = true;
		cwt.e = (!A_1.ImmuneToCriticalHits && euf.a(euf.a(bas, A_1)));
		cwt.q = false;
		cwt.f.Add(csk.a(csk.a(csk.a(euf.a(dzs.a(new eoj(A_0, null, null)), (double)(1f + (cwt.e ? bas.g() : 0f))), 1.0 - num), a_), a_2));
		cwt.ad["PsionicSource"] = PsiSchool.ThoughtControl;
		return cwt;
	}
}
