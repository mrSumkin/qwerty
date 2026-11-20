using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020012EC RID: 4844
[eiz("OVSA")]
[Serializable]
public sealed class dbm : pa, ISerializable
{
	// Token: 0x06006B9C RID: 27548 RVA: 0x002D32A8 File Offset: 0x002D14A8
	private dbm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 73)
		{
			this.a = (amn)A_0.GetValue("OVSA:T", typeof(amn));
		}
	}

	// Token: 0x06006B9D RID: 27549 RVA: 0x002D32E0 File Offset: 0x002D14E0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("OVSA:T", this.a);
	}

	// Token: 0x06006B9E RID: 27550 RVA: 0x002D3300 File Offset: 0x002D1500
	public amn a()
	{
		return this.a;
	}

	// Token: 0x06006B9F RID: 27551 RVA: 0x002D3308 File Offset: 0x002D1508
	public void a(amn A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006BA0 RID: 27552 RVA: 0x002D3314 File Offset: 0x002D1514
	public dbm(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006BA1 RID: 27553 RVA: 0x002D3320 File Offset: 0x002D1520
	protected override void ajy()
	{
		try
		{
			if (base.m())
			{
				if (this.a == amn.c)
				{
					base.a8().o.b.b = new Point(1, base.a8().o.b.b.Y);
				}
				else
				{
					base.a8().o.b.a = "Objects\\WallDecorations\\VentilationShaft-Open";
					if (this.a == amn.a)
					{
						base.a8().o.b.f = 1f;
					}
					else
					{
						base.a8().o.b.f = 0.6f;
					}
				}
			}
			else if (this.a == amn.c)
			{
				base.a8().o.b.b = new Point(0, base.a8().o.b.b.Y);
			}
			else if (this.a == amn.a)
			{
				base.a8().o.b.a = "Objects\\WallDecorations\\VentilationShaft";
			}
			else
			{
				base.a8().o.b.a = "Objects\\WallDecorations\\VentilationShaft-Dark";
			}
		}
		catch
		{
		}
	}

	// Token: 0x04002C29 RID: 11305
	private new amn a;
}
