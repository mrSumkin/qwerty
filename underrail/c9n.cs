using System;
using TimelapseVertigo.Rules;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000C5A RID: 3162
public sealed class c9n : bff
{
	// Token: 0x0600470F RID: 18191 RVA: 0x001D53EC File Offset: 0x001D35EC
	public override string cc()
	{
		return "xphw";
	}

	// Token: 0x06004710 RID: 18192 RVA: 0x001D53F4 File Offset: 0x001D35F4
	public override bool cd()
	{
		return true;
	}

	// Token: 0x06004711 RID: 18193 RVA: 0x001D53F8 File Offset: 0x001D35F8
	public c9n() : base("xphw_up_gattler", "creature\\characters\\support\\xphw\\up_gattler")
	{
	}

	// Token: 0x06004712 RID: 18194 RVA: 0x001D540C File Offset: 0x001D360C
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0 != null)
		{
			amc aspect = A_0.GetAspect<amc>();
			if (aspect != null)
			{
				cd1 cd = aspect.aa().Gear.j()[WeaponKey.Primary].Item;
				if (cd != null && cd.LoadedAmmo.Count == 0)
				{
					AmmoType item;
					if (A_1.ae() >= GameDifficulty.Dominating)
					{
						item = AmmoType.Caliber_9_W2C;
					}
					else
					{
						item = AmmoType.Caliber_9_Std;
					}
					for (int i = 0; i < cd.TypedDefinition.f(); i++)
					{
						cd.LoadedAmmo.Add(item);
					}
				}
			}
		}
	}
}
