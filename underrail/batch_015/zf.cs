using System;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001E03 RID: 7683
[d29("O", "Opportunist")]
public sealed class zf : ai8
{
	// Token: 0x0600AA1D RID: 43549 RVA: 0x003F33A8 File Offset: 0x003F15A8
	public zf() : base("胥Оппортунист")
	{
	}

	// Token: 0x0600AA1E RID: 43550 RVA: 0x003F33B8 File Offset: 0x003F15B8
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600AA1F RID: 43551 RVA: 0x003F33BC File Offset: 0x003F15BC
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600AA20 RID: 43552 RVA: 0x003F33C0 File Offset: 0x003F15C0
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(zf.a * 100.0),
			Convert.ToInt32(zf.b * 100.0)
		};
	}

	// Token: 0x0600AA21 RID: 43553 RVA: 0x003F3404 File Offset: 0x003F1604
	public static double a(efk A_0, efk A_1, ref c3u A_2)
	{
		double result = 0.0;
		if ((A_1.SpecialStates.b && (A_1.ImmunitiesBase & CharacterImmunities.Root) == CharacterImmunities.None) || A_1.SpecialStates.a || A_1.SpecialStates.c)
		{
			result = zf.a + (double)A_0.GetSpecializationValue<d6q>(true) * d6q.a;
			A_2 |= c3u.d;
		}
		else if (A_1.MovementSpeed < A_1.BaseMovementSpeed)
		{
			result = zf.b + (double)A_0.GetSpecializationValue<c70>(true) * c70.a;
			A_2 |= c3u.c;
		}
		return result;
	}

	// Token: 0x0600AA22 RID: 43554 RVA: 0x003F34AC File Offset: 0x003F16AC
	protected override string nq()
	{
		if (dk2.e())
		{
			return "XPHW";
		}
		return null;
	}

	// Token: 0x04003FB3 RID: 16307
	public new static readonly double a = 0.25;

	// Token: 0x04003FB4 RID: 16308
	public new static readonly double b = 0.15;
}
