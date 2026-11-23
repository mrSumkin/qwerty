using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Data;
using Ouroboros.Playfield.Aspects;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020011AA RID: 4522
[edy("ChT")]
public sealed class ceo : d4x
{
	// Token: 0x06006056 RID: 24662 RVA: 0x002A1208 File Offset: 0x0029F408
	public override Dictionary<string, Type> jn()
	{
		return new Dictionary<string, Type>();
	}

	// Token: 0x06006057 RID: 24663 RVA: 0x002A1210 File Offset: 0x0029F410
	protected override b0b jo(c5k A_0, Guid? A_1 = null)
	{
		esl esl = ceo.a(A_0);
		if (esl != null)
		{
			bool? primitivePropertyValue = A_0.f().GetPrimitivePropertyValue<bool>("Immobile", null);
			c5x c5x;
			if (A_1 != null)
			{
				c5x = new c5x(A_1.Value);
			}
			else
			{
				c5x = new c5x();
			}
			c5x.Size = new Vector3(1f, 1f, 1f);
			c5x.CanTrigger = true;
			c90.a(c5x, A_0);
			amc amc = new amc(c5x, new StandAloneProvider<efk>(new efk()));
			c5x.SetAspect<amc>(amc);
			su aspect = new su(c5x);
			c5x.SetAspect<su>(aspect);
			if (primitivePropertyValue == null || !primitivePropertyValue.Value)
			{
				mj mj = new mj(c5x, new MobileEntityAspectAccessor<amc>(c5x));
				mj.a(amc);
				c5x.SetAspect<mj>(mj);
				bool value = A_0.f().GetPrimitivePropertyValue<bool>("LightTraverser", new bool?(false)).Value;
				c5x.SetAspect<ale>(new ale(c5x)
				{
					d = value
				});
			}
			ny aspect2 = new ny(c5x);
			c5x.SetAspect<ny>(aspect2);
			bhf aspect3 = new bhf(c5x);
			c5x.SetAspect<u2>(aspect3);
			if (c5x.v.b == null)
			{
				aru aspect4 = new aru(c5x);
				c5x.SetAspect<aru>(aspect4);
			}
			c0s aspect5 = new c0s(c5x);
			c5x.SetAspect<c0s>(aspect5);
			bool? primitivePropertyValue2 = A_0.f().GetPrimitivePropertyValue<bool>("Intelligent", null);
			if (primitivePropertyValue2 != null && primitivePropertyValue2.Value)
			{
				bm6 aspect6 = new bm6(c5x);
				c5x.SetAspect<bm6>(aspect6);
			}
			ceo.a(A_0, esl, c5x, null);
			c5x.q(esl.d().aa().Name);
			return c5x;
		}
		return null;
	}

	// Token: 0x06006058 RID: 24664 RVA: 0x002A13E8 File Offset: 0x0029F5E8
	protected override bool afd(c5k A_0, b0b A_1, List<string> A_2)
	{
		return ceo.a(A_0, null, A_1, A_2);
	}

	// Token: 0x06006059 RID: 24665 RVA: 0x002A13F8 File Offset: 0x0029F5F8
	private static bool a(c5k A_0, esl A_1, b0b A_2, List<string> A_3)
	{
		HashSet<string> a_ = (A_3 != null) ? new HashSet<string>(A_3) : null;
		amc aspect = A_2.GetAspect<amc>();
		if (A_1 == null)
		{
			A_1 = ceo.a(A_0);
			if (A_1 == null)
			{
				return false;
			}
		}
		if (aspect == null)
		{
			return false;
		}
		if (ceo.a(a_, "model"))
		{
			aspect.a(A_1.d().am());
			aspect.c(A_1.d().a0());
			aspect.b(A_1.d().v());
			if (ceo.a(a_, "model", "model_corpseBehavior"))
			{
				aspect.i(A_1.d().ar());
				aspect.c(A_1.d().ab());
				aspect.g(A_1.d().ax());
				aspect.f(A_1.d().a1());
			}
			aspect.d(A_1.d().a7());
			aspect.a(A_1.d().ac());
			aspect.e(A_1.d().ae());
			aspect.a(A_1.d().an());
			aspect.aa().Gender = A_1.d().aa().Gender;
			aspect.am = A_1.d().am;
			aspect.al = A_1.d().al;
			aspect.ao = A_1.d().ao;
			aspect.an = A_1.d().an;
			cd0 cd = A_2.GetAspect<cd0>();
			string classPropertyValue = A_0.f().GetClassPropertyValue<string>("SimpleModel");
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				if (cd == null)
				{
					cd = new cd0(A_2 as c5x);
					cd.a = classPropertyValue;
					string classPropertyValue2 = A_0.f().GetClassPropertyValue<string>("SimpleFrame");
					if (!string.IsNullOrEmpty(classPropertyValue2))
					{
						cd.b = zy.b(classPropertyValue2);
					}
					A_2.SetAspect<cd0>(cd);
				}
			}
			else if (cd != null)
			{
				A_2.RemoveAspect<cd0>();
			}
		}
		if (ceo.a(a_, "system"))
		{
			aspect.aa().ak();
			aspect.aa().Id = A_1.d().aa().Id;
			aspect.aa().Name = A_1.d().aa().Name;
			aspect.aa().FactionId = A_1.d().aa().FactionId;
			aspect.aa().HostilityBroadcastMode = A_1.d().aa().HostilityBroadcastMode;
			aspect.aa().Passive = A_1.d().aa().Passive;
			aspect.aa().EtherealBase = A_1.d().aa().EtherealBase;
			aspect.t = A_1.d().t;
		}
		if (ceo.a(a_, "xp"))
		{
			aspect.a(A_1.d().ap());
			aspect.d(A_1.d().ak());
		}
		if (ceo.a(a_, "modifiers"))
		{
			aspect.aa().ak();
			aspect.aa().BaseMovementSpeed = A_1.d().aa().BaseMovementSpeed;
			aspect.aa().Offense.h(A_1.d().aa().Offense.x());
			aspect.aa().Offense.i(A_1.d().aa().Offense.aj());
			aspect.aa().Offense.d(A_1.d().aa().Offense.w());
			aspect.aa().BaseSightRange = A_1.d().aa().BaseSightRange;
			aspect.aa().BaseDetectionModifier = A_1.d().aa().BaseDetectionModifier;
			aspect.aa().Defense.a(A_1.d().aa().Defense.ad());
			aspect.aa().NaturallyTruesighted = A_1.d().aa().NaturallyTruesighted;
			aspect.aa().TruesightRange = A_1.d().aa().TruesightRange;
			aspect.aa().NaturalDarkvision = A_1.d().aa().NaturalDarkvision;
			aspect.aa().Defense.d(A_1.d().aa().Defense.ag());
		}
		if (ceo.a(a_, "attributes"))
		{
			aspect.aa().AttributesBase = A_1.d().aa().AttributesBase;
		}
		if (ceo.a(a_, "immunities"))
		{
			aspect.aa().ImmunitiesBase = A_1.d().aa().ImmunitiesBase;
		}
		if (ceo.a(a_, "appearance"))
		{
			aspect.aa().Portrait = A_1.d().aa().Portrait;
			aspect.aa().Color = A_1.d().aa().Color;
		}
		if (ceo.a(a_, "base"))
		{
			aspect.aa().ak();
			aspect.aa().Level = A_1.d().aa().Level;
			foreach (to to in aspect.aa().BaseAbilities)
			{
				aspect.aa().BaseAbilities.b(to.Name).a(A_1.d().aa().BaseAbilities.b(to.Name).f());
			}
		}
		if (ceo.a(a_, "skills"))
		{
			aspect.aa().ak();
			foreach (csn csn in A_1.d().aa().Skills)
			{
				aspect.aa().Skills.b(csn.Name).a(csn.f());
			}
		}
		if (ceo.a(a_, "feats"))
		{
			aspect.aa().ak();
			foreach (ai8 ai in Enumerable.ToList<ai8>(aspect.aa().Feats))
			{
				if (!A_1.d().aa().Feats.a(ai))
				{
					aspect.aa().Feats.b(ai.GetType());
				}
			}
			foreach (ai8 ai2 in A_1.d().aa().Feats)
			{
				if (!aspect.aa().Feats.a(ai2))
				{
					aspect.aa().Feats.d(ai2.GetType());
				}
			}
		}
		if (ceo.a(a_, "specials"))
		{
			aspect.aa().ak();
			aspect.aa().SpecialAttacks.b();
			foreach (aia aia in A_1.d().aa().SpecialAttacks)
			{
				aspect.aa().SpecialAttacks.b(aia.Value);
			}
			aspect.aa().SpecialAbilities.b();
			foreach (aia aia2 in A_1.d().aa().SpecialAbilities)
			{
				aspect.aa().SpecialAbilities.b(aia2.Value);
			}
			aspect.aa().PsiAbilities.b();
			foreach (aia aia3 in A_1.d().aa().PsiAbilities)
			{
				aspect.aa().PsiAbilities.b(aia3.Value);
			}
		}
		ery ery = A_2.GetAspect<ery>();
		bool flag = ery == null || !ery.a();
		if (flag && ceo.a(a_, "gear"))
		{
			aspect.a4();
			aspect.aa().ak();
			aspect.aa().Gear.l().po(ceo.a(A_1.d().aa().Gear.l().Value));
			aspect.aa().Gear.e().po(ceo.a(A_1.d().aa().Gear.e().Value));
			aspect.aa().Gear.f().po(ceo.a(A_1.d().aa().Gear.f().Value));
			aspect.aa().Gear.g().po(ceo.a(A_1.d().aa().Gear.g().Value));
			aspect.aa().Gear.h().po(ceo.a(A_1.d().aa().Gear.h().Value));
			aspect.aa().Gear.j()[WeaponKey.Primary].po(ceo.a(A_1.d().aa().Gear.j()[WeaponKey.Primary].Value));
			aspect.aa().Gear.j()[WeaponKey.Secondary].po(ceo.a(A_1.d().aa().Gear.j()[WeaponKey.Secondary].Value));
			aspect.a3();
		}
		if (ceo.a(a_, "staticGear"))
		{
			aspect.aa().ak();
			if (ceo.b(A_1.d().aa().Gear.l().Value))
			{
				aspect.aa().Gear.l().po(ceo.a(A_1.d().aa().Gear.l().Value));
			}
			if (ceo.b(A_1.d().aa().Gear.e().Value))
			{
				aspect.aa().Gear.e().po(ceo.a(A_1.d().aa().Gear.e().Value));
			}
			if (ceo.b(A_1.d().aa().Gear.f().Value))
			{
				aspect.aa().Gear.f().po(ceo.a(A_1.d().aa().Gear.f().Value));
			}
			if (ceo.b(A_1.d().aa().Gear.g().Value))
			{
				aspect.aa().Gear.g().po(ceo.a(A_1.d().aa().Gear.g().Value));
			}
			if (ceo.b(A_1.d().aa().Gear.h().Value))
			{
				aspect.aa().Gear.h().po(ceo.a(A_1.d().aa().Gear.h().Value));
			}
			if (ceo.b(A_1.d().aa().Gear.j()[WeaponKey.Primary].Value))
			{
				aspect.aa().Gear.j()[WeaponKey.Primary].po(ceo.a(A_1.d().aa().Gear.j()[WeaponKey.Primary].Value));
			}
			if (ceo.b(A_1.d().aa().Gear.j()[WeaponKey.Secondary].Value))
			{
				aspect.aa().Gear.j()[WeaponKey.Secondary].po(ceo.a(A_1.d().aa().Gear.j()[WeaponKey.Secondary].Value));
			}
		}
		if (ceo.a(a_, "utility"))
		{
			aspect.aa().ak();
			for (int i = 0; i < aiy.ay; i++)
			{
				aspect.aa().Gear.d()[i].po(ceo.a(A_1.d().aa().Gear.d()[i].Value));
			}
		}
		if (flag && ceo.a(a_, "inventory"))
		{
			aspect.aa().ak();
			aspect.aa().Bag.z7();
			foreach (coh coh in A_1.d().aa().Bag.z2())
			{
				aspect.aa().Bag.z3(coh.fy(), false);
			}
			if (ery == null && A_1.b() != null && A_1.b().g().Count > 0)
			{
				ery = new ery(A_2 as c5x);
				A_2.SetAspect<ery>(ery);
			}
			if (ery != null)
			{
				if (A_1.b() != null && A_1.b().g().Count > 0)
				{
					ery.a(A_1.b().e());
				}
				else
				{
					A_2.RemoveAspect<ery>();
				}
			}
		}
		if (ceo.a(a_, "jobs"))
		{
			aspect.a6().Clear();
			aspect.a6().AddRange(A_1.d().a6());
			aspect.ay().Clear();
			aspect.ay().AddRange(A_1.d().ay());
			aspect.av().Clear();
			aspect.av().AddRange(A_1.d().av());
			aspect.au().Clear();
			aspect.au().AddRange(A_1.d().au());
			aspect.aj().Clear();
			aspect.aj().AddRange(A_1.d().aj());
			aspect.aq().Clear();
			aspect.aq().AddRange(A_1.d().aq());
		}
		if (ceo.a(a_, "ai") && A_1.c() != null)
		{
			bm6 aspect2 = A_2.GetAspect<bm6>();
			if (aspect2 != null)
			{
				aspect2.b(A_1.c().ac());
				aspect2.c(A_1.c().ab());
				aspect2.a(A_1.c().ad().Clone());
				aspect2.c(A_1.c().q());
				aspect2.a(A_1.c().ag());
				aspect2.d(A_1.c().ae());
				aspect2.a(new List<dkv>(A_1.c().x()));
				if (ceo.a(a_, "ai", "ai_combatSpeak"))
				{
					aspect2.a(A_1.c().p());
				}
			}
		}
		if (ceo.a(a_, "trekker") && A_1.a() != null)
		{
			ale aspect3 = A_2.GetAspect<ale>();
			if (aspect3 != null)
			{
				aspect3.a = new List<string>(A_1.a().a);
				aspect3.c = A_1.a().c;
			}
		}
		if (ceo.a(a_, "sounds") && A_1.c() != null)
		{
			aspect.a(A_1.d().ag().b());
		}
		if (ceo.a(a_, "vehicle"))
		{
			if (A_1.d().z() != null)
			{
				aspect.a(A_1.d().z().qz());
			}
			else
			{
				aspect.a(null);
			}
		}
		if (ceo.a(a_, "map"))
		{
			aspect.d(A_1.d().az());
		}
		if (ceo.a(a_, "customProperties"))
		{
			foreach (Property property in Enumerable.ToList<Property>(aspect.aa().CustomProperties.Properties))
			{
				if (property.Name != null && property.Name.StartsWith("up_", StringComparison.OrdinalIgnoreCase))
				{
					aspect.aa().CustomProperties.RemoveProperty(property.Name);
				}
			}
			foreach (Property property2 in A_1.d().aa().CustomProperties.Properties)
			{
				if (property2.Name != null && property2.Name.StartsWith("up_", StringComparison.OrdinalIgnoreCase))
				{
					aspect.aa().CustomProperties[property2.Name] = property2.Value;
				}
			}
		}
		aspect.aa().bl();
		return true;
	}

	// Token: 0x0600605A RID: 24666 RVA: 0x002A26D0 File Offset: 0x002A08D0
	private static bool b(coh A_0)
	{
		return A_0 != null && A_0.Definition != null && !string.IsNullOrEmpty(A_0.Definition.az()) && A_0.Definition.az().EndsWith("*");
	}

	// Token: 0x0600605B RID: 24667 RVA: 0x002A271C File Offset: 0x002A091C
	private static coh a(coh A_0)
	{
		if (A_0 != null)
		{
			return A_0.fy();
		}
		return null;
	}

	// Token: 0x0600605C RID: 24668 RVA: 0x002A2730 File Offset: 0x002A0930
	public static bool a(HashSet<string> A_0, string A_1)
	{
		return A_0 == null || A_0.Count == 0 || (A_0.Contains("full") && !A_0.Contains("-" + A_1)) || A_0.Contains(A_1);
	}

	// Token: 0x0600605D RID: 24669 RVA: 0x002A2780 File Offset: 0x002A0980
	private static bool a(HashSet<string> A_0, string A_1, string A_2)
	{
		return A_0 == null || A_0.Count == 0 || ((A_0.Contains("full") || A_0.Contains(A_1)) && !A_0.Contains("-" + A_2)) || A_0.Contains(A_2);
	}

	// Token: 0x0600605E RID: 24670 RVA: 0x002A27DC File Offset: 0x002A09DC
	private static esl a(c5k A_0)
	{
		string classPropertyValue = A_0.f().GetClassPropertyValue<string>("Definition");
		if (classPropertyValue != null)
		{
			return hu.a(classPropertyValue);
		}
		return null;
	}
}
