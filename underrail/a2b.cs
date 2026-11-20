using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B9F RID: 7071
[dgg("shotgunShells")]
public sealed class a2b : cwp
{
	// Token: 0x06009988 RID: 39304 RVA: 0x003BD208 File Offset: 0x003BB408
	public override string bt()
	{
		return "茴Патроны для дробовика";
	}

	// Token: 0x06009989 RID: 39305 RVA: 0x003BD210 File Offset: 0x003BB410
	public override string bu()
	{
		return "shotgunShells";
	}

	// Token: 0x0600998A RID: 39306 RVA: 0x003BD218 File Offset: 0x003BB418
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x0600998B RID: 39307 RVA: 0x003BD21C File Offset: 0x003BB41C
	public override int dq()
	{
		return 15;
	}

	// Token: 0x0600998C RID: 39308 RVA: 0x003BD220 File Offset: 0x003BB420
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x0600998D RID: 39309 RVA: 0x003BD228 File Offset: 0x003BB428
	public a2b()
	{
		base.Slots.Add("shotgunShell", new cgo(new eh0("case.ShotgunShell", 101), "Гильза дробовика", false, 15, 0.1f, false, false, null));
		base.Slots.Add("mold", new cgo(new c6s(ms.bk, 102), "Форма дроби", false, 1, 0.1f, false, false, null));
		base.Slots.Add("tnt", new cgo(new eh0("tnt", 11), "Тротил", false, 1, 0.1f, false, false, null));
		base.Slots.Add("metal", new cgo(new eh0(new string[]
		{
			"steel",
			"tungstenSteel"
		}, 23), "Стальная пластина", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x0600998E RID: 39310 RVA: 0x003BD30C File Offset: 0x003BB50C
	protected override Dictionary<string, int> dr(string A_0, cgo A_1, coh A_2)
	{
		if (A_0 == "metal")
		{
			return cwp.a(SkillEnum.Mechanics, 30, A_2);
		}
		return base.gk(A_2);
	}

	// Token: 0x0600998F RID: 39311 RVA: 0x003BD334 File Offset: 0x003BB534
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			fv fv = A_1.SafeGet("mold", null);
			fv fv2 = A_1.SafeGet("metal", null);
			string classPropertyValue = fv.TypedDefinition.a7().GetClassPropertyValue<string>("ShotgunShell");
			if (classPropertyValue == "ShotgunShell_3")
			{
				if (fv2.TypedDefinition.a5() != "tungstenSteel")
				{
					A_2 = "Чтобы создать дробь при помощи этой формы, нужна вольфрамовая сталь.";
					return null;
				}
			}
			else if (fv2.TypedDefinition.a5() != "steel")
			{
				A_2 = "Чтобы создать дробь при помощи этой формы, нужна обычная сталь.";
				return null;
			}
			string path = "ammo\\Xpbl\\" + classPropertyValue;
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}
}
