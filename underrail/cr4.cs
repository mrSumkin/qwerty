using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BD7 RID: 7127
[dgg("cloakingDevice")]
public sealed class cr4 : cwp
{
	// Token: 0x06009B1D RID: 39709 RVA: 0x003C8144 File Offset: 0x003C6344
	public override string bt()
	{
		return "荌Маскировочное устройство";
	}

	// Token: 0x06009B1E RID: 39710 RVA: 0x003C814C File Offset: 0x003C634C
	public override string bu()
	{
		return "cloakingDevice";
	}

	// Token: 0x06009B1F RID: 39711 RVA: 0x003C8154 File Offset: 0x003C6354
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009B20 RID: 39712 RVA: 0x003C8158 File Offset: 0x003C6358
	public override bool bw()
	{
		return true;
	}

	// Token: 0x06009B21 RID: 39713 RVA: 0x003C815C File Offset: 0x003C635C
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Devices;
	}

	// Token: 0x06009B22 RID: 39714 RVA: 0x003C8160 File Offset: 0x003C6360
	public cr4()
	{
		base.Slots.Add(cr4.a, new cgo(new c6s(ms.at, 39), "Электромагнитный отражатель", false, 1, 0.1f, false, false, null));
		base.Slots.Add(cr4.b, new cgo(new c6s(ms.au, 38), "Стабилизатор электромагнитного поля", false, 1, 0.1f, false, false, null));
		base.Slots.Add(cr4.c, new cgo(new c6s(ms.i, 7), "Энергетическое ядро", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009B23 RID: 39715 RVA: 0x003C81F8 File Offset: 0x003C63F8
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(cr4.a, null);
		fv fv2 = A_1.SafeGet(cr4.b, null);
		fv fv3 = A_1.SafeGet(cr4.c, null);
		if (fv != null && fv2 != null && fv.TypedDefinition != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null)
		{
			int num = (int)((double)fv.QualityLevel * 0.5);
			int num2 = (int)((double)fv.QualityLevel * 0.25);
			double num3 = Math.Max(0.1, 1.0 - (double)fv2.QualityLevel / 100.0 * 0.5);
			int num4 = c6o.a(fv3, A_0);
			double num5 = (double)fv.QualityLevel * 0.15 * num3;
			double num6 = (double)((int)Math.Min(num5 * 3.0, (double)(num4 / 2)));
			cdk cdk = new cdk();
			cdk.g("Маскировочное устройство");
			cdk.f("Items.CloakingDevice");
			cdk.i(qv.b("Items\\Utilities/CloakingDevice"));
			cdk.a2().Add(new aia("PersonalCloaking"));
			cdk.a7()["StealthBonus"] = num;
			cdk.a7()["EvasionBonus"] = num2;
			cdk.a7()["PowerPerTurnCost"] = num5;
			cdk.a7()["PowerOnCost"] = num6;
			cdk.b(new double?((double)((fv.SingleItemValue + fv2.SingleItemValue + fv3.SingleItemValue) * 2)));
			cdk.h(fv.SingleItemWeight + fv2.SingleItemWeight + fv3.SingleItemWeight);
			cdk.g((int)((cwp.a(fv) + cwp.a(fv2) + cwp.a(fv3)) / 3.0));
			cdk.a(fv.TypedDefinition.bc());
			cdk.a(a0.aj);
			acz result = new acz(new IndependentItemDefinitionProvider<cdk>(cdk));
			cdk.c(new int?(num4));
			return result;
		}
		return null;
	}

	// Token: 0x04003B4A RID: 15178
	public new static readonly string a = "deflector";

	// Token: 0x04003B4B RID: 15179
	public new static readonly string b = "stabilizer";

	// Token: 0x04003B4C RID: 15180
	public static readonly string c = "core";
}
