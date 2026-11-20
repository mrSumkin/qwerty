using System;

// Token: 0x02001C41 RID: 7233
[d29("TattooTheBeast", "Tattoo: The Beast")]
public sealed class bld : e33
{
	// Token: 0x06009EC7 RID: 40647 RVA: 0x003E2A78 File Offset: 0x003E0C78
	public bld() : base("Татуировка: Зверь")
	{
	}

	// Token: 0x06009EC8 RID: 40648 RVA: 0x003E2A88 File Offset: 0x003E0C88
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(bld.a * 100.0)
		};
	}

	// Token: 0x04003D83 RID: 15747
	public new static readonly double a = 0.1;
}
