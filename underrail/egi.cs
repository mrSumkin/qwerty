using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.CustomLogic.Data;

// Token: 0x02000AB3 RID: 2739
[eiz("MSRTJ")]
[Serializable]
public sealed class egi : cze, ISerializable
{
	// Token: 0x06003FFD RID: 16381 RVA: 0x00184634 File Offset: 0x00182834
	private egi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetInt32("MSRTJ:D");
			return;
		}
		if (base.GetType() == typeof(egi))
		{
			this.a = A_0.GetInt32("_Distance");
			return;
		}
		this.a = A_0.GetInt32("MoveShootingRangeTargetJob+_Distance");
	}

	// Token: 0x06003FFE RID: 16382 RVA: 0x001846A4 File Offset: 0x001828A4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MSRTJ:D", this.a);
	}

	// Token: 0x06003FFF RID: 16383 RVA: 0x001846C0 File Offset: 0x001828C0
	public int a()
	{
		return this.a;
	}

	// Token: 0x06004000 RID: 16384 RVA: 0x001846C8 File Offset: 0x001828C8
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004001 RID: 16385 RVA: 0x001846D4 File Offset: 0x001828D4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			ShootingRangeConsoleData shootingRangeConsoleData = ShootingRangeConsoleData.ExtractFromEntity(A_1);
			if (shootingRangeConsoleData != null)
			{
				c5x c5x = new ar7(shootingRangeConsoleData.TargetEntityId, A_1.Area).ao() as c5x;
				if (c5x != null && c5x.i.b != null && c5x.j.b != null)
				{
					cy6 a_ = new cy6(c5x.j.b, new Vector3((float)shootingRangeConsoleData.ShootingBootLocation.X, (float)(shootingRangeConsoleData.ShootingBootLocation.Y - this.a), 0f), null, m7.b | m7.e);
					c5x.i.b.a(a_, atp.a, true, false);
				}
			}
		}
	}

	// Token: 0x04001BE8 RID: 7144
	private new int a;
}
