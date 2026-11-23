using System;

// Token: 0x02000BC7 RID: 3015
public sealed class cdu : eny
{
	// Token: 0x06004514 RID: 17684 RVA: 0x001C17A4 File Offset: 0x001BF9A4
	public override string mt()
	{
		return "aiScrambler";
	}

	// Token: 0x06004515 RID: 17685 RVA: 0x001C17AC File Offset: 0x001BF9AC
	public override int? mu()
	{
		return new int?(5);
	}

	// Token: 0x06004516 RID: 17686 RVA: 0x001C17B4 File Offset: 0x001BF9B4
	public override int? mv()
	{
		return new int?(15);
	}

	// Token: 0x06004517 RID: 17687 RVA: 0x001C17C0 File Offset: 0x001BF9C0
	public override void mw(coh A_0, int A_1)
	{
		int num = base.b(A_1);
		base.mw(A_0, num);
		cdk cdk = A_0.Definition as cdk;
		if (cdk != null)
		{
			int num2 = (int)d05.b(10.0, (double)(num * 2) * (0.75 + zp.a.NextDouble() * 0.5), 40.0);
			int value = 25 + num * 5;
			cdk.a7()["CortexScrambleHackingBonus"] = num2;
			cdk.c(new int?(value));
			base.a(cdk, num, 0.35);
		}
	}
}
