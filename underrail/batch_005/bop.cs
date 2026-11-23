using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.Space;

// Token: 0x020011CD RID: 4557
[eiz("RLET")]
[Serializable]
public sealed class bop : ya, ISerializable
{
	// Token: 0x060061BB RID: 25019 RVA: 0x002A7360 File Offset: 0x002A5560
	private bop(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<string>("RLET:C", ref this.a, A_0);
		if (ell.a() >= 441)
		{
			this.b = (A_0.GetValue("RLET:D", typeof(HorizontalDirection?)) as HorizontalDirection?);
		}
		if (ell.a() >= 449)
		{
			this.c = A_0.GetBoolean("RLET:WS");
			this.d = A_0.GetBoolean("RLET:WN");
			this.e = A_0.GetBoolean("RLET:WE");
			this.f = A_0.GetBoolean("RLET:WW");
		}
		if (ell.a() >= 461)
		{
			this.g = (A_0.GetValue("RLET:S", typeof(bool?)) as bool?);
		}
	}

	// Token: 0x060061BC RID: 25020 RVA: 0x002A744C File Offset: 0x002A564C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<string>("RLET:C", this.a, info);
		info.AddValue("RLET:D", this.b);
		info.AddValue("RLET:WS", this.c);
		info.AddValue("RLET:WN", this.d);
		info.AddValue("RLET:WE", this.e);
		info.AddValue("RLET:WW", this.f);
		info.AddValue("RLET:S", this.g);
	}

	// Token: 0x060061BD RID: 25021 RVA: 0x002A74E4 File Offset: 0x002A56E4
	public List<string> g()
	{
		return this.a;
	}

	// Token: 0x060061BE RID: 25022 RVA: 0x002A74EC File Offset: 0x002A56EC
	public void a(List<string> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060061BF RID: 25023 RVA: 0x002A74F8 File Offset: 0x002A56F8
	public HorizontalDirection? e()
	{
		return this.b;
	}

	// Token: 0x060061C0 RID: 25024 RVA: 0x002A7500 File Offset: 0x002A5700
	public void a(HorizontalDirection? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060061C1 RID: 25025 RVA: 0x002A750C File Offset: 0x002A570C
	public bool c()
	{
		return this.c;
	}

	// Token: 0x060061C2 RID: 25026 RVA: 0x002A7514 File Offset: 0x002A5714
	public void d(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060061C3 RID: 25027 RVA: 0x002A7520 File Offset: 0x002A5720
	public bool f()
	{
		return this.d;
	}

	// Token: 0x060061C4 RID: 25028 RVA: 0x002A7528 File Offset: 0x002A5728
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060061C5 RID: 25029 RVA: 0x002A7534 File Offset: 0x002A5734
	public bool d()
	{
		return this.e;
	}

	// Token: 0x060061C6 RID: 25030 RVA: 0x002A753C File Offset: 0x002A573C
	public void c(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060061C7 RID: 25031 RVA: 0x002A7548 File Offset: 0x002A5748
	public bool a()
	{
		return this.f;
	}

	// Token: 0x060061C8 RID: 25032 RVA: 0x002A7550 File Offset: 0x002A5750
	public void b(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060061C9 RID: 25033 RVA: 0x002A755C File Offset: 0x002A575C
	public bool? b()
	{
		return this.g;
	}

	// Token: 0x060061CA RID: 25034 RVA: 0x002A7564 File Offset: 0x002A5764
	public void a(bool? A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060061CB RID: 25035 RVA: 0x002A7570 File Offset: 0x002A5770
	public bop()
	{
	}

	// Token: 0x04002980 RID: 10624
	private List<string> a = new List<string>();

	// Token: 0x04002981 RID: 10625
	private HorizontalDirection? b;

	// Token: 0x04002982 RID: 10626
	private bool c;

	// Token: 0x04002983 RID: 10627
	private new bool d;

	// Token: 0x04002984 RID: 10628
	private new bool e;

	// Token: 0x04002985 RID: 10629
	private new bool f;

	// Token: 0x04002986 RID: 10630
	private new bool? g;
}
