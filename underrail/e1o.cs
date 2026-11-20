using System;
using System.Runtime.Serialization;

// Token: 0x02001450 RID: 5200
[eiz("OLIA")]
[Serializable]
public sealed class e1o : b1z, ISerializable
{
	// Token: 0x060074EA RID: 29930 RVA: 0x003192DC File Offset: 0x003174DC
	private e1o(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (A_0.GetValue("OLIA:LDR", typeof(jy)) as jy);
		this.c = A_0.GetSingle("OLIA:MIV");
		this.d = A_0.GetSingle("OLIA:MXV");
		this.e = A_0.GetInt32("OLIA:CD");
		this.f = A_0.GetDouble("OLIA:CPM");
		if (ell.a() >= 83)
		{
			this.g = A_0.GetDouble("OLIA:C");
		}
	}

	// Token: 0x060074EB RID: 29931 RVA: 0x0031937C File Offset: 0x0031757C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("OLIA:LDR", this.b);
		info.AddValue("OLIA:MIV", this.c);
		info.AddValue("OLIA:MXV", this.d);
		info.AddValue("OLIA:CD", this.e);
		info.AddValue("OLIA:CPM", this.f);
		info.AddValue("OLIA:C", this.g);
	}

	// Token: 0x060074EC RID: 29932 RVA: 0x003193F8 File Offset: 0x003175F8
	public e1o(ah7 A_0, float A_1, float A_2, double A_3)
	{
		this.b = new jy(A_0);
		this.c = A_1;
		this.d = A_2;
		this.f = A_3;
	}

	// Token: 0x060074ED RID: 29933 RVA: 0x0031942C File Offset: 0x0031762C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.b == null || this.b.ao() == null)
		{
			return dc4.e;
		}
		float num = this.c + (this.d - this.c) * 0.3f;
		if ((this.g += A_1.TotalMilliseconds) >= 33.0)
		{
			double num2 = this.g * this.f * (double)this.e * 0.66;
			this.b.ao().Light = new ae8(this.b.ao().Light.d(), (float)((double)this.b.ao().Light.c() + num2), this.b.ao().Light.a());
			if (this.e == 1)
			{
				if (this.b.ao().Light.c() >= this.d)
				{
					this.b.ao().Light = new ae8(this.b.ao().Light.d(), this.d, this.b.ao().Light.a());
					this.e = -1;
				}
			}
			else if (this.b.ao().Light.c() <= num)
			{
				this.b.ao().Light = new ae8(this.b.ao().Light.d(), num, this.b.ao().Light.a());
				this.e = 1;
			}
			this.b.ao().d();
			this.g -= (0.9 + cuo.a.NextDouble() * 0.2) * 33.0;
		}
		return dc4.b;
	}

	// Token: 0x04002FDE RID: 12254
	private new const int a = 33;

	// Token: 0x04002FDF RID: 12255
	private jy b;

	// Token: 0x04002FE0 RID: 12256
	private float c;

	// Token: 0x04002FE1 RID: 12257
	private float d;

	// Token: 0x04002FE2 RID: 12258
	private int e = 1;

	// Token: 0x04002FE3 RID: 12259
	private double f;

	// Token: 0x04002FE4 RID: 12260
	private double g;
}
