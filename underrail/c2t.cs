using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001037 RID: 4151
[eiz("CSFJ")]
[Serializable]
public sealed class c2t : cze
{
	// Token: 0x060055B9 RID: 21945 RVA: 0x0025CB64 File Offset: 0x0025AD64
	private c2t(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("CSFJ:I", typeof(Guid?));
		this.b = A_0.GetString("CSFJ:A");
		this.c = A_0.GetString("CSFJ:TF");
	}

	// Token: 0x060055BA RID: 21946 RVA: 0x0025CBBC File Offset: 0x0025ADBC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CSFJ:I", this.a);
		info.AddValue("CSFJ:A", this.b);
		info.AddValue("CSFJ:TF", this.c);
	}

	// Token: 0x060055BB RID: 21947 RVA: 0x0025CC0C File Offset: 0x0025AE0C
	public string a()
	{
		return this.b;
	}

	// Token: 0x060055BC RID: 21948 RVA: 0x0025CC14 File Offset: 0x0025AE14
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060055BD RID: 21949 RVA: 0x0025CC20 File Offset: 0x0025AE20
	public Guid? b()
	{
		return this.a;
	}

	// Token: 0x060055BE RID: 21950 RVA: 0x0025CC28 File Offset: 0x0025AE28
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060055BF RID: 21951 RVA: 0x0025CC34 File Offset: 0x0025AE34
	public string c()
	{
		return this.c;
	}

	// Token: 0x060055C0 RID: 21952 RVA: 0x0025CC3C File Offset: 0x0025AE3C
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060055C1 RID: 21953 RVA: 0x0025CC48 File Offset: 0x0025AE48
	public c2t()
	{
	}

	// Token: 0x060055C2 RID: 21954 RVA: 0x0025CC50 File Offset: 0x0025AE50
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		b0b b0b = A_0 ?? A_1;
		c5x c5x = null;
		if (this.a != null && b0b != null)
		{
			aud aud = null;
			if (this.b != null)
			{
				aud = b0b.Zone.n(this.b);
			}
			else if (A_1 != null)
			{
				aud = b0b.Area;
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
			dg2 aspect = c5x.GetAspect<dg2>();
			if (aspect != null && this.c != null)
			{
				aspect.a(this.c);
			}
		}
	}

	// Token: 0x040022DB RID: 8923
	private new Guid? a;

	// Token: 0x040022DC RID: 8924
	private string b;

	// Token: 0x040022DD RID: 8925
	private string c;
}
