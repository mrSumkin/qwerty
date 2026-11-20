using System;

// Token: 0x02001D30 RID: 7472
public sealed class be5 : apq
{
	// Token: 0x0600A483 RID: 42115 RVA: 0x003EBB8C File Offset: 0x003E9D8C
	public override Type e3()
	{
		return typeof(crq);
	}

	// Token: 0x0600A484 RID: 42116 RVA: 0x003EBB98 File Offset: 0x003E9D98
	public override string e4()
	{
		return "FullAutoDamage";
	}

	// Token: 0x0600A485 RID: 42117 RVA: 0x003EBBA0 File Offset: 0x003E9DA0
	public override string e5()
	{
		return "Автоматич. огонь: пулемёт";
	}

	// Token: 0x0600A486 RID: 42118 RVA: 0x003EBBA8 File Offset: 0x003E9DA8
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A487 RID: 42119 RVA: 0x003EBBAC File Offset: 0x003E9DAC
	public override object[] e7()
	{
		return new object[]
		{
			(int)(be5.a * 100.0)
		};
	}

	// Token: 0x04003E89 RID: 16009
	public new static readonly double a = 0.03;
}
