using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000A78 RID: 2680
[eiz("TTICJ")]
[Serializable]
public sealed class cb5 : cze, ISerializable
{
	// Token: 0x06003F1E RID: 16158 RVA: 0x0017E1A0 File Offset: 0x0017C3A0
	private cb5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("TTICJ:I", typeof(Guid));
	}

	// Token: 0x06003F1F RID: 16159 RVA: 0x0017E1CC File Offset: 0x0017C3CC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TTICJ:I", this.a);
	}

	// Token: 0x06003F20 RID: 16160 RVA: 0x0017E1EC File Offset: 0x0017C3EC
	public Guid a()
	{
		return this.a;
	}

	// Token: 0x06003F21 RID: 16161 RVA: 0x0017E1F4 File Offset: 0x0017C3F4
	public void a(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003F22 RID: 16162 RVA: 0x0017E200 File Offset: 0x0017C400
	public cb5()
	{
	}

	// Token: 0x06003F23 RID: 16163 RVA: 0x0017E20C File Offset: 0x0017C40C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null && A_0.Area != null)
		{
			dy8 dy = new EntityAspectReference<dy8, dy8>(A_0.Area, this.a).ao();
			if (dy != null)
			{
				dy.h();
			}
		}
	}

	// Token: 0x04001BD0 RID: 7120
	private new Guid a;
}
