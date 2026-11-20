using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200141B RID: 5147
[eiz("ST0")]
[Serializable]
public sealed class cw : dvv, ISerializable
{
	// Token: 0x0600737A RID: 29562 RVA: 0x0030AB90 File Offset: 0x00308D90
	private cw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (ar7)A_0.GetValue("ST0:T", typeof(ar7));
	}

	// Token: 0x0600737B RID: 29563 RVA: 0x0030ABBC File Offset: 0x00308DBC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ST0:T", this.a);
	}

	// Token: 0x0600737C RID: 29564 RVA: 0x0030ABD8 File Offset: 0x00308DD8
	public cw(c5x A_0)
	{
		this.a = new ar7(A_0);
	}

	// Token: 0x0600737D RID: 29565 RVA: 0x0030ABEC File Offset: 0x00308DEC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a != null)
		{
			c5x c5x = this.a.ao() as c5x;
			if (c5x != null && c5x.p.b != null && c5x.p.b.a.Count >= 2)
			{
				ed2 ed = c5x.r.b as ed2;
				c5x.p.b.a[1] = new cd0(c5x)
				{
					a = c5x.p.b.a[0].a,
					b = new Point(c5x.p.b.a[0].b.X + 2, c5x.p.b.a[0].b.Y),
					c = new Color?((ed != null) ? ed.h : Color.Red)
				};
			}
		}
		return dc4.c;
	}

	// Token: 0x04002F37 RID: 12087
	private new ar7 a;
}
