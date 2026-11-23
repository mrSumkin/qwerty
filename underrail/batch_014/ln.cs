using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Rules;

// Token: 0x02001266 RID: 4710
[eiz("XCEA")]
[Serializable]
public sealed class ln : Aspect<c5x>, ISerializable
{
	// Token: 0x06006605 RID: 26117 RVA: 0x002B6760 File Offset: 0x002B4960
	private ln(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("XCEA:D", typeof(GameDifficulty?)) as GameDifficulty?);
		this.c = A_0.GetString("XCEA:L");
		if (ell.a() >= 440)
		{
			this.b = (A_0.GetValue("XCEA:M", typeof(GameDifficulty?)) as GameDifficulty?);
		}
		if (ell.a() >= 468)
		{
			this.d = A_0.GetBoolean("XCEA:I");
			this.e = A_0.GetDouble("XCEA:C");
		}
		else
		{
			this.e = 1.0;
		}
		if (ell.a() >= 499)
		{
			this.f = (A_0.GetValue("XCEA:N", typeof(dth)) as dth);
		}
	}

	// Token: 0x06006606 RID: 26118 RVA: 0x002B6864 File Offset: 0x002B4A64
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XCEA:D", this.a);
		info.AddValue("XCEA:L", this.c);
		info.AddValue("XCEA:M", this.b);
		info.AddValue("XCEA:I", this.d);
		info.AddValue("XCEA:C", this.e);
		info.AddValue("XCEA:N", this.f);
	}

	// Token: 0x06006607 RID: 26119 RVA: 0x002B68EC File Offset: 0x002B4AEC
	public GameDifficulty? a()
	{
		return this.a;
	}

	// Token: 0x06006608 RID: 26120 RVA: 0x002B68F4 File Offset: 0x002B4AF4
	public void b(GameDifficulty? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006609 RID: 26121 RVA: 0x002B6900 File Offset: 0x002B4B00
	public GameDifficulty? g()
	{
		return this.b;
	}

	// Token: 0x0600660A RID: 26122 RVA: 0x002B6908 File Offset: 0x002B4B08
	public void a(GameDifficulty? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600660B RID: 26123 RVA: 0x002B6914 File Offset: 0x002B4B14
	public string d()
	{
		return this.c;
	}

	// Token: 0x0600660C RID: 26124 RVA: 0x002B691C File Offset: 0x002B4B1C
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600660D RID: 26125 RVA: 0x002B6928 File Offset: 0x002B4B28
	public bool b()
	{
		return this.d;
	}

	// Token: 0x0600660E RID: 26126 RVA: 0x002B6930 File Offset: 0x002B4B30
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600660F RID: 26127 RVA: 0x002B693C File Offset: 0x002B4B3C
	public double e()
	{
		return this.e;
	}

	// Token: 0x06006610 RID: 26128 RVA: 0x002B6944 File Offset: 0x002B4B44
	public void a(double A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006611 RID: 26129 RVA: 0x002B6950 File Offset: 0x002B4B50
	public dth f()
	{
		return this.f;
	}

	// Token: 0x06006612 RID: 26130 RVA: 0x002B6958 File Offset: 0x002B4B58
	public void a(dth A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06006613 RID: 26131 RVA: 0x002B6964 File Offset: 0x002B4B64
	public ln(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x04002A65 RID: 10853
	private GameDifficulty? a;

	// Token: 0x04002A66 RID: 10854
	private GameDifficulty? b;

	// Token: 0x04002A67 RID: 10855
	private string c;

	// Token: 0x04002A68 RID: 10856
	private bool d;

	// Token: 0x04002A69 RID: 10857
	private double e = 1.0;

	// Token: 0x04002A6A RID: 10858
	private dth f;
}
