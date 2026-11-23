using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001440 RID: 5184
[eiz("SA2")]
[Serializable]
public sealed class dto : c2e, ISerializable
{
	// Token: 0x06007495 RID: 29845 RVA: 0x0031733C File Offset: 0x0031553C
	private dto(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(dto);
		}
	}

	// Token: 0x06007496 RID: 29846 RVA: 0x00317368 File Offset: 0x00315568
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06007497 RID: 29847 RVA: 0x00317374 File Offset: 0x00315574
	public dto(amc A_0, amc A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007498 RID: 29848 RVA: 0x00317384 File Offset: 0x00315584
	protected override bool ap4()
	{
		if (base.ap4())
		{
			return true;
		}
		cd1 a_ = base.n().aa().Offense.u();
		bke bke = base.n().aa().Offense.u().TypedDefinition;
		if (bke != null && base.m().a8().j == cgy.b && base.m().a8().Area == base.n().a8().Area)
		{
			cwt cwt = euf.a(base.n().aa(), base.m().aa(), awq.b(base.n(), base.m(), null), 0.0, null, 1.0, null, true);
			ay7 ay = null;
			if (!string.IsNullOrEmpty(bke.b()))
			{
				ay = ckf.a(bke.b());
			}
			if (ay != null)
			{
				ay.pe(base.n(), base.m(), a_, cwt, bke.ak(), null, null);
			}
			else
			{
				awq.a(base.n(), base.m(), cwt, base.n().aa().Offense.u(), null);
			}
			return false;
		}
		return true;
	}

	// Token: 0x06007499 RID: 29849 RVA: 0x003174D0 File Offset: 0x003156D0
	protected override CharacterState tp()
	{
		bke bke = base.n().aa().Offense.u().TypedDefinition;
		CharacterState result;
		if (bke != null && !string.IsNullOrWhiteSpace(bke.ag()) && Enum.TryParse<CharacterState>(bke.ag(), out result))
		{
			return result;
		}
		if (base.n() != null && base.n().aa() != null && base.n().aa().Offense.u() != null && base.n().aa().Offense.u().TypedDefinition != null && string.IsNullOrEmpty(base.n().aa().Offense.u().TypedDefinition.ac()) && base.n().aa().Gear.l().Item != null && base.n().aa().Gear.l().Item.fu() != null && base.n().aa().Gear.l().Item.fu().a())
		{
			return CharacterState.Attack1;
		}
		if (dto.a.NextDouble() > 0.65)
		{
			return CharacterState.Attack2;
		}
		return CharacterState.Attack1;
	}

	// Token: 0x04002FA3 RID: 12195
	private new static Random a = new Random();
}
