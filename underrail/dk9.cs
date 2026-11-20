using System;

// Token: 0x02001D43 RID: 7491
public sealed class dk9 : apq
{
	// Token: 0x0600A508 RID: 42248 RVA: 0x003EC214 File Offset: 0x003EA414
	public override Type e3()
	{
		return typeof(u3);
	}

	// Token: 0x0600A509 RID: 42249 RVA: 0x003EC220 File Offset: 0x003EA420
	public override string e4()
	{
		return "RiposteCritChance";
	}

	// Token: 0x0600A50A RID: 42250 RVA: 0x003EC228 File Offset: 0x003EA428
	public override string e5()
	{
		return "Ответный удар";
	}

	// Token: 0x0600A50B RID: 42251 RVA: 0x003EC230 File Offset: 0x003EA430
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A50C RID: 42252 RVA: 0x003EC234 File Offset: 0x003EA434
	public override object[] e7()
	{
		return new object[]
		{
			(int)(dk9.a * 100.0)
		};
	}

	// Token: 0x04003E9D RID: 16029
	public new static readonly double a = 0.03;
}
