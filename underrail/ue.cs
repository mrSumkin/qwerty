using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.CustomLogic.Data;

// Token: 0x02000AB4 RID: 2740
[eiz("SSRTSJ")]
[Serializable]
public sealed class ue : cze, ISerializable
{
	// Token: 0x06004002 RID: 16386 RVA: 0x00184790 File Offset: 0x00182990
	private ue(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetInt32("SSRTSJ:FX");
			return;
		}
		if (base.GetType() == typeof(ue))
		{
			this.a = A_0.GetInt32("_FrameX");
			return;
		}
		this.a = A_0.GetInt32("SetShootingRangeTargetStateJob+_FrameX");
	}

	// Token: 0x06004003 RID: 16387 RVA: 0x00184800 File Offset: 0x00182A00
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SSRTSJ:FX", this.a);
	}

	// Token: 0x06004004 RID: 16388 RVA: 0x0018481C File Offset: 0x00182A1C
	public int a()
	{
		return this.a;
	}

	// Token: 0x06004005 RID: 16389 RVA: 0x00184824 File Offset: 0x00182A24
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004006 RID: 16390 RVA: 0x00184830 File Offset: 0x00182A30
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		ShootingRangeConsoleData shootingRangeConsoleData = ShootingRangeConsoleData.ExtractFromEntity(A_1);
		if (shootingRangeConsoleData != null)
		{
			c5x c5x = new ar7(shootingRangeConsoleData.TargetEntityId, A_1.Area).ao() as c5x;
			if (c5x != null && c5x.o.b != null)
			{
				c5x.o.b.b = new Point(this.a, c5x.o.b.b.Y);
			}
			if (this.a == 0)
			{
				ejt ejt = Enumerable.FirstOrDefault<ejt>(bnx.a(c5x, "ShootingRangeTargetLightning"));
				if (ejt != null)
				{
					ejt.ig();
					return;
				}
			}
			else if (Enumerable.FirstOrDefault<ejt>(bnx.a(c5x, "ShootingRangeTargetLightning")) == null)
			{
				ah7 ah = c5x.Zone.i("ShootingRangeTargetLightning");
				if (ah != null)
				{
					ah.g().be(c5x);
				}
			}
		}
	}

	// Token: 0x04001BE9 RID: 7145
	private new int a;
}
