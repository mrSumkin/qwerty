using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Capabilities.Psi;

// Token: 0x020019F1 RID: 6641
[eiz("MPACACE")]
[Serializable]
public sealed class a09 : cdh, d7s, ISerializable
{
	// Token: 0x06008EF0 RID: 36592 RVA: 0x00396C48 File Offset: 0x00394E48
	private a09(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (PsiAbilityCategories)A_0.GetValue("MPACACE:C", typeof(PsiAbilityCategories));
		this.b = A_0.GetDouble("MPACACE:M");
	}

	// Token: 0x06008EF1 RID: 36593 RVA: 0x00396C84 File Offset: 0x00394E84
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MPACACE:C", this.a);
		info.AddValue("MPACACE:M", this.b);
	}

	// Token: 0x06008EF2 RID: 36594 RVA: 0x00396CB8 File Offset: 0x00394EB8
	public PsiAbilityCategories a()
	{
		return this.a;
	}

	// Token: 0x06008EF3 RID: 36595 RVA: 0x00396CC0 File Offset: 0x00394EC0
	public void a(PsiAbilityCategories A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008EF4 RID: 36596 RVA: 0x00396CCC File Offset: 0x00394ECC
	public double b()
	{
		return this.b;
	}

	// Token: 0x06008EF5 RID: 36597 RVA: 0x00396CD4 File Offset: 0x00394ED4
	public void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008EF6 RID: 36598 RVA: 0x00396CE0 File Offset: 0x00394EE0
	public override bool ae5()
	{
		return this.b > 0.0;
	}

	// Token: 0x06008EF7 RID: 36599 RVA: 0x00396CF4 File Offset: 0x00394EF4
	public a09()
	{
	}

	// Token: 0x06008EF8 RID: 36600 RVA: 0x00396CFC File Offset: 0x00394EFC
	public a09(PsiAbilityCategories A_0, double A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06008EF9 RID: 36601 RVA: 0x00396D14 File Offset: 0x00394F14
	public void cn(d3e A_0)
	{
		a09 a = A_0 as a09;
		if (a != null)
		{
			this.b += a.b;
		}
	}

	// Token: 0x06008EFA RID: 36602 RVA: 0x00396D44 File Offset: 0x00394F44
	public bool co(d3e A_0)
	{
		a09 a = A_0 as a09;
		return a != null && a.a == this.a;
	}

	// Token: 0x06008EFB RID: 36603 RVA: 0x00396D70 File Offset: 0x00394F70
	public override string b2()
	{
		string text = b29.a(this.a, true);
		if (this.b < 0.0)
		{
			return qv.a("StaticEffects/ModifyPsiAbilityCategoriesApCost_Decreased", new object[]
			{
				text,
				Convert.ToInt32(Math.Abs(this.b * 100.0))
			});
		}
		return qv.a("StaticEffects/ModifyPsiAbilityCategoriesApCost_Increased", new object[]
		{
			text,
			Convert.ToInt32(this.b * 100.0)
		});
	}

	// Token: 0x06008EFC RID: 36604 RVA: 0x00396E08 File Offset: 0x00395008
	public override d3e b3()
	{
		a09 a = new a09();
		this.xx(a);
		return a;
	}

	// Token: 0x06008EFD RID: 36605 RVA: 0x00396E24 File Offset: 0x00395024
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		a09 a = (a09)A_0;
		a.a = this.a;
		a.b = this.b;
	}

	// Token: 0x040037E5 RID: 14309
	private new PsiAbilityCategories a;

	// Token: 0x040037E6 RID: 14310
	private double b;
}
