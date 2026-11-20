using System;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;

// Token: 0x020012C9 RID: 4809
[eiz("QCS")]
[Serializable]
public sealed class b2x : Aspect<c5x>, ISerializable
{
	// Token: 0x06006A2E RID: 27182 RVA: 0x002CC290 File Offset: 0x002CA490
	private b2x(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 590)
		{
			this.a = A_0.GetString("QCS:D");
		}
	}

	// Token: 0x06006A2F RID: 27183 RVA: 0x002CC2BC File Offset: 0x002CA4BC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("QCS:D", this.a);
	}

	// Token: 0x06006A30 RID: 27184 RVA: 0x002CC2D8 File Offset: 0x002CA4D8
	public b2x(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006A31 RID: 27185 RVA: 0x002CC2E4 File Offset: 0x002CA4E4
	public bool a()
	{
		return base.a8() != null && base.a8().o.b != null && base.a8().o.b.b.Y == 0;
	}

	// Token: 0x06006A32 RID: 27186 RVA: 0x002CC330 File Offset: 0x002CA530
	public bool b(c5x A_0)
	{
		if (!this.a() && base.a8() != null)
		{
			ak1 ak = Enumerable.FirstOrDefault<ak1>(base.a8().l);
			if (ak != null && !ak.Formation.c(2L) && ak.f(null) == 0L)
			{
				if (base.a8().o.b != null)
				{
					base.a8().o.b.b = new Point(base.a8().o.b.b.X, 0);
				}
				b2x.a(base.a8());
			}
			return true;
		}
		return false;
	}

	// Token: 0x06006A33 RID: 27187 RVA: 0x002CC3E0 File Offset: 0x002CA5E0
	public static void a(c5x A_0)
	{
		bky bky = new bky(A_0);
		bky.Location = A_0.Location.a();
		bky.Size = new esj(1, 1);
		bky.TriggeringRadius = new double?(0.55);
		bky.Layer = aju.x;
		A_0.Area.b(bky);
	}

	// Token: 0x04002BA8 RID: 11176
	public string a;
}
