using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E71 RID: 7793
[ayj("VehicleRepairKit")]
public sealed class a1o : m0
{
	// Token: 0x0600AD6B RID: 44395 RVA: 0x003FB400 File Offset: 0x003F9600
	public override string y8()
	{
		return "VehicleRepairKit";
	}

	// Token: 0x0600AD6C RID: 44396 RVA: 0x003FB408 File Offset: 0x003F9608
	public override string os()
	{
		return "VehicleRepairKit";
	}

	// Token: 0x0600AD6D RID: 44397 RVA: 0x003FB410 File Offset: 0x003F9610
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600AD6E RID: 44398 RVA: 0x003FB414 File Offset: 0x003F9614
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.DisarmTrap);
	}

	// Token: 0x0600AD6F RID: 44399 RVA: 0x003FB420 File Offset: 0x003F9620
	public override string c1()
	{
		return "Ремонтирует";
	}

	// Token: 0x0600AD70 RID: 44400 RVA: 0x003FB428 File Offset: 0x003F9628
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600AD71 RID: 44401 RVA: 0x003FB42C File Offset: 0x003F962C
	public override bool q2()
	{
		return false;
	}

	// Token: 0x0600AD72 RID: 44402 RVA: 0x003FB430 File Offset: 0x003F9630
	public a1o()
	{
		this.a = new List<string>();
	}

	// Token: 0x0600AD73 RID: 44403 RVA: 0x003FB444 File Offset: 0x003F9644
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600AD74 RID: 44404 RVA: 0x003FB448 File Offset: 0x003F9648
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.RepairableVehicle;
	}

	// Token: 0x0600AD75 RID: 44405 RVA: 0x003FB450 File Offset: 0x003F9650
	public override string bo(cnm A_0)
	{
		return this.bp(A_0);
	}

	// Token: 0x0600AD76 RID: 44406 RVA: 0x003FB45C File Offset: 0x003F965C
	public override string bp(cnm A_0)
	{
		if (A_0 != null)
		{
			coh coh = A_0.b9() as coh;
			if (coh != null && coh.Definition != null)
			{
				int num = a1o.a(coh);
				return qv.a("Items\\RepairKits/Vehicle", new object[]
				{
					num
				});
			}
		}
		return string.Empty;
	}

	// Token: 0x0600AD77 RID: 44407 RVA: 0x003FB4B4 File Offset: 0x003F96B4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600AD78 RID: 44408 RVA: 0x003FB4BC File Offset: 0x003F96BC
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600AD79 RID: 44409 RVA: 0x003FB4C8 File Offset: 0x003F96C8
	public static int a(coh A_0)
	{
		if (A_0 != null)
		{
			return A_0.Definition.a7().GetPrimitivePropertyValue<int>("RepairAmount", new int?(0)).Value;
		}
		return 0;
	}

	// Token: 0x0600AD7A RID: 44410 RVA: 0x003FB500 File Offset: 0x003F9700
	public override dsk cv(cnm A_0)
	{
		return dsk.a;
	}

	// Token: 0x0600AD7B RID: 44411 RVA: 0x003FB504 File Offset: 0x003F9704
	protected override int br(cnm A_0)
	{
		return 5000;
	}

	// Token: 0x0600AD7C RID: 44412 RVA: 0x003FB50C File Offset: 0x003F970C
	protected override float f0(cnm A_0)
	{
		return 2.5f;
	}

	// Token: 0x0400406E RID: 16494
	private new List<string> a;
}
