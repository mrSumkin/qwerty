using System;
using System.Runtime.Serialization;

// Token: 0x02000517 RID: 1303
[eiz("CEEE")]
[Serializable]
public sealed class bjq : bjs, b2h, ISerializable
{
	// Token: 0x06002191 RID: 8593 RVA: 0x000B3478 File Offset: 0x000B1678
	private bjq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("CEEE:EN");
			return;
		}
		if (base.GetType() == typeof(bjq))
		{
			this.a = A_0.GetString("_EffectName");
			return;
		}
		this.a = A_0.GetString("CharacterEvadesEffectEvent+_EffectName");
	}

	// Token: 0x06002192 RID: 8594 RVA: 0x000B34E8 File Offset: 0x000B16E8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CEEE:EN", this.a);
	}

	// Token: 0x06002193 RID: 8595 RVA: 0x000B3504 File Offset: 0x000B1704
	public string c()
	{
		return this.a;
	}

	// Token: 0x06002194 RID: 8596 RVA: 0x000B350C File Offset: 0x000B170C
	public bjq(ap9 A_0, ap9 A_1, string A_2) : base(A_0, A_1)
	{
		this.a = A_2;
	}

	// Token: 0x06002195 RID: 8597 RVA: 0x000B3520 File Offset: 0x000B1720
	public ecs se()
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		dl.a.Add(new bph(bvm.a(adi.o), string.Format("- {0} уворачивается от {1}.", (base.h() != null) ? base.h().a() : base.i(), this.a), null));
		return ecs;
	}

	// Token: 0x04001455 RID: 5205
	private new string a;
}
