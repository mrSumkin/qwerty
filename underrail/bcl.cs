using System;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000FA6 RID: 4006
[ayj("RechargeObject")]
public sealed class bcl : c0r
{
	// Token: 0x060051D5 RID: 20949 RVA: 0x0024C6BC File Offset: 0x0024A8BC
	public override string y8()
	{
		return "Зарядить объект";
	}

	// Token: 0x060051D6 RID: 20950 RVA: 0x0024C6C4 File Offset: 0x0024A8C4
	public override string c1()
	{
		return "Заряжает";
	}

	// Token: 0x060051D7 RID: 20951 RVA: 0x0024C6CC File Offset: 0x0024A8CC
	public override string os()
	{
		return "RechargeObject";
	}

	// Token: 0x060051D8 RID: 20952 RVA: 0x0024C6D4 File Offset: 0x0024A8D4
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x060051D9 RID: 20953 RVA: 0x0024C6D8 File Offset: 0x0024A8D8
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x060051DA RID: 20954 RVA: 0x0024C6EC File Offset: 0x0024A8EC
	public override TimelapseCursor? wz(object A_0, bool A_1 = false)
	{
		if (A_1)
		{
			return new TimelapseCursor?(TimelapseCursor.ForbiddenPower);
		}
		return new TimelapseCursor?(TimelapseCursor.Power);
	}

	// Token: 0x060051DB RID: 20955 RVA: 0x0024C704 File Offset: 0x0024A904
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x060051DC RID: 20956 RVA: 0x0024C708 File Offset: 0x0024A908
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.EnergyStorageObject;
	}

	// Token: 0x060051DD RID: 20957 RVA: 0x0024C70C File Offset: 0x0024A90C
	public override string bm(cnm A_0)
	{
		return "Energy.RechargeObject";
	}

	// Token: 0x060051DE RID: 20958 RVA: 0x0024C714 File Offset: 0x0024A914
	public override string bo(cnm A_0)
	{
		return this.bp(A_0);
	}

	// Token: 0x060051DF RID: 20959 RVA: 0x0024C720 File Offset: 0x0024A920
	public override string bp(cnm A_0)
	{
		int num = bcl.a(A_0);
		return qv.a("Items\\Consumables/RestoreObjectEnergy", new object[]
		{
			num
		});
	}

	// Token: 0x060051E0 RID: 20960 RVA: 0x0024C750 File Offset: 0x0024A950
	public new static int a(cnm A_0)
	{
		coh coh = ehl.a(A_0);
		if (coh != null)
		{
			return coh.Definition.a7().GetPrimitivePropertyValue<int>(vo.g, new int?(0)).Value;
		}
		return 0;
	}

	// Token: 0x060051E1 RID: 20961 RVA: 0x0024C790 File Offset: 0x0024A990
	protected override int br(cnm A_0)
	{
		return 3000;
	}

	// Token: 0x060051E2 RID: 20962 RVA: 0x0024C798 File Offset: 0x0024A998
	protected override int hi(cnm A_0)
	{
		return 40;
	}

	// Token: 0x060051E3 RID: 20963 RVA: 0x0024C7A0 File Offset: 0x0024A9A0
	protected override float f0(cnm A_0)
	{
		if (A_0 != null)
		{
			c5x c5x = A_0.ca() as c5x;
			if (c5x != null && c5x.s.b != null)
			{
				return c5x.s.b.ac();
			}
		}
		return 1.75f;
	}

	// Token: 0x0400218C RID: 8588
	internal new const int a = 3000;
}
