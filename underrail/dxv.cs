using System;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012D2 RID: 4818
[eiz("GSE2")]
[Serializable]
public sealed class dxv : Aspect<c5x>, ISerializable, chb, c98, cwd
{
	// Token: 0x06006A6E RID: 27246 RVA: 0x002CD790 File Offset: 0x002CB990
	private dxv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetDouble("GSE2:L");
		this.e = A_0.GetString("GSE2:G");
		this.c = A_0.GetString("GSE2:O");
		this.d = A_0.GetDouble("GSE2:C");
		this.f = A_0.GetBoolean("GSE2:E");
		if (ell.a() >= 413)
		{
			this.g = (A_0.GetValue("GSE2:P", typeof(TimeSpan?)) as TimeSpan?);
		}
		if (ell.a() >= 541)
		{
			this.h = A_0.GetBoolean("GSE2:S");
		}
	}

	// Token: 0x06006A6F RID: 27247 RVA: 0x002CD880 File Offset: 0x002CBA80
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GSE2:L", this.b);
		info.AddValue("GSE2:G", this.e);
		info.AddValue("GSE2:O", this.c);
		info.AddValue("GSE2:C", this.d);
		info.AddValue("GSE2:E", this.f);
		info.AddValue("GSE2:P", this.g);
		info.AddValue("GSE2:S", this.h);
	}

	// Token: 0x06006A70 RID: 27248 RVA: 0x002CD914 File Offset: 0x002CBB14
	public double e()
	{
		return this.b;
	}

	// Token: 0x06006A71 RID: 27249 RVA: 0x002CD91C File Offset: 0x002CBB1C
	public void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006A72 RID: 27250 RVA: 0x002CD928 File Offset: 0x002CBB28
	public string g()
	{
		return this.c;
	}

	// Token: 0x06006A73 RID: 27251 RVA: 0x002CD930 File Offset: 0x002CBB30
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006A74 RID: 27252 RVA: 0x002CD93C File Offset: 0x002CBB3C
	public string d()
	{
		return this.e;
	}

	// Token: 0x06006A75 RID: 27253 RVA: 0x002CD944 File Offset: 0x002CBB44
	public void a(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006A76 RID: 27254 RVA: 0x002CD950 File Offset: 0x002CBB50
	public bool h()
	{
		return this.f;
	}

	// Token: 0x06006A77 RID: 27255 RVA: 0x002CD958 File Offset: 0x002CBB58
	public void a(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06006A78 RID: 27256 RVA: 0x002CD964 File Offset: 0x002CBB64
	public TimeSpan? b()
	{
		return this.g;
	}

	// Token: 0x06006A79 RID: 27257 RVA: 0x002CD96C File Offset: 0x002CBB6C
	public void a(TimeSpan? A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06006A7A RID: 27258 RVA: 0x002CD978 File Offset: 0x002CBB78
	public bool f()
	{
		return this.h;
	}

	// Token: 0x06006A7B RID: 27259 RVA: 0x002CD980 File Offset: 0x002CBB80
	public void b(bool A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06006A7C RID: 27260 RVA: 0x002CD98C File Offset: 0x002CBB8C
	public dxv(c5x A_0) : this(A_0, null, null)
	{
	}

	// Token: 0x06006A7D RID: 27261 RVA: 0x002CD99C File Offset: 0x002CBB9C
	public dxv(c5x A_0, string A_1, string A_2) : base(A_0)
	{
		this.c = A_2;
		this.e = A_1;
		this.d = (double)(d0u.b / 5);
		this.a();
	}

	// Token: 0x06006A7E RID: 27262 RVA: 0x002CDA04 File Offset: 0x002CBC04
	public void aqi()
	{
		if (this.g != null)
		{
			this.a(this.g.Value);
			this.g = null;
			this.d = (double)d0u.b;
			this.a();
		}
	}

	// Token: 0x06006A7F RID: 27263 RVA: 0x002CDA50 File Offset: 0x002CBC50
	public void r7(eds A_0)
	{
		if (this.f && !this.h)
		{
			if (!dz6.e())
			{
				if ((this.d -= A_0.b.TotalMilliseconds) <= 0.0)
				{
					this.d += (double)(d0u.b / 5);
					this.a(this.b / 5.0, false);
					return;
				}
			}
			else
			{
				this.d = (double)d0u.b;
				this.a();
			}
		}
	}

	// Token: 0x06006A80 RID: 27264 RVA: 0x002CDAE8 File Offset: 0x002CBCE8
	public void c()
	{
		if (this.f)
		{
			for (int i = 0; i < 5; i++)
			{
				this.a(this.b / 5.0, false);
			}
		}
	}

	// Token: 0x06006A81 RID: 27265 RVA: 0x002CDB28 File Offset: 0x002CBD28
	public void a(TimeSpan A_0)
	{
		if (this.f)
		{
			int num = (int)Math.Min(1000.0, A_0.TotalMilliseconds / (double)(d0u.b / 5));
			for (int i = 0; i < num; i++)
			{
				this.a(this.b / 5.0, true);
			}
		}
	}

	// Token: 0x06006A82 RID: 27266 RVA: 0x002CDB88 File Offset: 0x002CBD88
	public void b(TimeSpan A_0)
	{
	}

	// Token: 0x06006A83 RID: 27267 RVA: 0x002CDB8C File Offset: 0x002CBD8C
	private void a(double A_0, bool A_1 = false)
	{
		ak1 a_ = Enumerable.FirstOrDefault<ak1>(base.a8().l);
		bpv.a(this.e, A_0, a_, this.c, A_1, this.h, new double?(1000.0));
	}

	// Token: 0x06006A84 RID: 27268 RVA: 0x002CDBD4 File Offset: 0x002CBDD4
	private void a()
	{
		this.d += (double)cuo.a.Next(d0u.b / 5);
	}

	// Token: 0x04002BB7 RID: 11191
	private const int a = 5;

	// Token: 0x04002BB8 RID: 11192
	private double b = 4.0;

	// Token: 0x04002BB9 RID: 11193
	private string c;

	// Token: 0x04002BBA RID: 11194
	private double d;

	// Token: 0x04002BBB RID: 11195
	private string e;

	// Token: 0x04002BBC RID: 11196
	private bool f = true;

	// Token: 0x04002BBD RID: 11197
	private TimeSpan? g = new TimeSpan?(TimeSpan.FromSeconds(30.0));

	// Token: 0x04002BBE RID: 11198
	private bool h;
}
