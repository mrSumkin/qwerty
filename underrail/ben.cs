using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x02001453 RID: 5203
[eiz("SSEAFA")]
[Serializable]
public sealed class ben : b1z, ISerializable
{
	// Token: 0x06007512 RID: 29970 RVA: 0x0031A0B4 File Offset: 0x003182B4
	private ben(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (EntityAspectReference<cd0, cd0>)A_0.GetValue("SSEAFA:SEAR", typeof(EntityAspectReference<cd0, cd0>));
			this.b = (Point)A_0.GetValue("SSEAFA:F", typeof(Point));
			return;
		}
		if (base.GetType() == typeof(ben))
		{
			this.a = (EntityAspectReference<cd0, cd0>)A_0.GetValue("_SimpleEntityAspectRef", typeof(EntityAspectReference<cd0, cd0>));
			this.b = (Point)A_0.GetValue("_Frame", typeof(Point));
			return;
		}
		this.a = (EntityAspectReference<cd0, cd0>)A_0.GetValue("SetSimpleEntityAspectFrameAction+_SimpleEntityAspectRef", typeof(EntityAspectReference<cd0, cd0>));
		this.b = (Point)A_0.GetValue("SetSimpleEntityAspectFrameAction+_Frame", typeof(Point));
	}

	// Token: 0x06007513 RID: 29971 RVA: 0x0031A1B0 File Offset: 0x003183B0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SSEAFA:SEAR", this.a);
		info.AddValue("SSEAFA:F", this.b);
	}

	// Token: 0x06007514 RID: 29972 RVA: 0x0031A1E4 File Offset: 0x003183E4
	private cd0 a()
	{
		if (this.a != null)
		{
			return this.a.ao();
		}
		return null;
	}

	// Token: 0x06007515 RID: 29973 RVA: 0x0031A200 File Offset: 0x00318400
	public ben(cd0 A_0, Point A_1)
	{
		this.a = new EntityAspectReference<cd0, cd0>(A_0);
		this.b = A_1;
	}

	// Token: 0x06007516 RID: 29974 RVA: 0x0031A21C File Offset: 0x0031841C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a() != null)
		{
			this.a().b = this.b;
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x04002FF5 RID: 12277
	private new EntityAspectReference<cd0, cd0> a;

	// Token: 0x04002FF6 RID: 12278
	private Point b;
}
