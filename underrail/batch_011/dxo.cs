using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012A2 RID: 4770
[eiz("OLIEA2")]
[Serializable]
public sealed class dxo : Aspect<c5x>, ISerializable, c98
{
	// Token: 0x0600684A RID: 26698 RVA: 0x002C1C50 File Offset: 0x002BFE50
	private dxo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetString("OLIEA2:LN");
		this.c = A_0.GetSingle("OLIEA2:MIV");
		this.d = A_0.GetSingle("OLIEA2:MXV");
		this.e = A_0.GetInt32("OLIEA2:CD");
		this.f = A_0.GetDouble("OLIEA2:CPM");
		this.g = A_0.GetDouble("OLIEA2:C");
	}

	// Token: 0x0600684B RID: 26699 RVA: 0x002C1CD4 File Offset: 0x002BFED4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("OLIEA2:LN", this.b);
		info.AddValue("OLIEA2:MIV", this.c);
		info.AddValue("OLIEA2:MXV", this.d);
		info.AddValue("OLIEA2:CD", this.e);
		info.AddValue("OLIEA2:CPM", this.f);
		info.AddValue("OLIEA2:C", this.g);
	}

	// Token: 0x0600684C RID: 26700 RVA: 0x002C1D50 File Offset: 0x002BFF50
	public string b()
	{
		return this.b;
	}

	// Token: 0x0600684D RID: 26701 RVA: 0x002C1D58 File Offset: 0x002BFF58
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600684E RID: 26702 RVA: 0x002C1D64 File Offset: 0x002BFF64
	public float e()
	{
		return this.c;
	}

	// Token: 0x0600684F RID: 26703 RVA: 0x002C1D6C File Offset: 0x002BFF6C
	public void b(float A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006850 RID: 26704 RVA: 0x002C1D78 File Offset: 0x002BFF78
	public float d()
	{
		return this.d;
	}

	// Token: 0x06006851 RID: 26705 RVA: 0x002C1D80 File Offset: 0x002BFF80
	public void a(float A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006852 RID: 26706 RVA: 0x002C1D8C File Offset: 0x002BFF8C
	public int a()
	{
		return this.e;
	}

	// Token: 0x06006853 RID: 26707 RVA: 0x002C1D94 File Offset: 0x002BFF94
	public void a(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006854 RID: 26708 RVA: 0x002C1DA0 File Offset: 0x002BFFA0
	public double f()
	{
		return this.f;
	}

	// Token: 0x06006855 RID: 26709 RVA: 0x002C1DA8 File Offset: 0x002BFFA8
	public void a(double A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06006856 RID: 26710 RVA: 0x002C1DB4 File Offset: 0x002BFFB4
	public dxo(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006857 RID: 26711 RVA: 0x002C1DC4 File Offset: 0x002BFFC4
	public dxo(c5x A_0, string A_1, float A_2, float A_3, double A_4) : base(A_0)
	{
		this.a(A_1, A_2, A_3, A_4);
	}

	// Token: 0x06006858 RID: 26712 RVA: 0x002C1DE0 File Offset: 0x002BFFE0
	public void a(string A_0, float A_1, float A_2, double A_3)
	{
		this.b = A_0;
		this.c = A_1;
		this.d = A_2;
		this.f = A_3;
	}

	// Token: 0x06006859 RID: 26713 RVA: 0x002C1E00 File Offset: 0x002C0000
	public void r7(eds A_0)
	{
		ah7 ah = null;
		if (base.a8() != null)
		{
			foreach (ejt ejt in base.a8().RaysEmitters)
			{
				bsf bsf = ejt as bsf;
				if (bsf != null && bsf.Definition != null && bsf.Definition.Name == this.b)
				{
					ah = bsf.Definition;
					break;
				}
			}
			if (ah != null)
			{
				float num = this.c + (this.d - this.c) * 0.3f;
				if ((this.g += A_0.b.TotalMilliseconds) >= 33.0)
				{
					double num2 = this.g * this.f * (double)this.e * 0.66;
					ah.Light = new ae8(ah.Light.d(), (float)((double)ah.Light.c() + num2), ah.Light.a());
					if (this.e == 1)
					{
						if (ah.Light.c() >= this.d)
						{
							ah.Light = new ae8(ah.Light.d(), this.d, ah.Light.a());
							this.e = -1;
						}
					}
					else if (ah.Light.c() <= num)
					{
						ah.Light = new ae8(ah.Light.d(), num, ah.Light.a());
						this.e = 1;
					}
					ah.d();
					this.g -= (0.9 + cuo.a.NextDouble() * 0.2) * 33.0;
				}
			}
		}
	}

	// Token: 0x04002B16 RID: 11030
	private const int a = 33;

	// Token: 0x04002B17 RID: 11031
	private string b;

	// Token: 0x04002B18 RID: 11032
	private float c;

	// Token: 0x04002B19 RID: 11033
	private float d;

	// Token: 0x04002B1A RID: 11034
	private int e = 1;

	// Token: 0x04002B1B RID: 11035
	private double f;

	// Token: 0x04002B1C RID: 11036
	private double g;
}
