using System;
using System.Collections.Generic;

// Token: 0x02001C9F RID: 7327
[d29("FancyFootwork", "Fancy Footwork")]
public sealed class ebd : ai8
{
	// Token: 0x0600A09B RID: 41115 RVA: 0x003E5D88 File Offset: 0x003E3F88
	public ebd() : base("膷Работа ног")
	{
	}

	// Token: 0x0600A09C RID: 41116 RVA: 0x003E5D98 File Offset: 0x003E3F98
	public override object[] at()
	{
		return new object[]
		{
			ebd.a
		};
	}

	// Token: 0x0600A09D RID: 41117 RVA: 0x003E5DB0 File Offset: 0x003E3FB0
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(dqg), 7),
			new bap(40, new Type[]
			{
				typeof(jk)
			}),
			new bap(40, new Type[]
			{
				typeof(e74)
			})
		};
	}

	// Token: 0x04003DD9 RID: 15833
	public new static readonly int a = 8;

	// Token: 0x04003DDA RID: 15834
	public new static readonly int b = 1;

	// Token: 0x04003DDB RID: 15835
	public static readonly double c = 0.2;
}
