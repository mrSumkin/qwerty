using System;
using System.Collections.Generic;

// Token: 0x02001CC0 RID: 7360
[d29("Parry", "Parry")]
public sealed class du9 : ai8
{
	// Token: 0x0600A167 RID: 41319 RVA: 0x003E76B4 File Offset: 0x003E58B4
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A168 RID: 41320 RVA: 0x003E76BC File Offset: 0x003E58BC
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A169 RID: 41321 RVA: 0x003E76C0 File Offset: 0x003E58C0
	public du9() : base("膣Парирование")
	{
	}

	// Token: 0x0600A16A RID: 41322 RVA: 0x003E76D0 File Offset: 0x003E58D0
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(du9.b * 100.0),
			Convert.ToInt32(du9.c * 100.0),
			du9.a
		};
	}

	// Token: 0x0600A16B RID: 41323 RVA: 0x003E7728 File Offset: 0x003E5928
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), du9.a),
			new bap(30, new Type[]
			{
				typeof(jk)
			})
		};
	}

	// Token: 0x04003E0C RID: 15884
	public new static readonly int a = 6;

	// Token: 0x04003E0D RID: 15885
	public new static readonly double b = 0.25;

	// Token: 0x04003E0E RID: 15886
	public static readonly double c = 0.03;

	// Token: 0x04003E0F RID: 15887
	public new static readonly double d = 1.0;

	// Token: 0x04003E10 RID: 15888
	public new static readonly double e = 2.0;
}
