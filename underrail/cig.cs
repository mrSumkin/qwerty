using System;

// Token: 0x02001D67 RID: 7527
public sealed class cig : apq
{
	// Token: 0x0600A5F8 RID: 42488 RVA: 0x003ECD24 File Offset: 0x003EAF24
	public override Type e3()
	{
		return typeof(dvu);
	}

	// Token: 0x0600A5F9 RID: 42489 RVA: 0x003ECD30 File Offset: 0x003EAF30
	public override string e4()
	{
		return "ShellShockSkillReduction";
	}

	// Token: 0x0600A5FA RID: 42490 RVA: 0x003ECD38 File Offset: 0x003EAF38
	public override string e5()
	{
		return "Взрывное потрясение: снижение навыков";
	}

	// Token: 0x0600A5FB RID: 42491 RVA: 0x003ECD40 File Offset: 0x003EAF40
	public override int e6()
	{
		return 4;
	}

	// Token: 0x0600A5FC RID: 42492 RVA: 0x003ECD44 File Offset: 0x003EAF44
	public override object[] e7()
	{
		return new object[]
		{
			cig.a.ToString("P1")
		};
	}

	// Token: 0x04003EBB RID: 16059
	public new static readonly float a = 0.005f;
}
