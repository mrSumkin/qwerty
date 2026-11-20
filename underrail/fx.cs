using System;
using System.Runtime.Serialization;

// Token: 0x0200144B RID: 5195
[eiz("FLIA")]
[Serializable]
public sealed class fx : b1z, ISerializable
{
	// Token: 0x060074CA RID: 29898 RVA: 0x00318638 File Offset: 0x00316838
	private fx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("FLIA:L", typeof(jy)) as jy);
		this.b = A_0.GetSingle("FLIA:S");
		this.c = A_0.GetSingle("FLIA:E");
		this.d = A_0.GetSingle("FLIA:C");
		if (ell.a() >= 235)
		{
			this.e = A_0.GetBoolean("FLIA:D");
		}
	}

	// Token: 0x060074CB RID: 29899 RVA: 0x003186D8 File Offset: 0x003168D8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FLIA:L", this.a);
		info.AddValue("FLIA:S", this.b);
		info.AddValue("FLIA:E", this.c);
		info.AddValue("FLIA:C", this.d);
		info.AddValue("FLIA:D", this.e);
	}

	// Token: 0x060074CC RID: 29900 RVA: 0x00318744 File Offset: 0x00316944
	public fx(ah7 A_0, float A_1, float A_2, float A_3, bool A_4 = false)
	{
		this.a = new jy(A_0);
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
		this.e = A_4;
	}

	// Token: 0x060074CD RID: 29901 RVA: 0x00318798 File Offset: 0x00316998
	protected override dc4 dt()
	{
		if (this.a == null || this.a.ao() == null)
		{
			return dc4.e;
		}
		this.a.ao().Light = new ae8(this.a.ao().Light.d(), this.b, this.a.ao().Light.a());
		this.a.ao().d();
		return dc4.b;
	}

	// Token: 0x060074CE RID: 29902 RVA: 0x00318820 File Offset: 0x00316A20
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a == null || this.a.ao() == null)
		{
			return dc4.e;
		}
		float num = this.a.ao().Light.c();
		num += (float)(A_1.TotalMilliseconds * (double)this.d);
		bool flag = false;
		if (Math.Sign(this.d) == 1)
		{
			if (num >= this.c)
			{
				flag = true;
				num = this.c;
			}
		}
		else if (num <= this.c)
		{
			flag = true;
			num = this.c;
		}
		this.a.ao().Light = new ae8(this.a.ao().Light.d(), num, this.a.ao().Light.a());
		this.a.ao().d();
		if (flag)
		{
			if (this.e)
			{
				this.a.ao().n();
			}
			return dc4.c;
		}
		return dc4.b;
	}

	// Token: 0x04002FBE RID: 12222
	private new jy a;

	// Token: 0x04002FBF RID: 12223
	private float b = 1f;

	// Token: 0x04002FC0 RID: 12224
	private float c;

	// Token: 0x04002FC1 RID: 12225
	private float d = -0.001f;

	// Token: 0x04002FC2 RID: 12226
	private bool e;
}
