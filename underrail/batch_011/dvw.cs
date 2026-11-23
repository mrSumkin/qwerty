using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;

// Token: 0x020017C8 RID: 6088
[eiz("FC0")]
[Serializable]
public sealed class dvw : a6k, ISerializable
{
	// Token: 0x060081E5 RID: 33253 RVA: 0x0036ADC4 File Offset: 0x00368FC4
	private dvw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060081E6 RID: 33254 RVA: 0x0036ADD4 File Offset: 0x00368FD4
	static dvw()
	{
		dvw.a.Add("rathoundBarbeque", new bnh());
		dvw.a.Add("burrowerBurger", new c0j());
		dvw.a.Add("caveHopperSteak", new c9u());
		dvw.a.Add("eelSandwich", new ef0());
		dvw.a.Add("junkyardSurprise", new rf());
		dvw.a.Add("mushroomBrew", new aok());
		dvw.a.Add("coffee", new dfr());
		dvw.a.Add("cannedFish", new e73());
		dvw.a.Add("cannedMeat", new dw4());
		dvw.a.Add("cannedMushrooms", new bgs());
		dvw.a.Add("cannedStew", new c77());
		dvw.a.Add("baconCheeseSandwich", new epd());
		dvw.a.Add("cookedBurrowerEgg", new art());
		dvw.a.Add("coreChips", new brk());
		dvw.a.Add("hardcoreChips", new c10());
		dvw.a.Add("friedSiphonerTongue", new dkw());
		dvw.a.Add("mushroomSalad", new exu());
		dvw.a.Add("pentapusBarbecue", new d6y());
		dvw.a.Add("pickledMindshrooms", new dfe());
		dvw.a.Add("psiBeetleBrainSoup", new d6h());
		dvw.a.Add("rootSoda", new cin());
		dvw.a.Add("stuffedBat", new bx7());
		dvw.a.Add("underPie", new bsv());
		dvw.a.Add("cannedCzernina", new a49());
		dvw.a.Add("crabSandwich", new cf5());
		dvw.a.Add("kzozel", new a7e());
		dvw.a.Add("kzozelYantar", new d70());
		dvw.a.Add("mutieStew", new a57());
		dvw.a.Add("seaSerpentFillet", new fr());
		dvw.a.Add("butterySteamedClams", new cuf());
		dvw.a.Add("bisonMilk", new ah1());
		dvw.a.Add("mysteryCandy", new cg2());
		dvw.a.Add("jonSpecial", new ea9());
		foreach (Type type in bpo.GetServiceOrThrow<ei2>().av2(new Func<Type, bool>(dvw.a.a.a)))
		{
			z1 singletonCustomAttribute = boo.GetSingletonCustomAttribute<z1>(type);
			if (singletonCustomAttribute != null && !string.IsNullOrEmpty(singletonCustomAttribute.a) && type.GetConstructor(Type.EmptyTypes) != null)
			{
				try
				{
					dz4 dz = Activator.CreateInstance(type) as dz4;
					if (dz != null)
					{
						dvw.a[singletonCustomAttribute.a] = dz;
					}
				}
				catch (Exception a_)
				{
					dux.a(LogSeverity.Error, a_, "Не удалось создать экземпляр обработчика пищи с кодом: '{0}'", new object[]
					{
						singletonCustomAttribute.a
					});
				}
			}
		}
	}

	// Token: 0x060081E7 RID: 33255 RVA: 0x0036B168 File Offset: 0x00369368
	public dvw()
	{
	}

	// Token: 0x060081E8 RID: 33256 RVA: 0x0036B170 File Offset: 0x00369370
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		coh coh = base.vg().e().b9() as coh;
		if (coh != null)
		{
			string classPropertyValue = coh.Definition.a7().GetClassPropertyValue<string>("foodCode");
			string classPropertyValue2 = coh.Definition.a7().GetClassPropertyValue<string>("foodName");
			if (!string.IsNullOrEmpty(classPropertyValue) && !string.IsNullOrEmpty(classPropertyValue2))
			{
				dz4 dz;
				dvw.a.TryGetValue(classPropertyValue, out dz);
				if (dz != null)
				{
					d3e[] a_;
					wq[] a_2;
					string a_3;
					dz.ft(out a_, out a_2, out a_3);
					base.vg().q().c().a(dz.o6());
					List<c9i> list = c5x.h.b.aa().StatusEffects.Get<c9i>();
					if (list != null)
					{
						foreach (c9i a_4 in list)
						{
							c5x.h.b.aa().StatusEffects.d(a_4);
						}
					}
					int a_5 = 0;
					if (base.vg().e() != null && base.vg().e().b8() != null && base.vg().e().b8().Feats.Contains<cp1>())
					{
						a_5 = cp1.a;
					}
					c9i c9i = new c9i(classPropertyValue, classPropertyValue2, coh.Definition.a3(), a_, a_2, a_3, a_5);
					c9i.ab = dz.py(c5x);
					c9i.y = dz.pz(c5x);
					c9i.w = dz.p0(c5x);
					c9i.x = dz.p2(c5x);
					c9i.aa = dz.p1(c5x);
					c9i.z = dz.px(c5x);
					amd a_6 = new amd(c5x.h.b, new els[]
					{
						c9i
					});
					c5x.Zone.ActionManager.g9(a_6, atp.a);
					dz6.a(a_6);
					if (base.vg().q().IsPlayer)
					{
						cxc.a(eyy.b3);
					}
					dz.pw(base.vg().q());
					return dc4.c;
				}
			}
		}
		return dc4.e;
	}

	// Token: 0x0400325E RID: 12894
	private new static readonly Dictionary<string, dz4> a = new Dictionary<string, dz4>();

	// Token: 0x020017C9 RID: 6089
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060081EB RID: 33259 RVA: 0x0036B430 File Offset: 0x00369630
		internal bool a(Type A_0)
		{
			return A_0.IsClass && !A_0.IsAbstract && typeof(dz4).IsAssignableFrom(A_0);
		}

		// Token: 0x0400325F RID: 12895
		public static readonly dvw.a a = new dvw.a();
	}
}
