using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BAE RID: 7086
[dgg("supersoldierDrug")]
public sealed class e04 : cwp
{
	// Token: 0x060099F6 RID: 39414 RVA: 0x003BFCB4 File Offset: 0x003BDEB4
	public override string bt()
	{
		return "莘Сыворотка сверхсолдата";
	}

	// Token: 0x060099F7 RID: 39415 RVA: 0x003BFCBC File Offset: 0x003BDEBC
	public override string bu()
	{
		return "supersoldierDrug";
	}

	// Token: 0x060099F8 RID: 39416 RVA: 0x003BFCC4 File Offset: 0x003BDEC4
	public override cr1 bv()
	{
		return cr1.e;
	}

	// Token: 0x060099F9 RID: 39417 RVA: 0x003BFCC8 File Offset: 0x003BDEC8
	public override int dq()
	{
		return 1;
	}

	// Token: 0x060099FA RID: 39418 RVA: 0x003BFCCC File Offset: 0x003BDECC
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Medicine;
	}

	// Token: 0x060099FB RID: 39419 RVA: 0x003BFCD0 File Offset: 0x003BDED0
	public e04()
	{
		base.Slots.Add("muscarine", new cgo(new eh0("muscarine", 55), "Мускарин", false, 1, 0.1f, false, false, null));
		base.Slots.Add("adrenaline", new cgo(new eh0("adrenaline", 53), "Адреналин", false, 1, 0.1f, false, false, null));
		base.Slots.Add("kynurenicAcid", new cgo(new eh0("kynurenicAcid", 53), "Кинуреновая кислота", false, 1, 0.1f, false, false, null));
		base.Slots.Add("prednisoneSolution", new cgo(new eh0("prednisoneSolution", 57), "Раствор преднизона", false, 1, 0.1f, false, false, null));
		base.Slots.Add("syringe", new cgo(new c6s(ms.ao, 34), "Шприц", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x060099FC RID: 39420 RVA: 0x003BFDD0 File Offset: 0x003BDFD0
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			bit bit = ez2.CreateDefinitonProvider<dgn>("Consumables\\Medicine\\SupersoldierDrug");
			if (bit != null)
			{
				return new d48(bit);
			}
		}
		return null;
	}
}
