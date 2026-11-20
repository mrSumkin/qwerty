using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001961 RID: 6497
[eiz("ABCI")]
[Serializable]
public class ett : a1k, ISerializable
{
	// Token: 0x06008AE8 RID: 35560 RVA: 0x0038E1B0 File Offset: 0x0038C3B0
	protected ett(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<bt5>("ABCI:DRF", ref this.a, A_0);
			if (ell.a() >= 91)
			{
				this.b = A_0.GetDouble("ABCI:E");
			}
			else
			{
				this.b = (double)A_0.GetSingle("ABCI:E");
			}
			if (ell.a() >= 90)
			{
				di7.ReadList<c3e>("ABCI:M", ref this.c, A_0);
			}
			else
			{
				this.c = new List<c3e>();
			}
			if (ell.a() >= 96)
			{
				this.d = A_0.GetInt32("ABCI:S");
			}
			if (ell.a() >= 187)
			{
				di7.ReadList<d3e>("ABCI:SE", ref this.e, A_0);
				di7.ReadList<wq>("ABCI:DE", ref this.f, A_0);
				return;
			}
			this.e = new List<d3e>();
			this.f = new List<wq>();
			return;
		}
		else
		{
			if (base.GetType() == typeof(ett))
			{
				this.a = (List<bt5>)A_0.GetValue("_DamageResistanceFactors", typeof(List<bt5>));
				this.b = (double)A_0.GetSingle("_Encumbrance");
				return;
			}
			this.a = (List<bt5>)A_0.GetValue("ArmorBaseComponentItem+_DamageResistanceFactors", typeof(List<bt5>));
			this.b = (double)A_0.GetSingle("ArmorBaseComponentItem+_Encumbrance");
			return;
		}
	}

	// Token: 0x06008AE9 RID: 35561 RVA: 0x0038E354 File Offset: 0x0038C554
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<bt5>("ABCI:DRF", this.a, info);
		info.AddValue("ABCI:E", this.b);
		di7.WriteList<c3e>("ABCI:M", this.c, info);
		info.AddValue("ABCI:S", this.d);
		di7.WriteList<d3e>("ABCI:SE", this.e, info);
		di7.WriteList<wq>("ABCI:DE", this.f, info);
	}

	// Token: 0x06008AEA RID: 35562 RVA: 0x0038E3D0 File Offset: 0x0038C5D0
	public List<bt5> d()
	{
		return this.a;
	}

	// Token: 0x06008AEB RID: 35563 RVA: 0x0038E3D8 File Offset: 0x0038C5D8
	public double f()
	{
		return this.b;
	}

	// Token: 0x06008AEC RID: 35564 RVA: 0x0038E3E0 File Offset: 0x0038C5E0
	public new void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008AED RID: 35565 RVA: 0x0038E3EC File Offset: 0x0038C5EC
	public new List<c3e> a()
	{
		return this.c;
	}

	// Token: 0x06008AEE RID: 35566 RVA: 0x0038E3F4 File Offset: 0x0038C5F4
	public new void a(List<c3e> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06008AEF RID: 35567 RVA: 0x0038E400 File Offset: 0x0038C600
	public int c()
	{
		return this.d;
	}

	// Token: 0x06008AF0 RID: 35568 RVA: 0x0038E408 File Offset: 0x0038C608
	public new void a(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06008AF1 RID: 35569 RVA: 0x0038E414 File Offset: 0x0038C614
	public List<d3e> e()
	{
		return this.e;
	}

	// Token: 0x06008AF2 RID: 35570 RVA: 0x0038E41C File Offset: 0x0038C61C
	public List<wq> b()
	{
		return this.f;
	}

	// Token: 0x06008AF3 RID: 35571 RVA: 0x0038E424 File Offset: 0x0038C624
	public ett()
	{
	}

	// Token: 0x06008AF4 RID: 35572 RVA: 0x0038E45C File Offset: 0x0038C65C
	public override bk3 tw()
	{
		ett ett = new ett();
		this.ai7(ett);
		return ett;
	}

	// Token: 0x06008AF5 RID: 35573 RVA: 0x0038E478 File Offset: 0x0038C678
	protected override void ai7(bk3 A_0)
	{
		base.ai7(A_0);
		ett ett = (ett)A_0;
		ett.a = new List<bt5>(this.a);
		ett.c = new List<c3e>(this.c);
		ett.b = this.b;
		ett.d = this.d;
		ett.e = new List<d3e>(this.e);
		ett.f = new List<wq>(this.f);
	}

	// Token: 0x04003782 RID: 14210
	private new List<bt5> a = new List<bt5>();

	// Token: 0x04003783 RID: 14211
	private double b;

	// Token: 0x04003784 RID: 14212
	private List<c3e> c = new List<c3e>();

	// Token: 0x04003785 RID: 14213
	private int d;

	// Token: 0x04003786 RID: 14214
	private List<d3e> e = new List<d3e>();

	// Token: 0x04003787 RID: 14215
	private List<wq> f = new List<wq>();
}
