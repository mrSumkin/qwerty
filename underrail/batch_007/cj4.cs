using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001262 RID: 4706
[eiz("ESEA")]
[a(typeof(bbw))]
[Serializable]
public class cj4 : bbw, ISerializable
{
	// Token: 0x060065EA RID: 26090 RVA: 0x002B5FA0 File Offset: 0x002B41A0
	protected cj4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("ESEA:M");
		this.b = A_0.GetDouble("ESEA:C");
		di7.ReadList<cze>("ESEA:OC", ref this.c, A_0);
		di7.ReadList<cze>("ESEA:OD", ref this.d, A_0);
		this.e = (A_0.GetValue("ESEA:CR", typeof(dth)) as dth);
	}

	// Token: 0x060065EB RID: 26091 RVA: 0x002B6030 File Offset: 0x002B4230
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ESEA:M", this.a);
		info.AddValue("ESEA:C", this.b);
		di7.WriteList<cze>("ESEA:OC", this.c, info);
		di7.WriteList<cze>("ESEA:OD", this.d, info);
		info.AddValue("ESEA:CR", this.e);
	}

	// Token: 0x060065EC RID: 26092 RVA: 0x002B609C File Offset: 0x002B429C
	public override int s6()
	{
		return this.a;
	}

	// Token: 0x060065ED RID: 26093 RVA: 0x002B60A4 File Offset: 0x002B42A4
	public override void s7(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060065EE RID: 26094 RVA: 0x002B60B0 File Offset: 0x002B42B0
	public override double s8()
	{
		return this.b;
	}

	// Token: 0x060065EF RID: 26095 RVA: 0x002B60B8 File Offset: 0x002B42B8
	public override void s9(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060065F0 RID: 26096 RVA: 0x002B60C4 File Offset: 0x002B42C4
	public List<cze> e()
	{
		return this.c;
	}

	// Token: 0x060065F1 RID: 26097 RVA: 0x002B60CC File Offset: 0x002B42CC
	public void b(List<cze> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060065F2 RID: 26098 RVA: 0x002B60D8 File Offset: 0x002B42D8
	public List<cze> f()
	{
		return this.d;
	}

	// Token: 0x060065F3 RID: 26099 RVA: 0x002B60E0 File Offset: 0x002B42E0
	public void a(List<cze> A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060065F4 RID: 26100 RVA: 0x002B60EC File Offset: 0x002B42EC
	public dth d()
	{
		return this.e;
	}

	// Token: 0x060065F5 RID: 26101 RVA: 0x002B60F4 File Offset: 0x002B42F4
	public void a(dth A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060065F6 RID: 26102 RVA: 0x002B6100 File Offset: 0x002B4300
	public cj4(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060065F7 RID: 26103 RVA: 0x002B6120 File Offset: 0x002B4320
	public override bool tb()
	{
		return this.b < (double)this.a && (this.e == null || this.e.jh(this));
	}

	// Token: 0x060065F8 RID: 26104 RVA: 0x002B6154 File Offset: 0x002B4354
	public override double tc(c5x A_0, double A_1)
	{
		double num = Math.Min(A_1, (double)this.a - this.b);
		this.b = Math.Min((double)this.a, this.b + num);
		if (this.c.Count > 0)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary["EnergyChange"] = num;
			foreach (cze cze in this.c)
			{
				cze.ym(A_0, base.a8(), dictionary);
			}
		}
		return num;
	}

	// Token: 0x060065F9 RID: 26105 RVA: 0x002B620C File Offset: 0x002B440C
	public override double td(c5x A_0, double A_1, bool A_2 = true)
	{
		double num = Math.Min(A_1, this.b);
		if (A_2 || num == A_1)
		{
			this.b = Math.Max(0.0, this.b - num);
			if (this.d.Count > 0)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary["EnergyChange"] = -num;
				foreach (cze cze in this.d)
				{
					cze.ym(A_0, base.a8(), dictionary);
				}
			}
		}
		return num;
	}

	// Token: 0x04002A5E RID: 10846
	private int a;

	// Token: 0x04002A5F RID: 10847
	private double b;

	// Token: 0x04002A60 RID: 10848
	private List<cze> c = new List<cze>();

	// Token: 0x04002A61 RID: 10849
	private List<cze> d = new List<cze>();

	// Token: 0x04002A62 RID: 10850
	private dth e;
}
