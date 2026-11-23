using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Common;

// Token: 0x0200180D RID: 6157
public abstract class bon : ehl
{
	// Token: 0x060082E5 RID: 33509
	public abstract bool cs();

	// Token: 0x060082E6 RID: 33510
	public abstract int ct();

	// Token: 0x060082E7 RID: 33511 RVA: 0x0036D710 File Offset: 0x0036B910
	public override int bh()
	{
		return (this.cs() ? 0 : 1000) + this.ct();
	}

	// Token: 0x060082E8 RID: 33512 RVA: 0x0036D730 File Offset: 0x0036B930
	public virtual bool l8()
	{
		return true;
	}

	// Token: 0x060082E9 RID: 33513 RVA: 0x0036D734 File Offset: 0x0036B934
	public virtual bool i2()
	{
		return false;
	}

	// Token: 0x060082EA RID: 33514 RVA: 0x0036D738 File Offset: 0x0036B938
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.SpecialAttack);
	}

	// Token: 0x060082EB RID: 33515 RVA: 0x0036D740 File Offset: 0x0036B940
	public override string bp(cnm A_0)
	{
		return "Perform " + this.Name;
	}

	// Token: 0x060082EC RID: 33516 RVA: 0x0036D754 File Offset: 0x0036B954
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0.b8() != null && A_0.b8().Offense.u() != null) && (!this.i2() || Enumerable.Any<aia>(A_0.b8().Offense.u().TypedDefinition.@as(), new Func<aia, bool>(this.a))) && (!this.l8() || eub.a(A_0.b8().Offense.u()) || eub.b(A_0.b8(), A_0.b8().Offense.u()));
	}

	// Token: 0x060082ED RID: 33517 RVA: 0x0036D810 File Offset: 0x0036BA10
	public virtual double l9(cnm A_0, double A_1)
	{
		return 1.0;
	}

	// Token: 0x060082EE RID: 33518 RVA: 0x0036D81C File Offset: 0x0036BA1C
	public virtual double ajx(cnm A_0, double A_1, efk A_2, double A_3)
	{
		return A_1;
	}

	// Token: 0x060082EF RID: 33519 RVA: 0x0036D820 File Offset: 0x0036BA20
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x060082F0 RID: 33520 RVA: 0x0036D828 File Offset: 0x0036BA28
	public override int zb(eoj A_0)
	{
		if (A_0.b8() != null)
		{
			return A_0.b8().Offense.u().TypedDefinition.ah();
		}
		return 0;
	}

	// Token: 0x060082F1 RID: 33521 RVA: 0x0036D85C File Offset: 0x0036BA5C
	protected override int hi(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			return A_0.b8().Offense.av();
		}
		return 0;
	}

	// Token: 0x060082F2 RID: 33522 RVA: 0x0036D884 File Offset: 0x0036BA84
	protected override float f0(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null)
		{
			return A_0.b8().Offense.u().TypedDefinition.ad();
		}
		return as3.bk;
	}

	// Token: 0x060082F4 RID: 33524 RVA: 0x0036D8FC File Offset: 0x0036BAFC
	[CompilerGenerated]
	private bool a(aia A_0)
	{
		return A_0.Value == this;
	}
}
