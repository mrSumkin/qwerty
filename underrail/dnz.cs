using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001044 RID: 4164
[eiz("SCHARSJOB")]
[Serializable]
public sealed class dnz : cze, ISerializable
{
	// Token: 0x06005631 RID: 22065 RVA: 0x0025E5A4 File Offset: 0x0025C7A4
	private dnz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = (Guid?)A_0.GetValue("SCHARSJOB:I", typeof(Guid?));
		this.d = A_0.GetString("SCHARSJOB:A");
		this.a = (float)A_0.GetValue("SCHARSJOB:H", typeof(float));
		this.b = (float)A_0.GetValue("SCHARSJOB:G", typeof(float));
	}

	// Token: 0x06005632 RID: 22066 RVA: 0x0025E62C File Offset: 0x0025C82C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SCHARSJOB:I", this.c);
		info.AddValue("SCHARSJOB:A", this.d);
		info.AddValue("SCHARSJOB:H", this.a);
		info.AddValue("SCHARSJOB:G", this.b);
	}

	// Token: 0x06005633 RID: 22067 RVA: 0x0025E68C File Offset: 0x0025C88C
	public float d()
	{
		return this.a;
	}

	// Token: 0x06005634 RID: 22068 RVA: 0x0025E694 File Offset: 0x0025C894
	public void a(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005635 RID: 22069 RVA: 0x0025E6A0 File Offset: 0x0025C8A0
	public float b()
	{
		return this.b;
	}

	// Token: 0x06005636 RID: 22070 RVA: 0x0025E6A8 File Offset: 0x0025C8A8
	public void b(float A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005637 RID: 22071 RVA: 0x0025E6B4 File Offset: 0x0025C8B4
	public string a()
	{
		return this.d;
	}

	// Token: 0x06005638 RID: 22072 RVA: 0x0025E6BC File Offset: 0x0025C8BC
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005639 RID: 22073 RVA: 0x0025E6C8 File Offset: 0x0025C8C8
	public Guid? c()
	{
		return this.c;
	}

	// Token: 0x0600563A RID: 22074 RVA: 0x0025E6D0 File Offset: 0x0025C8D0
	public void a(Guid? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600563B RID: 22075 RVA: 0x0025E6DC File Offset: 0x0025C8DC
	public dnz()
	{
	}

	// Token: 0x0600563C RID: 22076 RVA: 0x0025E6E4 File Offset: 0x0025C8E4
	public dnz(float A_0, float A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x0600563D RID: 22077 RVA: 0x0025E6FC File Offset: 0x0025C8FC
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.c != null)
		{
			aud aud = null;
			if (this.d != null)
			{
				b4b serviceOrThrow = bpo.GetServiceOrThrow<b4b>();
				if (serviceOrThrow.yn() != null && serviceOrThrow.yn().Zones.Count > 0)
				{
					aud = serviceOrThrow.yn().Zones[0].n(this.d);
				}
			}
			else if (A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x = (new ar7(this.c.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null && c5x.h.b != null)
		{
			c5x.h.b.al = this.a;
			c5x.h.b.am = this.b;
		}
	}

	// Token: 0x04002300 RID: 8960
	private new float a;

	// Token: 0x04002301 RID: 8961
	private float b;

	// Token: 0x04002302 RID: 8962
	private Guid? c;

	// Token: 0x04002303 RID: 8963
	private string d;
}
