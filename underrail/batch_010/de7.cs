using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Capabilities.Psi;

// Token: 0x020019F0 RID: 6640
[eiz("MPACPCE")]
[Serializable]
public sealed class de7 : cdh, d7s, ISerializable
{
	// Token: 0x06008EE2 RID: 36578 RVA: 0x00396A40 File Offset: 0x00394C40
	private de7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (PsiAbilityCategories)A_0.GetValue("MPACACE:C", typeof(PsiAbilityCategories));
		this.b = A_0.GetDouble("MPACACE:M");
	}

	// Token: 0x06008EE3 RID: 36579 RVA: 0x00396A7C File Offset: 0x00394C7C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MPACACE:C", this.a);
		info.AddValue("MPACACE:M", this.b);
	}

	// Token: 0x06008EE4 RID: 36580 RVA: 0x00396AB0 File Offset: 0x00394CB0
	public PsiAbilityCategories a()
	{
		return this.a;
	}

	// Token: 0x06008EE5 RID: 36581 RVA: 0x00396AB8 File Offset: 0x00394CB8
	public void a(PsiAbilityCategories A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008EE6 RID: 36582 RVA: 0x00396AC4 File Offset: 0x00394CC4
	public double b()
	{
		return this.b;
	}

	// Token: 0x06008EE7 RID: 36583 RVA: 0x00396ACC File Offset: 0x00394CCC
	public void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008EE8 RID: 36584 RVA: 0x00396AD8 File Offset: 0x00394CD8
	public override bool ae5()
	{
		return this.b > 0.0;
	}

	// Token: 0x06008EE9 RID: 36585 RVA: 0x00396AEC File Offset: 0x00394CEC
	public de7()
	{
	}

	// Token: 0x06008EEA RID: 36586 RVA: 0x00396AF4 File Offset: 0x00394CF4
	public de7(PsiAbilityCategories A_0, double A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06008EEB RID: 36587 RVA: 0x00396B10 File Offset: 0x00394D10
	public void cn(d3e A_0)
	{
		de7 de = A_0 as de7;
		if (de != null)
		{
			this.b += de.b;
		}
	}

	// Token: 0x06008EEC RID: 36588 RVA: 0x00396B40 File Offset: 0x00394D40
	public bool co(d3e A_0)
	{
		de7 de = A_0 as de7;
		return de != null && de.a == this.a;
	}

	// Token: 0x06008EED RID: 36589 RVA: 0x00396B6C File Offset: 0x00394D6C
	public override string b2()
	{
		string text = b29.a(this.a, true);
		if (this.b < 0.0)
		{
			return qv.a("StaticEffects/ModifyPsiAbilityCategoriesPsiCost_Decreased", new object[]
			{
				text,
				Convert.ToInt32(Math.Abs(this.b * 100.0))
			});
		}
		return qv.a("StaticEffects/ModifyPsiAbilityCategoriesPsiCost_Increased", new object[]
		{
			text,
			Convert.ToInt32(this.b * 100.0)
		});
	}

	// Token: 0x06008EEE RID: 36590 RVA: 0x00396C04 File Offset: 0x00394E04
	public override d3e b3()
	{
		de7 de = new de7();
		this.xx(de);
		return de;
	}

	// Token: 0x06008EEF RID: 36591 RVA: 0x00396C20 File Offset: 0x00394E20
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		de7 de = (de7)A_0;
		de.a = this.a;
		de.b = this.b;
	}

	// Token: 0x040037E3 RID: 14307
	private new PsiAbilityCategories a;

	// Token: 0x040037E4 RID: 14308
	private double b;
}
