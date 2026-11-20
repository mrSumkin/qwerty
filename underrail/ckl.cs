using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BC0 RID: 7104
[dgg("Taser")]
public sealed class ckl : cwp
{
	// Token: 0x06009A7B RID: 39547 RVA: 0x003C19AC File Offset: 0x003BFBAC
	public override string bt()
	{
		return "草Электрошокер";
	}

	// Token: 0x06009A7C RID: 39548 RVA: 0x003C19B4 File Offset: 0x003BFBB4
	public override string bu()
	{
		return "Taser";
	}

	// Token: 0x06009A7D RID: 39549 RVA: 0x003C19BC File Offset: 0x003BFBBC
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009A7E RID: 39550 RVA: 0x003C19C0 File Offset: 0x003BFBC0
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009A7F RID: 39551 RVA: 0x003C19C4 File Offset: 0x003BFBC4
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Devices;
	}

	// Token: 0x06009A80 RID: 39552 RVA: 0x003C19CC File Offset: 0x003BFBCC
	public ckl()
	{
		base.Slots.Add(ckl.a, new cgo(new eh0("electroshockGenerator", 72), "Электрошоковый генератор", false, 1, 0.1f, false, false, null));
		base.Slots.Add(ckl.b, new cgo(new c6s(ms.i, 7), "Энергетическое ядро", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009A81 RID: 39553 RVA: 0x003C1A3C File Offset: 0x003BFC3C
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(ckl.a, null);
		fv fv2 = A_1.SafeGet(ckl.b, null);
		if (fv != null && fv2 != null)
		{
			bool flag = fv.TypedDefinition != null;
			a1k a1k = fv2.TypedDefinition;
			if (flag && a1k != null)
			{
				cdk cdk = new cdk();
				cdk.g("Электрошокер");
				cdk.f("Items.Taser");
				cdk.i("Электрошоковое оружие, способное нанести урон и оглушить цель.");
				cdk.a(a0.aj);
				cdk.h(fv.SingleItemWeight + fv2.SingleItemWeight);
				cdk.b(new double?((double)((fv.SingleItemValue + fv2.SingleItemValue) * 2)));
				cdk.a7()["TaserStrength"] = fv.QualityLevel;
				cdk.a2().Add(new aia("taserTase"));
				int value = c6o.a(fv2, A_0);
				acz result = new acz(new IndependentItemDefinitionProvider<cdk>(cdk));
				cdk.c(new int?(value));
				return result;
			}
		}
		return null;
	}

	// Token: 0x04003B03 RID: 15107
	public new static readonly string a = "electroshockGen";

	// Token: 0x04003B04 RID: 15108
	public new static readonly string b = "core";
}
