using System;

// Token: 0x02001D23 RID: 7459
public sealed class sx : apq
{
	// Token: 0x0600A428 RID: 42024 RVA: 0x003EB71C File Offset: 0x003E991C
	public override Type e3()
	{
		return typeof(alo);
	}

	// Token: 0x0600A429 RID: 42025 RVA: 0x003EB728 File Offset: 0x003E9928
	public override string e4()
	{
		return "ImprovedUnarmedCombatDazeChance";
	}

	// Token: 0x0600A42A RID: 42026 RVA: 0x003EB730 File Offset: 0x003E9930
	public override string e5()
	{
		return "Улучш. рукопашный бой: дезориентация";
	}

	// Token: 0x0600A42B RID: 42027 RVA: 0x003EB738 File Offset: 0x003E9938
	public override int e6()
	{
		return 3;
	}

	// Token: 0x0600A42C RID: 42028 RVA: 0x003EB73C File Offset: 0x003E993C
	public override object[] e7()
	{
		return new object[]
		{
			Convert.ToInt32(sx.a * 100.0)
		};
	}

	// Token: 0x04003E7C RID: 15996
	public new static readonly double a = 0.01;
}
