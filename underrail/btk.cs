using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001435 RID: 5173
[eiz("AAA")]
[Serializable]
public sealed class btk : awx, ISerializable, evp
{
	// Token: 0x060073FA RID: 29690 RVA: 0x003111CC File Offset: 0x0030F3CC
	private btk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("AAA:AR", typeof(EntityAspectReference<amc, amc>));
			this.c = (EntityAspectReference<amc, amc>)A_0.GetValue("AAA:TR", typeof(EntityAspectReference<amc, amc>));
			this.d = A_0.GetBoolean("AAA:A");
			this.a = (c2e)A_0.GetValue("AAA:W", typeof(c2e));
			if (ell.a() >= 521)
			{
				this.e = (A_0.GetValue("AAA:AP", typeof(int?)) as int?);
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(btk))
			{
				this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("_AttackerRef", typeof(EntityAspectReference<amc, amc>));
				this.c = (EntityAspectReference<amc, amc>)A_0.GetValue("_TargetRef", typeof(EntityAspectReference<amc, amc>));
				this.d = A_0.GetBoolean("_Attacked");
				return;
			}
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("AutoAttackAction+_AttackerRef", typeof(EntityAspectReference<amc, amc>));
			this.c = (EntityAspectReference<amc, amc>)A_0.GetValue("AutoAttackAction+_TargetRef", typeof(EntityAspectReference<amc, amc>));
			this.d = A_0.GetBoolean("AutoAttackAction+_Attacked");
		}
	}

	// Token: 0x060073FB RID: 29691 RVA: 0x00311350 File Offset: 0x0030F550
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("AAA:AR", this.b);
		info.AddValue("AAA:TR", this.c);
		info.AddValue("AAA:A", this.d);
		info.AddValue("AAA:W", this.a);
		info.AddValue("AAA:AP", this.e);
	}

	// Token: 0x060073FC RID: 29692 RVA: 0x003113C0 File Offset: 0x0030F5C0
	private amc c()
	{
		return this.b.ao();
	}

	// Token: 0x060073FD RID: 29693 RVA: 0x003113D0 File Offset: 0x0030F5D0
	private amc b()
	{
		return this.c.ao();
	}

	// Token: 0x060073FE RID: 29694 RVA: 0x003113E0 File Offset: 0x0030F5E0
	public override int? tm()
	{
		int? result = base.tm();
		if (result == null && this.d)
		{
			return new int?(this.e.GetValueOrDefault());
		}
		return result;
	}

	// Token: 0x060073FF RID: 29695 RVA: 0x00311420 File Offset: 0x0030F620
	public override CharacterState? q1()
	{
		CharacterState? result = base.q1();
		if (result == null && this.d && this.a != null)
		{
			return new CharacterState?(CharacterState.Attack1);
		}
		return result;
	}

	// Token: 0x06007400 RID: 29696 RVA: 0x00311460 File Offset: 0x0030F660
	public sealed override object fm()
	{
		if (this.b() != null)
		{
			return this.b().a8();
		}
		return null;
	}

	// Token: 0x06007401 RID: 29697 RVA: 0x0031147C File Offset: 0x0030F67C
	public sealed override ci8? oi()
	{
		return new ci8?(ci8.c);
	}

	// Token: 0x06007402 RID: 29698 RVA: 0x00311484 File Offset: 0x0030F684
	public btk(amc A_0, amc A_1)
	{
		czh.a(A_0, "attacker");
		czh.a(A_1, "target");
		this.b = new EntityAspectReference<amc, amc>(A_0);
		this.c = new EntityAspectReference<amc, amc>(A_1);
		base.a(m7.b | m7.d);
		if (this.b() != null)
		{
			this.a();
		}
	}

	// Token: 0x06007403 RID: 29699 RVA: 0x003114E0 File Offset: 0x0030F6E0
	public new bool sp()
	{
		return base.y() != null && base.aa() == this.a && base.y().hd(this, atp.a) && base.a(0);
	}

	// Token: 0x06007404 RID: 29700 RVA: 0x0031152C File Offset: 0x0030F72C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		return base.fr(A_0, A_1);
	}

	// Token: 0x06007405 RID: 29701 RVA: 0x00311538 File Offset: 0x0030F738
	private new void a()
	{
		bke bke = this.c().aa().Offense.u().TypedDefinition;
		ale ale = this.c().a8().k.b;
		this.d = false;
		if (ale != null)
		{
			if (bke.ad() == as3.bk)
			{
				fk fk = new fk(ale, this.b().a8(), null, false, bke.ah());
				fk.l();
				base.ad().Add(fk);
			}
			else
			{
				e1i e1i = new e1i(ale, this.b().a8(), bke.ad());
				e1i.a(awq.a(bke));
				e1i.l();
				base.ad().Add(e1i);
			}
		}
		else
		{
			dsr dsr = new dsr(this.c().a8(), this.b().a8(), bke.ad());
			dsr.a(awq.a(bke));
			base.ad().Add(dsr);
		}
		if (bke.e() == btz.g)
		{
			this.a = new dto(this.c(), this.b());
		}
		else
		{
			this.a = new a13(this.c(), this.b());
		}
		this.a.t(new EventHandler<EventArgs>(this.a));
		bool flag = this.b.ao().a8().IsPlayer;
		bool flag2 = dz6.e();
		bool flag3 = this.a.l();
		bool value = bke.a7().GetPrimitivePropertyValue<bool>("DisableRaiseLowerAnim", new bool?(false)).Value;
		this.e = bke.a7().GetPrimitivePropertyValue<int>("AfterAttackHoldPhase", null);
		dkf dkf = null;
		if (!string.IsNullOrEmpty(bke.b()))
		{
			dkf = (ckf.a(bke.b()) as dkf);
		}
		if ((flag || (flag2 && flag3)) && !value && (dkf == null || !dkf.pf(this.c())))
		{
			int? primitivePropertyValue = bke.a7().GetPrimitivePropertyValue<int>("RaiseWeaponAnimationPhaseStep", null);
			e4t item = new e4t(this.c().a8().h.b, CharacterState.RaiseWeapon, dz6.b((primitivePropertyValue != null) ? primitivePropertyValue.Value : cux.k), 0, null, 1);
			base.ad().Add(item);
		}
		base.ad().Add(this.a);
		if ((flag || (flag2 && flag3)) && !value && (dkf == null || !dkf.pg(this.c())))
		{
			int? primitivePropertyValue2 = bke.a7().GetPrimitivePropertyValue<int>("LowerWeaponAnimationPhaseStep", null);
			string classPropertyValue = bke.a7().GetClassPropertyValue<string>("LowerWeaponSound");
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				base.ad().Add(new a4s(new bfq(classPropertyValue), null, new ar7(this.c().a8()), null));
			}
			e4t item2 = new e4t(this.c().a8().h.b, CharacterState.LowerWeapon, dz6.b((primitivePropertyValue2 != null) ? primitivePropertyValue2.Value : cux.k), 0, null, 1);
			base.ad().Add(item2);
		}
	}

	// Token: 0x06007406 RID: 29702 RVA: 0x003118C4 File Offset: 0x0030FAC4
	[dcc("AAA:mUWA_I")]
	private new void a(object A_0, EventArgs A_1)
	{
		this.d = true;
		this.a.u(new EventHandler<EventArgs>(this.a));
	}

	// Token: 0x04002F6A RID: 12138
	private new c2e a;

	// Token: 0x04002F6B RID: 12139
	private EntityAspectReference<amc, amc> b;

	// Token: 0x04002F6C RID: 12140
	private EntityAspectReference<amc, amc> c;

	// Token: 0x04002F6D RID: 12141
	private bool d;

	// Token: 0x04002F6E RID: 12142
	private int? e;
}
