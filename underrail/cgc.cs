using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000F8E RID: 3982
[a(typeof(dy8))]
[eiz("EFICEA")]
[Serializable]
public sealed class cgc : dy8
{
	// Token: 0x0600514A RID: 20810 RVA: 0x00249A90 File Offset: 0x00247C90
	private cgc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Rectangle)A_0.GetValue("EFICEA:F", typeof(Rectangle));
		di7.ReadList<Guid>("EFICEA:D", ref this.a, A_0);
	}

	// Token: 0x0600514B RID: 20811 RVA: 0x00249AE4 File Offset: 0x00247CE4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("EFICEA:F", this.b);
		di7.WriteList<Guid>("EFICEA:D", this.a, info);
	}

	// Token: 0x0600514C RID: 20812 RVA: 0x00249B18 File Offset: 0x00247D18
	public List<Guid> a()
	{
		return this.a;
	}

	// Token: 0x0600514D RID: 20813 RVA: 0x00249B20 File Offset: 0x00247D20
	public void a(List<Guid> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600514E RID: 20814 RVA: 0x00249B2C File Offset: 0x00247D2C
	public Rectangle b()
	{
		return this.b;
	}

	// Token: 0x0600514F RID: 20815 RVA: 0x00249B34 File Offset: 0x00247D34
	public void a(Rectangle A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005150 RID: 20816 RVA: 0x00249B40 File Offset: 0x00247D40
	public cgc(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06005151 RID: 20817 RVA: 0x00249B54 File Offset: 0x00247D54
	protected override void o2()
	{
		base.g(this.a);
		c48 c = new c48();
		c.a(true);
		c.a(new Point(this.b.X, this.b.Y));
		c.b(new Point(this.b.X + this.b.Width - 1, this.b.Y + this.b.Height - 1));
		c.ym(null, base.a8(), null);
	}

	// Token: 0x06005152 RID: 20818 RVA: 0x00249BE4 File Offset: 0x00247DE4
	protected override void o3()
	{
		base.h(this.a);
		c48 c = new c48();
		c.a(false);
		c.a(new Point(this.b.X, this.b.Y));
		c.b(new Point(this.b.X + this.b.Width - 1, this.b.Y + this.b.Height - 1));
		c.ym(null, base.a8(), null);
	}

	// Token: 0x06005153 RID: 20819 RVA: 0x00249C74 File Offset: 0x00247E74
	protected override void o4()
	{
	}

	// Token: 0x04002151 RID: 8529
	private List<Guid> a = new List<Guid>();

	// Token: 0x04002152 RID: 8530
	private Rectangle b;
}
