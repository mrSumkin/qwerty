using System;
using System.Runtime.Serialization;

// Token: 0x02000518 RID: 1304
[eiz("CIE")]
[Serializable]
public sealed class etm : bjs, b2h, ISerializable
{
	// Token: 0x06002196 RID: 8598 RVA: 0x000B3590 File Offset: 0x000B1790
	private etm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("CIE:EN");
			return;
		}
		if (base.GetType() == typeof(etm))
		{
			this.a = A_0.GetString("_EffectName");
			return;
		}
		this.a = A_0.GetString("CharacterImmuneEvent+_EffectName");
	}

	// Token: 0x06002197 RID: 8599 RVA: 0x000B3600 File Offset: 0x000B1800
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CIE:EN", this.a);
	}

	// Token: 0x06002198 RID: 8600 RVA: 0x000B361C File Offset: 0x000B181C
	public string c()
	{
		return this.a;
	}

	// Token: 0x06002199 RID: 8601 RVA: 0x000B3624 File Offset: 0x000B1824
	public etm(ap9 A_0, string A_1) : base(A_0, null)
	{
		this.a = A_1;
	}

	// Token: 0x0600219A RID: 8602 RVA: 0x000B3638 File Offset: 0x000B1838
	public ecs se()
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		dl.a.Add(new bph(bvm.a(adi.n), string.Format("- {0}: невосприимчивость к {1}.", (base.h() != null) ? base.h().a() : base.i(), this.a), null));
		return ecs;
	}

	// Token: 0x04001456 RID: 5206
	private new string a;
}
