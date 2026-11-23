using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200106A RID: 4202
[eiz("STWJ")]
[Serializable]
public sealed class dgs : cze, ISerializable
{
	// Token: 0x0600576E RID: 22382 RVA: 0x00262974 File Offset: 0x00260B74
	private dgs(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("STWJ:I", typeof(Guid?));
		this.b = (Guid?)A_0.GetValue("STWJ:T", typeof(Guid?));
		this.c = A_0.GetString("STWJ:A");
	}

	// Token: 0x0600576F RID: 22383 RVA: 0x002629DC File Offset: 0x00260BDC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("STWJ:I", this.a);
		info.AddValue("STWJ:T", this.b);
		info.AddValue("STWJ:A", this.c);
	}

	// Token: 0x06005770 RID: 22384 RVA: 0x00262A30 File Offset: 0x00260C30
	public string b()
	{
		return this.c;
	}

	// Token: 0x06005771 RID: 22385 RVA: 0x00262A38 File Offset: 0x00260C38
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005772 RID: 22386 RVA: 0x00262A44 File Offset: 0x00260C44
	public Guid? a()
	{
		return this.a;
	}

	// Token: 0x06005773 RID: 22387 RVA: 0x00262A4C File Offset: 0x00260C4C
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005774 RID: 22388 RVA: 0x00262A58 File Offset: 0x00260C58
	public Guid? c()
	{
		return this.b;
	}

	// Token: 0x06005775 RID: 22389 RVA: 0x00262A60 File Offset: 0x00260C60
	public void b(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005776 RID: 22390 RVA: 0x00262A6C File Offset: 0x00260C6C
	public dgs()
	{
	}

	// Token: 0x06005777 RID: 22391 RVA: 0x00262A78 File Offset: 0x00260C78
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.a != null)
		{
			aud aud = null;
			if (this.c != null)
			{
				aud = A_1.Zone.n(this.c);
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
		c5x c5x2 = null;
		if (this.b != null)
		{
			aud aud2 = null;
			if (this.c != null)
			{
				aud2 = A_1.Zone.n(this.c);
			}
			else if (A_1 != null)
			{
				aud2 = A_1.Area;
			}
			if (aud2 != null)
			{
				c5x2 = (new ar7(this.b.Value, aud2).ao() as c5x);
			}
		}
		else
		{
			c5x2 = (A_0 as c5x);
		}
		if (c5x2 != null && c5x != null)
		{
			bdf aspect = c5x.GetAspect<bdf>();
			if (aspect != null)
			{
				aspect.r8(c5x2, false);
			}
		}
	}

	// Token: 0x04002362 RID: 9058
	private new Guid? a;

	// Token: 0x04002363 RID: 9059
	private Guid? b;

	// Token: 0x04002364 RID: 9060
	private string c;
}
