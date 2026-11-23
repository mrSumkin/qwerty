using System;

// Token: 0x02001D44 RID: 7492
public sealed class b5d : apq
{
	// Token: 0x0600A50F RID: 42255 RVA: 0x003EC26C File Offset: 0x003EA46C
	public override Type e3()
	{
		return typeof(bdn);
	}

	// Token: 0x0600A510 RID: 42256 RVA: 0x003EC278 File Offset: 0x003EA478
	public override string e4()
	{
		return "DecapitateDamage";
	}

	// Token: 0x0600A511 RID: 42257 RVA: 0x003EC280 File Offset: 0x003EA480
	public override string e5()
	{
		return "Обезглавливание: урон";
	}

	// Token: 0x0600A512 RID: 42258 RVA: 0x003EC288 File Offset: 0x003EA488
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A513 RID: 42259 RVA: 0x003EC28C File Offset: 0x003EA48C
	public override object[] e7()
	{
		return new object[]
		{
			(int)(b5d.a * 100.0)
		};
	}

	// Token: 0x04003E9E RID: 16030
	public new static readonly double a = 0.1;
}
