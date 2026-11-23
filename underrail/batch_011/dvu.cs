using System;
using System.Collections.Generic;

// Token: 0x02001CE0 RID: 7392
[d29("ShellShock", "Shell Shock")]
public sealed class dvu : ai8
{
	// Token: 0x0600A251 RID: 41553 RVA: 0x003E8F84 File Offset: 0x003E7184
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A252 RID: 41554 RVA: 0x003E8F88 File Offset: 0x003E7188
	public override string au()
	{
		return "xphw";
	}

	// Token: 0x0600A253 RID: 41555 RVA: 0x003E8F90 File Offset: 0x003E7190
	public dvu() : base("胭Взрывное потрясение")
	{
	}

	// Token: 0x0600A254 RID: 41556 RVA: 0x003E8FA0 File Offset: 0x003E71A0
	public static float c(efk A_0)
	{
		float num = dvu.a;
		if (A_0 != null)
		{
			num += (float)A_0.GetSpecializationValue<cig>(true) * cig.a;
		}
		return num;
	}

	// Token: 0x0600A255 RID: 41557 RVA: 0x003E8FCC File Offset: 0x003E71CC
	public static int b(efk A_0)
	{
		int num = dvu.b;
		if (A_0 != null)
		{
			num += A_0.GetSpecializationValue<b1t>(true);
		}
		return num;
	}

	// Token: 0x0600A256 RID: 41558 RVA: 0x003E8FF0 File Offset: 0x003E71F0
	public static int a(efk A_0)
	{
		int num = dvu.c;
		if (A_0 != null)
		{
			num += A_0.GetSpecializationValue<ava>(true);
		}
		return num;
	}

	// Token: 0x0600A257 RID: 41559 RVA: 0x003E9014 File Offset: 0x003E7214
	public override object[] at()
	{
		return new object[]
		{
			dvu.a.ToString("P0"),
			l4.a(dvu.c, false),
			dvu.b
		};
	}

	// Token: 0x0600A258 RID: 41560 RVA: 0x003E9058 File Offset: 0x003E7258
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(60, new Type[]
			{
				typeof(ct7),
				typeof(e8k)
			}),
			new bap(40, new Type[]
			{
				typeof(bec)
			})
		};
	}

	// Token: 0x04003E34 RID: 15924
	public new static readonly float a = 0.04f;

	// Token: 0x04003E35 RID: 15925
	public new static readonly int b = 5;

	// Token: 0x04003E36 RID: 15926
	public static readonly int c = 3;
}
