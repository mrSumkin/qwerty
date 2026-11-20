using System;
using System.Runtime.Serialization;

// Token: 0x02001A03 RID: 6659
[eiz("MFAPASE")]
[Serializable]
public sealed class ek1 : d3e, ISerializable
{
	// Token: 0x06008FB6 RID: 36790 RVA: 0x0039872C File Offset: 0x0039692C
	private ek1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetSingle("MFAPASE:A");
		this.b = A_0.GetInt32("MFAPASE:P");
		this.c = A_0.GetInt32("MFAPASE:C");
	}

	// Token: 0x06008FB7 RID: 36791 RVA: 0x00398774 File Offset: 0x00396974
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MFAPASE:A", this.a);
		info.AddValue("MFAPASE:P", this.b);
		info.AddValue("MFAPASE:C", this.c);
	}

	// Token: 0x06008FB8 RID: 36792 RVA: 0x003987BC File Offset: 0x003969BC
	public float b()
	{
		return this.a;
	}

	// Token: 0x06008FB9 RID: 36793 RVA: 0x003987C4 File Offset: 0x003969C4
	public void a(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008FBA RID: 36794 RVA: 0x003987D0 File Offset: 0x003969D0
	public int a()
	{
		return this.c;
	}

	// Token: 0x06008FBB RID: 36795 RVA: 0x003987D8 File Offset: 0x003969D8
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06008FBC RID: 36796 RVA: 0x003987E4 File Offset: 0x003969E4
	public override bool ae5()
	{
		return this.c > 0;
	}

	// Token: 0x06008FBD RID: 36797 RVA: 0x003987F0 File Offset: 0x003969F0
	public ek1()
	{
	}

	// Token: 0x06008FBE RID: 36798 RVA: 0x003987F8 File Offset: 0x003969F8
	public ek1(float A_0, int A_1, int A_2 = 0)
	{
		this.a = A_0;
		this.c = A_1;
		this.b = A_2;
	}

	// Token: 0x06008FBF RID: 36799 RVA: 0x00398818 File Offset: 0x00396A18
	public override d3e b3()
	{
		bjo bjo = new bjo();
		this.xx(bjo);
		return bjo;
	}

	// Token: 0x06008FC0 RID: 36800 RVA: 0x00398834 File Offset: 0x00396A34
	public override string b2()
	{
		if (this.c >= 0)
		{
			return qv.a("StaticEffects/ModifyFirearmPistolsAttackSpeed_Increased", new object[]
			{
				this.c
			});
		}
		return qv.a("StaticEffects/ModifyFirearmPistolsAttackSpeed_Decreased", new object[]
		{
			Math.Abs(this.c)
		});
	}

	// Token: 0x06008FC1 RID: 36801 RVA: 0x00398890 File Offset: 0x00396A90
	protected override void @in(ll A_0)
	{
		if (A_0.a().Offense.u().TypedDefinition != null && A_0.a().Offense.u().TypedDefinition.e() == btz.a && euf.m(A_0.a().Offense.u()))
		{
			dcu dcu = A_0.a().Offense;
			dcu.a(dcu.ax() + this.a);
			dcu dcu2 = A_0.a().Offense;
			dcu2.e(dcu2.j() + this.c);
		}
	}

	// Token: 0x06008FC2 RID: 36802 RVA: 0x0039892C File Offset: 0x00396B2C
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		ek1 ek = (ek1)A_0;
		ek.c = this.c;
		ek.b = this.b;
		ek.a = this.a;
	}

	// Token: 0x040037FA RID: 14330
	private new float a;

	// Token: 0x040037FB RID: 14331
	private int b;

	// Token: 0x040037FC RID: 14332
	private int c;
}
