using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000B50 RID: 2896
[eiz("DCPPRGCJ")]
[Serializable]
public sealed class dwf : cze, ISerializable
{
	// Token: 0x06004271 RID: 17009 RVA: 0x0019C4EC File Offset: 0x0019A6EC
	private dwf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("DCPPRGCJ:G", typeof(Guid));
		this.c = (Rectangle)A_0.GetValue("DCPPRGCJ:Z", typeof(Rectangle));
		this.b = (Rectangle)A_0.GetValue("DCPPRGCJ:E", typeof(Rectangle));
	}

	// Token: 0x06004272 RID: 17010 RVA: 0x0019C564 File Offset: 0x0019A764
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DCPPRGCJ:G", this.a);
		info.AddValue("DCPPRGCJ:Z", this.c);
		info.AddValue("DCPPRGCJ:E", this.b);
	}

	// Token: 0x06004273 RID: 17011 RVA: 0x0019C5BC File Offset: 0x0019A7BC
	public Guid b()
	{
		return this.a;
	}

	// Token: 0x06004274 RID: 17012 RVA: 0x0019C5C4 File Offset: 0x0019A7C4
	public void a(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004275 RID: 17013 RVA: 0x0019C5D0 File Offset: 0x0019A7D0
	public Rectangle a()
	{
		return this.b;
	}

	// Token: 0x06004276 RID: 17014 RVA: 0x0019C5D8 File Offset: 0x0019A7D8
	public void a(Rectangle A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06004277 RID: 17015 RVA: 0x0019C5E4 File Offset: 0x0019A7E4
	public Rectangle c()
	{
		return this.c;
	}

	// Token: 0x06004278 RID: 17016 RVA: 0x0019C5EC File Offset: 0x0019A7EC
	public void b(Rectangle A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06004279 RID: 17017 RVA: 0x0019C5F8 File Offset: 0x0019A7F8
	public dwf()
	{
	}

	// Token: 0x0600427A RID: 17018 RVA: 0x0019C604 File Offset: 0x0019A804
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.Area != null && A_1.Zone != null)
		{
			c5x c5x = new ar7(this.a, A_1.Area).ao() as c5x;
			if (c5x != null && c5x.o.b != null && c5x.i.b != null)
			{
				bool flag = this.a(A_1.Area, this.c);
				bool flag2 = this.a(A_1.Area, this.b);
				if (flag)
				{
					if (c5x.o.b.b.X != 3 && (c5x.i.b.a() == null || c5x.i.b.a().Name == "close"))
					{
						b6x b6x = new b6x();
						b6x.c().Add(this.a);
						b6x.a(A_1.Area.y8());
						b6x.a(bbo.b);
						b6x.ym(null, A_1, null);
						return;
					}
				}
				else if (!flag2 && c5x.o.b.b.X != 0 && (c5x.i.b.a() == null || c5x.i.b.a().Name == "open"))
				{
					b6x b6x2 = new b6x();
					b6x2.c().Add(this.a);
					b6x2.a(A_1.Area.y8());
					b6x2.a(bbo.c);
					b6x2.ym(null, A_1, null);
				}
			}
		}
	}

	// Token: 0x0600427B RID: 17019 RVA: 0x0019C7B4 File Offset: 0x0019A9B4
	private bool a(aud A_0, Rectangle A_1)
	{
		for (int i = A_1.X; i <= A_1.X + A_1.Width; i++)
		{
			for (int j = A_1.Y; j <= A_1.Y + A_1.Height; j++)
			{
				ak1 ak = A_0.b(i, j);
				if (ak != null)
				{
					foreach (b0b b0b in ak.c.Values)
					{
						c5x c5x = (c5x)b0b;
						if (c5x.h.b != null && !c5x.h.b.aa().Passive)
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x04001C26 RID: 7206
	private new Guid a;

	// Token: 0x04001C27 RID: 7207
	private Rectangle b;

	// Token: 0x04001C28 RID: 7208
	private Rectangle c;
}
