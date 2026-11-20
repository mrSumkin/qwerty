using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010CA RID: 4298
[eiz("SDSJ1")]
[Serializable]
public sealed class my : cze, ISerializable
{
	// Token: 0x06005A89 RID: 23177 RVA: 0x002712A8 File Offset: 0x0026F4A8
	private my(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("SDSJ1:I", typeof(Guid?));
		this.c = A_0.GetString("SDSJ1:A");
		this.a = A_0.GetBoolean("SDSJ1:L");
	}

	// Token: 0x06005A8A RID: 23178 RVA: 0x00271300 File Offset: 0x0026F500
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SDSJ1:I", this.b);
		info.AddValue("SDSJ1:A", this.c);
		info.AddValue("SDSJ1:L", this.a);
	}

	// Token: 0x06005A8B RID: 23179 RVA: 0x00271350 File Offset: 0x0026F550
	public bool c()
	{
		return this.a;
	}

	// Token: 0x06005A8C RID: 23180 RVA: 0x00271358 File Offset: 0x0026F558
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005A8D RID: 23181 RVA: 0x00271364 File Offset: 0x0026F564
	public string a()
	{
		return this.c;
	}

	// Token: 0x06005A8E RID: 23182 RVA: 0x0027136C File Offset: 0x0026F56C
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005A8F RID: 23183 RVA: 0x00271378 File Offset: 0x0026F578
	public Guid? b()
	{
		return this.b;
	}

	// Token: 0x06005A90 RID: 23184 RVA: 0x00271380 File Offset: 0x0026F580
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005A91 RID: 23185 RVA: 0x0027138C File Offset: 0x0026F58C
	public my()
	{
	}

	// Token: 0x06005A92 RID: 23186 RVA: 0x00271394 File Offset: 0x0026F594
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.b != null)
		{
			aud aud = null;
			if (this.c != null)
			{
				b4b serviceOrThrow = bpo.GetServiceOrThrow<b4b>();
				if (serviceOrThrow.yn() != null && serviceOrThrow.yn().Zones.Count > 0)
				{
					aud = serviceOrThrow.yn().Zones[0].n(this.c);
				}
			}
			else if (A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x = (new ar7(this.b.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			cnb cnb = c5x.GetAspect<bim>() as cnb;
			if (cnb != null)
			{
				cnb.b(this.a);
			}
		}
	}

	// Token: 0x04002441 RID: 9281
	private new bool a;

	// Token: 0x04002442 RID: 9282
	private Guid? b;

	// Token: 0x04002443 RID: 9283
	private string c;
}
