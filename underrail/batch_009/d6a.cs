using System;
using System.Runtime.Serialization;

// Token: 0x020019FD RID: 6653
[eiz("MWCAS")]
[Serializable]
public sealed class d6a : d3e, ISerializable
{
	// Token: 0x06008F7C RID: 36732 RVA: 0x00397E74 File Offset: 0x00396074
	private d6a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetSingle("MWCAS:A");
		this.b = A_0.GetInt32("MWCAS:C");
		this.c = (cs5)A_0.GetValue("MWCAS:F", typeof(cs5));
	}

	// Token: 0x06008F7D RID: 36733 RVA: 0x00397ECC File Offset: 0x003960CC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MWCAS:A", this.a);
		info.AddValue("MWCAS:C", this.b);
		info.AddValue("MWCAS:F", this.c);
	}

	// Token: 0x06008F7E RID: 36734 RVA: 0x00397F1C File Offset: 0x0039611C
	public float c()
	{
		return this.a;
	}

	// Token: 0x06008F7F RID: 36735 RVA: 0x00397F24 File Offset: 0x00396124
	public void a(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008F80 RID: 36736 RVA: 0x00397F30 File Offset: 0x00396130
	public int b()
	{
		return this.b;
	}

	// Token: 0x06008F81 RID: 36737 RVA: 0x00397F38 File Offset: 0x00396138
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008F82 RID: 36738 RVA: 0x00397F44 File Offset: 0x00396144
	public cs5 a()
	{
		return this.c;
	}

	// Token: 0x06008F83 RID: 36739 RVA: 0x00397F4C File Offset: 0x0039614C
	public void a(cs5 A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06008F84 RID: 36740 RVA: 0x00397F58 File Offset: 0x00396158
	public d6a()
	{
	}

	// Token: 0x06008F85 RID: 36741 RVA: 0x00397F60 File Offset: 0x00396160
	public d6a(float A_0, int A_1, cs5 A_2)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x06008F86 RID: 36742 RVA: 0x00397F80 File Offset: 0x00396180
	public override string b2()
	{
		string arg = bsr.c(this.c);
		if (this.b >= 0)
		{
			return string.Format("Стоимость в очках действия атак {0} увеличена на {1}.", arg, this.b);
		}
		return string.Format("Стоимость в очках действия атак {0} уменьшена на {1}.", arg, Math.Abs(this.b));
	}

	// Token: 0x06008F87 RID: 36743 RVA: 0x00397FD8 File Offset: 0x003961D8
	public override d3e b3()
	{
		d6a d6a = new d6a();
		this.xx(d6a);
		return d6a;
	}

	// Token: 0x06008F88 RID: 36744 RVA: 0x00397FF4 File Offset: 0x003961F4
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		d6a d6a = (d6a)A_0;
		d6a.b = this.b;
		d6a.a = this.a;
		d6a.c = this.c;
	}

	// Token: 0x06008F89 RID: 36745 RVA: 0x0039802C File Offset: 0x0039622C
	protected override void @in(ll A_0)
	{
		if (A_0 != null && A_0.a() != null && euf.a(A_0.a().Offense.u(), this.c))
		{
			dcu dcu = A_0.a().Offense;
			dcu.a(dcu.ax() + this.a);
			dcu dcu2 = A_0.a().Offense;
			dcu2.e(dcu2.j() + this.b);
		}
	}

	// Token: 0x040037F5 RID: 14325
	private new float a;

	// Token: 0x040037F6 RID: 14326
	private int b;

	// Token: 0x040037F7 RID: 14327
	private cs5 c;
}
