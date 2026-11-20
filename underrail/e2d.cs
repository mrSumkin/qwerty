using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010F5 RID: 4341
[eiz("EDU0")]
[Serializable]
public sealed class e2d : cze, ISerializable
{
	// Token: 0x06005BEC RID: 23532 RVA: 0x0027699C File Offset: 0x00274B9C
	private e2d(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("EDU0:I", typeof(Guid?));
		this.c = A_0.GetString("EDU0:A");
		this.a = A_0.GetBoolean("EDU0:E");
	}

	// Token: 0x06005BED RID: 23533 RVA: 0x002769F4 File Offset: 0x00274BF4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("EDU0:I", this.b);
		info.AddValue("EDU0:A", this.c);
		info.AddValue("EDU0:E", this.a);
	}

	// Token: 0x06005BEE RID: 23534 RVA: 0x00276A44 File Offset: 0x00274C44
	public bool c()
	{
		return this.a;
	}

	// Token: 0x06005BEF RID: 23535 RVA: 0x00276A4C File Offset: 0x00274C4C
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005BF0 RID: 23536 RVA: 0x00276A58 File Offset: 0x00274C58
	public string a()
	{
		return this.c;
	}

	// Token: 0x06005BF1 RID: 23537 RVA: 0x00276A60 File Offset: 0x00274C60
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005BF2 RID: 23538 RVA: 0x00276A6C File Offset: 0x00274C6C
	public Guid? b()
	{
		return this.b;
	}

	// Token: 0x06005BF3 RID: 23539 RVA: 0x00276A74 File Offset: 0x00274C74
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005BF4 RID: 23540 RVA: 0x00276A80 File Offset: 0x00274C80
	public e2d()
	{
	}

	// Token: 0x06005BF5 RID: 23541 RVA: 0x00276A88 File Offset: 0x00274C88
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
			if (c5x != null && c5x.s.b != null)
			{
				c5x.s.b.g(this.a);
			}
		}
	}

	// Token: 0x040024B9 RID: 9401
	private new bool a;

	// Token: 0x040024BA RID: 9402
	private Guid? b;

	// Token: 0x040024BB RID: 9403
	private string c;
}
