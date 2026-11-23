using System;

// Token: 0x020006D3 RID: 1747
public sealed class bn3
{
	// Token: 0x06002CF4 RID: 11508 RVA: 0x00100A30 File Offset: 0x000FEC30
	public bn3(string A_0, float A_1 = 1f, b1g? A_2 = null, bbs? A_3 = null)
	{
		this.a = A_0;
		this.d = A_1;
		this.b = A_2;
		this.c = A_3;
	}

	// Token: 0x06002CF5 RID: 11509 RVA: 0x00100A58 File Offset: 0x000FEC58
	public string a()
	{
		return this.a;
	}

	// Token: 0x06002CF6 RID: 11510 RVA: 0x00100A60 File Offset: 0x000FEC60
	public b1g? b()
	{
		return this.b;
	}

	// Token: 0x06002CF7 RID: 11511 RVA: 0x00100A68 File Offset: 0x000FEC68
	public bbs? d()
	{
		return this.c;
	}

	// Token: 0x06002CF8 RID: 11512 RVA: 0x00100A70 File Offset: 0x000FEC70
	public float c()
	{
		return this.d;
	}

	// Token: 0x06002CF9 RID: 11513 RVA: 0x00100A7C File Offset: 0x000FEC7C
	public override bool Equals(object obj)
	{
		bn3 bn = obj as bn3;
		return bn != null && this.a() == bn.a();
	}

	// Token: 0x06002CFA RID: 11514 RVA: 0x00100AAC File Offset: 0x000FECAC
	public override int GetHashCode()
	{
		if (this.a != null)
		{
			return this.a.GetHashCode();
		}
		return 0;
	}

	// Token: 0x0400199D RID: 6557
	private string a;

	// Token: 0x0400199E RID: 6558
	private b1g? b;

	// Token: 0x0400199F RID: 6559
	private bbs? c;

	// Token: 0x040019A0 RID: 6560
	private float d;
}
