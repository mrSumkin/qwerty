using System;

// Token: 0x02001C3A RID: 7226
[d29("TattooAbomination", "Tattoo: Abomination")]
public sealed class bze : e33
{
	// Token: 0x06009EAC RID: 40620 RVA: 0x003E26DC File Offset: 0x003E08DC
	public bze() : base("Татуировка: Мерзость")
	{
	}

	// Token: 0x06009EAD RID: 40621 RVA: 0x003E26EC File Offset: 0x003E08EC
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(bze.a * 100.0)
		};
	}

	// Token: 0x04003D7B RID: 15739
	public new static readonly double a = 0.7;
}
