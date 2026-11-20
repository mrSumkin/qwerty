using System;
using System.Collections.Generic;

// Token: 0x02001CBD RID: 7357
[d29("JetAndJab", "Jet 'n' Jab")]
public sealed class cyz : ai8
{
	// Token: 0x0600A14F RID: 41295 RVA: 0x003E7484 File Offset: 0x003E5684
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A150 RID: 41296 RVA: 0x003E748C File Offset: 0x003E568C
	public override bool aq()
	{
		return false;
	}

	// Token: 0x0600A151 RID: 41297 RVA: 0x003E7490 File Offset: 0x003E5690
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A152 RID: 41298 RVA: 0x003E7494 File Offset: 0x003E5694
	public cyz() : base("Газ и джеб")
	{
	}

	// Token: 0x0600A153 RID: 41299 RVA: 0x003E74A4 File Offset: 0x003E56A4
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(as3.bw * 100.0)
		};
	}

	// Token: 0x0600A154 RID: 41300 RVA: 0x003E74C8 File Offset: 0x003E56C8
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(50, new Type[]
			{
				typeof(jk)
			}),
			new b4k(new Type[]
			{
				typeof(ej3)
			})
		};
	}
}
