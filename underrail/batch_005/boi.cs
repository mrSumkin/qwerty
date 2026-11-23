using System;

// Token: 0x02001DB5 RID: 7605
public sealed class boi : apq
{
	// Token: 0x0600A81A RID: 43034 RVA: 0x003EE768 File Offset: 0x003EC968
	public override Type e3()
	{
		return typeof(cmr);
	}

	// Token: 0x0600A81B RID: 43035 RVA: 0x003EE774 File Offset: 0x003EC974
	public override string e4()
	{
		return "GunNutDamage";
	}

	// Token: 0x0600A81C RID: 43036 RVA: 0x003EE77C File Offset: 0x003EC97C
	public override string e5()
	{
		return "Оружейник";
	}

	// Token: 0x0600A81D RID: 43037 RVA: 0x003EE784 File Offset: 0x003EC984
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A81E RID: 43038 RVA: 0x003EE788 File Offset: 0x003EC988
	public override object[] e7()
	{
		return new object[]
		{
			Math.Round(boi.a * 100.0, 1)
		};
	}

	// Token: 0x04003F0B RID: 16139
	public new static readonly double a = 0.02;
}
