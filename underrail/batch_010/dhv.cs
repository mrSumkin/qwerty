using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010DB RID: 4315
[eiz("SEBOJ")]
[Serializable]
public sealed class dhv : cze
{
	// Token: 0x06005AF2 RID: 23282 RVA: 0x00272884 File Offset: 0x00270A84
	private dhv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetSingle("SEBOJ:MN");
		this.b = A_0.GetSingle("SEBOJ:MX");
		this.c = A_0.GetDouble("SEBOJ:C");
		this.d = A_0.GetString("SEBOJ:N");
	}

	// Token: 0x06005AF3 RID: 23283 RVA: 0x002728E0 File Offset: 0x00270AE0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SEBOJ:MN", this.a);
		info.AddValue("SEBOJ:MX", this.b);
		info.AddValue("SEBOJ:N", this.d);
		info.AddValue("SEBOJ:C", this.c);
	}

	// Token: 0x06005AF4 RID: 23284 RVA: 0x0027293C File Offset: 0x00270B3C
	public float d()
	{
		return this.a;
	}

	// Token: 0x06005AF5 RID: 23285 RVA: 0x00272944 File Offset: 0x00270B44
	public void b(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005AF6 RID: 23286 RVA: 0x00272950 File Offset: 0x00270B50
	public float a()
	{
		return this.b;
	}

	// Token: 0x06005AF7 RID: 23287 RVA: 0x00272958 File Offset: 0x00270B58
	public void a(float A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005AF8 RID: 23288 RVA: 0x00272964 File Offset: 0x00270B64
	public double c()
	{
		return this.c;
	}

	// Token: 0x06005AF9 RID: 23289 RVA: 0x0027296C File Offset: 0x00270B6C
	public void a(double A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005AFA RID: 23290 RVA: 0x00272978 File Offset: 0x00270B78
	public string b()
	{
		return this.d;
	}

	// Token: 0x06005AFB RID: 23291 RVA: 0x00272980 File Offset: 0x00270B80
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005AFC RID: 23292 RVA: 0x0027298C File Offset: 0x00270B8C
	public dhv()
	{
	}

	// Token: 0x06005AFD RID: 23293 RVA: 0x00272998 File Offset: 0x00270B98
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!string.IsNullOrEmpty(this.d))
		{
			c1a c1a;
			if (A_0 != null)
			{
				c1a = A_0.Zone;
			}
			else if (A_1 != null)
			{
				c1a = A_1.Zone;
			}
			else
			{
				c1a = null;
			}
			if (c1a != null)
			{
				c5x c5x = new ar7(new Guid(this.d), A_0.Area).ao() as c5x;
				if (c5x != null)
				{
					dxi a_ = new dxi(c5x.o.b, this.a, this.b, this.c);
					c1a.ActionManager.g9(a_, atp.a);
				}
			}
		}
	}

	// Token: 0x0400245D RID: 9309
	private new float a;

	// Token: 0x0400245E RID: 9310
	private float b;

	// Token: 0x0400245F RID: 9311
	private double c;

	// Token: 0x04002460 RID: 9312
	private string d;
}
