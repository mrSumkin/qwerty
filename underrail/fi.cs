using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001E7C RID: 7804
[ayj("RepairKit")]
public sealed class fi : m0
{
	// Token: 0x0600AE23 RID: 44579 RVA: 0x003FBE5C File Offset: 0x003FA05C
	public override string y8()
	{
		return "RepairKit";
	}

	// Token: 0x0600AE24 RID: 44580 RVA: 0x003FBE64 File Offset: 0x003FA064
	public override string os()
	{
		return "RepairKit";
	}

	// Token: 0x0600AE25 RID: 44581 RVA: 0x003FBE6C File Offset: 0x003FA06C
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600AE26 RID: 44582 RVA: 0x003FBE70 File Offset: 0x003FA070
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.DisarmTrap);
	}

	// Token: 0x0600AE27 RID: 44583 RVA: 0x003FBE7C File Offset: 0x003FA07C
	public override string c1()
	{
		return "Ремонтирует";
	}

	// Token: 0x0600AE28 RID: 44584 RVA: 0x003FBE84 File Offset: 0x003FA084
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600AE29 RID: 44585 RVA: 0x003FBE88 File Offset: 0x003FA088
	public fi()
	{
		this.a = new List<string>();
	}

	// Token: 0x0600AE2A RID: 44586 RVA: 0x003FBE9C File Offset: 0x003FA09C
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600AE2B RID: 44587 RVA: 0x003FBEA0 File Offset: 0x003FA0A0
	public override SpellTargetType bn(cnm A_0)
	{
		ItemRepairCategory itemRepairCategory = ItemRepairCategory.Mechanical;
		if (A_0 != null)
		{
			coh coh = A_0.b9() as coh;
			if (coh != null && coh.Definition != null)
			{
				itemRepairCategory = fi.a(coh);
			}
		}
		switch (itemRepairCategory)
		{
		case ItemRepairCategory.Mechanical:
			return SpellTargetType.RepairableMechanicalItem;
		case ItemRepairCategory.Fabric:
			return SpellTargetType.RepairableFabricItem;
		case ItemRepairCategory.Electronic:
			return SpellTargetType.RepairableElectronicItem;
		default:
			return SpellTargetType.RepairableMechanicalItem;
		}
	}

	// Token: 0x0600AE2C RID: 44588 RVA: 0x003FBEFC File Offset: 0x003FA0FC
	public override string bo(cnm A_0)
	{
		return this.bp(A_0);
	}

	// Token: 0x0600AE2D RID: 44589 RVA: 0x003FBF08 File Offset: 0x003FA108
	public override string bp(cnm A_0)
	{
		if (A_0 != null)
		{
			coh coh = A_0.b9() as coh;
			if (coh != null && coh.Definition != null)
			{
				int num = fi.b(coh);
				return qv.a("Items\\RepairKits/" + fi.a(coh).ToString(), new object[]
				{
					num
				});
			}
		}
		return string.Empty;
	}

	// Token: 0x0600AE2E RID: 44590 RVA: 0x003FBF78 File Offset: 0x003FA178
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600AE2F RID: 44591 RVA: 0x003FBF80 File Offset: 0x003FA180
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600AE30 RID: 44592 RVA: 0x003FBF8C File Offset: 0x003FA18C
	public static int b(coh A_0)
	{
		if (A_0 != null)
		{
			return A_0.Definition.a7().GetPrimitivePropertyValue<int>("RepairAmount", new int?(0)).Value;
		}
		return 0;
	}

	// Token: 0x0600AE31 RID: 44593 RVA: 0x003FBFC4 File Offset: 0x003FA1C4
	public static ItemRepairCategory a(coh A_0)
	{
		if (A_0 != null)
		{
			return A_0.Definition.a7().GetPrimitivePropertyValue<ItemRepairCategory>("RepairCategory", new ItemRepairCategory?(ItemRepairCategory.Mechanical)).Value;
		}
		return ItemRepairCategory.Mechanical;
	}

	// Token: 0x0600AE32 RID: 44594 RVA: 0x003FBFFC File Offset: 0x003FA1FC
	public override dsk cv(cnm A_0)
	{
		return dsk.a;
	}

	// Token: 0x0600AE33 RID: 44595 RVA: 0x003FC000 File Offset: 0x003FA200
	protected override int br(cnm A_0)
	{
		return 2000;
	}

	// Token: 0x04004078 RID: 16504
	private new List<string> a;
}
