using System;
using System.Runtime.Serialization;

// Token: 0x02001BF9 RID: 7161
[eiz("XAM")]
[Serializable]
public sealed class cmn : ISerializable
{
	// Token: 0x06009BE7 RID: 39911 RVA: 0x003D23BC File Offset: 0x003D05BC
	private cmn(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (c3u)A_0.GetValue("XAM:T", typeof(c3u));
		this.b = A_0.GetDouble("XAM:D");
		this.c = A_0.GetDouble("XAM:C");
		this.d = A_0.GetDouble("XAM:CD");
		this.e = A_0.GetInt32("XAM:AS");
		this.f = A_0.GetBoolean("XAM:I");
		this.g = A_0.GetDouble("XAM:M");
		if (ell.a() >= 667)
		{
			this.h = A_0.GetDouble("XAM:P");
		}
		if (ell.a() >= 668)
		{
			this.i = A_0.GetDouble("XAM:EI");
		}
		if (ell.a() >= 683)
		{
			this.j = A_0.GetDouble("XAM:DM");
			return;
		}
		this.j = 1.0;
	}

	// Token: 0x06009BE8 RID: 39912 RVA: 0x003D24E4 File Offset: 0x003D06E4
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("XAM:T", this.a);
		info.AddValue("XAM:D", this.b);
		info.AddValue("XAM:C", this.c);
		info.AddValue("XAM:CD", this.d);
		info.AddValue("XAM:AS", this.e);
		info.AddValue("XAM:I", this.f);
		info.AddValue("XAM:M", this.g);
		info.AddValue("XAM:P", this.h);
		info.AddValue("XAM:EI", this.i);
		info.AddValue("XAM:DM", this.j);
	}

	// Token: 0x06009BE9 RID: 39913 RVA: 0x003D25A0 File Offset: 0x003D07A0
	public cmn()
	{
	}

	// Token: 0x06009BEA RID: 39914 RVA: 0x003D25C8 File Offset: 0x003D07C8
	public static cmn a(cmn A_0, cmn A_1)
	{
		return new cmn
		{
			a = (A_0.a | A_1.a),
			b = A_0.b + A_1.b,
			c = A_0.c + A_1.c,
			d = A_0.d + A_1.d,
			e = A_0.e + A_1.e,
			f = (A_0.f || A_1.f),
			g = A_0.g * A_1.g,
			h = A_0.h + A_1.h,
			i = A_0.i + A_1.i,
			j = A_0.j * A_1.j
		};
	}

	// Token: 0x06009BEB RID: 39915 RVA: 0x003D26A4 File Offset: 0x003D08A4
	public void a(cmn A_0)
	{
		if (A_0 != null)
		{
			this.a |= A_0.a;
			this.b += A_0.b;
			this.c += A_0.c;
			this.d += A_0.d;
			this.e += A_0.e;
			this.f |= A_0.f;
			this.g *= A_0.g;
			this.h += A_0.h;
			this.i += A_0.i;
			this.j *= A_0.j;
		}
	}

	// Token: 0x04003BE1 RID: 15329
	public c3u a;

	// Token: 0x04003BE2 RID: 15330
	public double b;

	// Token: 0x04003BE3 RID: 15331
	public double c;

	// Token: 0x04003BE4 RID: 15332
	public double d;

	// Token: 0x04003BE5 RID: 15333
	public int e;

	// Token: 0x04003BE6 RID: 15334
	public bool f;

	// Token: 0x04003BE7 RID: 15335
	public double g = 1.0;

	// Token: 0x04003BE8 RID: 15336
	public double h;

	// Token: 0x04003BE9 RID: 15337
	public double i;

	// Token: 0x04003BEA RID: 15338
	public double j = 1.0;
}
