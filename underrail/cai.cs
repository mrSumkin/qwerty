using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001083 RID: 4227
[eiz("SRGTPJ")]
[Serializable]
public sealed class cai : cze, ISerializable
{
	// Token: 0x06005817 RID: 22551 RVA: 0x0026444C File Offset: 0x0026264C
	private cai(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("SRGTPJ:I", typeof(Guid?));
		this.b = A_0.GetString("SRGTPJ:A");
		this.c = A_0.GetInt32("SRGTPJ:P");
		this.d = A_0.GetInt32("SRGTPJ:S");
	}

	// Token: 0x06005818 RID: 22552 RVA: 0x002644B4 File Offset: 0x002626B4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SRGTPJ:I", this.a);
		info.AddValue("SRGTPJ:A", this.b);
		info.AddValue("SRGTPJ:P", this.c);
		info.AddValue("SRGTPJ:S", this.d);
	}

	// Token: 0x06005819 RID: 22553 RVA: 0x00264514 File Offset: 0x00262714
	public int b()
	{
		return this.c;
	}

	// Token: 0x0600581A RID: 22554 RVA: 0x0026451C File Offset: 0x0026271C
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600581B RID: 22555 RVA: 0x00264528 File Offset: 0x00262728
	public int c()
	{
		return this.d;
	}

	// Token: 0x0600581C RID: 22556 RVA: 0x00264530 File Offset: 0x00262730
	public void b(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600581D RID: 22557 RVA: 0x0026453C File Offset: 0x0026273C
	public string a()
	{
		return this.b;
	}

	// Token: 0x0600581E RID: 22558 RVA: 0x00264544 File Offset: 0x00262744
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600581F RID: 22559 RVA: 0x00264550 File Offset: 0x00262750
	public Guid? d()
	{
		return this.a;
	}

	// Token: 0x06005820 RID: 22560 RVA: 0x00264558 File Offset: 0x00262758
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005821 RID: 22561 RVA: 0x00264564 File Offset: 0x00262764
	public cai()
	{
	}

	// Token: 0x06005822 RID: 22562 RVA: 0x00264570 File Offset: 0x00262770
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.a != null)
		{
			aud aud = null;
			if (this.b != null)
			{
				b4b serviceOrThrow = bpo.GetServiceOrThrow<b4b>();
				if (serviceOrThrow.yn() != null && serviceOrThrow.yn().Zones.Count > 0)
				{
					aud = serviceOrThrow.yn().Zones[0].n(this.b);
				}
			}
			else if (A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x = (new ar7(this.a.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			bvy aspect = c5x.GetAspect<bvy>();
			if (aspect != null)
			{
				aspect.c(this.c);
				aspect.d(this.d);
			}
		}
	}

	// Token: 0x0400238D RID: 9101
	private new Guid? a;

	// Token: 0x0400238E RID: 9102
	private string b;

	// Token: 0x0400238F RID: 9103
	private int c;

	// Token: 0x04002390 RID: 9104
	private int d;
}
