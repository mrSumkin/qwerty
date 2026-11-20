using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010E7 RID: 4327
[eiz("SGOSJ")]
[Serializable]
public sealed class bnp : cze, ISerializable
{
	// Token: 0x06005B5D RID: 23389 RVA: 0x00274668 File Offset: 0x00272868
	private bnp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = (Guid?)A_0.GetValue("SGOSJ:I", typeof(Guid?));
		this.d = A_0.GetString("SGOSJ:A");
		this.a = A_0.GetBoolean("SGOSJ:E");
		this.b = A_0.GetBoolean("SGOSJ:R");
	}

	// Token: 0x06005B5E RID: 23390 RVA: 0x002746D0 File Offset: 0x002728D0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SGOSJ:I", this.c);
		info.AddValue("SGOSJ:A", this.d);
		info.AddValue("SGOSJ:E", this.a);
		info.AddValue("SGOSJ:R", this.b);
	}

	// Token: 0x06005B5F RID: 23391 RVA: 0x00274730 File Offset: 0x00272930
	public bool d()
	{
		return this.a;
	}

	// Token: 0x06005B60 RID: 23392 RVA: 0x00274738 File Offset: 0x00272938
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005B61 RID: 23393 RVA: 0x00274744 File Offset: 0x00272944
	public bool b()
	{
		return this.b;
	}

	// Token: 0x06005B62 RID: 23394 RVA: 0x0027474C File Offset: 0x0027294C
	public void b(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005B63 RID: 23395 RVA: 0x00274758 File Offset: 0x00272958
	public string a()
	{
		return this.d;
	}

	// Token: 0x06005B64 RID: 23396 RVA: 0x00274760 File Offset: 0x00272960
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005B65 RID: 23397 RVA: 0x0027476C File Offset: 0x0027296C
	public Guid? c()
	{
		return this.c;
	}

	// Token: 0x06005B66 RID: 23398 RVA: 0x00274774 File Offset: 0x00272974
	public void a(Guid? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005B67 RID: 23399 RVA: 0x00274780 File Offset: 0x00272980
	public bnp()
	{
	}

	// Token: 0x06005B68 RID: 23400 RVA: 0x0027478C File Offset: 0x0027298C
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.c != null)
		{
			aud aud = null;
			if (this.d != null)
			{
				aud = A_1.Zone.n(this.d);
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
		if (c5x != null)
		{
			d0c aspect = c5x.GetAspect<d0c>();
			if (aspect != null)
			{
				if (this.b)
				{
					aspect.a(null);
				}
				aspect.a(this.a);
			}
		}
	}

	// Token: 0x0400247F RID: 9343
	private new bool a;

	// Token: 0x04002480 RID: 9344
	private bool b;

	// Token: 0x04002481 RID: 9345
	private Guid? c;

	// Token: 0x04002482 RID: 9346
	private string d;
}
