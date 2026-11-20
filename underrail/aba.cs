using System;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200218E RID: 8590
[dp2("1.0.3.21_WeaponCustomPropertiesChanges", "1.0.3.21")]
public sealed class aba : dnv
{
	// Token: 0x0600C96E RID: 51566 RVA: 0x004731EC File Offset: 0x004713EC
	public bool eq(bk3 A_0)
	{
		bke bke = A_0 as bke;
		if (bke != null)
		{
			WeaponSubtype? primitivePropertyValue = bke.a7().GetPrimitivePropertyValue<WeaponSubtype>("WeaponSubtype", null);
			string classPropertyValue = bke.a7().GetClassPropertyValue<string>("CustomShootingActuator");
			bool value = bke.a7().GetPrimitivePropertyValue<bool>("DualFire", new bool?(false)).Value;
			int? primitivePropertyValue2 = bke.a7().GetPrimitivePropertyValue<int>("CustomTurnBasedDelay", null);
			CharacterState? primitivePropertyValue3 = bke.a7().GetPrimitivePropertyValue<CharacterState>("CustomAttackAnimation", null);
			bke.a7().RemoveProperty("WeaponSubtype");
			bke.a7().RemoveProperty("CustomShootingActuator");
			bke.a7().RemoveProperty("DualFire");
			bke.a7().RemoveProperty("CustomTurnBasedDelay");
			bke.a7().RemoveProperty("CustomAttackAnimation");
			bke.a(primitivePropertyValue);
			bke.c(classPropertyValue);
			bke.a(value);
			if (primitivePropertyValue2 != null)
			{
				bke.b(primitivePropertyValue2);
			}
			if (primitivePropertyValue3 != null)
			{
				bke.d(primitivePropertyValue3.Value.ToString());
			}
		}
		return true;
	}

	// Token: 0x0600C96F RID: 51567 RVA: 0x00473334 File Offset: 0x00471534
	public bool er(coh A_0)
	{
		return true;
	}
}
