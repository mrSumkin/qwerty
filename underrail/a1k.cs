using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200195D RID: 6493
[eiz("CI")]
[elw(typeof(fv))]
[Serializable]
public class a1k : bk3, ISerializable
{
	// Token: 0x06008ABE RID: 35518 RVA: 0x0038D9E8 File Offset: 0x0038BBE8
	protected a1k(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<b8w>("CI:SR", ref this.a, A_0);
			di7.ReadList<eu3>("CI:SB", ref this.b, A_0);
			this.c = (ms)A_0.GetValue("CI:CT", typeof(ms));
			if (ell.a() >= 23)
			{
				this.d = A_0.GetInt32("CI:BV");
				this.e = A_0.GetDouble("CI:AVPQ");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(a1k))
			{
				this.a = (List<b8w>)A_0.GetValue("_SkillRequirements", typeof(List<b8w>));
				this.b = (List<eu3>)A_0.GetValue("_SkillBonuses", typeof(List<eu3>));
				this.c = (ms)A_0.GetValue("_ComponentType", typeof(ms));
				return;
			}
			this.a = (List<b8w>)A_0.GetValue("ComponentItem+_SkillRequirements", typeof(List<b8w>));
			this.b = (List<eu3>)A_0.GetValue("ComponentItem+_SkillBonuses", typeof(List<eu3>));
			this.c = (ms)A_0.GetValue("ComponentItem+_ComponentType", typeof(ms));
		}
	}

	// Token: 0x06008ABF RID: 35519 RVA: 0x0038DB6C File Offset: 0x0038BD6C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<b8w>("CI:SR", this.a, info);
		di7.WriteList<eu3>("CI:SB", this.b, info);
		info.AddValue("CI:CT", this.c);
		info.AddValue("CI:BV", this.d);
		info.AddValue("CI:AVPQ", this.e);
	}

	// Token: 0x06008AC0 RID: 35520 RVA: 0x0038DBDC File Offset: 0x0038BDDC
	public List<b8w> g()
	{
		return this.a;
	}

	// Token: 0x06008AC1 RID: 35521 RVA: 0x0038DBE4 File Offset: 0x0038BDE4
	public override string tv()
	{
		return "Компонент";
	}

	// Token: 0x06008AC2 RID: 35522 RVA: 0x0038DBEC File Offset: 0x0038BDEC
	public List<eu3> j()
	{
		return this.b;
	}

	// Token: 0x06008AC3 RID: 35523 RVA: 0x0038DBF4 File Offset: 0x0038BDF4
	public ms i()
	{
		return this.c;
	}

	// Token: 0x06008AC4 RID: 35524 RVA: 0x0038DBFC File Offset: 0x0038BDFC
	public new void a(ms A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06008AC5 RID: 35525 RVA: 0x0038DC08 File Offset: 0x0038BE08
	public int k()
	{
		return this.d;
	}

	// Token: 0x06008AC6 RID: 35526 RVA: 0x0038DC10 File Offset: 0x0038BE10
	public void b(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06008AC7 RID: 35527 RVA: 0x0038DC1C File Offset: 0x0038BE1C
	public double h()
	{
		return this.e;
	}

	// Token: 0x06008AC8 RID: 35528 RVA: 0x0038DC24 File Offset: 0x0038BE24
	public void b(double A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06008AC9 RID: 35529 RVA: 0x0038DC30 File Offset: 0x0038BE30
	public a1k()
	{
	}

	// Token: 0x06008ACA RID: 35530 RVA: 0x0038DC50 File Offset: 0x0038BE50
	public override bk3 tw()
	{
		a1k a1k = new a1k();
		this.ai7(a1k);
		return a1k;
	}

	// Token: 0x06008ACB RID: 35531 RVA: 0x0038DC6C File Offset: 0x0038BE6C
	public override int tj(coh A_0)
	{
		fv fv = A_0 as fv;
		if (fv != null)
		{
			return this.d + Convert.ToInt32((double)fv.QualityLevel * this.e);
		}
		return base.tj(A_0);
	}

	// Token: 0x06008ACC RID: 35532 RVA: 0x0038DCA8 File Offset: 0x0038BEA8
	protected override void ai7(bk3 A_0)
	{
		base.ai7(A_0);
		a1k a1k = A_0 as a1k;
		if (a1k != null)
		{
			if (this.a != null)
			{
				if (a1k.a == null)
				{
					a1k.a = new List<b8w>();
				}
				a1k.a.AddRange(this.a);
			}
			else
			{
				a1k.a = null;
			}
			if (this.b != null)
			{
				if (a1k.b == null)
				{
					a1k.b = new List<eu3>();
				}
				a1k.b.AddRange(this.b);
			}
			else
			{
				a1k.b = null;
			}
			a1k.c = this.c;
			a1k.e = this.e;
			a1k.d = this.d;
		}
	}

	// Token: 0x0400371C RID: 14108
	private new List<b8w> a = new List<b8w>();

	// Token: 0x0400371D RID: 14109
	private List<eu3> b = new List<eu3>();

	// Token: 0x0400371E RID: 14110
	private ms c;

	// Token: 0x0400371F RID: 14111
	private int d;

	// Token: 0x04003720 RID: 14112
	private double e;
}
