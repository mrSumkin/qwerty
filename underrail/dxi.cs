using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x0200144D RID: 5197
[eiz("OEBA")]
[Serializable]
public sealed class dxi : b1z, ISerializable
{
	// Token: 0x060074D3 RID: 29907 RVA: 0x00318A40 File Offset: 0x00316C40
	private dxi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (A_0.GetValue("OEBA:S", typeof(EntityAspectReference<cd0, cd0>)) as EntityAspectReference<cd0, cd0>);
		this.c = A_0.GetSingle("OEBA:MIV");
		this.d = A_0.GetSingle("OEBA:MXV");
		this.e = A_0.GetInt32("OEBA:CD");
		this.f = A_0.GetDouble("OEBA:CPM");
		if (ell.a() >= 83)
		{
			this.g = A_0.GetDouble("OEBA:C");
		}
	}

	// Token: 0x060074D4 RID: 29908 RVA: 0x00318AE0 File Offset: 0x00316CE0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("OEBA:S", this.b);
		info.AddValue("OEBA:MIV", this.c);
		info.AddValue("OEBA:MXV", this.d);
		info.AddValue("OEBA:CD", this.e);
		info.AddValue("OEBA:CPM", this.f);
		info.AddValue("OEBA:C", this.g);
	}

	// Token: 0x060074D5 RID: 29909 RVA: 0x00318B5C File Offset: 0x00316D5C
	public dxi(cd0 A_0, float A_1, float A_2, double A_3)
	{
		this.b = new EntityAspectReference<cd0, cd0>(A_0);
		this.c = A_1;
		this.d = A_2;
		this.f = A_3;
	}

	// Token: 0x060074D6 RID: 29910 RVA: 0x00318B90 File Offset: 0x00316D90
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.b == null || this.b.ao() == null)
		{
			return dc4.e;
		}
		if ((this.g += A_1.TotalMilliseconds) >= 100.0)
		{
			double num = this.g * this.f * (double)this.e;
			this.b.ao().f += (float)num;
			if (this.e == 1)
			{
				if (this.b.ao().f >= this.d)
				{
					this.b.ao().f = this.d;
					this.e = -1;
				}
			}
			else if (this.b.ao().f <= this.c)
			{
				this.b.ao().f = this.c;
				this.e = 1;
			}
			this.g -= (0.9 + cuo.a.NextDouble() * 0.2) * 100.0;
		}
		return dc4.b;
	}

	// Token: 0x04002FC5 RID: 12229
	private new const int a = 100;

	// Token: 0x04002FC6 RID: 12230
	private EntityAspectReference<cd0, cd0> b;

	// Token: 0x04002FC7 RID: 12231
	private float c;

	// Token: 0x04002FC8 RID: 12232
	private float d;

	// Token: 0x04002FC9 RID: 12233
	private int e = 1;

	// Token: 0x04002FCA RID: 12234
	private double f;

	// Token: 0x04002FCB RID: 12235
	private double g;
}
