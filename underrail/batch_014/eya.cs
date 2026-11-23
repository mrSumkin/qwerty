using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001940 RID: 6464
[eiz("AI1")]
[elw(typeof(cgk))]
[Serializable]
public abstract class eya : diz, ISerializable
{
	// Token: 0x0600892C RID: 35116 RVA: 0x00389384 File Offset: 0x00387584
	protected eya(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<du2>("AI1:DR", ref this.a, A_0);
			if (ell.a() >= 91)
			{
				this.b = A_0.GetDouble("AI1:E");
			}
			else
			{
				this.b = (double)A_0.GetSingle("AI1:E");
			}
			if (ell.a() >= 90)
			{
				di7.ReadList<c3e>("AT1:M", ref this.c, A_0);
			}
			else
			{
				this.c = new List<c3e>();
			}
			if (ell.a() >= 96)
			{
				this.d = A_0.GetInt32("AT1:S");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(eya))
			{
				this.a = (List<du2>)A_0.GetValue("_DamageResistances", typeof(List<du2>));
				this.b = (double)A_0.GetSingle("_Encumbrance");
				return;
			}
			this.a = (List<du2>)A_0.GetValue("ArmorItem+_DamageResistances", typeof(List<du2>));
			this.b = (double)A_0.GetSingle("ArmorItem+_Encumbrance");
		}
	}

	// Token: 0x0600892D RID: 35117 RVA: 0x003894C8 File Offset: 0x003876C8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<du2>("AI1:DR", this.a, info);
		info.AddValue("AI1:E", this.b);
		di7.WriteList<c3e>("AT1:M", this.c, info);
		info.AddValue("AT1:S", this.d);
	}

	// Token: 0x0600892E RID: 35118 RVA: 0x00389524 File Offset: 0x00387724
	public List<du2> i()
	{
		return this.a;
	}

	// Token: 0x0600892F RID: 35119 RVA: 0x0038952C File Offset: 0x0038772C
	public double h()
	{
		return this.b;
	}

	// Token: 0x06008930 RID: 35120 RVA: 0x00389534 File Offset: 0x00387734
	public void b(double A_0)
	{
		this.b = Math.Round(A_0, 2);
	}

	// Token: 0x06008931 RID: 35121 RVA: 0x00389544 File Offset: 0x00387744
	public List<c3e> f()
	{
		return this.c;
	}

	// Token: 0x06008932 RID: 35122 RVA: 0x0038954C File Offset: 0x0038774C
	public new void a(List<c3e> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06008933 RID: 35123 RVA: 0x00389558 File Offset: 0x00387758
	public int g()
	{
		return this.d;
	}

	// Token: 0x06008934 RID: 35124 RVA: 0x00389560 File Offset: 0x00387760
	public void b(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06008935 RID: 35125 RVA: 0x0038956C File Offset: 0x0038776C
	protected eya()
	{
		base.g(false);
	}

	// Token: 0x06008936 RID: 35126 RVA: 0x00389594 File Offset: 0x00387794
	protected override void ai7(bk3 A_0)
	{
		base.ai7(A_0);
		eya eya = (eya)A_0;
		eya.b = this.b;
		eya.d = this.d;
		eya.a = new List<du2>();
		if (this.a != null)
		{
			eya.a.AddRange(this.a);
		}
		eya.c = new List<c3e>();
		if (this.c != null)
		{
			foreach (c3e c3e in this.c)
			{
				eya.c.Add(c3e.xr());
			}
		}
	}

	// Token: 0x040036A4 RID: 13988
	private new List<du2> a = new List<du2>();

	// Token: 0x040036A5 RID: 13989
	private double b;

	// Token: 0x040036A6 RID: 13990
	private List<c3e> c = new List<c3e>();

	// Token: 0x040036A7 RID: 13991
	private int d;
}
