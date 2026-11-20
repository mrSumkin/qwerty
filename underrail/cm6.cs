using System;
using System.Collections.Generic;

// Token: 0x02001CB5 RID: 7349
[d29("BoardingUp", "Boarding Up")]
public sealed class cm6 : ai8
{
	// Token: 0x0600A115 RID: 41237 RVA: 0x003E6ED0 File Offset: 0x003E50D0
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A116 RID: 41238 RVA: 0x003E6ED8 File Offset: 0x003E50D8
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A117 RID: 41239 RVA: 0x003E6EDC File Offset: 0x003E50DC
	public cm6() : base("膼За бордюром")
	{
	}

	// Token: 0x0600A118 RID: 41240 RVA: 0x003E6EEC File Offset: 0x003E50EC
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(cm6.a * 100.0),
			l4.a(cm6.c, false),
			cm6.b
		};
	}

	// Token: 0x0600A119 RID: 41241 RVA: 0x003E6F2C File Offset: 0x003E512C
	public static double a(efk A_0)
	{
		return cm6.a + (double)A_0.GetSpecializationValue<all>(true) * all.a;
	}

	// Token: 0x0600A11A RID: 41242 RVA: 0x003E6F44 File Offset: 0x003E5144
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(60, new Type[]
			{
				typeof(jk)
			})
		};
	}

	// Token: 0x04003DFA RID: 15866
	public new static readonly double a = 0.2;

	// Token: 0x04003DFB RID: 15867
	public new static readonly int b = 5;

	// Token: 0x04003DFC RID: 15868
	public static readonly int c = 3;
}
