using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001364 RID: 4964
[eiz("HEA")]
[Serializable]
public abstract class cpl : b1z, bs8, ISerializable
{
	// Token: 0x06007090 RID: 28816 RVA: 0x002F4788 File Offset: 0x002F2988
	protected cpl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("HEA:AR", typeof(EntityAspectReference<amc, amc>));
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("HEA:TR", typeof(EntityAspectReference<amc, amc>));
			this.c = (edm)A_0.GetValue("HEA:HER", typeof(edm));
			this.d = (cwt)A_0.GetValue("HEA:OAR", typeof(cwt));
			if (ell.a() >= 262)
			{
				this.e = (cru)A_0.GetValue("HEA:S", typeof(cru));
			}
			if (ell.a() >= 470)
			{
				this.f = (A_0.GetValue("HEA:L", typeof(bt4)) as bt4);
			}
			if (ell.a() >= 531)
			{
				this.g = (A_0.GetValue("HEA:W", typeof(cd1)) as cd1);
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(cpl))
			{
				this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("_AttackerRef", typeof(EntityAspectReference<amc, amc>));
				this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("_TargetRef", typeof(EntityAspectReference<amc, amc>));
				this.c = (edm)A_0.GetValue("_HitEffectRef", typeof(edm));
				this.d = (cwt)A_0.GetValue("_OriginalAttackResult", typeof(cwt));
				return;
			}
			this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("HitEffectAction+_AttackerRef", typeof(EntityAspectReference<amc, amc>));
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("HitEffectAction+_TargetRef", typeof(EntityAspectReference<amc, amc>));
			this.c = (edm)A_0.GetValue("HitEffectAction+_HitEffectRef", typeof(edm));
			this.d = (cwt)A_0.GetValue("HitEffectAction+_OriginalAttackResult", typeof(cwt));
		}
	}

	// Token: 0x06007091 RID: 28817 RVA: 0x002F49D0 File Offset: 0x002F2BD0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("HEA:AR", this.a);
		info.AddValue("HEA:TR", this.b);
		info.AddValue("HEA:HER", this.c);
		info.AddValue("HEA:OAR", this.d);
		info.AddValue("HEA:S", this.e);
		info.AddValue("HEA:L", this.f);
		info.AddValue("HEA:W", this.g);
	}

	// Token: 0x06007092 RID: 28818 RVA: 0x002F4A5C File Offset: 0x002F2C5C
	public EntityAspectReference<amc, amc> agq()
	{
		return this.a;
	}

	// Token: 0x06007093 RID: 28819 RVA: 0x002F4A64 File Offset: 0x002F2C64
	public void agr(EntityAspectReference<amc, amc> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06007094 RID: 28820 RVA: 0x002F4A70 File Offset: 0x002F2C70
	public EntityAspectReference<amc, amc> ags()
	{
		return this.b;
	}

	// Token: 0x06007095 RID: 28821 RVA: 0x002F4A78 File Offset: 0x002F2C78
	public void agt(EntityAspectReference<amc, amc> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06007096 RID: 28822 RVA: 0x002F4A84 File Offset: 0x002F2C84
	public edm agu()
	{
		return this.c;
	}

	// Token: 0x06007097 RID: 28823 RVA: 0x002F4A8C File Offset: 0x002F2C8C
	public void agv(edm A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06007098 RID: 28824 RVA: 0x002F4A98 File Offset: 0x002F2C98
	public cwt agw()
	{
		return this.d;
	}

	// Token: 0x06007099 RID: 28825 RVA: 0x002F4AA0 File Offset: 0x002F2CA0
	public void agx(cwt A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600709A RID: 28826 RVA: 0x002F4AAC File Offset: 0x002F2CAC
	public cru agy()
	{
		return this.e;
	}

	// Token: 0x0600709B RID: 28827 RVA: 0x002F4AB4 File Offset: 0x002F2CB4
	public void agz(cru A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600709C RID: 28828 RVA: 0x002F4AC0 File Offset: 0x002F2CC0
	public amc a()
	{
		if (this.a != null)
		{
			return this.a.ao();
		}
		return null;
	}

	// Token: 0x0600709D RID: 28829 RVA: 0x002F4ADC File Offset: 0x002F2CDC
	public amc b()
	{
		if (this.b != null)
		{
			return this.b.ao();
		}
		return null;
	}

	// Token: 0x0600709E RID: 28830 RVA: 0x002F4AF8 File Offset: 0x002F2CF8
	public bt4 ag0()
	{
		return this.f;
	}

	// Token: 0x0600709F RID: 28831 RVA: 0x002F4B00 File Offset: 0x002F2D00
	public void ag1(bt4 A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060070A0 RID: 28832 RVA: 0x002F4B0C File Offset: 0x002F2D0C
	public cd1 ag2()
	{
		return this.g;
	}

	// Token: 0x060070A1 RID: 28833 RVA: 0x002F4B14 File Offset: 0x002F2D14
	public void ag3(cd1 A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060070A2 RID: 28834 RVA: 0x002F4B20 File Offset: 0x002F2D20
	protected cpl()
	{
	}

	// Token: 0x060070A3 RID: 28835 RVA: 0x002F4B28 File Offset: 0x002F2D28
	protected static void a(cwt A_0, cwt A_1)
	{
		A_1.z = A_0.z;
		A_1.ae = A_0.ae;
		A_1.af = A_0.af;
		cpl.a(A_0, A_1, "IsBurst");
	}

	// Token: 0x060070A4 RID: 28836 RVA: 0x002F4B60 File Offset: 0x002F2D60
	protected cd1 c()
	{
		if (this.g != null)
		{
			return this.g;
		}
		if (this.a() != null && this.a().aa() != null)
		{
			return this.a().aa().Offense.u();
		}
		return null;
	}

	// Token: 0x060070A5 RID: 28837 RVA: 0x002F4BB4 File Offset: 0x002F2DB4
	private static void a(cwt A_0, cwt A_1, string A_2)
	{
		object propertyValue = A_0.ad.GetPropertyValue(A_2);
		if (propertyValue != null)
		{
			A_1.ad[A_2] = propertyValue;
		}
	}

	// Token: 0x04002E0F RID: 11791
	private new EntityAspectReference<amc, amc> a;

	// Token: 0x04002E10 RID: 11792
	private EntityAspectReference<amc, amc> b;

	// Token: 0x04002E11 RID: 11793
	private edm c;

	// Token: 0x04002E12 RID: 11794
	private cwt d;

	// Token: 0x04002E13 RID: 11795
	private cru e;

	// Token: 0x04002E14 RID: 11796
	private bt4 f;

	// Token: 0x04002E15 RID: 11797
	private cd1 g;
}
