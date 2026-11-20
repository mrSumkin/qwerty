using System;
using Microsoft.Xna.Framework;

// Token: 0x02001660 RID: 5728
public sealed class ayr : uu
{
	// Token: 0x06007D4F RID: 32079 RVA: 0x0034C084 File Offset: 0x0034A284
	public override bool gu(cnm A_0, amc A_1, amc A_2)
	{
		if (!base.gu(A_0, A_1, A_2))
		{
			return false;
		}
		c5x c5x = A_2.a8();
		if (A_0.b8().c(d8o.e))
		{
			vr a_ = new vr(new ap9(c5x.h.b.aa()), null, "Повышение характеристик не оказало никакого влияния на {0}", new Color?(adi.m), null);
			bey.a(a_, c5x.h.b.aa(), c5x.h.b);
			a7v.a(a_);
			return false;
		}
		coh coh = A_0.b9() as coh;
		if (coh == null)
		{
			return false;
		}
		string classPropertyValue = coh.Definition.a7().GetClassPropertyValue<string>("StatToBoost");
		bool value = coh.Definition.a7().GetPrimitivePropertyValue<bool>("Overboost", new bool?(false)).Value;
		if (string.IsNullOrEmpty(classPropertyValue))
		{
			return false;
		}
		foreach (to to in A_2.aa().BaseAbilities)
		{
			if (string.Equals(to.Name, classPropertyValue))
			{
				to to2 = A_2.aa().BaseAbilities.b(to.Name);
				to2.a(to2.f() + (value ? 2 : 1));
			}
		}
		int value2 = coh.Definition.a7().GetPrimitivePropertyValue<int>("SideEffectValue", new int?(0)).Value;
		if (value2 != 0)
		{
			if (value2 > 0)
			{
				A_2.aa().StatusEffects.a(new z8(value2 * 120000, value2), false, false, false);
			}
			else if (value2 < 0)
			{
				A_2.aa().StatusEffects.a(new boy(Math.Abs(value2) * 1200000, value2), false, false, false);
			}
		}
		return true;
	}
}
