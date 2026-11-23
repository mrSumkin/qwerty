using System;

// Token: 0x020002CB RID: 715
[apc("passiveScanner")]
public class c5q : e1k
{
	// Token: 0x06001545 RID: 5445 RVA: 0x00062AA8 File Offset: 0x00060CA8
	public c5q()
	{
		this.a = new aij();
		this.b = new vw(new string[]
		{
			"Nb",
			"PriTarAct",
			"PriTarTr",
			"AdjRel"
		});
		this.a.a = this.b;
		this.b.a = this.a;
		base.b(this.b);
	}

	// Token: 0x04000BFD RID: 3069
	protected aij a;

	// Token: 0x04000BFE RID: 3070
	protected vw b;
}
