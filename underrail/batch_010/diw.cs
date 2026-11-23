using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020004FF RID: 1279
[eiz("CIRE")]
[Serializable]
public sealed class diw : bjs, b2h, ISerializable
{
	// Token: 0x06002116 RID: 8470 RVA: 0x000B13F4 File Offset: 0x000AF5F4
	private diw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002117 RID: 8471 RVA: 0x000B1400 File Offset: 0x000AF600
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06002118 RID: 8472 RVA: 0x000B140C File Offset: 0x000AF60C
	public int d()
	{
		return this.a;
	}

	// Token: 0x06002119 RID: 8473 RVA: 0x000B1414 File Offset: 0x000AF614
	public int c()
	{
		return this.b;
	}

	// Token: 0x0600211A RID: 8474 RVA: 0x000B141C File Offset: 0x000AF61C
	public int e()
	{
		return this.c;
	}

	// Token: 0x0600211B RID: 8475 RVA: 0x000B1424 File Offset: 0x000AF624
	public diw(ap9 A_0, int A_1, int A_2, int A_3 = 0) : base(A_0, null)
	{
		this.a = A_1;
		this.b = A_2;
		this.c = A_3;
	}

	// Token: 0x0600211C RID: 8476 RVA: 0x000B1448 File Offset: 0x000AF648
	public ecs se()
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		string a_;
		if (this.c > 0)
		{
			a_ = string.Format("- {0} вступает в бой. Инициатива: {1} + {2} + {3} = {4}.", new object[]
			{
				(base.h() != null) ? base.h().a() : base.i(),
				this.a,
				this.b,
				this.c,
				this.a + this.b + this.c
			});
		}
		else if (this.c < 0)
		{
			a_ = string.Format("- {0} вступает в бой. Инициатива: {1} + {2} - {3} = {4}.", new object[]
			{
				(base.h() != null) ? base.h().a() : base.i(),
				this.a,
				this.b,
				Math.Abs(this.c),
				this.a + this.b + this.c
			});
		}
		else
		{
			a_ = string.Format("- {0} вступает в бой. Инициатива: {1} + {2} = {3}.", new object[]
			{
				(base.h() != null) ? base.h().a() : base.i(),
				this.a,
				this.b,
				this.a + this.b
			});
		}
		dl.a.Add(new bph(bvm.a(Color.White), a_, null));
		return ecs;
	}

	// Token: 0x0400143E RID: 5182
	private new int a;

	// Token: 0x0400143F RID: 5183
	private new int b;

	// Token: 0x04001440 RID: 5184
	private int c;
}
