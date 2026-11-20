using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x0200159B RID: 5531
[eiz("SASIA")]
[Serializable]
public sealed class dl : ad5, ISerializable
{
	// Token: 0x06007ABC RID: 31420 RVA: 0x00335D9C File Offset: 0x00333F9C
	private dl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		ell.a();
	}

	// Token: 0x06007ABD RID: 31421 RVA: 0x00335DAC File Offset: 0x00333FAC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06007ABE RID: 31422 RVA: 0x00335DB8 File Offset: 0x00333FB8
	protected override m7 d6()
	{
		return m7.a;
	}

	// Token: 0x06007ABF RID: 31423 RVA: 0x00335DC0 File Offset: 0x00333FC0
	public override int? tm()
	{
		int? result = base.tm();
		if (result != null || base.ab() <= 3)
		{
			return result;
		}
		int? primitivePropertyValue = base.e().b8().Offense.u().TypedDefinition.a7().GetPrimitivePropertyValue<int>("AfterAttackHoldPhase", null);
		if (primitivePropertyValue != null)
		{
			return new int?(primitivePropertyValue.Value);
		}
		return new int?(0);
	}

	// Token: 0x06007AC0 RID: 31424 RVA: 0x00335E40 File Offset: 0x00334040
	public override CharacterState? q1()
	{
		CharacterState? result = base.q1();
		if (!(base.e().p() is eua) && result == null && base.ab() > 3)
		{
			return new CharacterState?(CharacterState.Attack1);
		}
		return result;
	}

	// Token: 0x06007AC1 RID: 31425 RVA: 0x00335E8C File Offset: 0x0033408C
	public dl(eu7 A_0, c5x A_1, object A_2) : base(A_0, A_1, A_2, false)
	{
	}

	// Token: 0x06007AC2 RID: 31426 RVA: 0x00335E98 File Offset: 0x00334098
	public override pl d7()
	{
		return new bn4(this);
	}

	// Token: 0x06007AC3 RID: 31427 RVA: 0x00335EA0 File Offset: 0x003340A0
	public override boa d8(afq A_0, params evd[] A_1)
	{
		return new ev9(this, A_0, A_1);
	}

	// Token: 0x06007AC4 RID: 31428 RVA: 0x00335EAC File Offset: 0x003340AC
	public override cst d9(dqw A_0)
	{
		if (dz6.e() && !(A_0 is blr))
		{
			awx awx = new awx();
			if (base.e().b8().Offense.u().TypedDefinition.e() == btz.k)
			{
				awx.ad().Add(new a4s(new bfq("Minigun_motor"), null, new ar7(base.q()), null));
			}
			int? primitivePropertyValue = base.e().b8().Offense.u().TypedDefinition.a7().GetPrimitivePropertyValue<int>("RaiseWeaponAnimationPhaseStep", null);
			e4t item = new e4t(base.q().h.b, CharacterState.RaiseWeapon, dz6.b((primitivePropertyValue != null) ? primitivePropertyValue.Value : cux.k), 0, null, 1);
			awx.ad().Add(item);
			return awx;
		}
		return null;
	}

	// Token: 0x06007AC5 RID: 31429 RVA: 0x00335FA8 File Offset: 0x003341A8
	public override List<cst> ea(dqw A_0)
	{
		if (dz6.e())
		{
			List<cst> list = new List<cst>();
			int? primitivePropertyValue = base.e().b8().Offense.u().TypedDefinition.a7().GetPrimitivePropertyValue<int>("LowerWeaponAnimationPhaseStep", null);
			string classPropertyValue = base.e().b8().Offense.u().TypedDefinition.a7().GetClassPropertyValue<string>("LowerWeaponSound");
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				list.Add(new a4s(new bfq(classPropertyValue), null, new ar7(base.q()), null));
			}
			e4t item = new e4t(base.q().h.b, CharacterState.LowerWeapon, dz6.b((primitivePropertyValue != null) ? primitivePropertyValue.Value : cux.k), 0, null, 1);
			list.Add(item);
			return list;
		}
		return null;
	}

	// Token: 0x06007AC6 RID: 31430 RVA: 0x0033609C File Offset: 0x0033429C
	protected override c47 eb()
	{
		return new dq0(new ap9(base.e().b8()), base.e().p().Name, base.e().p().Nature);
	}

	// Token: 0x06007AC7 RID: 31431 RVA: 0x003360E0 File Offset: 0x003342E0
	protected override c47 ec()
	{
		return new bv(new ap9(base.e().b8()), base.e().p().Name, base.e().p().Nature);
	}
}
