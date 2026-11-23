using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020010C0 RID: 4288
[eiz("SSEF1")]
[Serializable]
public sealed class af6 : cze, ISerializable
{
	// Token: 0x06005A1E RID: 23070 RVA: 0x0026E2E0 File Offset: 0x0026C4E0
	private af6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = (Guid?)A_0.GetValue("SSEF1:I", typeof(Guid?));
		this.d = A_0.GetString("SSEF1:A");
		if (ell.a() >= 233)
		{
			this.a = (Point)A_0.GetValue("SSEF1:F", typeof(Point));
			this.b = A_0.GetBoolean("SSEF1:SF");
		}
	}

	// Token: 0x06005A1F RID: 23071 RVA: 0x0026E368 File Offset: 0x0026C568
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SSEF1:I", this.c);
		info.AddValue("SSEF1:A", this.d);
		info.AddValue("SSEF1:F", this.a);
		info.AddValue("SSEF1:SF", this.b);
	}

	// Token: 0x06005A20 RID: 23072 RVA: 0x0026E3CC File Offset: 0x0026C5CC
	public Point d()
	{
		return this.a;
	}

	// Token: 0x06005A21 RID: 23073 RVA: 0x0026E3D4 File Offset: 0x0026C5D4
	public void a(Point A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005A22 RID: 23074 RVA: 0x0026E3E0 File Offset: 0x0026C5E0
	public bool b()
	{
		return this.b;
	}

	// Token: 0x06005A23 RID: 23075 RVA: 0x0026E3E8 File Offset: 0x0026C5E8
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005A24 RID: 23076 RVA: 0x0026E3F4 File Offset: 0x0026C5F4
	public string a()
	{
		return this.d;
	}

	// Token: 0x06005A25 RID: 23077 RVA: 0x0026E3FC File Offset: 0x0026C5FC
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005A26 RID: 23078 RVA: 0x0026E408 File Offset: 0x0026C608
	public Guid? c()
	{
		return this.c;
	}

	// Token: 0x06005A27 RID: 23079 RVA: 0x0026E410 File Offset: 0x0026C610
	public void a(Guid? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005A28 RID: 23080 RVA: 0x0026E41C File Offset: 0x0026C61C
	public af6()
	{
	}

	// Token: 0x06005A29 RID: 23081 RVA: 0x0026E428 File Offset: 0x0026C628
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
		if (c5x != null)
		{
			cd0 aspect = c5x.GetAspect<cd0>();
			if (aspect != null)
			{
				aspect.b = this.a;
			}
		}
	}

	// Token: 0x04002420 RID: 9248
	private new Point a;

	// Token: 0x04002421 RID: 9249
	private bool b;

	// Token: 0x04002422 RID: 9250
	private Guid? c;

	// Token: 0x04002423 RID: 9251
	private string d;
}
