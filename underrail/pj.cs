using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020006AE RID: 1710
[eiz("RFSP")]
[Serializable]
public sealed class pj : ap
{
	// Token: 0x06002C50 RID: 11344 RVA: 0x000FDBE0 File Offset: 0x000FBDE0
	private pj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<string>("RFSP:C", ref this.a, A_0);
	}

	// Token: 0x06002C51 RID: 11345 RVA: 0x000FDC08 File Offset: 0x000FBE08
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<string>("RFSP:C", this.a, info);
	}

	// Token: 0x06002C52 RID: 11346 RVA: 0x000FDC24 File Offset: 0x000FBE24
	public List<string> a()
	{
		return this.a;
	}

	// Token: 0x06002C53 RID: 11347 RVA: 0x000FDC2C File Offset: 0x000FBE2C
	public void a(List<string> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002C54 RID: 11348 RVA: 0x000FDC38 File Offset: 0x000FBE38
	public pj()
	{
	}

	// Token: 0x06002C55 RID: 11349 RVA: 0x000FDC4C File Offset: 0x000FBE4C
	public override string ToString()
	{
		string text = base.c() + ": ";
		for (int i = 0; i < this.a.Count; i++)
		{
			if (this.a.Count >= 2 && i == this.a.Count - 1)
			{
				text += " или ";
			}
			text += this.a[i];
			if (this.a.Count > 2 && i < this.a.Count - 1)
			{
				text += ", ";
			}
		}
		return text;
	}

	// Token: 0x06002C56 RID: 11350 RVA: 0x000FDCFC File Offset: 0x000FBEFC
	public override object j1(Random A_0)
	{
		Random random = A_0 ?? new Random();
		return this.a[random.Next(this.a.Count)];
	}

	// Token: 0x0400192A RID: 6442
	private new List<string> a = new List<string>();
}
