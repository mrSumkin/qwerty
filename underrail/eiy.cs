using System;

// Token: 0x02001D3D RID: 7485
public sealed class eiy : apq
{
	// Token: 0x0600A4DE RID: 42206 RVA: 0x003EC004 File Offset: 0x003EA204
	public override Type e3()
	{
		return typeof(du9);
	}

	// Token: 0x0600A4DF RID: 42207 RVA: 0x003EC010 File Offset: 0x003EA210
	public override string e4()
	{
		return "ParryBlockAmount";
	}

	// Token: 0x0600A4E0 RID: 42208 RVA: 0x003EC018 File Offset: 0x003EA218
	public override string e5()
	{
		return "Парирование: кол-во блока";
	}

	// Token: 0x0600A4E1 RID: 42209 RVA: 0x003EC020 File Offset: 0x003EA220
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A4E2 RID: 42210 RVA: 0x003EC024 File Offset: 0x003EA224
	public override object[] e7()
	{
		return new object[]
		{
			(int)(eiy.a * 100.0)
		};
	}

	// Token: 0x04003E97 RID: 16023
	public new static readonly double a = 0.05;
}
