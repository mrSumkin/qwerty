using System;
using System.Runtime.Serialization;

// Token: 0x0200050F RID: 1295
[eiz("CREE")]
[Serializable]
public sealed class c6f : bjs, b2h, ISerializable
{
	// Token: 0x06002161 RID: 8545 RVA: 0x000B2498 File Offset: 0x000B0698
	private c6f(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("CREE:EN");
			return;
		}
		if (base.GetType() == typeof(c6f))
		{
			this.a = A_0.GetString("_EffectName");
			return;
		}
		this.a = A_0.GetString("CharacterResistsEffectEvent+_EffectName");
	}

	// Token: 0x06002162 RID: 8546 RVA: 0x000B2508 File Offset: 0x000B0708
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CREE:EN", this.a);
	}

	// Token: 0x06002163 RID: 8547 RVA: 0x000B2524 File Offset: 0x000B0724
	public string c()
	{
		return this.a;
	}

	// Token: 0x06002164 RID: 8548 RVA: 0x000B252C File Offset: 0x000B072C
	public c6f(ap9 A_0, ap9 A_1, string A_2) : base(A_0, A_1)
	{
		this.a = A_2;
	}

	// Token: 0x06002165 RID: 8549 RVA: 0x000B2540 File Offset: 0x000B0740
	public ecs se()
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		dl.a.Add(new bph(bvm.a(adi.o), string.Format("- {0} сопротивляется {1}.", (base.h() != null) ? base.h().a() : base.i(), this.a), null));
		return ecs;
	}

	// Token: 0x0400144A RID: 5194
	private new string a;
}
