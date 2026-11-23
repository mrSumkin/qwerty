using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200104C RID: 4172
[eiz("SPEASJ")]
[Serializable]
public sealed class b7e : cze, ISerializable
{
	// Token: 0x0600566F RID: 22127 RVA: 0x0025F0D0 File Offset: 0x0025D2D0
	private b7e(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("SPEASJ:I", typeof(Guid?));
		this.c = A_0.GetString("SPEASJ:A");
		this.a = A_0.GetBoolean("SPEASJ:E");
	}

	// Token: 0x06005670 RID: 22128 RVA: 0x0025F128 File Offset: 0x0025D328
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SPEASJ:I", this.b);
		info.AddValue("SPEASJ:A", this.c);
		info.AddValue("SPEASJ:E", this.a);
	}

	// Token: 0x06005671 RID: 22129 RVA: 0x0025F178 File Offset: 0x0025D378
	public bool c()
	{
		return this.a;
	}

	// Token: 0x06005672 RID: 22130 RVA: 0x0025F180 File Offset: 0x0025D380
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005673 RID: 22131 RVA: 0x0025F18C File Offset: 0x0025D38C
	public string a()
	{
		return this.c;
	}

	// Token: 0x06005674 RID: 22132 RVA: 0x0025F194 File Offset: 0x0025D394
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005675 RID: 22133 RVA: 0x0025F1A0 File Offset: 0x0025D3A0
	public Guid? b()
	{
		return this.b;
	}

	// Token: 0x06005676 RID: 22134 RVA: 0x0025F1A8 File Offset: 0x0025D3A8
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005677 RID: 22135 RVA: 0x0025F1B4 File Offset: 0x0025D3B4
	public b7e()
	{
	}

	// Token: 0x06005678 RID: 22136 RVA: 0x0025F1BC File Offset: 0x0025D3BC
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		c1a c1a = null;
		if (A_0 != null)
		{
			c1a = A_0.Zone;
		}
		if (c1a == null && A_1 != null)
		{
			c1a = A_1.Zone;
		}
		if (c1a != null)
		{
			if (this.b != null)
			{
				aud aud = null;
				if (this.c != null)
				{
					aud = c1a.n(this.c);
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
				epo aspect = c5x.GetAspect<epo>();
				if (aspect != null)
				{
					aspect.b(this.a);
				}
			}
		}
	}

	// Token: 0x04002310 RID: 8976
	private new bool a;

	// Token: 0x04002311 RID: 8977
	private Guid? b;

	// Token: 0x04002312 RID: 8978
	private string c;
}
