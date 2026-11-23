using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BBF RID: 7103
[dgg("throwingKnives")]
public sealed class ajh : cwp
{
	// Token: 0x06009A74 RID: 39540 RVA: 0x003C1828 File Offset: 0x003BFA28
	public override string bt()
	{
		return "荔Метательные ножи";
	}

	// Token: 0x06009A75 RID: 39541 RVA: 0x003C1830 File Offset: 0x003BFA30
	public override string bu()
	{
		return "throwingKnives";
	}

	// Token: 0x06009A76 RID: 39542 RVA: 0x003C1838 File Offset: 0x003BFA38
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009A77 RID: 39543 RVA: 0x003C183C File Offset: 0x003BFA3C
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x06009A78 RID: 39544 RVA: 0x003C1840 File Offset: 0x003BFA40
	public ajh()
	{
		base.Slots.Add(ajh.a, new cgo(new c6s(ms.ac, 23), "Метал", false, 1, 0.1f, false, false, null));
		base.Slots.Add(ajh.b, new cgo(new c6s(new ms[]
		{
			ms.aq
		}, 5), "Яд", true, 1, 0f, false, false, null));
	}

	// Token: 0x06009A79 RID: 39545 RVA: 0x003C18B8 File Offset: 0x003BFAB8
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(ajh.a, null);
		fv fv2 = A_1.SafeGet(ajh.b, null);
		if (fv != null && fv.TypedDefinition != null)
		{
			string text = "";
			if (fv2 != null && fv2.TypedDefinition != null)
			{
				text = fv2.TypedDefinition.a7().GetClassPropertyValue<string>("PoisonCode");
				if (!string.IsNullOrEmpty(text))
				{
					text = text.Replace(" ", "");
				}
			}
			string path = string.Format("Weapons\\{0}ThrowingKnife", text);
			if (ez2.GetItemDefinition<cdk>(path, true) != null)
			{
				acz acz = new acz(ez2.CreateDefinitonProvider<cdk>(path));
				if (fv2 != null && fv2.TypedDefinition != null)
				{
					acz.Stacks = 10;
				}
				else
				{
					acz.Stacks = 30;
				}
				return acz;
			}
			A_2 = "Нельзя использовать этот химикат.";
		}
		return null;
	}

	// Token: 0x04003B01 RID: 15105
	public new static readonly string a = "metal";

	// Token: 0x04003B02 RID: 15106
	public new static readonly string b = "poison";
}
