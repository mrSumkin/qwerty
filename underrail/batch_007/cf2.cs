using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.CustomLogic.Data;

// Token: 0x02000AB5 RID: 2741
[eiz("SRTAJ")]
[Serializable]
public sealed class cf2 : cze, ISerializable
{
	// Token: 0x06004007 RID: 16391 RVA: 0x00184910 File Offset: 0x00182B10
	private cf2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (Guid)A_0.GetValue("SRTAJ:SBI", typeof(Guid));
			return;
		}
		if (base.GetType() == typeof(cf2))
		{
			this.a = (Guid)A_0.GetValue("_ShoothingBoothId", typeof(Guid));
			return;
		}
		this.a = (Guid)A_0.GetValue("ShootingRangeTargetAttackedJob+_ShoothingBoothId", typeof(Guid));
	}

	// Token: 0x06004008 RID: 16392 RVA: 0x001849AC File Offset: 0x00182BAC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SRTAJ:SBI", this.a);
	}

	// Token: 0x06004009 RID: 16393 RVA: 0x001849CC File Offset: 0x00182BCC
	public Guid a()
	{
		return this.a;
	}

	// Token: 0x0600400A RID: 16394 RVA: 0x001849D4 File Offset: 0x00182BD4
	public void a(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600400B RID: 16395 RVA: 0x001849E0 File Offset: 0x00182BE0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cwt cwt = A_2.SafeGet("attackResult", null);
		List<csk> list = A_2.SafeGet("damage", null);
		if (cwt != null)
		{
			b0b b0b = new ar7(this.a, A_1.Area).ao();
			if (b0b != null)
			{
				ShootingRangeConsoleData shootingRangeConsoleData = ShootingRangeConsoleData.ExtractFromEntity(b0b);
				if (shootingRangeConsoleData != null && shootingRangeConsoleData.SessionActive)
				{
					if (cwt.b)
					{
						ShootingRangeConsoleData shootingRangeConsoleData2 = shootingRangeConsoleData;
						int num = shootingRangeConsoleData2.Hits;
						shootingRangeConsoleData2.Hits = num + 1;
						if (list != null && list.Count > 0)
						{
							shootingRangeConsoleData.Damages.AddRange(list);
							return;
						}
					}
					else
					{
						ShootingRangeConsoleData shootingRangeConsoleData3 = shootingRangeConsoleData;
						int num = shootingRangeConsoleData3.Misses;
						shootingRangeConsoleData3.Misses = num + 1;
					}
				}
			}
		}
	}

	// Token: 0x04001BEA RID: 7146
	private new Guid a;
}
