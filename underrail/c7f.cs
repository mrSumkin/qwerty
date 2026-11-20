using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020010D2 RID: 4306
[eiz("SECJ")]
[Serializable]
public sealed class c7f : cze
{
	// Token: 0x06005ABE RID: 23230 RVA: 0x00271B88 File Offset: 0x0026FD88
	private c7f(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Point)A_0.GetValue("SECJ:O", typeof(Point));
		if (ell.a() >= 225)
		{
			this.b = (Guid?)A_0.GetValue("SECJ:I", typeof(Guid?));
			this.c = A_0.GetString("SECJ:A");
		}
	}

	// Token: 0x06005ABF RID: 23231 RVA: 0x00271C00 File Offset: 0x0026FE00
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SECJ:O", this.a);
		info.AddValue("SECJ:I", this.b);
		info.AddValue("SECJ:A", this.c);
	}

	// Token: 0x06005AC0 RID: 23232 RVA: 0x00271C54 File Offset: 0x0026FE54
	public Point a()
	{
		return this.a;
	}

	// Token: 0x06005AC1 RID: 23233 RVA: 0x00271C5C File Offset: 0x0026FE5C
	public void a(Point A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005AC2 RID: 23234 RVA: 0x00271C68 File Offset: 0x0026FE68
	public string b()
	{
		return this.c;
	}

	// Token: 0x06005AC3 RID: 23235 RVA: 0x00271C70 File Offset: 0x0026FE70
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005AC4 RID: 23236 RVA: 0x00271C7C File Offset: 0x0026FE7C
	public Guid? c()
	{
		return this.b;
	}

	// Token: 0x06005AC5 RID: 23237 RVA: 0x00271C84 File Offset: 0x0026FE84
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005AC6 RID: 23238 RVA: 0x00271C90 File Offset: 0x0026FE90
	public c7f()
	{
	}

	// Token: 0x06005AC7 RID: 23239 RVA: 0x00271C9C File Offset: 0x0026FE9C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (A_1 != null && A_1.Area != null)
		{
			c5x = (A_1 as c5x);
		}
		else if (A_0 != null && A_0.Area != null)
		{
			c5x = (A_0 as c5x);
		}
		if (c5x != null)
		{
			c5x c5x2 = null;
			if (this.b != null)
			{
				aud aud = null;
				if (this.c != null)
				{
					aud = c5x.Zone.n(this.c);
				}
				else if (c5x != null)
				{
					aud = c5x.Area;
				}
				if (aud != null)
				{
					c5x2 = (new ar7(this.b.Value, aud).ao() as c5x);
				}
			}
			else
			{
				c5x2 = c5x;
			}
			if (c5x2 != null && c5x2.Area != null)
			{
				bkt.a(c5x2);
				bkt.a(c5x2.Area, this.a, c5x2);
			}
		}
	}

	// Token: 0x0400244D RID: 9293
	private new Point a;

	// Token: 0x0400244E RID: 9294
	private Guid? b;

	// Token: 0x0400244F RID: 9295
	private string c;
}
