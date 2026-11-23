using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200134E RID: 4942
[eiz("MVAX")]
[Serializable]
public sealed class kp : b1z, ISerializable
{
	// Token: 0x06006FD9 RID: 28633 RVA: 0x002EE9E0 File Offset: 0x002ECBE0
	private kp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("MVAX:V", typeof(EntityAspectReference<wv, bim>)) as EntityAspectReference<wv, bim>);
		this.b = (A_0.GetValue("MVAX:D", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
	}

	// Token: 0x06006FDA RID: 28634 RVA: 0x002EEA38 File Offset: 0x002ECC38
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MVAX:V", this.a);
		info.AddValue("MVAX:D", this.b);
	}

	// Token: 0x06006FDB RID: 28635 RVA: 0x002EEA64 File Offset: 0x002ECC64
	public kp(wv A_0, amc A_1)
	{
		this.a = new EntityAspectReference<wv, bim>(A_0);
		this.b = new EntityAspectReference<amc, amc>(A_1);
	}

	// Token: 0x06006FDC RID: 28636 RVA: 0x002EEA88 File Offset: 0x002ECC88
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.b != null && this.b.ao() != null && this.b.ao().a8() != null && this.a != null && this.a.ao() != null && this.a.ao().a8() != null)
		{
			bdf aspect = this.a.ao().a8().GetAspect<bdf>();
			if (aspect != null && aspect.f() != null)
			{
				aspect.r9(false);
			}
			ar7 classPropertyValue = this.b.ao().a8().d().a().GetClassPropertyValue<ar7>(bah.c);
			if (classPropertyValue != null && classPropertyValue.ao() != null)
			{
				bdf aspect2 = classPropertyValue.ao().GetAspect<bdf>();
				if (aspect2 != null && aspect2.f() != null && aspect2.f().ao() == this.b.ao().a8())
				{
					aspect2.r9(false);
				}
			}
			this.b.ao().a(this.a.ao().g());
			c5x c5x = this.a.ao().a8();
			c3g aspect3 = c5x.GetAspect<c3g>();
			this.b.ao().aa().Vehicle.l().Clear();
			if (aspect3 != null)
			{
				this.b.ao().aa().Vehicle.l().AddRange(aspect3.d());
				this.b.ao().aa().Vehicle.l().AddRange(aspect3.b());
			}
			d2b aspect4 = c5x.GetAspect<d2b>();
			if (aspect4 != null)
			{
				this.b.ao().aa().Vehicle.b(aspect4.g());
				this.b.ao().aa().Vehicle.f(aspect4.p());
			}
			else
			{
				this.b.ao().aa().Vehicle.b(null);
				this.b.ao().aa().Vehicle.f(0);
			}
			this.b.ao().a8().Location = this.a.ao().a8().Location;
			this.b.ao().a8().VisualDirection = this.a.ao().a8().VisualDirection;
			this.b.ao().a8().ah();
			this.a.ao().a8().w();
			this.a.ao().a8().an();
			if (!this.b.ao().aa().SpecialAbilities.a(typeof(d5e)))
			{
				this.b.ao().aa().SpecialAbilities.b(dgk.Get<d5e>());
			}
			foreach (WeaponKey key in new WeaponKey[]
			{
				WeaponKey.Primary,
				WeaponKey.Secondary
			})
			{
				cd1 cd = this.b.ao().aa().Gear.j()[key].Value as cd1;
				if (!euf.a(this.b.ao().aa().Vehicle, cd))
				{
					this.b.ao().aa().Bag.z3(cd, true);
					this.b.ao().aa().Gear.j()[key].a(null, true);
					if (this.b.ao().aa() is e3q)
					{
						this.b.ao().aa().CustomProperties["vehicleRidingWeaponUnequipped_" + key.ToString()] = cd.Id;
					}
				}
			}
			this.b.ao().aa().Vehicle.k();
			this.b.ao().aa().bl();
			if (dz6.e())
			{
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					d4n d4n = service.ahu(this.b.ao().aa());
					if (d4n != null && service.ahe() == d4n)
					{
						d4n.d = (double)(d4n.b.aa().Offense.m() / 2);
					}
				}
			}
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x04002DAB RID: 11691
	private new EntityAspectReference<wv, bim> a;

	// Token: 0x04002DAC RID: 11692
	private EntityAspectReference<amc, amc> b;
}
