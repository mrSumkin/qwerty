using System;

// Token: 0x020007E4 RID: 2020
public abstract class iq : el4
{
	// Token: 0x0600329A RID: 12954 RVA: 0x0013A60C File Offset: 0x0013880C
	public override string a4()
	{
		return this.b + this.a.ToString();
	}

	// Token: 0x0600329B RID: 12955 RVA: 0x0013A624 File Offset: 0x00138824
	public override string a5()
	{
		return this.c + " " + this.a.ToString();
	}

	// Token: 0x0600329C RID: 12956 RVA: 0x0013A644 File Offset: 0x00138844
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x0600329D RID: 12957 RVA: 0x0013A648 File Offset: 0x00138848
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(60.0));
	}

	// Token: 0x0600329E RID: 12958 RVA: 0x0013A660 File Offset: 0x00138860
	public iq(int A_0, string A_1, string A_2, params string[] A_3) : base(A_3)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x0600329F RID: 12959 RVA: 0x0013A680 File Offset: 0x00138880
	protected int a(cyt A_0)
	{
		int num = A_0.h().BaseLevel;
		if (num == 0)
		{
			num = A_0.v().Level;
		}
		return Math.Max(1, num + cuo.a.Next(-3, 4));
	}

	// Token: 0x04001B1D RID: 6941
	private new int a;

	// Token: 0x04001B1E RID: 6942
	private string b;

	// Token: 0x04001B1F RID: 6943
	private new string c;
}
